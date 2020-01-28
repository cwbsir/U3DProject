globalData = nil;
globalConst = nil;
globalManager = nil;


--主入口函数。从这里开始lua逻辑
function main()					
	print("logic start");

	require("ImportClient");

	globalData = GlobalData:new();
	globalConst = GobalConst:new();
	globalManager = GlobalManager:new();

	globalConst:init();
	globalManager:init();


	startGame();
end

function startGame()
	print("startGame");
	local node = globalManager.kCreator:createNode();
	node:setSize(100,100);
	node:setPosition(5,50);
	node:setParent(globalManager.uiManager.mainTransform);
end

function tickFunc(deltaTime)
	-- print("deltaTime=",deltaTime);
	globalManager.tickManager:update(deltaTime)
end

function fixedTickFunc(deltaTime)
	-- print("deltaTime=",deltaTime);
end