function newObject(name)
	return UnityEngine.GameObject(name);
end

function parseABContent(abContent)
	local prefabList = abContent:LoadAllAssets(typeof(UnityEngine.GameObject));
	local destList = {};
	if(prefabList == nil)then return destList; end;
	local len = prefabList.Length - 1;
	for i = 0,len,1 do
		local prefab = prefabList[i];
		destList[prefab.name] = prefab;
	end
	return destList;
end