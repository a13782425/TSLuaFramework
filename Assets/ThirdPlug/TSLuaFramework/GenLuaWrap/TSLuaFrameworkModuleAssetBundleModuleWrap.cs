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
        public void __RegisterTSLuaFrameworkModuleAssetBundleModule(RealStatePtr L) 
        {
		    System.Type type = typeof(TSLuaFramework.Module.AssetBundleModule);
			Utils.BeginObjectRegister(type, L, this, 0, 10, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Init", TSLuaFrameworkModuleAssetBundleModule_m_Init);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Update", TSLuaFrameworkModuleAssetBundleModule_m_Update);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Freed", TSLuaFrameworkModuleAssetBundleModule_m_Freed);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UnloadAssetBundleByName", TSLuaFrameworkModuleAssetBundleModule_m_UnloadAssetBundleByName);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetAssetBundleInfo", TSLuaFrameworkModuleAssetBundleModule_m_SetAssetBundleInfo);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveAssetBundleInfo", TSLuaFrameworkModuleAssetBundleModule_m_RemoveAssetBundleInfo);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AutoUnload", TSLuaFrameworkModuleAssetBundleModule_m_AutoUnload);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UnloadAll", TSLuaFrameworkModuleAssetBundleModule_m_UnloadAll);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LoadAsset", TSLuaFrameworkModuleAssetBundleModule_m_LoadAsset);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LoadAssetAsync", TSLuaFrameworkModuleAssetBundleModule_m_LoadAssetAsync);
			
			
			
			
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceTSLuaFrameworkModuleAssetBundleModule, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceTSLuaFrameworkModuleAssetBundleModule(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			if(gen_param_count == 1)
			{
				
				TSLuaFramework.Module.AssetBundleModule gen_ret = new TSLuaFramework.Module.AssetBundleModule();
				translator.Push(L, gen_ret);
				
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to TSLuaFramework.Module.AssetBundleModule constructor!");
            
        }
        
		
        
		
        
        
        
        
        int TSLuaFrameworkModuleAssetBundleModule_m_Init(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            TSLuaFramework.Module.AssetBundleModule gen_to_be_invoked = (TSLuaFramework.Module.AssetBundleModule)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.Init(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int TSLuaFrameworkModuleAssetBundleModule_m_Update(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            TSLuaFramework.Module.AssetBundleModule gen_to_be_invoked = (TSLuaFramework.Module.AssetBundleModule)translator.FastGetCSObj(L, 1);
            
			
			{
				float _deltaTime = (float)LuaAPI.lua_tonumber(L, 2);
				
				gen_to_be_invoked.Update( _deltaTime );
				
				
				
				return 0;
			}
			
            
        }
        
        int TSLuaFrameworkModuleAssetBundleModule_m_Freed(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            TSLuaFramework.Module.AssetBundleModule gen_to_be_invoked = (TSLuaFramework.Module.AssetBundleModule)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.Freed(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int TSLuaFrameworkModuleAssetBundleModule_m_UnloadAssetBundleByName(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            TSLuaFramework.Module.AssetBundleModule gen_to_be_invoked = (TSLuaFramework.Module.AssetBundleModule)translator.FastGetCSObj(L, 1);
            
			
			{
				string _bundleName = LuaAPI.lua_tostring(L, 2);
				
				gen_to_be_invoked.UnloadAssetBundleByName( _bundleName );
				
				
				
				return 0;
			}
			
            
        }
        
        int TSLuaFrameworkModuleAssetBundleModule_m_SetAssetBundleInfo(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            TSLuaFramework.Module.AssetBundleModule gen_to_be_invoked = (TSLuaFramework.Module.AssetBundleModule)translator.FastGetCSObj(L, 1);
            
			
			{
				string _abPath = LuaAPI.lua_tostring(L, 2);
				
				TSLuaFramework.Module.AssetBundleModule gen_ret = gen_to_be_invoked.SetAssetBundleInfo( _abPath );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int TSLuaFrameworkModuleAssetBundleModule_m_RemoveAssetBundleInfo(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            TSLuaFramework.Module.AssetBundleModule gen_to_be_invoked = (TSLuaFramework.Module.AssetBundleModule)translator.FastGetCSObj(L, 1);
            
			
			{
				string _abPath = LuaAPI.lua_tostring(L, 2);
				bool _unloadAllObjects = LuaAPI.lua_toboolean(L, 3);
				
				TSLuaFramework.Module.AssetBundleModule gen_ret = gen_to_be_invoked.RemoveAssetBundleInfo( _abPath, _unloadAllObjects );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int TSLuaFrameworkModuleAssetBundleModule_m_AutoUnload(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            TSLuaFramework.Module.AssetBundleModule gen_to_be_invoked = (TSLuaFramework.Module.AssetBundleModule)translator.FastGetCSObj(L, 1);
            
			
			{
				int _second = LuaAPI.xlua_tointeger(L, 2);
				
				gen_to_be_invoked.AutoUnload( _second );
				
				
				
				return 0;
			}
			
            
        }
        
        int TSLuaFrameworkModuleAssetBundleModule_m_UnloadAll(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            TSLuaFramework.Module.AssetBundleModule gen_to_be_invoked = (TSLuaFramework.Module.AssetBundleModule)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.UnloadAll(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int TSLuaFrameworkModuleAssetBundleModule_m_LoadAsset(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            TSLuaFramework.Module.AssetBundleModule gen_to_be_invoked = (TSLuaFramework.Module.AssetBundleModule)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
			{
				string _assetName = LuaAPI.lua_tostring(L, 2);
				
				UnityEngine.Object gen_ret = gen_to_be_invoked.LoadAsset( _assetName );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)) 
			{
				string _bundleName = LuaAPI.lua_tostring(L, 2);
				string _assetName = LuaAPI.lua_tostring(L, 3);
				
				UnityEngine.Object gen_ret = gen_to_be_invoked.LoadAsset( _bundleName, _assetName );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to TSLuaFramework.Module.AssetBundleModule.LoadAsset!");
            
        }
        
        int TSLuaFrameworkModuleAssetBundleModule_m_LoadAssetAsync(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            TSLuaFramework.Module.AssetBundleModule gen_to_be_invoked = (TSLuaFramework.Module.AssetBundleModule)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Action<UnityEngine.Object>>(L, 3)) 
			{
				string _assetName = LuaAPI.lua_tostring(L, 2);
				System.Action<UnityEngine.Object> _callBack = translator.GetDelegate<System.Action<UnityEngine.Object>>(L, 3);
				
				gen_to_be_invoked.LoadAssetAsync( _assetName, _callBack );
				
				
				
				return 0;
			}
			if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Action<UnityEngine.Object>>(L, 4)) 
			{
				string _bundleName = LuaAPI.lua_tostring(L, 2);
				string _assetName = LuaAPI.lua_tostring(L, 3);
				System.Action<UnityEngine.Object> _callBack = translator.GetDelegate<System.Action<UnityEngine.Object>>(L, 4);
				
				gen_to_be_invoked.LoadAssetAsync( _bundleName, _assetName, _callBack );
				
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to TSLuaFramework.Module.AssetBundleModule.LoadAssetAsync!");
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
