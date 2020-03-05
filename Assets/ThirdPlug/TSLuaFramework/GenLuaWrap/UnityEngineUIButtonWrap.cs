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
        public void __RegisterUnityEngineUIButton(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.UI.Button);
			Utils.BeginObjectRegister(type, L, this, 0, 2, 1, 1);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnPointerClick", UnityEngineUIButton_m_OnPointerClick);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnSubmit", UnityEngineUIButton_m_OnSubmit);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "onClick", UnityEngineUIButton_g_get_onClick);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "onClick", UnityEngineUIButton_s_set_onClick);
            
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineUIButton, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineUIButton(RealStatePtr L, int gen_param_count) 
        {
            return LuaAPI.luaL_error(L, "UnityEngine.UI.Button does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        int UnityEngineUIButton_m_OnPointerClick(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.Button gen_to_be_invoked = (UnityEngine.UI.Button)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.EventSystems.PointerEventData _eventData = (UnityEngine.EventSystems.PointerEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
				
				gen_to_be_invoked.OnPointerClick( _eventData );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIButton_m_OnSubmit(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.Button gen_to_be_invoked = (UnityEngine.UI.Button)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.EventSystems.BaseEventData _eventData = (UnityEngine.EventSystems.BaseEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.BaseEventData));
				
				gen_to_be_invoked.OnSubmit( _eventData );
				
				
				
				return 0;
			}
			
            
        }
        
        
        
        
        int UnityEngineUIButton_g_get_onClick(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Button gen_to_be_invoked = (UnityEngine.UI.Button)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.onClick);
            return 1;
        }
        
        
        
        int UnityEngineUIButton_s_set_onClick(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.Button gen_to_be_invoked = (UnityEngine.UI.Button)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.onClick = (UnityEngine.UI.Button.ButtonClickedEvent)translator.GetObject(L, 2, typeof(UnityEngine.UI.Button.ButtonClickedEvent));
            
            return 0;
        }
        
		
		
		
		
    }
}
