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
        public void __RegisterUnityEngineObject(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.Object);
			Utils.BeginObjectRegister(type, L, this, 1, 5, 2, 2);
			Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__eq", UnityEngineObject__EqMeta);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetInstanceID", UnityEngineObject_m_GetInstanceID);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetHashCode", UnityEngineObject_m_GetHashCode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Equals", UnityEngineObject_m_Equals);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToString", UnityEngineObject_m_ToString);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsNull", UnityEngineObject_m_IsNull);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "name", UnityEngineObject_g_get_name);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hideFlags", UnityEngineObject_g_get_hideFlags);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "name", UnityEngineObject_s_set_name);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "hideFlags", UnityEngineObject_s_set_hideFlags);
            
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineObject, 7, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Instantiate", UnityEngineObject_m_Instantiate_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Destroy", UnityEngineObject_m_Destroy_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DestroyImmediate", UnityEngineObject_m_DestroyImmediate_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FindObjectsOfType", UnityEngineObject_m_FindObjectsOfType_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DontDestroyOnLoad", UnityEngineObject_m_DontDestroyOnLoad_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FindObjectOfType", UnityEngineObject_m_FindObjectOfType_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineObject(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			if(gen_param_count == 1)
			{
				
				UnityEngine.Object gen_ret = new UnityEngine.Object();
				translator.Push(L, gen_ret);
				
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Object constructor!");
            
        }
        
		
        
		
        
        
        int UnityEngineObject__EqMeta(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
            
			if (translator.Assignable<UnityEngine.Object>(L, 1) && translator.Assignable<UnityEngine.Object>(L, 2))
			{
				UnityEngine.Object leftside = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
				UnityEngine.Object rightside = (UnityEngine.Object)translator.GetObject(L, 2, typeof(UnityEngine.Object));
				
				LuaAPI.lua_pushboolean(L, leftside == rightside);
				
				return 1;
			}
            
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of == operator, need UnityEngine.Object!");
            
        }
        
        
        
        int UnityEngineObject_m_GetInstanceID(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Object gen_to_be_invoked = (UnityEngine.Object)translator.FastGetCSObj(L, 1);
            
			
			{
				
				int gen_ret = gen_to_be_invoked.GetInstanceID(  );
				LuaAPI.xlua_pushinteger(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineObject_m_GetHashCode(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Object gen_to_be_invoked = (UnityEngine.Object)translator.FastGetCSObj(L, 1);
            
			
			{
				
				int gen_ret = gen_to_be_invoked.GetHashCode(  );
				LuaAPI.xlua_pushinteger(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineObject_m_Equals(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Object gen_to_be_invoked = (UnityEngine.Object)translator.FastGetCSObj(L, 1);
            
			
			{
				object _other = translator.GetObject(L, 2, typeof(object));
				
				bool gen_ret = gen_to_be_invoked.Equals( _other );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineObject_m_Instantiate_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			if(gen_param_count == 1&& translator.Assignable<UnityEngine.Object>(L, 1)) 
			{
				UnityEngine.Object _original = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
				
				UnityEngine.Object gen_ret = UnityEngine.Object.Instantiate( _original );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 1&& translator.Assignable<UnityEngine.Object>(L, 1)) 
			{
				UnityEngine.Object _original = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
				
				UnityEngine.Object gen_ret = UnityEngine.Object.Instantiate( _original );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.Object>(L, 1)&& translator.Assignable<UnityEngine.Transform>(L, 2)) 
			{
				UnityEngine.Object _original = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
				UnityEngine.Transform _parent = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
				
				UnityEngine.Object gen_ret = UnityEngine.Object.Instantiate( _original, _parent );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.Object>(L, 1)&& translator.Assignable<UnityEngine.Transform>(L, 2)) 
			{
				UnityEngine.Object _original = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
				UnityEngine.Transform _parent = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
				
				UnityEngine.Object gen_ret = UnityEngine.Object.Instantiate( _original, _parent );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 3&& translator.Assignable<UnityEngine.Object>(L, 1)&& translator.Assignable<UnityEngine.Transform>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
			{
				UnityEngine.Object _original = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
				UnityEngine.Transform _parent = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
				bool _instantiateInWorldSpace = LuaAPI.lua_toboolean(L, 3);
				
				UnityEngine.Object gen_ret = UnityEngine.Object.Instantiate( _original, _parent, _instantiateInWorldSpace );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 3&& translator.Assignable<UnityEngine.Object>(L, 1)&& translator.Assignable<UnityEngine.Transform>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
			{
				UnityEngine.Object _original = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
				UnityEngine.Transform _parent = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
				bool _worldPositionStays = LuaAPI.lua_toboolean(L, 3);
				
				UnityEngine.Object gen_ret = UnityEngine.Object.Instantiate( _original, _parent, _worldPositionStays );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 3&& translator.Assignable<UnityEngine.Object>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Quaternion>(L, 3)) 
			{
				UnityEngine.Object _original = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
				UnityEngine.Vector3 _position;translator.Get(L, 2, out _position);
				UnityEngine.Quaternion _rotation;translator.Get(L, 3, out _rotation);
				
				UnityEngine.Object gen_ret = UnityEngine.Object.Instantiate( _original, _position, _rotation );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 3&& translator.Assignable<UnityEngine.Object>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Quaternion>(L, 3)) 
			{
				UnityEngine.Object _original = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
				UnityEngine.Vector3 _position;translator.Get(L, 2, out _position);
				UnityEngine.Quaternion _rotation;translator.Get(L, 3, out _rotation);
				
				UnityEngine.Object gen_ret = UnityEngine.Object.Instantiate( _original, _position, _rotation );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 4&& translator.Assignable<UnityEngine.Object>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Quaternion>(L, 3)&& translator.Assignable<UnityEngine.Transform>(L, 4)) 
			{
				UnityEngine.Object _original = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
				UnityEngine.Vector3 _position;translator.Get(L, 2, out _position);
				UnityEngine.Quaternion _rotation;translator.Get(L, 3, out _rotation);
				UnityEngine.Transform _parent = (UnityEngine.Transform)translator.GetObject(L, 4, typeof(UnityEngine.Transform));
				
				UnityEngine.Object gen_ret = UnityEngine.Object.Instantiate( _original, _position, _rotation, _parent );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 4&& translator.Assignable<UnityEngine.Object>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Quaternion>(L, 3)&& translator.Assignable<UnityEngine.Transform>(L, 4)) 
			{
				UnityEngine.Object _original = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
				UnityEngine.Vector3 _position;translator.Get(L, 2, out _position);
				UnityEngine.Quaternion _rotation;translator.Get(L, 3, out _rotation);
				UnityEngine.Transform _parent = (UnityEngine.Transform)translator.GetObject(L, 4, typeof(UnityEngine.Transform));
				
				UnityEngine.Object gen_ret = UnityEngine.Object.Instantiate( _original, _position, _rotation, _parent );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Object.Instantiate!");
            
        }
        
        int UnityEngineObject_m_Destroy_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			if(gen_param_count == 1&& translator.Assignable<UnityEngine.Object>(L, 1)) 
			{
				UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
				
				UnityEngine.Object.Destroy( _obj );
				
				
				
				return 0;
			}
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.Object>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
			{
				UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
				float _t = (float)LuaAPI.lua_tonumber(L, 2);
				
				UnityEngine.Object.Destroy( _obj, _t );
				
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Object.Destroy!");
            
        }
        
        int UnityEngineObject_m_DestroyImmediate_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			if(gen_param_count == 1&& translator.Assignable<UnityEngine.Object>(L, 1)) 
			{
				UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
				
				UnityEngine.Object.DestroyImmediate( _obj );
				
				
				
				return 0;
			}
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.Object>(L, 1)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
			{
				UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
				bool _allowDestroyingAssets = LuaAPI.lua_toboolean(L, 2);
				
				UnityEngine.Object.DestroyImmediate( _obj, _allowDestroyingAssets );
				
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Object.DestroyImmediate!");
            
        }
        
        int UnityEngineObject_m_FindObjectsOfType_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				System.Type _type = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
				
				UnityEngine.Object[] gen_ret = UnityEngine.Object.FindObjectsOfType( _type );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineObject_m_DontDestroyOnLoad_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Object _target = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
				
				UnityEngine.Object.DontDestroyOnLoad( _target );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineObject_m_FindObjectOfType_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				System.Type _type = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
				
				UnityEngine.Object gen_ret = UnityEngine.Object.FindObjectOfType( _type );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineObject_m_ToString(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Object gen_to_be_invoked = (UnityEngine.Object)translator.FastGetCSObj(L, 1);
            
			
			{
				
				string gen_ret = gen_to_be_invoked.ToString(  );
				LuaAPI.lua_pushstring(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineObject_m_IsNull(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Object gen_to_be_invoked = (UnityEngine.Object)translator.FastGetCSObj(L, 1);
            
			
			{
				
				bool gen_ret = gen_to_be_invoked.IsNull(  );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        
        
        
        int UnityEngineObject_g_get_name(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Object gen_to_be_invoked = (UnityEngine.Object)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushstring(L, gen_to_be_invoked.name);
            return 1;
        }
        
        int UnityEngineObject_g_get_hideFlags(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Object gen_to_be_invoked = (UnityEngine.Object)translator.FastGetCSObj(L, 1);
			translator.PushUnityEngineHideFlags(L, gen_to_be_invoked.hideFlags);
            return 1;
        }
        
        
        
        int UnityEngineObject_s_set_name(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Object gen_to_be_invoked = (UnityEngine.Object)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.name = LuaAPI.lua_tostring(L, 2);
            
            return 0;
        }
        
        int UnityEngineObject_s_set_hideFlags(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Object gen_to_be_invoked = (UnityEngine.Object)translator.FastGetCSObj(L, 1);
            UnityEngine.HideFlags gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.hideFlags = gen_value;
            
            return 0;
        }
        
		
		
		
		
    }
}
