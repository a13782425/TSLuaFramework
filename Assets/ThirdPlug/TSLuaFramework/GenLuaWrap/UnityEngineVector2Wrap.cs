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
        public void __RegisterUnityEngineVector2(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.Vector2);
			Utils.BeginObjectRegister(type, L, this, 6, 7, 5, 2);
			Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__add", UnityEngineVector2__AddMeta);
            Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__sub", UnityEngineVector2__SubMeta);
            Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__mul", UnityEngineVector2__MulMeta);
            Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__div", UnityEngineVector2__DivMeta);
            Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__unm", UnityEngineVector2__UnmMeta);
            Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__eq", UnityEngineVector2__EqMeta);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Set", UnityEngineVector2_m_Set);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Scale", UnityEngineVector2_m_Scale);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Normalize", UnityEngineVector2_m_Normalize);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToString", UnityEngineVector2_m_ToString);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetHashCode", UnityEngineVector2_m_GetHashCode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Equals", UnityEngineVector2_m_Equals);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SqrMagnitude", UnityEngineVector2_m_SqrMagnitude);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "normalized", UnityEngineVector2_g_get_normalized);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "magnitude", UnityEngineVector2_g_get_magnitude);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sqrMagnitude", UnityEngineVector2_g_get_sqrMagnitude);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "x", UnityEngineVector2_g_get_x);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "y", UnityEngineVector2_g_get_y);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "x", UnityEngineVector2_s_set_x);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "y", UnityEngineVector2_s_set_y);
            
			
			Utils.EndObjectRegister(type, L, this, __CSIndexerUnityEngineVector2, __NewIndexerUnityEngineVector2,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineVector2, 18, 8, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Lerp", UnityEngineVector2_m_Lerp_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LerpUnclamped", UnityEngineVector2_m_LerpUnclamped_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MoveTowards", UnityEngineVector2_m_MoveTowards_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Scale", UnityEngineVector2_m_Scale_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Reflect", UnityEngineVector2_m_Reflect_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Perpendicular", UnityEngineVector2_m_Perpendicular_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Dot", UnityEngineVector2_m_Dot_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Angle", UnityEngineVector2_m_Angle_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SignedAngle", UnityEngineVector2_m_SignedAngle_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Distance", UnityEngineVector2_m_Distance_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ClampMagnitude", UnityEngineVector2_m_ClampMagnitude_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SqrMagnitude", UnityEngineVector2_m_SqrMagnitude_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Min", UnityEngineVector2_m_Min_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Max", UnityEngineVector2_m_Max_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SmoothDamp", UnityEngineVector2_m_SmoothDamp_xlua_st_);
            
			
            Utils.RegisterObject(L, this, Utils.CLS_IDX, "kEpsilon", UnityEngine.Vector2.kEpsilon);
            Utils.RegisterObject(L, this, Utils.CLS_IDX, "kEpsilonNormalSqrt", UnityEngine.Vector2.kEpsilonNormalSqrt);
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "zero", UnityEngineVector2_g_get_zero);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "one", UnityEngineVector2_g_get_one);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "up", UnityEngineVector2_g_get_up);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "down", UnityEngineVector2_g_get_down);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "left", UnityEngineVector2_g_get_left);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "right", UnityEngineVector2_g_get_right);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "positiveInfinity", UnityEngineVector2_g_get_positiveInfinity);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "negativeInfinity", UnityEngineVector2_g_get_negativeInfinity);
            
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineVector2(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			if(gen_param_count == 3 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3))
			{
				float _x = (float)LuaAPI.lua_tonumber(L, 2);
				float _y = (float)LuaAPI.lua_tonumber(L, 3);
				
				UnityEngine.Vector2 gen_ret = new UnityEngine.Vector2(_x, _y);
				translator.PushUnityEngineVector2(L, gen_ret);
				
				return 1;
			}
			
			if (gen_param_count == 1)
			{
				translator.PushUnityEngineVector2(L, default(UnityEngine.Vector2));
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Vector2 constructor!");
            
        }
        
		
        int __CSIndexerUnityEngineVector2(RealStatePtr L, int gen_param_count) 
        {
			ObjectTranslator translator = this;
			
			if (translator.Assignable<UnityEngine.Vector2>(L, 1) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2))
			{
				
				UnityEngine.Vector2 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
				int index = LuaAPI.xlua_tointeger(L, 2);
				LuaAPI.lua_pushboolean(L, true);
				LuaAPI.lua_pushnumber(L, gen_to_be_invoked[index]);
				return 2;
			}
			
            LuaAPI.lua_pushboolean(L, false);
			return 1;
        }
		
        
		
        int __NewIndexerUnityEngineVector2(RealStatePtr L, int gen_param_count) 
        {
			ObjectTranslator translator = this;
			
			
			if (translator.Assignable<UnityEngine.Vector2>(L, 1) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3))
			{
				
				UnityEngine.Vector2 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
				int key = LuaAPI.xlua_tointeger(L, 2);
				gen_to_be_invoked[key] = (float)LuaAPI.lua_tonumber(L, 3);
				LuaAPI.lua_pushboolean(L, true);
				return 1;
			}
			
			LuaAPI.lua_pushboolean(L, false);
            return 1;
        }
		
        
        
        int UnityEngineVector2__AddMeta(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
            
			if (translator.Assignable<UnityEngine.Vector2>(L, 1) && translator.Assignable<UnityEngine.Vector2>(L, 2))
			{
				UnityEngine.Vector2 leftside;translator.Get(L, 1, out leftside);
				UnityEngine.Vector2 rightside;translator.Get(L, 2, out rightside);
				
				translator.PushUnityEngineVector2(L, leftside + rightside);
				
				return 1;
			}
            
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of + operator, need UnityEngine.Vector2!");
            
        }
        
        int UnityEngineVector2__SubMeta(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
            
			if (translator.Assignable<UnityEngine.Vector2>(L, 1) && translator.Assignable<UnityEngine.Vector2>(L, 2))
			{
				UnityEngine.Vector2 leftside;translator.Get(L, 1, out leftside);
				UnityEngine.Vector2 rightside;translator.Get(L, 2, out rightside);
				
				translator.PushUnityEngineVector2(L, leftside - rightside);
				
				return 1;
			}
            
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of - operator, need UnityEngine.Vector2!");
            
        }
        
        int UnityEngineVector2__MulMeta(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
            
			if (translator.Assignable<UnityEngine.Vector2>(L, 1) && translator.Assignable<UnityEngine.Vector2>(L, 2))
			{
				UnityEngine.Vector2 leftside;translator.Get(L, 1, out leftside);
				UnityEngine.Vector2 rightside;translator.Get(L, 2, out rightside);
				
				translator.PushUnityEngineVector2(L, leftside * rightside);
				
				return 1;
			}
            
			if (translator.Assignable<UnityEngine.Vector2>(L, 1) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2))
			{
				UnityEngine.Vector2 leftside;translator.Get(L, 1, out leftside);
				float rightside = (float)LuaAPI.lua_tonumber(L, 2);
				
				translator.PushUnityEngineVector2(L, leftside * rightside);
				
				return 1;
			}
            
			if (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1) && translator.Assignable<UnityEngine.Vector2>(L, 2))
			{
				float leftside = (float)LuaAPI.lua_tonumber(L, 1);
				UnityEngine.Vector2 rightside;translator.Get(L, 2, out rightside);
				
				translator.PushUnityEngineVector2(L, leftside * rightside);
				
				return 1;
			}
            
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of * operator, need UnityEngine.Vector2!");
            
        }
        
        int UnityEngineVector2__DivMeta(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
            
			if (translator.Assignable<UnityEngine.Vector2>(L, 1) && translator.Assignable<UnityEngine.Vector2>(L, 2))
			{
				UnityEngine.Vector2 leftside;translator.Get(L, 1, out leftside);
				UnityEngine.Vector2 rightside;translator.Get(L, 2, out rightside);
				
				translator.PushUnityEngineVector2(L, leftside / rightside);
				
				return 1;
			}
            
			if (translator.Assignable<UnityEngine.Vector2>(L, 1) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2))
			{
				UnityEngine.Vector2 leftside;translator.Get(L, 1, out leftside);
				float rightside = (float)LuaAPI.lua_tonumber(L, 2);
				
				translator.PushUnityEngineVector2(L, leftside / rightside);
				
				return 1;
			}
            
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of / operator, need UnityEngine.Vector2!");
            
        }
        
        int UnityEngineVector2__UnmMeta(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
            
			UnityEngine.Vector2 rightside;translator.Get(L, 1, out rightside);
			translator.PushUnityEngineVector2(L, - rightside);
            return 1;
            
        }
        
        int UnityEngineVector2__EqMeta(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
            
			if (translator.Assignable<UnityEngine.Vector2>(L, 1) && translator.Assignable<UnityEngine.Vector2>(L, 2))
			{
				UnityEngine.Vector2 leftside;translator.Get(L, 1, out leftside);
				UnityEngine.Vector2 rightside;translator.Get(L, 2, out rightside);
				
				LuaAPI.lua_pushboolean(L, leftside == rightside);
				
				return 1;
			}
            
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of == operator, need UnityEngine.Vector2!");
            
        }
        
        
        
        int UnityEngineVector2_m_Set(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Vector2 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			
			{
				float _newX = (float)LuaAPI.lua_tonumber(L, 2);
				float _newY = (float)LuaAPI.lua_tonumber(L, 3);
				
				gen_to_be_invoked.Set( _newX, _newY );
				
				
				translator.UpdateUnityEngineVector2(L, 1, gen_to_be_invoked);
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineVector2_m_Lerp_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector2 _a;translator.Get(L, 1, out _a);
				UnityEngine.Vector2 _b;translator.Get(L, 2, out _b);
				float _t = (float)LuaAPI.lua_tonumber(L, 3);
				
				UnityEngine.Vector2 gen_ret = UnityEngine.Vector2.Lerp( _a, _b, _t );
				translator.PushUnityEngineVector2(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector2_m_LerpUnclamped_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector2 _a;translator.Get(L, 1, out _a);
				UnityEngine.Vector2 _b;translator.Get(L, 2, out _b);
				float _t = (float)LuaAPI.lua_tonumber(L, 3);
				
				UnityEngine.Vector2 gen_ret = UnityEngine.Vector2.LerpUnclamped( _a, _b, _t );
				translator.PushUnityEngineVector2(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector2_m_MoveTowards_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector2 _current;translator.Get(L, 1, out _current);
				UnityEngine.Vector2 _target;translator.Get(L, 2, out _target);
				float _maxDistanceDelta = (float)LuaAPI.lua_tonumber(L, 3);
				
				UnityEngine.Vector2 gen_ret = UnityEngine.Vector2.MoveTowards( _current, _target, _maxDistanceDelta );
				translator.PushUnityEngineVector2(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector2_m_Scale_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector2 _a;translator.Get(L, 1, out _a);
				UnityEngine.Vector2 _b;translator.Get(L, 2, out _b);
				
				UnityEngine.Vector2 gen_ret = UnityEngine.Vector2.Scale( _a, _b );
				translator.PushUnityEngineVector2(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector2_m_Scale(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Vector2 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			
			{
				UnityEngine.Vector2 _scale;translator.Get(L, 2, out _scale);
				
				gen_to_be_invoked.Scale( _scale );
				
				
				translator.UpdateUnityEngineVector2(L, 1, gen_to_be_invoked);
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineVector2_m_Normalize(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Vector2 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			
			{
				
				gen_to_be_invoked.Normalize(  );
				
				
				translator.UpdateUnityEngineVector2(L, 1, gen_to_be_invoked);
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineVector2_m_ToString(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Vector2 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			if(gen_param_count == 1) 
			{
				
				string gen_ret = gen_to_be_invoked.ToString(  );
				LuaAPI.lua_pushstring(L, gen_ret);
				
				
				translator.UpdateUnityEngineVector2(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
			{
				string _format = LuaAPI.lua_tostring(L, 2);
				
				string gen_ret = gen_to_be_invoked.ToString( _format );
				LuaAPI.lua_pushstring(L, gen_ret);
				
				
				translator.UpdateUnityEngineVector2(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Vector2.ToString!");
            
        }
        
        int UnityEngineVector2_m_GetHashCode(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Vector2 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			
			{
				
				int gen_ret = gen_to_be_invoked.GetHashCode(  );
				LuaAPI.xlua_pushinteger(L, gen_ret);
				
				
				translator.UpdateUnityEngineVector2(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector2_m_Equals(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Vector2 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			if(gen_param_count == 2&& translator.Assignable<object>(L, 2)) 
			{
				object _other = translator.GetObject(L, 2, typeof(object));
				
				bool gen_ret = gen_to_be_invoked.Equals( _other );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				translator.UpdateUnityEngineVector2(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector2>(L, 2)) 
			{
				UnityEngine.Vector2 _other;translator.Get(L, 2, out _other);
				
				bool gen_ret = gen_to_be_invoked.Equals( _other );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				translator.UpdateUnityEngineVector2(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Vector2.Equals!");
            
        }
        
        int UnityEngineVector2_m_Reflect_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector2 _inDirection;translator.Get(L, 1, out _inDirection);
				UnityEngine.Vector2 _inNormal;translator.Get(L, 2, out _inNormal);
				
				UnityEngine.Vector2 gen_ret = UnityEngine.Vector2.Reflect( _inDirection, _inNormal );
				translator.PushUnityEngineVector2(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector2_m_Perpendicular_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector2 _inDirection;translator.Get(L, 1, out _inDirection);
				
				UnityEngine.Vector2 gen_ret = UnityEngine.Vector2.Perpendicular( _inDirection );
				translator.PushUnityEngineVector2(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector2_m_Dot_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector2 _lhs;translator.Get(L, 1, out _lhs);
				UnityEngine.Vector2 _rhs;translator.Get(L, 2, out _rhs);
				
				float gen_ret = UnityEngine.Vector2.Dot( _lhs, _rhs );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector2_m_Angle_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector2 _from;translator.Get(L, 1, out _from);
				UnityEngine.Vector2 _to;translator.Get(L, 2, out _to);
				
				float gen_ret = UnityEngine.Vector2.Angle( _from, _to );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector2_m_SignedAngle_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector2 _from;translator.Get(L, 1, out _from);
				UnityEngine.Vector2 _to;translator.Get(L, 2, out _to);
				
				float gen_ret = UnityEngine.Vector2.SignedAngle( _from, _to );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector2_m_Distance_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector2 _a;translator.Get(L, 1, out _a);
				UnityEngine.Vector2 _b;translator.Get(L, 2, out _b);
				
				float gen_ret = UnityEngine.Vector2.Distance( _a, _b );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector2_m_ClampMagnitude_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector2 _vector;translator.Get(L, 1, out _vector);
				float _maxLength = (float)LuaAPI.lua_tonumber(L, 2);
				
				UnityEngine.Vector2 gen_ret = UnityEngine.Vector2.ClampMagnitude( _vector, _maxLength );
				translator.PushUnityEngineVector2(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector2_m_SqrMagnitude_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector2 _a;translator.Get(L, 1, out _a);
				
				float gen_ret = UnityEngine.Vector2.SqrMagnitude( _a );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector2_m_SqrMagnitude(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Vector2 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			
			{
				
				float gen_ret = gen_to_be_invoked.SqrMagnitude(  );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				translator.UpdateUnityEngineVector2(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector2_m_Min_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector2 _lhs;translator.Get(L, 1, out _lhs);
				UnityEngine.Vector2 _rhs;translator.Get(L, 2, out _rhs);
				
				UnityEngine.Vector2 gen_ret = UnityEngine.Vector2.Min( _lhs, _rhs );
				translator.PushUnityEngineVector2(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector2_m_Max_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector2 _lhs;translator.Get(L, 1, out _lhs);
				UnityEngine.Vector2 _rhs;translator.Get(L, 2, out _rhs);
				
				UnityEngine.Vector2 gen_ret = UnityEngine.Vector2.Max( _lhs, _rhs );
				translator.PushUnityEngineVector2(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector2_m_SmoothDamp_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
			{
				UnityEngine.Vector2 _current;translator.Get(L, 1, out _current);
				UnityEngine.Vector2 _target;translator.Get(L, 2, out _target);
				UnityEngine.Vector2 _currentVelocity;translator.Get(L, 3, out _currentVelocity);
				float _smoothTime = (float)LuaAPI.lua_tonumber(L, 4);
				
				UnityEngine.Vector2 gen_ret = UnityEngine.Vector2.SmoothDamp( _current, _target, ref _currentVelocity, _smoothTime );
				translator.PushUnityEngineVector2(L, gen_ret);
				translator.PushUnityEngineVector2(L, _currentVelocity);
					translator.UpdateUnityEngineVector2(L, 3, _currentVelocity);
					
				
				
				
				return 2;
			}
			if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
			{
				UnityEngine.Vector2 _current;translator.Get(L, 1, out _current);
				UnityEngine.Vector2 _target;translator.Get(L, 2, out _target);
				UnityEngine.Vector2 _currentVelocity;translator.Get(L, 3, out _currentVelocity);
				float _smoothTime = (float)LuaAPI.lua_tonumber(L, 4);
				float _maxSpeed = (float)LuaAPI.lua_tonumber(L, 5);
				
				UnityEngine.Vector2 gen_ret = UnityEngine.Vector2.SmoothDamp( _current, _target, ref _currentVelocity, _smoothTime, _maxSpeed );
				translator.PushUnityEngineVector2(L, gen_ret);
				translator.PushUnityEngineVector2(L, _currentVelocity);
					translator.UpdateUnityEngineVector2(L, 3, _currentVelocity);
					
				
				
				
				return 2;
			}
			if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
			{
				UnityEngine.Vector2 _current;translator.Get(L, 1, out _current);
				UnityEngine.Vector2 _target;translator.Get(L, 2, out _target);
				UnityEngine.Vector2 _currentVelocity;translator.Get(L, 3, out _currentVelocity);
				float _smoothTime = (float)LuaAPI.lua_tonumber(L, 4);
				float _maxSpeed = (float)LuaAPI.lua_tonumber(L, 5);
				float _deltaTime = (float)LuaAPI.lua_tonumber(L, 6);
				
				UnityEngine.Vector2 gen_ret = UnityEngine.Vector2.SmoothDamp( _current, _target, ref _currentVelocity, _smoothTime, _maxSpeed, _deltaTime );
				translator.PushUnityEngineVector2(L, gen_ret);
				translator.PushUnityEngineVector2(L, _currentVelocity);
					translator.UpdateUnityEngineVector2(L, 3, _currentVelocity);
					
				
				
				
				return 2;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Vector2.SmoothDamp!");
            
        }
        
        
        
        
        int UnityEngineVector2_g_get_normalized(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Vector2 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			translator.PushUnityEngineVector2(L, gen_to_be_invoked.normalized);
            return 1;
        }
        
        int UnityEngineVector2_g_get_magnitude(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Vector2 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.magnitude);
            return 1;
        }
        
        int UnityEngineVector2_g_get_sqrMagnitude(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Vector2 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.sqrMagnitude);
            return 1;
        }
        
        int UnityEngineVector2_g_get_zero(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.PushUnityEngineVector2(L, UnityEngine.Vector2.zero);
            return 1;
        }
        
        int UnityEngineVector2_g_get_one(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.PushUnityEngineVector2(L, UnityEngine.Vector2.one);
            return 1;
        }
        
        int UnityEngineVector2_g_get_up(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.PushUnityEngineVector2(L, UnityEngine.Vector2.up);
            return 1;
        }
        
        int UnityEngineVector2_g_get_down(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.PushUnityEngineVector2(L, UnityEngine.Vector2.down);
            return 1;
        }
        
        int UnityEngineVector2_g_get_left(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.PushUnityEngineVector2(L, UnityEngine.Vector2.left);
            return 1;
        }
        
        int UnityEngineVector2_g_get_right(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.PushUnityEngineVector2(L, UnityEngine.Vector2.right);
            return 1;
        }
        
        int UnityEngineVector2_g_get_positiveInfinity(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.PushUnityEngineVector2(L, UnityEngine.Vector2.positiveInfinity);
            return 1;
        }
        
        int UnityEngineVector2_g_get_negativeInfinity(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.PushUnityEngineVector2(L, UnityEngine.Vector2.negativeInfinity);
            return 1;
        }
        
        int UnityEngineVector2_g_get_x(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Vector2 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.x);
            return 1;
        }
        
        int UnityEngineVector2_g_get_y(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Vector2 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.y);
            return 1;
        }
        
        
        
        int UnityEngineVector2_s_set_x(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Vector2 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            gen_to_be_invoked.x = (float)LuaAPI.lua_tonumber(L, 2);
            
            translator.UpdateUnityEngineVector2(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineVector2_s_set_y(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Vector2 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            gen_to_be_invoked.y = (float)LuaAPI.lua_tonumber(L, 2);
            
            translator.UpdateUnityEngineVector2(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
		
		
		
		
    }
}
