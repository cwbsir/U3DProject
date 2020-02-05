UIManager = class("UIManager");

function UIManager:ctor()
	self.PANEL_WIDTH = 1280;
	self.PANEL_HEIGHT = 720;

	self.canvas = nil;
	self.canvasTransform = nil;

	self.mainNode = nil;
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
	-- self.panelLayer, self.panelTransform, self.panelNode = self:createLayer(self.canvasTransform, "PanelLayer", 900);
	self.mainLayer, self.mainTransform, self.mainNode = self:createLayer(self.canvasTransform, "MainLayer", 1000);
	self.mainLayer.layer = globalConst.layerConst.UI;
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

function UIManager:createLayer(parent, layer, zPosition)
	-- local node = globalManager.kCreator:newKUINode(false);
	local layerGo = UnityEngine.GameObject(layer);
	local rect = layerGo:AddComponent(typeof(UnityEngine.RectTransform));
	-- node:setGoTrans(layerGo);
	rect:SetParent(parent, false);
	rect.pivot = Vector2(0,1);
	rect.anchorMin = Vector2(0,1);
	rect.anchorMax = Vector2(0,1);
	rect.offsetMin = Vector2.zero;
	rect.offsetMax = Vector2.zero;
	rect.sizeDelta = Vector2(720, self.canvas_height);
	rect.anchoredPosition3D = Vector3(0, 0, zPosition);
	return layerGo, rect;
end