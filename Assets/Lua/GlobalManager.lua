GlobalManager = class("GlobalManager");

function GlobalManager:ctor()
	self.poolManager = nil;
end

function GlobalManager:init()
	print("GlobalManager:init");

	self.kCreator = KCreator:new();
	self.tickManager = TickManager:new();

	self.uiManager = UIManager:new();
	self.cameraManager = CameraManager:new();

	self.cameraManager:init();
	-- self.uiManager:init();
	-- self.poolManager = PoolManager:new();
end