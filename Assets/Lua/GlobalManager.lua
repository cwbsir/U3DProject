GlobalManager = class("GlobalManager");

function GlobalManager:ctor()
	self.kCreator = nil;
	self.uiManager = nil;
	self.poolManager = nil;
	self.tickManager = nil;
	self.loaderManager = nil;
	self.cameraManager = nil;
end

function GlobalManager:init()
	print("GlobalManager:init");

	self.kCreator = KCreator:new();
	self.tickManager = TickManager:new();
	self.poolManager = PoolManager:new();
	self.loaderManager = LoaderManager:new();

	self.uiManager = UIManager:new();
	self.cameraManager = CameraManager:new();

	self.cameraManager:init();
	self.uiManager:init();
end