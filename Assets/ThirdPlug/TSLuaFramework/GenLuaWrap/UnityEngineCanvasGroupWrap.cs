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
        public void __RegisterUnityEngineCanvasGroup(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.CanvasGroup);
			Utils.BeginObjectRegister(type, L, this, 0, 1, 4, 4);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsRaycastLocationValid", UnityEngineCanvasGroup_m_IsRaycastLocationValid);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "alpha", UnityEngineCanvasGroup_g_get_alpha);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "interactable", UnityEngineCanvasGroup_g_get_interactable);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "blocksRaycasts", UnityEngineCanvasGroup_g_get_blocksRaycasts);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ignoreParentGroups", UnityEngineCanvasGroup_g_get_ignoreParentGroups);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "alpha", UnityEngineCanvasGroup_s_set_alpha);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "interactable", UnityEngineCanvasGroup_s_set_interactable);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "blocksRaycasts", UnityEngineCanvasGroup_s_set_blocksRaycasts);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ignoreParentGroups", UnityEngineCanvasGroup_s_set_ignoreParentGroups);
            
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineCanvasGroup, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineCanvasGroup(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			if(gen_param_count == 1)
			{
				
				UnityEngine.CanvasGroup gen_ret = new UnityEngine.CanvasGroup();
				translator.Push(L, gen_ret);
				
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.CanvasGroup constructor!");
            
        }
        
		
        
		
        
        
        
        
        int UnityEngineCanvasGroup_m_IsRaycastLocationValid(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.CanvasGroup gen_to_be_invoked = (UnityEngine.CanvasGroup)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.Vector2 _sp;translator.Get(L, 2, out _sp);
				UnityEngine.Camera _eventCamera = (UnityEngine.Camera)translator.GetObject(L, 3, typeof(UnityEngine.Camera));
				
				bool gen_ret = gen_to_be_invoked.IsRaycastLocationValid( _sp, _eventCamera );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        
        
        
        int UnityEngineCanvasGroup_g_get_alpha(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.CanvasGroup gen_to_be_invoked = (UnityEngine.CanvasGroup)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.alpha);
            return 1;
        }
        
        int UnityEngineCanvasGroup_g_get_interactable(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.CanvasGroup gen_to_be_invoked = (UnityEngine.CanvasGroup)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.interactable);
            return 1;
        }
        
        int UnityEngineCanvasGroup_g_get_blocksRaycasts(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.CanvasGroup gen_to_be_invoked = (UnityEngine.CanvasGroup)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.blocksRaycasts);
            return 1;
        }
        
        int UnityEngineCanvasGroup_g_get_ignoreParentGroups(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.CanvasGroup gen_to_be_invoked = (UnityEngine.CanvasGroup)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.ignoreParentGroups);
            return 1;
        }
        
        
        
        int UnityEngineCanvasGroup_s_set_alpha(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.CanvasGroup gen_to_be_invoked = (UnityEngine.CanvasGroup)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.alpha = (float)LuaAPI.lua_tonumber(L, 2);
            
            return 0;
        }
        
        int UnityEngineCanvasGroup_s_set_interactable(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.CanvasGroup gen_to_be_invoked = (UnityEngine.CanvasGroup)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.interactable = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineCanvasGroup_s_set_blocksRaycasts(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.CanvasGroup gen_to_be_invoked = (UnityEngine.CanvasGroup)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.blocksRaycasts = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineCanvasGroup_s_set_ignoreParentGroups(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.CanvasGroup gen_to_be_invoked = (UnityEngine.CanvasGroup)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.ignoreParentGroups = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
		
		
		
		
    }
}
