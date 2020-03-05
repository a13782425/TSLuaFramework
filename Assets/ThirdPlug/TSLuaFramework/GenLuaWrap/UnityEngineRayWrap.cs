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
        public void __RegisterUnityEngineRay(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.Ray);
			Utils.BeginObjectRegister(type, L, this, 0, 2, 2, 2);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPoint", UnityEngineRay_m_GetPoint);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToString", UnityEngineRay_m_ToString);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "origin", UnityEngineRay_g_get_origin);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "direction", UnityEngineRay_g_get_direction);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "origin", UnityEngineRay_s_set_origin);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "direction", UnityEngineRay_s_set_direction);
            
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineRay, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineRay(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			if(gen_param_count == 3 && translator.Assignable<UnityEngine.Vector3>(L, 2) && translator.Assignable<UnityEngine.Vector3>(L, 3))
			{
				UnityEngine.Vector3 _origin;translator.Get(L, 2, out _origin);
				UnityEngine.Vector3 _direction;translator.Get(L, 3, out _direction);
				
				UnityEngine.Ray gen_ret = new UnityEngine.Ray(_origin, _direction);
				translator.PushUnityEngineRay(L, gen_ret);
				
				return 1;
			}
			
			if (gen_param_count == 1)
			{
				translator.PushUnityEngineRay(L, default(UnityEngine.Ray));
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Ray constructor!");
            
        }
        
		
        
		
        
        
        
        
        int UnityEngineRay_m_GetPoint(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Ray gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			
			{
				float _distance = (float)LuaAPI.lua_tonumber(L, 2);
				
				UnityEngine.Vector3 gen_ret = gen_to_be_invoked.GetPoint( _distance );
				translator.PushUnityEngineVector3(L, gen_ret);
				
				
				translator.UpdateUnityEngineRay(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineRay_m_ToString(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Ray gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			if(gen_param_count == 1) 
			{
				
				string gen_ret = gen_to_be_invoked.ToString(  );
				LuaAPI.lua_pushstring(L, gen_ret);
				
				
				translator.UpdateUnityEngineRay(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
			{
				string _format = LuaAPI.lua_tostring(L, 2);
				
				string gen_ret = gen_to_be_invoked.ToString( _format );
				LuaAPI.lua_pushstring(L, gen_ret);
				
				
				translator.UpdateUnityEngineRay(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Ray.ToString!");
            
        }
        
        
        
        
        int UnityEngineRay_g_get_origin(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Ray gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			translator.PushUnityEngineVector3(L, gen_to_be_invoked.origin);
            return 1;
        }
        
        int UnityEngineRay_g_get_direction(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Ray gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			translator.PushUnityEngineVector3(L, gen_to_be_invoked.direction);
            return 1;
        }
        
        
        
        int UnityEngineRay_s_set_origin(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Ray gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.origin = gen_value;
            
            translator.UpdateUnityEngineRay(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineRay_s_set_direction(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Ray gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.direction = gen_value;
            
            translator.UpdateUnityEngineRay(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
		
		
		
		
    }
}
