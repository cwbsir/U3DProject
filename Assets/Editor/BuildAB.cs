using System.IO;
using UnityEditor;
using UnityEngine;

public class BuildAB : MonoBehaviour
{
    [MenuItem("MyTools/Build AssetBundles")]
    public static void BuildAllAssetBundles()
    {
        Debug.Log("BuildAllAssetBundles");
        string assetBundleDirectory = "Assets/StreamingAssets";
        if (!Directory.Exists(assetBundleDirectory))
        {
            Directory.CreateDirectory(assetBundleDirectory);
        }
        
        BuildPipeline.BuildAssetBundles(assetBundleDirectory, BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows64);
    }

    [MenuItem("MyTools/生成ImportClient.lua")]
    public static void BuildImportClient()
    {
        System.Diagnostics.Process proc = new System.Diagnostics.Process();
        proc.StartInfo.FileName = Application.dataPath + "/../Tools/ImportClient.bat";
        proc.StartInfo.CreateNoWindow = true;
        proc.Start();
        proc.WaitForExit();

        Debug.Log("!!!!!!!ImportClient.lua重新生成成功!!!!!!!!!!!");
    }
}
