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
        public void __RegisterUnityEnginePlane(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.Plane);
			Utils.BeginObjectRegister(type, L, this, 0, 10, 3, 2);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetNormalAndPosition", UnityEnginePlane_m_SetNormalAndPosition);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Set3Points", UnityEnginePlane_m_Set3Points);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Flip", UnityEnginePlane_m_Flip);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Translate", UnityEnginePlane_m_Translate);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ClosestPointOnPlane", UnityEnginePlane_m_ClosestPointOnPlane);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetDistanceToPoint", UnityEnginePlane_m_GetDistanceToPoint);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetSide", UnityEnginePlane_m_GetSide);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SameSide", UnityEnginePlane_m_SameSide);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Raycast", UnityEnginePlane_m_Raycast);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToString", UnityEnginePlane_m_ToString);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "normal", UnityEnginePlane_g_get_normal);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "distance", UnityEnginePlane_g_get_distance);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "flipped", UnityEnginePlane_g_get_flipped);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "normal", UnityEnginePlane_s_set_normal);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "distance", UnityEnginePlane_s_set_distance);
            
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEnginePlane, 2, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Translate", UnityEnginePlane_m_Translate_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEnginePlane(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			if(gen_param_count == 3 && translator.Assignable<UnityEngine.Vector3>(L, 2) && translator.Assignable<UnityEngine.Vector3>(L, 3))
			{
				UnityEngine.Vector3 _inNormal;translator.Get(L, 2, out _inNormal);
				UnityEngine.Vector3 _inPoint;translator.Get(L, 3, out _inPoint);
				
				UnityEngine.Plane gen_ret = new UnityEngine.Plane(_inNormal, _inPoint);
				translator.Push(L, gen_ret);
				
				return 1;
			}
			if(gen_param_count == 3 && translator.Assignable<UnityEngine.Vector3>(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3))
			{
				UnityEngine.Vector3 _inNormal;translator.Get(L, 2, out _inNormal);
				float _d = (float)LuaAPI.lua_tonumber(L, 3);
				
				UnityEngine.Plane gen_ret = new UnityEngine.Plane(_inNormal, _d);
				translator.Push(L, gen_ret);
				
				return 1;
			}
			if(gen_param_count == 4 && translator.Assignable<UnityEngine.Vector3>(L, 2) && translator.Assignable<UnityEngine.Vector3>(L, 3) && translator.Assignable<UnityEngine.Vector3>(L, 4))
			{
				UnityEngine.Vector3 _a;translator.Get(L, 2, out _a);
				UnityEngine.Vector3 _b;translator.Get(L, 3, out _b);
				UnityEngine.Vector3 _c;translator.Get(L, 4, out _c);
				
				UnityEngine.Plane gen_ret = new UnityEngine.Plane(_a, _b, _c);
				translator.Push(L, gen_ret);
				
				return 1;
			}
			
			if (gen_param_count == 1)
			{
				translator.Push(L, default(UnityEngine.Plane));
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Plane constructor!");
            
        }
        
		
        
		
        
        
        
        
        int UnityEnginePlane_m_SetNormalAndPosition(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Plane gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			
			{
				UnityEngine.Vector3 _inNormal;translator.Get(L, 2, out _inNormal);
				UnityEngine.Vector3 _inPoint;translator.Get(L, 3, out _inPoint);
				
				gen_to_be_invoked.SetNormalAndPosition( _inNormal, _inPoint );
				
				
				translator.Update(L, 1, gen_to_be_invoked);
				
				
				return 0;
			}
			
            
        }
        
        int UnityEnginePlane_m_Set3Points(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Plane gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			
			{
				UnityEngine.Vector3 _a;translator.Get(L, 2, out _a);
				UnityEngine.Vector3 _b;translator.Get(L, 3, out _b);
				UnityEngine.Vector3 _c;translator.Get(L, 4, out _c);
				
				gen_to_be_invoked.Set3Points( _a, _b, _c );
				
				
				translator.Update(L, 1, gen_to_be_invoked);
				
				
				return 0;
			}
			
            
        }
        
        int UnityEnginePlane_m_Flip(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Plane gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			
			{
				
				gen_to_be_invoked.Flip(  );
				
				
				translator.Update(L, 1, gen_to_be_invoked);
				
				
				return 0;
			}
			
            
        }
        
        int UnityEnginePlane_m_Translate(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Plane gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			
			{
				UnityEngine.Vector3 _translation;translator.Get(L, 2, out _translation);
				
				gen_to_be_invoked.Translate( _translation );
				
				
				translator.Update(L, 1, gen_to_be_invoked);
				
				
				return 0;
			}
			
            
        }
        
        int UnityEnginePlane_m_Translate_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Plane _plane;translator.Get(L, 1, out _plane);
				UnityEngine.Vector3 _translation;translator.Get(L, 2, out _translation);
				
				UnityEngine.Plane gen_ret = UnityEngine.Plane.Translate( _plane, _translation );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEnginePlane_m_ClosestPointOnPlane(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Plane gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			
			{
				UnityEngine.Vector3 _point;translator.Get(L, 2, out _point);
				
				UnityEngine.Vector3 gen_ret = gen_to_be_invoked.ClosestPointOnPlane( _point );
				translator.PushUnityEngineVector3(L, gen_ret);
				
				
				translator.Update(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			
            
        }
        
        int UnityEnginePlane_m_GetDistanceToPoint(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Plane gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			
			{
				UnityEngine.Vector3 _point;translator.Get(L, 2, out _point);
				
				float gen_ret = gen_to_be_invoked.GetDistanceToPoint( _point );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				translator.Update(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			
            
        }
        
        int UnityEnginePlane_m_GetSide(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Plane gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			
			{
				UnityEngine.Vector3 _point;translator.Get(L, 2, out _point);
				
				bool gen_ret = gen_to_be_invoked.GetSide( _point );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				translator.Update(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			
            
        }
        
        int UnityEnginePlane_m_SameSide(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Plane gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			
			{
				UnityEngine.Vector3 _inPt0;translator.Get(L, 2, out _inPt0);
				UnityEngine.Vector3 _inPt1;translator.Get(L, 3, out _inPt1);
				
				bool gen_ret = gen_to_be_invoked.SameSide( _inPt0, _inPt1 );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				translator.Update(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			
            
        }
        
        int UnityEnginePlane_m_Raycast(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Plane gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			
			{
				UnityEngine.Ray _ray;translator.Get(L, 2, out _ray);
				float _enter;
				
				bool gen_ret = gen_to_be_invoked.Raycast( _ray, out _enter );
				LuaAPI.lua_pushboolean(L, gen_ret);
				LuaAPI.lua_pushnumber(L, _enter);
					
				
				
				translator.Update(L, 1, gen_to_be_invoked);
				
				
				return 2;
			}
			
            
        }
        
        int UnityEnginePlane_m_ToString(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Plane gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			if(gen_param_count == 1) 
			{
				
				string gen_ret = gen_to_be_invoked.ToString(  );
				LuaAPI.lua_pushstring(L, gen_ret);
				
				
				translator.Update(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
			{
				string _format = LuaAPI.lua_tostring(L, 2);
				
				string gen_ret = gen_to_be_invoked.ToString( _format );
				LuaAPI.lua_pushstring(L, gen_ret);
				
				
				translator.Update(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Plane.ToString!");
            
        }
        
        
        
        
        int UnityEnginePlane_g_get_normal(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Plane gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			translator.PushUnityEngineVector3(L, gen_to_be_invoked.normal);
            return 1;
        }
        
        int UnityEnginePlane_g_get_distance(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Plane gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.distance);
            return 1;
        }
        
        int UnityEnginePlane_g_get_flipped(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Plane gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			translator.Push(L, gen_to_be_invoked.flipped);
            return 1;
        }
        
        
        
        int UnityEnginePlane_s_set_normal(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Plane gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.normal = gen_value;
            
            translator.Update(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEnginePlane_s_set_distance(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Plane gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            gen_to_be_invoked.distance = (float)LuaAPI.lua_tonumber(L, 2);
            
            translator.Update(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
		
		
		
		
    }
}
