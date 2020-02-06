GobalConst = class("GobalConst");

function GobalConst:ctor()
	self.layerConst = nil;
	self.colorConst = nil;
	self.triggerType = nil;
	self.handlePattern = "&#%d+$[^&]*#&";
end

function GobalConst:init()
	self.layerConst = LayerConst:new();
	self.colorConst = ColorConst:new();
	self.triggerType = TriggerType:new();
end