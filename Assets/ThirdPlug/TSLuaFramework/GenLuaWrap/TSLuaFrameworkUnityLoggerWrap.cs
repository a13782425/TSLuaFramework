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
        public void __RegisterTSLuaFrameworkUnityLogger(RealStatePtr L) 
        {
		    System.Type type = typeof(TSLuaFramework.UnityLogger);
			Utils.BeginObjectRegister(type, L, this, 0, 3, 1, 1);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Log", TSLuaFrameworkUnityLogger_m_Log);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LogWarning", TSLuaFrameworkUnityLogger_m_LogWarning);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LogError", TSLuaFrameworkUnityLogger_m_LogError);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsEnable", TSLuaFrameworkUnityLogger_g_get_IsEnable);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "IsEnable", TSLuaFrameworkUnityLogger_s_set_IsEnable);
            
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceTSLuaFrameworkUnityLogger, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceTSLuaFrameworkUnityLogger(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			if(gen_param_count == 2 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING))
			{
				string _name = LuaAPI.lua_tostring(L, 2);
				
				TSLuaFramework.UnityLogger gen_ret = new TSLuaFramework.UnityLogger(_name);
				translator.Push(L, gen_ret);
				
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to TSLuaFramework.UnityLogger constructor!");
            
        }
        
		
        
		
        
        
        
        
        int TSLuaFrameworkUnityLogger_m_Log(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            TSLuaFramework.UnityLogger gen_to_be_invoked = (TSLuaFramework.UnityLogger)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
			{
				string _message = LuaAPI.lua_tostring(L, 2);
				
				gen_to_be_invoked.Log( _message );
				
				
				
				return 0;
			}
			if(gen_param_count == 2&& translator.Assignable<object>(L, 2)) 
			{
				object _message = translator.GetObject(L, 2, typeof(object));
				
				gen_to_be_invoked.Log( _message );
				
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to TSLuaFramework.UnityLogger.Log!");
            
        }
        
        int TSLuaFrameworkUnityLogger_m_LogWarning(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            TSLuaFramework.UnityLogger gen_to_be_invoked = (TSLuaFramework.UnityLogger)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
			{
				string _message = LuaAPI.lua_tostring(L, 2);
				
				gen_to_be_invoked.LogWarning( _message );
				
				
				
				return 0;
			}
			if(gen_param_count == 2&& translator.Assignable<object>(L, 2)) 
			{
				object _message = translator.GetObject(L, 2, typeof(object));
				
				gen_to_be_invoked.LogWarning( _message );
				
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to TSLuaFramework.UnityLogger.LogWarning!");
            
        }
        
        int TSLuaFrameworkUnityLogger_m_LogError(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            TSLuaFramework.UnityLogger gen_to_be_invoked = (TSLuaFramework.UnityLogger)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
			{
				string _message = LuaAPI.lua_tostring(L, 2);
				
				gen_to_be_invoked.LogError( _message );
				
				
				
				return 0;
			}
			if(gen_param_count == 2&& translator.Assignable<object>(L, 2)) 
			{
				object _message = translator.GetObject(L, 2, typeof(object));
				
				gen_to_be_invoked.LogError( _message );
				
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to TSLuaFramework.UnityLogger.LogError!");
            
        }
        
        
        
        
        int TSLuaFrameworkUnityLogger_g_get_IsEnable(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			TSLuaFramework.UnityLogger gen_to_be_invoked = (TSLuaFramework.UnityLogger)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsEnable);
            return 1;
        }
        
        
        
        int TSLuaFrameworkUnityLogger_s_set_IsEnable(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            TSLuaFramework.UnityLogger gen_to_be_invoked = (TSLuaFramework.UnityLogger)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.IsEnable = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
		
		
		
		
    }
}
