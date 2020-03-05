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
        public void __RegisterSystemObject(RealStatePtr L) 
        {
		    System.Type type = typeof(object);
			Utils.BeginObjectRegister(type, L, this, 0, 5, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Equals", SystemObject_m_Equals);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetHashCode", SystemObject_m_GetHashCode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetType", SystemObject_m_GetType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToString", SystemObject_m_ToString);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetTypeName", SystemObject_m_GetTypeName);
			
			
			
			
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceSystemObject, 3, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Equals", SystemObject_m_Equals_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ReferenceEquals", SystemObject_m_ReferenceEquals_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceSystemObject(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			if(gen_param_count == 1)
			{
				
				object gen_ret = new object();
				translator.PushAny(L, gen_ret);
				
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to object constructor!");
            
        }
        
		
        
		
        
        
        
        
        int SystemObject_m_Equals(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            object gen_to_be_invoked = translator.FastGetCSObj(L, 1);
            
			
			{
				object _obj = translator.GetObject(L, 2, typeof(object));
				
				bool gen_ret = gen_to_be_invoked.Equals( _obj );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int SystemObject_m_Equals_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				object _objA = translator.GetObject(L, 1, typeof(object));
				object _objB = translator.GetObject(L, 2, typeof(object));
				
				bool gen_ret = object.Equals( _objA, _objB );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int SystemObject_m_GetHashCode(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            object gen_to_be_invoked = translator.FastGetCSObj(L, 1);
            
			
			{
				
				int gen_ret = gen_to_be_invoked.GetHashCode(  );
				LuaAPI.xlua_pushinteger(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int SystemObject_m_GetType(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            object gen_to_be_invoked = translator.FastGetCSObj(L, 1);
            
			
			{
				
				System.Type gen_ret = gen_to_be_invoked.GetType(  );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int SystemObject_m_ToString(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            object gen_to_be_invoked = translator.FastGetCSObj(L, 1);
            
			
			{
				
				string gen_ret = gen_to_be_invoked.ToString(  );
				LuaAPI.lua_pushstring(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int SystemObject_m_ReferenceEquals_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				object _objA = translator.GetObject(L, 1, typeof(object));
				object _objB = translator.GetObject(L, 2, typeof(object));
				
				bool gen_ret = object.ReferenceEquals( _objA, _objB );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int SystemObject_m_GetTypeName(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            object gen_to_be_invoked = translator.FastGetCSObj(L, 1);
            
			
			{
				
				string gen_ret = gen_to_be_invoked.GetTypeName(  );
				LuaAPI.lua_pushstring(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
