GlobalData = class("GlobalData");

function GlobalData:ctor()
	self.USE_POOL = true;
	self.defaultFont = UnityEngine.Font.New("Arial");
	print("self.defaultFont.fontSize",self.defaultFont.fontSize);
end

function GlobalData:init()

end