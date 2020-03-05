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
        public void __RegisterUnityEngineRenderer(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.Renderer);
			Utils.BeginObjectRegister(type, L, this, 0, 6, 29, 24);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HasPropertyBlock", UnityEngineRenderer_m_HasPropertyBlock);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetPropertyBlock", UnityEngineRenderer_m_SetPropertyBlock);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPropertyBlock", UnityEngineRenderer_m_GetPropertyBlock);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetMaterials", UnityEngineRenderer_m_GetMaterials);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetSharedMaterials", UnityEngineRenderer_m_GetSharedMaterials);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetClosestReflectionProbes", UnityEngineRenderer_m_GetClosestReflectionProbes);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "bounds", UnityEngineRenderer_g_get_bounds);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "enabled", UnityEngineRenderer_g_get_enabled);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isVisible", UnityEngineRenderer_g_get_isVisible);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "shadowCastingMode", UnityEngineRenderer_g_get_shadowCastingMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "receiveShadows", UnityEngineRenderer_g_get_receiveShadows);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "forceRenderingOff", UnityEngineRenderer_g_get_forceRenderingOff);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "motionVectorGenerationMode", UnityEngineRenderer_g_get_motionVectorGenerationMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lightProbeUsage", UnityEngineRenderer_g_get_lightProbeUsage);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "reflectionProbeUsage", UnityEngineRenderer_g_get_reflectionProbeUsage);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "renderingLayerMask", UnityEngineRenderer_g_get_renderingLayerMask);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rendererPriority", UnityEngineRenderer_g_get_rendererPriority);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rayTracingMode", UnityEngineRenderer_g_get_rayTracingMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sortingLayerName", UnityEngineRenderer_g_get_sortingLayerName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sortingLayerID", UnityEngineRenderer_g_get_sortingLayerID);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sortingOrder", UnityEngineRenderer_g_get_sortingOrder);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "allowOcclusionWhenDynamic", UnityEngineRenderer_g_get_allowOcclusionWhenDynamic);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isPartOfStaticBatch", UnityEngineRenderer_g_get_isPartOfStaticBatch);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "worldToLocalMatrix", UnityEngineRenderer_g_get_worldToLocalMatrix);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "localToWorldMatrix", UnityEngineRenderer_g_get_localToWorldMatrix);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lightProbeProxyVolumeOverride", UnityEngineRenderer_g_get_lightProbeProxyVolumeOverride);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "probeAnchor", UnityEngineRenderer_g_get_probeAnchor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lightmapIndex", UnityEngineRenderer_g_get_lightmapIndex);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "realtimeLightmapIndex", UnityEngineRenderer_g_get_realtimeLightmapIndex);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lightmapScaleOffset", UnityEngineRenderer_g_get_lightmapScaleOffset);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "realtimeLightmapScaleOffset", UnityEngineRenderer_g_get_realtimeLightmapScaleOffset);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "materials", UnityEngineRenderer_g_get_materials);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "material", UnityEngineRenderer_g_get_material);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sharedMaterial", UnityEngineRenderer_g_get_sharedMaterial);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sharedMaterials", UnityEngineRenderer_g_get_sharedMaterials);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "enabled", UnityEngineRenderer_s_set_enabled);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "shadowCastingMode", UnityEngineRenderer_s_set_shadowCastingMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "receiveShadows", UnityEngineRenderer_s_set_receiveShadows);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "forceRenderingOff", UnityEngineRenderer_s_set_forceRenderingOff);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "motionVectorGenerationMode", UnityEngineRenderer_s_set_motionVectorGenerationMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "lightProbeUsage", UnityEngineRenderer_s_set_lightProbeUsage);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "reflectionProbeUsage", UnityEngineRenderer_s_set_reflectionProbeUsage);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "renderingLayerMask", UnityEngineRenderer_s_set_renderingLayerMask);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "rendererPriority", UnityEngineRenderer_s_set_rendererPriority);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "rayTracingMode", UnityEngineRenderer_s_set_rayTracingMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sortingLayerName", UnityEngineRenderer_s_set_sortingLayerName);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sortingLayerID", UnityEngineRenderer_s_set_sortingLayerID);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sortingOrder", UnityEngineRenderer_s_set_sortingOrder);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "allowOcclusionWhenDynamic", UnityEngineRenderer_s_set_allowOcclusionWhenDynamic);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "lightProbeProxyVolumeOverride", UnityEngineRenderer_s_set_lightProbeProxyVolumeOverride);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "probeAnchor", UnityEngineRenderer_s_set_probeAnchor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "lightmapIndex", UnityEngineRenderer_s_set_lightmapIndex);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "realtimeLightmapIndex", UnityEngineRenderer_s_set_realtimeLightmapIndex);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "lightmapScaleOffset", UnityEngineRenderer_s_set_lightmapScaleOffset);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "realtimeLightmapScaleOffset", UnityEngineRenderer_s_set_realtimeLightmapScaleOffset);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "materials", UnityEngineRenderer_s_set_materials);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "material", UnityEngineRenderer_s_set_material);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sharedMaterial", UnityEngineRenderer_s_set_sharedMaterial);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sharedMaterials", UnityEngineRenderer_s_set_sharedMaterials);
            
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineRenderer, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineRenderer(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			if(gen_param_count == 1)
			{
				
				UnityEngine.Renderer gen_ret = new UnityEngine.Renderer();
				translator.Push(L, gen_ret);
				
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Renderer constructor!");
            
        }
        
		
        
		
        
        
        
        
        int UnityEngineRenderer_m_HasPropertyBlock(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
            
			
			{
				
				bool gen_ret = gen_to_be_invoked.HasPropertyBlock(  );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineRenderer_m_SetPropertyBlock(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 2)) 
			{
				UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 2, typeof(UnityEngine.MaterialPropertyBlock));
				
				gen_to_be_invoked.SetPropertyBlock( _properties );
				
				
				
				return 0;
			}
			if(gen_param_count == 3&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
			{
				UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 2, typeof(UnityEngine.MaterialPropertyBlock));
				int _materialIndex = LuaAPI.xlua_tointeger(L, 3);
				
				gen_to_be_invoked.SetPropertyBlock( _properties, _materialIndex );
				
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Renderer.SetPropertyBlock!");
            
        }
        
        int UnityEngineRenderer_m_GetPropertyBlock(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 2)) 
			{
				UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 2, typeof(UnityEngine.MaterialPropertyBlock));
				
				gen_to_be_invoked.GetPropertyBlock( _properties );
				
				
				
				return 0;
			}
			if(gen_param_count == 3&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
			{
				UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 2, typeof(UnityEngine.MaterialPropertyBlock));
				int _materialIndex = LuaAPI.xlua_tointeger(L, 3);
				
				gen_to_be_invoked.GetPropertyBlock( _properties, _materialIndex );
				
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Renderer.GetPropertyBlock!");
            
        }
        
        int UnityEngineRenderer_m_GetMaterials(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
            
			
			{
				System.Collections.Generic.List<UnityEngine.Material> _m = (System.Collections.Generic.List<UnityEngine.Material>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Material>));
				
				gen_to_be_invoked.GetMaterials( _m );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineRenderer_m_GetSharedMaterials(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
            
			
			{
				System.Collections.Generic.List<UnityEngine.Material> _m = (System.Collections.Generic.List<UnityEngine.Material>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Material>));
				
				gen_to_be_invoked.GetSharedMaterials( _m );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineRenderer_m_GetClosestReflectionProbes(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
            
			
			{
				System.Collections.Generic.List<UnityEngine.Rendering.ReflectionProbeBlendInfo> _result = (System.Collections.Generic.List<UnityEngine.Rendering.ReflectionProbeBlendInfo>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Rendering.ReflectionProbeBlendInfo>));
				
				gen_to_be_invoked.GetClosestReflectionProbes( _result );
				
				
				
				return 0;
			}
			
            
        }
        
        
        
        
        int UnityEngineRenderer_g_get_bounds(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
			translator.PushUnityEngineBounds(L, gen_to_be_invoked.bounds);
            return 1;
        }
        
        int UnityEngineRenderer_g_get_enabled(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.enabled);
            return 1;
        }
        
        int UnityEngineRenderer_g_get_isVisible(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isVisible);
            return 1;
        }
        
        int UnityEngineRenderer_g_get_shadowCastingMode(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.shadowCastingMode);
            return 1;
        }
        
        int UnityEngineRenderer_g_get_receiveShadows(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.receiveShadows);
            return 1;
        }
        
        int UnityEngineRenderer_g_get_forceRenderingOff(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.forceRenderingOff);
            return 1;
        }
        
        int UnityEngineRenderer_g_get_motionVectorGenerationMode(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.motionVectorGenerationMode);
            return 1;
        }
        
        int UnityEngineRenderer_g_get_lightProbeUsage(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.lightProbeUsage);
            return 1;
        }
        
        int UnityEngineRenderer_g_get_reflectionProbeUsage(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.reflectionProbeUsage);
            return 1;
        }
        
        int UnityEngineRenderer_g_get_renderingLayerMask(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushuint(L, gen_to_be_invoked.renderingLayerMask);
            return 1;
        }
        
        int UnityEngineRenderer_g_get_rendererPriority(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.rendererPriority);
            return 1;
        }
        
        int UnityEngineRenderer_g_get_rayTracingMode(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.rayTracingMode);
            return 1;
        }
        
        int UnityEngineRenderer_g_get_sortingLayerName(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushstring(L, gen_to_be_invoked.sortingLayerName);
            return 1;
        }
        
        int UnityEngineRenderer_g_get_sortingLayerID(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.sortingLayerID);
            return 1;
        }
        
        int UnityEngineRenderer_g_get_sortingOrder(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.sortingOrder);
            return 1;
        }
        
        int UnityEngineRenderer_g_get_allowOcclusionWhenDynamic(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.allowOcclusionWhenDynamic);
            return 1;
        }
        
        int UnityEngineRenderer_g_get_isPartOfStaticBatch(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isPartOfStaticBatch);
            return 1;
        }
        
        int UnityEngineRenderer_g_get_worldToLocalMatrix(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.worldToLocalMatrix);
            return 1;
        }
        
        int UnityEngineRenderer_g_get_localToWorldMatrix(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.localToWorldMatrix);
            return 1;
        }
        
        int UnityEngineRenderer_g_get_lightProbeProxyVolumeOverride(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.lightProbeProxyVolumeOverride);
            return 1;
        }
        
        int UnityEngineRenderer_g_get_probeAnchor(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.probeAnchor);
            return 1;
        }
        
        int UnityEngineRenderer_g_get_lightmapIndex(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.lightmapIndex);
            return 1;
        }
        
        int UnityEngineRenderer_g_get_realtimeLightmapIndex(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.realtimeLightmapIndex);
            return 1;
        }
        
        int UnityEngineRenderer_g_get_lightmapScaleOffset(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
			translator.PushUnityEngineVector4(L, gen_to_be_invoked.lightmapScaleOffset);
            return 1;
        }
        
        int UnityEngineRenderer_g_get_realtimeLightmapScaleOffset(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
			translator.PushUnityEngineVector4(L, gen_to_be_invoked.realtimeLightmapScaleOffset);
            return 1;
        }
        
        int UnityEngineRenderer_g_get_materials(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.materials);
            return 1;
        }
        
        int UnityEngineRenderer_g_get_material(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.material);
            return 1;
        }
        
        int UnityEngineRenderer_g_get_sharedMaterial(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.sharedMaterial);
            return 1;
        }
        
        int UnityEngineRenderer_g_get_sharedMaterials(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.sharedMaterials);
            return 1;
        }
        
        
        
        int UnityEngineRenderer_s_set_enabled(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.enabled = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineRenderer_s_set_shadowCastingMode(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
            UnityEngine.Rendering.ShadowCastingMode gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.shadowCastingMode = gen_value;
            
            return 0;
        }
        
        int UnityEngineRenderer_s_set_receiveShadows(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.receiveShadows = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineRenderer_s_set_forceRenderingOff(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.forceRenderingOff = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineRenderer_s_set_motionVectorGenerationMode(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
            UnityEngine.MotionVectorGenerationMode gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.motionVectorGenerationMode = gen_value;
            
            return 0;
        }
        
        int UnityEngineRenderer_s_set_lightProbeUsage(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
            UnityEngine.Rendering.LightProbeUsage gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.lightProbeUsage = gen_value;
            
            return 0;
        }
        
        int UnityEngineRenderer_s_set_reflectionProbeUsage(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
            UnityEngine.Rendering.ReflectionProbeUsage gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.reflectionProbeUsage = gen_value;
            
            return 0;
        }
        
        int UnityEngineRenderer_s_set_renderingLayerMask(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.renderingLayerMask = LuaAPI.xlua_touint(L, 2);
            
            return 0;
        }
        
        int UnityEngineRenderer_s_set_rendererPriority(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.rendererPriority = LuaAPI.xlua_tointeger(L, 2);
            
            return 0;
        }
        
        int UnityEngineRenderer_s_set_rayTracingMode(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
            UnityEngine.Experimental.Rendering.RayTracingMode gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.rayTracingMode = gen_value;
            
            return 0;
        }
        
        int UnityEngineRenderer_s_set_sortingLayerName(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.sortingLayerName = LuaAPI.lua_tostring(L, 2);
            
            return 0;
        }
        
        int UnityEngineRenderer_s_set_sortingLayerID(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.sortingLayerID = LuaAPI.xlua_tointeger(L, 2);
            
            return 0;
        }
        
        int UnityEngineRenderer_s_set_sortingOrder(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.sortingOrder = LuaAPI.xlua_tointeger(L, 2);
            
            return 0;
        }
        
        int UnityEngineRenderer_s_set_allowOcclusionWhenDynamic(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.allowOcclusionWhenDynamic = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineRenderer_s_set_lightProbeProxyVolumeOverride(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.lightProbeProxyVolumeOverride = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            return 0;
        }
        
        int UnityEngineRenderer_s_set_probeAnchor(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.probeAnchor = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
            
            return 0;
        }
        
        int UnityEngineRenderer_s_set_lightmapIndex(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.lightmapIndex = LuaAPI.xlua_tointeger(L, 2);
            
            return 0;
        }
        
        int UnityEngineRenderer_s_set_realtimeLightmapIndex(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.realtimeLightmapIndex = LuaAPI.xlua_tointeger(L, 2);
            
            return 0;
        }
        
        int UnityEngineRenderer_s_set_lightmapScaleOffset(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
            UnityEngine.Vector4 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.lightmapScaleOffset = gen_value;
            
            return 0;
        }
        
        int UnityEngineRenderer_s_set_realtimeLightmapScaleOffset(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
            UnityEngine.Vector4 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.realtimeLightmapScaleOffset = gen_value;
            
            return 0;
        }
        
        int UnityEngineRenderer_s_set_materials(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.materials = (UnityEngine.Material[])translator.GetObject(L, 2, typeof(UnityEngine.Material[]));
            
            return 0;
        }
        
        int UnityEngineRenderer_s_set_material(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.material = (UnityEngine.Material)translator.GetObject(L, 2, typeof(UnityEngine.Material));
            
            return 0;
        }
        
        int UnityEngineRenderer_s_set_sharedMaterial(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.sharedMaterial = (UnityEngine.Material)translator.GetObject(L, 2, typeof(UnityEngine.Material));
            
            return 0;
        }
        
        int UnityEngineRenderer_s_set_sharedMaterials(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Renderer gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.sharedMaterials = (UnityEngine.Material[])translator.GetObject(L, 2, typeof(UnityEngine.Material[]));
            
            return 0;
        }
        
		
		
		
		
    }
}
