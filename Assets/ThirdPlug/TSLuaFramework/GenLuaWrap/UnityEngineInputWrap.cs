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
        public void __RegisterUnityEngineInput(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.Input);
			Utils.BeginObjectRegister(type, L, this, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineInput, 16, 26, 6);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAxis", UnityEngineInput_m_GetAxis_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAxisRaw", UnityEngineInput_m_GetAxisRaw_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetButton", UnityEngineInput_m_GetButton_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetButtonDown", UnityEngineInput_m_GetButtonDown_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetButtonUp", UnityEngineInput_m_GetButtonUp_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetMouseButton", UnityEngineInput_m_GetMouseButton_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetMouseButtonDown", UnityEngineInput_m_GetMouseButtonDown_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetMouseButtonUp", UnityEngineInput_m_GetMouseButtonUp_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ResetInputAxes", UnityEngineInput_m_ResetInputAxes_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetJoystickNames", UnityEngineInput_m_GetJoystickNames_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetTouch", UnityEngineInput_m_GetTouch_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAccelerationEvent", UnityEngineInput_m_GetAccelerationEvent_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetKey", UnityEngineInput_m_GetKey_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetKeyUp", UnityEngineInput_m_GetKeyUp_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetKeyDown", UnityEngineInput_m_GetKeyDown_xlua_st_);
            
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "simulateMouseWithTouches", UnityEngineInput_g_get_simulateMouseWithTouches);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "anyKey", UnityEngineInput_g_get_anyKey);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "anyKeyDown", UnityEngineInput_g_get_anyKeyDown);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "inputString", UnityEngineInput_g_get_inputString);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "mousePosition", UnityEngineInput_g_get_mousePosition);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "mouseScrollDelta", UnityEngineInput_g_get_mouseScrollDelta);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "imeCompositionMode", UnityEngineInput_g_get_imeCompositionMode);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "compositionString", UnityEngineInput_g_get_compositionString);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "imeIsSelected", UnityEngineInput_g_get_imeIsSelected);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "compositionCursorPos", UnityEngineInput_g_get_compositionCursorPos);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "mousePresent", UnityEngineInput_g_get_mousePresent);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "touchCount", UnityEngineInput_g_get_touchCount);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "touchPressureSupported", UnityEngineInput_g_get_touchPressureSupported);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "stylusTouchSupported", UnityEngineInput_g_get_stylusTouchSupported);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "touchSupported", UnityEngineInput_g_get_touchSupported);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "multiTouchEnabled", UnityEngineInput_g_get_multiTouchEnabled);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "deviceOrientation", UnityEngineInput_g_get_deviceOrientation);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "acceleration", UnityEngineInput_g_get_acceleration);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "compensateSensors", UnityEngineInput_g_get_compensateSensors);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "accelerationEventCount", UnityEngineInput_g_get_accelerationEventCount);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "backButtonLeavesApp", UnityEngineInput_g_get_backButtonLeavesApp);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "location", UnityEngineInput_g_get_location);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "compass", UnityEngineInput_g_get_compass);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "gyro", UnityEngineInput_g_get_gyro);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "touches", UnityEngineInput_g_get_touches);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "accelerationEvents", UnityEngineInput_g_get_accelerationEvents);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "simulateMouseWithTouches", UnityEngineInput_s_set_simulateMouseWithTouches);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "imeCompositionMode", UnityEngineInput_s_set_imeCompositionMode);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "compositionCursorPos", UnityEngineInput_s_set_compositionCursorPos);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "multiTouchEnabled", UnityEngineInput_s_set_multiTouchEnabled);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "compensateSensors", UnityEngineInput_s_set_compensateSensors);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "backButtonLeavesApp", UnityEngineInput_s_set_backButtonLeavesApp);
            
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineInput(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			if(gen_param_count == 1)
			{
				
				UnityEngine.Input gen_ret = new UnityEngine.Input();
				translator.Push(L, gen_ret);
				
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Input constructor!");
            
        }
        
		
        
		
        
        
        
        
        int UnityEngineInput_m_GetAxis_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				string _axisName = LuaAPI.lua_tostring(L, 1);
				
				float gen_ret = UnityEngine.Input.GetAxis( _axisName );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineInput_m_GetAxisRaw_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				string _axisName = LuaAPI.lua_tostring(L, 1);
				
				float gen_ret = UnityEngine.Input.GetAxisRaw( _axisName );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineInput_m_GetButton_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				string _buttonName = LuaAPI.lua_tostring(L, 1);
				
				bool gen_ret = UnityEngine.Input.GetButton( _buttonName );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineInput_m_GetButtonDown_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				string _buttonName = LuaAPI.lua_tostring(L, 1);
				
				bool gen_ret = UnityEngine.Input.GetButtonDown( _buttonName );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineInput_m_GetButtonUp_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				string _buttonName = LuaAPI.lua_tostring(L, 1);
				
				bool gen_ret = UnityEngine.Input.GetButtonUp( _buttonName );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineInput_m_GetMouseButton_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				int _button = LuaAPI.xlua_tointeger(L, 1);
				
				bool gen_ret = UnityEngine.Input.GetMouseButton( _button );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineInput_m_GetMouseButtonDown_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				int _button = LuaAPI.xlua_tointeger(L, 1);
				
				bool gen_ret = UnityEngine.Input.GetMouseButtonDown( _button );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineInput_m_GetMouseButtonUp_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				int _button = LuaAPI.xlua_tointeger(L, 1);
				
				bool gen_ret = UnityEngine.Input.GetMouseButtonUp( _button );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineInput_m_ResetInputAxes_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				
				UnityEngine.Input.ResetInputAxes(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineInput_m_GetJoystickNames_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				
				string[] gen_ret = UnityEngine.Input.GetJoystickNames(  );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineInput_m_GetTouch_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				int _index = LuaAPI.xlua_tointeger(L, 1);
				
				UnityEngine.Touch gen_ret = UnityEngine.Input.GetTouch( _index );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineInput_m_GetAccelerationEvent_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				int _index = LuaAPI.xlua_tointeger(L, 1);
				
				UnityEngine.AccelerationEvent gen_ret = UnityEngine.Input.GetAccelerationEvent( _index );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineInput_m_GetKey_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			if(gen_param_count == 1&& translator.Assignable<UnityEngine.KeyCode>(L, 1)) 
			{
				UnityEngine.KeyCode _key;translator.Get(L, 1, out _key);
				
				bool gen_ret = UnityEngine.Input.GetKey( _key );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
			{
				string _name = LuaAPI.lua_tostring(L, 1);
				
				bool gen_ret = UnityEngine.Input.GetKey( _name );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Input.GetKey!");
            
        }
        
        int UnityEngineInput_m_GetKeyUp_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			if(gen_param_count == 1&& translator.Assignable<UnityEngine.KeyCode>(L, 1)) 
			{
				UnityEngine.KeyCode _key;translator.Get(L, 1, out _key);
				
				bool gen_ret = UnityEngine.Input.GetKeyUp( _key );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
			{
				string _name = LuaAPI.lua_tostring(L, 1);
				
				bool gen_ret = UnityEngine.Input.GetKeyUp( _name );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Input.GetKeyUp!");
            
        }
        
        int UnityEngineInput_m_GetKeyDown_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			if(gen_param_count == 1&& translator.Assignable<UnityEngine.KeyCode>(L, 1)) 
			{
				UnityEngine.KeyCode _key;translator.Get(L, 1, out _key);
				
				bool gen_ret = UnityEngine.Input.GetKeyDown( _key );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
			{
				string _name = LuaAPI.lua_tostring(L, 1);
				
				bool gen_ret = UnityEngine.Input.GetKeyDown( _name );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Input.GetKeyDown!");
            
        }
        
        
        
        
        int UnityEngineInput_g_get_simulateMouseWithTouches(RealStatePtr L, int gen_param_count) 
        {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.Input.simulateMouseWithTouches);
            return 1;
        }
        
        int UnityEngineInput_g_get_anyKey(RealStatePtr L, int gen_param_count) 
        {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.Input.anyKey);
            return 1;
        }
        
        int UnityEngineInput_g_get_anyKeyDown(RealStatePtr L, int gen_param_count) 
        {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.Input.anyKeyDown);
            return 1;
        }
        
        int UnityEngineInput_g_get_inputString(RealStatePtr L, int gen_param_count) 
        {
            
			    LuaAPI.lua_pushstring(L, UnityEngine.Input.inputString);
            return 1;
        }
        
        int UnityEngineInput_g_get_mousePosition(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.PushUnityEngineVector3(L, UnityEngine.Input.mousePosition);
            return 1;
        }
        
        int UnityEngineInput_g_get_mouseScrollDelta(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.PushUnityEngineVector2(L, UnityEngine.Input.mouseScrollDelta);
            return 1;
        }
        
        int UnityEngineInput_g_get_imeCompositionMode(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.Push(L, UnityEngine.Input.imeCompositionMode);
            return 1;
        }
        
        int UnityEngineInput_g_get_compositionString(RealStatePtr L, int gen_param_count) 
        {
            
			    LuaAPI.lua_pushstring(L, UnityEngine.Input.compositionString);
            return 1;
        }
        
        int UnityEngineInput_g_get_imeIsSelected(RealStatePtr L, int gen_param_count) 
        {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.Input.imeIsSelected);
            return 1;
        }
        
        int UnityEngineInput_g_get_compositionCursorPos(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.PushUnityEngineVector2(L, UnityEngine.Input.compositionCursorPos);
            return 1;
        }
        
        int UnityEngineInput_g_get_mousePresent(RealStatePtr L, int gen_param_count) 
        {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.Input.mousePresent);
            return 1;
        }
        
        int UnityEngineInput_g_get_touchCount(RealStatePtr L, int gen_param_count) 
        {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.Input.touchCount);
            return 1;
        }
        
        int UnityEngineInput_g_get_touchPressureSupported(RealStatePtr L, int gen_param_count) 
        {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.Input.touchPressureSupported);
            return 1;
        }
        
        int UnityEngineInput_g_get_stylusTouchSupported(RealStatePtr L, int gen_param_count) 
        {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.Input.stylusTouchSupported);
            return 1;
        }
        
        int UnityEngineInput_g_get_touchSupported(RealStatePtr L, int gen_param_count) 
        {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.Input.touchSupported);
            return 1;
        }
        
        int UnityEngineInput_g_get_multiTouchEnabled(RealStatePtr L, int gen_param_count) 
        {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.Input.multiTouchEnabled);
            return 1;
        }
        
        int UnityEngineInput_g_get_deviceOrientation(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.Push(L, UnityEngine.Input.deviceOrientation);
            return 1;
        }
        
        int UnityEngineInput_g_get_acceleration(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.PushUnityEngineVector3(L, UnityEngine.Input.acceleration);
            return 1;
        }
        
        int UnityEngineInput_g_get_compensateSensors(RealStatePtr L, int gen_param_count) 
        {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.Input.compensateSensors);
            return 1;
        }
        
        int UnityEngineInput_g_get_accelerationEventCount(RealStatePtr L, int gen_param_count) 
        {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.Input.accelerationEventCount);
            return 1;
        }
        
        int UnityEngineInput_g_get_backButtonLeavesApp(RealStatePtr L, int gen_param_count) 
        {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.Input.backButtonLeavesApp);
            return 1;
        }
        
        int UnityEngineInput_g_get_location(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.Push(L, UnityEngine.Input.location);
            return 1;
        }
        
        int UnityEngineInput_g_get_compass(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.Push(L, UnityEngine.Input.compass);
            return 1;
        }
        
        int UnityEngineInput_g_get_gyro(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.Push(L, UnityEngine.Input.gyro);
            return 1;
        }
        
        int UnityEngineInput_g_get_touches(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.Push(L, UnityEngine.Input.touches);
            return 1;
        }
        
        int UnityEngineInput_g_get_accelerationEvents(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.Push(L, UnityEngine.Input.accelerationEvents);
            return 1;
        }
        
        
        
        int UnityEngineInput_s_set_simulateMouseWithTouches(RealStatePtr L, int gen_param_count) 
        {
            
			UnityEngine.Input.simulateMouseWithTouches = LuaAPI.lua_toboolean(L, 1);
            
            return 0;
        }
        
        int UnityEngineInput_s_set_imeCompositionMode(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			UnityEngine.IMECompositionMode gen_value;translator.Get(L, 1, out gen_value);
			UnityEngine.Input.imeCompositionMode = gen_value;
            
            return 0;
        }
        
        int UnityEngineInput_s_set_compositionCursorPos(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			UnityEngine.Vector2 gen_value;translator.Get(L, 1, out gen_value);
			UnityEngine.Input.compositionCursorPos = gen_value;
            
            return 0;
        }
        
        int UnityEngineInput_s_set_multiTouchEnabled(RealStatePtr L, int gen_param_count) 
        {
            
			UnityEngine.Input.multiTouchEnabled = LuaAPI.lua_toboolean(L, 1);
            
            return 0;
        }
        
        int UnityEngineInput_s_set_compensateSensors(RealStatePtr L, int gen_param_count) 
        {
            
			UnityEngine.Input.compensateSensors = LuaAPI.lua_toboolean(L, 1);
            
            return 0;
        }
        
        int UnityEngineInput_s_set_backButtonLeavesApp(RealStatePtr L, int gen_param_count) 
        {
            
			UnityEngine.Input.backButtonLeavesApp = LuaAPI.lua_toboolean(L, 1);
            
            return 0;
        }
        
		
		
		
		
    }
}
