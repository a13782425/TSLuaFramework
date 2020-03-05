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
        public void __RegisterUnityEngineGameObject(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.GameObject);
			Utils.BeginObjectRegister(type, L, this, 0, 13, 8, 3);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetComponent", UnityEngineGameObject_m_GetComponent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetComponentInChildren", UnityEngineGameObject_m_GetComponentInChildren);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetComponentInParent", UnityEngineGameObject_m_GetComponentInParent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetComponents", UnityEngineGameObject_m_GetComponents);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetComponentsInChildren", UnityEngineGameObject_m_GetComponentsInChildren);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetComponentsInParent", UnityEngineGameObject_m_GetComponentsInParent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TryGetComponent", UnityEngineGameObject_m_TryGetComponent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SendMessageUpwards", UnityEngineGameObject_m_SendMessageUpwards);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SendMessage", UnityEngineGameObject_m_SendMessage);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "BroadcastMessage", UnityEngineGameObject_m_BroadcastMessage);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddComponent", UnityEngineGameObject_m_AddComponent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetActive", UnityEngineGameObject_m_SetActive);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CompareTag", UnityEngineGameObject_m_CompareTag);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "transform", UnityEngineGameObject_g_get_transform);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "layer", UnityEngineGameObject_g_get_layer);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "activeSelf", UnityEngineGameObject_g_get_activeSelf);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "activeInHierarchy", UnityEngineGameObject_g_get_activeInHierarchy);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isStatic", UnityEngineGameObject_g_get_isStatic);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "tag", UnityEngineGameObject_g_get_tag);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "scene", UnityEngineGameObject_g_get_scene);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "gameObject", UnityEngineGameObject_g_get_gameObject);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "layer", UnityEngineGameObject_s_set_layer);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "isStatic", UnityEngineGameObject_s_set_isStatic);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "tag", UnityEngineGameObject_s_set_tag);
            
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineGameObject, 6, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "CreatePrimitive", UnityEngineGameObject_m_CreatePrimitive_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FindWithTag", UnityEngineGameObject_m_FindWithTag_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FindGameObjectWithTag", UnityEngineGameObject_m_FindGameObjectWithTag_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FindGameObjectsWithTag", UnityEngineGameObject_m_FindGameObjectsWithTag_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Find", UnityEngineGameObject_m_Find_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineGameObject(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			if(gen_param_count == 2 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING))
			{
				string _name = LuaAPI.lua_tostring(L, 2);
				
				UnityEngine.GameObject gen_ret = new UnityEngine.GameObject(_name);
				translator.Push(L, gen_ret);
				
				return 1;
			}
			if(gen_param_count == 1)
			{
				
				UnityEngine.GameObject gen_ret = new UnityEngine.GameObject();
				translator.Push(L, gen_ret);
				
				return 1;
			}
			if(gen_param_count >= 2 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<System.Type>(L, 3)))
			{
				string _name = LuaAPI.lua_tostring(L, 2);
				System.Type[] _components = translator.GetParams<System.Type>(L, 3);
				
				UnityEngine.GameObject gen_ret = new UnityEngine.GameObject(_name, _components);
				translator.Push(L, gen_ret);
				
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GameObject constructor!");
            
        }
        
		
        
		
        
        
        
        
        int UnityEngineGameObject_m_CreatePrimitive_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.PrimitiveType _type;translator.Get(L, 1, out _type);
				
				UnityEngine.GameObject gen_ret = UnityEngine.GameObject.CreatePrimitive( _type );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineGameObject_m_GetComponent(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
            
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
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GameObject.GetComponent!");
            
        }
        
        int UnityEngineGameObject_m_GetComponentInChildren(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 2&& translator.Assignable<System.Type>(L, 2)) 
			{
				System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
				
				UnityEngine.Component gen_ret = gen_to_be_invoked.GetComponentInChildren( _type );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 3&& translator.Assignable<System.Type>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
			{
				System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
				bool _includeInactive = LuaAPI.lua_toboolean(L, 3);
				
				UnityEngine.Component gen_ret = gen_to_be_invoked.GetComponentInChildren( _type, _includeInactive );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GameObject.GetComponentInChildren!");
            
        }
        
        int UnityEngineGameObject_m_GetComponentInParent(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
            
			
			{
				System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
				
				UnityEngine.Component gen_ret = gen_to_be_invoked.GetComponentInParent( _type );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineGameObject_m_GetComponents(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
            
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
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GameObject.GetComponents!");
            
        }
        
        int UnityEngineGameObject_m_GetComponentsInChildren(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 2&& translator.Assignable<System.Type>(L, 2)) 
			{
				System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
				
				UnityEngine.Component[] gen_ret = gen_to_be_invoked.GetComponentsInChildren( _type );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 3&& translator.Assignable<System.Type>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
			{
				System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
				bool _includeInactive = LuaAPI.lua_toboolean(L, 3);
				
				UnityEngine.Component[] gen_ret = gen_to_be_invoked.GetComponentsInChildren( _type, _includeInactive );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GameObject.GetComponentsInChildren!");
            
        }
        
        int UnityEngineGameObject_m_GetComponentsInParent(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 2&& translator.Assignable<System.Type>(L, 2)) 
			{
				System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
				
				UnityEngine.Component[] gen_ret = gen_to_be_invoked.GetComponentsInParent( _type );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 3&& translator.Assignable<System.Type>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
			{
				System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
				bool _includeInactive = LuaAPI.lua_toboolean(L, 3);
				
				UnityEngine.Component[] gen_ret = gen_to_be_invoked.GetComponentsInParent( _type, _includeInactive );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GameObject.GetComponentsInParent!");
            
        }
        
        int UnityEngineGameObject_m_TryGetComponent(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
            
			
			{
				System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
				UnityEngine.Component _component;
				
				bool gen_ret = gen_to_be_invoked.TryGetComponent( _type, out _component );
				LuaAPI.lua_pushboolean(L, gen_ret);
				translator.Push(L, _component);
					
				
				
				
				return 2;
			}
			
            
        }
        
        int UnityEngineGameObject_m_FindWithTag_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				string _tag = LuaAPI.lua_tostring(L, 1);
				
				UnityEngine.GameObject gen_ret = UnityEngine.GameObject.FindWithTag( _tag );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineGameObject_m_SendMessageUpwards(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
			{
				string _methodName = LuaAPI.lua_tostring(L, 2);
				
				gen_to_be_invoked.SendMessageUpwards( _methodName );
				
				
				
				return 0;
			}
			if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.SendMessageOptions>(L, 3)) 
			{
				string _methodName = LuaAPI.lua_tostring(L, 2);
				UnityEngine.SendMessageOptions _options;translator.Get(L, 3, out _options);
				
				gen_to_be_invoked.SendMessageUpwards( _methodName, _options );
				
				
				
				return 0;
			}
			if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 3)) 
			{
				string _methodName = LuaAPI.lua_tostring(L, 2);
				object _value = translator.GetObject(L, 3, typeof(object));
				
				gen_to_be_invoked.SendMessageUpwards( _methodName, _value );
				
				
				
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
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GameObject.SendMessageUpwards!");
            
        }
        
        int UnityEngineGameObject_m_SendMessage(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
			{
				string _methodName = LuaAPI.lua_tostring(L, 2);
				
				gen_to_be_invoked.SendMessage( _methodName );
				
				
				
				return 0;
			}
			if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.SendMessageOptions>(L, 3)) 
			{
				string _methodName = LuaAPI.lua_tostring(L, 2);
				UnityEngine.SendMessageOptions _options;translator.Get(L, 3, out _options);
				
				gen_to_be_invoked.SendMessage( _methodName, _options );
				
				
				
				return 0;
			}
			if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 3)) 
			{
				string _methodName = LuaAPI.lua_tostring(L, 2);
				object _value = translator.GetObject(L, 3, typeof(object));
				
				gen_to_be_invoked.SendMessage( _methodName, _value );
				
				
				
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
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GameObject.SendMessage!");
            
        }
        
        int UnityEngineGameObject_m_BroadcastMessage(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
			{
				string _methodName = LuaAPI.lua_tostring(L, 2);
				
				gen_to_be_invoked.BroadcastMessage( _methodName );
				
				
				
				return 0;
			}
			if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.SendMessageOptions>(L, 3)) 
			{
				string _methodName = LuaAPI.lua_tostring(L, 2);
				UnityEngine.SendMessageOptions _options;translator.Get(L, 3, out _options);
				
				gen_to_be_invoked.BroadcastMessage( _methodName, _options );
				
				
				
				return 0;
			}
			if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 3)) 
			{
				string _methodName = LuaAPI.lua_tostring(L, 2);
				object _parameter = translator.GetObject(L, 3, typeof(object));
				
				gen_to_be_invoked.BroadcastMessage( _methodName, _parameter );
				
				
				
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
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GameObject.BroadcastMessage!");
            
        }
        
        int UnityEngineGameObject_m_AddComponent(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
            
			
			{
				System.Type _componentType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
				
				UnityEngine.Component gen_ret = gen_to_be_invoked.AddComponent( _componentType );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineGameObject_m_SetActive(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
            
			
			{
				bool _value = LuaAPI.lua_toboolean(L, 2);
				
				gen_to_be_invoked.SetActive( _value );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineGameObject_m_CompareTag(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
            
			
			{
				string _tag = LuaAPI.lua_tostring(L, 2);
				
				bool gen_ret = gen_to_be_invoked.CompareTag( _tag );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineGameObject_m_FindGameObjectWithTag_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				string _tag = LuaAPI.lua_tostring(L, 1);
				
				UnityEngine.GameObject gen_ret = UnityEngine.GameObject.FindGameObjectWithTag( _tag );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineGameObject_m_FindGameObjectsWithTag_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				string _tag = LuaAPI.lua_tostring(L, 1);
				
				UnityEngine.GameObject[] gen_ret = UnityEngine.GameObject.FindGameObjectsWithTag( _tag );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineGameObject_m_Find_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				string _name = LuaAPI.lua_tostring(L, 1);
				
				UnityEngine.GameObject gen_ret = UnityEngine.GameObject.Find( _name );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        
        
        
        int UnityEngineGameObject_g_get_transform(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.transform);
            return 1;
        }
        
        int UnityEngineGameObject_g_get_layer(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.layer);
            return 1;
        }
        
        int UnityEngineGameObject_g_get_activeSelf(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.activeSelf);
            return 1;
        }
        
        int UnityEngineGameObject_g_get_activeInHierarchy(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.activeInHierarchy);
            return 1;
        }
        
        int UnityEngineGameObject_g_get_isStatic(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isStatic);
            return 1;
        }
        
        int UnityEngineGameObject_g_get_tag(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushstring(L, gen_to_be_invoked.tag);
            return 1;
        }
        
        int UnityEngineGameObject_g_get_scene(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.scene);
            return 1;
        }
        
        int UnityEngineGameObject_g_get_gameObject(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.gameObject);
            return 1;
        }
        
        
        
        int UnityEngineGameObject_s_set_layer(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.layer = LuaAPI.xlua_tointeger(L, 2);
            
            return 0;
        }
        
        int UnityEngineGameObject_s_set_isStatic(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.isStatic = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineGameObject_s_set_tag(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.tag = LuaAPI.lua_tostring(L, 2);
            
            return 0;
        }
        
		
		
		
		
    }
}
