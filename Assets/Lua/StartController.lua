StartController = class("StartController");

function StartController:startLoad()

	
	print("Application.dataPath",UnityEngine.Application.dataPath);
	print("Application.temporaryCachePath",UnityEngine.Application.temporaryCachePath);
	print("Application.streamingAssetsPath",UnityEngine.Application.streamingAssetsPath);
	print("Application.persistentDataPath",UnityEngine.Application.persistentDataPath);

	self:loadUIPrefabs();
end

function StartController:loadUIPrefabs()
	globalManager.loaderManager:loadAsset("uiprefabs.u",self.loadUIPrefabsComplete,self);
end

function StartController:loadUIPrefabsComplete(abName,assetName,abcontent)
	globalData.uiPrefabs = parseABContent(abcontent);
	self:startGame();
end

function StartController:loadComplete(abName,assetName,abcontent)
	-- globalData.defaultFont = abcontent:LoadAsset("Asterix-Blink.ttf");
	-- print(typeof(globalData.defaultFont));
	local destList = parseABContent(abcontent);
	--  = destList["Asterix-Blink.ttf"];
	-- abcontent:LoadAsset("Text.prefab");
	self:startGame();
end

function StartController:startGame()
	print("startGame");

	local image = globalManager.kCreator:createImage();	image:setPath("bg.jpg");
	image:setPosition(globalManager.uiManager.PANEL_WIDTH/2,-globalManager.uiManager.PANEL_HEIGHT/2);
	image:addTouchCallBack(self.btnClickHandler,self);
	image:setParent(globalManager.uiManager.mainTransform);

	local label = globalManager.kCreator:createLabel();
	label:setPosition(50,-50);
	label:setString("hello,cwbsir!!");
	label:setParent(globalManager.uiManager.mainTransform);
end

function StartController:btnClickHandler(sender)
	print("StartController:btnClickHandlerStartController:btnClickHandler");
end