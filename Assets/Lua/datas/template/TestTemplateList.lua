TestTemplateList = class("TestTemplateList",BaseTemplateList);


function TestTemplateList:ctor()
 	TestTemplateList.super.ctor(self);
 	self.isAllParse2 = true;
end

function TestTemplateList:initInfo1(info)
	info.id = 0;
	info.dataPos = 0;
	info.isParsed = false;
end

function TestTemplateList:initInfo2(info)
	info.name = 0;
	info.age = 0;
end

function TestTemplateList:parseKey(info)
	info.id = self._templateData:readInt();
	print("info.id",info.id);
	self._list[info.id] = info;
end

function TestTemplateList:parseOne2(info)
	info.name = self._templateData:readString();
	info.age = self._templateData:readInt();
	print("TestTemplateList:parseOne2",info.name,info.age);
end

function TestTemplateList:getItem(id)
	return self:getInfo2(self._list[id]);
end
