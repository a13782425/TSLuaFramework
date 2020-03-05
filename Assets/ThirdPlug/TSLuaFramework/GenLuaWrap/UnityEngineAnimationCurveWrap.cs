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
        public void __RegisterUnityEngineAnimationCurve(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.AnimationCurve);
			Utils.BeginObjectRegister(type, L, this, 0, 7, 4, 3);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Evaluate", UnityEngineAnimationCurve_m_Evaluate);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddKey", UnityEngineAnimationCurve_m_AddKey);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MoveKey", UnityEngineAnimationCurve_m_MoveKey);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveKey", UnityEngineAnimationCurve_m_RemoveKey);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SmoothTangents", UnityEngineAnimationCurve_m_SmoothTangents);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Equals", UnityEngineAnimationCurve_m_Equals);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetHashCode", UnityEngineAnimationCurve_m_GetHashCode);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "keys", UnityEngineAnimationCurve_g_get_keys);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "length", UnityEngineAnimationCurve_g_get_length);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "preWrapMode", UnityEngineAnimationCurve_g_get_preWrapMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "postWrapMode", UnityEngineAnimationCurve_g_get_postWrapMode);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "keys", UnityEngineAnimationCurve_s_set_keys);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "preWrapMode", UnityEngineAnimationCurve_s_set_preWrapMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "postWrapMode", UnityEngineAnimationCurve_s_set_postWrapMode);
            
			
			Utils.EndObjectRegister(type, L, this, __CSIndexerUnityEngineAnimationCurve, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineAnimationCurve, 4, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Constant", UnityEngineAnimationCurve_m_Constant_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Linear", UnityEngineAnimationCurve_m_Linear_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "EaseInOut", UnityEngineAnimationCurve_m_EaseInOut_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineAnimationCurve(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			if(gen_param_count >= 1 && (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<UnityEngine.Keyframe>(L, 2)))
			{
				UnityEngine.Keyframe[] _keys = translator.GetParams<UnityEngine.Keyframe>(L, 2);
				
				UnityEngine.AnimationCurve gen_ret = new UnityEngine.AnimationCurve(_keys);
				translator.Push(L, gen_ret);
				
				return 1;
			}
			if(gen_param_count == 1)
			{
				
				UnityEngine.AnimationCurve gen_ret = new UnityEngine.AnimationCurve();
				translator.Push(L, gen_ret);
				
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.AnimationCurve constructor!");
            
        }
        
		
        int __CSIndexerUnityEngineAnimationCurve(RealStatePtr L, int gen_param_count) 
        {
			ObjectTranslator translator = this;
			
			if (translator.Assignable<UnityEngine.AnimationCurve>(L, 1) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2))
			{
				
				UnityEngine.AnimationCurve gen_to_be_invoked = (UnityEngine.AnimationCurve)translator.FastGetCSObj(L, 1);
				int index = LuaAPI.xlua_tointeger(L, 2);
				LuaAPI.lua_pushboolean(L, true);
				translator.Push(L, gen_to_be_invoked[index]);
				return 2;
			}
			
            LuaAPI.lua_pushboolean(L, false);
			return 1;
        }
		
        
		
        
        
        
        
        int UnityEngineAnimationCurve_m_Evaluate(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.AnimationCurve gen_to_be_invoked = (UnityEngine.AnimationCurve)translator.FastGetCSObj(L, 1);
            
			
			{
				float _time = (float)LuaAPI.lua_tonumber(L, 2);
				
				float gen_ret = gen_to_be_invoked.Evaluate( _time );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineAnimationCurve_m_AddKey(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.AnimationCurve gen_to_be_invoked = (UnityEngine.AnimationCurve)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
			{
				float _time = (float)LuaAPI.lua_tonumber(L, 2);
				float _value = (float)LuaAPI.lua_tonumber(L, 3);
				
				int gen_ret = gen_to_be_invoked.AddKey( _time, _value );
				LuaAPI.xlua_pushinteger(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.Keyframe>(L, 2)) 
			{
				UnityEngine.Keyframe _key;translator.Get(L, 2, out _key);
				
				int gen_ret = gen_to_be_invoked.AddKey( _key );
				LuaAPI.xlua_pushinteger(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.AnimationCurve.AddKey!");
            
        }
        
        int UnityEngineAnimationCurve_m_MoveKey(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.AnimationCurve gen_to_be_invoked = (UnityEngine.AnimationCurve)translator.FastGetCSObj(L, 1);
            
			
			{
				int _index = LuaAPI.xlua_tointeger(L, 2);
				UnityEngine.Keyframe _key;translator.Get(L, 3, out _key);
				
				int gen_ret = gen_to_be_invoked.MoveKey( _index, _key );
				LuaAPI.xlua_pushinteger(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineAnimationCurve_m_RemoveKey(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.AnimationCurve gen_to_be_invoked = (UnityEngine.AnimationCurve)translator.FastGetCSObj(L, 1);
            
			
			{
				int _index = LuaAPI.xlua_tointeger(L, 2);
				
				gen_to_be_invoked.RemoveKey( _index );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineAnimationCurve_m_SmoothTangents(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.AnimationCurve gen_to_be_invoked = (UnityEngine.AnimationCurve)translator.FastGetCSObj(L, 1);
            
			
			{
				int _index = LuaAPI.xlua_tointeger(L, 2);
				float _weight = (float)LuaAPI.lua_tonumber(L, 3);
				
				gen_to_be_invoked.SmoothTangents( _index, _weight );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineAnimationCurve_m_Constant_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				float _timeStart = (float)LuaAPI.lua_tonumber(L, 1);
				float _timeEnd = (float)LuaAPI.lua_tonumber(L, 2);
				float _value = (float)LuaAPI.lua_tonumber(L, 3);
				
				UnityEngine.AnimationCurve gen_ret = UnityEngine.AnimationCurve.Constant( _timeStart, _timeEnd, _value );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineAnimationCurve_m_Linear_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				float _timeStart = (float)LuaAPI.lua_tonumber(L, 1);
				float _valueStart = (float)LuaAPI.lua_tonumber(L, 2);
				float _timeEnd = (float)LuaAPI.lua_tonumber(L, 3);
				float _valueEnd = (float)LuaAPI.lua_tonumber(L, 4);
				
				UnityEngine.AnimationCurve gen_ret = UnityEngine.AnimationCurve.Linear( _timeStart, _valueStart, _timeEnd, _valueEnd );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineAnimationCurve_m_EaseInOut_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				float _timeStart = (float)LuaAPI.lua_tonumber(L, 1);
				float _valueStart = (float)LuaAPI.lua_tonumber(L, 2);
				float _timeEnd = (float)LuaAPI.lua_tonumber(L, 3);
				float _valueEnd = (float)LuaAPI.lua_tonumber(L, 4);
				
				UnityEngine.AnimationCurve gen_ret = UnityEngine.AnimationCurve.EaseInOut( _timeStart, _valueStart, _timeEnd, _valueEnd );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineAnimationCurve_m_Equals(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.AnimationCurve gen_to_be_invoked = (UnityEngine.AnimationCurve)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 2&& translator.Assignable<object>(L, 2)) 
			{
				object _o = translator.GetObject(L, 2, typeof(object));
				
				bool gen_ret = gen_to_be_invoked.Equals( _o );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.AnimationCurve>(L, 2)) 
			{
				UnityEngine.AnimationCurve _other = (UnityEngine.AnimationCurve)translator.GetObject(L, 2, typeof(UnityEngine.AnimationCurve));
				
				bool gen_ret = gen_to_be_invoked.Equals( _other );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.AnimationCurve.Equals!");
            
        }
        
        int UnityEngineAnimationCurve_m_GetHashCode(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.AnimationCurve gen_to_be_invoked = (UnityEngine.AnimationCurve)translator.FastGetCSObj(L, 1);
            
			
			{
				
				int gen_ret = gen_to_be_invoked.GetHashCode(  );
				LuaAPI.xlua_pushinteger(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        
        
        
        int UnityEngineAnimationCurve_g_get_keys(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.AnimationCurve gen_to_be_invoked = (UnityEngine.AnimationCurve)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.keys);
            return 1;
        }
        
        int UnityEngineAnimationCurve_g_get_length(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.AnimationCurve gen_to_be_invoked = (UnityEngine.AnimationCurve)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.length);
            return 1;
        }
        
        int UnityEngineAnimationCurve_g_get_preWrapMode(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.AnimationCurve gen_to_be_invoked = (UnityEngine.AnimationCurve)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.preWrapMode);
            return 1;
        }
        
        int UnityEngineAnimationCurve_g_get_postWrapMode(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.AnimationCurve gen_to_be_invoked = (UnityEngine.AnimationCurve)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.postWrapMode);
            return 1;
        }
        
        
        
        int UnityEngineAnimationCurve_s_set_keys(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.AnimationCurve gen_to_be_invoked = (UnityEngine.AnimationCurve)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.keys = (UnityEngine.Keyframe[])translator.GetObject(L, 2, typeof(UnityEngine.Keyframe[]));
            
            return 0;
        }
        
        int UnityEngineAnimationCurve_s_set_preWrapMode(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.AnimationCurve gen_to_be_invoked = (UnityEngine.AnimationCurve)translator.FastGetCSObj(L, 1);
            UnityEngine.WrapMode gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.preWrapMode = gen_value;
            
            return 0;
        }
        
        int UnityEngineAnimationCurve_s_set_postWrapMode(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.AnimationCurve gen_to_be_invoked = (UnityEngine.AnimationCurve)translator.FastGetCSObj(L, 1);
            UnityEngine.WrapMode gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.postWrapMode = gen_value;
            
            return 0;
        }
        
		
		
		
		
    }
}
