Label = class("Label",Node);

function Label:ctor()
	self._content = nil;

	Label.super.ctor(self);
	self.component =  self.go:AddComponent(typeof(UnityEngine.UI.Text));
end

function Label:setString(str)
	if(self._content == str)then return; end
	self._content = str;
	if self.component ~= nil then
		self.component.text = self._content;
	end
end

function Label:dispose()
	self._content = nil;
	Label.super.dispose(self);
end