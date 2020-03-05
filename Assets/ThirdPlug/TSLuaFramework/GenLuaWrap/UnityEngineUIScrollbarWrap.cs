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
        public void __RegisterUnityEngineUIScrollbar(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.UI.Scrollbar);
			Utils.BeginObjectRegister(type, L, this, 0, 15, 6, 6);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetValueWithoutNotify", UnityEngineUIScrollbar_m_SetValueWithoutNotify);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Rebuild", UnityEngineUIScrollbar_m_Rebuild);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LayoutComplete", UnityEngineUIScrollbar_m_LayoutComplete);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GraphicUpdateComplete", UnityEngineUIScrollbar_m_GraphicUpdateComplete);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnBeginDrag", UnityEngineUIScrollbar_m_OnBeginDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnDrag", UnityEngineUIScrollbar_m_OnDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnPointerDown", UnityEngineUIScrollbar_m_OnPointerDown);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnPointerUp", UnityEngineUIScrollbar_m_OnPointerUp);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnMove", UnityEngineUIScrollbar_m_OnMove);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FindSelectableOnLeft", UnityEngineUIScrollbar_m_FindSelectableOnLeft);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FindSelectableOnRight", UnityEngineUIScrollbar_m_FindSelectableOnRight);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FindSelectableOnUp", UnityEngineUIScrollbar_m_FindSelectableOnUp);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FindSelectableOnDown", UnityEngineUIScrollbar_m_FindSelectableOnDown);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnInitializePotentialDrag", UnityEngineUIScrollbar_m_OnInitializePotentialDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetDirection", UnityEngineUIScrollbar_m_SetDirection);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "handleRect", UnityEngineUIScrollbar_g_get_handleRect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "direction", UnityEngineUIScrollbar_g_get_direction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "value", UnityEngineUIScrollbar_g_get_value);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "size", UnityEngineUIScrollbar_g_get_size);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "numberOfSteps", UnityEngineUIScrollbar_g_get_numberOfSteps);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onValueChanged", UnityEngineUIScrollbar_g_get_onValueChanged);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "handleRect", UnityEngineUIScrollbar_s_set_handleRect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "direction", UnityEngineUIScrollbar_s_set_direction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "value", UnityEngineUIScrollbar_s_set_value);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "size", UnityEngineUIScrollbar_s_set_size);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "numberOfSteps", UnityEngineUIScrollbar_s_set_numberOfSteps);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onValueChanged", UnityEngineUIScrollbar_s_set_onValueChanged);
            
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineUIScrollbar, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineUIScrollbar(RealStatePtr L, int gen_param_count) 
        {
            return LuaAPI.luaL_error(L, "UnityEngine.UI.Scrollbar does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        int UnityEngineUIScrollbar_m_SetValueWithoutNotify(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.Scrollbar gen_to_be_invoked = (UnityEngine.UI.Scrollbar)translator.FastGetCSObj(L, 1);
            
			
			{
				float _input = (float)LuaAPI.lua_tonumber(L, 2);
				
				gen_to_be_invoked.SetValueWithoutNotify( _input );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIScrollbar_m_Rebuild(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.Scrollbar gen_to_be_invoked = (UnityEngine.UI.Scrollbar)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.UI.CanvasUpdate _executing;translator.Get(L, 2, out _executing);
				
				gen_to_be_invoked.Rebuild( _executing );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIScrollbar_m_LayoutComplete(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.Scrollbar gen_to_be_invoked = (UnityEngine.UI.Scrollbar)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.LayoutComplete(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIScrollbar_m_GraphicUpdateComplete(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.Scrollbar gen_to_be_invoked = (UnityEngine.UI.Scrollbar)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.GraphicUpdateComplete(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIScrollbar_m_OnBeginDrag(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.Scrollbar gen_to_be_invoked = (UnityEngine.UI.Scrollbar)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.EventSystems.PointerEventData _eventData = (UnityEngine.EventSystems.PointerEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
				
				gen_to_be_invoked.OnBeginDrag( _eventData );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIScrollbar_m_OnDrag(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.Scrollbar gen_to_be_invoked = (UnityEngine.UI.Scrollbar)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.EventSystems.PointerEventData _eventData = (UnityEngine.EventSystems.PointerEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
				
				gen_to_be_invoked.OnDrag( _eventData );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIScrollbar_m_OnPointerDown(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.Scrollbar gen_to_be_invoked = (UnityEngine.UI.Scrollbar)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.EventSystems.PointerEventData _eventData = (UnityEngine.EventSystems.PointerEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
				
				gen_to_be_invoked.OnPointerDown( _eventData );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIScrollbar_m_OnPointerUp(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.Scrollbar gen_to_be_invoked = (UnityEngine.UI.Scrollbar)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.EventSystems.PointerEventData _eventData = (UnityEngine.EventSystems.PointerEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
				
				gen_to_be_invoked.OnPointerUp( _eventData );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIScrollbar_m_OnMove(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.Scrollbar gen_to_be_invoked = (UnityEngine.UI.Scrollbar)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.EventSystems.AxisEventData _eventData = (UnityEngine.EventSystems.AxisEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.AxisEventData));
				
				gen_to_be_invoked.OnMove( _eventData );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIScrollbar_m_FindSelectableOnLeft(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.Scrollbar gen_to_be_invoked = (UnityEngine.UI.Scrollbar)translator.FastGetCSObj(L, 1);
            
			
			{
				
				UnityEngine.UI.Selectable gen_ret = gen_to_be_invoked.FindSelectableOnLeft(  );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineUIScrollbar_m_FindSelectableOnRight(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.Scrollbar gen_to_be_invoked = (UnityEngine.UI.Scrollbar)translator.FastGetCSObj(L, 1);
            
			
			{
				
				UnityEngine.UI.Selectable gen_ret = gen_to_be_invoked.FindSelectableOnRight(  );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineUIScrollbar_m_FindSelectableOnUp(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.Scrollbar gen_to_be_invoked = (UnityEngine.UI.Scrollbar)translator.FastGetCSObj(L, 1);
            
			
			{
				
				UnityEngine.UI.Selectable gen_ret = gen_to_be_invoked.FindSelectableOnUp(  );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineUIScrollbar_m_FindSelectableOnDown(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.Scrollbar gen_to_be_invoked = (UnityEngine.UI.Scrollbar)translator.FastGetCSObj(L, 1);
            
			
			{
				
				UnityEngine.UI.Selectable gen_ret = gen_to_be_invoked.FindSelectableOnDown(  );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineUIScrollbar_m_OnInitializePotentialDrag(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.Scrollbar gen_to_be_invoked = (UnityEngine.UI.Scrollbar)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.EventSystems.PointerEventData _eventData = (UnityEngine.EventSystems.PointerEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
				
				gen_to_be_invoked.OnInitializePotentialDrag( _eventData );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIScrollbar_m_SetDirection(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.Scrollbar gen_to_be_invoked = (UnityEngine.UI.Scrollbar)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.UI.Scrollbar.Direction _direction;translator.Get(L, 2, out _direction);
				bool _includeRectLayouts = LuaAPI.lua_toboolean(L, 3);
				
				gen_to_be_invoked.SetDirection( _direction, _includeRectLayouts );
				
				
				
				return 0;
			}
			
            
        }
        
        
        
        
        int UnityEngineUIScrollbar_g_get_handleRect(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Scrollbar gen_to_be_invoked = (UnityEngine.UI.Scrollbar)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.handleRect);
            return 1;
        }
        
        int UnityEngineUIScrollbar_g_get_direction(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Scrollbar gen_to_be_invoked = (UnityEngine.UI.Scrollbar)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.direction);
            return 1;
        }
        
        int UnityEngineUIScrollbar_g_get_value(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Scrollbar gen_to_be_invoked = (UnityEngine.UI.Scrollbar)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.value);
            return 1;
        }
        
        int UnityEngineUIScrollbar_g_get_size(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Scrollbar gen_to_be_invoked = (UnityEngine.UI.Scrollbar)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.size);
            return 1;
        }
        
        int UnityEngineUIScrollbar_g_get_numberOfSteps(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Scrollbar gen_to_be_invoked = (UnityEngine.UI.Scrollbar)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.numberOfSteps);
            return 1;
        }
        
        int UnityEngineUIScrollbar_g_get_onValueChanged(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Scrollbar gen_to_be_invoked = (UnityEngine.UI.Scrollbar)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.onValueChanged);
            return 1;
        }
        
        
        
        int UnityEngineUIScrollbar_s_set_handleRect(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.Scrollbar gen_to_be_invoked = (UnityEngine.UI.Scrollbar)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.handleRect = (UnityEngine.RectTransform)translator.GetObject(L, 2, typeof(UnityEngine.RectTransform));
            
            return 0;
        }
        
        int UnityEngineUIScrollbar_s_set_direction(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.Scrollbar gen_to_be_invoked = (UnityEngine.UI.Scrollbar)translator.FastGetCSObj(L, 1);
            UnityEngine.UI.Scrollbar.Direction gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.direction = gen_value;
            
            return 0;
        }
        
        int UnityEngineUIScrollbar_s_set_value(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.Scrollbar gen_to_be_invoked = (UnityEngine.UI.Scrollbar)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.value = (float)LuaAPI.lua_tonumber(L, 2);
            
            return 0;
        }
        
        int UnityEngineUIScrollbar_s_set_size(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.Scrollbar gen_to_be_invoked = (UnityEngine.UI.Scrollbar)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.size = (float)LuaAPI.lua_tonumber(L, 2);
            
            return 0;
        }
        
        int UnityEngineUIScrollbar_s_set_numberOfSteps(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.Scrollbar gen_to_be_invoked = (UnityEngine.UI.Scrollbar)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.numberOfSteps = LuaAPI.xlua_tointeger(L, 2);
            
            return 0;
        }
        
        int UnityEngineUIScrollbar_s_set_onValueChanged(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.Scrollbar gen_to_be_invoked = (UnityEngine.UI.Scrollbar)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.onValueChanged = (UnityEngine.UI.Scrollbar.ScrollEvent)translator.GetObject(L, 2, typeof(UnityEngine.UI.Scrollbar.ScrollEvent));
            
            return 0;
        }
        
		
		
		
		
    }
}
