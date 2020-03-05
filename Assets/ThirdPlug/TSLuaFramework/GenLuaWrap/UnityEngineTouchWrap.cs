#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua
{
    public partial class ObjectTranslator
    {
        public void __RegisterUnityEngineTouch(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.Touch);
			Utils.BeginObjectRegister(type, L, this, 0, 0, 14, 14);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "fingerId", UnityEngineTouch_g_get_fingerId);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "position", UnityEngineTouch_g_get_position);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rawPosition", UnityEngineTouch_g_get_rawPosition);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "deltaPosition", UnityEngineTouch_g_get_deltaPosition);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "deltaTime", UnityEngineTouch_g_get_deltaTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "tapCount", UnityEngineTouch_g_get_tapCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "phase", UnityEngineTouch_g_get_phase);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pressure", UnityEngineTouch_g_get_pressure);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "maximumPossiblePressure", UnityEngineTouch_g_get_maximumPossiblePressure);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "type", UnityEngineTouch_g_get_type);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "altitudeAngle", UnityEngineTouch_g_get_altitudeAngle);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "azimuthAngle", UnityEngineTouch_g_get_azimuthAngle);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "radius", UnityEngineTouch_g_get_radius);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "radiusVariance", UnityEngineTouch_g_get_radiusVariance);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "fingerId", UnityEngineTouch_s_set_fingerId);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "position", UnityEngineTouch_s_set_position);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "rawPosition", UnityEngineTouch_s_set_rawPosition);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "deltaPosition", UnityEngineTouch_s_set_deltaPosition);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "deltaTime", UnityEngineTouch_s_set_deltaTime);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "tapCount", UnityEngineTouch_s_set_tapCount);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "phase", UnityEngineTouch_s_set_phase);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pressure", UnityEngineTouch_s_set_pressure);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "maximumPossiblePressure", UnityEngineTouch_s_set_maximumPossiblePressure);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "type", UnityEngineTouch_s_set_type);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "altitudeAngle", UnityEngineTouch_s_set_altitudeAngle);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "azimuthAngle", UnityEngineTouch_s_set_azimuthAngle);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "radius", UnityEngineTouch_s_set_radius);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "radiusVariance", UnityEngineTouch_s_set_radiusVariance);
            
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineTouch, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineTouch(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			
			if (gen_param_count == 1)
			{
				translator.Push(L, default(UnityEngine.Touch));
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Touch constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        int UnityEngineTouch_g_get_fingerId(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Touch gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.fingerId);
            return 1;
        }
        
        int UnityEngineTouch_g_get_position(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Touch gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			translator.PushUnityEngineVector2(L, gen_to_be_invoked.position);
            return 1;
        }
        
        int UnityEngineTouch_g_get_rawPosition(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Touch gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			translator.PushUnityEngineVector2(L, gen_to_be_invoked.rawPosition);
            return 1;
        }
        
        int UnityEngineTouch_g_get_deltaPosition(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Touch gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			translator.PushUnityEngineVector2(L, gen_to_be_invoked.deltaPosition);
            return 1;
        }
        
        int UnityEngineTouch_g_get_deltaTime(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Touch gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.deltaTime);
            return 1;
        }
        
        int UnityEngineTouch_g_get_tapCount(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Touch gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.tapCount);
            return 1;
        }
        
        int UnityEngineTouch_g_get_phase(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Touch gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			translator.PushUnityEngineTouchPhase(L, gen_to_be_invoked.phase);
            return 1;
        }
        
        int UnityEngineTouch_g_get_pressure(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Touch gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.pressure);
            return 1;
        }
        
        int UnityEngineTouch_g_get_maximumPossiblePressure(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Touch gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.maximumPossiblePressure);
            return 1;
        }
        
        int UnityEngineTouch_g_get_type(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Touch gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			translator.Push(L, gen_to_be_invoked.type);
            return 1;
        }
        
        int UnityEngineTouch_g_get_altitudeAngle(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Touch gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.altitudeAngle);
            return 1;
        }
        
        int UnityEngineTouch_g_get_azimuthAngle(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Touch gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.azimuthAngle);
            return 1;
        }
        
        int UnityEngineTouch_g_get_radius(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Touch gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.radius);
            return 1;
        }
        
        int UnityEngineTouch_g_get_radiusVariance(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Touch gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.radiusVariance);
            return 1;
        }
        
        
        
        int UnityEngineTouch_s_set_fingerId(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Touch gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            gen_to_be_invoked.fingerId = LuaAPI.xlua_tointeger(L, 2);
            
            translator.Update(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineTouch_s_set_position(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Touch gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.position = gen_value;
            
            translator.Update(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineTouch_s_set_rawPosition(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Touch gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.rawPosition = gen_value;
            
            translator.Update(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineTouch_s_set_deltaPosition(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Touch gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.deltaPosition = gen_value;
            
            translator.Update(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineTouch_s_set_deltaTime(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Touch gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            gen_to_be_invoked.deltaTime = (float)LuaAPI.lua_tonumber(L, 2);
            
            translator.Update(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineTouch_s_set_tapCount(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Touch gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            gen_to_be_invoked.tapCount = LuaAPI.xlua_tointeger(L, 2);
            
            translator.Update(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineTouch_s_set_phase(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Touch gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            UnityEngine.TouchPhase gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.phase = gen_value;
            
            translator.Update(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineTouch_s_set_pressure(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Touch gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            gen_to_be_invoked.pressure = (float)LuaAPI.lua_tonumber(L, 2);
            
            translator.Update(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineTouch_s_set_maximumPossiblePressure(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Touch gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            gen_to_be_invoked.maximumPossiblePressure = (float)LuaAPI.lua_tonumber(L, 2);
            
            translator.Update(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineTouch_s_set_type(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Touch gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            UnityEngine.TouchType gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.type = gen_value;
            
            translator.Update(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineTouch_s_set_altitudeAngle(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Touch gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            gen_to_be_invoked.altitudeAngle = (float)LuaAPI.lua_tonumber(L, 2);
            
            translator.Update(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineTouch_s_set_azimuthAngle(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Touch gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            gen_to_be_invoked.azimuthAngle = (float)LuaAPI.lua_tonumber(L, 2);
            
            translator.Update(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineTouch_s_set_radius(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Touch gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            gen_to_be_invoked.radius = (float)LuaAPI.lua_tonumber(L, 2);
            
            translator.Update(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineTouch_s_set_radiusVariance(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Touch gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            gen_to_be_invoked.radiusVariance = (float)LuaAPI.lua_tonumber(L, 2);
            
            translator.Update(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
		
		
		
		
    }
}
