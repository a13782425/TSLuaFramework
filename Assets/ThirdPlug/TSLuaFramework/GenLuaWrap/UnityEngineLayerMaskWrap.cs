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
        public void __RegisterUnityEngineLayerMask(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.LayerMask);
			Utils.BeginObjectRegister(type, L, this, 0, 0, 1, 1);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "value", UnityEngineLayerMask_g_get_value);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "value", UnityEngineLayerMask_s_set_value);
            
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineLayerMask, 4, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "LayerToName", UnityEngineLayerMask_m_LayerToName_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "NameToLayer", UnityEngineLayerMask_m_NameToLayer_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetMask", UnityEngineLayerMask_m_GetMask_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineLayerMask(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			
			if (gen_param_count == 1)
			{
				translator.Push(L, default(UnityEngine.LayerMask));
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.LayerMask constructor!");
            
        }
        
		
        
		
        
        
        
        
        int UnityEngineLayerMask_m_LayerToName_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				int _layer = LuaAPI.xlua_tointeger(L, 1);
				
				string gen_ret = UnityEngine.LayerMask.LayerToName( _layer );
				LuaAPI.lua_pushstring(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineLayerMask_m_NameToLayer_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				string _layerName = LuaAPI.lua_tostring(L, 1);
				
				int gen_ret = UnityEngine.LayerMask.NameToLayer( _layerName );
				LuaAPI.xlua_pushinteger(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineLayerMask_m_GetMask_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				string[] _layerNames = translator.GetParams<string>(L, 1);
				
				int gen_ret = UnityEngine.LayerMask.GetMask( _layerNames );
				LuaAPI.xlua_pushinteger(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        
        
        
        int UnityEngineLayerMask_g_get_value(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.LayerMask gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.value);
            return 1;
        }
        
        
        
        int UnityEngineLayerMask_s_set_value(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.LayerMask gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            gen_to_be_invoked.value = LuaAPI.xlua_tointeger(L, 2);
            
            translator.Update(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
		
		
		
		
    }
}
