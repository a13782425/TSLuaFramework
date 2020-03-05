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
        public void __RegisterUnityEngineQuaternion(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.Quaternion);
			Utils.BeginObjectRegister(type, L, this, 2, 8, 6, 5);
			Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__mul", UnityEngineQuaternion__MulMeta);
            Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__eq", UnityEngineQuaternion__EqMeta);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Set", UnityEngineQuaternion_m_Set);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetLookRotation", UnityEngineQuaternion_m_SetLookRotation);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToAngleAxis", UnityEngineQuaternion_m_ToAngleAxis);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetFromToRotation", UnityEngineQuaternion_m_SetFromToRotation);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Normalize", UnityEngineQuaternion_m_Normalize);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetHashCode", UnityEngineQuaternion_m_GetHashCode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Equals", UnityEngineQuaternion_m_Equals);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToString", UnityEngineQuaternion_m_ToString);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "eulerAngles", UnityEngineQuaternion_g_get_eulerAngles);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "normalized", UnityEngineQuaternion_g_get_normalized);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "x", UnityEngineQuaternion_g_get_x);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "y", UnityEngineQuaternion_g_get_y);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "z", UnityEngineQuaternion_g_get_z);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "w", UnityEngineQuaternion_g_get_w);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "eulerAngles", UnityEngineQuaternion_s_set_eulerAngles);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "x", UnityEngineQuaternion_s_set_x);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "y", UnityEngineQuaternion_s_set_y);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "z", UnityEngineQuaternion_s_set_z);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "w", UnityEngineQuaternion_s_set_w);
            
			
			Utils.EndObjectRegister(type, L, this, __CSIndexerUnityEngineQuaternion, __NewIndexerUnityEngineQuaternion,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineQuaternion, 15, 1, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "FromToRotation", UnityEngineQuaternion_m_FromToRotation_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Inverse", UnityEngineQuaternion_m_Inverse_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Slerp", UnityEngineQuaternion_m_Slerp_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SlerpUnclamped", UnityEngineQuaternion_m_SlerpUnclamped_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Lerp", UnityEngineQuaternion_m_Lerp_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LerpUnclamped", UnityEngineQuaternion_m_LerpUnclamped_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AngleAxis", UnityEngineQuaternion_m_AngleAxis_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LookRotation", UnityEngineQuaternion_m_LookRotation_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Dot", UnityEngineQuaternion_m_Dot_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Angle", UnityEngineQuaternion_m_Angle_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Euler", UnityEngineQuaternion_m_Euler_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RotateTowards", UnityEngineQuaternion_m_RotateTowards_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Normalize", UnityEngineQuaternion_m_Normalize_xlua_st_);
            
			
            Utils.RegisterObject(L, this, Utils.CLS_IDX, "kEpsilon", UnityEngine.Quaternion.kEpsilon);
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "identity", UnityEngineQuaternion_g_get_identity);
            
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineQuaternion(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			if(gen_param_count == 5 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5))
			{
				float _x = (float)LuaAPI.lua_tonumber(L, 2);
				float _y = (float)LuaAPI.lua_tonumber(L, 3);
				float _z = (float)LuaAPI.lua_tonumber(L, 4);
				float _w = (float)LuaAPI.lua_tonumber(L, 5);
				
				UnityEngine.Quaternion gen_ret = new UnityEngine.Quaternion(_x, _y, _z, _w);
				translator.PushUnityEngineQuaternion(L, gen_ret);
				
				return 1;
			}
			
			if (gen_param_count == 1)
			{
				translator.PushUnityEngineQuaternion(L, default(UnityEngine.Quaternion));
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Quaternion constructor!");
            
        }
        
		
        int __CSIndexerUnityEngineQuaternion(RealStatePtr L, int gen_param_count) 
        {
			ObjectTranslator translator = this;
			
			if (translator.Assignable<UnityEngine.Quaternion>(L, 1) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2))
			{
				
				UnityEngine.Quaternion gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
				int index = LuaAPI.xlua_tointeger(L, 2);
				LuaAPI.lua_pushboolean(L, true);
				LuaAPI.lua_pushnumber(L, gen_to_be_invoked[index]);
				return 2;
			}
			
            LuaAPI.lua_pushboolean(L, false);
			return 1;
        }
		
        
		
        int __NewIndexerUnityEngineQuaternion(RealStatePtr L, int gen_param_count) 
        {
			ObjectTranslator translator = this;
			
			
			if (translator.Assignable<UnityEngine.Quaternion>(L, 1) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3))
			{
				
				UnityEngine.Quaternion gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
				int key = LuaAPI.xlua_tointeger(L, 2);
				gen_to_be_invoked[key] = (float)LuaAPI.lua_tonumber(L, 3);
				LuaAPI.lua_pushboolean(L, true);
				return 1;
			}
			
			LuaAPI.lua_pushboolean(L, false);
            return 1;
        }
		
        
        
        int UnityEngineQuaternion__MulMeta(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
            
			if (translator.Assignable<UnityEngine.Quaternion>(L, 1) && translator.Assignable<UnityEngine.Quaternion>(L, 2))
			{
				UnityEngine.Quaternion leftside;translator.Get(L, 1, out leftside);
				UnityEngine.Quaternion rightside;translator.Get(L, 2, out rightside);
				
				translator.PushUnityEngineQuaternion(L, leftside * rightside);
				
				return 1;
			}
            
			if (translator.Assignable<UnityEngine.Quaternion>(L, 1) && translator.Assignable<UnityEngine.Vector3>(L, 2))
			{
				UnityEngine.Quaternion leftside;translator.Get(L, 1, out leftside);
				UnityEngine.Vector3 rightside;translator.Get(L, 2, out rightside);
				
				translator.PushUnityEngineVector3(L, leftside * rightside);
				
				return 1;
			}
            
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of * operator, need UnityEngine.Quaternion!");
            
        }
        
        int UnityEngineQuaternion__EqMeta(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
            
			if (translator.Assignable<UnityEngine.Quaternion>(L, 1) && translator.Assignable<UnityEngine.Quaternion>(L, 2))
			{
				UnityEngine.Quaternion leftside;translator.Get(L, 1, out leftside);
				UnityEngine.Quaternion rightside;translator.Get(L, 2, out rightside);
				
				LuaAPI.lua_pushboolean(L, leftside == rightside);
				
				return 1;
			}
            
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of == operator, need UnityEngine.Quaternion!");
            
        }
        
        
        
        int UnityEngineQuaternion_m_FromToRotation_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector3 _fromDirection;translator.Get(L, 1, out _fromDirection);
				UnityEngine.Vector3 _toDirection;translator.Get(L, 2, out _toDirection);
				
				UnityEngine.Quaternion gen_ret = UnityEngine.Quaternion.FromToRotation( _fromDirection, _toDirection );
				translator.PushUnityEngineQuaternion(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineQuaternion_m_Inverse_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Quaternion _rotation;translator.Get(L, 1, out _rotation);
				
				UnityEngine.Quaternion gen_ret = UnityEngine.Quaternion.Inverse( _rotation );
				translator.PushUnityEngineQuaternion(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineQuaternion_m_Slerp_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Quaternion _a;translator.Get(L, 1, out _a);
				UnityEngine.Quaternion _b;translator.Get(L, 2, out _b);
				float _t = (float)LuaAPI.lua_tonumber(L, 3);
				
				UnityEngine.Quaternion gen_ret = UnityEngine.Quaternion.Slerp( _a, _b, _t );
				translator.PushUnityEngineQuaternion(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineQuaternion_m_SlerpUnclamped_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Quaternion _a;translator.Get(L, 1, out _a);
				UnityEngine.Quaternion _b;translator.Get(L, 2, out _b);
				float _t = (float)LuaAPI.lua_tonumber(L, 3);
				
				UnityEngine.Quaternion gen_ret = UnityEngine.Quaternion.SlerpUnclamped( _a, _b, _t );
				translator.PushUnityEngineQuaternion(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineQuaternion_m_Lerp_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Quaternion _a;translator.Get(L, 1, out _a);
				UnityEngine.Quaternion _b;translator.Get(L, 2, out _b);
				float _t = (float)LuaAPI.lua_tonumber(L, 3);
				
				UnityEngine.Quaternion gen_ret = UnityEngine.Quaternion.Lerp( _a, _b, _t );
				translator.PushUnityEngineQuaternion(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineQuaternion_m_LerpUnclamped_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Quaternion _a;translator.Get(L, 1, out _a);
				UnityEngine.Quaternion _b;translator.Get(L, 2, out _b);
				float _t = (float)LuaAPI.lua_tonumber(L, 3);
				
				UnityEngine.Quaternion gen_ret = UnityEngine.Quaternion.LerpUnclamped( _a, _b, _t );
				translator.PushUnityEngineQuaternion(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineQuaternion_m_AngleAxis_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				float _angle = (float)LuaAPI.lua_tonumber(L, 1);
				UnityEngine.Vector3 _axis;translator.Get(L, 2, out _axis);
				
				UnityEngine.Quaternion gen_ret = UnityEngine.Quaternion.AngleAxis( _angle, _axis );
				translator.PushUnityEngineQuaternion(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineQuaternion_m_LookRotation_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			if(gen_param_count == 1&& translator.Assignable<UnityEngine.Vector3>(L, 1)) 
			{
				UnityEngine.Vector3 _forward;translator.Get(L, 1, out _forward);
				
				UnityEngine.Quaternion gen_ret = UnityEngine.Quaternion.LookRotation( _forward );
				translator.PushUnityEngineQuaternion(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
			{
				UnityEngine.Vector3 _forward;translator.Get(L, 1, out _forward);
				UnityEngine.Vector3 _upwards;translator.Get(L, 2, out _upwards);
				
				UnityEngine.Quaternion gen_ret = UnityEngine.Quaternion.LookRotation( _forward, _upwards );
				translator.PushUnityEngineQuaternion(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Quaternion.LookRotation!");
            
        }
        
        int UnityEngineQuaternion_m_Set(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Quaternion gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			
			{
				float _newX = (float)LuaAPI.lua_tonumber(L, 2);
				float _newY = (float)LuaAPI.lua_tonumber(L, 3);
				float _newZ = (float)LuaAPI.lua_tonumber(L, 4);
				float _newW = (float)LuaAPI.lua_tonumber(L, 5);
				
				gen_to_be_invoked.Set( _newX, _newY, _newZ, _newW );
				
				
				translator.UpdateUnityEngineQuaternion(L, 1, gen_to_be_invoked);
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineQuaternion_m_Dot_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Quaternion _a;translator.Get(L, 1, out _a);
				UnityEngine.Quaternion _b;translator.Get(L, 2, out _b);
				
				float gen_ret = UnityEngine.Quaternion.Dot( _a, _b );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineQuaternion_m_SetLookRotation(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Quaternion gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
			{
				UnityEngine.Vector3 _view;translator.Get(L, 2, out _view);
				
				gen_to_be_invoked.SetLookRotation( _view );
				
				
				translator.UpdateUnityEngineQuaternion(L, 1, gen_to_be_invoked);
				
				
				return 0;
			}
			if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)) 
			{
				UnityEngine.Vector3 _view;translator.Get(L, 2, out _view);
				UnityEngine.Vector3 _up;translator.Get(L, 3, out _up);
				
				gen_to_be_invoked.SetLookRotation( _view, _up );
				
				
				translator.UpdateUnityEngineQuaternion(L, 1, gen_to_be_invoked);
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Quaternion.SetLookRotation!");
            
        }
        
        int UnityEngineQuaternion_m_Angle_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Quaternion _a;translator.Get(L, 1, out _a);
				UnityEngine.Quaternion _b;translator.Get(L, 2, out _b);
				
				float gen_ret = UnityEngine.Quaternion.Angle( _a, _b );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineQuaternion_m_Euler_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
			{
				float _x = (float)LuaAPI.lua_tonumber(L, 1);
				float _y = (float)LuaAPI.lua_tonumber(L, 2);
				float _z = (float)LuaAPI.lua_tonumber(L, 3);
				
				UnityEngine.Quaternion gen_ret = UnityEngine.Quaternion.Euler( _x, _y, _z );
				translator.PushUnityEngineQuaternion(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 1&& translator.Assignable<UnityEngine.Vector3>(L, 1)) 
			{
				UnityEngine.Vector3 _euler;translator.Get(L, 1, out _euler);
				
				UnityEngine.Quaternion gen_ret = UnityEngine.Quaternion.Euler( _euler );
				translator.PushUnityEngineQuaternion(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Quaternion.Euler!");
            
        }
        
        int UnityEngineQuaternion_m_ToAngleAxis(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Quaternion gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			
			{
				float _angle;
				UnityEngine.Vector3 _axis;
				
				gen_to_be_invoked.ToAngleAxis( out _angle, out _axis );
				LuaAPI.lua_pushnumber(L, _angle);
					
				translator.PushUnityEngineVector3(L, _axis);
					
				
				
				translator.UpdateUnityEngineQuaternion(L, 1, gen_to_be_invoked);
				
				
				return 2;
			}
			
            
        }
        
        int UnityEngineQuaternion_m_SetFromToRotation(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Quaternion gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			
			{
				UnityEngine.Vector3 _fromDirection;translator.Get(L, 2, out _fromDirection);
				UnityEngine.Vector3 _toDirection;translator.Get(L, 3, out _toDirection);
				
				gen_to_be_invoked.SetFromToRotation( _fromDirection, _toDirection );
				
				
				translator.UpdateUnityEngineQuaternion(L, 1, gen_to_be_invoked);
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineQuaternion_m_RotateTowards_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Quaternion _from;translator.Get(L, 1, out _from);
				UnityEngine.Quaternion _to;translator.Get(L, 2, out _to);
				float _maxDegreesDelta = (float)LuaAPI.lua_tonumber(L, 3);
				
				UnityEngine.Quaternion gen_ret = UnityEngine.Quaternion.RotateTowards( _from, _to, _maxDegreesDelta );
				translator.PushUnityEngineQuaternion(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineQuaternion_m_Normalize_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Quaternion _q;translator.Get(L, 1, out _q);
				
				UnityEngine.Quaternion gen_ret = UnityEngine.Quaternion.Normalize( _q );
				translator.PushUnityEngineQuaternion(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineQuaternion_m_Normalize(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Quaternion gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			
			{
				
				gen_to_be_invoked.Normalize(  );
				
				
				translator.UpdateUnityEngineQuaternion(L, 1, gen_to_be_invoked);
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineQuaternion_m_GetHashCode(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Quaternion gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			
			{
				
				int gen_ret = gen_to_be_invoked.GetHashCode(  );
				LuaAPI.xlua_pushinteger(L, gen_ret);
				
				
				translator.UpdateUnityEngineQuaternion(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineQuaternion_m_Equals(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Quaternion gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			if(gen_param_count == 2&& translator.Assignable<object>(L, 2)) 
			{
				object _other = translator.GetObject(L, 2, typeof(object));
				
				bool gen_ret = gen_to_be_invoked.Equals( _other );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				translator.UpdateUnityEngineQuaternion(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.Quaternion>(L, 2)) 
			{
				UnityEngine.Quaternion _other;translator.Get(L, 2, out _other);
				
				bool gen_ret = gen_to_be_invoked.Equals( _other );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				translator.UpdateUnityEngineQuaternion(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Quaternion.Equals!");
            
        }
        
        int UnityEngineQuaternion_m_ToString(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Quaternion gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			if(gen_param_count == 1) 
			{
				
				string gen_ret = gen_to_be_invoked.ToString(  );
				LuaAPI.lua_pushstring(L, gen_ret);
				
				
				translator.UpdateUnityEngineQuaternion(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
			{
				string _format = LuaAPI.lua_tostring(L, 2);
				
				string gen_ret = gen_to_be_invoked.ToString( _format );
				LuaAPI.lua_pushstring(L, gen_ret);
				
				
				translator.UpdateUnityEngineQuaternion(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Quaternion.ToString!");
            
        }
        
        
        
        
        int UnityEngineQuaternion_g_get_identity(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.PushUnityEngineQuaternion(L, UnityEngine.Quaternion.identity);
            return 1;
        }
        
        int UnityEngineQuaternion_g_get_eulerAngles(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Quaternion gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			translator.PushUnityEngineVector3(L, gen_to_be_invoked.eulerAngles);
            return 1;
        }
        
        int UnityEngineQuaternion_g_get_normalized(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Quaternion gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			translator.PushUnityEngineQuaternion(L, gen_to_be_invoked.normalized);
            return 1;
        }
        
        int UnityEngineQuaternion_g_get_x(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Quaternion gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.x);
            return 1;
        }
        
        int UnityEngineQuaternion_g_get_y(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Quaternion gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.y);
            return 1;
        }
        
        int UnityEngineQuaternion_g_get_z(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Quaternion gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.z);
            return 1;
        }
        
        int UnityEngineQuaternion_g_get_w(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Quaternion gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.w);
            return 1;
        }
        
        
        
        int UnityEngineQuaternion_s_set_eulerAngles(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Quaternion gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.eulerAngles = gen_value;
            
            translator.UpdateUnityEngineQuaternion(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineQuaternion_s_set_x(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Quaternion gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            gen_to_be_invoked.x = (float)LuaAPI.lua_tonumber(L, 2);
            
            translator.UpdateUnityEngineQuaternion(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineQuaternion_s_set_y(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Quaternion gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            gen_to_be_invoked.y = (float)LuaAPI.lua_tonumber(L, 2);
            
            translator.UpdateUnityEngineQuaternion(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineQuaternion_s_set_z(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Quaternion gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            gen_to_be_invoked.z = (float)LuaAPI.lua_tonumber(L, 2);
            
            translator.UpdateUnityEngineQuaternion(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineQuaternion_s_set_w(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Quaternion gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            gen_to_be_invoked.w = (float)LuaAPI.lua_tonumber(L, 2);
            
            translator.UpdateUnityEngineQuaternion(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
		
		
		
		
    }
}
