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
        public void __RegisterUnityEngineEventSystemsBaseEventData(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.EventSystems.BaseEventData);
			Utils.BeginObjectRegister(type, L, this, 0, 0, 2, 1);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "currentInputModule", UnityEngineEventSystemsBaseEventData_g_get_currentInputModule);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "selectedObject", UnityEngineEventSystemsBaseEventData_g_get_selectedObject);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "selectedObject", UnityEngineEventSystemsBaseEventData_s_set_selectedObject);
            
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineEventSystemsBaseEventData, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineEventSystemsBaseEventData(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			if(gen_param_count == 2 && translator.Assignable<UnityEngine.EventSystems.EventSystem>(L, 2))
			{
				UnityEngine.EventSystems.EventSystem _eventSystem = (UnityEngine.EventSystems.EventSystem)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.EventSystem));
				
				UnityEngine.EventSystems.BaseEventData gen_ret = new UnityEngine.EventSystems.BaseEventData(_eventSystem);
				translator.Push(L, gen_ret);
				
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.EventSystems.BaseEventData constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        int UnityEngineEventSystemsBaseEventData_g_get_currentInputModule(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.EventSystems.BaseEventData gen_to_be_invoked = (UnityEngine.EventSystems.BaseEventData)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.currentInputModule);
            return 1;
        }
        
        int UnityEngineEventSystemsBaseEventData_g_get_selectedObject(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.EventSystems.BaseEventData gen_to_be_invoked = (UnityEngine.EventSystems.BaseEventData)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.selectedObject);
            return 1;
        }
        
        
        
        int UnityEngineEventSystemsBaseEventData_s_set_selectedObject(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.EventSystems.BaseEventData gen_to_be_invoked = (UnityEngine.EventSystems.BaseEventData)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.selectedObject = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            return 0;
        }
        
		
		
		
		
    }
}
