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
        public void __RegisterUnityEngineUIScrollRect(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.UI.ScrollRect);
			Utils.BeginObjectRegister(type, L, this, 0, 14, 27, 20);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Rebuild", UnityEngineUIScrollRect_m_Rebuild);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LayoutComplete", UnityEngineUIScrollRect_m_LayoutComplete);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GraphicUpdateComplete", UnityEngineUIScrollRect_m_GraphicUpdateComplete);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsActive", UnityEngineUIScrollRect_m_IsActive);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "StopMovement", UnityEngineUIScrollRect_m_StopMovement);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnScroll", UnityEngineUIScrollRect_m_OnScroll);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnInitializePotentialDrag", UnityEngineUIScrollRect_m_OnInitializePotentialDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnBeginDrag", UnityEngineUIScrollRect_m_OnBeginDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnEndDrag", UnityEngineUIScrollRect_m_OnEndDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnDrag", UnityEngineUIScrollRect_m_OnDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CalculateLayoutInputHorizontal", UnityEngineUIScrollRect_m_CalculateLayoutInputHorizontal);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CalculateLayoutInputVertical", UnityEngineUIScrollRect_m_CalculateLayoutInputVertical);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetLayoutHorizontal", UnityEngineUIScrollRect_m_SetLayoutHorizontal);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetLayoutVertical", UnityEngineUIScrollRect_m_SetLayoutVertical);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "content", UnityEngineUIScrollRect_g_get_content);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "horizontal", UnityEngineUIScrollRect_g_get_horizontal);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "vertical", UnityEngineUIScrollRect_g_get_vertical);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "movementType", UnityEngineUIScrollRect_g_get_movementType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "elasticity", UnityEngineUIScrollRect_g_get_elasticity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "inertia", UnityEngineUIScrollRect_g_get_inertia);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "decelerationRate", UnityEngineUIScrollRect_g_get_decelerationRate);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "scrollSensitivity", UnityEngineUIScrollRect_g_get_scrollSensitivity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "viewport", UnityEngineUIScrollRect_g_get_viewport);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "horizontalScrollbar", UnityEngineUIScrollRect_g_get_horizontalScrollbar);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "verticalScrollbar", UnityEngineUIScrollRect_g_get_verticalScrollbar);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "horizontalScrollbarVisibility", UnityEngineUIScrollRect_g_get_horizontalScrollbarVisibility);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "verticalScrollbarVisibility", UnityEngineUIScrollRect_g_get_verticalScrollbarVisibility);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "horizontalScrollbarSpacing", UnityEngineUIScrollRect_g_get_horizontalScrollbarSpacing);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "verticalScrollbarSpacing", UnityEngineUIScrollRect_g_get_verticalScrollbarSpacing);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onValueChanged", UnityEngineUIScrollRect_g_get_onValueChanged);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "velocity", UnityEngineUIScrollRect_g_get_velocity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "normalizedPosition", UnityEngineUIScrollRect_g_get_normalizedPosition);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "horizontalNormalizedPosition", UnityEngineUIScrollRect_g_get_horizontalNormalizedPosition);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "verticalNormalizedPosition", UnityEngineUIScrollRect_g_get_verticalNormalizedPosition);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "minWidth", UnityEngineUIScrollRect_g_get_minWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "preferredWidth", UnityEngineUIScrollRect_g_get_preferredWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "flexibleWidth", UnityEngineUIScrollRect_g_get_flexibleWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "minHeight", UnityEngineUIScrollRect_g_get_minHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "preferredHeight", UnityEngineUIScrollRect_g_get_preferredHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "flexibleHeight", UnityEngineUIScrollRect_g_get_flexibleHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "layoutPriority", UnityEngineUIScrollRect_g_get_layoutPriority);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "content", UnityEngineUIScrollRect_s_set_content);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "horizontal", UnityEngineUIScrollRect_s_set_horizontal);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "vertical", UnityEngineUIScrollRect_s_set_vertical);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "movementType", UnityEngineUIScrollRect_s_set_movementType);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "elasticity", UnityEngineUIScrollRect_s_set_elasticity);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "inertia", UnityEngineUIScrollRect_s_set_inertia);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "decelerationRate", UnityEngineUIScrollRect_s_set_decelerationRate);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "scrollSensitivity", UnityEngineUIScrollRect_s_set_scrollSensitivity);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "viewport", UnityEngineUIScrollRect_s_set_viewport);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "horizontalScrollbar", UnityEngineUIScrollRect_s_set_horizontalScrollbar);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "verticalScrollbar", UnityEngineUIScrollRect_s_set_verticalScrollbar);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "horizontalScrollbarVisibility", UnityEngineUIScrollRect_s_set_horizontalScrollbarVisibility);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "verticalScrollbarVisibility", UnityEngineUIScrollRect_s_set_verticalScrollbarVisibility);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "horizontalScrollbarSpacing", UnityEngineUIScrollRect_s_set_horizontalScrollbarSpacing);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "verticalScrollbarSpacing", UnityEngineUIScrollRect_s_set_verticalScrollbarSpacing);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onValueChanged", UnityEngineUIScrollRect_s_set_onValueChanged);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "velocity", UnityEngineUIScrollRect_s_set_velocity);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "normalizedPosition", UnityEngineUIScrollRect_s_set_normalizedPosition);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "horizontalNormalizedPosition", UnityEngineUIScrollRect_s_set_horizontalNormalizedPosition);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "verticalNormalizedPosition", UnityEngineUIScrollRect_s_set_verticalNormalizedPosition);
            
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineUIScrollRect, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineUIScrollRect(RealStatePtr L, int gen_param_count) 
        {
            return LuaAPI.luaL_error(L, "UnityEngine.UI.ScrollRect does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        int UnityEngineUIScrollRect_m_Rebuild(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.UI.CanvasUpdate _executing;translator.Get(L, 2, out _executing);
				
				gen_to_be_invoked.Rebuild( _executing );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIScrollRect_m_LayoutComplete(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.LayoutComplete(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIScrollRect_m_GraphicUpdateComplete(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.GraphicUpdateComplete(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIScrollRect_m_IsActive(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
            
			
			{
				
				bool gen_ret = gen_to_be_invoked.IsActive(  );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineUIScrollRect_m_StopMovement(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.StopMovement(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIScrollRect_m_OnScroll(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.EventSystems.PointerEventData _data = (UnityEngine.EventSystems.PointerEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
				
				gen_to_be_invoked.OnScroll( _data );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIScrollRect_m_OnInitializePotentialDrag(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.EventSystems.PointerEventData _eventData = (UnityEngine.EventSystems.PointerEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
				
				gen_to_be_invoked.OnInitializePotentialDrag( _eventData );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIScrollRect_m_OnBeginDrag(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.EventSystems.PointerEventData _eventData = (UnityEngine.EventSystems.PointerEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
				
				gen_to_be_invoked.OnBeginDrag( _eventData );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIScrollRect_m_OnEndDrag(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.EventSystems.PointerEventData _eventData = (UnityEngine.EventSystems.PointerEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
				
				gen_to_be_invoked.OnEndDrag( _eventData );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIScrollRect_m_OnDrag(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.EventSystems.PointerEventData _eventData = (UnityEngine.EventSystems.PointerEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
				
				gen_to_be_invoked.OnDrag( _eventData );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIScrollRect_m_CalculateLayoutInputHorizontal(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.CalculateLayoutInputHorizontal(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIScrollRect_m_CalculateLayoutInputVertical(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.CalculateLayoutInputVertical(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIScrollRect_m_SetLayoutHorizontal(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.SetLayoutHorizontal(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIScrollRect_m_SetLayoutVertical(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.SetLayoutVertical(  );
				
				
				
				return 0;
			}
			
            
        }
        
        
        
        
        int UnityEngineUIScrollRect_g_get_content(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.content);
            return 1;
        }
        
        int UnityEngineUIScrollRect_g_get_horizontal(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.horizontal);
            return 1;
        }
        
        int UnityEngineUIScrollRect_g_get_vertical(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.vertical);
            return 1;
        }
        
        int UnityEngineUIScrollRect_g_get_movementType(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.movementType);
            return 1;
        }
        
        int UnityEngineUIScrollRect_g_get_elasticity(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.elasticity);
            return 1;
        }
        
        int UnityEngineUIScrollRect_g_get_inertia(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.inertia);
            return 1;
        }
        
        int UnityEngineUIScrollRect_g_get_decelerationRate(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.decelerationRate);
            return 1;
        }
        
        int UnityEngineUIScrollRect_g_get_scrollSensitivity(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.scrollSensitivity);
            return 1;
        }
        
        int UnityEngineUIScrollRect_g_get_viewport(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.viewport);
            return 1;
        }
        
        int UnityEngineUIScrollRect_g_get_horizontalScrollbar(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.horizontalScrollbar);
            return 1;
        }
        
        int UnityEngineUIScrollRect_g_get_verticalScrollbar(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.verticalScrollbar);
            return 1;
        }
        
        int UnityEngineUIScrollRect_g_get_horizontalScrollbarVisibility(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.horizontalScrollbarVisibility);
            return 1;
        }
        
        int UnityEngineUIScrollRect_g_get_verticalScrollbarVisibility(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.verticalScrollbarVisibility);
            return 1;
        }
        
        int UnityEngineUIScrollRect_g_get_horizontalScrollbarSpacing(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.horizontalScrollbarSpacing);
            return 1;
        }
        
        int UnityEngineUIScrollRect_g_get_verticalScrollbarSpacing(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.verticalScrollbarSpacing);
            return 1;
        }
        
        int UnityEngineUIScrollRect_g_get_onValueChanged(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.onValueChanged);
            return 1;
        }
        
        int UnityEngineUIScrollRect_g_get_velocity(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
			translator.PushUnityEngineVector2(L, gen_to_be_invoked.velocity);
            return 1;
        }
        
        int UnityEngineUIScrollRect_g_get_normalizedPosition(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
			translator.PushUnityEngineVector2(L, gen_to_be_invoked.normalizedPosition);
            return 1;
        }
        
        int UnityEngineUIScrollRect_g_get_horizontalNormalizedPosition(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.horizontalNormalizedPosition);
            return 1;
        }
        
        int UnityEngineUIScrollRect_g_get_verticalNormalizedPosition(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.verticalNormalizedPosition);
            return 1;
        }
        
        int UnityEngineUIScrollRect_g_get_minWidth(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.minWidth);
            return 1;
        }
        
        int UnityEngineUIScrollRect_g_get_preferredWidth(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.preferredWidth);
            return 1;
        }
        
        int UnityEngineUIScrollRect_g_get_flexibleWidth(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.flexibleWidth);
            return 1;
        }
        
        int UnityEngineUIScrollRect_g_get_minHeight(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.minHeight);
            return 1;
        }
        
        int UnityEngineUIScrollRect_g_get_preferredHeight(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.preferredHeight);
            return 1;
        }
        
        int UnityEngineUIScrollRect_g_get_flexibleHeight(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.flexibleHeight);
            return 1;
        }
        
        int UnityEngineUIScrollRect_g_get_layoutPriority(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.layoutPriority);
            return 1;
        }
        
        
        
        int UnityEngineUIScrollRect_s_set_content(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.content = (UnityEngine.RectTransform)translator.GetObject(L, 2, typeof(UnityEngine.RectTransform));
            
            return 0;
        }
        
        int UnityEngineUIScrollRect_s_set_horizontal(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.horizontal = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineUIScrollRect_s_set_vertical(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.vertical = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineUIScrollRect_s_set_movementType(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
            UnityEngine.UI.ScrollRect.MovementType gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.movementType = gen_value;
            
            return 0;
        }
        
        int UnityEngineUIScrollRect_s_set_elasticity(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.elasticity = (float)LuaAPI.lua_tonumber(L, 2);
            
            return 0;
        }
        
        int UnityEngineUIScrollRect_s_set_inertia(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.inertia = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineUIScrollRect_s_set_decelerationRate(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.decelerationRate = (float)LuaAPI.lua_tonumber(L, 2);
            
            return 0;
        }
        
        int UnityEngineUIScrollRect_s_set_scrollSensitivity(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.scrollSensitivity = (float)LuaAPI.lua_tonumber(L, 2);
            
            return 0;
        }
        
        int UnityEngineUIScrollRect_s_set_viewport(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.viewport = (UnityEngine.RectTransform)translator.GetObject(L, 2, typeof(UnityEngine.RectTransform));
            
            return 0;
        }
        
        int UnityEngineUIScrollRect_s_set_horizontalScrollbar(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.horizontalScrollbar = (UnityEngine.UI.Scrollbar)translator.GetObject(L, 2, typeof(UnityEngine.UI.Scrollbar));
            
            return 0;
        }
        
        int UnityEngineUIScrollRect_s_set_verticalScrollbar(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.verticalScrollbar = (UnityEngine.UI.Scrollbar)translator.GetObject(L, 2, typeof(UnityEngine.UI.Scrollbar));
            
            return 0;
        }
        
        int UnityEngineUIScrollRect_s_set_horizontalScrollbarVisibility(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
            UnityEngine.UI.ScrollRect.ScrollbarVisibility gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.horizontalScrollbarVisibility = gen_value;
            
            return 0;
        }
        
        int UnityEngineUIScrollRect_s_set_verticalScrollbarVisibility(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
            UnityEngine.UI.ScrollRect.ScrollbarVisibility gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.verticalScrollbarVisibility = gen_value;
            
            return 0;
        }
        
        int UnityEngineUIScrollRect_s_set_horizontalScrollbarSpacing(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.horizontalScrollbarSpacing = (float)LuaAPI.lua_tonumber(L, 2);
            
            return 0;
        }
        
        int UnityEngineUIScrollRect_s_set_verticalScrollbarSpacing(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.verticalScrollbarSpacing = (float)LuaAPI.lua_tonumber(L, 2);
            
            return 0;
        }
        
        int UnityEngineUIScrollRect_s_set_onValueChanged(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.onValueChanged = (UnityEngine.UI.ScrollRect.ScrollRectEvent)translator.GetObject(L, 2, typeof(UnityEngine.UI.ScrollRect.ScrollRectEvent));
            
            return 0;
        }
        
        int UnityEngineUIScrollRect_s_set_velocity(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
            UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.velocity = gen_value;
            
            return 0;
        }
        
        int UnityEngineUIScrollRect_s_set_normalizedPosition(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
            UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.normalizedPosition = gen_value;
            
            return 0;
        }
        
        int UnityEngineUIScrollRect_s_set_horizontalNormalizedPosition(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.horizontalNormalizedPosition = (float)LuaAPI.lua_tonumber(L, 2);
            
            return 0;
        }
        
        int UnityEngineUIScrollRect_s_set_verticalNormalizedPosition(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.ScrollRect gen_to_be_invoked = (UnityEngine.UI.ScrollRect)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.verticalNormalizedPosition = (float)LuaAPI.lua_tonumber(L, 2);
            
            return 0;
        }
        
		
		
		
		
    }
}
