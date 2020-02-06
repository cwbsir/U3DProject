UIManager = class("UIManager");

function UIManager:ctor()
	self.PANEL_WIDTH = 1280;
	self.PANEL_HEIGHT = 720;

	self.canvas = nil;
	self.canvasTransform = nil;

	self.mainLayer = nil;
	self.mainTransform = nil;

	self.canvasScale = 1;
	self.canvas_width = 1280;
	self.canvas_height = 720;
	self.canvasWHScale = nil;
end

function UIManager:init()
	self:createEventSystem();
	self:createCanvas();
	self:createCanvasLayer();
end

function UIManager:createEventSystem()
	local go = UnityEngine.GameObject("EventSystem");
	UnityEngine.Object.DontDestroyOnLoad(go);
	self.eventSystem = go:AddComponent(typeof(UnityEngine.EventSystems.EventSystem));
	self.eventSystem.sendNavigationEvents = false;
	self.eventSystem.pixelDragThreshold = 15;
	go:AddComponent(typeof(UnityEngine.EventSystems.StandaloneInputModule));
end

function UIManager:createCanvas()
	local go = self:newCanvas("Canvas",globalManager.cameraManager.uiCamera,300,-100,globalConst.layerConst.UI,1);
	UnityEngine.Object.DontDestroyOnLoad(go);
	self.canvasTransform = go:GetComponent("RectTransform");
	self.canvas = go;
end

function UIManager:createCanvasLayer()
	self.mainLayer = self:createLayer(self.canvasTransform, "MainLayer", 1000);
	self.mainTransform = self.mainLayer.transform;
	self.mainLayer:setLayer(globalConst.layerConst.UI);
end


function UIManager:newCanvas(name,camera,planeDistance,sortingOrder,layer,index)
	local go = UnityEngine.GameObject(name);
	local canvas = go:AddComponent(typeof(UnityEngine.Canvas));
	canvas.renderMode = UnityEngine.RenderMode.ScreenSpaceCamera;
	canvas.worldCamera = camera;
	canvas.planeDistance = planeDistance;
	--像素对齐 scrollBar图片会跳动
	canvas.pixelPerfect = true;
	canvas.scaleFactor = self.canvasScale;
	canvas.sortingOrder = sortingOrder;
	
	-- local scaler = go:AddComponent(typeof(UnityEngine.UI.CanvasScaler));
	-- scaler.uiScaleMode = ScaleMode.ScaleWithScreenSize;
	-- self._tmpVector2:Set(self.PANEL_WIDTH, self.PANEL_HEIGHT);
	-- scaler.referenceResolution = self._tmpVector2;
	-- local canvasTransform = go:GetComponent("RectTransform");
	-- if index == 1 then
	-- 	self.canvas_width = tonumber(canvasTransform.sizeDelta.x);
	-- 	self.canvas_height = tonumber(canvasTransform.sizeDelta.y);
	-- 	self.canvasWHScale = self.canvas_width / self.canvas_height;
	-- end
	-- if self.canvas_width > 0 and self.canvas_width / self.canvas_height >= self.PANEL_WIDTH / self.PANEL_HEIGHT then
	-- 	scaler.matchWidthOrHeight = 1;
	-- else
	-- 	scaler.matchWidthOrHeight = 0;
	-- end
	go:AddComponent(typeof(UnityEngine.UI.GraphicRaycaster));
	go.layer = layer;
	return go;
end

function UIManager:createLayer(parent, name, zPosition)
	local node = globalManager.kCreator:createNode(name);
	node.transform:SetParent(parent, false);
	node.transform.pivot = Vector2(0,1);
	node.transform.anchorMin = Vector2(0,1);
	node.transform.anchorMax = Vector2(0,1);
	node.transform.offsetMin = Vector2.zero;
	node.transform.offsetMax = Vector2.zero;
	node.transform.sizeDelta = Vector2(720, self.canvas_height);
	node.transform.anchoredPosition3D = Vector3(0, 0, zPosition);
	return node;
end