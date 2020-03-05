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
        public void __RegisterUnityEngineRaycastHit(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.RaycastHit);
			Utils.BeginObjectRegister(type, L, this, 0, 0, 11, 4);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "collider", UnityEngineRaycastHit_g_get_collider);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "point", UnityEngineRaycastHit_g_get_point);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "normal", UnityEngineRaycastHit_g_get_normal);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "barycentricCoordinate", UnityEngineRaycastHit_g_get_barycentricCoordinate);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "distance", UnityEngineRaycastHit_g_get_distance);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "triangleIndex", UnityEngineRaycastHit_g_get_triangleIndex);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "textureCoord", UnityEngineRaycastHit_g_get_textureCoord);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "textureCoord2", UnityEngineRaycastHit_g_get_textureCoord2);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "transform", UnityEngineRaycastHit_g_get_transform);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rigidbody", UnityEngineRaycastHit_g_get_rigidbody);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lightmapCoord", UnityEngineRaycastHit_g_get_lightmapCoord);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "point", UnityEngineRaycastHit_s_set_point);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "normal", UnityEngineRaycastHit_s_set_normal);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "barycentricCoordinate", UnityEngineRaycastHit_s_set_barycentricCoordinate);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "distance", UnityEngineRaycastHit_s_set_distance);
            
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineRaycastHit, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineRaycastHit(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			
			if (gen_param_count == 1)
			{
				translator.Push(L, default(UnityEngine.RaycastHit));
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.RaycastHit constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        int UnityEngineRaycastHit_g_get_collider(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.RaycastHit gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			translator.Push(L, gen_to_be_invoked.collider);
            return 1;
        }
        
        int UnityEngineRaycastHit_g_get_point(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.RaycastHit gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			translator.PushUnityEngineVector3(L, gen_to_be_invoked.point);
            return 1;
        }
        
        int UnityEngineRaycastHit_g_get_normal(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.RaycastHit gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			translator.PushUnityEngineVector3(L, gen_to_be_invoked.normal);
            return 1;
        }
        
        int UnityEngineRaycastHit_g_get_barycentricCoordinate(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.RaycastHit gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			translator.PushUnityEngineVector3(L, gen_to_be_invoked.barycentricCoordinate);
            return 1;
        }
        
        int UnityEngineRaycastHit_g_get_distance(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.RaycastHit gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.distance);
            return 1;
        }
        
        int UnityEngineRaycastHit_g_get_triangleIndex(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.RaycastHit gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.triangleIndex);
            return 1;
        }
        
        int UnityEngineRaycastHit_g_get_textureCoord(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.RaycastHit gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			translator.PushUnityEngineVector2(L, gen_to_be_invoked.textureCoord);
            return 1;
        }
        
        int UnityEngineRaycastHit_g_get_textureCoord2(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.RaycastHit gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			translator.PushUnityEngineVector2(L, gen_to_be_invoked.textureCoord2);
            return 1;
        }
        
        int UnityEngineRaycastHit_g_get_transform(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.RaycastHit gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			translator.Push(L, gen_to_be_invoked.transform);
            return 1;
        }
        
        int UnityEngineRaycastHit_g_get_rigidbody(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.RaycastHit gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			translator.Push(L, gen_to_be_invoked.rigidbody);
            return 1;
        }
        
        int UnityEngineRaycastHit_g_get_lightmapCoord(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.RaycastHit gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			translator.PushUnityEngineVector2(L, gen_to_be_invoked.lightmapCoord);
            return 1;
        }
        
        
        
        int UnityEngineRaycastHit_s_set_point(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.RaycastHit gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.point = gen_value;
            
            translator.Update(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineRaycastHit_s_set_normal(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.RaycastHit gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.normal = gen_value;
            
            translator.Update(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineRaycastHit_s_set_barycentricCoordinate(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.RaycastHit gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.barycentricCoordinate = gen_value;
            
            translator.Update(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineRaycastHit_s_set_distance(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.RaycastHit gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            gen_to_be_invoked.distance = (float)LuaAPI.lua_tonumber(L, 2);
            
            translator.Update(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
		
		
		
		
    }
}
