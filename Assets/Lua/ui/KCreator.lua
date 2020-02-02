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
	name = name or "Node";
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

function KCreator:createLabel(fontSize,name,isPool)
	name = name or "Label";
	local label,isNew = globalManager.poolManager:createLabel(isPool);
	if isNew then
		local object = newObject(name)
		label:setObject(object);
	else
		label:setName(name);
		label:show();
	end
	-- label:setSize(0,0,true,true);
	label:setFontSize(fontSize or 20);
	label:setLineSpacing(1);
	label:setFontStyle(UnityEngine.FontStyle.BoldAndItalic);
	label:setPivot(self.pivotPoint0);
	label:setAnchor(self.pivotPoint1,self.pivotPoint1);

	return label;
end

function KCreator:createImage(name,isPool)
	name = name or "Image";
	local image,isNew = globalManager.poolManager:createImage(isPool);
	if isNew then
		local object = newObject(name)
		image:setObject(object);
	else
		image:setName(name);
		image:show();
	end

	image:setPivot(self.pivotPoint0);
	image:setAnchor(self.pivotPoint1,self.pivotPoint1);

	return image;
end
