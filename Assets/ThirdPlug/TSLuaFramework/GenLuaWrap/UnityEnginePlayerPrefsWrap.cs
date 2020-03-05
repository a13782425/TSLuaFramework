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
        public void __RegisterUnityEnginePlayerPrefs(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.PlayerPrefs);
			Utils.BeginObjectRegister(type, L, this, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEnginePlayerPrefs, 11, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "SetInt", UnityEnginePlayerPrefs_m_SetInt_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetInt", UnityEnginePlayerPrefs_m_GetInt_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetFloat", UnityEnginePlayerPrefs_m_SetFloat_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetFloat", UnityEnginePlayerPrefs_m_GetFloat_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetString", UnityEnginePlayerPrefs_m_SetString_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetString", UnityEnginePlayerPrefs_m_GetString_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "HasKey", UnityEnginePlayerPrefs_m_HasKey_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DeleteKey", UnityEnginePlayerPrefs_m_DeleteKey_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DeleteAll", UnityEnginePlayerPrefs_m_DeleteAll_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Save", UnityEnginePlayerPrefs_m_Save_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEnginePlayerPrefs(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			if(gen_param_count == 1)
			{
				
				UnityEngine.PlayerPrefs gen_ret = new UnityEngine.PlayerPrefs();
				translator.Push(L, gen_ret);
				
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.PlayerPrefs constructor!");
            
        }
        
		
        
		
        
        
        
        
        int UnityEnginePlayerPrefs_m_SetInt_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				string _key = LuaAPI.lua_tostring(L, 1);
				int _value = LuaAPI.xlua_tointeger(L, 2);
				
				UnityEngine.PlayerPrefs.SetInt( _key, _value );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEnginePlayerPrefs_m_GetInt_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			if(gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
			{
				string _key = LuaAPI.lua_tostring(L, 1);
				
				int gen_ret = UnityEngine.PlayerPrefs.GetInt( _key );
				LuaAPI.xlua_pushinteger(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
			{
				string _key = LuaAPI.lua_tostring(L, 1);
				int _defaultValue = LuaAPI.xlua_tointeger(L, 2);
				
				int gen_ret = UnityEngine.PlayerPrefs.GetInt( _key, _defaultValue );
				LuaAPI.xlua_pushinteger(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.PlayerPrefs.GetInt!");
            
        }
        
        int UnityEnginePlayerPrefs_m_SetFloat_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				string _key = LuaAPI.lua_tostring(L, 1);
				float _value = (float)LuaAPI.lua_tonumber(L, 2);
				
				UnityEngine.PlayerPrefs.SetFloat( _key, _value );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEnginePlayerPrefs_m_GetFloat_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			if(gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
			{
				string _key = LuaAPI.lua_tostring(L, 1);
				
				float gen_ret = UnityEngine.PlayerPrefs.GetFloat( _key );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
			{
				string _key = LuaAPI.lua_tostring(L, 1);
				float _defaultValue = (float)LuaAPI.lua_tonumber(L, 2);
				
				float gen_ret = UnityEngine.PlayerPrefs.GetFloat( _key, _defaultValue );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.PlayerPrefs.GetFloat!");
            
        }
        
        int UnityEnginePlayerPrefs_m_SetString_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				string _key = LuaAPI.lua_tostring(L, 1);
				string _value = LuaAPI.lua_tostring(L, 2);
				
				UnityEngine.PlayerPrefs.SetString( _key, _value );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEnginePlayerPrefs_m_GetString_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			if(gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
			{
				string _key = LuaAPI.lua_tostring(L, 1);
				
				string gen_ret = UnityEngine.PlayerPrefs.GetString( _key );
				LuaAPI.lua_pushstring(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
			{
				string _key = LuaAPI.lua_tostring(L, 1);
				string _defaultValue = LuaAPI.lua_tostring(L, 2);
				
				string gen_ret = UnityEngine.PlayerPrefs.GetString( _key, _defaultValue );
				LuaAPI.lua_pushstring(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.PlayerPrefs.GetString!");
            
        }
        
        int UnityEnginePlayerPrefs_m_HasKey_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				string _key = LuaAPI.lua_tostring(L, 1);
				
				bool gen_ret = UnityEngine.PlayerPrefs.HasKey( _key );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEnginePlayerPrefs_m_DeleteKey_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				string _key = LuaAPI.lua_tostring(L, 1);
				
				UnityEngine.PlayerPrefs.DeleteKey( _key );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEnginePlayerPrefs_m_DeleteAll_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				
				UnityEngine.PlayerPrefs.DeleteAll(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEnginePlayerPrefs_m_Save_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				
				UnityEngine.PlayerPrefs.Save(  );
				
				
				
				return 0;
			}
			
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
