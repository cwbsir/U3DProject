StartController = class("StartController");

function StartController:startLoad()

	
	print("Application.dataPath",UnityEngine.Application.dataPath);
	print("Application.temporaryCachePath",UnityEngine.Application.temporaryCachePath);
	print("Application.streamingAssetsPath",UnityEngine.Application.streamingAssetsPath);
	print("Application.persistentDataPath",UnityEngine.Application.persistentDataPath);

	globalManager.loaderManager:loadAsset(UnityEngine.Application.dataPath.."/AssetBundles/".."uiprefabs.u",self.loadComplete,self);
end

function StartController:initCommonPrefab(abContent)

	local prefabList = abContent:LoadAllAssets(typeof(UnityEngine.GameObject));
	local destList = {};
	if(prefabList == nil)then return destList; end;
	local len = prefabList.Length - 1;
	print("StartController:initCommonPrefab",len);
	for i = 0,len,1 do
		local prefab = prefabList[i];
		print("prefab.name",prefab.name);
		destList[prefab.name] = prefab;
	end
	return destList;
end

function StartController:loadComplete(abName,assetName,abcontent)
	-- globalData.defaultFont = abcontent:LoadAsset("Asterix-Blink.ttf");
	-- print(typeof(globalData.defaultFont));
	-- local destList = self:initCommonPrefab(abcontent);
	--  = destList["Asterix-Blink.ttf"];
	self:startGame();
end

function StartController:startGame()
	print("startGame");

	local label = globalManager.kCreator:createLabel();
	label:setPosition(50,-50);
	label:setString("hello,cwbsir!!");
	label:setParent(globalManager.uiManager.mainTransform);

	-- local image = globalManager.kCreator:createImage();
	-- image:setSize(100,100);
	-- image:setPath("bg.jpg");
	-- image:setPosition(globalManager.uiManager.PANEL_WIDTH/2,-globalManager.uiManager.PANEL_HEIGHT/2);
	-- image:setParent(globalManager.uiManager.mainTransform);
end