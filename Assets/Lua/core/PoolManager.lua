--对象池
--__isInPoolList表示对象是否处理对象池里面
PoolManager = class("PoolManager");

function PoolManager:ctor()
	self.vector3List = {};
	self.vector2List = {};

	self.quoteDataList = {};
	self.uiNodeList = {};
	self.uiImageList = {};
	self.uiLabelList = {};
	self.downloadItemList = {};
	self.uiNumberList = {};
	self.ui3DNumberList = {};
	self.actionInfoList = {};
	self.itemGridList = {};
	self.equipGridList = {};
	self.shopGridList = {};
	self.skillGridList = {};
	self.richLabelList = {};
	self.ui3DImageList = {};
	self.ui3DLabelList = {};
	self.loaderItemList = {};
	self.chatItemInfoList = {};


	self.types = {};
	-- self.types["QuoteData"] = {QuoteData,self.quoteDataList,0};
	-- self.types["DownloadItem"] = {DownloadItem,self.downloadItemList,100};
	-- self.types["LoaderItem"] = {LoaderItem,self.loaderItemList,100};
	-- self.types["KUINode"] = {KUINode,self.uiNodeList,0};
	-- self.types["KUIImage"] = {KUIImage,self.uiImageList,30};
	-- self.types["KUI3DImage"] = {KUI3DImage,self.ui3DImageList,10};
	-- self.types["KUILabel"] = {KUILabel,self.uiLabelList,20};
	-- self.types["KUI3DLabel"] = {KUI3DLabel,self.ui3DLabelList,10};
	-- self.types["KUIRichLabel"] = {KUIRichLabel,self.richLabelList,50};
	-- self.types["KUINumberView"] = {KUINumberView,self.uiNumberList,10};
	-- self.types["KUI3DNumberView"] = {KUINumberView,self.ui3DNumberList,5};
	-- self.types["ItemGrid"] = {ItemGrid,self.itemGridList,0};
	-- self.types["SkillGrid"] = {SkillGrid,self.skillGridList,20};
	-- self.types["SkillEffectActionInfo"] = {SkillEffectActionInfo,self.actionInfoList,0};
	-- self.types["ChatItemInfo"] = {ChatItemInfo,self.chatItemInfoList,0};
end

function PoolManager:createItem(usePool,itemType,is3D)
	if usePool == nil then usePool = true;end
	local typeClass = self.types[itemType][1];
	local poolList = self.types[itemType][2];
	if globalData.USE_POOL and usePool then
		local item = nil;
		if #poolList > 0 then
			item = table.remove(poolList,1);
			if item.poolShow ~= nil then
				item:poolShow();
			end
			-- 从池中取出标记一下
			item.__isInPoolList = false;
			-- 使用完需要放回缓存池
			item.__isForPoolList = true;
			return item,false;
		else
			item = typeClass:new(is3D);
			item.__isInPoolList = false;
			-- 使用完需要放回缓存池
			item.__isForPoolList = true;
			return item, true;
		end
	end
	-- 直接创建
	item = typeClass:new(is3D);
	-- 是否在池中
	item.__isInPoolList = false;
	-- 不放回缓存池
	item.__isForPoolList = false;
	return item,true;
end

function PoolManager:putItem(item,itemType)
	-- 防止重复放入池中
	if item.__isInPoolList then return;end
	local typeClass = self.types[itemType][1];
	local poolList = self.types[itemType][2];
	local limitCount = self.types[itemType][3];
	if item.__cname ~= typeClass.__cname or  #poolList >= limitCount or globalData.USE_POOL == false or item.__isForPoolList == false then
		item:poolDispose();
	else
		item:poolReset();
		if item.__isInPoolList == false then
			table.insert(poolList,item);
			-- 放入池中，标记一下
			item.__isInPoolList = true;
		end
	end
end
