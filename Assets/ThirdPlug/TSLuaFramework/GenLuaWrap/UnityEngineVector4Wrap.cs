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
        public void __RegisterUnityEngineVector4(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.Vector4);
			Utils.BeginObjectRegister(type, L, this, 6, 7, 7, 4);
			Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__add", UnityEngineVector4__AddMeta);
            Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__sub", UnityEngineVector4__SubMeta);
            Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__unm", UnityEngineVector4__UnmMeta);
            Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__mul", UnityEngineVector4__MulMeta);
            Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__div", UnityEngineVector4__DivMeta);
            Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__eq", UnityEngineVector4__EqMeta);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Set", UnityEngineVector4_m_Set);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Scale", UnityEngineVector4_m_Scale);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetHashCode", UnityEngineVector4_m_GetHashCode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Equals", UnityEngineVector4_m_Equals);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Normalize", UnityEngineVector4_m_Normalize);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToString", UnityEngineVector4_m_ToString);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SqrMagnitude", UnityEngineVector4_m_SqrMagnitude);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "normalized", UnityEngineVector4_g_get_normalized);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "magnitude", UnityEngineVector4_g_get_magnitude);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sqrMagnitude", UnityEngineVector4_g_get_sqrMagnitude);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "x", UnityEngineVector4_g_get_x);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "y", UnityEngineVector4_g_get_y);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "z", UnityEngineVector4_g_get_z);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "w", UnityEngineVector4_g_get_w);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "x", UnityEngineVector4_s_set_x);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "y", UnityEngineVector4_s_set_y);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "z", UnityEngineVector4_s_set_z);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "w", UnityEngineVector4_s_set_w);
            
			
			Utils.EndObjectRegister(type, L, this, __CSIndexerUnityEngineVector4, __NewIndexerUnityEngineVector4,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineVector4, 14, 4, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Lerp", UnityEngineVector4_m_Lerp_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LerpUnclamped", UnityEngineVector4_m_LerpUnclamped_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MoveTowards", UnityEngineVector4_m_MoveTowards_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Scale", UnityEngineVector4_m_Scale_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Normalize", UnityEngineVector4_m_Normalize_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Dot", UnityEngineVector4_m_Dot_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Project", UnityEngineVector4_m_Project_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Distance", UnityEngineVector4_m_Distance_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Magnitude", UnityEngineVector4_m_Magnitude_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Min", UnityEngineVector4_m_Min_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Max", UnityEngineVector4_m_Max_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SqrMagnitude", UnityEngineVector4_m_SqrMagnitude_xlua_st_);
            
			
            Utils.RegisterObject(L, this, Utils.CLS_IDX, "kEpsilon", UnityEngine.Vector4.kEpsilon);
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "zero", UnityEngineVector4_g_get_zero);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "one", UnityEngineVector4_g_get_one);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "positiveInfinity", UnityEngineVector4_g_get_positiveInfinity);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "negativeInfinity", UnityEngineVector4_g_get_negativeInfinity);
            
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineVector4(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			if(gen_param_count == 5 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5))
			{
				float _x = (float)LuaAPI.lua_tonumber(L, 2);
				float _y = (float)LuaAPI.lua_tonumber(L, 3);
				float _z = (float)LuaAPI.lua_tonumber(L, 4);
				float _w = (float)LuaAPI.lua_tonumber(L, 5);
				
				UnityEngine.Vector4 gen_ret = new UnityEngine.Vector4(_x, _y, _z, _w);
				translator.PushUnityEngineVector4(L, gen_ret);
				
				return 1;
			}
			if(gen_param_count == 4 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4))
			{
				float _x = (float)LuaAPI.lua_tonumber(L, 2);
				float _y = (float)LuaAPI.lua_tonumber(L, 3);
				float _z = (float)LuaAPI.lua_tonumber(L, 4);
				
				UnityEngine.Vector4 gen_ret = new UnityEngine.Vector4(_x, _y, _z);
				translator.PushUnityEngineVector4(L, gen_ret);
				
				return 1;
			}
			if(gen_param_count == 3 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3))
			{
				float _x = (float)LuaAPI.lua_tonumber(L, 2);
				float _y = (float)LuaAPI.lua_tonumber(L, 3);
				
				UnityEngine.Vector4 gen_ret = new UnityEngine.Vector4(_x, _y);
				translator.PushUnityEngineVector4(L, gen_ret);
				
				return 1;
			}
			
			if (gen_param_count == 1)
			{
				translator.PushUnityEngineVector4(L, default(UnityEngine.Vector4));
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Vector4 constructor!");
            
        }
        
		
        int __CSIndexerUnityEngineVector4(RealStatePtr L, int gen_param_count) 
        {
			ObjectTranslator translator = this;
			
			if (translator.Assignable<UnityEngine.Vector4>(L, 1) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2))
			{
				
				UnityEngine.Vector4 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
				int index = LuaAPI.xlua_tointeger(L, 2);
				LuaAPI.lua_pushboolean(L, true);
				LuaAPI.lua_pushnumber(L, gen_to_be_invoked[index]);
				return 2;
			}
			
            LuaAPI.lua_pushboolean(L, false);
			return 1;
        }
		
        
		
        int __NewIndexerUnityEngineVector4(RealStatePtr L, int gen_param_count) 
        {
			ObjectTranslator translator = this;
			
			
			if (translator.Assignable<UnityEngine.Vector4>(L, 1) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3))
			{
				
				UnityEngine.Vector4 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
				int key = LuaAPI.xlua_tointeger(L, 2);
				gen_to_be_invoked[key] = (float)LuaAPI.lua_tonumber(L, 3);
				LuaAPI.lua_pushboolean(L, true);
				return 1;
			}
			
			LuaAPI.lua_pushboolean(L, false);
            return 1;
        }
		
        
        
        int UnityEngineVector4__AddMeta(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
            
			if (translator.Assignable<UnityEngine.Vector4>(L, 1) && translator.Assignable<UnityEngine.Vector4>(L, 2))
			{
				UnityEngine.Vector4 leftside;translator.Get(L, 1, out leftside);
				UnityEngine.Vector4 rightside;translator.Get(L, 2, out rightside);
				
				translator.PushUnityEngineVector4(L, leftside + rightside);
				
				return 1;
			}
            
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of + operator, need UnityEngine.Vector4!");
            
        }
        
        int UnityEngineVector4__SubMeta(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
            
			if (translator.Assignable<UnityEngine.Vector4>(L, 1) && translator.Assignable<UnityEngine.Vector4>(L, 2))
			{
				UnityEngine.Vector4 leftside;translator.Get(L, 1, out leftside);
				UnityEngine.Vector4 rightside;translator.Get(L, 2, out rightside);
				
				translator.PushUnityEngineVector4(L, leftside - rightside);
				
				return 1;
			}
            
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of - operator, need UnityEngine.Vector4!");
            
        }
        
        int UnityEngineVector4__UnmMeta(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
            
			UnityEngine.Vector4 rightside;translator.Get(L, 1, out rightside);
			translator.PushUnityEngineVector4(L, - rightside);
            return 1;
            
        }
        
        int UnityEngineVector4__MulMeta(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
            
			if (translator.Assignable<UnityEngine.Vector4>(L, 1) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2))
			{
				UnityEngine.Vector4 leftside;translator.Get(L, 1, out leftside);
				float rightside = (float)LuaAPI.lua_tonumber(L, 2);
				
				translator.PushUnityEngineVector4(L, leftside * rightside);
				
				return 1;
			}
            
			if (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1) && translator.Assignable<UnityEngine.Vector4>(L, 2))
			{
				float leftside = (float)LuaAPI.lua_tonumber(L, 1);
				UnityEngine.Vector4 rightside;translator.Get(L, 2, out rightside);
				
				translator.PushUnityEngineVector4(L, leftside * rightside);
				
				return 1;
			}
            
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of * operator, need UnityEngine.Vector4!");
            
        }
        
        int UnityEngineVector4__DivMeta(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
            
			if (translator.Assignable<UnityEngine.Vector4>(L, 1) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2))
			{
				UnityEngine.Vector4 leftside;translator.Get(L, 1, out leftside);
				float rightside = (float)LuaAPI.lua_tonumber(L, 2);
				
				translator.PushUnityEngineVector4(L, leftside / rightside);
				
				return 1;
			}
            
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of / operator, need UnityEngine.Vector4!");
            
        }
        
        int UnityEngineVector4__EqMeta(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
            
			if (translator.Assignable<UnityEngine.Vector4>(L, 1) && translator.Assignable<UnityEngine.Vector4>(L, 2))
			{
				UnityEngine.Vector4 leftside;translator.Get(L, 1, out leftside);
				UnityEngine.Vector4 rightside;translator.Get(L, 2, out rightside);
				
				LuaAPI.lua_pushboolean(L, leftside == rightside);
				
				return 1;
			}
            
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of == operator, need UnityEngine.Vector4!");
            
        }
        
        
        
        int UnityEngineVector4_m_Set(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Vector4 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			
			{
				float _newX = (float)LuaAPI.lua_tonumber(L, 2);
				float _newY = (float)LuaAPI.lua_tonumber(L, 3);
				float _newZ = (float)LuaAPI.lua_tonumber(L, 4);
				float _newW = (float)LuaAPI.lua_tonumber(L, 5);
				
				gen_to_be_invoked.Set( _newX, _newY, _newZ, _newW );
				
				
				translator.UpdateUnityEngineVector4(L, 1, gen_to_be_invoked);
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineVector4_m_Lerp_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector4 _a;translator.Get(L, 1, out _a);
				UnityEngine.Vector4 _b;translator.Get(L, 2, out _b);
				float _t = (float)LuaAPI.lua_tonumber(L, 3);
				
				UnityEngine.Vector4 gen_ret = UnityEngine.Vector4.Lerp( _a, _b, _t );
				translator.PushUnityEngineVector4(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector4_m_LerpUnclamped_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector4 _a;translator.Get(L, 1, out _a);
				UnityEngine.Vector4 _b;translator.Get(L, 2, out _b);
				float _t = (float)LuaAPI.lua_tonumber(L, 3);
				
				UnityEngine.Vector4 gen_ret = UnityEngine.Vector4.LerpUnclamped( _a, _b, _t );
				translator.PushUnityEngineVector4(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector4_m_MoveTowards_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector4 _current;translator.Get(L, 1, out _current);
				UnityEngine.Vector4 _target;translator.Get(L, 2, out _target);
				float _maxDistanceDelta = (float)LuaAPI.lua_tonumber(L, 3);
				
				UnityEngine.Vector4 gen_ret = UnityEngine.Vector4.MoveTowards( _current, _target, _maxDistanceDelta );
				translator.PushUnityEngineVector4(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector4_m_Scale_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector4 _a;translator.Get(L, 1, out _a);
				UnityEngine.Vector4 _b;translator.Get(L, 2, out _b);
				
				UnityEngine.Vector4 gen_ret = UnityEngine.Vector4.Scale( _a, _b );
				translator.PushUnityEngineVector4(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector4_m_Scale(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Vector4 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			
			{
				UnityEngine.Vector4 _scale;translator.Get(L, 2, out _scale);
				
				gen_to_be_invoked.Scale( _scale );
				
				
				translator.UpdateUnityEngineVector4(L, 1, gen_to_be_invoked);
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineVector4_m_GetHashCode(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Vector4 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			
			{
				
				int gen_ret = gen_to_be_invoked.GetHashCode(  );
				LuaAPI.xlua_pushinteger(L, gen_ret);
				
				
				translator.UpdateUnityEngineVector4(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector4_m_Equals(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Vector4 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			if(gen_param_count == 2&& translator.Assignable<object>(L, 2)) 
			{
				object _other = translator.GetObject(L, 2, typeof(object));
				
				bool gen_ret = gen_to_be_invoked.Equals( _other );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				translator.UpdateUnityEngineVector4(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector4>(L, 2)) 
			{
				UnityEngine.Vector4 _other;translator.Get(L, 2, out _other);
				
				bool gen_ret = gen_to_be_invoked.Equals( _other );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				translator.UpdateUnityEngineVector4(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Vector4.Equals!");
            
        }
        
        int UnityEngineVector4_m_Normalize_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector4 _a;translator.Get(L, 1, out _a);
				
				UnityEngine.Vector4 gen_ret = UnityEngine.Vector4.Normalize( _a );
				translator.PushUnityEngineVector4(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector4_m_Normalize(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Vector4 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			
			{
				
				gen_to_be_invoked.Normalize(  );
				
				
				translator.UpdateUnityEngineVector4(L, 1, gen_to_be_invoked);
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineVector4_m_Dot_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector4 _a;translator.Get(L, 1, out _a);
				UnityEngine.Vector4 _b;translator.Get(L, 2, out _b);
				
				float gen_ret = UnityEngine.Vector4.Dot( _a, _b );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector4_m_Project_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector4 _a;translator.Get(L, 1, out _a);
				UnityEngine.Vector4 _b;translator.Get(L, 2, out _b);
				
				UnityEngine.Vector4 gen_ret = UnityEngine.Vector4.Project( _a, _b );
				translator.PushUnityEngineVector4(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector4_m_Distance_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector4 _a;translator.Get(L, 1, out _a);
				UnityEngine.Vector4 _b;translator.Get(L, 2, out _b);
				
				float gen_ret = UnityEngine.Vector4.Distance( _a, _b );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector4_m_Magnitude_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector4 _a;translator.Get(L, 1, out _a);
				
				float gen_ret = UnityEngine.Vector4.Magnitude( _a );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector4_m_Min_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector4 _lhs;translator.Get(L, 1, out _lhs);
				UnityEngine.Vector4 _rhs;translator.Get(L, 2, out _rhs);
				
				UnityEngine.Vector4 gen_ret = UnityEngine.Vector4.Min( _lhs, _rhs );
				translator.PushUnityEngineVector4(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector4_m_Max_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector4 _lhs;translator.Get(L, 1, out _lhs);
				UnityEngine.Vector4 _rhs;translator.Get(L, 2, out _rhs);
				
				UnityEngine.Vector4 gen_ret = UnityEngine.Vector4.Max( _lhs, _rhs );
				translator.PushUnityEngineVector4(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector4_m_ToString(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Vector4 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			if(gen_param_count == 1) 
			{
				
				string gen_ret = gen_to_be_invoked.ToString(  );
				LuaAPI.lua_pushstring(L, gen_ret);
				
				
				translator.UpdateUnityEngineVector4(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
			{
				string _format = LuaAPI.lua_tostring(L, 2);
				
				string gen_ret = gen_to_be_invoked.ToString( _format );
				LuaAPI.lua_pushstring(L, gen_ret);
				
				
				translator.UpdateUnityEngineVector4(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Vector4.ToString!");
            
        }
        
        int UnityEngineVector4_m_SqrMagnitude_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Vector4 _a;translator.Get(L, 1, out _a);
				
				float gen_ret = UnityEngine.Vector4.SqrMagnitude( _a );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineVector4_m_SqrMagnitude(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Vector4 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			
			{
				
				float gen_ret = gen_to_be_invoked.SqrMagnitude(  );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				translator.UpdateUnityEngineVector4(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			
            
        }
        
        
        
        
        int UnityEngineVector4_g_get_normalized(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Vector4 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			translator.PushUnityEngineVector4(L, gen_to_be_invoked.normalized);
            return 1;
        }
        
        int UnityEngineVector4_g_get_magnitude(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Vector4 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.magnitude);
            return 1;
        }
        
        int UnityEngineVector4_g_get_sqrMagnitude(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Vector4 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.sqrMagnitude);
            return 1;
        }
        
        int UnityEngineVector4_g_get_zero(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.PushUnityEngineVector4(L, UnityEngine.Vector4.zero);
            return 1;
        }
        
        int UnityEngineVector4_g_get_one(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.PushUnityEngineVector4(L, UnityEngine.Vector4.one);
            return 1;
        }
        
        int UnityEngineVector4_g_get_positiveInfinity(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.PushUnityEngineVector4(L, UnityEngine.Vector4.positiveInfinity);
            return 1;
        }
        
        int UnityEngineVector4_g_get_negativeInfinity(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.PushUnityEngineVector4(L, UnityEngine.Vector4.negativeInfinity);
            return 1;
        }
        
        int UnityEngineVector4_g_get_x(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Vector4 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.x);
            return 1;
        }
        
        int UnityEngineVector4_g_get_y(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Vector4 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.y);
            return 1;
        }
        
        int UnityEngineVector4_g_get_z(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Vector4 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.z);
            return 1;
        }
        
        int UnityEngineVector4_g_get_w(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Vector4 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.w);
            return 1;
        }
        
        
        
        int UnityEngineVector4_s_set_x(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Vector4 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            gen_to_be_invoked.x = (float)LuaAPI.lua_tonumber(L, 2);
            
            translator.UpdateUnityEngineVector4(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineVector4_s_set_y(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Vector4 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            gen_to_be_invoked.y = (float)LuaAPI.lua_tonumber(L, 2);
            
            translator.UpdateUnityEngineVector4(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineVector4_s_set_z(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Vector4 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            gen_to_be_invoked.z = (float)LuaAPI.lua_tonumber(L, 2);
            
            translator.UpdateUnityEngineVector4(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineVector4_s_set_w(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Vector4 gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            gen_to_be_invoked.w = (float)LuaAPI.lua_tonumber(L, 2);
            
            translator.UpdateUnityEngineVector4(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
		
		
		
		
    }
}
