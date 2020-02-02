Label = class("Label",Node);

function Label:ctor()
	self._content = nil;
	self.count = 1;
	Label.super.ctor(self);	
end

function Label:createComponent()
	self.component = self.go:GetComponent(typeof(UnityEngine.UI.Text));
	if self.component == nil then
		self.component = self.go:AddComponent(typeof(UnityEngine.UI.Text));
		self.component.font = globalData.defaultFont;
		self.component.raycastTarget = false;
	end
	self.component.color.a = 1;
end




function Label:setString(str)
	if(self._content == str)then return; end
	self._content = str;
	if self.component ~= nil then
		self.component.text = self._content;
	end
end

function Label:setFontSize(fontSize)
	self.component.fontSize = fontSize;
end

-- 行间距
function Label:setLineSpacing(value)
	self.component.lineSpacing = value;
end

--UnityEngine.FontStyle.Normal(默认)
--UnityEngine.FontStyle.Bold(加粗)
--UnityEngine.FontStyle.Italiclic(倾斜)
--UnityEngine.FontStyle.BoldAndItalic(加粗倾斜)
function Label:setFontStyle(style)
	self.component.fontStyle = style;
end

--globalConst.uiConst.anchorType.UpperLeft
--globalConst.uiConst.anchorType.UpperCenter
--globalConst.uiConst.anchorType.UpperRight
--globalConst.uiConst.anchorType.MiddleLeft
--globalConst.uiConst.anchorType.MiddleCenter
--globalConst.uiConst.anchorType.MiddleRight
--globalConst.uiConst.anchorType.LowerLeft
--globalConst.uiConst.anchorType.LowerCenter
--globalConst.uiConst.anchorType.LowerRight
function Label:setAlign(align)
	self.component.alignment = align;
end

--globalConst.uiConst.hWrapMode.Wrap(换行)
--globalConst.uiConst.hWrapMode.Overflow(强行超出)
function Label:setHOverflow(overflow)
	self.component.horizontalOverflow = overflow;
end

--globalConst.uiConst.vWrapMode.Truncate(不显示)
--globalConst.uiConst.vWrapMode.Overflow(强行超出)
function Label:setVOverflow(overflow)
	self.component.verticalOverflow = overflow;
end

function Label:dispose()
	globalManager.poolManager:putItem(self);
end