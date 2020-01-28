KCreator = class("KCreator");


function KCreator:ctor()
	self.pivotPoint0 = Vector2.New(0.5,0.5);	--center
	self.pivotPoint1 = Vector2.New(0,1);		--topLeft
	self.pivotPoint2 = Vector2.New(0.5,1);		--topCenter
	self.pivotPoint3 = Vector2.New(1,1);		--topRight
	self.pivotPoint4 = Vector2.New(0,0.5);		--centerLeft
	self.pivotPoint5 = Vector2.New(1,0.5);		--centerRight
	self.pivotPoint6 = Vector2.New(0,0);		--bottomLeft
	self.pivotPoint7 = Vector2.New(1,0);		--bottomRight
	self.pivotPoint8 = Vector2.New(0.5,0);		--bottomCenter
end

function KCreator:createNode(name,isPool)
	local node,isNew = globalManager.poolManager:createNode(isPool);
	if isNew then
		local object = newObject(name)
		node:setObject(object);
	else
		node:setName(name);
		node:show();
	end

	node:setPivot(self.pivotPoint0);
	node:setAnchor(self.pivotPoint1,self.pivotPoint1);

	return node;
end
