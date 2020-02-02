﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_AssetBundleRequestWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.AssetBundleRequest), typeof(UnityEngine.AsyncOperation));
		L.RegFunction("New", _CreateUnityEngine_AssetBundleRequest);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("asset", get_asset, null);
		L.RegVar("allAssets", get_allAssets, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_AssetBundleRequest(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				UnityEngine.AssetBundleRequest obj = new UnityEngine.AssetBundleRequest();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: UnityEngine.AssetBundleRequest.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_asset(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AssetBundleRequest obj = (UnityEngine.AssetBundleRequest)o;
			UnityEngine.Object ret = obj.asset;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index asset on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_allAssets(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AssetBundleRequest obj = (UnityEngine.AssetBundleRequest)o;
			UnityEngine.Object[] ret = obj.allAssets;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index allAssets on a nil value");
		}
	}
}
