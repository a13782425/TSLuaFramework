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
        public void __RegisterUnityEngineUISlider(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.UI.Slider);
			Utils.BeginObjectRegister(type, L, this, 0, 13, 9, 9);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetValueWithoutNotify", UnityEngineUISlider_m_SetValueWithoutNotify);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Rebuild", UnityEngineUISlider_m_Rebuild);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LayoutComplete", UnityEngineUISlider_m_LayoutComplete);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GraphicUpdateComplete", UnityEngineUISlider_m_GraphicUpdateComplete);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnPointerDown", UnityEngineUISlider_m_OnPointerDown);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnDrag", UnityEngineUISlider_m_OnDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnMove", UnityEngineUISlider_m_OnMove);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FindSelectableOnLeft", UnityEngineUISlider_m_FindSelectableOnLeft);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FindSelectableOnRight", UnityEngineUISlider_m_FindSelectableOnRight);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FindSelectableOnUp", UnityEngineUISlider_m_FindSelectableOnUp);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FindSelectableOnDown", UnityEngineUISlider_m_FindSelectableOnDown);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnInitializePotentialDrag", UnityEngineUISlider_m_OnInitializePotentialDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetDirection", UnityEngineUISlider_m_SetDirection);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "fillRect", UnityEngineUISlider_g_get_fillRect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "handleRect", UnityEngineUISlider_g_get_handleRect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "direction", UnityEngineUISlider_g_get_direction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "minValue", UnityEngineUISlider_g_get_minValue);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "maxValue", UnityEngineUISlider_g_get_maxValue);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "wholeNumbers", UnityEngineUISlider_g_get_wholeNumbers);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "value", UnityEngineUISlider_g_get_value);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "normalizedValue", UnityEngineUISlider_g_get_normalizedValue);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onValueChanged", UnityEngineUISlider_g_get_onValueChanged);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "fillRect", UnityEngineUISlider_s_set_fillRect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "handleRect", UnityEngineUISlider_s_set_handleRect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "direction", UnityEngineUISlider_s_set_direction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "minValue", UnityEngineUISlider_s_set_minValue);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "maxValue", UnityEngineUISlider_s_set_maxValue);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "wholeNumbers", UnityEngineUISlider_s_set_wholeNumbers);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "value", UnityEngineUISlider_s_set_value);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "normalizedValue", UnityEngineUISlider_s_set_normalizedValue);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onValueChanged", UnityEngineUISlider_s_set_onValueChanged);
            
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineUISlider, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineUISlider(RealStatePtr L, int gen_param_count) 
        {
            return LuaAPI.luaL_error(L, "UnityEngine.UI.Slider does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        int UnityEngineUISlider_m_SetValueWithoutNotify(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.Slider gen_to_be_invoked = (UnityEngine.UI.Slider)translator.FastGetCSObj(L, 1);
            
			
			{
				float _input = (float)LuaAPI.lua_tonumber(L, 2);
				
				gen_to_be_invoked.SetValueWithoutNotify( _input );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUISlider_m_Rebuild(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.Slider gen_to_be_invoked = (UnityEngine.UI.Slider)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.UI.CanvasUpdate _executing;translator.Get(L, 2, out _executing);
				
				gen_to_be_invoked.Rebuild( _executing );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUISlider_m_LayoutComplete(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.Slider gen_to_be_invoked = (UnityEngine.UI.Slider)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.LayoutComplete(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUISlider_m_GraphicUpdateComplete(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.Slider gen_to_be_invoked = (UnityEngine.UI.Slider)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.GraphicUpdateComplete(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUISlider_m_OnPointerDown(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.Slider gen_to_be_invoked = (UnityEngine.UI.Slider)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.EventSystems.PointerEventData _eventData = (UnityEngine.EventSystems.PointerEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
				
				gen_to_be_invoked.OnPointerDown( _eventData );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUISlider_m_OnDrag(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.Slider gen_to_be_invoked = (UnityEngine.UI.Slider)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.EventSystems.PointerEventData _eventData = (UnityEngine.EventSystems.PointerEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
				
				gen_to_be_invoked.OnDrag( _eventData );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUISlider_m_OnMove(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.Slider gen_to_be_invoked = (UnityEngine.UI.Slider)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.EventSystems.AxisEventData _eventData = (UnityEngine.EventSystems.AxisEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.AxisEventData));
				
				gen_to_be_invoked.OnMove( _eventData );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUISlider_m_FindSelectableOnLeft(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.Slider gen_to_be_invoked = (UnityEngine.UI.Slider)translator.FastGetCSObj(L, 1);
            
			
			{
				
				UnityEngine.UI.Selectable gen_ret = gen_to_be_invoked.FindSelectableOnLeft(  );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineUISlider_m_FindSelectableOnRight(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.Slider gen_to_be_invoked = (UnityEngine.UI.Slider)translator.FastGetCSObj(L, 1);
            
			
			{
				
				UnityEngine.UI.Selectable gen_ret = gen_to_be_invoked.FindSelectableOnRight(  );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineUISlider_m_FindSelectableOnUp(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.Slider gen_to_be_invoked = (UnityEngine.UI.Slider)translator.FastGetCSObj(L, 1);
            
			
			{
				
				UnityEngine.UI.Selectable gen_ret = gen_to_be_invoked.FindSelectableOnUp(  );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineUISlider_m_FindSelectableOnDown(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.Slider gen_to_be_invoked = (UnityEngine.UI.Slider)translator.FastGetCSObj(L, 1);
            
			
			{
				
				UnityEngine.UI.Selectable gen_ret = gen_to_be_invoked.FindSelectableOnDown(  );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineUISlider_m_OnInitializePotentialDrag(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.Slider gen_to_be_invoked = (UnityEngine.UI.Slider)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.EventSystems.PointerEventData _eventData = (UnityEngine.EventSystems.PointerEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
				
				gen_to_be_invoked.OnInitializePotentialDrag( _eventData );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUISlider_m_SetDirection(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.Slider gen_to_be_invoked = (UnityEngine.UI.Slider)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.UI.Slider.Direction _direction;translator.Get(L, 2, out _direction);
				bool _includeRectLayouts = LuaAPI.lua_toboolean(L, 3);
				
				gen_to_be_invoked.SetDirection( _direction, _includeRectLayouts );
				
				
				
				return 0;
			}
			
            
        }
        
        
        
        
        int UnityEngineUISlider_g_get_fillRect(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Slider gen_to_be_invoked = (UnityEngine.UI.Slider)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.fillRect);
            return 1;
        }
        
        int UnityEngineUISlider_g_get_handleRect(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Slider gen_to_be_invoked = (UnityEngine.UI.Slider)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.handleRect);
            return 1;
        }
        
        int UnityEngineUISlider_g_get_direction(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Slider gen_to_be_invoked = (UnityEngine.UI.Slider)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.direction);
            return 1;
        }
        
        int UnityEngineUISlider_g_get_minValue(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Slider gen_to_be_invoked = (UnityEngine.UI.Slider)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.minValue);
            return 1;
        }
        
        int UnityEngineUISlider_g_get_maxValue(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Slider gen_to_be_invoked = (UnityEngine.UI.Slider)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.maxValue);
            return 1;
        }
        
        int UnityEngineUISlider_g_get_wholeNumbers(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Slider gen_to_be_invoked = (UnityEngine.UI.Slider)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.wholeNumbers);
            return 1;
        }
        
        int UnityEngineUISlider_g_get_value(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Slider gen_to_be_invoked = (UnityEngine.UI.Slider)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.value);
            return 1;
        }
        
        int UnityEngineUISlider_g_get_normalizedValue(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Slider gen_to_be_invoked = (UnityEngine.UI.Slider)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.normalizedValue);
            return 1;
        }
        
        int UnityEngineUISlider_g_get_onValueChanged(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Slider gen_to_be_invoked = (UnityEngine.UI.Slider)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.onValueChanged);
            return 1;
        }
        
        
        
        int UnityEngineUISlider_s_set_fillRect(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.Slider gen_to_be_invoked = (UnityEngine.UI.Slider)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.fillRect = (UnityEngine.RectTransform)translator.GetObject(L, 2, typeof(UnityEngine.RectTransform));
            
            return 0;
        }
        
        int UnityEngineUISlider_s_set_handleRect(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.Slider gen_to_be_invoked = (UnityEngine.UI.Slider)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.handleRect = (UnityEngine.RectTransform)translator.GetObject(L, 2, typeof(UnityEngine.RectTransform));
            
            return 0;
        }
        
        int UnityEngineUISlider_s_set_direction(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.Slider gen_to_be_invoked = (UnityEngine.UI.Slider)translator.FastGetCSObj(L, 1);
            UnityEngine.UI.Slider.Direction gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.direction = gen_value;
            
            return 0;
        }
        
        int UnityEngineUISlider_s_set_minValue(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.Slider gen_to_be_invoked = (UnityEngine.UI.Slider)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.minValue = (float)LuaAPI.lua_tonumber(L, 2);
            
            return 0;
        }
        
        int UnityEngineUISlider_s_set_maxValue(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.Slider gen_to_be_invoked = (UnityEngine.UI.Slider)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.maxValue = (float)LuaAPI.lua_tonumber(L, 2);
            
            return 0;
        }
        
        int UnityEngineUISlider_s_set_wholeNumbers(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.Slider gen_to_be_invoked = (UnityEngine.UI.Slider)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.wholeNumbers = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineUISlider_s_set_value(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.Slider gen_to_be_invoked = (UnityEngine.UI.Slider)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.value = (float)LuaAPI.lua_tonumber(L, 2);
            
            return 0;
        }
        
        int UnityEngineUISlider_s_set_normalizedValue(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.Slider gen_to_be_invoked = (UnityEngine.UI.Slider)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.normalizedValue = (float)LuaAPI.lua_tonumber(L, 2);
            
            return 0;
        }
        
        int UnityEngineUISlider_s_set_onValueChanged(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.Slider gen_to_be_invoked = (UnityEngine.UI.Slider)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.onValueChanged = (UnityEngine.UI.Slider.SliderEvent)translator.GetObject(L, 2, typeof(UnityEngine.UI.Slider.SliderEvent));
            
            return 0;
        }
        
		
		
		
		
    }
}
