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
        public void __RegisterUnityEngineComponent(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.Component);
			Utils.BeginObjectRegister(type, L, this, 0, 11, 3, 1);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetComponent", UnityEngineComponent_m_GetComponent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TryGetComponent", UnityEngineComponent_m_TryGetComponent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetComponentInChildren", UnityEngineComponent_m_GetComponentInChildren);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetComponentsInChildren", UnityEngineComponent_m_GetComponentsInChildren);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetComponentInParent", UnityEngineComponent_m_GetComponentInParent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetComponentsInParent", UnityEngineComponent_m_GetComponentsInParent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetComponents", UnityEngineComponent_m_GetComponents);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CompareTag", UnityEngineComponent_m_CompareTag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SendMessageUpwards", UnityEngineComponent_m_SendMessageUpwards);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SendMessage", UnityEngineComponent_m_SendMessage);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "BroadcastMessage", UnityEngineComponent_m_BroadcastMessage);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "transform", UnityEngineComponent_g_get_transform);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "gameObject", UnityEngineComponent_g_get_gameObject);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "tag", UnityEngineComponent_g_get_tag);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "tag", UnityEngineComponent_s_set_tag);
            
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineComponent, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineComponent(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			if(gen_param_count == 1)
			{
				
				UnityEngine.Component gen_ret = new UnityEngine.Component();
				translator.Push(L, gen_ret);
				
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Component constructor!");
            
        }
        
		
        
		
        
        
        
        
        int UnityEngineComponent_m_GetComponent(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Component gen_to_be_invoked = (UnityEngine.Component)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 2&& translator.Assignable<System.Type>(L, 2)) 
			{
				System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
				
				UnityEngine.Component gen_ret = gen_to_be_invoked.GetComponent( _type );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
			{
				string _type = LuaAPI.lua_tostring(L, 2);
				
				UnityEngine.Component gen_ret = gen_to_be_invoked.GetComponent( _type );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Component.GetComponent!");
            
        }
        
        int UnityEngineComponent_m_TryGetComponent(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Component gen_to_be_invoked = (UnityEngine.Component)translator.FastGetCSObj(L, 1);
            
			
			{
				System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
				UnityEngine.Component _component;
				
				bool gen_ret = gen_to_be_invoked.TryGetComponent( _type, out _component );
				LuaAPI.lua_pushboolean(L, gen_ret);
				translator.Push(L, _component);
					
				
				
				
				return 2;
			}
			
            
        }
        
        int UnityEngineComponent_m_GetComponentInChildren(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Component gen_to_be_invoked = (UnityEngine.Component)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 2&& translator.Assignable<System.Type>(L, 2)) 
			{
				System.Type _t = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
				
				UnityEngine.Component gen_ret = gen_to_be_invoked.GetComponentInChildren( _t );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 3&& translator.Assignable<System.Type>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
			{
				System.Type _t = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
				bool _includeInactive = LuaAPI.lua_toboolean(L, 3);
				
				UnityEngine.Component gen_ret = gen_to_be_invoked.GetComponentInChildren( _t, _includeInactive );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Component.GetComponentInChildren!");
            
        }
        
        int UnityEngineComponent_m_GetComponentsInChildren(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Component gen_to_be_invoked = (UnityEngine.Component)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 2&& translator.Assignable<System.Type>(L, 2)) 
			{
				System.Type _t = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
				
				UnityEngine.Component[] gen_ret = gen_to_be_invoked.GetComponentsInChildren( _t );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 3&& translator.Assignable<System.Type>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
			{
				System.Type _t = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
				bool _includeInactive = LuaAPI.lua_toboolean(L, 3);
				
				UnityEngine.Component[] gen_ret = gen_to_be_invoked.GetComponentsInChildren( _t, _includeInactive );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Component.GetComponentsInChildren!");
            
        }
        
        int UnityEngineComponent_m_GetComponentInParent(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Component gen_to_be_invoked = (UnityEngine.Component)translator.FastGetCSObj(L, 1);
            
			
			{
				System.Type _t = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
				
				UnityEngine.Component gen_ret = gen_to_be_invoked.GetComponentInParent( _t );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineComponent_m_GetComponentsInParent(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Component gen_to_be_invoked = (UnityEngine.Component)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 2&& translator.Assignable<System.Type>(L, 2)) 
			{
				System.Type _t = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
				
				UnityEngine.Component[] gen_ret = gen_to_be_invoked.GetComponentsInParent( _t );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 3&& translator.Assignable<System.Type>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
			{
				System.Type _t = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
				bool _includeInactive = LuaAPI.lua_toboolean(L, 3);
				
				UnityEngine.Component[] gen_ret = gen_to_be_invoked.GetComponentsInParent( _t, _includeInactive );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Component.GetComponentsInParent!");
            
        }
        
        int UnityEngineComponent_m_GetComponents(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Component gen_to_be_invoked = (UnityEngine.Component)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 2&& translator.Assignable<System.Type>(L, 2)) 
			{
				System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
				
				UnityEngine.Component[] gen_ret = gen_to_be_invoked.GetComponents( _type );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 3&& translator.Assignable<System.Type>(L, 2)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Component>>(L, 3)) 
			{
				System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
				System.Collections.Generic.List<UnityEngine.Component> _results = (System.Collections.Generic.List<UnityEngine.Component>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Component>));
				
				gen_to_be_invoked.GetComponents( _type, _results );
				
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Component.GetComponents!");
            
        }
        
        int UnityEngineComponent_m_CompareTag(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Component gen_to_be_invoked = (UnityEngine.Component)translator.FastGetCSObj(L, 1);
            
			
			{
				string _tag = LuaAPI.lua_tostring(L, 2);
				
				bool gen_ret = gen_to_be_invoked.CompareTag( _tag );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineComponent_m_SendMessageUpwards(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Component gen_to_be_invoked = (UnityEngine.Component)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
			{
				string _methodName = LuaAPI.lua_tostring(L, 2);
				
				gen_to_be_invoked.SendMessageUpwards( _methodName );
				
				
				
				return 0;
			}
			if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 3)) 
			{
				string _methodName = LuaAPI.lua_tostring(L, 2);
				object _value = translator.GetObject(L, 3, typeof(object));
				
				gen_to_be_invoked.SendMessageUpwards( _methodName, _value );
				
				
				
				return 0;
			}
			if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.SendMessageOptions>(L, 3)) 
			{
				string _methodName = LuaAPI.lua_tostring(L, 2);
				UnityEngine.SendMessageOptions _options;translator.Get(L, 3, out _options);
				
				gen_to_be_invoked.SendMessageUpwards( _methodName, _options );
				
				
				
				return 0;
			}
			if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 3)&& translator.Assignable<UnityEngine.SendMessageOptions>(L, 4)) 
			{
				string _methodName = LuaAPI.lua_tostring(L, 2);
				object _value = translator.GetObject(L, 3, typeof(object));
				UnityEngine.SendMessageOptions _options;translator.Get(L, 4, out _options);
				
				gen_to_be_invoked.SendMessageUpwards( _methodName, _value, _options );
				
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Component.SendMessageUpwards!");
            
        }
        
        int UnityEngineComponent_m_SendMessage(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Component gen_to_be_invoked = (UnityEngine.Component)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
			{
				string _methodName = LuaAPI.lua_tostring(L, 2);
				
				gen_to_be_invoked.SendMessage( _methodName );
				
				
				
				return 0;
			}
			if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 3)) 
			{
				string _methodName = LuaAPI.lua_tostring(L, 2);
				object _value = translator.GetObject(L, 3, typeof(object));
				
				gen_to_be_invoked.SendMessage( _methodName, _value );
				
				
				
				return 0;
			}
			if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.SendMessageOptions>(L, 3)) 
			{
				string _methodName = LuaAPI.lua_tostring(L, 2);
				UnityEngine.SendMessageOptions _options;translator.Get(L, 3, out _options);
				
				gen_to_be_invoked.SendMessage( _methodName, _options );
				
				
				
				return 0;
			}
			if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 3)&& translator.Assignable<UnityEngine.SendMessageOptions>(L, 4)) 
			{
				string _methodName = LuaAPI.lua_tostring(L, 2);
				object _value = translator.GetObject(L, 3, typeof(object));
				UnityEngine.SendMessageOptions _options;translator.Get(L, 4, out _options);
				
				gen_to_be_invoked.SendMessage( _methodName, _value, _options );
				
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Component.SendMessage!");
            
        }
        
        int UnityEngineComponent_m_BroadcastMessage(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Component gen_to_be_invoked = (UnityEngine.Component)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
			{
				string _methodName = LuaAPI.lua_tostring(L, 2);
				
				gen_to_be_invoked.BroadcastMessage( _methodName );
				
				
				
				return 0;
			}
			if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 3)) 
			{
				string _methodName = LuaAPI.lua_tostring(L, 2);
				object _parameter = translator.GetObject(L, 3, typeof(object));
				
				gen_to_be_invoked.BroadcastMessage( _methodName, _parameter );
				
				
				
				return 0;
			}
			if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.SendMessageOptions>(L, 3)) 
			{
				string _methodName = LuaAPI.lua_tostring(L, 2);
				UnityEngine.SendMessageOptions _options;translator.Get(L, 3, out _options);
				
				gen_to_be_invoked.BroadcastMessage( _methodName, _options );
				
				
				
				return 0;
			}
			if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 3)&& translator.Assignable<UnityEngine.SendMessageOptions>(L, 4)) 
			{
				string _methodName = LuaAPI.lua_tostring(L, 2);
				object _parameter = translator.GetObject(L, 3, typeof(object));
				UnityEngine.SendMessageOptions _options;translator.Get(L, 4, out _options);
				
				gen_to_be_invoked.BroadcastMessage( _methodName, _parameter, _options );
				
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Component.BroadcastMessage!");
            
        }
        
        
        
        
        int UnityEngineComponent_g_get_transform(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Component gen_to_be_invoked = (UnityEngine.Component)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.transform);
            return 1;
        }
        
        int UnityEngineComponent_g_get_gameObject(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Component gen_to_be_invoked = (UnityEngine.Component)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.gameObject);
            return 1;
        }
        
        int UnityEngineComponent_g_get_tag(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Component gen_to_be_invoked = (UnityEngine.Component)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushstring(L, gen_to_be_invoked.tag);
            return 1;
        }
        
        
        
        int UnityEngineComponent_s_set_tag(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Component gen_to_be_invoked = (UnityEngine.Component)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.tag = LuaAPI.lua_tostring(L, 2);
            
            return 0;
        }
        
		
		
		
		
    }
}
