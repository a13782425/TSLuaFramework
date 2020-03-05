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
    
		public void __RegisterUnityEngineKeyCode(RealStatePtr L)
        {
		    Utils.BeginObjectRegister(typeof(UnityEngine.KeyCode), L, this, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.KeyCode), L, this, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.KeyCode), L, null, 327, 0, 0);

            Utils.RegisterEnumType(L, typeof(UnityEngine.KeyCode));

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFromUnityEngineKeyCode);
            
            Utils.EndClassRegister(typeof(UnityEngine.KeyCode), L, this);
        }
		
        int __CastFromUnityEngineKeyCode(RealStatePtr L, int __gen_top)
		{
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                PushUnityEngineKeyCode(L, (UnityEngine.KeyCode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

                try
				{
                    TranslateToEnumToTop(L, typeof(UnityEngine.KeyCode), 1);
				}
				catch (System.Exception e)
				{
					return LuaAPI.luaL_error(L, "cast to " + typeof(UnityEngine.KeyCode) + " exception:" + e);
				}

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.KeyCode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
    
		public void __RegisterUnityEngineCameraClearFlags(RealStatePtr L)
        {
		    Utils.BeginObjectRegister(typeof(UnityEngine.CameraClearFlags), L, this, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.CameraClearFlags), L, this, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.CameraClearFlags), L, null, 6, 0, 0);

            
            Utils.RegisterObject(L, this, Utils.CLS_IDX, "Skybox", UnityEngine.CameraClearFlags.Skybox);
            
            Utils.RegisterObject(L, this, Utils.CLS_IDX, "Color", UnityEngine.CameraClearFlags.Color);
            
            Utils.RegisterObject(L, this, Utils.CLS_IDX, "SolidColor", UnityEngine.CameraClearFlags.SolidColor);
            
            Utils.RegisterObject(L, this, Utils.CLS_IDX, "Depth", UnityEngine.CameraClearFlags.Depth);
            
            Utils.RegisterObject(L, this, Utils.CLS_IDX, "Nothing", UnityEngine.CameraClearFlags.Nothing);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFromUnityEngineCameraClearFlags);
            
            Utils.EndClassRegister(typeof(UnityEngine.CameraClearFlags), L, this);
        }
		
        int __CastFromUnityEngineCameraClearFlags(RealStatePtr L, int __gen_top)
		{
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                PushUnityEngineCameraClearFlags(L, (UnityEngine.CameraClearFlags)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Skybox"))
                {
                    PushUnityEngineCameraClearFlags(L, UnityEngine.CameraClearFlags.Skybox);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Color"))
                {
                    PushUnityEngineCameraClearFlags(L, UnityEngine.CameraClearFlags.Color);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SolidColor"))
                {
                    PushUnityEngineCameraClearFlags(L, UnityEngine.CameraClearFlags.SolidColor);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Depth"))
                {
                    PushUnityEngineCameraClearFlags(L, UnityEngine.CameraClearFlags.Depth);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Nothing"))
                {
                    PushUnityEngineCameraClearFlags(L, UnityEngine.CameraClearFlags.Nothing);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.CameraClearFlags!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.CameraClearFlags! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
    
		public void __RegisterUnityEngineHideFlags(RealStatePtr L)
        {
		    Utils.BeginObjectRegister(typeof(UnityEngine.HideFlags), L, this, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.HideFlags), L, this, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.HideFlags), L, null, 10, 0, 0);

            
            Utils.RegisterObject(L, this, Utils.CLS_IDX, "None", UnityEngine.HideFlags.None);
            
            Utils.RegisterObject(L, this, Utils.CLS_IDX, "HideInHierarchy", UnityEngine.HideFlags.HideInHierarchy);
            
            Utils.RegisterObject(L, this, Utils.CLS_IDX, "HideInInspector", UnityEngine.HideFlags.HideInInspector);
            
            Utils.RegisterObject(L, this, Utils.CLS_IDX, "DontSaveInEditor", UnityEngine.HideFlags.DontSaveInEditor);
            
            Utils.RegisterObject(L, this, Utils.CLS_IDX, "NotEditable", UnityEngine.HideFlags.NotEditable);
            
            Utils.RegisterObject(L, this, Utils.CLS_IDX, "DontSaveInBuild", UnityEngine.HideFlags.DontSaveInBuild);
            
            Utils.RegisterObject(L, this, Utils.CLS_IDX, "DontUnloadUnusedAsset", UnityEngine.HideFlags.DontUnloadUnusedAsset);
            
            Utils.RegisterObject(L, this, Utils.CLS_IDX, "DontSave", UnityEngine.HideFlags.DontSave);
            
            Utils.RegisterObject(L, this, Utils.CLS_IDX, "HideAndDontSave", UnityEngine.HideFlags.HideAndDontSave);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFromUnityEngineHideFlags);
            
            Utils.EndClassRegister(typeof(UnityEngine.HideFlags), L, this);
        }
		
        int __CastFromUnityEngineHideFlags(RealStatePtr L, int __gen_top)
		{
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                PushUnityEngineHideFlags(L, (UnityEngine.HideFlags)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    PushUnityEngineHideFlags(L, UnityEngine.HideFlags.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "HideInHierarchy"))
                {
                    PushUnityEngineHideFlags(L, UnityEngine.HideFlags.HideInHierarchy);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "HideInInspector"))
                {
                    PushUnityEngineHideFlags(L, UnityEngine.HideFlags.HideInInspector);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DontSaveInEditor"))
                {
                    PushUnityEngineHideFlags(L, UnityEngine.HideFlags.DontSaveInEditor);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "NotEditable"))
                {
                    PushUnityEngineHideFlags(L, UnityEngine.HideFlags.NotEditable);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DontSaveInBuild"))
                {
                    PushUnityEngineHideFlags(L, UnityEngine.HideFlags.DontSaveInBuild);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DontUnloadUnusedAsset"))
                {
                    PushUnityEngineHideFlags(L, UnityEngine.HideFlags.DontUnloadUnusedAsset);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DontSave"))
                {
                    PushUnityEngineHideFlags(L, UnityEngine.HideFlags.DontSave);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "HideAndDontSave"))
                {
                    PushUnityEngineHideFlags(L, UnityEngine.HideFlags.HideAndDontSave);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.HideFlags!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.HideFlags! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
    
		public void __RegisterUnityEngineTouchPhase(RealStatePtr L)
        {
		    Utils.BeginObjectRegister(typeof(UnityEngine.TouchPhase), L, this, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.TouchPhase), L, this, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.TouchPhase), L, null, 6, 0, 0);

            
            Utils.RegisterObject(L, this, Utils.CLS_IDX, "Began", UnityEngine.TouchPhase.Began);
            
            Utils.RegisterObject(L, this, Utils.CLS_IDX, "Moved", UnityEngine.TouchPhase.Moved);
            
            Utils.RegisterObject(L, this, Utils.CLS_IDX, "Stationary", UnityEngine.TouchPhase.Stationary);
            
            Utils.RegisterObject(L, this, Utils.CLS_IDX, "Ended", UnityEngine.TouchPhase.Ended);
            
            Utils.RegisterObject(L, this, Utils.CLS_IDX, "Canceled", UnityEngine.TouchPhase.Canceled);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFromUnityEngineTouchPhase);
            
            Utils.EndClassRegister(typeof(UnityEngine.TouchPhase), L, this);
        }
		
        int __CastFromUnityEngineTouchPhase(RealStatePtr L, int __gen_top)
		{
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                PushUnityEngineTouchPhase(L, (UnityEngine.TouchPhase)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Began"))
                {
                    PushUnityEngineTouchPhase(L, UnityEngine.TouchPhase.Began);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Moved"))
                {
                    PushUnityEngineTouchPhase(L, UnityEngine.TouchPhase.Moved);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Stationary"))
                {
                    PushUnityEngineTouchPhase(L, UnityEngine.TouchPhase.Stationary);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Ended"))
                {
                    PushUnityEngineTouchPhase(L, UnityEngine.TouchPhase.Ended);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Canceled"))
                {
                    PushUnityEngineTouchPhase(L, UnityEngine.TouchPhase.Canceled);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.TouchPhase!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.TouchPhase! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
    
		public void __RegisterUnityEngineRenderMode(RealStatePtr L)
        {
		    Utils.BeginObjectRegister(typeof(UnityEngine.RenderMode), L, this, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.RenderMode), L, this, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.RenderMode), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, this, Utils.CLS_IDX, "ScreenSpaceOverlay", UnityEngine.RenderMode.ScreenSpaceOverlay);
            
            Utils.RegisterObject(L, this, Utils.CLS_IDX, "ScreenSpaceCamera", UnityEngine.RenderMode.ScreenSpaceCamera);
            
            Utils.RegisterObject(L, this, Utils.CLS_IDX, "WorldSpace", UnityEngine.RenderMode.WorldSpace);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFromUnityEngineRenderMode);
            
            Utils.EndClassRegister(typeof(UnityEngine.RenderMode), L, this);
        }
		
        int __CastFromUnityEngineRenderMode(RealStatePtr L, int __gen_top)
		{
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                PushUnityEngineRenderMode(L, (UnityEngine.RenderMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "ScreenSpaceOverlay"))
                {
                    PushUnityEngineRenderMode(L, UnityEngine.RenderMode.ScreenSpaceOverlay);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ScreenSpaceCamera"))
                {
                    PushUnityEngineRenderMode(L, UnityEngine.RenderMode.ScreenSpaceCamera);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "WorldSpace"))
                {
                    PushUnityEngineRenderMode(L, UnityEngine.RenderMode.WorldSpace);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.RenderMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.RenderMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
    
		public void __RegisterUnityEngineUICanvasScalerScaleMode(RealStatePtr L)
        {
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.CanvasScaler.ScaleMode), L, this, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.CanvasScaler.ScaleMode), L, this, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.CanvasScaler.ScaleMode), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, this, Utils.CLS_IDX, "ConstantPixelSize", UnityEngine.UI.CanvasScaler.ScaleMode.ConstantPixelSize);
            
            Utils.RegisterObject(L, this, Utils.CLS_IDX, "ScaleWithScreenSize", UnityEngine.UI.CanvasScaler.ScaleMode.ScaleWithScreenSize);
            
            Utils.RegisterObject(L, this, Utils.CLS_IDX, "ConstantPhysicalSize", UnityEngine.UI.CanvasScaler.ScaleMode.ConstantPhysicalSize);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFromUnityEngineUICanvasScalerScaleMode);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.CanvasScaler.ScaleMode), L, this);
        }
		
        int __CastFromUnityEngineUICanvasScalerScaleMode(RealStatePtr L, int __gen_top)
		{
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                PushUnityEngineUICanvasScalerScaleMode(L, (UnityEngine.UI.CanvasScaler.ScaleMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "ConstantPixelSize"))
                {
                    PushUnityEngineUICanvasScalerScaleMode(L, UnityEngine.UI.CanvasScaler.ScaleMode.ConstantPixelSize);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ScaleWithScreenSize"))
                {
                    PushUnityEngineUICanvasScalerScaleMode(L, UnityEngine.UI.CanvasScaler.ScaleMode.ScaleWithScreenSize);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ConstantPhysicalSize"))
                {
                    PushUnityEngineUICanvasScalerScaleMode(L, UnityEngine.UI.CanvasScaler.ScaleMode.ConstantPhysicalSize);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.CanvasScaler.ScaleMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.CanvasScaler.ScaleMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
    
		public void __RegisterUnityEngineUICanvasScalerScreenMatchMode(RealStatePtr L)
        {
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.CanvasScaler.ScreenMatchMode), L, this, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.CanvasScaler.ScreenMatchMode), L, this, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.CanvasScaler.ScreenMatchMode), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, this, Utils.CLS_IDX, "MatchWidthOrHeight", UnityEngine.UI.CanvasScaler.ScreenMatchMode.MatchWidthOrHeight);
            
            Utils.RegisterObject(L, this, Utils.CLS_IDX, "Expand", UnityEngine.UI.CanvasScaler.ScreenMatchMode.Expand);
            
            Utils.RegisterObject(L, this, Utils.CLS_IDX, "Shrink", UnityEngine.UI.CanvasScaler.ScreenMatchMode.Shrink);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFromUnityEngineUICanvasScalerScreenMatchMode);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.CanvasScaler.ScreenMatchMode), L, this);
        }
		
        int __CastFromUnityEngineUICanvasScalerScreenMatchMode(RealStatePtr L, int __gen_top)
		{
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                PushUnityEngineUICanvasScalerScreenMatchMode(L, (UnityEngine.UI.CanvasScaler.ScreenMatchMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "MatchWidthOrHeight"))
                {
                    PushUnityEngineUICanvasScalerScreenMatchMode(L, UnityEngine.UI.CanvasScaler.ScreenMatchMode.MatchWidthOrHeight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Expand"))
                {
                    PushUnityEngineUICanvasScalerScreenMatchMode(L, UnityEngine.UI.CanvasScaler.ScreenMatchMode.Expand);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Shrink"))
                {
                    PushUnityEngineUICanvasScalerScreenMatchMode(L, UnityEngine.UI.CanvasScaler.ScreenMatchMode.Shrink);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.CanvasScaler.ScreenMatchMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.CanvasScaler.ScreenMatchMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
    
	}
}