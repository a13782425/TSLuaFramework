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
        public void __RegisterUnityEngineUICanvasScaler(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.UI.CanvasScaler);
			Utils.BeginObjectRegister(type, L, this, 0, 0, 10, 10);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "uiScaleMode", UnityEngineUICanvasScaler_g_get_uiScaleMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "referencePixelsPerUnit", UnityEngineUICanvasScaler_g_get_referencePixelsPerUnit);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "scaleFactor", UnityEngineUICanvasScaler_g_get_scaleFactor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "referenceResolution", UnityEngineUICanvasScaler_g_get_referenceResolution);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "screenMatchMode", UnityEngineUICanvasScaler_g_get_screenMatchMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "matchWidthOrHeight", UnityEngineUICanvasScaler_g_get_matchWidthOrHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "physicalUnit", UnityEngineUICanvasScaler_g_get_physicalUnit);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "fallbackScreenDPI", UnityEngineUICanvasScaler_g_get_fallbackScreenDPI);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "defaultSpriteDPI", UnityEngineUICanvasScaler_g_get_defaultSpriteDPI);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "dynamicPixelsPerUnit", UnityEngineUICanvasScaler_g_get_dynamicPixelsPerUnit);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "uiScaleMode", UnityEngineUICanvasScaler_s_set_uiScaleMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "referencePixelsPerUnit", UnityEngineUICanvasScaler_s_set_referencePixelsPerUnit);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "scaleFactor", UnityEngineUICanvasScaler_s_set_scaleFactor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "referenceResolution", UnityEngineUICanvasScaler_s_set_referenceResolution);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "screenMatchMode", UnityEngineUICanvasScaler_s_set_screenMatchMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "matchWidthOrHeight", UnityEngineUICanvasScaler_s_set_matchWidthOrHeight);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "physicalUnit", UnityEngineUICanvasScaler_s_set_physicalUnit);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "fallbackScreenDPI", UnityEngineUICanvasScaler_s_set_fallbackScreenDPI);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "defaultSpriteDPI", UnityEngineUICanvasScaler_s_set_defaultSpriteDPI);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "dynamicPixelsPerUnit", UnityEngineUICanvasScaler_s_set_dynamicPixelsPerUnit);
            
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineUICanvasScaler, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineUICanvasScaler(RealStatePtr L, int gen_param_count) 
        {
            return LuaAPI.luaL_error(L, "UnityEngine.UI.CanvasScaler does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        
        
        
        int UnityEngineUICanvasScaler_g_get_uiScaleMode(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.CanvasScaler gen_to_be_invoked = (UnityEngine.UI.CanvasScaler)translator.FastGetCSObj(L, 1);
			translator.PushUnityEngineUICanvasScalerScaleMode(L, gen_to_be_invoked.uiScaleMode);
            return 1;
        }
        
        int UnityEngineUICanvasScaler_g_get_referencePixelsPerUnit(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.CanvasScaler gen_to_be_invoked = (UnityEngine.UI.CanvasScaler)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.referencePixelsPerUnit);
            return 1;
        }
        
        int UnityEngineUICanvasScaler_g_get_scaleFactor(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.CanvasScaler gen_to_be_invoked = (UnityEngine.UI.CanvasScaler)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.scaleFactor);
            return 1;
        }
        
        int UnityEngineUICanvasScaler_g_get_referenceResolution(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.CanvasScaler gen_to_be_invoked = (UnityEngine.UI.CanvasScaler)translator.FastGetCSObj(L, 1);
			translator.PushUnityEngineVector2(L, gen_to_be_invoked.referenceResolution);
            return 1;
        }
        
        int UnityEngineUICanvasScaler_g_get_screenMatchMode(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.CanvasScaler gen_to_be_invoked = (UnityEngine.UI.CanvasScaler)translator.FastGetCSObj(L, 1);
			translator.PushUnityEngineUICanvasScalerScreenMatchMode(L, gen_to_be_invoked.screenMatchMode);
            return 1;
        }
        
        int UnityEngineUICanvasScaler_g_get_matchWidthOrHeight(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.CanvasScaler gen_to_be_invoked = (UnityEngine.UI.CanvasScaler)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.matchWidthOrHeight);
            return 1;
        }
        
        int UnityEngineUICanvasScaler_g_get_physicalUnit(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.CanvasScaler gen_to_be_invoked = (UnityEngine.UI.CanvasScaler)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.physicalUnit);
            return 1;
        }
        
        int UnityEngineUICanvasScaler_g_get_fallbackScreenDPI(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.CanvasScaler gen_to_be_invoked = (UnityEngine.UI.CanvasScaler)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.fallbackScreenDPI);
            return 1;
        }
        
        int UnityEngineUICanvasScaler_g_get_defaultSpriteDPI(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.CanvasScaler gen_to_be_invoked = (UnityEngine.UI.CanvasScaler)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.defaultSpriteDPI);
            return 1;
        }
        
        int UnityEngineUICanvasScaler_g_get_dynamicPixelsPerUnit(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.CanvasScaler gen_to_be_invoked = (UnityEngine.UI.CanvasScaler)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.dynamicPixelsPerUnit);
            return 1;
        }
        
        
        
        int UnityEngineUICanvasScaler_s_set_uiScaleMode(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.CanvasScaler gen_to_be_invoked = (UnityEngine.UI.CanvasScaler)translator.FastGetCSObj(L, 1);
            UnityEngine.UI.CanvasScaler.ScaleMode gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.uiScaleMode = gen_value;
            
            return 0;
        }
        
        int UnityEngineUICanvasScaler_s_set_referencePixelsPerUnit(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.CanvasScaler gen_to_be_invoked = (UnityEngine.UI.CanvasScaler)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.referencePixelsPerUnit = (float)LuaAPI.lua_tonumber(L, 2);
            
            return 0;
        }
        
        int UnityEngineUICanvasScaler_s_set_scaleFactor(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.CanvasScaler gen_to_be_invoked = (UnityEngine.UI.CanvasScaler)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.scaleFactor = (float)LuaAPI.lua_tonumber(L, 2);
            
            return 0;
        }
        
        int UnityEngineUICanvasScaler_s_set_referenceResolution(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.CanvasScaler gen_to_be_invoked = (UnityEngine.UI.CanvasScaler)translator.FastGetCSObj(L, 1);
            UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.referenceResolution = gen_value;
            
            return 0;
        }
        
        int UnityEngineUICanvasScaler_s_set_screenMatchMode(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.CanvasScaler gen_to_be_invoked = (UnityEngine.UI.CanvasScaler)translator.FastGetCSObj(L, 1);
            UnityEngine.UI.CanvasScaler.ScreenMatchMode gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.screenMatchMode = gen_value;
            
            return 0;
        }
        
        int UnityEngineUICanvasScaler_s_set_matchWidthOrHeight(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.CanvasScaler gen_to_be_invoked = (UnityEngine.UI.CanvasScaler)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.matchWidthOrHeight = (float)LuaAPI.lua_tonumber(L, 2);
            
            return 0;
        }
        
        int UnityEngineUICanvasScaler_s_set_physicalUnit(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.CanvasScaler gen_to_be_invoked = (UnityEngine.UI.CanvasScaler)translator.FastGetCSObj(L, 1);
            UnityEngine.UI.CanvasScaler.Unit gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.physicalUnit = gen_value;
            
            return 0;
        }
        
        int UnityEngineUICanvasScaler_s_set_fallbackScreenDPI(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.CanvasScaler gen_to_be_invoked = (UnityEngine.UI.CanvasScaler)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.fallbackScreenDPI = (float)LuaAPI.lua_tonumber(L, 2);
            
            return 0;
        }
        
        int UnityEngineUICanvasScaler_s_set_defaultSpriteDPI(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.CanvasScaler gen_to_be_invoked = (UnityEngine.UI.CanvasScaler)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.defaultSpriteDPI = (float)LuaAPI.lua_tonumber(L, 2);
            
            return 0;
        }
        
        int UnityEngineUICanvasScaler_s_set_dynamicPixelsPerUnit(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.CanvasScaler gen_to_be_invoked = (UnityEngine.UI.CanvasScaler)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.dynamicPixelsPerUnit = (float)LuaAPI.lua_tonumber(L, 2);
            
            return 0;
        }
        
		
		
		
		
    }
}
