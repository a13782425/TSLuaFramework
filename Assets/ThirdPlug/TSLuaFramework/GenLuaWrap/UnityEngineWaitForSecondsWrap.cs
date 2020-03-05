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
        public void __RegisterUnityEngineWaitForSeconds(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.WaitForSeconds);
			Utils.BeginObjectRegister(type, L, this, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineWaitForSeconds, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineWaitForSeconds(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			if(gen_param_count == 2 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2))
			{
				float _seconds = (float)LuaAPI.lua_tonumber(L, 2);
				
				UnityEngine.WaitForSeconds gen_ret = new UnityEngine.WaitForSeconds(_seconds);
				translator.Push(L, gen_ret);
				
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.WaitForSeconds constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        
        
		
		
		
		
    }
}
