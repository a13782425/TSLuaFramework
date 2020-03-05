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
        public void __RegisterUnityEngineMonoBehaviour(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.MonoBehaviour);
			Utils.BeginObjectRegister(type, L, this, 0, 7, 1, 1);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsInvoking", UnityEngineMonoBehaviour_m_IsInvoking);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CancelInvoke", UnityEngineMonoBehaviour_m_CancelInvoke);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Invoke", UnityEngineMonoBehaviour_m_Invoke);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "InvokeRepeating", UnityEngineMonoBehaviour_m_InvokeRepeating);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "StartCoroutine", UnityEngineMonoBehaviour_m_StartCoroutine);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "StopCoroutine", UnityEngineMonoBehaviour_m_StopCoroutine);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "StopAllCoroutines", UnityEngineMonoBehaviour_m_StopAllCoroutines);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "useGUILayout", UnityEngineMonoBehaviour_g_get_useGUILayout);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "useGUILayout", UnityEngineMonoBehaviour_s_set_useGUILayout);
            
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineMonoBehaviour, 2, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "print", UnityEngineMonoBehaviour_m_print_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineMonoBehaviour(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			if(gen_param_count == 1)
			{
				
				UnityEngine.MonoBehaviour gen_ret = new UnityEngine.MonoBehaviour();
				translator.Push(L, gen_ret);
				
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.MonoBehaviour constructor!");
            
        }
        
		
        
		
        
        
        
        
        int UnityEngineMonoBehaviour_m_IsInvoking(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.MonoBehaviour gen_to_be_invoked = (UnityEngine.MonoBehaviour)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 1) 
			{
				
				bool gen_ret = gen_to_be_invoked.IsInvoking(  );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
			{
				string _methodName = LuaAPI.lua_tostring(L, 2);
				
				bool gen_ret = gen_to_be_invoked.IsInvoking( _methodName );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.MonoBehaviour.IsInvoking!");
            
        }
        
        int UnityEngineMonoBehaviour_m_CancelInvoke(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.MonoBehaviour gen_to_be_invoked = (UnityEngine.MonoBehaviour)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 1) 
			{
				
				gen_to_be_invoked.CancelInvoke(  );
				
				
				
				return 0;
			}
			if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
			{
				string _methodName = LuaAPI.lua_tostring(L, 2);
				
				gen_to_be_invoked.CancelInvoke( _methodName );
				
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.MonoBehaviour.CancelInvoke!");
            
        }
        
        int UnityEngineMonoBehaviour_m_Invoke(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.MonoBehaviour gen_to_be_invoked = (UnityEngine.MonoBehaviour)translator.FastGetCSObj(L, 1);
            
			
			{
				string _methodName = LuaAPI.lua_tostring(L, 2);
				float _time = (float)LuaAPI.lua_tonumber(L, 3);
				
				gen_to_be_invoked.Invoke( _methodName, _time );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineMonoBehaviour_m_InvokeRepeating(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.MonoBehaviour gen_to_be_invoked = (UnityEngine.MonoBehaviour)translator.FastGetCSObj(L, 1);
            
			
			{
				string _methodName = LuaAPI.lua_tostring(L, 2);
				float _time = (float)LuaAPI.lua_tonumber(L, 3);
				float _repeatRate = (float)LuaAPI.lua_tonumber(L, 4);
				
				gen_to_be_invoked.InvokeRepeating( _methodName, _time, _repeatRate );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineMonoBehaviour_m_StartCoroutine(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.MonoBehaviour gen_to_be_invoked = (UnityEngine.MonoBehaviour)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
			{
				string _methodName = LuaAPI.lua_tostring(L, 2);
				
				UnityEngine.Coroutine gen_ret = gen_to_be_invoked.StartCoroutine( _methodName );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 2&& translator.Assignable<System.Collections.IEnumerator>(L, 2)) 
			{
				System.Collections.IEnumerator _routine = (System.Collections.IEnumerator)translator.GetObject(L, 2, typeof(System.Collections.IEnumerator));
				
				UnityEngine.Coroutine gen_ret = gen_to_be_invoked.StartCoroutine( _routine );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 3)) 
			{
				string _methodName = LuaAPI.lua_tostring(L, 2);
				object _value = translator.GetObject(L, 3, typeof(object));
				
				UnityEngine.Coroutine gen_ret = gen_to_be_invoked.StartCoroutine( _methodName, _value );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.MonoBehaviour.StartCoroutine!");
            
        }
        
        int UnityEngineMonoBehaviour_m_StopCoroutine(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.MonoBehaviour gen_to_be_invoked = (UnityEngine.MonoBehaviour)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 2&& translator.Assignable<System.Collections.IEnumerator>(L, 2)) 
			{
				System.Collections.IEnumerator _routine = (System.Collections.IEnumerator)translator.GetObject(L, 2, typeof(System.Collections.IEnumerator));
				
				gen_to_be_invoked.StopCoroutine( _routine );
				
				
				
				return 0;
			}
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.Coroutine>(L, 2)) 
			{
				UnityEngine.Coroutine _routine = (UnityEngine.Coroutine)translator.GetObject(L, 2, typeof(UnityEngine.Coroutine));
				
				gen_to_be_invoked.StopCoroutine( _routine );
				
				
				
				return 0;
			}
			if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
			{
				string _methodName = LuaAPI.lua_tostring(L, 2);
				
				gen_to_be_invoked.StopCoroutine( _methodName );
				
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.MonoBehaviour.StopCoroutine!");
            
        }
        
        int UnityEngineMonoBehaviour_m_StopAllCoroutines(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.MonoBehaviour gen_to_be_invoked = (UnityEngine.MonoBehaviour)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.StopAllCoroutines(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineMonoBehaviour_m_print_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				object _message = translator.GetObject(L, 1, typeof(object));
				
				UnityEngine.MonoBehaviour.print( _message );
				
				
				
				return 0;
			}
			
            
        }
        
        
        
        
        int UnityEngineMonoBehaviour_g_get_useGUILayout(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.MonoBehaviour gen_to_be_invoked = (UnityEngine.MonoBehaviour)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.useGUILayout);
            return 1;
        }
        
        
        
        int UnityEngineMonoBehaviour_s_set_useGUILayout(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.MonoBehaviour gen_to_be_invoked = (UnityEngine.MonoBehaviour)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.useGUILayout = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
		
		
		
		
    }
}
