using System;
using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using System.Globalization;
using System.Collections.Generic;


class PSD2UI : MonoBehaviour
{	
	public static string curBaseAssetsDir = "";
	public static string texturePackerTempPath = "Assets/TMP/";

	[MenuItem("MyTools/PSD 转为 Prefab")]
	public static void PSD2Prefab()
	{
		//返回选中文件的绝对路径
		string inputFile = EditorUtility.OpenFilePanel("Choose PSDUI File to Import", Application.dataPath+"/Resources/PSD/PSD/", "psd");
		Debug.Log("inputFile:"+inputFile);
		if ((inputFile != null) && (inputFile != ""))
		{
			string psdName = inputFile.Split('/')[inputFile.Split('/').Length - 1];

			string dirName = Path.GetFileNameWithoutExtension(psdName);
			dirName = dirName.Split('_')[dirName.Split('_').Length - 1];

			string outPath = PSDConst.PSD_OUT_PATH + dirName + "/";
			PSD2Json(inputFile, outPath);

			Json2Prefab(outPath,dirName);
		}
		GC.Collect();

				// 删除临时文件夹
		if (Directory.Exists (PSD2UI.texturePackerTempPath)) {
			Directory.Delete(PSD2UI.texturePackerTempPath,true);
		}

		Debug.Log("###########执行命令结束###########");
	}

	[MenuItem("MyTools/打common图集")]
	public static void BuildCommonUI()
	{
		PSD2Json(PSDConst.UI_COMMON_PATH,PSDConst.PSD_OUT_PATH+"UICommon/");
		string jsonPath = PSDConst.PSD_OUT_PATH + "UICommon/";
		Json2Prefab(jsonPath,"UICommon");

		string prefabPath = PSDConst.GUI_PATH + "UICommon/"+ "UICommonPrefab.prefab";
		if(File.Exists(prefabPath))
		{
			File.Delete(prefabPath);
		}
		Debug.Log("###########common图集成功打完###########");
	}


	// [MenuItem("MyTools/PSD 转为 json")] 
	public static void PSD2Json(string psdFile,string outPath)
	{	
		// if(!PSD2UI.isMD5Change(psdFile))
		// {
		// 	return;
		// }
		Debug.Log("PSD2Json psdFile："+psdFile+",outPath"+outPath);
		// TODO 执行psd工具的命令.具体的拷贝 `plist.bat` 里面执行的命令
    	string cmd = String.Format("\"{0}\" -o \"{1}\" -s -v", psdFile, outPath);
   		// 执行cmd命令
   		TerminalManager.cmd(PSDConst.Psd2UI_EXE_PATH, cmd);
	}


