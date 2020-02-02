Image = class("Image",Node);

function Image:ctor()
	Image.super.ctor(self);
	self._resPath = nil;
end

function Image:createComponent()
	self.component = self.go:GetComponent(typeof(UnityEngine.UI.Image));
	if self.component == nil then
		self.component = self.go:AddComponent(typeof(UnityEngine.UI.Image));
		self.component.raycastTarget = false;
	end
end

function Image:setPath(abName)
	globalManager.loaderManager:loadTexture(abName,self.loadComplete,self);
end

function Image:loadComplete(abName,assetName,texture)
    local sprite = UnityEngine.Sprite.Create(texture,UnityEngine.Rect(0,0,texture.width,texture.height),Vector2(0, 0));
	self.component.sprite = sprite;
	self:setSize(texture.width,texture.height);
end

function Image:loadComplete2()
	print("loadComplete2");
end

function Image:doClear()
	Image.super.doClear();
end

function Image:dispose()
	globalManager.poolManager:putItem(self);
end