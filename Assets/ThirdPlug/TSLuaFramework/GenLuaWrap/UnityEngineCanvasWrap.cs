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
        public void __RegisterUnityEngineCanvas(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.Canvas);
			Utils.BeginObjectRegister(type, L, this, 0, 0, 19, 14);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "renderMode", UnityEngineCanvas_g_get_renderMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isRootCanvas", UnityEngineCanvas_g_get_isRootCanvas);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pixelRect", UnityEngineCanvas_g_get_pixelRect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "scaleFactor", UnityEngineCanvas_g_get_scaleFactor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "referencePixelsPerUnit", UnityEngineCanvas_g_get_referencePixelsPerUnit);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "overridePixelPerfect", UnityEngineCanvas_g_get_overridePixelPerfect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pixelPerfect", UnityEngineCanvas_g_get_pixelPerfect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "planeDistance", UnityEngineCanvas_g_get_planeDistance);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "renderOrder", UnityEngineCanvas_g_get_renderOrder);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "overrideSorting", UnityEngineCanvas_g_get_overrideSorting);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sortingOrder", UnityEngineCanvas_g_get_sortingOrder);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "targetDisplay", UnityEngineCanvas_g_get_targetDisplay);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sortingLayerID", UnityEngineCanvas_g_get_sortingLayerID);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "cachedSortingLayerValue", UnityEngineCanvas_g_get_cachedSortingLayerValue);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "additionalShaderChannels", UnityEngineCanvas_g_get_additionalShaderChannels);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sortingLayerName", UnityEngineCanvas_g_get_sortingLayerName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rootCanvas", UnityEngineCanvas_g_get_rootCanvas);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "worldCamera", UnityEngineCanvas_g_get_worldCamera);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "normalizedSortingGridSize", UnityEngineCanvas_g_get_normalizedSortingGridSize);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "renderMode", UnityEngineCanvas_s_set_renderMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "scaleFactor", UnityEngineCanvas_s_set_scaleFactor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "referencePixelsPerUnit", UnityEngineCanvas_s_set_referencePixelsPerUnit);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "overridePixelPerfect", UnityEngineCanvas_s_set_overridePixelPerfect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pixelPerfect", UnityEngineCanvas_s_set_pixelPerfect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "planeDistance", UnityEngineCanvas_s_set_planeDistance);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "overrideSorting", UnityEngineCanvas_s_set_overrideSorting);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sortingOrder", UnityEngineCanvas_s_set_sortingOrder);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "targetDisplay", UnityEngineCanvas_s_set_targetDisplay);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sortingLayerID", UnityEngineCanvas_s_set_sortingLayerID);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "additionalShaderChannels", UnityEngineCanvas_s_set_additionalShaderChannels);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sortingLayerName", UnityEngineCanvas_s_set_sortingLayerName);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "worldCamera", UnityEngineCanvas_s_set_worldCamera);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "normalizedSortingGridSize", UnityEngineCanvas_s_set_normalizedSortingGridSize);
            
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineCanvas, 5, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "GetDefaultCanvasMaterial", UnityEngineCanvas_m_GetDefaultCanvasMaterial_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetETC1SupportedCanvasMaterial", UnityEngineCanvas_m_GetETC1SupportedCanvasMaterial_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ForceUpdateCanvases", UnityEngineCanvas_m_ForceUpdateCanvases_xlua_st_);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "willRenderCanvases", UnityEngineCanvas_e_willRenderCanvases);
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineCanvas(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			if(gen_param_count == 1)
			{
				
				UnityEngine.Canvas gen_ret = new UnityEngine.Canvas();
				translator.Push(L, gen_ret);
				
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Canvas constructor!");
            
        }
        
		
        
		
        
        
        
        
        int UnityEngineCanvas_m_GetDefaultCanvasMaterial_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				
				UnityEngine.Material gen_ret = UnityEngine.Canvas.GetDefaultCanvasMaterial(  );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineCanvas_m_GetETC1SupportedCanvasMaterial_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				
				UnityEngine.Material gen_ret = UnityEngine.Canvas.GetETC1SupportedCanvasMaterial(  );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineCanvas_m_ForceUpdateCanvases_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				
				UnityEngine.Canvas.ForceUpdateCanvases(  );
				
				
				
				return 0;
			}
			
            
        }
        
        
        
        
        int UnityEngineCanvas_g_get_renderMode(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Canvas gen_to_be_invoked = (UnityEngine.Canvas)translator.FastGetCSObj(L, 1);
			translator.PushUnityEngineRenderMode(L, gen_to_be_invoked.renderMode);
            return 1;
        }
        
        int UnityEngineCanvas_g_get_isRootCanvas(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Canvas gen_to_be_invoked = (UnityEngine.Canvas)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isRootCanvas);
            return 1;
        }
        
        int UnityEngineCanvas_g_get_pixelRect(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Canvas gen_to_be_invoked = (UnityEngine.Canvas)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.pixelRect);
            return 1;
        }
        
        int UnityEngineCanvas_g_get_scaleFactor(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Canvas gen_to_be_invoked = (UnityEngine.Canvas)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.scaleFactor);
            return 1;
        }
        
        int UnityEngineCanvas_g_get_referencePixelsPerUnit(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Canvas gen_to_be_invoked = (UnityEngine.Canvas)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.referencePixelsPerUnit);
            return 1;
        }
        
        int UnityEngineCanvas_g_get_overridePixelPerfect(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Canvas gen_to_be_invoked = (UnityEngine.Canvas)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.overridePixelPerfect);
            return 1;
        }
        
        int UnityEngineCanvas_g_get_pixelPerfect(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Canvas gen_to_be_invoked = (UnityEngine.Canvas)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.pixelPerfect);
            return 1;
        }
        
        int UnityEngineCanvas_g_get_planeDistance(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Canvas gen_to_be_invoked = (UnityEngine.Canvas)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.planeDistance);
            return 1;
        }
        
        int UnityEngineCanvas_g_get_renderOrder(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Canvas gen_to_be_invoked = (UnityEngine.Canvas)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.renderOrder);
            return 1;
        }
        
        int UnityEngineCanvas_g_get_overrideSorting(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Canvas gen_to_be_invoked = (UnityEngine.Canvas)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.overrideSorting);
            return 1;
        }
        
        int UnityEngineCanvas_g_get_sortingOrder(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Canvas gen_to_be_invoked = (UnityEngine.Canvas)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.sortingOrder);
            return 1;
        }
        
        int UnityEngineCanvas_g_get_targetDisplay(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Canvas gen_to_be_invoked = (UnityEngine.Canvas)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.targetDisplay);
            return 1;
        }
        
        int UnityEngineCanvas_g_get_sortingLayerID(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Canvas gen_to_be_invoked = (UnityEngine.Canvas)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.sortingLayerID);
            return 1;
        }
        
        int UnityEngineCanvas_g_get_cachedSortingLayerValue(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Canvas gen_to_be_invoked = (UnityEngine.Canvas)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.cachedSortingLayerValue);
            return 1;
        }
        
        int UnityEngineCanvas_g_get_additionalShaderChannels(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Canvas gen_to_be_invoked = (UnityEngine.Canvas)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.additionalShaderChannels);
            return 1;
        }
        
        int UnityEngineCanvas_g_get_sortingLayerName(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Canvas gen_to_be_invoked = (UnityEngine.Canvas)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushstring(L, gen_to_be_invoked.sortingLayerName);
            return 1;
        }
        
        int UnityEngineCanvas_g_get_rootCanvas(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Canvas gen_to_be_invoked = (UnityEngine.Canvas)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.rootCanvas);
            return 1;
        }
        
        int UnityEngineCanvas_g_get_worldCamera(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Canvas gen_to_be_invoked = (UnityEngine.Canvas)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.worldCamera);
            return 1;
        }
        
        int UnityEngineCanvas_g_get_normalizedSortingGridSize(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Canvas gen_to_be_invoked = (UnityEngine.Canvas)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.normalizedSortingGridSize);
            return 1;
        }
        
        
        
        int UnityEngineCanvas_s_set_renderMode(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Canvas gen_to_be_invoked = (UnityEngine.Canvas)translator.FastGetCSObj(L, 1);
            UnityEngine.RenderMode gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.renderMode = gen_value;
            
            return 0;
        }
        
        int UnityEngineCanvas_s_set_scaleFactor(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Canvas gen_to_be_invoked = (UnityEngine.Canvas)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.scaleFactor = (float)LuaAPI.lua_tonumber(L, 2);
            
            return 0;
        }
        
        int UnityEngineCanvas_s_set_referencePixelsPerUnit(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Canvas gen_to_be_invoked = (UnityEngine.Canvas)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.referencePixelsPerUnit = (float)LuaAPI.lua_tonumber(L, 2);
            
            return 0;
        }
        
        int UnityEngineCanvas_s_set_overridePixelPerfect(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Canvas gen_to_be_invoked = (UnityEngine.Canvas)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.overridePixelPerfect = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineCanvas_s_set_pixelPerfect(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Canvas gen_to_be_invoked = (UnityEngine.Canvas)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.pixelPerfect = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineCanvas_s_set_planeDistance(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Canvas gen_to_be_invoked = (UnityEngine.Canvas)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.planeDistance = (float)LuaAPI.lua_tonumber(L, 2);
            
            return 0;
        }
        
        int UnityEngineCanvas_s_set_overrideSorting(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Canvas gen_to_be_invoked = (UnityEngine.Canvas)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.overrideSorting = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineCanvas_s_set_sortingOrder(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Canvas gen_to_be_invoked = (UnityEngine.Canvas)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.sortingOrder = LuaAPI.xlua_tointeger(L, 2);
            
            return 0;
        }
        
        int UnityEngineCanvas_s_set_targetDisplay(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Canvas gen_to_be_invoked = (UnityEngine.Canvas)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.targetDisplay = LuaAPI.xlua_tointeger(L, 2);
            
            return 0;
        }
        
        int UnityEngineCanvas_s_set_sortingLayerID(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Canvas gen_to_be_invoked = (UnityEngine.Canvas)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.sortingLayerID = LuaAPI.xlua_tointeger(L, 2);
            
            return 0;
        }
        
        int UnityEngineCanvas_s_set_additionalShaderChannels(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Canvas gen_to_be_invoked = (UnityEngine.Canvas)translator.FastGetCSObj(L, 1);
            UnityEngine.AdditionalCanvasShaderChannels gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.additionalShaderChannels = gen_value;
            
            return 0;
        }
        
        int UnityEngineCanvas_s_set_sortingLayerName(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Canvas gen_to_be_invoked = (UnityEngine.Canvas)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.sortingLayerName = LuaAPI.lua_tostring(L, 2);
            
            return 0;
        }
        
        int UnityEngineCanvas_s_set_worldCamera(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Canvas gen_to_be_invoked = (UnityEngine.Canvas)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.worldCamera = (UnityEngine.Camera)translator.GetObject(L, 2, typeof(UnityEngine.Camera));
            
            return 0;
        }
        
        int UnityEngineCanvas_s_set_normalizedSortingGridSize(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Canvas gen_to_be_invoked = (UnityEngine.Canvas)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.normalizedSortingGridSize = (float)LuaAPI.lua_tonumber(L, 2);
            
            return 0;
        }
        
		
		
		
		
        int UnityEngineCanvas_e_willRenderCanvases(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			UnityEngine.Canvas.WillRenderCanvases gen_delegate = translator.GetDelegate<UnityEngine.Canvas.WillRenderCanvases>(L, 2);
			if (gen_delegate == null) {
				return LuaAPI.luaL_error(L, "#2 need UnityEngine.Canvas.WillRenderCanvases!");
			}
			
			
			if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
				UnityEngine.Canvas.willRenderCanvases += gen_delegate;
				return 0;
			} 
			
			
			if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
				UnityEngine.Canvas.willRenderCanvases -= gen_delegate;
				return 0;
			} 
			
			return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Canvas.willRenderCanvases!");
        }
        
    }
}
