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
        public void __RegisterUnityEngineEventSystemsPointerEventData(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.EventSystems.PointerEventData);
			Utils.BeginObjectRegister(type, L, this, 0, 3, 21, 18);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsPointerMoving", UnityEngineEventSystemsPointerEventData_m_IsPointerMoving);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsScrolling", UnityEngineEventSystemsPointerEventData_m_IsScrolling);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToString", UnityEngineEventSystemsPointerEventData_m_ToString);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "pointerEnter", UnityEngineEventSystemsPointerEventData_g_get_pointerEnter);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lastPress", UnityEngineEventSystemsPointerEventData_g_get_lastPress);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rawPointerPress", UnityEngineEventSystemsPointerEventData_g_get_rawPointerPress);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pointerDrag", UnityEngineEventSystemsPointerEventData_g_get_pointerDrag);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pointerCurrentRaycast", UnityEngineEventSystemsPointerEventData_g_get_pointerCurrentRaycast);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pointerPressRaycast", UnityEngineEventSystemsPointerEventData_g_get_pointerPressRaycast);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "eligibleForClick", UnityEngineEventSystemsPointerEventData_g_get_eligibleForClick);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pointerId", UnityEngineEventSystemsPointerEventData_g_get_pointerId);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "position", UnityEngineEventSystemsPointerEventData_g_get_position);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "delta", UnityEngineEventSystemsPointerEventData_g_get_delta);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pressPosition", UnityEngineEventSystemsPointerEventData_g_get_pressPosition);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "clickTime", UnityEngineEventSystemsPointerEventData_g_get_clickTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "clickCount", UnityEngineEventSystemsPointerEventData_g_get_clickCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "scrollDelta", UnityEngineEventSystemsPointerEventData_g_get_scrollDelta);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "useDragThreshold", UnityEngineEventSystemsPointerEventData_g_get_useDragThreshold);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "dragging", UnityEngineEventSystemsPointerEventData_g_get_dragging);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "button", UnityEngineEventSystemsPointerEventData_g_get_button);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "enterEventCamera", UnityEngineEventSystemsPointerEventData_g_get_enterEventCamera);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pressEventCamera", UnityEngineEventSystemsPointerEventData_g_get_pressEventCamera);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pointerPress", UnityEngineEventSystemsPointerEventData_g_get_pointerPress);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hovered", UnityEngineEventSystemsPointerEventData_g_get_hovered);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "pointerEnter", UnityEngineEventSystemsPointerEventData_s_set_pointerEnter);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "rawPointerPress", UnityEngineEventSystemsPointerEventData_s_set_rawPointerPress);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pointerDrag", UnityEngineEventSystemsPointerEventData_s_set_pointerDrag);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pointerCurrentRaycast", UnityEngineEventSystemsPointerEventData_s_set_pointerCurrentRaycast);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pointerPressRaycast", UnityEngineEventSystemsPointerEventData_s_set_pointerPressRaycast);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "eligibleForClick", UnityEngineEventSystemsPointerEventData_s_set_eligibleForClick);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pointerId", UnityEngineEventSystemsPointerEventData_s_set_pointerId);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "position", UnityEngineEventSystemsPointerEventData_s_set_position);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "delta", UnityEngineEventSystemsPointerEventData_s_set_delta);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pressPosition", UnityEngineEventSystemsPointerEventData_s_set_pressPosition);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "clickTime", UnityEngineEventSystemsPointerEventData_s_set_clickTime);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "clickCount", UnityEngineEventSystemsPointerEventData_s_set_clickCount);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "scrollDelta", UnityEngineEventSystemsPointerEventData_s_set_scrollDelta);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "useDragThreshold", UnityEngineEventSystemsPointerEventData_s_set_useDragThreshold);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "dragging", UnityEngineEventSystemsPointerEventData_s_set_dragging);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "button", UnityEngineEventSystemsPointerEventData_s_set_button);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pointerPress", UnityEngineEventSystemsPointerEventData_s_set_pointerPress);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "hovered", UnityEngineEventSystemsPointerEventData_s_set_hovered);
            
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineEventSystemsPointerEventData, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineEventSystemsPointerEventData(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			if(gen_param_count == 2 && translator.Assignable<UnityEngine.EventSystems.EventSystem>(L, 2))
			{
				UnityEngine.EventSystems.EventSystem _eventSystem = (UnityEngine.EventSystems.EventSystem)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.EventSystem));
				
				UnityEngine.EventSystems.PointerEventData gen_ret = new UnityEngine.EventSystems.PointerEventData(_eventSystem);
				translator.Push(L, gen_ret);
				
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.EventSystems.PointerEventData constructor!");
            
        }
        
		
        
		
        
        
        
        
        int UnityEngineEventSystemsPointerEventData_m_IsPointerMoving(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
            
			
			{
				
				bool gen_ret = gen_to_be_invoked.IsPointerMoving(  );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineEventSystemsPointerEventData_m_IsScrolling(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
            
			
			{
				
				bool gen_ret = gen_to_be_invoked.IsScrolling(  );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineEventSystemsPointerEventData_m_ToString(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
            
			
			{
				
				string gen_ret = gen_to_be_invoked.ToString(  );
				LuaAPI.lua_pushstring(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        
        
        
        int UnityEngineEventSystemsPointerEventData_g_get_pointerEnter(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.pointerEnter);
            return 1;
        }
        
        int UnityEngineEventSystemsPointerEventData_g_get_lastPress(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.lastPress);
            return 1;
        }
        
        int UnityEngineEventSystemsPointerEventData_g_get_rawPointerPress(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.rawPointerPress);
            return 1;
        }
        
        int UnityEngineEventSystemsPointerEventData_g_get_pointerDrag(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.pointerDrag);
            return 1;
        }
        
        int UnityEngineEventSystemsPointerEventData_g_get_pointerCurrentRaycast(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.pointerCurrentRaycast);
            return 1;
        }
        
        int UnityEngineEventSystemsPointerEventData_g_get_pointerPressRaycast(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.pointerPressRaycast);
            return 1;
        }
        
        int UnityEngineEventSystemsPointerEventData_g_get_eligibleForClick(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.eligibleForClick);
            return 1;
        }
        
        int UnityEngineEventSystemsPointerEventData_g_get_pointerId(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.pointerId);
            return 1;
        }
        
        int UnityEngineEventSystemsPointerEventData_g_get_position(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
			translator.PushUnityEngineVector2(L, gen_to_be_invoked.position);
            return 1;
        }
        
        int UnityEngineEventSystemsPointerEventData_g_get_delta(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
			translator.PushUnityEngineVector2(L, gen_to_be_invoked.delta);
            return 1;
        }
        
        int UnityEngineEventSystemsPointerEventData_g_get_pressPosition(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
			translator.PushUnityEngineVector2(L, gen_to_be_invoked.pressPosition);
            return 1;
        }
        
        int UnityEngineEventSystemsPointerEventData_g_get_clickTime(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.clickTime);
            return 1;
        }
        
        int UnityEngineEventSystemsPointerEventData_g_get_clickCount(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.clickCount);
            return 1;
        }
        
        int UnityEngineEventSystemsPointerEventData_g_get_scrollDelta(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
			translator.PushUnityEngineVector2(L, gen_to_be_invoked.scrollDelta);
            return 1;
        }
        
        int UnityEngineEventSystemsPointerEventData_g_get_useDragThreshold(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.useDragThreshold);
            return 1;
        }
        
        int UnityEngineEventSystemsPointerEventData_g_get_dragging(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.dragging);
            return 1;
        }
        
        int UnityEngineEventSystemsPointerEventData_g_get_button(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.button);
            return 1;
        }
        
        int UnityEngineEventSystemsPointerEventData_g_get_enterEventCamera(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.enterEventCamera);
            return 1;
        }
        
        int UnityEngineEventSystemsPointerEventData_g_get_pressEventCamera(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.pressEventCamera);
            return 1;
        }
        
        int UnityEngineEventSystemsPointerEventData_g_get_pointerPress(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.pointerPress);
            return 1;
        }
        
        int UnityEngineEventSystemsPointerEventData_g_get_hovered(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.hovered);
            return 1;
        }
        
        
        
        int UnityEngineEventSystemsPointerEventData_s_set_pointerEnter(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.pointerEnter = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            return 0;
        }
        
        int UnityEngineEventSystemsPointerEventData_s_set_rawPointerPress(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.rawPointerPress = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            return 0;
        }
        
        int UnityEngineEventSystemsPointerEventData_s_set_pointerDrag(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.pointerDrag = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            return 0;
        }
        
        int UnityEngineEventSystemsPointerEventData_s_set_pointerCurrentRaycast(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
            UnityEngine.EventSystems.RaycastResult gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.pointerCurrentRaycast = gen_value;
            
            return 0;
        }
        
        int UnityEngineEventSystemsPointerEventData_s_set_pointerPressRaycast(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
            UnityEngine.EventSystems.RaycastResult gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.pointerPressRaycast = gen_value;
            
            return 0;
        }
        
        int UnityEngineEventSystemsPointerEventData_s_set_eligibleForClick(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.eligibleForClick = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineEventSystemsPointerEventData_s_set_pointerId(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.pointerId = LuaAPI.xlua_tointeger(L, 2);
            
            return 0;
        }
        
        int UnityEngineEventSystemsPointerEventData_s_set_position(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
            UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.position = gen_value;
            
            return 0;
        }
        
        int UnityEngineEventSystemsPointerEventData_s_set_delta(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
            UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.delta = gen_value;
            
            return 0;
        }
        
        int UnityEngineEventSystemsPointerEventData_s_set_pressPosition(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
            UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.pressPosition = gen_value;
            
            return 0;
        }
        
        int UnityEngineEventSystemsPointerEventData_s_set_clickTime(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.clickTime = (float)LuaAPI.lua_tonumber(L, 2);
            
            return 0;
        }
        
        int UnityEngineEventSystemsPointerEventData_s_set_clickCount(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.clickCount = LuaAPI.xlua_tointeger(L, 2);
            
            return 0;
        }
        
        int UnityEngineEventSystemsPointerEventData_s_set_scrollDelta(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
            UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.scrollDelta = gen_value;
            
            return 0;
        }
        
        int UnityEngineEventSystemsPointerEventData_s_set_useDragThreshold(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.useDragThreshold = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineEventSystemsPointerEventData_s_set_dragging(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.dragging = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineEventSystemsPointerEventData_s_set_button(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
            UnityEngine.EventSystems.PointerEventData.InputButton gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.button = gen_value;
            
            return 0;
        }
        
        int UnityEngineEventSystemsPointerEventData_s_set_pointerPress(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.pointerPress = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            return 0;
        }
        
        int UnityEngineEventSystemsPointerEventData_s_set_hovered(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.hovered = (System.Collections.Generic.List<UnityEngine.GameObject>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.GameObject>));
            
            return 0;
        }
        
		
		
		
		
    }
}
