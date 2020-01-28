﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_EventSystems_BaseInputModuleWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.EventSystems.BaseInputModule), typeof(UnityEngine.EventSystems.UIBehaviour));
		L.RegFunction("Process", Process);
		L.RegFunction("IsPointerOverGameObject", IsPointerOverGameObject);
		L.RegFunction("ShouldActivateModule", ShouldActivateModule);
		L.RegFunction("DeactivateModule", DeactivateModule);
		L.RegFunction("ActivateModule", ActivateModule);
		L.RegFunction("UpdateModule", UpdateModule);
		L.RegFunction("IsModuleSupported", IsModuleSupported);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("input", get_input, null);
		L.RegVar("inputOverride", get_inputOverride, set_inputOverride);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Process(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.EventSystems.BaseInputModule obj = (UnityEngine.EventSystems.BaseInputModule)ToLua.CheckObject<UnityEngine.EventSystems.BaseInputModule>(L, 1);
			obj.Process();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsPointerOverGameObject(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.EventSystems.BaseInputModule obj = (UnityEngine.EventSystems.BaseInputModule)ToLua.CheckObject<UnityEngine.EventSystems.BaseInputModule>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			bool o = obj.IsPointerOverGameObject(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ShouldActivateModule(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.EventSystems.BaseInputModule obj = (UnityEngine.EventSystems.BaseInputModule)ToLua.CheckObject<UnityEngine.EventSystems.BaseInputModule>(L, 1);
			bool o = obj.ShouldActivateModule();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DeactivateModule(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.EventSystems.BaseInputModule obj = (UnityEngine.EventSystems.BaseInputModule)ToLua.CheckObject<UnityEngine.EventSystems.BaseInputModule>(L, 1);
			obj.DeactivateModule();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ActivateModule(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.EventSystems.BaseInputModule obj = (UnityEngine.EventSystems.BaseInputModule)ToLua.CheckObject<UnityEngine.EventSystems.BaseInputModule>(L, 1);
			obj.ActivateModule();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UpdateModule(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.EventSystems.BaseInputModule obj = (UnityEngine.EventSystems.BaseInputModule)ToLua.CheckObject<UnityEngine.EventSystems.BaseInputModule>(L, 1);
			obj.UpdateModule();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsModuleSupported(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.EventSystems.BaseInputModule obj = (UnityEngine.EventSystems.BaseInputModule)ToLua.CheckObject<UnityEngine.EventSystems.BaseInputModule>(L, 1);
			bool o = obj.IsModuleSupported();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_input(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.BaseInputModule obj = (UnityEngine.EventSystems.BaseInputModule)o;
			UnityEngine.EventSystems.BaseInput ret = obj.input;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index input on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_inputOverride(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.BaseInputModule obj = (UnityEngine.EventSystems.BaseInputModule)o;
			UnityEngine.EventSystems.BaseInput ret = obj.inputOverride;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index inputOverride on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_inputOverride(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.BaseInputModule obj = (UnityEngine.EventSystems.BaseInputModule)o;
			UnityEngine.EventSystems.BaseInput arg0 = (UnityEngine.EventSystems.BaseInput)ToLua.CheckObject<UnityEngine.EventSystems.BaseInput>(L, 2);
			obj.inputOverride = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index inputOverride on a nil value");
		}
	}
}

