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
        public void __RegisterUnityEngineBounds(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.Bounds);
			Utils.BeginObjectRegister(type, L, this, 1, 11, 5, 5);
			Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__eq", UnityEngineBounds__EqMeta);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetHashCode", UnityEngineBounds_m_GetHashCode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Equals", UnityEngineBounds_m_Equals);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetMinMax", UnityEngineBounds_m_SetMinMax);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Encapsulate", UnityEngineBounds_m_Encapsulate);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Expand", UnityEngineBounds_m_Expand);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Intersects", UnityEngineBounds_m_Intersects);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IntersectRay", UnityEngineBounds_m_IntersectRay);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToString", UnityEngineBounds_m_ToString);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Contains", UnityEngineBounds_m_Contains);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SqrDistance", UnityEngineBounds_m_SqrDistance);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ClosestPoint", UnityEngineBounds_m_ClosestPoint);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "center", UnityEngineBounds_g_get_center);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "size", UnityEngineBounds_g_get_size);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "extents", UnityEngineBounds_g_get_extents);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "min", UnityEngineBounds_g_get_min);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "max", UnityEngineBounds_g_get_max);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "center", UnityEngineBounds_s_set_center);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "size", UnityEngineBounds_s_set_size);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "extents", UnityEngineBounds_s_set_extents);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "min", UnityEngineBounds_s_set_min);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "max", UnityEngineBounds_s_set_max);
            
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineBounds, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineBounds(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			if(gen_param_count == 3 && translator.Assignable<UnityEngine.Vector3>(L, 2) && translator.Assignable<UnityEngine.Vector3>(L, 3))
			{
				UnityEngine.Vector3 _center;translator.Get(L, 2, out _center);
				UnityEngine.Vector3 _size;translator.Get(L, 3, out _size);
				
				UnityEngine.Bounds gen_ret = new UnityEngine.Bounds(_center, _size);
				translator.PushUnityEngineBounds(L, gen_ret);
				
				return 1;
			}
			
			if (gen_param_count == 1)
			{
				translator.PushUnityEngineBounds(L, default(UnityEngine.Bounds));
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Bounds constructor!");
            
        }
        
		
        
		
        
        
        int UnityEngineBounds__EqMeta(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
            
			if (translator.Assignable<UnityEngine.Bounds>(L, 1) && translator.Assignable<UnityEngine.Bounds>(L, 2))
			{
				UnityEngine.Bounds leftside;translator.Get(L, 1, out leftside);
				UnityEngine.Bounds rightside;translator.Get(L, 2, out rightside);
				
				LuaAPI.lua_pushboolean(L, leftside == rightside);
				
				return 1;
			}
            
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of == operator, need UnityEngine.Bounds!");
            
        }
        
        
        
        int UnityEngineBounds_m_GetHashCode(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Bounds gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			
			{
				
				int gen_ret = gen_to_be_invoked.GetHashCode(  );
				LuaAPI.xlua_pushinteger(L, gen_ret);
				
				
				translator.UpdateUnityEngineBounds(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineBounds_m_Equals(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Bounds gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			if(gen_param_count == 2&& translator.Assignable<object>(L, 2)) 
			{
				object _other = translator.GetObject(L, 2, typeof(object));
				
				bool gen_ret = gen_to_be_invoked.Equals( _other );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				translator.UpdateUnityEngineBounds(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.Bounds>(L, 2)) 
			{
				UnityEngine.Bounds _other;translator.Get(L, 2, out _other);
				
				bool gen_ret = gen_to_be_invoked.Equals( _other );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				translator.UpdateUnityEngineBounds(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Bounds.Equals!");
            
        }
        
        int UnityEngineBounds_m_SetMinMax(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Bounds gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			
			{
				UnityEngine.Vector3 _min;translator.Get(L, 2, out _min);
				UnityEngine.Vector3 _max;translator.Get(L, 3, out _max);
				
				gen_to_be_invoked.SetMinMax( _min, _max );
				
				
				translator.UpdateUnityEngineBounds(L, 1, gen_to_be_invoked);
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineBounds_m_Encapsulate(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Bounds gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
			{
				UnityEngine.Vector3 _point;translator.Get(L, 2, out _point);
				
				gen_to_be_invoked.Encapsulate( _point );
				
				
				translator.UpdateUnityEngineBounds(L, 1, gen_to_be_invoked);
				
				
				return 0;
			}
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.Bounds>(L, 2)) 
			{
				UnityEngine.Bounds _bounds;translator.Get(L, 2, out _bounds);
				
				gen_to_be_invoked.Encapsulate( _bounds );
				
				
				translator.UpdateUnityEngineBounds(L, 1, gen_to_be_invoked);
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Bounds.Encapsulate!");
            
        }
        
        int UnityEngineBounds_m_Expand(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Bounds gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
			{
				float _amount = (float)LuaAPI.lua_tonumber(L, 2);
				
				gen_to_be_invoked.Expand( _amount );
				
				
				translator.UpdateUnityEngineBounds(L, 1, gen_to_be_invoked);
				
				
				return 0;
			}
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
			{
				UnityEngine.Vector3 _amount;translator.Get(L, 2, out _amount);
				
				gen_to_be_invoked.Expand( _amount );
				
				
				translator.UpdateUnityEngineBounds(L, 1, gen_to_be_invoked);
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Bounds.Expand!");
            
        }
        
        int UnityEngineBounds_m_Intersects(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Bounds gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			
			{
				UnityEngine.Bounds _bounds;translator.Get(L, 2, out _bounds);
				
				bool gen_ret = gen_to_be_invoked.Intersects( _bounds );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				translator.UpdateUnityEngineBounds(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineBounds_m_IntersectRay(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Bounds gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.Ray>(L, 2)) 
			{
				UnityEngine.Ray _ray;translator.Get(L, 2, out _ray);
				
				bool gen_ret = gen_to_be_invoked.IntersectRay( _ray );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				translator.UpdateUnityEngineBounds(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.Ray>(L, 2)) 
			{
				UnityEngine.Ray _ray;translator.Get(L, 2, out _ray);
				float _distance;
				
				bool gen_ret = gen_to_be_invoked.IntersectRay( _ray, out _distance );
				LuaAPI.lua_pushboolean(L, gen_ret);
				LuaAPI.lua_pushnumber(L, _distance);
					
				
				
				translator.UpdateUnityEngineBounds(L, 1, gen_to_be_invoked);
				
				
				return 2;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Bounds.IntersectRay!");
            
        }
        
        int UnityEngineBounds_m_ToString(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Bounds gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			if(gen_param_count == 1) 
			{
				
				string gen_ret = gen_to_be_invoked.ToString(  );
				LuaAPI.lua_pushstring(L, gen_ret);
				
				
				translator.UpdateUnityEngineBounds(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
			{
				string _format = LuaAPI.lua_tostring(L, 2);
				
				string gen_ret = gen_to_be_invoked.ToString( _format );
				LuaAPI.lua_pushstring(L, gen_ret);
				
				
				translator.UpdateUnityEngineBounds(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Bounds.ToString!");
            
        }
        
        int UnityEngineBounds_m_Contains(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Bounds gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			
			{
				UnityEngine.Vector3 _point;translator.Get(L, 2, out _point);
				
				bool gen_ret = gen_to_be_invoked.Contains( _point );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				translator.UpdateUnityEngineBounds(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineBounds_m_SqrDistance(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Bounds gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			
			{
				UnityEngine.Vector3 _point;translator.Get(L, 2, out _point);
				
				float gen_ret = gen_to_be_invoked.SqrDistance( _point );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				translator.UpdateUnityEngineBounds(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineBounds_m_ClosestPoint(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Bounds gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			
			{
				UnityEngine.Vector3 _point;translator.Get(L, 2, out _point);
				
				UnityEngine.Vector3 gen_ret = gen_to_be_invoked.ClosestPoint( _point );
				translator.PushUnityEngineVector3(L, gen_ret);
				
				
				translator.UpdateUnityEngineBounds(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			
            
        }
        
        
        
        
        int UnityEngineBounds_g_get_center(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Bounds gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			translator.PushUnityEngineVector3(L, gen_to_be_invoked.center);
            return 1;
        }
        
        int UnityEngineBounds_g_get_size(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Bounds gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			translator.PushUnityEngineVector3(L, gen_to_be_invoked.size);
            return 1;
        }
        
        int UnityEngineBounds_g_get_extents(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Bounds gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			translator.PushUnityEngineVector3(L, gen_to_be_invoked.extents);
            return 1;
        }
        
        int UnityEngineBounds_g_get_min(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Bounds gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			translator.PushUnityEngineVector3(L, gen_to_be_invoked.min);
            return 1;
        }
        
        int UnityEngineBounds_g_get_max(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Bounds gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			translator.PushUnityEngineVector3(L, gen_to_be_invoked.max);
            return 1;
        }
        
        
        
        int UnityEngineBounds_s_set_center(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Bounds gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.center = gen_value;
            
            translator.UpdateUnityEngineBounds(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineBounds_s_set_size(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Bounds gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.size = gen_value;
            
            translator.UpdateUnityEngineBounds(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineBounds_s_set_extents(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Bounds gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.extents = gen_value;
            
            translator.UpdateUnityEngineBounds(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineBounds_s_set_min(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Bounds gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.min = gen_value;
            
            translator.UpdateUnityEngineBounds(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineBounds_s_set_max(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Bounds gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.max = gen_value;
            
            translator.UpdateUnityEngineBounds(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
		
		
		
		
    }
}
