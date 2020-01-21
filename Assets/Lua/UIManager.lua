UIManager = class("UIManager");

function UIManager:ctor()
	self.PANEL_WIDTH = 1280;
	self.PANEL_HEIGHT = 720;

	self.canvas = nil;
	self.canvasTransform = nil;

	self.canvasScale = 1;
	self.canvas_width = 1280;
	self.canvas_height = 720;
	self.canvasWHScale = nil;



end

function UIManager:init()
	self:createCanvas();
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
	-- go:AddComponent(typeof(UnityEngine.UI.GraphicRaycaster));
	go.layer = layer;
	return go;
end


function UIManager:createCanvas()
	local go = self:newCanvas("Canvas",globalManager.cameraManager.uiCamera,300,-100,globalConst.layerConst.UI,1);
	UnityEngine.Object.DontDestroyOnLoad(go);
	self.canvasTransform = go:GetComponent("RectTransform");
	self.canvas = go;
end