GlobalData = class("GlobalData");

function GlobalData:ctor()
	self.USE_POOL = true;
	self.uiPrefabs = nil;
	self.defaultFont = UnityEngine.Font.New("Arial");
end

function GlobalData:init()

end