	public static void Json2Prefab(string outPath,string dirName)
	{

		string[] jsonPaths = Directory.GetFiles(outPath, "*.json", SearchOption.AllDirectories);
		 

		List<Model> modelList = new List<Model>();

		 foreach (string jsonPath in jsonPaths)
		 {
			// if(!PSD2UI.isMD5Change(jsonPath))
			// {
			// 	continue;
			// }
			StreamReader jsonReader = File.OpenText(jsonPath);
			if (jsonReader != null) 
			{
				string jsonStr = jsonReader.ReadToEnd();
				Model model = JsonUtility.FromJson<Model> (jsonStr);
				modelList.Add(model);
			}
		 }

		if(modelList.Count <= 0){ return; }

        PSD2UI.curBaseAssetsDir = outPath;
		
		for (var i = 0; i < modelList.Count; i++)
		{
			var model = modelList[i];

			for (var j = model.children.Length - 1; j>= 0; j--) 
			{
				oneCopyImgToTmpPath(model.children[j],dirName);
			}
		}
		copyImgToTmpPathFromPNGExport(dirName);


		//打包临时文件的图集
		Debug.Log("######开始打图集######");
		string srcPath = PSD2UI.texturePackerTempPath + dirName;
		string tarPath = PSDConst.GUI_PATH + dirName + "/" + dirName + ".png";
		AtlasManager.InitAtlasForTextureP(srcPath,tarPath);

		Debug.Log("######图集打完，开始加载UI######");
		string path1 = PSDConst.GetPrefabPathByName("Canvas");
		Canvas temp1 = AssetDatabase.LoadAssetAtPath(path1, typeof(Canvas)) as Canvas;
		// 实例化显示prefab（要另外用个对象保存避免被释放）
		Canvas canvas = GameObject.Instantiate (temp1) as Canvas;
	

		for (var i = 0; i < modelList.Count; i++)
		{
			var model = modelList[i];
			string path3 = PSDConst.GetPrefabPathByName("GameObject");
			GameObject temp = AssetDatabase.LoadAssetAtPath(path3,typeof(GameObject)) as GameObject;
			GameObject gameobj = GameObject.Instantiate(temp) as GameObject;
			gameobj.name = model.name+"Prefab";
			gameobj.transform.SetParent(canvas.gameObject.transform,false);
			RectTransform rect = gameobj.GetComponent<RectTransform>();
			// 总预设锚点再左上角(父锚点，锚点)
			Vector2 anchorP = PSDConst.PIVOTPOINT1;
			rect.anchorMin = anchorP;
			rect.anchorMax = anchorP;
			rect.pivot = anchorP; 
			rect.offsetMin = new Vector2 (0.0f,0.0f);
			rect.offsetMax = new Vector2 (0.0f,0.0f);
			rect.sizeDelta = new Vector2 (model.options.width,model.options.height);
			for (int j = model.children.Length - 1; j >= 0; j--) 
			{

				initComponent(model.children[j],gameobj,dirName);
			}

			string prefabPath = PSDConst.GUI_PATH + dirName + "/" + model.name +"Prefab.prefab";
			Debug.Log("######创建预设:"+prefabPath+"######");
			PrefabUtility.CreatePrefab(prefabPath, gameobj, ReplacePrefabOptions.ReplaceNameBased);
		}


		SetAssetBundleName();
		BuildAB.BuildAllAssetBundles();

		AssetDatabase.Refresh();
	}

	private static void oneCopyImgToTmpPath(Children child,string fileName = "")
	{
		if (child.classname == "IMAGE") 
		{
			string[] link_split = child.options.link.Split ('#');
			string rootPath = (link_split.Length > 0) ? (link_split[0]) : "";
			string imgPath = (link_split.Length > 0) ? link_split[link_split.Length - 1] : "";

			string atlasName = "rootPath" + "_" + Path.GetFileNameWithoutExtension(imgPath);

			Sprite sprite = null;
			// 先到公共图集中查询是否有该图片
			if (File.Exists (PSDConst.ATLAS_PATH_COMMON)) {
				sprite = AtlasManager.getSpriteForTextureP (PSDConst.ATLAS_PATH_COMMON, atlasName);
			}

			if(sprite == null)
			{
				//复制到临时文件夹，给打包图集用
				string tmpDir = PSD2UI.texturePackerTempPath + fileName + "/";
				string singleImg = PSD2UI.curBaseAssetsDir + rootPath + "/" + imgPath;
				string tarSingleImg = tmpDir + imgPath;
				string saveTempDir = Directory.GetParent (tarSingleImg).FullName;
				Debug.Log ("###tarImg:"+tarSingleImg);
				Debug.Log ("###saveDir:"+saveTempDir);
				if (!Directory.Exists (saveTempDir)) {
					Directory.CreateDirectory (saveTempDir);
				}
				if ((!File.Exists (tarSingleImg)) && (!Directory.Exists(tarSingleImg))) {
					File.Copy (singleImg,tarSingleImg);
				}
			}
		}
		if (child.children.Length > 0) {
			for (int i = child.children.Length - 1; i >= 0; i--) {
				oneCopyImgToTmpPath(child.children[i], fileName);
			}
		}
	}

    private static void copyImgToTmpPathFromPNGExport(string rootName)
    {
        string pngExportPath = PSD2UI.curBaseAssetsDir + rootName + "/PNGExport";
        string tmpDir = PSD2UI.texturePackerTempPath + rootName;
        if (Directory.Exists(pngExportPath))
        {
			if (!Directory.Exists (pngExportPath)) {
				return;
			}
			if (!Directory.Exists (tmpDir)) {
				Directory.CreateDirectory (tmpDir);
			}
			string[] srcFiles = Directory.GetFiles (pngExportPath,"*",SearchOption.AllDirectories);
			foreach (string srcFile in srcFiles) {
				// 生成拷贝的目录结构
				string tarFile = srcFile.Replace (pngExportPath,tmpDir);
				string tarFileParent = Path.GetDirectoryName (tarFile);
				if (!Directory.Exists (tarFileParent)) {
					Directory.CreateDirectory (tarFileParent);
				}
				if (!File.Exists (tarFile)) {
					File.Copy (srcFile,tarFile);
				}
			}
			AssetDatabase.Refresh ();
        }
    }


