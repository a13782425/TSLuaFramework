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
        public void __RegisterUnityEngineTime(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.Time);
			Utils.BeginObjectRegister(type, L, this, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineTime, 1, 19, 6);
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "time", UnityEngineTime_g_get_time);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "timeSinceLevelLoad", UnityEngineTime_g_get_timeSinceLevelLoad);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "deltaTime", UnityEngineTime_g_get_deltaTime);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "fixedTime", UnityEngineTime_g_get_fixedTime);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "unscaledTime", UnityEngineTime_g_get_unscaledTime);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "fixedUnscaledTime", UnityEngineTime_g_get_fixedUnscaledTime);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "unscaledDeltaTime", UnityEngineTime_g_get_unscaledDeltaTime);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "fixedUnscaledDeltaTime", UnityEngineTime_g_get_fixedUnscaledDeltaTime);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "fixedDeltaTime", UnityEngineTime_g_get_fixedDeltaTime);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "maximumDeltaTime", UnityEngineTime_g_get_maximumDeltaTime);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "smoothDeltaTime", UnityEngineTime_g_get_smoothDeltaTime);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "maximumParticleDeltaTime", UnityEngineTime_g_get_maximumParticleDeltaTime);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "timeScale", UnityEngineTime_g_get_timeScale);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "frameCount", UnityEngineTime_g_get_frameCount);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "renderedFrameCount", UnityEngineTime_g_get_renderedFrameCount);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "realtimeSinceStartup", UnityEngineTime_g_get_realtimeSinceStartup);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "captureDeltaTime", UnityEngineTime_g_get_captureDeltaTime);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "captureFramerate", UnityEngineTime_g_get_captureFramerate);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "inFixedTimeStep", UnityEngineTime_g_get_inFixedTimeStep);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "fixedDeltaTime", UnityEngineTime_s_set_fixedDeltaTime);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "maximumDeltaTime", UnityEngineTime_s_set_maximumDeltaTime);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "maximumParticleDeltaTime", UnityEngineTime_s_set_maximumParticleDeltaTime);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "timeScale", UnityEngineTime_s_set_timeScale);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "captureDeltaTime", UnityEngineTime_s_set_captureDeltaTime);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "captureFramerate", UnityEngineTime_s_set_captureFramerate);
            
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineTime(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			if(gen_param_count == 1)
			{
				
				UnityEngine.Time gen_ret = new UnityEngine.Time();
				translator.Push(L, gen_ret);
				
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Time constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        int UnityEngineTime_g_get_time(RealStatePtr L, int gen_param_count) 
        {
            
			    LuaAPI.lua_pushnumber(L, UnityEngine.Time.time);
            return 1;
        }
        
        int UnityEngineTime_g_get_timeSinceLevelLoad(RealStatePtr L, int gen_param_count) 
        {
            
			    LuaAPI.lua_pushnumber(L, UnityEngine.Time.timeSinceLevelLoad);
            return 1;
        }
        
        int UnityEngineTime_g_get_deltaTime(RealStatePtr L, int gen_param_count) 
        {
            
			    LuaAPI.lua_pushnumber(L, UnityEngine.Time.deltaTime);
            return 1;
        }
        
        int UnityEngineTime_g_get_fixedTime(RealStatePtr L, int gen_param_count) 
        {
            
			    LuaAPI.lua_pushnumber(L, UnityEngine.Time.fixedTime);
            return 1;
        }
        
        int UnityEngineTime_g_get_unscaledTime(RealStatePtr L, int gen_param_count) 
        {
            
			    LuaAPI.lua_pushnumber(L, UnityEngine.Time.unscaledTime);
            return 1;
        }
        
        int UnityEngineTime_g_get_fixedUnscaledTime(RealStatePtr L, int gen_param_count) 
        {
            
			    LuaAPI.lua_pushnumber(L, UnityEngine.Time.fixedUnscaledTime);
            return 1;
        }
        
        int UnityEngineTime_g_get_unscaledDeltaTime(RealStatePtr L, int gen_param_count) 
        {
            
			    LuaAPI.lua_pushnumber(L, UnityEngine.Time.unscaledDeltaTime);
            return 1;
        }
        
        int UnityEngineTime_g_get_fixedUnscaledDeltaTime(RealStatePtr L, int gen_param_count) 
        {
            
			    LuaAPI.lua_pushnumber(L, UnityEngine.Time.fixedUnscaledDeltaTime);
            return 1;
        }
        
        int UnityEngineTime_g_get_fixedDeltaTime(RealStatePtr L, int gen_param_count) 
        {
            
			    LuaAPI.lua_pushnumber(L, UnityEngine.Time.fixedDeltaTime);
            return 1;
        }
        
        int UnityEngineTime_g_get_maximumDeltaTime(RealStatePtr L, int gen_param_count) 
        {
            
			    LuaAPI.lua_pushnumber(L, UnityEngine.Time.maximumDeltaTime);
            return 1;
        }
        
        int UnityEngineTime_g_get_smoothDeltaTime(RealStatePtr L, int gen_param_count) 
        {
            
			    LuaAPI.lua_pushnumber(L, UnityEngine.Time.smoothDeltaTime);
            return 1;
        }
        
        int UnityEngineTime_g_get_maximumParticleDeltaTime(RealStatePtr L, int gen_param_count) 
        {
            
			    LuaAPI.lua_pushnumber(L, UnityEngine.Time.maximumParticleDeltaTime);
            return 1;
        }
        
        int UnityEngineTime_g_get_timeScale(RealStatePtr L, int gen_param_count) 
        {
            
			    LuaAPI.lua_pushnumber(L, UnityEngine.Time.timeScale);
            return 1;
        }
        
        int UnityEngineTime_g_get_frameCount(RealStatePtr L, int gen_param_count) 
        {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.Time.frameCount);
            return 1;
        }
        
        int UnityEngineTime_g_get_renderedFrameCount(RealStatePtr L, int gen_param_count) 
        {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.Time.renderedFrameCount);
            return 1;
        }
        
        int UnityEngineTime_g_get_realtimeSinceStartup(RealStatePtr L, int gen_param_count) 
        {
            
			    LuaAPI.lua_pushnumber(L, UnityEngine.Time.realtimeSinceStartup);
            return 1;
        }
        
        int UnityEngineTime_g_get_captureDeltaTime(RealStatePtr L, int gen_param_count) 
        {
            
			    LuaAPI.lua_pushnumber(L, UnityEngine.Time.captureDeltaTime);
            return 1;
        }
        
        int UnityEngineTime_g_get_captureFramerate(RealStatePtr L, int gen_param_count) 
        {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.Time.captureFramerate);
            return 1;
        }
        
        int UnityEngineTime_g_get_inFixedTimeStep(RealStatePtr L, int gen_param_count) 
        {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.Time.inFixedTimeStep);
            return 1;
        }
        
        
        
        int UnityEngineTime_s_set_fixedDeltaTime(RealStatePtr L, int gen_param_count) 
        {
            
			UnityEngine.Time.fixedDeltaTime = (float)LuaAPI.lua_tonumber(L, 1);
            
            return 0;
        }
        
        int UnityEngineTime_s_set_maximumDeltaTime(RealStatePtr L, int gen_param_count) 
        {
            
			UnityEngine.Time.maximumDeltaTime = (float)LuaAPI.lua_tonumber(L, 1);
            
            return 0;
        }
        
        int UnityEngineTime_s_set_maximumParticleDeltaTime(RealStatePtr L, int gen_param_count) 
        {
            
			UnityEngine.Time.maximumParticleDeltaTime = (float)LuaAPI.lua_tonumber(L, 1);
            
            return 0;
        }
        
        int UnityEngineTime_s_set_timeScale(RealStatePtr L, int gen_param_count) 
        {
            
			UnityEngine.Time.timeScale = (float)LuaAPI.lua_tonumber(L, 1);
            
            return 0;
        }
        
        int UnityEngineTime_s_set_captureDeltaTime(RealStatePtr L, int gen_param_count) 
        {
            
			UnityEngine.Time.captureDeltaTime = (float)LuaAPI.lua_tonumber(L, 1);
            
            return 0;
        }
        
        int UnityEngineTime_s_set_captureFramerate(RealStatePtr L, int gen_param_count) 
        {
            
			UnityEngine.Time.captureFramerate = LuaAPI.xlua_tointeger(L, 1);
            
            return 0;
        }
        
		
		
		
		
    }
}
