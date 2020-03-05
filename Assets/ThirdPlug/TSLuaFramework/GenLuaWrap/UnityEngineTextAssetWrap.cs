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
        public void __RegisterUnityEngineTextAsset(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.TextAsset);
			Utils.BeginObjectRegister(type, L, this, 0, 1, 2, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToString", UnityEngineTextAsset_m_ToString);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "text", UnityEngineTextAsset_g_get_text);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "bytes", UnityEngineTextAsset_g_get_bytes);
            
			
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineTextAsset, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineTextAsset(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			if(gen_param_count == 1)
			{
				
				UnityEngine.TextAsset gen_ret = new UnityEngine.TextAsset();
				translator.Push(L, gen_ret);
				
				return 1;
			}
			if(gen_param_count == 2 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING))
			{
				string _text = LuaAPI.lua_tostring(L, 2);
				
				UnityEngine.TextAsset gen_ret = new UnityEngine.TextAsset(_text);
				translator.Push(L, gen_ret);
				
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.TextAsset constructor!");
            
        }
        
		
        
		
        
        
        
        
        int UnityEngineTextAsset_m_ToString(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.TextAsset gen_to_be_invoked = (UnityEngine.TextAsset)translator.FastGetCSObj(L, 1);
            
			
			{
				
				string gen_ret = gen_to_be_invoked.ToString(  );
				LuaAPI.lua_pushstring(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        
        
        
        int UnityEngineTextAsset_g_get_text(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.TextAsset gen_to_be_invoked = (UnityEngine.TextAsset)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushstring(L, gen_to_be_invoked.text);
            return 1;
        }
        
        int UnityEngineTextAsset_g_get_bytes(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.TextAsset gen_to_be_invoked = (UnityEngine.TextAsset)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushstring(L, gen_to_be_invoked.bytes);
            return 1;
        }
        
        
        
		
		
		
		
    }
}
