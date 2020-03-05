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
        public void __RegisterUnityEngineUIToggle(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.UI.Toggle);
			Utils.BeginObjectRegister(type, L, this, 0, 6, 5, 5);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Rebuild", UnityEngineUIToggle_m_Rebuild);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LayoutComplete", UnityEngineUIToggle_m_LayoutComplete);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GraphicUpdateComplete", UnityEngineUIToggle_m_GraphicUpdateComplete);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetIsOnWithoutNotify", UnityEngineUIToggle_m_SetIsOnWithoutNotify);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnPointerClick", UnityEngineUIToggle_m_OnPointerClick);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnSubmit", UnityEngineUIToggle_m_OnSubmit);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "group", UnityEngineUIToggle_g_get_group);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isOn", UnityEngineUIToggle_g_get_isOn);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "toggleTransition", UnityEngineUIToggle_g_get_toggleTransition);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "graphic", UnityEngineUIToggle_g_get_graphic);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onValueChanged", UnityEngineUIToggle_g_get_onValueChanged);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "group", UnityEngineUIToggle_s_set_group);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "isOn", UnityEngineUIToggle_s_set_isOn);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "toggleTransition", UnityEngineUIToggle_s_set_toggleTransition);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "graphic", UnityEngineUIToggle_s_set_graphic);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onValueChanged", UnityEngineUIToggle_s_set_onValueChanged);
            
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineUIToggle, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineUIToggle(RealStatePtr L, int gen_param_count) 
        {
            return LuaAPI.luaL_error(L, "UnityEngine.UI.Toggle does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        int UnityEngineUIToggle_m_Rebuild(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.Toggle gen_to_be_invoked = (UnityEngine.UI.Toggle)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.UI.CanvasUpdate _executing;translator.Get(L, 2, out _executing);
				
				gen_to_be_invoked.Rebuild( _executing );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIToggle_m_LayoutComplete(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.Toggle gen_to_be_invoked = (UnityEngine.UI.Toggle)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.LayoutComplete(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIToggle_m_GraphicUpdateComplete(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.Toggle gen_to_be_invoked = (UnityEngine.UI.Toggle)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.GraphicUpdateComplete(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIToggle_m_SetIsOnWithoutNotify(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.Toggle gen_to_be_invoked = (UnityEngine.UI.Toggle)translator.FastGetCSObj(L, 1);
            
			
			{
				bool _value = LuaAPI.lua_toboolean(L, 2);
				
				gen_to_be_invoked.SetIsOnWithoutNotify( _value );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIToggle_m_OnPointerClick(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.Toggle gen_to_be_invoked = (UnityEngine.UI.Toggle)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.EventSystems.PointerEventData _eventData = (UnityEngine.EventSystems.PointerEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
				
				gen_to_be_invoked.OnPointerClick( _eventData );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIToggle_m_OnSubmit(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.Toggle gen_to_be_invoked = (UnityEngine.UI.Toggle)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.EventSystems.BaseEventData _eventData = (UnityEngine.EventSystems.BaseEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.BaseEventData));
				
				gen_to_be_invoked.OnSubmit( _eventData );
				
				
				
				return 0;
			}
			
            
        }
        
        
        
        
        int UnityEngineUIToggle_g_get_group(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Toggle gen_to_be_invoked = (UnityEngine.UI.Toggle)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.group);
            return 1;
        }
        
        int UnityEngineUIToggle_g_get_isOn(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Toggle gen_to_be_invoked = (UnityEngine.UI.Toggle)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isOn);
            return 1;
        }
        
        int UnityEngineUIToggle_g_get_toggleTransition(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Toggle gen_to_be_invoked = (UnityEngine.UI.Toggle)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.toggleTransition);
            return 1;
        }
        
        int UnityEngineUIToggle_g_get_graphic(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Toggle gen_to_be_invoked = (UnityEngine.UI.Toggle)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.graphic);
            return 1;
        }
        
        int UnityEngineUIToggle_g_get_onValueChanged(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Toggle gen_to_be_invoked = (UnityEngine.UI.Toggle)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.onValueChanged);
            return 1;
        }
        
        
        
        int UnityEngineUIToggle_s_set_group(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.Toggle gen_to_be_invoked = (UnityEngine.UI.Toggle)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.group = (UnityEngine.UI.ToggleGroup)translator.GetObject(L, 2, typeof(UnityEngine.UI.ToggleGroup));
            
            return 0;
        }
        
        int UnityEngineUIToggle_s_set_isOn(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.Toggle gen_to_be_invoked = (UnityEngine.UI.Toggle)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.isOn = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineUIToggle_s_set_toggleTransition(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.Toggle gen_to_be_invoked = (UnityEngine.UI.Toggle)translator.FastGetCSObj(L, 1);
            UnityEngine.UI.Toggle.ToggleTransition gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.toggleTransition = gen_value;
            
            return 0;
        }
        
        int UnityEngineUIToggle_s_set_graphic(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.Toggle gen_to_be_invoked = (UnityEngine.UI.Toggle)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.graphic = (UnityEngine.UI.Graphic)translator.GetObject(L, 2, typeof(UnityEngine.UI.Graphic));
            
            return 0;
        }
        
        int UnityEngineUIToggle_s_set_onValueChanged(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.Toggle gen_to_be_invoked = (UnityEngine.UI.Toggle)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.onValueChanged = (UnityEngine.UI.Toggle.ToggleEvent)translator.GetObject(L, 2, typeof(UnityEngine.UI.Toggle.ToggleEvent));
            
            return 0;
        }
        
		
		
		
		
    }
}
