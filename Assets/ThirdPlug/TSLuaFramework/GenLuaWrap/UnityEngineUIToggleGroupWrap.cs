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
        public void __RegisterUnityEngineUIToggleGroup(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.UI.ToggleGroup);
			Utils.BeginObjectRegister(type, L, this, 0, 7, 1, 1);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "NotifyToggleOn", UnityEngineUIToggleGroup_m_NotifyToggleOn);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UnregisterToggle", UnityEngineUIToggleGroup_m_UnregisterToggle);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RegisterToggle", UnityEngineUIToggleGroup_m_RegisterToggle);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EnsureValidState", UnityEngineUIToggleGroup_m_EnsureValidState);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AnyTogglesOn", UnityEngineUIToggleGroup_m_AnyTogglesOn);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ActiveToggles", UnityEngineUIToggleGroup_m_ActiveToggles);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetAllTogglesOff", UnityEngineUIToggleGroup_m_SetAllTogglesOff);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "allowSwitchOff", UnityEngineUIToggleGroup_g_get_allowSwitchOff);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "allowSwitchOff", UnityEngineUIToggleGroup_s_set_allowSwitchOff);
            
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineUIToggleGroup, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineUIToggleGroup(RealStatePtr L, int gen_param_count) 
        {
            return LuaAPI.luaL_error(L, "UnityEngine.UI.ToggleGroup does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        int UnityEngineUIToggleGroup_m_NotifyToggleOn(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.ToggleGroup gen_to_be_invoked = (UnityEngine.UI.ToggleGroup)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 3&& translator.Assignable<UnityEngine.UI.Toggle>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
			{
				UnityEngine.UI.Toggle _toggle = (UnityEngine.UI.Toggle)translator.GetObject(L, 2, typeof(UnityEngine.UI.Toggle));
				bool _sendCallback = LuaAPI.lua_toboolean(L, 3);
				
				gen_to_be_invoked.NotifyToggleOn( _toggle, _sendCallback );
				
				
				
				return 0;
			}
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.UI.Toggle>(L, 2)) 
			{
				UnityEngine.UI.Toggle _toggle = (UnityEngine.UI.Toggle)translator.GetObject(L, 2, typeof(UnityEngine.UI.Toggle));
				
				gen_to_be_invoked.NotifyToggleOn( _toggle );
				
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.UI.ToggleGroup.NotifyToggleOn!");
            
        }
        
        int UnityEngineUIToggleGroup_m_UnregisterToggle(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.ToggleGroup gen_to_be_invoked = (UnityEngine.UI.ToggleGroup)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.UI.Toggle _toggle = (UnityEngine.UI.Toggle)translator.GetObject(L, 2, typeof(UnityEngine.UI.Toggle));
				
				gen_to_be_invoked.UnregisterToggle( _toggle );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIToggleGroup_m_RegisterToggle(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.ToggleGroup gen_to_be_invoked = (UnityEngine.UI.ToggleGroup)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.UI.Toggle _toggle = (UnityEngine.UI.Toggle)translator.GetObject(L, 2, typeof(UnityEngine.UI.Toggle));
				
				gen_to_be_invoked.RegisterToggle( _toggle );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIToggleGroup_m_EnsureValidState(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.ToggleGroup gen_to_be_invoked = (UnityEngine.UI.ToggleGroup)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.EnsureValidState(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIToggleGroup_m_AnyTogglesOn(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.ToggleGroup gen_to_be_invoked = (UnityEngine.UI.ToggleGroup)translator.FastGetCSObj(L, 1);
            
			
			{
				
				bool gen_ret = gen_to_be_invoked.AnyTogglesOn(  );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineUIToggleGroup_m_ActiveToggles(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.ToggleGroup gen_to_be_invoked = (UnityEngine.UI.ToggleGroup)translator.FastGetCSObj(L, 1);
            
			
			{
				
				System.Collections.Generic.IEnumerable<UnityEngine.UI.Toggle> gen_ret = gen_to_be_invoked.ActiveToggles(  );
				translator.PushAny(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineUIToggleGroup_m_SetAllTogglesOff(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.ToggleGroup gen_to_be_invoked = (UnityEngine.UI.ToggleGroup)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
			{
				bool _sendCallback = LuaAPI.lua_toboolean(L, 2);
				
				gen_to_be_invoked.SetAllTogglesOff( _sendCallback );
				
				
				
				return 0;
			}
			if(gen_param_count == 1) 
			{
				
				gen_to_be_invoked.SetAllTogglesOff(  );
				
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.UI.ToggleGroup.SetAllTogglesOff!");
            
        }
        
        
        
        
        int UnityEngineUIToggleGroup_g_get_allowSwitchOff(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.ToggleGroup gen_to_be_invoked = (UnityEngine.UI.ToggleGroup)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.allowSwitchOff);
            return 1;
        }
        
        
        
        int UnityEngineUIToggleGroup_s_set_allowSwitchOff(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.ToggleGroup gen_to_be_invoked = (UnityEngine.UI.ToggleGroup)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.allowSwitchOff = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
		
		
		
		
    }
}
