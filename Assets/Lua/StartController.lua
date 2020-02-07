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
	
	for k,v in pairs(globalData.uiPrefabs) do
		print("uiPrefabs:",k);
	end
	globalManager.loaderManager:loadAsset("font.u",self.loadFontComplete,self);
end

function StartController:loadFontComplete(abName,assetName,abcontent)
	globalData.defaultFont = abcontent:LoadAsset("yhFont.ttf");
	
	self:startGame();
end

function StartController:loadComplete(abName,assetName,abcontent)
	
	-- print(typeof(globalData.defaultFont));
	local destList = parseABContent(abcontent);
	--  = destList["Asterix-Blink.ttf"];
	-- abcontent:LoadAsset("Text.prefab");
	self:startGame();
end

function StartController:startGame()
	print("startGame");

	local image = globalManager.kCreator:createImage();	
	image:setPath("bg.jpg");
	image:setPosition(globalManager.uiManager.PANEL_WIDTH/2,-globalManager.uiManager.PANEL_HEIGHT/2);
	-- image:addTouchCallBack(self.btnClickHandler,self);
	image:setParent(globalManager.uiManager.mainTransform);

	local label = globalManager.kCreator:createRichLabel();
	label:setPosition(100,-50)
	label:setString("你是&#6$602$2$<color=#fb5657>没下划线点击</color>$81$0$0$0#&哈&#6$602$3$<color=#fb5657>下划线点击</color>$91$0$0$0#&吗");
	label:setParent(globalManager.uiManager.mainTransform);

	local listView = globalManager.kCreator:createListView(image.transform,"listView");
	listView:setMargin(5);
	listView:pushBackItem(globalManager.kCreator:createImage());
	listView:pushBackItem(globalManager.kCreator:createImage());
	listView:pushBackItem(globalManager.kCreator:createImage());
	listView:pushBackItem(globalManager.kCreator:createImage());
	listView:pushBackItem(globalManager.kCreator:createImage());

	listView:setViewPortSize(100,250);
end

function StartController:btnClickHandler(sender)
	print("StartController:btnClickHandlerStartController:btnClickHandler");
end