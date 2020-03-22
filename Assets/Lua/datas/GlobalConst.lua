GobalConst = class("GobalConst");

function GobalConst:ctor()
	self.layerConst = nil;
	self.colorConst = nil;
	self.shaderType = nil;
	self.triggerType = nil;

	self.testTemplateList = nil;

	self.handlePattern = "&#%d+$[^&]*#&";
end

function GobalConst:init()
	self.layerConst = LayerConst:new();
	self.colorConst = ColorConst:new();
	self.triggerType = TriggerType:new();
	self.shaderType = ShaderType:new();

	self.testTemplateList = TestTemplateList:new();
end