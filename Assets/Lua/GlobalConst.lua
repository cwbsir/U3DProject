GobalConst = class("GobalConst");

function GobalConst:ctor()
	self.layerConst = nil;
end

function GobalConst:init()
	self.layerConst = LayerConst:new();
	self.colorConst = ColorConst:new();
end