globalConst = nil;
globalManager = nil;


--主入口函数。从这里开始lua逻辑
function main()					
	print("logic start");

	require("ImportClient");

	globalConst = GobalConst:new();
	globalManager = GlobalManager:new();

	globalConst:init();
	globalManager:init();
end

function tickFunc(deltaTime)
	-- print("deltaTime=",deltaTime);
	globalManager.tickManager:update(deltaTime)
end

function fixedTickFunc(deltaTime)
	-- print("deltaTime=",deltaTime);
end