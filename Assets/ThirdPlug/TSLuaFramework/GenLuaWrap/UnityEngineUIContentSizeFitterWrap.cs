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
        public void __RegisterUnityEngineUIContentSizeFitter(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.UI.ContentSizeFitter);
			Utils.BeginObjectRegister(type, L, this, 0, 2, 2, 2);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetLayoutHorizontal", UnityEngineUIContentSizeFitter_m_SetLayoutHorizontal);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetLayoutVertical", UnityEngineUIContentSizeFitter_m_SetLayoutVertical);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "horizontalFit", UnityEngineUIContentSizeFitter_g_get_horizontalFit);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "verticalFit", UnityEngineUIContentSizeFitter_g_get_verticalFit);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "horizontalFit", UnityEngineUIContentSizeFitter_s_set_horizontalFit);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "verticalFit", UnityEngineUIContentSizeFitter_s_set_verticalFit);
            
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineUIContentSizeFitter, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineUIContentSizeFitter(RealStatePtr L, int gen_param_count) 
        {
            return LuaAPI.luaL_error(L, "UnityEngine.UI.ContentSizeFitter does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        int UnityEngineUIContentSizeFitter_m_SetLayoutHorizontal(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.ContentSizeFitter gen_to_be_invoked = (UnityEngine.UI.ContentSizeFitter)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.SetLayoutHorizontal(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIContentSizeFitter_m_SetLayoutVertical(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.ContentSizeFitter gen_to_be_invoked = (UnityEngine.UI.ContentSizeFitter)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.SetLayoutVertical(  );
				
				
				
				return 0;
			}
			
            
        }
        
        
        
        
        int UnityEngineUIContentSizeFitter_g_get_horizontalFit(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.ContentSizeFitter gen_to_be_invoked = (UnityEngine.UI.ContentSizeFitter)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.horizontalFit);
            return 1;
        }
        
        int UnityEngineUIContentSizeFitter_g_get_verticalFit(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.ContentSizeFitter gen_to_be_invoked = (UnityEngine.UI.ContentSizeFitter)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.verticalFit);
            return 1;
        }
        
        
        
        int UnityEngineUIContentSizeFitter_s_set_horizontalFit(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.ContentSizeFitter gen_to_be_invoked = (UnityEngine.UI.ContentSizeFitter)translator.FastGetCSObj(L, 1);
            UnityEngine.UI.ContentSizeFitter.FitMode gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.horizontalFit = gen_value;
            
            return 0;
        }
        
        int UnityEngineUIContentSizeFitter_s_set_verticalFit(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.ContentSizeFitter gen_to_be_invoked = (UnityEngine.UI.ContentSizeFitter)translator.FastGetCSObj(L, 1);
            UnityEngine.UI.ContentSizeFitter.FitMode gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.verticalFit = gen_value;
            
            return 0;
        }
        
		
		
		
		
    }
}
