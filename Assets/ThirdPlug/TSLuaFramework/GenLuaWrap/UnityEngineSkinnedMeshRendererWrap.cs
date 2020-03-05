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
        public void __RegisterUnityEngineSkinnedMeshRenderer(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.SkinnedMeshRenderer);
			Utils.BeginObjectRegister(type, L, this, 0, 3, 8, 8);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetBlendShapeWeight", UnityEngineSkinnedMeshRenderer_m_GetBlendShapeWeight);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetBlendShapeWeight", UnityEngineSkinnedMeshRenderer_m_SetBlendShapeWeight);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "BakeMesh", UnityEngineSkinnedMeshRenderer_m_BakeMesh);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "quality", UnityEngineSkinnedMeshRenderer_g_get_quality);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "updateWhenOffscreen", UnityEngineSkinnedMeshRenderer_g_get_updateWhenOffscreen);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "forceMatrixRecalculationPerRender", UnityEngineSkinnedMeshRenderer_g_get_forceMatrixRecalculationPerRender);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rootBone", UnityEngineSkinnedMeshRenderer_g_get_rootBone);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "bones", UnityEngineSkinnedMeshRenderer_g_get_bones);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sharedMesh", UnityEngineSkinnedMeshRenderer_g_get_sharedMesh);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "skinnedMotionVectors", UnityEngineSkinnedMeshRenderer_g_get_skinnedMotionVectors);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "localBounds", UnityEngineSkinnedMeshRenderer_g_get_localBounds);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "quality", UnityEngineSkinnedMeshRenderer_s_set_quality);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "updateWhenOffscreen", UnityEngineSkinnedMeshRenderer_s_set_updateWhenOffscreen);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "forceMatrixRecalculationPerRender", UnityEngineSkinnedMeshRenderer_s_set_forceMatrixRecalculationPerRender);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "rootBone", UnityEngineSkinnedMeshRenderer_s_set_rootBone);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "bones", UnityEngineSkinnedMeshRenderer_s_set_bones);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sharedMesh", UnityEngineSkinnedMeshRenderer_s_set_sharedMesh);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "skinnedMotionVectors", UnityEngineSkinnedMeshRenderer_s_set_skinnedMotionVectors);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "localBounds", UnityEngineSkinnedMeshRenderer_s_set_localBounds);
            
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineSkinnedMeshRenderer, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineSkinnedMeshRenderer(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			if(gen_param_count == 1)
			{
				
				UnityEngine.SkinnedMeshRenderer gen_ret = new UnityEngine.SkinnedMeshRenderer();
				translator.Push(L, gen_ret);
				
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.SkinnedMeshRenderer constructor!");
            
        }
        
		
        
		
        
        
        
        
        int UnityEngineSkinnedMeshRenderer_m_GetBlendShapeWeight(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.SkinnedMeshRenderer gen_to_be_invoked = (UnityEngine.SkinnedMeshRenderer)translator.FastGetCSObj(L, 1);
            
			
			{
				int _index = LuaAPI.xlua_tointeger(L, 2);
				
				float gen_ret = gen_to_be_invoked.GetBlendShapeWeight( _index );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineSkinnedMeshRenderer_m_SetBlendShapeWeight(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.SkinnedMeshRenderer gen_to_be_invoked = (UnityEngine.SkinnedMeshRenderer)translator.FastGetCSObj(L, 1);
            
			
			{
				int _index = LuaAPI.xlua_tointeger(L, 2);
				float _value = (float)LuaAPI.lua_tonumber(L, 3);
				
				gen_to_be_invoked.SetBlendShapeWeight( _index, _value );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineSkinnedMeshRenderer_m_BakeMesh(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.SkinnedMeshRenderer gen_to_be_invoked = (UnityEngine.SkinnedMeshRenderer)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 2, typeof(UnityEngine.Mesh));
				
				gen_to_be_invoked.BakeMesh( _mesh );
				
				
				
				return 0;
			}
			
            
        }
        
        
        
        
        int UnityEngineSkinnedMeshRenderer_g_get_quality(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.SkinnedMeshRenderer gen_to_be_invoked = (UnityEngine.SkinnedMeshRenderer)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.quality);
            return 1;
        }
        
        int UnityEngineSkinnedMeshRenderer_g_get_updateWhenOffscreen(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.SkinnedMeshRenderer gen_to_be_invoked = (UnityEngine.SkinnedMeshRenderer)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.updateWhenOffscreen);
            return 1;
        }
        
        int UnityEngineSkinnedMeshRenderer_g_get_forceMatrixRecalculationPerRender(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.SkinnedMeshRenderer gen_to_be_invoked = (UnityEngine.SkinnedMeshRenderer)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.forceMatrixRecalculationPerRender);
            return 1;
        }
        
        int UnityEngineSkinnedMeshRenderer_g_get_rootBone(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.SkinnedMeshRenderer gen_to_be_invoked = (UnityEngine.SkinnedMeshRenderer)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.rootBone);
            return 1;
        }
        
        int UnityEngineSkinnedMeshRenderer_g_get_bones(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.SkinnedMeshRenderer gen_to_be_invoked = (UnityEngine.SkinnedMeshRenderer)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.bones);
            return 1;
        }
        
        int UnityEngineSkinnedMeshRenderer_g_get_sharedMesh(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.SkinnedMeshRenderer gen_to_be_invoked = (UnityEngine.SkinnedMeshRenderer)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.sharedMesh);
            return 1;
        }
        
        int UnityEngineSkinnedMeshRenderer_g_get_skinnedMotionVectors(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.SkinnedMeshRenderer gen_to_be_invoked = (UnityEngine.SkinnedMeshRenderer)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.skinnedMotionVectors);
            return 1;
        }
        
        int UnityEngineSkinnedMeshRenderer_g_get_localBounds(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.SkinnedMeshRenderer gen_to_be_invoked = (UnityEngine.SkinnedMeshRenderer)translator.FastGetCSObj(L, 1);
			translator.PushUnityEngineBounds(L, gen_to_be_invoked.localBounds);
            return 1;
        }
        
        
        
        int UnityEngineSkinnedMeshRenderer_s_set_quality(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.SkinnedMeshRenderer gen_to_be_invoked = (UnityEngine.SkinnedMeshRenderer)translator.FastGetCSObj(L, 1);
            UnityEngine.SkinQuality gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.quality = gen_value;
            
            return 0;
        }
        
        int UnityEngineSkinnedMeshRenderer_s_set_updateWhenOffscreen(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.SkinnedMeshRenderer gen_to_be_invoked = (UnityEngine.SkinnedMeshRenderer)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.updateWhenOffscreen = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineSkinnedMeshRenderer_s_set_forceMatrixRecalculationPerRender(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.SkinnedMeshRenderer gen_to_be_invoked = (UnityEngine.SkinnedMeshRenderer)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.forceMatrixRecalculationPerRender = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineSkinnedMeshRenderer_s_set_rootBone(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.SkinnedMeshRenderer gen_to_be_invoked = (UnityEngine.SkinnedMeshRenderer)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.rootBone = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
            
            return 0;
        }
        
        int UnityEngineSkinnedMeshRenderer_s_set_bones(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.SkinnedMeshRenderer gen_to_be_invoked = (UnityEngine.SkinnedMeshRenderer)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.bones = (UnityEngine.Transform[])translator.GetObject(L, 2, typeof(UnityEngine.Transform[]));
            
            return 0;
        }
        
        int UnityEngineSkinnedMeshRenderer_s_set_sharedMesh(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.SkinnedMeshRenderer gen_to_be_invoked = (UnityEngine.SkinnedMeshRenderer)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.sharedMesh = (UnityEngine.Mesh)translator.GetObject(L, 2, typeof(UnityEngine.Mesh));
            
            return 0;
        }
        
        int UnityEngineSkinnedMeshRenderer_s_set_skinnedMotionVectors(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.SkinnedMeshRenderer gen_to_be_invoked = (UnityEngine.SkinnedMeshRenderer)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.skinnedMotionVectors = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineSkinnedMeshRenderer_s_set_localBounds(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.SkinnedMeshRenderer gen_to_be_invoked = (UnityEngine.SkinnedMeshRenderer)translator.FastGetCSObj(L, 1);
            UnityEngine.Bounds gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.localBounds = gen_value;
            
            return 0;
        }
        
		
		
		
		
    }
}
