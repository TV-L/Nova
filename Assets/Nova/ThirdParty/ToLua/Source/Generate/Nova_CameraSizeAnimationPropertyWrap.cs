﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Nova_CameraSizeAnimationPropertyWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Nova.CameraSizeAnimationProperty), typeof(Nova.FloatBaseAnimationProperty));
		L.RegFunction("New", _CreateNova_CameraSizeAnimationProperty);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("id", get_id, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateNova_CameraSizeAnimationProperty(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				Nova.CameraController arg0 = (Nova.CameraController)ToLua.CheckObject<Nova.CameraController>(L, 1);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 2);
				Nova.CameraSizeAnimationProperty obj = new Nova.CameraSizeAnimationProperty(arg0, arg1);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes<Nova.UseRelativeValue>(L, 3))
			{
				Nova.CameraController arg0 = (Nova.CameraController)ToLua.CheckObject<Nova.CameraController>(L, 1);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 2);
				Nova.UseRelativeValue arg2 = (Nova.UseRelativeValue)ToLua.ToObject(L, 3);
				Nova.CameraSizeAnimationProperty obj = new Nova.CameraSizeAnimationProperty(arg0, arg1, arg2);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes<float>(L, 3))
			{
				Nova.CameraController arg0 = (Nova.CameraController)ToLua.CheckObject<Nova.CameraController>(L, 1);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 2);
				float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
				Nova.CameraSizeAnimationProperty obj = new Nova.CameraSizeAnimationProperty(arg0, arg1, arg2);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: Nova.CameraSizeAnimationProperty.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_id(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Nova.CameraSizeAnimationProperty obj = (Nova.CameraSizeAnimationProperty)o;
			string ret = obj.id;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index id on a nil value");
		}
	}
}

