Node = class("Node");

function Node:ctor()
	self.go = nil;
	self._size = nil;
	self._position = nil;
	self._isShow = true;
	self.transform = nil;
	self.component = nil;
end

function Node:setObject(object)
	self.go = object;
	self.transform = self.go:GetComponent(typeof(UnityEngine.RectTransform));
	if self.transform == nil then
		self.transform = self.go:AddComponent(typeof(UnityEngine.RectTransform));
		self.transform.pivot = globalManager.kCreator.pivotPoint0;
		self.transform.anchorMax = globalManager.kCreator.pivotPoint1;
		self.transform.anchorMin = globalManager.kCreator.pivotPoint1;
	end

	self:createComponent();
end

function Node:createComponent()

end

function Node:addNode(uiNode)
	if(self.transform == nil or uiNode == nil)then return; end
	if uiNode.transform ~= nil then
		uiNode:setParent(uiNode.transform);
	end
end

function Node:setParent(parentTransform)
	self.transform:SetParent(parentTransform,false);
end

function Node:setZButtom()
	self.transform:SetAsFirstSibling();
end

function Node:setZTop()
	self.transform:SetAsLastSibling();
end

function Node:setName(name)
	if self.go ~= nil then
		self.go.name = name;
	end
end

function Node:setVisible(bShow)
	if bShow then
		self:show();
	else
		self:hide();
	end
end

function Node:show()
	self._isShow = true;
	self:updateShowHide();
end

function Node:hide()
	self._isShow = false;
	self:updateShowHide();
end

function Node:updateShowHide()
	if self.go ~= nil and not self.go:Equals(nil) and self.go.SetActive ~= nil then
		self.go:SetActive(self._isShow);
	end
end

function Node:setPivot(pivot)
	if(self.transform == nil)then return; end
	self.transform.pivot = pivot;
end
function Node:setAnchor(maxVector,minVector)
	if(self.transform == nil)then return; end
	self.transform.anchorMax = maxVector;
	self.transform.anchorMin = minVector;
end

function Node:setPosition(x,y,z)
	local pos = self:getPosition();
	if x ~= nil then
		pos.x = x;
	end
	if y ~= nil then
		pos.y = y;
	end
	if z ~= nil then
		pos.z = z;
	end
	self.transform.anchoredPosition = pos;
end

function Node:getPosition()
	if self._position == nil then
		local pos = self.transform.anchoredPosition;
		self._position = globalManager.poolManager:createVector3(pos.x,pos.y,pos.z);
	end
	return self._position;
end

function Node:setSize(width,height)
	local size = self:getSize();
	if width ~= nil then 
		size.x = width;
	end
	if height ~= nil then
		size.y = height;
	end
	self.transform.sizeDelta = size;
end

function Node:getSize()
	if(self._size == nil)then
		local size = self.transform.sizeDelta;
		self._size = globalManager.poolManager:createVector2(size.x,size.y);
	end
	return self._size;
end

function Node:doClear()
	self._isShow = true;
	self.component = nil;
	if self._size ~= nil then
		globalManager.poolManager:putVector2(self._size);
		self._size = nil;
	end
	if self._position ~= nil then
		globalManager.poolManager:putVector3(self._position);
		self._position = nil;
	end
end

function Node:dispose()
	globalManager.poolManager:putItem(self);
end