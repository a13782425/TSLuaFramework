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
        public void __RegisterTSLuaFrameworkUIUIParticle(RealStatePtr L) 
        {
		    System.Type type = typeof(TSLuaFramework.UI.UIParticle);
			Utils.BeginObjectRegister(type, L, this, 0, 0, 3, 2);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "mainTexture", TSLuaFrameworkUIUIParticle_g_get_mainTexture);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "fixedTime", TSLuaFrameworkUIUIParticle_g_get_fixedTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "maxParticleCount", TSLuaFrameworkUIUIParticle_g_get_maxParticleCount);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "fixedTime", TSLuaFrameworkUIUIParticle_s_set_fixedTime);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "maxParticleCount", TSLuaFrameworkUIUIParticle_s_set_maxParticleCount);
            
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceTSLuaFrameworkUIUIParticle, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceTSLuaFrameworkUIUIParticle(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			if(gen_param_count == 1)
			{
				
				TSLuaFramework.UI.UIParticle gen_ret = new TSLuaFramework.UI.UIParticle();
				translator.Push(L, gen_ret);
				
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to TSLuaFramework.UI.UIParticle constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        int TSLuaFrameworkUIUIParticle_g_get_mainTexture(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			TSLuaFramework.UI.UIParticle gen_to_be_invoked = (TSLuaFramework.UI.UIParticle)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.mainTexture);
            return 1;
        }
        
        int TSLuaFrameworkUIUIParticle_g_get_fixedTime(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			TSLuaFramework.UI.UIParticle gen_to_be_invoked = (TSLuaFramework.UI.UIParticle)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.fixedTime);
            return 1;
        }
        
        int TSLuaFrameworkUIUIParticle_g_get_maxParticleCount(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			TSLuaFramework.UI.UIParticle gen_to_be_invoked = (TSLuaFramework.UI.UIParticle)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.maxParticleCount);
            return 1;
        }
        
        
        
        int TSLuaFrameworkUIUIParticle_s_set_fixedTime(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            TSLuaFramework.UI.UIParticle gen_to_be_invoked = (TSLuaFramework.UI.UIParticle)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.fixedTime = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int TSLuaFrameworkUIUIParticle_s_set_maxParticleCount(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            TSLuaFramework.UI.UIParticle gen_to_be_invoked = (TSLuaFramework.UI.UIParticle)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.maxParticleCount = LuaAPI.xlua_tointeger(L, 2);
            
            return 0;
        }
        
		
		
		
		
    }
}
