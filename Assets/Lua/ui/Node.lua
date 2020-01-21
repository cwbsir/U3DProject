Node = class("Node");

function Node:ctor()
	self.component = nil;

	self.go = self:newGameObject("Node");
	self.transform = gameObject:AddComponent(typeof(UnityEngine.RectTransform));
	self.transform.pivot = globalManager.kCreator.pivotPoint0;
	self.transform.anchorMax = globalManager.kCreator.pivotPoint1;
	self.transform.anchorMin = globalManager.kCreator.pivotPoint1;
end

function Node:newGameObject(name)
	return UnityEngine.GameObject(name);
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

function Node:dispose()
	self.component = nil;
end