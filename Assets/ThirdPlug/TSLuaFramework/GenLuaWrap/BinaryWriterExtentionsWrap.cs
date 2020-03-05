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
        public void __RegisterBinaryWriterExtentions(RealStatePtr L) 
        {
		    System.Type type = typeof(BinaryWriterExtentions);
			Utils.BeginObjectRegister(type, L, this, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceBinaryWriterExtentions, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceBinaryWriterExtentions(RealStatePtr L, int gen_param_count) 
        {
            return LuaAPI.luaL_error(L, "BinaryWriterExtentions does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        
        
        
        
        
		
		
		
		
    }
}
