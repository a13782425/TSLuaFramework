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
        public void __RegisterTSLuaFrameworkUITextPlus(RealStatePtr L) 
        {
		    System.Type type = typeof(TSLuaFramework.UI.TextPlus);
			Utils.BeginObjectRegister(type, L, this, 0, 0, 4, 0);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "FontSpacingHandler", TSLuaFrameworkUITextPlus_g_get_FontSpacingHandler);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "VertexColorHandler", TSLuaFrameworkUITextPlus_g_get_VertexColorHandler);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "TextShadowHandler", TSLuaFrameworkUITextPlus_g_get_TextShadowHandler);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "TextOutlineHandler", TSLuaFrameworkUITextPlus_g_get_TextOutlineHandler);
            
			
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceTSLuaFrameworkUITextPlus, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceTSLuaFrameworkUITextPlus(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			if(gen_param_count == 1)
			{
				
				TSLuaFramework.UI.TextPlus gen_ret = new TSLuaFramework.UI.TextPlus();
				translator.Push(L, gen_ret);
				
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to TSLuaFramework.UI.TextPlus constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        int TSLuaFrameworkUITextPlus_g_get_FontSpacingHandler(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			TSLuaFramework.UI.TextPlus gen_to_be_invoked = (TSLuaFramework.UI.TextPlus)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.FontSpacingHandler);
            return 1;
        }
        
        int TSLuaFrameworkUITextPlus_g_get_VertexColorHandler(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			TSLuaFramework.UI.TextPlus gen_to_be_invoked = (TSLuaFramework.UI.TextPlus)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.VertexColorHandler);
            return 1;
        }
        
        int TSLuaFrameworkUITextPlus_g_get_TextShadowHandler(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			TSLuaFramework.UI.TextPlus gen_to_be_invoked = (TSLuaFramework.UI.TextPlus)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.TextShadowHandler);
            return 1;
        }
        
        int TSLuaFrameworkUITextPlus_g_get_TextOutlineHandler(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			TSLuaFramework.UI.TextPlus gen_to_be_invoked = (TSLuaFramework.UI.TextPlus)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.TextOutlineHandler);
            return 1;
        }
        
        
        
		
		
		
		
    }
}
