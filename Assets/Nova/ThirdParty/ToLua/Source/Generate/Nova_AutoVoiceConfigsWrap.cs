﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Nova_AutoVoiceConfigsWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Nova.AutoVoiceConfigs), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("Awake", Awake);
		L.RegFunction("GetCharacterControllerForName", GetCharacterControllerForName);
		L.RegFunction("GetVoicePrefixForName", GetVoicePrefixForName);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("luaGlobalName", get_luaGlobalName, set_luaGlobalName);
		L.RegVar("autoVoiceConfigs", get_autoVoiceConfigs, set_autoVoiceConfigs);
		L.RegVar("restorableObjectName", get_restorableObjectName, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Awake(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Nova.AutoVoiceConfigs obj = (Nova.AutoVoiceConfigs)ToLua.CheckObject<Nova.AutoVoiceConfigs>(L, 1);
			obj.Awake();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCharacterControllerForName(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Nova.AutoVoiceConfigs obj = (Nova.AutoVoiceConfigs)ToLua.CheckObject<Nova.AutoVoiceConfigs>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			Nova.CharacterController o = obj.GetCharacterControllerForName(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetVoicePrefixForName(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Nova.AutoVoiceConfigs obj = (Nova.AutoVoiceConfigs)ToLua.CheckObject<Nova.AutoVoiceConfigs>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			string o = obj.GetVoicePrefixForName(arg0);
			LuaDLL.lua_pushstring(L, o);
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
	static int get_luaGlobalName(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Nova.AutoVoiceConfigs obj = (Nova.AutoVoiceConfigs)o;
			string ret = obj.luaGlobalName;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index luaGlobalName on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_autoVoiceConfigs(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Nova.AutoVoiceConfigs obj = (Nova.AutoVoiceConfigs)o;
			Nova.AutoVoiceConfig[] ret = obj.autoVoiceConfigs;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index autoVoiceConfigs on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_restorableObjectName(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Nova.AutoVoiceConfigs obj = (Nova.AutoVoiceConfigs)o;
			string ret = obj.restorableObjectName;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index restorableObjectName on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_luaGlobalName(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Nova.AutoVoiceConfigs obj = (Nova.AutoVoiceConfigs)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.luaGlobalName = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index luaGlobalName on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_autoVoiceConfigs(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Nova.AutoVoiceConfigs obj = (Nova.AutoVoiceConfigs)o;
			Nova.AutoVoiceConfig[] arg0 = ToLua.CheckObjectArray<Nova.AutoVoiceConfig>(L, 2);
			obj.autoVoiceConfigs = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index autoVoiceConfigs on a nil value");
		}
	}
}

