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
        public void __RegisterUnityEngineCamera(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.Camera);
			Utils.BeginObjectRegister(type, L, this, 0, 41, 57, 44);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Reset", UnityEngineCamera_m_Reset);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ResetTransparencySortSettings", UnityEngineCamera_m_ResetTransparencySortSettings);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ResetAspect", UnityEngineCamera_m_ResetAspect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ResetCullingMatrix", UnityEngineCamera_m_ResetCullingMatrix);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetReplacementShader", UnityEngineCamera_m_SetReplacementShader);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ResetReplacementShader", UnityEngineCamera_m_ResetReplacementShader);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetGateFittedFieldOfView", UnityEngineCamera_m_GetGateFittedFieldOfView);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetGateFittedLensShift", UnityEngineCamera_m_GetGateFittedLensShift);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetTargetBuffers", UnityEngineCamera_m_SetTargetBuffers);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ResetWorldToCameraMatrix", UnityEngineCamera_m_ResetWorldToCameraMatrix);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ResetProjectionMatrix", UnityEngineCamera_m_ResetProjectionMatrix);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CalculateObliqueMatrix", UnityEngineCamera_m_CalculateObliqueMatrix);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WorldToScreenPoint", UnityEngineCamera_m_WorldToScreenPoint);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WorldToViewportPoint", UnityEngineCamera_m_WorldToViewportPoint);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ViewportToWorldPoint", UnityEngineCamera_m_ViewportToWorldPoint);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ScreenToWorldPoint", UnityEngineCamera_m_ScreenToWorldPoint);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ScreenToViewportPoint", UnityEngineCamera_m_ScreenToViewportPoint);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ViewportToScreenPoint", UnityEngineCamera_m_ViewportToScreenPoint);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ViewportPointToRay", UnityEngineCamera_m_ViewportPointToRay);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ScreenPointToRay", UnityEngineCamera_m_ScreenPointToRay);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CalculateFrustumCorners", UnityEngineCamera_m_CalculateFrustumCorners);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetStereoNonJitteredProjectionMatrix", UnityEngineCamera_m_GetStereoNonJitteredProjectionMatrix);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetStereoViewMatrix", UnityEngineCamera_m_GetStereoViewMatrix);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CopyStereoDeviceProjectionMatrixToNonJittered", UnityEngineCamera_m_CopyStereoDeviceProjectionMatrixToNonJittered);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetStereoProjectionMatrix", UnityEngineCamera_m_GetStereoProjectionMatrix);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetStereoProjectionMatrix", UnityEngineCamera_m_SetStereoProjectionMatrix);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ResetStereoProjectionMatrices", UnityEngineCamera_m_ResetStereoProjectionMatrices);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetStereoViewMatrix", UnityEngineCamera_m_SetStereoViewMatrix);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ResetStereoViewMatrices", UnityEngineCamera_m_ResetStereoViewMatrices);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RenderToCubemap", UnityEngineCamera_m_RenderToCubemap);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Render", UnityEngineCamera_m_Render);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RenderWithShader", UnityEngineCamera_m_RenderWithShader);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RenderDontRestore", UnityEngineCamera_m_RenderDontRestore);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CopyFrom", UnityEngineCamera_m_CopyFrom);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveCommandBuffers", UnityEngineCamera_m_RemoveCommandBuffers);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveAllCommandBuffers", UnityEngineCamera_m_RemoveAllCommandBuffers);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddCommandBuffer", UnityEngineCamera_m_AddCommandBuffer);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddCommandBufferAsync", UnityEngineCamera_m_AddCommandBufferAsync);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveCommandBuffer", UnityEngineCamera_m_RemoveCommandBuffer);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetCommandBuffers", UnityEngineCamera_m_GetCommandBuffers);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TryGetCullingParameters", UnityEngineCamera_m_TryGetCullingParameters);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "nearClipPlane", UnityEngineCamera_g_get_nearClipPlane);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "farClipPlane", UnityEngineCamera_g_get_farClipPlane);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "fieldOfView", UnityEngineCamera_g_get_fieldOfView);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "renderingPath", UnityEngineCamera_g_get_renderingPath);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "actualRenderingPath", UnityEngineCamera_g_get_actualRenderingPath);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "allowHDR", UnityEngineCamera_g_get_allowHDR);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "allowMSAA", UnityEngineCamera_g_get_allowMSAA);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "allowDynamicResolution", UnityEngineCamera_g_get_allowDynamicResolution);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "forceIntoRenderTexture", UnityEngineCamera_g_get_forceIntoRenderTexture);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "orthographicSize", UnityEngineCamera_g_get_orthographicSize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "orthographic", UnityEngineCamera_g_get_orthographic);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "opaqueSortMode", UnityEngineCamera_g_get_opaqueSortMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "transparencySortMode", UnityEngineCamera_g_get_transparencySortMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "transparencySortAxis", UnityEngineCamera_g_get_transparencySortAxis);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "depth", UnityEngineCamera_g_get_depth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "aspect", UnityEngineCamera_g_get_aspect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "velocity", UnityEngineCamera_g_get_velocity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "cullingMask", UnityEngineCamera_g_get_cullingMask);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "eventMask", UnityEngineCamera_g_get_eventMask);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "layerCullSpherical", UnityEngineCamera_g_get_layerCullSpherical);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "cameraType", UnityEngineCamera_g_get_cameraType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "overrideSceneCullingMask", UnityEngineCamera_g_get_overrideSceneCullingMask);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "layerCullDistances", UnityEngineCamera_g_get_layerCullDistances);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "useOcclusionCulling", UnityEngineCamera_g_get_useOcclusionCulling);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "cullingMatrix", UnityEngineCamera_g_get_cullingMatrix);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "backgroundColor", UnityEngineCamera_g_get_backgroundColor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "clearFlags", UnityEngineCamera_g_get_clearFlags);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "depthTextureMode", UnityEngineCamera_g_get_depthTextureMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "clearStencilAfterLightingPass", UnityEngineCamera_g_get_clearStencilAfterLightingPass);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "usePhysicalProperties", UnityEngineCamera_g_get_usePhysicalProperties);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sensorSize", UnityEngineCamera_g_get_sensorSize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lensShift", UnityEngineCamera_g_get_lensShift);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "focalLength", UnityEngineCamera_g_get_focalLength);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "gateFit", UnityEngineCamera_g_get_gateFit);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rect", UnityEngineCamera_g_get_rect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pixelRect", UnityEngineCamera_g_get_pixelRect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pixelWidth", UnityEngineCamera_g_get_pixelWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pixelHeight", UnityEngineCamera_g_get_pixelHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "scaledPixelWidth", UnityEngineCamera_g_get_scaledPixelWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "scaledPixelHeight", UnityEngineCamera_g_get_scaledPixelHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "targetTexture", UnityEngineCamera_g_get_targetTexture);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "activeTexture", UnityEngineCamera_g_get_activeTexture);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "targetDisplay", UnityEngineCamera_g_get_targetDisplay);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "cameraToWorldMatrix", UnityEngineCamera_g_get_cameraToWorldMatrix);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "worldToCameraMatrix", UnityEngineCamera_g_get_worldToCameraMatrix);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "projectionMatrix", UnityEngineCamera_g_get_projectionMatrix);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "nonJitteredProjectionMatrix", UnityEngineCamera_g_get_nonJitteredProjectionMatrix);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "useJitteredProjectionMatrixForTransparentRendering", UnityEngineCamera_g_get_useJitteredProjectionMatrixForTransparentRendering);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "previousViewProjectionMatrix", UnityEngineCamera_g_get_previousViewProjectionMatrix);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "scene", UnityEngineCamera_g_get_scene);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "stereoEnabled", UnityEngineCamera_g_get_stereoEnabled);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "stereoSeparation", UnityEngineCamera_g_get_stereoSeparation);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "stereoConvergence", UnityEngineCamera_g_get_stereoConvergence);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "areVRStereoViewMatricesWithinSingleCullTolerance", UnityEngineCamera_g_get_areVRStereoViewMatricesWithinSingleCullTolerance);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "stereoTargetEye", UnityEngineCamera_g_get_stereoTargetEye);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "stereoActiveEye", UnityEngineCamera_g_get_stereoActiveEye);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "commandBufferCount", UnityEngineCamera_g_get_commandBufferCount);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "nearClipPlane", UnityEngineCamera_s_set_nearClipPlane);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "farClipPlane", UnityEngineCamera_s_set_farClipPlane);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "fieldOfView", UnityEngineCamera_s_set_fieldOfView);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "renderingPath", UnityEngineCamera_s_set_renderingPath);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "allowHDR", UnityEngineCamera_s_set_allowHDR);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "allowMSAA", UnityEngineCamera_s_set_allowMSAA);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "allowDynamicResolution", UnityEngineCamera_s_set_allowDynamicResolution);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "forceIntoRenderTexture", UnityEngineCamera_s_set_forceIntoRenderTexture);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "orthographicSize", UnityEngineCamera_s_set_orthographicSize);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "orthographic", UnityEngineCamera_s_set_orthographic);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "opaqueSortMode", UnityEngineCamera_s_set_opaqueSortMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "transparencySortMode", UnityEngineCamera_s_set_transparencySortMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "transparencySortAxis", UnityEngineCamera_s_set_transparencySortAxis);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "depth", UnityEngineCamera_s_set_depth);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "aspect", UnityEngineCamera_s_set_aspect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "cullingMask", UnityEngineCamera_s_set_cullingMask);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "eventMask", UnityEngineCamera_s_set_eventMask);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "layerCullSpherical", UnityEngineCamera_s_set_layerCullSpherical);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "cameraType", UnityEngineCamera_s_set_cameraType);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "overrideSceneCullingMask", UnityEngineCamera_s_set_overrideSceneCullingMask);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "layerCullDistances", UnityEngineCamera_s_set_layerCullDistances);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "useOcclusionCulling", UnityEngineCamera_s_set_useOcclusionCulling);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "cullingMatrix", UnityEngineCamera_s_set_cullingMatrix);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "backgroundColor", UnityEngineCamera_s_set_backgroundColor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "clearFlags", UnityEngineCamera_s_set_clearFlags);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "depthTextureMode", UnityEngineCamera_s_set_depthTextureMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "clearStencilAfterLightingPass", UnityEngineCamera_s_set_clearStencilAfterLightingPass);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "usePhysicalProperties", UnityEngineCamera_s_set_usePhysicalProperties);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sensorSize", UnityEngineCamera_s_set_sensorSize);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "lensShift", UnityEngineCamera_s_set_lensShift);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "focalLength", UnityEngineCamera_s_set_focalLength);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "gateFit", UnityEngineCamera_s_set_gateFit);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "rect", UnityEngineCamera_s_set_rect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pixelRect", UnityEngineCamera_s_set_pixelRect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "targetTexture", UnityEngineCamera_s_set_targetTexture);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "targetDisplay", UnityEngineCamera_s_set_targetDisplay);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "worldToCameraMatrix", UnityEngineCamera_s_set_worldToCameraMatrix);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "projectionMatrix", UnityEngineCamera_s_set_projectionMatrix);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "nonJitteredProjectionMatrix", UnityEngineCamera_s_set_nonJitteredProjectionMatrix);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "useJitteredProjectionMatrixForTransparentRendering", UnityEngineCamera_s_set_useJitteredProjectionMatrixForTransparentRendering);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "scene", UnityEngineCamera_s_set_scene);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "stereoSeparation", UnityEngineCamera_s_set_stereoSeparation);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "stereoConvergence", UnityEngineCamera_s_set_stereoConvergence);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "stereoTargetEye", UnityEngineCamera_s_set_stereoTargetEye);
            
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineCamera, 8, 7, 3);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "CalculateProjectionMatrixFromPhysicalProperties", UnityEngineCamera_m_CalculateProjectionMatrixFromPhysicalProperties_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FocalLengthToFieldOfView", UnityEngineCamera_m_FocalLengthToFieldOfView_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FieldOfViewToFocalLength", UnityEngineCamera_m_FieldOfViewToFocalLength_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "HorizontalToVerticalFieldOfView", UnityEngineCamera_m_HorizontalToVerticalFieldOfView_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "VerticalToHorizontalFieldOfView", UnityEngineCamera_m_VerticalToHorizontalFieldOfView_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAllCameras", UnityEngineCamera_m_GetAllCameras_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetupCurrent", UnityEngineCamera_m_SetupCurrent_xlua_st_);
            
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "main", UnityEngineCamera_g_get_main);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "current", UnityEngineCamera_g_get_current);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "allCamerasCount", UnityEngineCamera_g_get_allCamerasCount);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "allCameras", UnityEngineCamera_g_get_allCameras);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "onPreCull", UnityEngineCamera_g_get_onPreCull);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "onPreRender", UnityEngineCamera_g_get_onPreRender);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "onPostRender", UnityEngineCamera_g_get_onPostRender);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "onPreCull", UnityEngineCamera_s_set_onPreCull);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "onPreRender", UnityEngineCamera_s_set_onPreRender);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "onPostRender", UnityEngineCamera_s_set_onPostRender);
            
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineCamera(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			if(gen_param_count == 1)
			{
				
				UnityEngine.Camera gen_ret = new UnityEngine.Camera();
				translator.Push(L, gen_ret);
				
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Camera constructor!");
            
        }
        
		
        
		
        
        
        
        
        int UnityEngineCamera_m_Reset(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.Reset(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineCamera_m_ResetTransparencySortSettings(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.ResetTransparencySortSettings(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineCamera_m_ResetAspect(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.ResetAspect(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineCamera_m_ResetCullingMatrix(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.ResetCullingMatrix(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineCamera_m_SetReplacementShader(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.Shader _shader = (UnityEngine.Shader)translator.GetObject(L, 2, typeof(UnityEngine.Shader));
				string _replacementTag = LuaAPI.lua_tostring(L, 3);
				
				gen_to_be_invoked.SetReplacementShader( _shader, _replacementTag );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineCamera_m_ResetReplacementShader(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.ResetReplacementShader(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineCamera_m_GetGateFittedFieldOfView(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
			
			{
				
				float gen_ret = gen_to_be_invoked.GetGateFittedFieldOfView(  );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineCamera_m_GetGateFittedLensShift(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
			
			{
				
				UnityEngine.Vector2 gen_ret = gen_to_be_invoked.GetGateFittedLensShift(  );
				translator.PushUnityEngineVector2(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineCamera_m_SetTargetBuffers(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 3&& translator.Assignable<UnityEngine.RenderBuffer>(L, 2)&& translator.Assignable<UnityEngine.RenderBuffer>(L, 3)) 
			{
				UnityEngine.RenderBuffer _colorBuffer;translator.Get(L, 2, out _colorBuffer);
				UnityEngine.RenderBuffer _depthBuffer;translator.Get(L, 3, out _depthBuffer);
				
				gen_to_be_invoked.SetTargetBuffers( _colorBuffer, _depthBuffer );
				
				
				
				return 0;
			}
			if(gen_param_count == 3&& translator.Assignable<UnityEngine.RenderBuffer[]>(L, 2)&& translator.Assignable<UnityEngine.RenderBuffer>(L, 3)) 
			{
				UnityEngine.RenderBuffer[] _colorBuffer = (UnityEngine.RenderBuffer[])translator.GetObject(L, 2, typeof(UnityEngine.RenderBuffer[]));
				UnityEngine.RenderBuffer _depthBuffer;translator.Get(L, 3, out _depthBuffer);
				
				gen_to_be_invoked.SetTargetBuffers( _colorBuffer, _depthBuffer );
				
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Camera.SetTargetBuffers!");
            
        }
        
        int UnityEngineCamera_m_ResetWorldToCameraMatrix(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.ResetWorldToCameraMatrix(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineCamera_m_ResetProjectionMatrix(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.ResetProjectionMatrix(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineCamera_m_CalculateObliqueMatrix(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.Vector4 _clipPlane;translator.Get(L, 2, out _clipPlane);
				
				UnityEngine.Matrix4x4 gen_ret = gen_to_be_invoked.CalculateObliqueMatrix( _clipPlane );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineCamera_m_WorldToScreenPoint(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
			{
				UnityEngine.Vector3 _position;translator.Get(L, 2, out _position);
				
				UnityEngine.Vector3 gen_ret = gen_to_be_invoked.WorldToScreenPoint( _position );
				translator.PushUnityEngineVector3(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Camera.MonoOrStereoscopicEye>(L, 3)) 
			{
				UnityEngine.Vector3 _position;translator.Get(L, 2, out _position);
				UnityEngine.Camera.MonoOrStereoscopicEye _eye;translator.Get(L, 3, out _eye);
				
				UnityEngine.Vector3 gen_ret = gen_to_be_invoked.WorldToScreenPoint( _position, _eye );
				translator.PushUnityEngineVector3(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Camera.WorldToScreenPoint!");
            
        }
        
        int UnityEngineCamera_m_WorldToViewportPoint(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
			{
				UnityEngine.Vector3 _position;translator.Get(L, 2, out _position);
				
				UnityEngine.Vector3 gen_ret = gen_to_be_invoked.WorldToViewportPoint( _position );
				translator.PushUnityEngineVector3(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Camera.MonoOrStereoscopicEye>(L, 3)) 
			{
				UnityEngine.Vector3 _position;translator.Get(L, 2, out _position);
				UnityEngine.Camera.MonoOrStereoscopicEye _eye;translator.Get(L, 3, out _eye);
				
				UnityEngine.Vector3 gen_ret = gen_to_be_invoked.WorldToViewportPoint( _position, _eye );
				translator.PushUnityEngineVector3(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Camera.WorldToViewportPoint!");
            
        }
        
        int UnityEngineCamera_m_ViewportToWorldPoint(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
			{
				UnityEngine.Vector3 _position;translator.Get(L, 2, out _position);
				
				UnityEngine.Vector3 gen_ret = gen_to_be_invoked.ViewportToWorldPoint( _position );
				translator.PushUnityEngineVector3(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Camera.MonoOrStereoscopicEye>(L, 3)) 
			{
				UnityEngine.Vector3 _position;translator.Get(L, 2, out _position);
				UnityEngine.Camera.MonoOrStereoscopicEye _eye;translator.Get(L, 3, out _eye);
				
				UnityEngine.Vector3 gen_ret = gen_to_be_invoked.ViewportToWorldPoint( _position, _eye );
				translator.PushUnityEngineVector3(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Camera.ViewportToWorldPoint!");
            
        }
        
        int UnityEngineCamera_m_ScreenToWorldPoint(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
			{
				UnityEngine.Vector3 _position;translator.Get(L, 2, out _position);
				
				UnityEngine.Vector3 gen_ret = gen_to_be_invoked.ScreenToWorldPoint( _position );
				translator.PushUnityEngineVector3(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Camera.MonoOrStereoscopicEye>(L, 3)) 
			{
				UnityEngine.Vector3 _position;translator.Get(L, 2, out _position);
				UnityEngine.Camera.MonoOrStereoscopicEye _eye;translator.Get(L, 3, out _eye);
				
				UnityEngine.Vector3 gen_ret = gen_to_be_invoked.ScreenToWorldPoint( _position, _eye );
				translator.PushUnityEngineVector3(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Camera.ScreenToWorldPoint!");
            
        }
        
        int UnityEngineCamera_m_ScreenToViewportPoint(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.Vector3 _position;translator.Get(L, 2, out _position);
				
				UnityEngine.Vector3 gen_ret = gen_to_be_invoked.ScreenToViewportPoint( _position );
				translator.PushUnityEngineVector3(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineCamera_m_ViewportToScreenPoint(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.Vector3 _position;translator.Get(L, 2, out _position);
				
				UnityEngine.Vector3 gen_ret = gen_to_be_invoked.ViewportToScreenPoint( _position );
				translator.PushUnityEngineVector3(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineCamera_m_ViewportPointToRay(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
			{
				UnityEngine.Vector3 _pos;translator.Get(L, 2, out _pos);
				
				UnityEngine.Ray gen_ret = gen_to_be_invoked.ViewportPointToRay( _pos );
				translator.PushUnityEngineRay(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Camera.MonoOrStereoscopicEye>(L, 3)) 
			{
				UnityEngine.Vector3 _pos;translator.Get(L, 2, out _pos);
				UnityEngine.Camera.MonoOrStereoscopicEye _eye;translator.Get(L, 3, out _eye);
				
				UnityEngine.Ray gen_ret = gen_to_be_invoked.ViewportPointToRay( _pos, _eye );
				translator.PushUnityEngineRay(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Camera.ViewportPointToRay!");
            
        }
        
        int UnityEngineCamera_m_ScreenPointToRay(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
			{
				UnityEngine.Vector3 _pos;translator.Get(L, 2, out _pos);
				
				UnityEngine.Ray gen_ret = gen_to_be_invoked.ScreenPointToRay( _pos );
				translator.PushUnityEngineRay(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Camera.MonoOrStereoscopicEye>(L, 3)) 
			{
				UnityEngine.Vector3 _pos;translator.Get(L, 2, out _pos);
				UnityEngine.Camera.MonoOrStereoscopicEye _eye;translator.Get(L, 3, out _eye);
				
				UnityEngine.Ray gen_ret = gen_to_be_invoked.ScreenPointToRay( _pos, _eye );
				translator.PushUnityEngineRay(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Camera.ScreenPointToRay!");
            
        }
        
        int UnityEngineCamera_m_CalculateFrustumCorners(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.Rect _viewport;translator.Get(L, 2, out _viewport);
				float _z = (float)LuaAPI.lua_tonumber(L, 3);
				UnityEngine.Camera.MonoOrStereoscopicEye _eye;translator.Get(L, 4, out _eye);
				UnityEngine.Vector3[] _outCorners = (UnityEngine.Vector3[])translator.GetObject(L, 5, typeof(UnityEngine.Vector3[]));
				
				gen_to_be_invoked.CalculateFrustumCorners( _viewport, _z, _eye, _outCorners );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineCamera_m_CalculateProjectionMatrixFromPhysicalProperties_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			if(gen_param_count == 6&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Camera.GateFitParameters>(L, 6)) 
			{
				UnityEngine.Matrix4x4 _output;
				float _focalLength = (float)LuaAPI.lua_tonumber(L, 1);
				UnityEngine.Vector2 _sensorSize;translator.Get(L, 2, out _sensorSize);
				UnityEngine.Vector2 _lensShift;translator.Get(L, 3, out _lensShift);
				float _nearClip = (float)LuaAPI.lua_tonumber(L, 4);
				float _farClip = (float)LuaAPI.lua_tonumber(L, 5);
				UnityEngine.Camera.GateFitParameters _gateFitParameters;translator.Get(L, 6, out _gateFitParameters);
				
				UnityEngine.Camera.CalculateProjectionMatrixFromPhysicalProperties( out _output, _focalLength, _sensorSize, _lensShift, _nearClip, _farClip, _gateFitParameters );
				translator.Push(L, _output);
					
				
				
				
				return 1;
			}
			if(gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
			{
				UnityEngine.Matrix4x4 _output;
				float _focalLength = (float)LuaAPI.lua_tonumber(L, 1);
				UnityEngine.Vector2 _sensorSize;translator.Get(L, 2, out _sensorSize);
				UnityEngine.Vector2 _lensShift;translator.Get(L, 3, out _lensShift);
				float _nearClip = (float)LuaAPI.lua_tonumber(L, 4);
				float _farClip = (float)LuaAPI.lua_tonumber(L, 5);
				
				UnityEngine.Camera.CalculateProjectionMatrixFromPhysicalProperties( out _output, _focalLength, _sensorSize, _lensShift, _nearClip, _farClip );
				translator.Push(L, _output);
					
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Camera.CalculateProjectionMatrixFromPhysicalProperties!");
            
        }
        
        int UnityEngineCamera_m_FocalLengthToFieldOfView_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				float _focalLength = (float)LuaAPI.lua_tonumber(L, 1);
				float _sensorSize = (float)LuaAPI.lua_tonumber(L, 2);
				
				float gen_ret = UnityEngine.Camera.FocalLengthToFieldOfView( _focalLength, _sensorSize );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineCamera_m_FieldOfViewToFocalLength_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				float _fieldOfView = (float)LuaAPI.lua_tonumber(L, 1);
				float _sensorSize = (float)LuaAPI.lua_tonumber(L, 2);
				
				float gen_ret = UnityEngine.Camera.FieldOfViewToFocalLength( _fieldOfView, _sensorSize );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineCamera_m_HorizontalToVerticalFieldOfView_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				float _horizontalFieldOfView = (float)LuaAPI.lua_tonumber(L, 1);
				float _aspectRatio = (float)LuaAPI.lua_tonumber(L, 2);
				
				float gen_ret = UnityEngine.Camera.HorizontalToVerticalFieldOfView( _horizontalFieldOfView, _aspectRatio );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineCamera_m_VerticalToHorizontalFieldOfView_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				float _verticalFieldOfView = (float)LuaAPI.lua_tonumber(L, 1);
				float _aspectRatio = (float)LuaAPI.lua_tonumber(L, 2);
				
				float gen_ret = UnityEngine.Camera.VerticalToHorizontalFieldOfView( _verticalFieldOfView, _aspectRatio );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineCamera_m_GetStereoNonJitteredProjectionMatrix(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.Camera.StereoscopicEye _eye;translator.Get(L, 2, out _eye);
				
				UnityEngine.Matrix4x4 gen_ret = gen_to_be_invoked.GetStereoNonJitteredProjectionMatrix( _eye );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineCamera_m_GetStereoViewMatrix(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.Camera.StereoscopicEye _eye;translator.Get(L, 2, out _eye);
				
				UnityEngine.Matrix4x4 gen_ret = gen_to_be_invoked.GetStereoViewMatrix( _eye );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineCamera_m_CopyStereoDeviceProjectionMatrixToNonJittered(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.Camera.StereoscopicEye _eye;translator.Get(L, 2, out _eye);
				
				gen_to_be_invoked.CopyStereoDeviceProjectionMatrixToNonJittered( _eye );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineCamera_m_GetStereoProjectionMatrix(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.Camera.StereoscopicEye _eye;translator.Get(L, 2, out _eye);
				
				UnityEngine.Matrix4x4 gen_ret = gen_to_be_invoked.GetStereoProjectionMatrix( _eye );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineCamera_m_SetStereoProjectionMatrix(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.Camera.StereoscopicEye _eye;translator.Get(L, 2, out _eye);
				UnityEngine.Matrix4x4 _matrix;translator.Get(L, 3, out _matrix);
				
				gen_to_be_invoked.SetStereoProjectionMatrix( _eye, _matrix );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineCamera_m_ResetStereoProjectionMatrices(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.ResetStereoProjectionMatrices(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineCamera_m_SetStereoViewMatrix(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.Camera.StereoscopicEye _eye;translator.Get(L, 2, out _eye);
				UnityEngine.Matrix4x4 _matrix;translator.Get(L, 3, out _matrix);
				
				gen_to_be_invoked.SetStereoViewMatrix( _eye, _matrix );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineCamera_m_ResetStereoViewMatrices(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.ResetStereoViewMatrices(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineCamera_m_GetAllCameras_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Camera[] _cameras = (UnityEngine.Camera[])translator.GetObject(L, 1, typeof(UnityEngine.Camera[]));
				
				int gen_ret = UnityEngine.Camera.GetAllCameras( _cameras );
				LuaAPI.xlua_pushinteger(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineCamera_m_RenderToCubemap(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.Cubemap>(L, 2)) 
			{
				UnityEngine.Cubemap _cubemap = (UnityEngine.Cubemap)translator.GetObject(L, 2, typeof(UnityEngine.Cubemap));
				
				bool gen_ret = gen_to_be_invoked.RenderToCubemap( _cubemap );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.RenderTexture>(L, 2)) 
			{
				UnityEngine.RenderTexture _cubemap = (UnityEngine.RenderTexture)translator.GetObject(L, 2, typeof(UnityEngine.RenderTexture));
				
				bool gen_ret = gen_to_be_invoked.RenderToCubemap( _cubemap );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 3&& translator.Assignable<UnityEngine.Cubemap>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
			{
				UnityEngine.Cubemap _cubemap = (UnityEngine.Cubemap)translator.GetObject(L, 2, typeof(UnityEngine.Cubemap));
				int _faceMask = LuaAPI.xlua_tointeger(L, 3);
				
				bool gen_ret = gen_to_be_invoked.RenderToCubemap( _cubemap, _faceMask );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 3&& translator.Assignable<UnityEngine.RenderTexture>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
			{
				UnityEngine.RenderTexture _cubemap = (UnityEngine.RenderTexture)translator.GetObject(L, 2, typeof(UnityEngine.RenderTexture));
				int _faceMask = LuaAPI.xlua_tointeger(L, 3);
				
				bool gen_ret = gen_to_be_invoked.RenderToCubemap( _cubemap, _faceMask );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 4&& translator.Assignable<UnityEngine.RenderTexture>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Camera.MonoOrStereoscopicEye>(L, 4)) 
			{
				UnityEngine.RenderTexture _cubemap = (UnityEngine.RenderTexture)translator.GetObject(L, 2, typeof(UnityEngine.RenderTexture));
				int _faceMask = LuaAPI.xlua_tointeger(L, 3);
				UnityEngine.Camera.MonoOrStereoscopicEye _stereoEye;translator.Get(L, 4, out _stereoEye);
				
				bool gen_ret = gen_to_be_invoked.RenderToCubemap( _cubemap, _faceMask, _stereoEye );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Camera.RenderToCubemap!");
            
        }
        
        int UnityEngineCamera_m_Render(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.Render(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineCamera_m_RenderWithShader(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.Shader _shader = (UnityEngine.Shader)translator.GetObject(L, 2, typeof(UnityEngine.Shader));
				string _replacementTag = LuaAPI.lua_tostring(L, 3);
				
				gen_to_be_invoked.RenderWithShader( _shader, _replacementTag );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineCamera_m_RenderDontRestore(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.RenderDontRestore(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineCamera_m_SetupCurrent_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Camera _cur = (UnityEngine.Camera)translator.GetObject(L, 1, typeof(UnityEngine.Camera));
				
				UnityEngine.Camera.SetupCurrent( _cur );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineCamera_m_CopyFrom(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.Camera _other = (UnityEngine.Camera)translator.GetObject(L, 2, typeof(UnityEngine.Camera));
				
				gen_to_be_invoked.CopyFrom( _other );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineCamera_m_RemoveCommandBuffers(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.Rendering.CameraEvent _evt;translator.Get(L, 2, out _evt);
				
				gen_to_be_invoked.RemoveCommandBuffers( _evt );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineCamera_m_RemoveAllCommandBuffers(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.RemoveAllCommandBuffers(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineCamera_m_AddCommandBuffer(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.Rendering.CameraEvent _evt;translator.Get(L, 2, out _evt);
				UnityEngine.Rendering.CommandBuffer _buffer = (UnityEngine.Rendering.CommandBuffer)translator.GetObject(L, 3, typeof(UnityEngine.Rendering.CommandBuffer));
				
				gen_to_be_invoked.AddCommandBuffer( _evt, _buffer );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineCamera_m_AddCommandBufferAsync(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.Rendering.CameraEvent _evt;translator.Get(L, 2, out _evt);
				UnityEngine.Rendering.CommandBuffer _buffer = (UnityEngine.Rendering.CommandBuffer)translator.GetObject(L, 3, typeof(UnityEngine.Rendering.CommandBuffer));
				UnityEngine.Rendering.ComputeQueueType _queueType;translator.Get(L, 4, out _queueType);
				
				gen_to_be_invoked.AddCommandBufferAsync( _evt, _buffer, _queueType );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineCamera_m_RemoveCommandBuffer(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.Rendering.CameraEvent _evt;translator.Get(L, 2, out _evt);
				UnityEngine.Rendering.CommandBuffer _buffer = (UnityEngine.Rendering.CommandBuffer)translator.GetObject(L, 3, typeof(UnityEngine.Rendering.CommandBuffer));
				
				gen_to_be_invoked.RemoveCommandBuffer( _evt, _buffer );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineCamera_m_GetCommandBuffers(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.Rendering.CameraEvent _evt;translator.Get(L, 2, out _evt);
				
				UnityEngine.Rendering.CommandBuffer[] gen_ret = gen_to_be_invoked.GetCommandBuffers( _evt );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineCamera_m_TryGetCullingParameters(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 1) 
			{
				UnityEngine.Rendering.ScriptableCullingParameters _cullingParameters;
				
				bool gen_ret = gen_to_be_invoked.TryGetCullingParameters( out _cullingParameters );
				LuaAPI.lua_pushboolean(L, gen_ret);
				translator.Push(L, _cullingParameters);
					
				
				
				
				return 2;
			}
			if(gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
			{
				bool _stereoAware = LuaAPI.lua_toboolean(L, 2);
				UnityEngine.Rendering.ScriptableCullingParameters _cullingParameters;
				
				bool gen_ret = gen_to_be_invoked.TryGetCullingParameters( _stereoAware, out _cullingParameters );
				LuaAPI.lua_pushboolean(L, gen_ret);
				translator.Push(L, _cullingParameters);
					
				
				
				
				return 2;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Camera.TryGetCullingParameters!");
            
        }
        
        
        
        
        int UnityEngineCamera_g_get_nearClipPlane(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.nearClipPlane);
            return 1;
        }
        
        int UnityEngineCamera_g_get_farClipPlane(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.farClipPlane);
            return 1;
        }
        
        int UnityEngineCamera_g_get_fieldOfView(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.fieldOfView);
            return 1;
        }
        
        int UnityEngineCamera_g_get_renderingPath(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.renderingPath);
            return 1;
        }
        
        int UnityEngineCamera_g_get_actualRenderingPath(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.actualRenderingPath);
            return 1;
        }
        
        int UnityEngineCamera_g_get_allowHDR(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.allowHDR);
            return 1;
        }
        
        int UnityEngineCamera_g_get_allowMSAA(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.allowMSAA);
            return 1;
        }
        
        int UnityEngineCamera_g_get_allowDynamicResolution(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.allowDynamicResolution);
            return 1;
        }
        
        int UnityEngineCamera_g_get_forceIntoRenderTexture(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.forceIntoRenderTexture);
            return 1;
        }
        
        int UnityEngineCamera_g_get_orthographicSize(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.orthographicSize);
            return 1;
        }
        
        int UnityEngineCamera_g_get_orthographic(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.orthographic);
            return 1;
        }
        
        int UnityEngineCamera_g_get_opaqueSortMode(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.opaqueSortMode);
            return 1;
        }
        
        int UnityEngineCamera_g_get_transparencySortMode(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.transparencySortMode);
            return 1;
        }
        
        int UnityEngineCamera_g_get_transparencySortAxis(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			translator.PushUnityEngineVector3(L, gen_to_be_invoked.transparencySortAxis);
            return 1;
        }
        
        int UnityEngineCamera_g_get_depth(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.depth);
            return 1;
        }
        
        int UnityEngineCamera_g_get_aspect(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.aspect);
            return 1;
        }
        
        int UnityEngineCamera_g_get_velocity(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			translator.PushUnityEngineVector3(L, gen_to_be_invoked.velocity);
            return 1;
        }
        
        int UnityEngineCamera_g_get_cullingMask(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.cullingMask);
            return 1;
        }
        
        int UnityEngineCamera_g_get_eventMask(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.eventMask);
            return 1;
        }
        
        int UnityEngineCamera_g_get_layerCullSpherical(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.layerCullSpherical);
            return 1;
        }
        
        int UnityEngineCamera_g_get_cameraType(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.cameraType);
            return 1;
        }
        
        int UnityEngineCamera_g_get_overrideSceneCullingMask(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushuint64(L, gen_to_be_invoked.overrideSceneCullingMask);
            return 1;
        }
        
        int UnityEngineCamera_g_get_layerCullDistances(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.layerCullDistances);
            return 1;
        }
        
        int UnityEngineCamera_g_get_useOcclusionCulling(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.useOcclusionCulling);
            return 1;
        }
        
        int UnityEngineCamera_g_get_cullingMatrix(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.cullingMatrix);
            return 1;
        }
        
        int UnityEngineCamera_g_get_backgroundColor(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			translator.PushUnityEngineColor(L, gen_to_be_invoked.backgroundColor);
            return 1;
        }
        
        int UnityEngineCamera_g_get_clearFlags(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			translator.PushUnityEngineCameraClearFlags(L, gen_to_be_invoked.clearFlags);
            return 1;
        }
        
        int UnityEngineCamera_g_get_depthTextureMode(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.depthTextureMode);
            return 1;
        }
        
        int UnityEngineCamera_g_get_clearStencilAfterLightingPass(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.clearStencilAfterLightingPass);
            return 1;
        }
        
        int UnityEngineCamera_g_get_usePhysicalProperties(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.usePhysicalProperties);
            return 1;
        }
        
        int UnityEngineCamera_g_get_sensorSize(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			translator.PushUnityEngineVector2(L, gen_to_be_invoked.sensorSize);
            return 1;
        }
        
        int UnityEngineCamera_g_get_lensShift(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			translator.PushUnityEngineVector2(L, gen_to_be_invoked.lensShift);
            return 1;
        }
        
        int UnityEngineCamera_g_get_focalLength(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.focalLength);
            return 1;
        }
        
        int UnityEngineCamera_g_get_gateFit(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.gateFit);
            return 1;
        }
        
        int UnityEngineCamera_g_get_rect(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.rect);
            return 1;
        }
        
        int UnityEngineCamera_g_get_pixelRect(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.pixelRect);
            return 1;
        }
        
        int UnityEngineCamera_g_get_pixelWidth(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.pixelWidth);
            return 1;
        }
        
        int UnityEngineCamera_g_get_pixelHeight(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.pixelHeight);
            return 1;
        }
        
        int UnityEngineCamera_g_get_scaledPixelWidth(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.scaledPixelWidth);
            return 1;
        }
        
        int UnityEngineCamera_g_get_scaledPixelHeight(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.scaledPixelHeight);
            return 1;
        }
        
        int UnityEngineCamera_g_get_targetTexture(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.targetTexture);
            return 1;
        }
        
        int UnityEngineCamera_g_get_activeTexture(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.activeTexture);
            return 1;
        }
        
        int UnityEngineCamera_g_get_targetDisplay(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.targetDisplay);
            return 1;
        }
        
        int UnityEngineCamera_g_get_cameraToWorldMatrix(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.cameraToWorldMatrix);
            return 1;
        }
        
        int UnityEngineCamera_g_get_worldToCameraMatrix(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.worldToCameraMatrix);
            return 1;
        }
        
        int UnityEngineCamera_g_get_projectionMatrix(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.projectionMatrix);
            return 1;
        }
        
        int UnityEngineCamera_g_get_nonJitteredProjectionMatrix(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.nonJitteredProjectionMatrix);
            return 1;
        }
        
        int UnityEngineCamera_g_get_useJitteredProjectionMatrixForTransparentRendering(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.useJitteredProjectionMatrixForTransparentRendering);
            return 1;
        }
        
        int UnityEngineCamera_g_get_previousViewProjectionMatrix(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.previousViewProjectionMatrix);
            return 1;
        }
        
        int UnityEngineCamera_g_get_main(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.Push(L, UnityEngine.Camera.main);
            return 1;
        }
        
        int UnityEngineCamera_g_get_current(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.Push(L, UnityEngine.Camera.current);
            return 1;
        }
        
        int UnityEngineCamera_g_get_scene(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.scene);
            return 1;
        }
        
        int UnityEngineCamera_g_get_stereoEnabled(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.stereoEnabled);
            return 1;
        }
        
        int UnityEngineCamera_g_get_stereoSeparation(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.stereoSeparation);
            return 1;
        }
        
        int UnityEngineCamera_g_get_stereoConvergence(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.stereoConvergence);
            return 1;
        }
        
        int UnityEngineCamera_g_get_areVRStereoViewMatricesWithinSingleCullTolerance(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.areVRStereoViewMatricesWithinSingleCullTolerance);
            return 1;
        }
        
        int UnityEngineCamera_g_get_stereoTargetEye(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.stereoTargetEye);
            return 1;
        }
        
        int UnityEngineCamera_g_get_stereoActiveEye(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.stereoActiveEye);
            return 1;
        }
        
        int UnityEngineCamera_g_get_allCamerasCount(RealStatePtr L, int gen_param_count) 
        {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.Camera.allCamerasCount);
            return 1;
        }
        
        int UnityEngineCamera_g_get_allCameras(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.Push(L, UnityEngine.Camera.allCameras);
            return 1;
        }
        
        int UnityEngineCamera_g_get_commandBufferCount(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.commandBufferCount);
            return 1;
        }
        
        int UnityEngineCamera_g_get_onPreCull(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.Push(L, UnityEngine.Camera.onPreCull);
            return 1;
        }
        
        int UnityEngineCamera_g_get_onPreRender(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.Push(L, UnityEngine.Camera.onPreRender);
            return 1;
        }
        
        int UnityEngineCamera_g_get_onPostRender(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.Push(L, UnityEngine.Camera.onPostRender);
            return 1;
        }
        
        
        
        int UnityEngineCamera_s_set_nearClipPlane(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.nearClipPlane = (float)LuaAPI.lua_tonumber(L, 2);
            
            return 0;
        }
        
        int UnityEngineCamera_s_set_farClipPlane(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.farClipPlane = (float)LuaAPI.lua_tonumber(L, 2);
            
            return 0;
        }
        
        int UnityEngineCamera_s_set_fieldOfView(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.fieldOfView = (float)LuaAPI.lua_tonumber(L, 2);
            
            return 0;
        }
        
        int UnityEngineCamera_s_set_renderingPath(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            UnityEngine.RenderingPath gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.renderingPath = gen_value;
            
            return 0;
        }
        
        int UnityEngineCamera_s_set_allowHDR(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.allowHDR = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineCamera_s_set_allowMSAA(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.allowMSAA = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineCamera_s_set_allowDynamicResolution(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.allowDynamicResolution = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineCamera_s_set_forceIntoRenderTexture(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.forceIntoRenderTexture = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineCamera_s_set_orthographicSize(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.orthographicSize = (float)LuaAPI.lua_tonumber(L, 2);
            
            return 0;
        }
        
        int UnityEngineCamera_s_set_orthographic(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.orthographic = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineCamera_s_set_opaqueSortMode(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            UnityEngine.Rendering.OpaqueSortMode gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.opaqueSortMode = gen_value;
            
            return 0;
        }
        
        int UnityEngineCamera_s_set_transparencySortMode(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            UnityEngine.TransparencySortMode gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.transparencySortMode = gen_value;
            
            return 0;
        }
        
        int UnityEngineCamera_s_set_transparencySortAxis(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.transparencySortAxis = gen_value;
            
            return 0;
        }
        
        int UnityEngineCamera_s_set_depth(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.depth = (float)LuaAPI.lua_tonumber(L, 2);
            
            return 0;
        }
        
        int UnityEngineCamera_s_set_aspect(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.aspect = (float)LuaAPI.lua_tonumber(L, 2);
            
            return 0;
        }
        
        int UnityEngineCamera_s_set_cullingMask(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.cullingMask = LuaAPI.xlua_tointeger(L, 2);
            
            return 0;
        }
        
        int UnityEngineCamera_s_set_eventMask(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.eventMask = LuaAPI.xlua_tointeger(L, 2);
            
            return 0;
        }
        
        int UnityEngineCamera_s_set_layerCullSpherical(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.layerCullSpherical = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineCamera_s_set_cameraType(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            UnityEngine.CameraType gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.cameraType = gen_value;
            
            return 0;
        }
        
        int UnityEngineCamera_s_set_overrideSceneCullingMask(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.overrideSceneCullingMask = LuaAPI.lua_touint64(L, 2);
            
            return 0;
        }
        
        int UnityEngineCamera_s_set_layerCullDistances(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.layerCullDistances = (float[])translator.GetObject(L, 2, typeof(float[]));
            
            return 0;
        }
        
        int UnityEngineCamera_s_set_useOcclusionCulling(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.useOcclusionCulling = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineCamera_s_set_cullingMatrix(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            UnityEngine.Matrix4x4 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.cullingMatrix = gen_value;
            
            return 0;
        }
        
        int UnityEngineCamera_s_set_backgroundColor(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            UnityEngine.Color gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.backgroundColor = gen_value;
            
            return 0;
        }
        
        int UnityEngineCamera_s_set_clearFlags(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            UnityEngine.CameraClearFlags gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.clearFlags = gen_value;
            
            return 0;
        }
        
        int UnityEngineCamera_s_set_depthTextureMode(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            UnityEngine.DepthTextureMode gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.depthTextureMode = gen_value;
            
            return 0;
        }
        
        int UnityEngineCamera_s_set_clearStencilAfterLightingPass(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.clearStencilAfterLightingPass = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineCamera_s_set_usePhysicalProperties(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.usePhysicalProperties = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineCamera_s_set_sensorSize(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.sensorSize = gen_value;
            
            return 0;
        }
        
        int UnityEngineCamera_s_set_lensShift(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.lensShift = gen_value;
            
            return 0;
        }
        
        int UnityEngineCamera_s_set_focalLength(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.focalLength = (float)LuaAPI.lua_tonumber(L, 2);
            
            return 0;
        }
        
        int UnityEngineCamera_s_set_gateFit(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            UnityEngine.Camera.GateFitMode gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.gateFit = gen_value;
            
            return 0;
        }
        
        int UnityEngineCamera_s_set_rect(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            UnityEngine.Rect gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.rect = gen_value;
            
            return 0;
        }
        
        int UnityEngineCamera_s_set_pixelRect(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            UnityEngine.Rect gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.pixelRect = gen_value;
            
            return 0;
        }
        
        int UnityEngineCamera_s_set_targetTexture(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.targetTexture = (UnityEngine.RenderTexture)translator.GetObject(L, 2, typeof(UnityEngine.RenderTexture));
            
            return 0;
        }
        
        int UnityEngineCamera_s_set_targetDisplay(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.targetDisplay = LuaAPI.xlua_tointeger(L, 2);
            
            return 0;
        }
        
        int UnityEngineCamera_s_set_worldToCameraMatrix(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            UnityEngine.Matrix4x4 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.worldToCameraMatrix = gen_value;
            
            return 0;
        }
        
        int UnityEngineCamera_s_set_projectionMatrix(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            UnityEngine.Matrix4x4 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.projectionMatrix = gen_value;
            
            return 0;
        }
        
        int UnityEngineCamera_s_set_nonJitteredProjectionMatrix(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            UnityEngine.Matrix4x4 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.nonJitteredProjectionMatrix = gen_value;
            
            return 0;
        }
        
        int UnityEngineCamera_s_set_useJitteredProjectionMatrixForTransparentRendering(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.useJitteredProjectionMatrixForTransparentRendering = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineCamera_s_set_scene(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            UnityEngine.SceneManagement.Scene gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.scene = gen_value;
            
            return 0;
        }
        
        int UnityEngineCamera_s_set_stereoSeparation(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.stereoSeparation = (float)LuaAPI.lua_tonumber(L, 2);
            
            return 0;
        }
        
        int UnityEngineCamera_s_set_stereoConvergence(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.stereoConvergence = (float)LuaAPI.lua_tonumber(L, 2);
            
            return 0;
        }
        
        int UnityEngineCamera_s_set_stereoTargetEye(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Camera gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            UnityEngine.StereoTargetEyeMask gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.stereoTargetEye = gen_value;
            
            return 0;
        }
        
        int UnityEngineCamera_s_set_onPreCull(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			UnityEngine.Camera.onPreCull = translator.GetDelegate<UnityEngine.Camera.CameraCallback>(L, 1);
            
            return 0;
        }
        
        int UnityEngineCamera_s_set_onPreRender(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			UnityEngine.Camera.onPreRender = translator.GetDelegate<UnityEngine.Camera.CameraCallback>(L, 1);
            
            return 0;
        }
        
        int UnityEngineCamera_s_set_onPostRender(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			UnityEngine.Camera.onPostRender = translator.GetDelegate<UnityEngine.Camera.CameraCallback>(L, 1);
            
            return 0;
        }
        
		
		
		
		
    }
}
