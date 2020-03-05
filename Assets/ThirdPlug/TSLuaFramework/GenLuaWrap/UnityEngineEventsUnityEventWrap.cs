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
        public void __RegisterUnityEngineEventsUnityEvent(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.Events.UnityEvent);
			Utils.BeginObjectRegister(type, L, this, 0, 3, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddListener", UnityEngineEventsUnityEvent_m_AddListener);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveListener", UnityEngineEventsUnityEvent_m_RemoveListener);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Invoke", UnityEngineEventsUnityEvent_m_Invoke);
			
			
			
			
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineEventsUnityEvent, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineEventsUnityEvent(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			if(gen_param_count == 1)
			{
				
				UnityEngine.Events.UnityEvent gen_ret = new UnityEngine.Events.UnityEvent();
				translator.Push(L, gen_ret);
				
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Events.UnityEvent constructor!");
            
        }
        
		
        
		
        
        
        
        
        int UnityEngineEventsUnityEvent_m_AddListener(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Events.UnityEvent gen_to_be_invoked = (UnityEngine.Events.UnityEvent)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.Events.UnityAction _call = translator.GetDelegate<UnityEngine.Events.UnityAction>(L, 2);
				
				gen_to_be_invoked.AddListener( _call );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineEventsUnityEvent_m_RemoveListener(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Events.UnityEvent gen_to_be_invoked = (UnityEngine.Events.UnityEvent)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.Events.UnityAction _call = translator.GetDelegate<UnityEngine.Events.UnityAction>(L, 2);
				
				gen_to_be_invoked.RemoveListener( _call );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineEventsUnityEvent_m_Invoke(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Events.UnityEvent gen_to_be_invoked = (UnityEngine.Events.UnityEvent)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.Invoke(  );
				
				
				
				return 0;
			}
			
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
