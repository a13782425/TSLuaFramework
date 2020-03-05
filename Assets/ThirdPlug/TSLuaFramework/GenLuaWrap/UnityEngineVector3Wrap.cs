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
        public void __RegisterUnityEngineVector3(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.Vector3);
			Utils.BeginObjectRegister(type, L, this, 6, 6, 6, 3);
			Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__add", UnityEngineVector3__AddMeta);
            Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__sub", UnityEngineVector3__SubMeta);
            Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__unm", UnityEngineVector3__UnmMeta);
            Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__mul", UnityEngineVector3__MulMeta);
            Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__div", UnityEngineVector3__DivMeta);
            Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__eq", UnityEngineVector3__EqMeta);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Set", UnityEngineVector3_m_Set);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Scale", UnityEngineVector3_m_Scale);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetHashCode", UnityEngineVector3_m_GetHashCode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Equals", UnityEngineVector3_m_Equals);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Normalize", UnityEngineVector3_m_Normalize);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToString", UnityEngineVector3_m_ToString);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "normalized", UnityEngineVector3_g_get_normalized);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "magnitude", UnityEngineVector3_g_get_magnitude);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sqrMagnitude", UnityEngineVector3_g_get_sqrMagnitude);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "x", UnityEngineVector3_g_get_x);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "y", UnityEngineVector3_g_get_y);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "z", UnityEngineVector3_g_get_z);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "x", UnityEngineVector3_s_set_x);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "y", UnityEngineVector3_s_set_y);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "z", UnityEngineVector3_s_set_z);
            
			
			Utils.EndObjectRegister(type, L, this, __CSIndexerUnityEngineVector3, __NewIndexerUnityEngineVector3,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineVector3, 26, 10, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Slerp", UnityEngineVector3_m_Slerp_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SlerpUnclamped", UnityEngineVector3_m_SlerpUnclamped_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "OrthoNormalize", UnityEngineVector3_m_OrthoNormalize_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RotateTowards", UnityEngineVector3_m_RotateTowards_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Lerp", UnityEngineVector3_m_Lerp_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LerpUnclamped", UnityEngineVector3_m_LerpUnclamped_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MoveTowards", UnityEngineVector3_m_MoveTowards_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SmoothDamp", UnityEngineVector3_m_SmoothDamp_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Scale", UnityEngineVector3_m_Scale_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Cross", UnityEngineVector3_m_Cross_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Reflect", UnityEngineVector3_m_Reflect_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Normalize", UnityEngineVector3_m_Normalize_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Dot", UnityEngineVector3_m_Dot_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Project", UnityEngineVector3_m_Project_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ProjectOnPlane", UnityEngineVector3_m_ProjectOnPlane_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Angle", UnityEngineVector3_m_Angle_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SignedAngle", UnityEngineVector3_m_SignedAngle_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Distance", UnityEngineVector3_m_Distance_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ClampMagnitude", UnityEngineVector3_m_ClampMagnitude_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Magnitude", UnityEngineVector3_m_Magnitude_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SqrMagnitude", UnityEngineVector3_m_SqrMagnitude_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Min", UnityEngineVector3_m_Min_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Max", UnityEngineVector3_m_Max_xlua_st_);
            
			
            Utils.RegisterObject(L, this, Utils.CLS_IDX, "kEpsilon", UnityEngine.Vector3.kEpsilon);
            Utils.RegisterObject(L, this, Utils.CLS_IDX, "kEpsilonNormalSqrt", UnityEngine.Vector3.kEpsilonNormalSqrt);
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "zero", UnityEngineVector3_g_get_zero);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "one", UnityEngineVector3_g_get_one);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "forward", UnityEngineVector3_g_get_forward);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "back", UnityEngineVector3_g_get_back);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "up", UnityEngineVector3_g_get_up);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "down", UnityEngineVector3_g_get_down);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "left", UnityEngineVector3_g_get_left);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "right", UnityEngineVector3_g_get_right);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "positiveInfinity", UnityEngineVector3_g_get_positiveInfinity);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "negativeInfinity", UnityEngineVector3_g_get_negativeInfinity);
            
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineVector3(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			if(gen_param_count == 4 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4))
			{
				float _x = (float)LuaAPI.lua_tonumber(L, 2);
				float _y = (float)LuaAPI.lua_tonumber(L, 3);
				float _z = (float)LuaAPI.lua_tonumber(L, 4);
				
				UnityEngine.Vector3 gen_ret = new UnityEngine.Vector3(_x, _y, _z);
				translator.PushUnityEngineVector3(L, gen_ret);
				
				return 1;
			}
			if(gen_param_count == 3 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3))
			{
				float _x = (float)LuaAPI.lua_tonumber(L, 2);
				float _y = (float)LuaAPI.lua_tonumber(L, 3);
				
				UnityEngine.Vector3 gen_ret = new UnityEngine.Vector3(_x, _y);
				translator.PushUnityEngineVector3(L, gen_ret);
				
				return 1;
			}
			
			if (gen_param_count == 1)
			{
				translator.PushUnityEngineVector3(L, default(UnityEngine.Vector3));
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Vector3 constructor!");
            
        }
        
		
        int __CSIndexerUnityEngineVector3(RealStatePtr L, int gen_param_count) 
        {
			ObjectTranslator translator = this;
			
			if (translator.Assignable<UnityEngine.Vector3>(L, 1) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2))
			{
				
				UnityEngine.Vector3 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
				int index = LuaAPI.xlua_tointeger(L, 2);
				LuaAPI.lua_pushboolean(L, true);
				LuaAPI.lua_pushnumber(L, gen_to_be_invoked[index]);
				return 2;
			}
			
            LuaAPI.lua_pushboolean(L, false);
			return 1;
        }
		
        
		
        int __NewIndexerUnityEngineVector3(RealStatePtr L, int gen_param_count) 
        {
			ObjectTranslator translator = this;
			
			
			if (translator.Assignable<UnityEngine.Vector3>(L, 1) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3))
			{
				
				UnityEngine.Vector3 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
				int key = LuaAPI.xlua_tointeger(L, 2);
				gen_to_be_invoked[key] = (float)LuaAPI.lua_tonumber(L, 3);
				LuaAPI.lua_pushboolean(L, true);
				return 1;
			}
			
			LuaAPI.lua_pushboolean(L, false);
            return 1;
        }
		
        
        
        int UnityEngineVector3__AddMeta(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
            
			if (translator.Assignable<UnityEngine.Vector3>(L, 1) && translator.Assignable<UnityEngine.Vector3>(L, 2))
			{
				UnityEngine.Vector3 leftside;translator.Get(L, 1, out leftside);
				UnityEngine.Vector3 rightside;translator.Get(L, 2, out rightside);
				
				translator.PushUnityEngineVector3(L, leftside + rightside);
				
				return 1;
			}
            
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of + operator, need UnityEngine.Vector3!");
            
        }
        
        int UnityEngineVector3__SubMeta(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
            
			if (translator.Assignable<UnityEngine.Vector3>(L, 1) && translator.Assignable<UnityEngine.Vector3>(L, 2))
			{
				UnityEngine.Vector3 leftside;translator.Get(L, 1, out leftside);
				UnityEngine.Vector3 rightside;translator.Get(L, 2, out rightside);
				
				translator.PushUnityEngineVector3(L, leftside - rightside);
				
				return 1;
			}
            
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of - operator, need UnityEngine.Vector3!");
            
        }
        
        int UnityEngineVector3__UnmMeta(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
            
			UnityEngine.Vector3 rightside;translator.Get(L, 1, out rightside);
			translator.PushUnityEngineVector3(L, - rightside);
            return 1;
            
        }
        
        int UnityEngineVector3__MulMeta(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
            
			if (translator.Assignable<UnityEngine.Vector3>(L, 1) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2))
			{
				UnityEngine.Vector3 leftside;translator.Get(L, 1, out leftside);
				float rightside = (float)LuaAPI.lua_tonumber(L, 2);
				
				translator.PushUnityEngineVector3(L, leftside * rightside);
				
				return 1;
			}
            
			if (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1) && translator.Assignable<UnityEngine.Vector3>(L, 2))
			{
				float leftside = (float)LuaAPI.lua_tonumber(L, 1);
				UnityEngine.Vector3 rightside;translator.Get(L, 2, out rightside);
				
				translator.PushUnityEngineVector3(L, leftside * rightside);
				
				return 1;
			}
            
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of * operator, need UnityEngine.Vector3!");
            
        }
        
        int UnityEngineVector3__DivMeta(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
            
			if (translator.Assignable<UnityEngine.Vector3>(L, 1) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2))
			{
				UnityEngine.Vector3 leftside;translator.Get(L, 1, out leftside);
				float rightside = (float)LuaAPI.lua_tonumber(L, 2);
				
				translator.PushUnityEngineVector3(L, leftside / rightside);
				
				return 1;
			}
            
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of / operator, need UnityEngine.Vector3!");
            
        }
        
        int UnityEngineVector3__EqMeta(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
            
			if (translator.Assignable<UnityEngine.Vector3>(L, 1) && translator.Assignable<UnityEngine.Vector3>(L, 2))
			{
				UnityEngine.Vector3 leftside;translator.Get(L, 1, out leftside);
				UnityEngine.Vector3 rightside;translator.Get(L, 2, out rightside);
				
				LuaAPI.lua_pushboolean(L, leftside == rightside);
				
				return 1;
			}
            
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of == operator, need UnityEngine.Vector3!");
            
        }
        
        
        
        int UnityEngineVector3_m_Slerp_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector3 _a;translator.Get(L, 1, out _a);
				UnityEngine.Vector3 _b;translator.Get(L, 2, out _b);
				float _t = (float)LuaAPI.lua_tonumber(L, 3);
				
				UnityEngine.Vector3 gen_ret = UnityEngine.Vector3.Slerp( _a, _b, _t );
				translator.PushUnityEngineVector3(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector3_m_SlerpUnclamped_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector3 _a;translator.Get(L, 1, out _a);
				UnityEngine.Vector3 _b;translator.Get(L, 2, out _b);
				float _t = (float)LuaAPI.lua_tonumber(L, 3);
				
				UnityEngine.Vector3 gen_ret = UnityEngine.Vector3.SlerpUnclamped( _a, _b, _t );
				translator.PushUnityEngineVector3(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector3_m_OrthoNormalize_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
			{
				UnityEngine.Vector3 _normal;translator.Get(L, 1, out _normal);
				UnityEngine.Vector3 _tangent;translator.Get(L, 2, out _tangent);
				
				UnityEngine.Vector3.OrthoNormalize( ref _normal, ref _tangent );
				translator.PushUnityEngineVector3(L, _normal);
					translator.UpdateUnityEngineVector3(L, 1, _normal);
					
				translator.PushUnityEngineVector3(L, _tangent);
					translator.UpdateUnityEngineVector3(L, 2, _tangent);
					
				
				
				
				return 2;
			}
			if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)) 
			{
				UnityEngine.Vector3 _normal;translator.Get(L, 1, out _normal);
				UnityEngine.Vector3 _tangent;translator.Get(L, 2, out _tangent);
				UnityEngine.Vector3 _binormal;translator.Get(L, 3, out _binormal);
				
				UnityEngine.Vector3.OrthoNormalize( ref _normal, ref _tangent, ref _binormal );
				translator.PushUnityEngineVector3(L, _normal);
					translator.UpdateUnityEngineVector3(L, 1, _normal);
					
				translator.PushUnityEngineVector3(L, _tangent);
					translator.UpdateUnityEngineVector3(L, 2, _tangent);
					
				translator.PushUnityEngineVector3(L, _binormal);
					translator.UpdateUnityEngineVector3(L, 3, _binormal);
					
				
				
				
				return 3;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Vector3.OrthoNormalize!");
            
        }
        
        int UnityEngineVector3_m_RotateTowards_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector3 _current;translator.Get(L, 1, out _current);
				UnityEngine.Vector3 _target;translator.Get(L, 2, out _target);
				float _maxRadiansDelta = (float)LuaAPI.lua_tonumber(L, 3);
				float _maxMagnitudeDelta = (float)LuaAPI.lua_tonumber(L, 4);
				
				UnityEngine.Vector3 gen_ret = UnityEngine.Vector3.RotateTowards( _current, _target, _maxRadiansDelta, _maxMagnitudeDelta );
				translator.PushUnityEngineVector3(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector3_m_Lerp_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector3 _a;translator.Get(L, 1, out _a);
				UnityEngine.Vector3 _b;translator.Get(L, 2, out _b);
				float _t = (float)LuaAPI.lua_tonumber(L, 3);
				
				UnityEngine.Vector3 gen_ret = UnityEngine.Vector3.Lerp( _a, _b, _t );
				translator.PushUnityEngineVector3(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector3_m_LerpUnclamped_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector3 _a;translator.Get(L, 1, out _a);
				UnityEngine.Vector3 _b;translator.Get(L, 2, out _b);
				float _t = (float)LuaAPI.lua_tonumber(L, 3);
				
				UnityEngine.Vector3 gen_ret = UnityEngine.Vector3.LerpUnclamped( _a, _b, _t );
				translator.PushUnityEngineVector3(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector3_m_MoveTowards_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector3 _current;translator.Get(L, 1, out _current);
				UnityEngine.Vector3 _target;translator.Get(L, 2, out _target);
				float _maxDistanceDelta = (float)LuaAPI.lua_tonumber(L, 3);
				
				UnityEngine.Vector3 gen_ret = UnityEngine.Vector3.MoveTowards( _current, _target, _maxDistanceDelta );
				translator.PushUnityEngineVector3(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector3_m_SmoothDamp_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
			{
				UnityEngine.Vector3 _current;translator.Get(L, 1, out _current);
				UnityEngine.Vector3 _target;translator.Get(L, 2, out _target);
				UnityEngine.Vector3 _currentVelocity;translator.Get(L, 3, out _currentVelocity);
				float _smoothTime = (float)LuaAPI.lua_tonumber(L, 4);
				
				UnityEngine.Vector3 gen_ret = UnityEngine.Vector3.SmoothDamp( _current, _target, ref _currentVelocity, _smoothTime );
				translator.PushUnityEngineVector3(L, gen_ret);
				translator.PushUnityEngineVector3(L, _currentVelocity);
					translator.UpdateUnityEngineVector3(L, 3, _currentVelocity);
					
				
				
				
				return 2;
			}
			if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
			{
				UnityEngine.Vector3 _current;translator.Get(L, 1, out _current);
				UnityEngine.Vector3 _target;translator.Get(L, 2, out _target);
				UnityEngine.Vector3 _currentVelocity;translator.Get(L, 3, out _currentVelocity);
				float _smoothTime = (float)LuaAPI.lua_tonumber(L, 4);
				float _maxSpeed = (float)LuaAPI.lua_tonumber(L, 5);
				
				UnityEngine.Vector3 gen_ret = UnityEngine.Vector3.SmoothDamp( _current, _target, ref _currentVelocity, _smoothTime, _maxSpeed );
				translator.PushUnityEngineVector3(L, gen_ret);
				translator.PushUnityEngineVector3(L, _currentVelocity);
					translator.UpdateUnityEngineVector3(L, 3, _currentVelocity);
					
				
				
				
				return 2;
			}
			if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
			{
				UnityEngine.Vector3 _current;translator.Get(L, 1, out _current);
				UnityEngine.Vector3 _target;translator.Get(L, 2, out _target);
				UnityEngine.Vector3 _currentVelocity;translator.Get(L, 3, out _currentVelocity);
				float _smoothTime = (float)LuaAPI.lua_tonumber(L, 4);
				float _maxSpeed = (float)LuaAPI.lua_tonumber(L, 5);
				float _deltaTime = (float)LuaAPI.lua_tonumber(L, 6);
				
				UnityEngine.Vector3 gen_ret = UnityEngine.Vector3.SmoothDamp( _current, _target, ref _currentVelocity, _smoothTime, _maxSpeed, _deltaTime );
				translator.PushUnityEngineVector3(L, gen_ret);
				translator.PushUnityEngineVector3(L, _currentVelocity);
					translator.UpdateUnityEngineVector3(L, 3, _currentVelocity);
					
				
				
				
				return 2;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Vector3.SmoothDamp!");
            
        }
        
        int UnityEngineVector3_m_Set(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Vector3 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			
			{
				float _newX = (float)LuaAPI.lua_tonumber(L, 2);
				float _newY = (float)LuaAPI.lua_tonumber(L, 3);
				float _newZ = (float)LuaAPI.lua_tonumber(L, 4);
				
				gen_to_be_invoked.Set( _newX, _newY, _newZ );
				
				
				translator.UpdateUnityEngineVector3(L, 1, gen_to_be_invoked);
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineVector3_m_Scale_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector3 _a;translator.Get(L, 1, out _a);
				UnityEngine.Vector3 _b;translator.Get(L, 2, out _b);
				
				UnityEngine.Vector3 gen_ret = UnityEngine.Vector3.Scale( _a, _b );
				translator.PushUnityEngineVector3(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector3_m_Scale(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Vector3 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			
			{
				UnityEngine.Vector3 _scale;translator.Get(L, 2, out _scale);
				
				gen_to_be_invoked.Scale( _scale );
				
				
				translator.UpdateUnityEngineVector3(L, 1, gen_to_be_invoked);
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineVector3_m_Cross_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector3 _lhs;translator.Get(L, 1, out _lhs);
				UnityEngine.Vector3 _rhs;translator.Get(L, 2, out _rhs);
				
				UnityEngine.Vector3 gen_ret = UnityEngine.Vector3.Cross( _lhs, _rhs );
				translator.PushUnityEngineVector3(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector3_m_GetHashCode(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Vector3 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			
			{
				
				int gen_ret = gen_to_be_invoked.GetHashCode(  );
				LuaAPI.xlua_pushinteger(L, gen_ret);
				
				
				translator.UpdateUnityEngineVector3(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector3_m_Equals(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Vector3 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			if(gen_param_count == 2&& translator.Assignable<object>(L, 2)) 
			{
				object _other = translator.GetObject(L, 2, typeof(object));
				
				bool gen_ret = gen_to_be_invoked.Equals( _other );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				translator.UpdateUnityEngineVector3(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
			{
				UnityEngine.Vector3 _other;translator.Get(L, 2, out _other);
				
				bool gen_ret = gen_to_be_invoked.Equals( _other );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				translator.UpdateUnityEngineVector3(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Vector3.Equals!");
            
        }
        
        int UnityEngineVector3_m_Reflect_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector3 _inDirection;translator.Get(L, 1, out _inDirection);
				UnityEngine.Vector3 _inNormal;translator.Get(L, 2, out _inNormal);
				
				UnityEngine.Vector3 gen_ret = UnityEngine.Vector3.Reflect( _inDirection, _inNormal );
				translator.PushUnityEngineVector3(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector3_m_Normalize_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector3 _value;translator.Get(L, 1, out _value);
				
				UnityEngine.Vector3 gen_ret = UnityEngine.Vector3.Normalize( _value );
				translator.PushUnityEngineVector3(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector3_m_Normalize(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Vector3 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			
			{
				
				gen_to_be_invoked.Normalize(  );
				
				
				translator.UpdateUnityEngineVector3(L, 1, gen_to_be_invoked);
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineVector3_m_Dot_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector3 _lhs;translator.Get(L, 1, out _lhs);
				UnityEngine.Vector3 _rhs;translator.Get(L, 2, out _rhs);
				
				float gen_ret = UnityEngine.Vector3.Dot( _lhs, _rhs );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector3_m_Project_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector3 _vector;translator.Get(L, 1, out _vector);
				UnityEngine.Vector3 _onNormal;translator.Get(L, 2, out _onNormal);
				
				UnityEngine.Vector3 gen_ret = UnityEngine.Vector3.Project( _vector, _onNormal );
				translator.PushUnityEngineVector3(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector3_m_ProjectOnPlane_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector3 _vector;translator.Get(L, 1, out _vector);
				UnityEngine.Vector3 _planeNormal;translator.Get(L, 2, out _planeNormal);
				
				UnityEngine.Vector3 gen_ret = UnityEngine.Vector3.ProjectOnPlane( _vector, _planeNormal );
				translator.PushUnityEngineVector3(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector3_m_Angle_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector3 _from;translator.Get(L, 1, out _from);
				UnityEngine.Vector3 _to;translator.Get(L, 2, out _to);
				
				float gen_ret = UnityEngine.Vector3.Angle( _from, _to );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector3_m_SignedAngle_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector3 _from;translator.Get(L, 1, out _from);
				UnityEngine.Vector3 _to;translator.Get(L, 2, out _to);
				UnityEngine.Vector3 _axis;translator.Get(L, 3, out _axis);
				
				float gen_ret = UnityEngine.Vector3.SignedAngle( _from, _to, _axis );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector3_m_Distance_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector3 _a;translator.Get(L, 1, out _a);
				UnityEngine.Vector3 _b;translator.Get(L, 2, out _b);
				
				float gen_ret = UnityEngine.Vector3.Distance( _a, _b );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector3_m_ClampMagnitude_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector3 _vector;translator.Get(L, 1, out _vector);
				float _maxLength = (float)LuaAPI.lua_tonumber(L, 2);
				
				UnityEngine.Vector3 gen_ret = UnityEngine.Vector3.ClampMagnitude( _vector, _maxLength );
				translator.PushUnityEngineVector3(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector3_m_Magnitude_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector3 _vector;translator.Get(L, 1, out _vector);
				
				float gen_ret = UnityEngine.Vector3.Magnitude( _vector );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector3_m_SqrMagnitude_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector3 _vector;translator.Get(L, 1, out _vector);
				
				float gen_ret = UnityEngine.Vector3.SqrMagnitude( _vector );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector3_m_Min_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector3 _lhs;translator.Get(L, 1, out _lhs);
				UnityEngine.Vector3 _rhs;translator.Get(L, 2, out _rhs);
				
				UnityEngine.Vector3 gen_ret = UnityEngine.Vector3.Min( _lhs, _rhs );
				translator.PushUnityEngineVector3(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector3_m_Max_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector3 _lhs;translator.Get(L, 1, out _lhs);
				UnityEngine.Vector3 _rhs;translator.Get(L, 2, out _rhs);
				
				UnityEngine.Vector3 gen_ret = UnityEngine.Vector3.Max( _lhs, _rhs );
				translator.PushUnityEngineVector3(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector3_m_ToString(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Vector3 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			if(gen_param_count == 1) 
			{
				
				string gen_ret = gen_to_be_invoked.ToString(  );
				LuaAPI.lua_pushstring(L, gen_ret);
				
				
				translator.UpdateUnityEngineVector3(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
			{
				string _format = LuaAPI.lua_tostring(L, 2);
				
				string gen_ret = gen_to_be_invoked.ToString( _format );
				LuaAPI.lua_pushstring(L, gen_ret);
				
				
				translator.UpdateUnityEngineVector3(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Vector3.ToString!");
            
        }
        
        
        
        
        int UnityEngineVector3_g_get_normalized(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Vector3 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			translator.PushUnityEngineVector3(L, gen_to_be_invoked.normalized);
            return 1;
        }
        
        int UnityEngineVector3_g_get_magnitude(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Vector3 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.magnitude);
            return 1;
        }
        
        int UnityEngineVector3_g_get_sqrMagnitude(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Vector3 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.sqrMagnitude);
            return 1;
        }
        
        int UnityEngineVector3_g_get_zero(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.PushUnityEngineVector3(L, UnityEngine.Vector3.zero);
            return 1;
        }
        
        int UnityEngineVector3_g_get_one(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.PushUnityEngineVector3(L, UnityEngine.Vector3.one);
            return 1;
        }
        
        int UnityEngineVector3_g_get_forward(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.PushUnityEngineVector3(L, UnityEngine.Vector3.forward);
            return 1;
        }
        
        int UnityEngineVector3_g_get_back(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.PushUnityEngineVector3(L, UnityEngine.Vector3.back);
            return 1;
        }
        
        int UnityEngineVector3_g_get_up(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.PushUnityEngineVector3(L, UnityEngine.Vector3.up);
            return 1;
        }
        
        int UnityEngineVector3_g_get_down(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.PushUnityEngineVector3(L, UnityEngine.Vector3.down);
            return 1;
        }
        
        int UnityEngineVector3_g_get_left(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.PushUnityEngineVector3(L, UnityEngine.Vector3.left);
            return 1;
        }
        
        int UnityEngineVector3_g_get_right(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.PushUnityEngineVector3(L, UnityEngine.Vector3.right);
            return 1;
        }
        
        int UnityEngineVector3_g_get_positiveInfinity(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.PushUnityEngineVector3(L, UnityEngine.Vector3.positiveInfinity);
            return 1;
        }
        
        int UnityEngineVector3_g_get_negativeInfinity(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.PushUnityEngineVector3(L, UnityEngine.Vector3.negativeInfinity);
            return 1;
        }
        
        int UnityEngineVector3_g_get_x(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Vector3 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.x);
            return 1;
        }
        
        int UnityEngineVector3_g_get_y(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Vector3 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.y);
            return 1;
        }
        
        int UnityEngineVector3_g_get_z(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Vector3 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.z);
            return 1;
        }
        
        
        
        int UnityEngineVector3_s_set_x(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Vector3 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            gen_to_be_invoked.x = (float)LuaAPI.lua_tonumber(L, 2);
            
            translator.UpdateUnityEngineVector3(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineVector3_s_set_y(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Vector3 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            gen_to_be_invoked.y = (float)LuaAPI.lua_tonumber(L, 2);
            
            translator.UpdateUnityEngineVector3(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineVector3_s_set_z(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Vector3 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            gen_to_be_invoked.z = (float)LuaAPI.lua_tonumber(L, 2);
            
            translator.UpdateUnityEngineVector3(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
		
		
		
		
    }
}
