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
        public void __RegisterUnityEngineBehaviour(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.Behaviour);
			Utils.BeginObjectRegister(type, L, this, 0, 0, 2, 1);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "enabled", UnityEngineBehaviour_g_get_enabled);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isActiveAndEnabled", UnityEngineBehaviour_g_get_isActiveAndEnabled);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "enabled", UnityEngineBehaviour_s_set_enabled);
            
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineBehaviour, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineBehaviour(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			if(gen_param_count == 1)
			{
				
				UnityEngine.Behaviour gen_ret = new UnityEngine.Behaviour();
				translator.Push(L, gen_ret);
				
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Behaviour constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        int UnityEngineBehaviour_g_get_enabled(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Behaviour gen_to_be_invoked = (UnityEngine.Behaviour)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.enabled);
            return 1;
        }
        
        int UnityEngineBehaviour_g_get_isActiveAndEnabled(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Behaviour gen_to_be_invoked = (UnityEngine.Behaviour)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isActiveAndEnabled);
            return 1;
        }
        
        
        
        int UnityEngineBehaviour_s_set_enabled(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Behaviour gen_to_be_invoked = (UnityEngine.Behaviour)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.enabled = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
		
		
		
		
    }
}
