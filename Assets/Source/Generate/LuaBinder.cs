﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using UnityEngine;
using LuaInterface;

public static class LuaBinder
{
	public static void Bind(LuaState L)
	{
		float t = Time.realtimeSinceStartup;
		L.BeginModule(null);
		LuaInterface_DebuggerWrap.Register(L);
		TouchTriggerWrap.Register(L);
		LinkImageTextWrap.Register(L);
		L.BeginModule("LuaInterface");
		LuaInterface_LuaInjectionStationWrap.Register(L);
		LuaInterface_InjectTypeWrap.Register(L);
		L.EndModule();
		L.BeginModule("UnityEngine");
		UnityEngine_ComponentWrap.Register(L);
		UnityEngine_TransformWrap.Register(L);
		UnityEngine_MaterialWrap.Register(L);
		UnityEngine_LightWrap.Register(L);
		UnityEngine_CameraWrap.Register(L);
		UnityEngine_AudioSourceWrap.Register(L);
		UnityEngine_BehaviourWrap.Register(L);
		UnityEngine_MonoBehaviourWrap.Register(L);
		UnityEngine_GameObjectWrap.Register(L);
		UnityEngine_TrackedReferenceWrap.Register(L);
		UnityEngine_ApplicationWrap.Register(L);
		UnityEngine_PhysicsWrap.Register(L);
		UnityEngine_ColliderWrap.Register(L);
		UnityEngine_TimeWrap.Register(L);
		UnityEngine_TextureWrap.Register(L);
		UnityEngine_Texture2DWrap.Register(L);
		UnityEngine_ShaderWrap.Register(L);
		UnityEngine_RendererWrap.Register(L);
		UnityEngine_WWWWrap.Register(L);
		UnityEngine_ScreenWrap.Register(L);
		UnityEngine_CameraClearFlagsWrap.Register(L);
		UnityEngine_AudioClipWrap.Register(L);
		UnityEngine_AssetBundleWrap.Register(L);
		UnityEngine_AssetBundleRequestWrap.Register(L);
		UnityEngine_AssetBundleManifestWrap.Register(L);
		UnityEngine_AssetBundleCreateRequestWrap.Register(L);
		UnityEngine_ParticleSystemWrap.Register(L);
		UnityEngine_AsyncOperationWrap.Register(L);
		UnityEngine_LightTypeWrap.Register(L);
		UnityEngine_SleepTimeoutWrap.Register(L);
		UnityEngine_AnimatorWrap.Register(L);
		UnityEngine_InputWrap.Register(L);
		UnityEngine_KeyCodeWrap.Register(L);
		UnityEngine_SkinnedMeshRendererWrap.Register(L);
		UnityEngine_SpaceWrap.Register(L);
		UnityEngine_AnimationBlendModeWrap.Register(L);
		UnityEngine_QueueModeWrap.Register(L);
		UnityEngine_PlayModeWrap.Register(L);
		UnityEngine_WrapModeWrap.Register(L);
		UnityEngine_QualitySettingsWrap.Register(L);
		UnityEngine_RenderSettingsWrap.Register(L);
		UnityEngine_ResourcesWrap.Register(L);
		UnityEngine_RectTransformWrap.Register(L);
		UnityEngine_CanvasWrap.Register(L);
		UnityEngine_RenderModeWrap.Register(L);
		UnityEngine_SpriteWrap.Register(L);
		UnityEngine_RectWrap.Register(L);
		UnityEngine_FontWrap.Register(L);
		UnityEngine_FontStyleWrap.Register(L);
		UnityEngine_TextAnchorWrap.Register(L);
		UnityEngine_HorizontalWrapModeWrap.Register(L);
		UnityEngine_VerticalWrapModeWrap.Register(L);
		UnityEngine_AnimatorStateInfoWrap.Register(L);
		UnityEngine_AudioBehaviourWrap.Register(L);
		L.BeginModule("UI");
		UnityEngine_UI_TextWrap.Register(L);
		UnityEngine_UI_ContentSizeFitterWrap.Register(L);
		UnityEngine_UI_GraphicRaycasterWrap.Register(L);
		UnityEngine_UI_ButtonWrap.Register(L);
		UnityEngine_UI_ImageWrap.Register(L);
		UnityEngine_UI_InputFieldWrap.Register(L);
		UnityEngine_UI_MaskWrap.Register(L);
		UnityEngine_UI_ScrollRectWrap.Register(L);
		UnityEngine_UI_MaskableGraphicWrap.Register(L);
		UnityEngine_UI_GraphicWrap.Register(L);
		UnityEngine_UI_SelectableWrap.Register(L);
		L.BeginModule("ContentSizeFitter");
		UnityEngine_UI_ContentSizeFitter_FitModeWrap.Register(L);
		L.EndModule();
		L.BeginModule("Button");
		UnityEngine_UI_Button_ButtonClickedEventWrap.Register(L);
		L.EndModule();
		L.BeginModule("InputField");
		UnityEngine_UI_InputField_OnChangeEventWrap.Register(L);
		UnityEngine_UI_InputField_SubmitEventWrap.Register(L);
		UnityEngine_UI_InputField_LineTypeWrap.Register(L);
		UnityEngine_UI_InputField_ContentTypeWrap.Register(L);
		L.RegFunction("OnValidateInput", UnityEngine_UI_InputField_OnValidateInput);
		L.EndModule();
		L.BeginModule("Toggle");
		UnityEngine_UI_Toggle_ToggleEventWrap.Register(L);
		L.EndModule();
		L.BeginModule("Dropdown");
		UnityEngine_UI_Dropdown_DropdownEventWrap.Register(L);
		L.EndModule();
		L.BeginModule("ScrollRect");
		UnityEngine_UI_ScrollRect_MovementTypeWrap.Register(L);
		L.EndModule();
		L.BeginModule("Image");
		UnityEngine_UI_Image_TypeWrap.Register(L);
		UnityEngine_UI_Image_FillMethodWrap.Register(L);
		UnityEngine_UI_Image_OriginHorizontalWrap.Register(L);
		UnityEngine_UI_Image_OriginVerticalWrap.Register(L);
		UnityEngine_UI_Image_Origin90Wrap.Register(L);
		UnityEngine_UI_Image_Origin180Wrap.Register(L);
		UnityEngine_UI_Image_Origin360Wrap.Register(L);
		L.EndModule();
		L.EndModule();
		L.BeginModule("EventSystems");
		UnityEngine_EventSystems_EventSystemWrap.Register(L);
		UnityEngine_EventSystems_PointerEventDataWrap.Register(L);
		UnityEngine_EventSystems_RaycastResultWrap.Register(L);
		UnityEngine_EventSystems_StandaloneInputModuleWrap.Register(L);
		UnityEngine_EventSystems_UIBehaviourWrap.Register(L);
		UnityEngine_EventSystems_BaseEventDataWrap.Register(L);
		UnityEngine_EventSystems_AbstractEventDataWrap.Register(L);
		UnityEngine_EventSystems_PointerInputModuleWrap.Register(L);
		UnityEngine_EventSystems_BaseInputModuleWrap.Register(L);
		UnityEngine_EventSystems_BaseRaycasterWrap.Register(L);
		L.EndModule();
		L.BeginModule("Events");
		UnityEngine_Events_UnityEventWrap.Register(L);
		UnityEngine_Events_UnityEventBaseWrap.Register(L);
		UnityEngine_Events_UnityEvent_intWrap.Register(L);
		UnityEngine_Events_UnityEvent_stringWrap.Register(L);
		UnityEngine_Events_UnityEvent_boolWrap.Register(L);
		L.RegFunction("UnityAction", UnityEngine_Events_UnityAction);
		L.RegFunction("UnityAction_int", UnityEngine_Events_UnityAction_int);
		L.RegFunction("UnityAction_string", UnityEngine_Events_UnityAction_string);
		L.RegFunction("UnityAction_bool", UnityEngine_Events_UnityAction_bool);
		L.EndModule();
		L.BeginModule("Camera");
		L.RegFunction("CameraCallback", UnityEngine_Camera_CameraCallback);
		L.EndModule();
		L.BeginModule("Application");
		L.RegFunction("AdvertisingIdentifierCallback", UnityEngine_Application_AdvertisingIdentifierCallback);
		L.RegFunction("LowMemoryCallback", UnityEngine_Application_LowMemoryCallback);
		L.RegFunction("LogCallback", UnityEngine_Application_LogCallback);
		L.EndModule();
		L.BeginModule("AudioClip");
		L.RegFunction("PCMReaderCallback", UnityEngine_AudioClip_PCMReaderCallback);
		L.RegFunction("PCMSetPositionCallback", UnityEngine_AudioClip_PCMSetPositionCallback);
		L.EndModule();
		L.BeginModule("RectTransform");
		L.RegFunction("ReapplyDrivenProperties", UnityEngine_RectTransform_ReapplyDrivenProperties);
		L.EndModule();
		L.BeginModule("Canvas");
		L.RegFunction("WillRenderCanvases", UnityEngine_Canvas_WillRenderCanvases);
		L.EndModule();
		L.BeginModule("Font");
		L.RegFunction("FontTextureRebuildCallback", UnityEngine_Font_FontTextureRebuildCallback);
		L.EndModule();
		L.EndModule();
		L.BeginModule("System");
		L.RegFunction("Action", System_Action);
		L.RegFunction("Predicate_int", System_Predicate_int);
		L.RegFunction("Action_int", System_Action_int);
		L.RegFunction("Comparison_int", System_Comparison_int);
		L.RegFunction("Func_int_int", System_Func_int_int);
		L.RegFunction("Action_bool", System_Action_bool);
		L.RegFunction("Func_bool", System_Func_bool);
		L.RegFunction("Action_UnityEngine_AsyncOperation", System_Action_UnityEngine_AsyncOperation);
		L.RegFunction("Predicate_UnityEngine_EventSystems_RaycastResult", System_Predicate_UnityEngine_EventSystems_RaycastResult);
		L.RegFunction("Action_UnityEngine_EventSystems_RaycastResult", System_Action_UnityEngine_EventSystems_RaycastResult);
		L.RegFunction("Comparison_UnityEngine_EventSystems_RaycastResult", System_Comparison_UnityEngine_EventSystems_RaycastResult);
		L.RegFunction("Action_UnityEngine_Font", System_Action_UnityEngine_Font);
		L.RegFunction("Func_string_UnityEngine_GameObject", System_Func_string_UnityEngine_GameObject);
		L.BeginModule("Collections");
		L.BeginModule("Generic");
		System_Collections_Generic_List_UnityEngine_EventSystems_RaycastResultWrap.Register(L);
		L.EndModule();
		L.EndModule();
		L.EndModule();
		L.EndModule();
		L.BeginPreLoad();
		L.AddPreLoad("UnityEngine.MeshRenderer", LuaOpen_UnityEngine_MeshRenderer, typeof(UnityEngine.MeshRenderer));
		L.AddPreLoad("UnityEngine.BoxCollider", LuaOpen_UnityEngine_BoxCollider, typeof(UnityEngine.BoxCollider));
		L.AddPreLoad("UnityEngine.MeshCollider", LuaOpen_UnityEngine_MeshCollider, typeof(UnityEngine.MeshCollider));
		L.AddPreLoad("UnityEngine.SphereCollider", LuaOpen_UnityEngine_SphereCollider, typeof(UnityEngine.SphereCollider));
		L.AddPreLoad("UnityEngine.CharacterController", LuaOpen_UnityEngine_CharacterController, typeof(UnityEngine.CharacterController));
		L.AddPreLoad("UnityEngine.CapsuleCollider", LuaOpen_UnityEngine_CapsuleCollider, typeof(UnityEngine.CapsuleCollider));
		L.AddPreLoad("UnityEngine.Animation", LuaOpen_UnityEngine_Animation, typeof(UnityEngine.Animation));
		L.AddPreLoad("UnityEngine.AnimationClip", LuaOpen_UnityEngine_AnimationClip, typeof(UnityEngine.AnimationClip));
		L.AddPreLoad("UnityEngine.AnimationState", LuaOpen_UnityEngine_AnimationState, typeof(UnityEngine.AnimationState));
		L.AddPreLoad("UnityEngine.BlendWeights", LuaOpen_UnityEngine_BlendWeights, typeof(UnityEngine.BlendWeights));
		L.AddPreLoad("UnityEngine.RenderTexture", LuaOpen_UnityEngine_RenderTexture, typeof(UnityEngine.RenderTexture));
		L.AddPreLoad("UnityEngine.Rigidbody", LuaOpen_UnityEngine_Rigidbody, typeof(UnityEngine.Rigidbody));
		L.EndPreLoad();
		Debugger.Log("Register lua type cost time: {0}", Time.realtimeSinceStartup - t);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_UI_InputField_OnValidateInput(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<UnityEngine.UI.InputField.OnValidateInput>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<UnityEngine.UI.InputField.OnValidateInput>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Events_UnityAction(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<UnityEngine.Events.UnityAction>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<UnityEngine.Events.UnityAction>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Events_UnityAction_int(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<UnityEngine.Events.UnityAction<int>>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<UnityEngine.Events.UnityAction<int>>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Events_UnityAction_string(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<UnityEngine.Events.UnityAction<string>>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<UnityEngine.Events.UnityAction<string>>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Events_UnityAction_bool(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<UnityEngine.Events.UnityAction<bool>>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<UnityEngine.Events.UnityAction<bool>>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Camera_CameraCallback(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<UnityEngine.Camera.CameraCallback>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<UnityEngine.Camera.CameraCallback>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Application_AdvertisingIdentifierCallback(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<UnityEngine.Application.AdvertisingIdentifierCallback>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<UnityEngine.Application.AdvertisingIdentifierCallback>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Application_LowMemoryCallback(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<UnityEngine.Application.LowMemoryCallback>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<UnityEngine.Application.LowMemoryCallback>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Application_LogCallback(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<UnityEngine.Application.LogCallback>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<UnityEngine.Application.LogCallback>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_AudioClip_PCMReaderCallback(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<UnityEngine.AudioClip.PCMReaderCallback>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<UnityEngine.AudioClip.PCMReaderCallback>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_AudioClip_PCMSetPositionCallback(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<UnityEngine.AudioClip.PCMSetPositionCallback>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<UnityEngine.AudioClip.PCMSetPositionCallback>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_RectTransform_ReapplyDrivenProperties(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<UnityEngine.RectTransform.ReapplyDrivenProperties>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<UnityEngine.RectTransform.ReapplyDrivenProperties>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Canvas_WillRenderCanvases(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<UnityEngine.Canvas.WillRenderCanvases>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<UnityEngine.Canvas.WillRenderCanvases>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Font_FontTextureRebuildCallback(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<UnityEngine.Font.FontTextureRebuildCallback>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<UnityEngine.Font.FontTextureRebuildCallback>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<System.Action>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<System.Action>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Predicate_int(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<System.Predicate<int>>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<System.Predicate<int>>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action_int(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<System.Action<int>>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<System.Action<int>>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Comparison_int(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<System.Comparison<int>>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<System.Comparison<int>>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Func_int_int(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<System.Func<int,int>>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<System.Func<int,int>>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action_bool(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<System.Action<bool>>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<System.Action<bool>>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Func_bool(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<System.Func<bool>>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<System.Func<bool>>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action_UnityEngine_AsyncOperation(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<System.Action<UnityEngine.AsyncOperation>>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<System.Action<UnityEngine.AsyncOperation>>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Predicate_UnityEngine_EventSystems_RaycastResult(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<System.Predicate<UnityEngine.EventSystems.RaycastResult>>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<System.Predicate<UnityEngine.EventSystems.RaycastResult>>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action_UnityEngine_EventSystems_RaycastResult(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<System.Action<UnityEngine.EventSystems.RaycastResult>>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<System.Action<UnityEngine.EventSystems.RaycastResult>>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Comparison_UnityEngine_EventSystems_RaycastResult(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<System.Comparison<UnityEngine.EventSystems.RaycastResult>>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<System.Comparison<UnityEngine.EventSystems.RaycastResult>>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action_UnityEngine_Font(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<System.Action<UnityEngine.Font>>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<System.Action<UnityEngine.Font>>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Func_string_UnityEngine_GameObject(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<System.Func<string,UnityEngine.GameObject>>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<System.Func<string,UnityEngine.GameObject>>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_MeshRenderer(IntPtr L)
	{
		try
		{
			LuaState state = LuaState.Get(L);
			state.BeginPreModule("UnityEngine");
			UnityEngine_MeshRendererWrap.Register(state);
			int reference = state.GetMetaReference(typeof(UnityEngine.MeshRenderer));
			state.EndPreModule(L, reference);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_BoxCollider(IntPtr L)
	{
		try
		{
			LuaState state = LuaState.Get(L);
			state.BeginPreModule("UnityEngine");
			UnityEngine_BoxColliderWrap.Register(state);
			int reference = state.GetMetaReference(typeof(UnityEngine.BoxCollider));
			state.EndPreModule(L, reference);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_MeshCollider(IntPtr L)
	{
		try
		{
			LuaState state = LuaState.Get(L);
			state.BeginPreModule("UnityEngine");
			UnityEngine_MeshColliderWrap.Register(state);
			int reference = state.GetMetaReference(typeof(UnityEngine.MeshCollider));
			state.EndPreModule(L, reference);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_SphereCollider(IntPtr L)
	{
		try
		{
			LuaState state = LuaState.Get(L);
			state.BeginPreModule("UnityEngine");
			UnityEngine_SphereColliderWrap.Register(state);
			int reference = state.GetMetaReference(typeof(UnityEngine.SphereCollider));
			state.EndPreModule(L, reference);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_CharacterController(IntPtr L)
	{
		try
		{
			LuaState state = LuaState.Get(L);
			state.BeginPreModule("UnityEngine");
			UnityEngine_CharacterControllerWrap.Register(state);
			int reference = state.GetMetaReference(typeof(UnityEngine.CharacterController));
			state.EndPreModule(L, reference);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_CapsuleCollider(IntPtr L)
	{
		try
		{
			LuaState state = LuaState.Get(L);
			state.BeginPreModule("UnityEngine");
			UnityEngine_CapsuleColliderWrap.Register(state);
			int reference = state.GetMetaReference(typeof(UnityEngine.CapsuleCollider));
			state.EndPreModule(L, reference);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_Animation(IntPtr L)
	{
		try
		{
			LuaState state = LuaState.Get(L);
			state.BeginPreModule("UnityEngine");
			UnityEngine_AnimationWrap.Register(state);
			int reference = state.GetMetaReference(typeof(UnityEngine.Animation));
			state.EndPreModule(L, reference);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_AnimationClip(IntPtr L)
	{
		try
		{
			LuaState state = LuaState.Get(L);
			state.BeginPreModule("UnityEngine");
			UnityEngine_AnimationClipWrap.Register(state);
			int reference = state.GetMetaReference(typeof(UnityEngine.AnimationClip));
			state.EndPreModule(L, reference);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_AnimationState(IntPtr L)
	{
		try
		{
			LuaState state = LuaState.Get(L);
			state.BeginPreModule("UnityEngine");
			UnityEngine_AnimationStateWrap.Register(state);
			int reference = state.GetMetaReference(typeof(UnityEngine.AnimationState));
			state.EndPreModule(L, reference);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_BlendWeights(IntPtr L)
	{
		try
		{
			LuaState state = LuaState.Get(L);
			state.BeginPreModule("UnityEngine");
			UnityEngine_BlendWeightsWrap.Register(state);
			int reference = state.GetMetaReference(typeof(UnityEngine.BlendWeights));
			state.EndPreModule(L, reference);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_RenderTexture(IntPtr L)
	{
		try
		{
			LuaState state = LuaState.Get(L);
			state.BeginPreModule("UnityEngine");
			UnityEngine_RenderTextureWrap.Register(state);
			int reference = state.GetMetaReference(typeof(UnityEngine.RenderTexture));
			state.EndPreModule(L, reference);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_Rigidbody(IntPtr L)
	{
		try
		{
			LuaState state = LuaState.Get(L);
			state.BeginPreModule("UnityEngine");
			UnityEngine_RigidbodyWrap.Register(state);
			int reference = state.GetMetaReference(typeof(UnityEngine.Rigidbody));
			state.EndPreModule(L, reference);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

