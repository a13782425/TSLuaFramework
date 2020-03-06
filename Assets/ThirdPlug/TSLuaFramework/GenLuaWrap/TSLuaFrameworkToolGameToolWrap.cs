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
        public void __RegisterTSLuaFrameworkToolGameTool(RealStatePtr L) 
        {
		    System.Type type = typeof(TSLuaFramework.Tool.GameTool);
			Utils.BeginObjectRegister(type, L, this, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceTSLuaFrameworkToolGameTool, 3, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "GetInstanceId", TSLuaFrameworkToolGameTool_m_GetInstanceId_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RecoverInstanceId", TSLuaFrameworkToolGameTool_m_RecoverInstanceId_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceTSLuaFrameworkToolGameTool(RealStatePtr L, int gen_param_count) 
        {
            return LuaAPI.luaL_error(L, "TSLuaFramework.Tool.GameTool does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        int TSLuaFrameworkToolGameTool_m_GetInstanceId_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				
				int gen_ret = TSLuaFramework.Tool.GameTool.GetInstanceId(  );
				LuaAPI.xlua_pushinteger(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int TSLuaFrameworkToolGameTool_m_RecoverInstanceId_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				int _instanceId = LuaAPI.xlua_tointeger(L, 1);
				
				TSLuaFramework.Tool.GameTool.RecoverInstanceId( _instanceId );
				
				
				
				return 0;
			}
			
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
