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
        public void __RegisterUnityEngineRay2D(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.Ray2D);
			Utils.BeginObjectRegister(type, L, this, 0, 2, 2, 2);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPoint", UnityEngineRay2D_m_GetPoint);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToString", UnityEngineRay2D_m_ToString);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "origin", UnityEngineRay2D_g_get_origin);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "direction", UnityEngineRay2D_g_get_direction);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "origin", UnityEngineRay2D_s_set_origin);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "direction", UnityEngineRay2D_s_set_direction);
            
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineRay2D, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineRay2D(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			if(gen_param_count == 3 && translator.Assignable<UnityEngine.Vector2>(L, 2) && translator.Assignable<UnityEngine.Vector2>(L, 3))
			{
				UnityEngine.Vector2 _origin;translator.Get(L, 2, out _origin);
				UnityEngine.Vector2 _direction;translator.Get(L, 3, out _direction);
				
				UnityEngine.Ray2D gen_ret = new UnityEngine.Ray2D(_origin, _direction);
				translator.PushUnityEngineRay2D(L, gen_ret);
				
				return 1;
			}
			
			if (gen_param_count == 1)
			{
				translator.PushUnityEngineRay2D(L, default(UnityEngine.Ray2D));
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Ray2D constructor!");
            
        }
        
		
        
		
        
        
        
        
        int UnityEngineRay2D_m_GetPoint(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Ray2D gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			
			{
				float _distance = (float)LuaAPI.lua_tonumber(L, 2);
				
				UnityEngine.Vector2 gen_ret = gen_to_be_invoked.GetPoint( _distance );
				translator.PushUnityEngineVector2(L, gen_ret);
				
				
				translator.UpdateUnityEngineRay2D(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineRay2D_m_ToString(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Ray2D gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			if(gen_param_count == 1) 
			{
				
				string gen_ret = gen_to_be_invoked.ToString(  );
				LuaAPI.lua_pushstring(L, gen_ret);
				
				
				translator.UpdateUnityEngineRay2D(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
			{
				string _format = LuaAPI.lua_tostring(L, 2);
				
				string gen_ret = gen_to_be_invoked.ToString( _format );
				LuaAPI.lua_pushstring(L, gen_ret);
				
				
				translator.UpdateUnityEngineRay2D(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Ray2D.ToString!");
            
        }
        
        
        
        
        int UnityEngineRay2D_g_get_origin(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Ray2D gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			translator.PushUnityEngineVector2(L, gen_to_be_invoked.origin);
            return 1;
        }
        
        int UnityEngineRay2D_g_get_direction(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Ray2D gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			translator.PushUnityEngineVector2(L, gen_to_be_invoked.direction);
            return 1;
        }
        
        
        
        int UnityEngineRay2D_s_set_origin(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Ray2D gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.origin = gen_value;
            
            translator.UpdateUnityEngineRay2D(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineRay2D_s_set_direction(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Ray2D gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.direction = gen_value;
            
            translator.UpdateUnityEngineRay2D(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
		
		
		
		
    }
}
