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
        public void __RegisterTSLuaFrameworkToolUIEvent(RealStatePtr L) 
        {
		    System.Type type = typeof(TSLuaFramework.Tool.UIEvent);
			Utils.BeginObjectRegister(type, L, this, 0, 7, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Destroy", TSLuaFrameworkToolUIEvent_m_Destroy);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddPointerEvent", TSLuaFrameworkToolUIEvent_m_AddPointerEvent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddBaseEvent", TSLuaFrameworkToolUIEvent_m_AddBaseEvent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddAxisEvent", TSLuaFrameworkToolUIEvent_m_AddAxisEvent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemovePointerEvent", TSLuaFrameworkToolUIEvent_m_RemovePointerEvent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveBaseEvent", TSLuaFrameworkToolUIEvent_m_RemoveBaseEvent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveAxisEvent", TSLuaFrameworkToolUIEvent_m_RemoveAxisEvent);
			
			
			
			
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceTSLuaFrameworkToolUIEvent, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceTSLuaFrameworkToolUIEvent(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			if(gen_param_count == 2 && translator.Assignable<UnityEngine.GameObject>(L, 2))
			{
				UnityEngine.GameObject _obj = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
				
				TSLuaFramework.Tool.UIEvent gen_ret = new TSLuaFramework.Tool.UIEvent(_obj);
				translator.Push(L, gen_ret);
				
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to TSLuaFramework.Tool.UIEvent constructor!");
            
        }
        
		
        
		
        
        
        
        
        int TSLuaFrameworkToolUIEvent_m_Destroy(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            TSLuaFramework.Tool.UIEvent gen_to_be_invoked = (TSLuaFramework.Tool.UIEvent)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.Destroy(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int TSLuaFrameworkToolUIEvent_m_AddPointerEvent(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            TSLuaFramework.Tool.UIEvent gen_to_be_invoked = (TSLuaFramework.Tool.UIEvent)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.EventSystems.EventTriggerType _triggerType;translator.Get(L, 2, out _triggerType);
				XLua.LuaTable _value = (XLua.LuaTable)translator.GetObject(L, 3, typeof(XLua.LuaTable));
				
				gen_to_be_invoked.AddPointerEvent( _triggerType, _value );
				
				
				
				return 0;
			}
			
            
        }
        
        int TSLuaFrameworkToolUIEvent_m_AddBaseEvent(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            TSLuaFramework.Tool.UIEvent gen_to_be_invoked = (TSLuaFramework.Tool.UIEvent)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.EventSystems.EventTriggerType _triggerType;translator.Get(L, 2, out _triggerType);
				XLua.LuaTable _value = (XLua.LuaTable)translator.GetObject(L, 3, typeof(XLua.LuaTable));
				
				gen_to_be_invoked.AddBaseEvent( _triggerType, _value );
				
				
				
				return 0;
			}
			
            
        }
        
        int TSLuaFrameworkToolUIEvent_m_AddAxisEvent(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            TSLuaFramework.Tool.UIEvent gen_to_be_invoked = (TSLuaFramework.Tool.UIEvent)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.EventSystems.EventTriggerType _triggerType;translator.Get(L, 2, out _triggerType);
				XLua.LuaTable _value = (XLua.LuaTable)translator.GetObject(L, 3, typeof(XLua.LuaTable));
				
				gen_to_be_invoked.AddAxisEvent( _triggerType, _value );
				
				
				
				return 0;
			}
			
            
        }
        
        int TSLuaFrameworkToolUIEvent_m_RemovePointerEvent(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            TSLuaFramework.Tool.UIEvent gen_to_be_invoked = (TSLuaFramework.Tool.UIEvent)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.EventSystems.EventTriggerType _triggerType;translator.Get(L, 2, out _triggerType);
				XLua.LuaTable _value = (XLua.LuaTable)translator.GetObject(L, 3, typeof(XLua.LuaTable));
				
				gen_to_be_invoked.RemovePointerEvent( _triggerType, _value );
				
				
				
				return 0;
			}
			
            
        }
        
        int TSLuaFrameworkToolUIEvent_m_RemoveBaseEvent(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            TSLuaFramework.Tool.UIEvent gen_to_be_invoked = (TSLuaFramework.Tool.UIEvent)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.EventSystems.EventTriggerType _triggerType;translator.Get(L, 2, out _triggerType);
				XLua.LuaTable _value = (XLua.LuaTable)translator.GetObject(L, 3, typeof(XLua.LuaTable));
				
				gen_to_be_invoked.RemoveBaseEvent( _triggerType, _value );
				
				
				
				return 0;
			}
			
            
        }
        
        int TSLuaFrameworkToolUIEvent_m_RemoveAxisEvent(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            TSLuaFramework.Tool.UIEvent gen_to_be_invoked = (TSLuaFramework.Tool.UIEvent)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.EventSystems.EventTriggerType _triggerType;translator.Get(L, 2, out _triggerType);
				XLua.LuaTable _value = (XLua.LuaTable)translator.GetObject(L, 3, typeof(XLua.LuaTable));
				
				gen_to_be_invoked.RemoveAxisEvent( _triggerType, _value );
				
				
				
				return 0;
			}
			
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
