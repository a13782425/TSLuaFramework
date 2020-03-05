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
        public void __RegisterUnityEngineDebug(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.Debug);
			Utils.BeginObjectRegister(type, L, this, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineDebug, 17, 3, 1);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "DrawLine", UnityEngineDebug_m_DrawLine_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DrawRay", UnityEngineDebug_m_DrawRay_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Break", UnityEngineDebug_m_Break_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DebugBreak", UnityEngineDebug_m_DebugBreak_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Log", UnityEngineDebug_m_Log_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LogFormat", UnityEngineDebug_m_LogFormat_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LogError", UnityEngineDebug_m_LogError_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LogErrorFormat", UnityEngineDebug_m_LogErrorFormat_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ClearDeveloperConsole", UnityEngineDebug_m_ClearDeveloperConsole_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LogException", UnityEngineDebug_m_LogException_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LogWarning", UnityEngineDebug_m_LogWarning_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LogWarningFormat", UnityEngineDebug_m_LogWarningFormat_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Assert", UnityEngineDebug_m_Assert_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AssertFormat", UnityEngineDebug_m_AssertFormat_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LogAssertion", UnityEngineDebug_m_LogAssertion_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LogAssertionFormat", UnityEngineDebug_m_LogAssertionFormat_xlua_st_);
            
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "unityLogger", UnityEngineDebug_g_get_unityLogger);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "developerConsoleVisible", UnityEngineDebug_g_get_developerConsoleVisible);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "isDebugBuild", UnityEngineDebug_g_get_isDebugBuild);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "developerConsoleVisible", UnityEngineDebug_s_set_developerConsoleVisible);
            
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineDebug(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			if(gen_param_count == 1)
			{
				
				UnityEngine.Debug gen_ret = new UnityEngine.Debug();
				translator.Push(L, gen_ret);
				
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Debug constructor!");
            
        }
        
		
        
		
        
        
        
        
        int UnityEngineDebug_m_DrawLine_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
			{
				UnityEngine.Vector3 _start;translator.Get(L, 1, out _start);
				UnityEngine.Vector3 _end;translator.Get(L, 2, out _end);
				
				UnityEngine.Debug.DrawLine( _start, _end );
				
				
				
				return 0;
			}
			if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Color>(L, 3)) 
			{
				UnityEngine.Vector3 _start;translator.Get(L, 1, out _start);
				UnityEngine.Vector3 _end;translator.Get(L, 2, out _end);
				UnityEngine.Color _color;translator.Get(L, 3, out _color);
				
				UnityEngine.Debug.DrawLine( _start, _end, _color );
				
				
				
				return 0;
			}
			if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Color>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
			{
				UnityEngine.Vector3 _start;translator.Get(L, 1, out _start);
				UnityEngine.Vector3 _end;translator.Get(L, 2, out _end);
				UnityEngine.Color _color;translator.Get(L, 3, out _color);
				float _duration = (float)LuaAPI.lua_tonumber(L, 4);
				
				UnityEngine.Debug.DrawLine( _start, _end, _color, _duration );
				
				
				
				return 0;
			}
			if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Color>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5)) 
			{
				UnityEngine.Vector3 _start;translator.Get(L, 1, out _start);
				UnityEngine.Vector3 _end;translator.Get(L, 2, out _end);
				UnityEngine.Color _color;translator.Get(L, 3, out _color);
				float _duration = (float)LuaAPI.lua_tonumber(L, 4);
				bool _depthTest = LuaAPI.lua_toboolean(L, 5);
				
				UnityEngine.Debug.DrawLine( _start, _end, _color, _duration, _depthTest );
				
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Debug.DrawLine!");
            
        }
        
        int UnityEngineDebug_m_DrawRay_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
			{
				UnityEngine.Vector3 _start;translator.Get(L, 1, out _start);
				UnityEngine.Vector3 _dir;translator.Get(L, 2, out _dir);
				
				UnityEngine.Debug.DrawRay( _start, _dir );
				
				
				
				return 0;
			}
			if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Color>(L, 3)) 
			{
				UnityEngine.Vector3 _start;translator.Get(L, 1, out _start);
				UnityEngine.Vector3 _dir;translator.Get(L, 2, out _dir);
				UnityEngine.Color _color;translator.Get(L, 3, out _color);
				
				UnityEngine.Debug.DrawRay( _start, _dir, _color );
				
				
				
				return 0;
			}
			if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Color>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
			{
				UnityEngine.Vector3 _start;translator.Get(L, 1, out _start);
				UnityEngine.Vector3 _dir;translator.Get(L, 2, out _dir);
				UnityEngine.Color _color;translator.Get(L, 3, out _color);
				float _duration = (float)LuaAPI.lua_tonumber(L, 4);
				
				UnityEngine.Debug.DrawRay( _start, _dir, _color, _duration );
				
				
				
				return 0;
			}
			if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Color>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5)) 
			{
				UnityEngine.Vector3 _start;translator.Get(L, 1, out _start);
				UnityEngine.Vector3 _dir;translator.Get(L, 2, out _dir);
				UnityEngine.Color _color;translator.Get(L, 3, out _color);
				float _duration = (float)LuaAPI.lua_tonumber(L, 4);
				bool _depthTest = LuaAPI.lua_toboolean(L, 5);
				
				UnityEngine.Debug.DrawRay( _start, _dir, _color, _duration, _depthTest );
				
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Debug.DrawRay!");
            
        }
        
        int UnityEngineDebug_m_Break_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				
				UnityEngine.Debug.Break(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineDebug_m_DebugBreak_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				
				UnityEngine.Debug.DebugBreak(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineDebug_m_Log_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			if(gen_param_count == 1&& translator.Assignable<object>(L, 1)) 
			{
				object _message = translator.GetObject(L, 1, typeof(object));
				
				UnityEngine.Debug.Log( _message );
				
				
				
				return 0;
			}
			if(gen_param_count == 2&& translator.Assignable<object>(L, 1)&& translator.Assignable<UnityEngine.Object>(L, 2)) 
			{
				object _message = translator.GetObject(L, 1, typeof(object));
				UnityEngine.Object _context = (UnityEngine.Object)translator.GetObject(L, 2, typeof(UnityEngine.Object));
				
				UnityEngine.Debug.Log( _message, _context );
				
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Debug.Log!");
            
        }
        
        int UnityEngineDebug_m_LogFormat_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			if(gen_param_count >= 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<object>(L, 2))) 
			{
				string _format = LuaAPI.lua_tostring(L, 1);
				object[] _args = translator.GetParams<object>(L, 2);
				
				UnityEngine.Debug.LogFormat( _format, _args );
				
				
				
				return 0;
			}
			if(gen_param_count >= 2&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<object>(L, 3))) 
			{
				UnityEngine.Object _context = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
				string _format = LuaAPI.lua_tostring(L, 2);
				object[] _args = translator.GetParams<object>(L, 3);
				
				UnityEngine.Debug.LogFormat( _context, _format, _args );
				
				
				
				return 0;
			}
			if(gen_param_count >= 4&& translator.Assignable<UnityEngine.LogType>(L, 1)&& translator.Assignable<UnityEngine.LogOption>(L, 2)&& translator.Assignable<UnityEngine.Object>(L, 3)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 5) || translator.Assignable<object>(L, 5))) 
			{
				UnityEngine.LogType _logType;translator.Get(L, 1, out _logType);
				UnityEngine.LogOption _logOptions;translator.Get(L, 2, out _logOptions);
				UnityEngine.Object _context = (UnityEngine.Object)translator.GetObject(L, 3, typeof(UnityEngine.Object));
				string _format = LuaAPI.lua_tostring(L, 4);
				object[] _args = translator.GetParams<object>(L, 5);
				
				UnityEngine.Debug.LogFormat( _logType, _logOptions, _context, _format, _args );
				
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Debug.LogFormat!");
            
        }
        
        int UnityEngineDebug_m_LogError_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			if(gen_param_count == 1&& translator.Assignable<object>(L, 1)) 
			{
				object _message = translator.GetObject(L, 1, typeof(object));
				
				UnityEngine.Debug.LogError( _message );
				
				
				
				return 0;
			}
			if(gen_param_count == 2&& translator.Assignable<object>(L, 1)&& translator.Assignable<UnityEngine.Object>(L, 2)) 
			{
				object _message = translator.GetObject(L, 1, typeof(object));
				UnityEngine.Object _context = (UnityEngine.Object)translator.GetObject(L, 2, typeof(UnityEngine.Object));
				
				UnityEngine.Debug.LogError( _message, _context );
				
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Debug.LogError!");
            
        }
        
        int UnityEngineDebug_m_LogErrorFormat_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			if(gen_param_count >= 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<object>(L, 2))) 
			{
				string _format = LuaAPI.lua_tostring(L, 1);
				object[] _args = translator.GetParams<object>(L, 2);
				
				UnityEngine.Debug.LogErrorFormat( _format, _args );
				
				
				
				return 0;
			}
			if(gen_param_count >= 2&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<object>(L, 3))) 
			{
				UnityEngine.Object _context = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
				string _format = LuaAPI.lua_tostring(L, 2);
				object[] _args = translator.GetParams<object>(L, 3);
				
				UnityEngine.Debug.LogErrorFormat( _context, _format, _args );
				
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Debug.LogErrorFormat!");
            
        }
        
        int UnityEngineDebug_m_ClearDeveloperConsole_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				
				UnityEngine.Debug.ClearDeveloperConsole(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineDebug_m_LogException_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			if(gen_param_count == 1&& translator.Assignable<System.Exception>(L, 1)) 
			{
				System.Exception _exception = (System.Exception)translator.GetObject(L, 1, typeof(System.Exception));
				
				UnityEngine.Debug.LogException( _exception );
				
				
				
				return 0;
			}
			if(gen_param_count == 2&& translator.Assignable<System.Exception>(L, 1)&& translator.Assignable<UnityEngine.Object>(L, 2)) 
			{
				System.Exception _exception = (System.Exception)translator.GetObject(L, 1, typeof(System.Exception));
				UnityEngine.Object _context = (UnityEngine.Object)translator.GetObject(L, 2, typeof(UnityEngine.Object));
				
				UnityEngine.Debug.LogException( _exception, _context );
				
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Debug.LogException!");
            
        }
        
        int UnityEngineDebug_m_LogWarning_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			if(gen_param_count == 1&& translator.Assignable<object>(L, 1)) 
			{
				object _message = translator.GetObject(L, 1, typeof(object));
				
				UnityEngine.Debug.LogWarning( _message );
				
				
				
				return 0;
			}
			if(gen_param_count == 2&& translator.Assignable<object>(L, 1)&& translator.Assignable<UnityEngine.Object>(L, 2)) 
			{
				object _message = translator.GetObject(L, 1, typeof(object));
				UnityEngine.Object _context = (UnityEngine.Object)translator.GetObject(L, 2, typeof(UnityEngine.Object));
				
				UnityEngine.Debug.LogWarning( _message, _context );
				
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Debug.LogWarning!");
            
        }
        
        int UnityEngineDebug_m_LogWarningFormat_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			if(gen_param_count >= 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<object>(L, 2))) 
			{
				string _format = LuaAPI.lua_tostring(L, 1);
				object[] _args = translator.GetParams<object>(L, 2);
				
				UnityEngine.Debug.LogWarningFormat( _format, _args );
				
				
				
				return 0;
			}
			if(gen_param_count >= 2&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<object>(L, 3))) 
			{
				UnityEngine.Object _context = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
				string _format = LuaAPI.lua_tostring(L, 2);
				object[] _args = translator.GetParams<object>(L, 3);
				
				UnityEngine.Debug.LogWarningFormat( _context, _format, _args );
				
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Debug.LogWarningFormat!");
            
        }
        
        int UnityEngineDebug_m_Assert_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			if(gen_param_count == 1&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 1)) 
			{
				bool _condition = LuaAPI.lua_toboolean(L, 1);
				
				UnityEngine.Debug.Assert( _condition );
				
				
				
				return 0;
			}
			if(gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Object>(L, 2)) 
			{
				bool _condition = LuaAPI.lua_toboolean(L, 1);
				UnityEngine.Object _context = (UnityEngine.Object)translator.GetObject(L, 2, typeof(UnityEngine.Object));
				
				UnityEngine.Debug.Assert( _condition, _context );
				
				
				
				return 0;
			}
			if(gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 1)&& translator.Assignable<object>(L, 2)) 
			{
				bool _condition = LuaAPI.lua_toboolean(L, 1);
				object _message = translator.GetObject(L, 2, typeof(object));
				
				UnityEngine.Debug.Assert( _condition, _message );
				
				
				
				return 0;
			}
			if(gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
			{
				bool _condition = LuaAPI.lua_toboolean(L, 1);
				string _message = LuaAPI.lua_tostring(L, 2);
				
				UnityEngine.Debug.Assert( _condition, _message );
				
				
				
				return 0;
			}
			if(gen_param_count == 3&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 1)&& translator.Assignable<object>(L, 2)&& translator.Assignable<UnityEngine.Object>(L, 3)) 
			{
				bool _condition = LuaAPI.lua_toboolean(L, 1);
				object _message = translator.GetObject(L, 2, typeof(object));
				UnityEngine.Object _context = (UnityEngine.Object)translator.GetObject(L, 3, typeof(UnityEngine.Object));
				
				UnityEngine.Debug.Assert( _condition, _message, _context );
				
				
				
				return 0;
			}
			if(gen_param_count == 3&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Object>(L, 3)) 
			{
				bool _condition = LuaAPI.lua_toboolean(L, 1);
				string _message = LuaAPI.lua_tostring(L, 2);
				UnityEngine.Object _context = (UnityEngine.Object)translator.GetObject(L, 3, typeof(UnityEngine.Object));
				
				UnityEngine.Debug.Assert( _condition, _message, _context );
				
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Debug.Assert!");
            
        }
        
        int UnityEngineDebug_m_AssertFormat_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			if(gen_param_count >= 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<object>(L, 3))) 
			{
				bool _condition = LuaAPI.lua_toboolean(L, 1);
				string _format = LuaAPI.lua_tostring(L, 2);
				object[] _args = translator.GetParams<object>(L, 3);
				
				UnityEngine.Debug.AssertFormat( _condition, _format, _args );
				
				
				
				return 0;
			}
			if(gen_param_count >= 3&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Object>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<object>(L, 4))) 
			{
				bool _condition = LuaAPI.lua_toboolean(L, 1);
				UnityEngine.Object _context = (UnityEngine.Object)translator.GetObject(L, 2, typeof(UnityEngine.Object));
				string _format = LuaAPI.lua_tostring(L, 3);
				object[] _args = translator.GetParams<object>(L, 4);
				
				UnityEngine.Debug.AssertFormat( _condition, _context, _format, _args );
				
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Debug.AssertFormat!");
            
        }
        
        int UnityEngineDebug_m_LogAssertion_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			if(gen_param_count == 1&& translator.Assignable<object>(L, 1)) 
			{
				object _message = translator.GetObject(L, 1, typeof(object));
				
				UnityEngine.Debug.LogAssertion( _message );
				
				
				
				return 0;
			}
			if(gen_param_count == 2&& translator.Assignable<object>(L, 1)&& translator.Assignable<UnityEngine.Object>(L, 2)) 
			{
				object _message = translator.GetObject(L, 1, typeof(object));
				UnityEngine.Object _context = (UnityEngine.Object)translator.GetObject(L, 2, typeof(UnityEngine.Object));
				
				UnityEngine.Debug.LogAssertion( _message, _context );
				
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Debug.LogAssertion!");
            
        }
        
        int UnityEngineDebug_m_LogAssertionFormat_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			if(gen_param_count >= 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<object>(L, 2))) 
			{
				string _format = LuaAPI.lua_tostring(L, 1);
				object[] _args = translator.GetParams<object>(L, 2);
				
				UnityEngine.Debug.LogAssertionFormat( _format, _args );
				
				
				
				return 0;
			}
			if(gen_param_count >= 2&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<object>(L, 3))) 
			{
				UnityEngine.Object _context = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
				string _format = LuaAPI.lua_tostring(L, 2);
				object[] _args = translator.GetParams<object>(L, 3);
				
				UnityEngine.Debug.LogAssertionFormat( _context, _format, _args );
				
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Debug.LogAssertionFormat!");
            
        }
        
        
        
        
        int UnityEngineDebug_g_get_unityLogger(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.PushAny(L, UnityEngine.Debug.unityLogger);
            return 1;
        }
        
        int UnityEngineDebug_g_get_developerConsoleVisible(RealStatePtr L, int gen_param_count) 
        {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.Debug.developerConsoleVisible);
            return 1;
        }
        
        int UnityEngineDebug_g_get_isDebugBuild(RealStatePtr L, int gen_param_count) 
        {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.Debug.isDebugBuild);
            return 1;
        }
        
        
        
        int UnityEngineDebug_s_set_developerConsoleVisible(RealStatePtr L, int gen_param_count) 
        {
            
			UnityEngine.Debug.developerConsoleVisible = LuaAPI.lua_toboolean(L, 1);
            
            return 0;
        }
        
		
		
		
		
    }
}
