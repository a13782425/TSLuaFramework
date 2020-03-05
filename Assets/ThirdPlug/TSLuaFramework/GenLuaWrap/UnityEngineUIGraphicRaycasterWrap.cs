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
        public void __RegisterUnityEngineUIGraphicRaycaster(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.UI.GraphicRaycaster);
			Utils.BeginObjectRegister(type, L, this, 0, 1, 5, 2);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Raycast", UnityEngineUIGraphicRaycaster_m_Raycast);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "sortOrderPriority", UnityEngineUIGraphicRaycaster_g_get_sortOrderPriority);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "renderOrderPriority", UnityEngineUIGraphicRaycaster_g_get_renderOrderPriority);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ignoreReversedGraphics", UnityEngineUIGraphicRaycaster_g_get_ignoreReversedGraphics);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "blockingObjects", UnityEngineUIGraphicRaycaster_g_get_blockingObjects);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "eventCamera", UnityEngineUIGraphicRaycaster_g_get_eventCamera);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "ignoreReversedGraphics", UnityEngineUIGraphicRaycaster_s_set_ignoreReversedGraphics);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "blockingObjects", UnityEngineUIGraphicRaycaster_s_set_blockingObjects);
            
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineUIGraphicRaycaster, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineUIGraphicRaycaster(RealStatePtr L, int gen_param_count) 
        {
            return LuaAPI.luaL_error(L, "UnityEngine.UI.GraphicRaycaster does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        int UnityEngineUIGraphicRaycaster_m_Raycast(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.GraphicRaycaster gen_to_be_invoked = (UnityEngine.UI.GraphicRaycaster)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.EventSystems.PointerEventData _eventData = (UnityEngine.EventSystems.PointerEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
				System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> _resultAppendList = (System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult>));
				
				gen_to_be_invoked.Raycast( _eventData, _resultAppendList );
				
				
				
				return 0;
			}
			
            
        }
        
        
        
        
        int UnityEngineUIGraphicRaycaster_g_get_sortOrderPriority(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.GraphicRaycaster gen_to_be_invoked = (UnityEngine.UI.GraphicRaycaster)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.sortOrderPriority);
            return 1;
        }
        
        int UnityEngineUIGraphicRaycaster_g_get_renderOrderPriority(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.GraphicRaycaster gen_to_be_invoked = (UnityEngine.UI.GraphicRaycaster)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.renderOrderPriority);
            return 1;
        }
        
        int UnityEngineUIGraphicRaycaster_g_get_ignoreReversedGraphics(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.GraphicRaycaster gen_to_be_invoked = (UnityEngine.UI.GraphicRaycaster)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.ignoreReversedGraphics);
            return 1;
        }
        
        int UnityEngineUIGraphicRaycaster_g_get_blockingObjects(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.GraphicRaycaster gen_to_be_invoked = (UnityEngine.UI.GraphicRaycaster)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.blockingObjects);
            return 1;
        }
        
        int UnityEngineUIGraphicRaycaster_g_get_eventCamera(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.GraphicRaycaster gen_to_be_invoked = (UnityEngine.UI.GraphicRaycaster)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.eventCamera);
            return 1;
        }
        
        
        
        int UnityEngineUIGraphicRaycaster_s_set_ignoreReversedGraphics(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.GraphicRaycaster gen_to_be_invoked = (UnityEngine.UI.GraphicRaycaster)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.ignoreReversedGraphics = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineUIGraphicRaycaster_s_set_blockingObjects(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.GraphicRaycaster gen_to_be_invoked = (UnityEngine.UI.GraphicRaycaster)translator.FastGetCSObj(L, 1);
            UnityEngine.UI.GraphicRaycaster.BlockingObjects gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.blockingObjects = gen_value;
            
            return 0;
        }
        
		
		
		
		
    }
}