	private static void initComponent(Children child,GameObject parentObj,string fileName = "")
	{	
		var propStr = child.options.property;
		var props = propStr.Split('\r');
		var prop = new Property ();
		prop.DeserializeProperty (props);

		GameObject tempObj = null;
		GameObject childObj = null;

		if ((child.classname == "LABEL") && (!prop.isInput)) {
			childObj = TextComponent.InitTextComponent (child, parentObj);
		}
		else if ((child.classname == "LABEL") && (prop.isInput)) {
			childObj = TextFieldComponent.InitTextFieldComponent (child, parentObj);
		}
		else if (child.classname == "IMAGE") {
			childObj = ImageComponent.InitImageComponent (child, parentObj, fileName);
		}
		else if (child.classname == "GROUP") {
			childObj = RectComponent.InitRectComponent (child, parentObj);
		}
		else if (child.classname == "LIST") {
			childObj = ScrollComponent.InitComponent (child,parentObj);
		}

		if ((child.children.Length > 0) && (childObj != null)) {
			for (int i = child.children.Length - 1; i >= 0; i--) {
				initComponent(child.children [i], childObj, fileName);
			}
		}
	}
	// [MenuItem("MyTools/设置所有资源的AB名")]
	public static void SetAssetBundleName()
	{
		string path = Application.dataPath + "/Resources";
        if (Directory.Exists(path))
        {
            var dir = new DirectoryInfo(path);
            var files = dir.GetFiles("*", SearchOption.AllDirectories);
            for (var i = 0; i < files.Length; ++i)
            {
                FileInfo info = files[i];
                setSingleAssetBundleName(info.FullName, info.Name);
            }
        }
        AssetDatabase.RemoveUnusedAssetBundleNames();
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
	}

	public static void setSingleAssetBundleName(string path,string fileName)
	{
		if (path.EndsWith(".meta")) return;
        int subIndex = path.IndexOf("\\Assets");
        string basePath = path.Substring(subIndex + 1);
        string sub = "\\Resources";
        int nameIndex = basePath.IndexOf(sub);
        AssetImporter importer = AssetImporter.GetAtPath(basePath);

        if (importer == null) { return; }

        string name = basePath.Substring(nameIndex + sub.Length + 1);
        string abName = string.Empty;
        string sourceFileName = fileName;
        int index = 0;
        fileName = fileName.ToLower();
        if (fileName.EndsWith(".ttf"))
        {
            //字体，按"font$" + 文件名 +".u"打包
            abName = "font.u";
        }
        else if (name.StartsWith("GUI\\"))
        {
            name = name.Substring(4);
            index = name.IndexOf("\\");
            abName = name.Substring(0, index) + ".u";
        }
        else if (name.StartsWith("OutPic\\"))
        {
            abName = fileName+".u";
        }
        else if (name.StartsWith("Shader\\"))
        {
            //Shader，全部文件打成一个包shader.u
            abName = "shader.u";
        }
        else
        {
        	return;
        }
        if (importer.assetBundleName != abName)
        {
           importer.assetBundleName = abName;
        }
	}


	//filePath为绝对路径
	public static bool isMD5Change(string filePath)
	{
        string md5 = PSDUtils.GetMD5HashFromFile(filePath);
        string fileName = filePath.Split('/')[filePath.Split('/').Length - 1];
        // 保存的md5值
        string saveFileMd5 = PSDUtils.GetMd5FromFileArray(PSDConst.MD5_PATH, fileName);
       	if(saveFileMd5 != md5)
       	{
       		PSDUtils.SaveMd5FromFileArray(PSDConst.MD5_PATH, fileName, md5);
       		return true;
       	}
        return false;
	}
}