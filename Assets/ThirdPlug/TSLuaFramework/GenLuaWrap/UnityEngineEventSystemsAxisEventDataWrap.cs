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
        public void __RegisterUnityEngineEventSystemsAxisEventData(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.EventSystems.AxisEventData);
			Utils.BeginObjectRegister(type, L, this, 0, 0, 2, 2);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "moveVector", UnityEngineEventSystemsAxisEventData_g_get_moveVector);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "moveDir", UnityEngineEventSystemsAxisEventData_g_get_moveDir);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "moveVector", UnityEngineEventSystemsAxisEventData_s_set_moveVector);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "moveDir", UnityEngineEventSystemsAxisEventData_s_set_moveDir);
            
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineEventSystemsAxisEventData, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineEventSystemsAxisEventData(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			if(gen_param_count == 2 && translator.Assignable<UnityEngine.EventSystems.EventSystem>(L, 2))
			{
				UnityEngine.EventSystems.EventSystem _eventSystem = (UnityEngine.EventSystems.EventSystem)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.EventSystem));
				
				UnityEngine.EventSystems.AxisEventData gen_ret = new UnityEngine.EventSystems.AxisEventData(_eventSystem);
				translator.Push(L, gen_ret);
				
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.EventSystems.AxisEventData constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        int UnityEngineEventSystemsAxisEventData_g_get_moveVector(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.EventSystems.AxisEventData gen_to_be_invoked = (UnityEngine.EventSystems.AxisEventData)translator.FastGetCSObj(L, 1);
			translator.PushUnityEngineVector2(L, gen_to_be_invoked.moveVector);
            return 1;
        }
        
        int UnityEngineEventSystemsAxisEventData_g_get_moveDir(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.EventSystems.AxisEventData gen_to_be_invoked = (UnityEngine.EventSystems.AxisEventData)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.moveDir);
            return 1;
        }
        
        
        
        int UnityEngineEventSystemsAxisEventData_s_set_moveVector(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.EventSystems.AxisEventData gen_to_be_invoked = (UnityEngine.EventSystems.AxisEventData)translator.FastGetCSObj(L, 1);
            UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.moveVector = gen_value;
            
            return 0;
        }
        
        int UnityEngineEventSystemsAxisEventData_s_set_moveDir(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.EventSystems.AxisEventData gen_to_be_invoked = (UnityEngine.EventSystems.AxisEventData)translator.FastGetCSObj(L, 1);
            UnityEngine.EventSystems.MoveDirection gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.moveDir = gen_value;
            
            return 0;
        }
        
		
		
		
		
    }
}
