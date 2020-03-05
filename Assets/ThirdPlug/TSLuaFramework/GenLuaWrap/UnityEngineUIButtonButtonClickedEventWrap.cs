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
        public void __RegisterUnityEngineUIButtonButtonClickedEvent(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.UI.Button.ButtonClickedEvent);
			Utils.BeginObjectRegister(type, L, this, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineUIButtonButtonClickedEvent, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineUIButtonButtonClickedEvent(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			if(gen_param_count == 1)
			{
				
				UnityEngine.UI.Button.ButtonClickedEvent gen_ret = new UnityEngine.UI.Button.ButtonClickedEvent();
				translator.Push(L, gen_ret);
				
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.UI.Button.ButtonClickedEvent constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        
        
		
		
		
		
    }
}
