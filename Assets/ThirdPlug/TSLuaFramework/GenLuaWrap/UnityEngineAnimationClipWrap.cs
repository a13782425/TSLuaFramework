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
        public void __RegisterUnityEngineAnimationClip(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.AnimationClip);
			Utils.BeginObjectRegister(type, L, this, 0, 5, 12, 5);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SampleAnimation", UnityEngineAnimationClip_m_SampleAnimation);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetCurve", UnityEngineAnimationClip_m_SetCurve);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EnsureQuaternionContinuity", UnityEngineAnimationClip_m_EnsureQuaternionContinuity);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ClearCurves", UnityEngineAnimationClip_m_ClearCurves);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddEvent", UnityEngineAnimationClip_m_AddEvent);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "length", UnityEngineAnimationClip_g_get_length);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "frameRate", UnityEngineAnimationClip_g_get_frameRate);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "wrapMode", UnityEngineAnimationClip_g_get_wrapMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "localBounds", UnityEngineAnimationClip_g_get_localBounds);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "legacy", UnityEngineAnimationClip_g_get_legacy);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "humanMotion", UnityEngineAnimationClip_g_get_humanMotion);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "empty", UnityEngineAnimationClip_g_get_empty);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hasGenericRootTransform", UnityEngineAnimationClip_g_get_hasGenericRootTransform);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hasMotionFloatCurves", UnityEngineAnimationClip_g_get_hasMotionFloatCurves);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hasMotionCurves", UnityEngineAnimationClip_g_get_hasMotionCurves);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hasRootCurves", UnityEngineAnimationClip_g_get_hasRootCurves);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "events", UnityEngineAnimationClip_g_get_events);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "frameRate", UnityEngineAnimationClip_s_set_frameRate);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "wrapMode", UnityEngineAnimationClip_s_set_wrapMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "localBounds", UnityEngineAnimationClip_s_set_localBounds);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "legacy", UnityEngineAnimationClip_s_set_legacy);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "events", UnityEngineAnimationClip_s_set_events);
            
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineAnimationClip, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineAnimationClip(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			if(gen_param_count == 1)
			{
				
				UnityEngine.AnimationClip gen_ret = new UnityEngine.AnimationClip();
				translator.Push(L, gen_ret);
				
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.AnimationClip constructor!");
            
        }
        
		
        
		
        
        
        
        
        int UnityEngineAnimationClip_m_SampleAnimation(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.AnimationClip gen_to_be_invoked = (UnityEngine.AnimationClip)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.GameObject _go = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
				float _time = (float)LuaAPI.lua_tonumber(L, 3);
				
				gen_to_be_invoked.SampleAnimation( _go, _time );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineAnimationClip_m_SetCurve(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.AnimationClip gen_to_be_invoked = (UnityEngine.AnimationClip)translator.FastGetCSObj(L, 1);
            
			
			{
				string _relativePath = LuaAPI.lua_tostring(L, 2);
				System.Type _type = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
				string _propertyName = LuaAPI.lua_tostring(L, 4);
				UnityEngine.AnimationCurve _curve = (UnityEngine.AnimationCurve)translator.GetObject(L, 5, typeof(UnityEngine.AnimationCurve));
				
				gen_to_be_invoked.SetCurve( _relativePath, _type, _propertyName, _curve );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineAnimationClip_m_EnsureQuaternionContinuity(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.AnimationClip gen_to_be_invoked = (UnityEngine.AnimationClip)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.EnsureQuaternionContinuity(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineAnimationClip_m_ClearCurves(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.AnimationClip gen_to_be_invoked = (UnityEngine.AnimationClip)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.ClearCurves(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineAnimationClip_m_AddEvent(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.AnimationClip gen_to_be_invoked = (UnityEngine.AnimationClip)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.AnimationEvent _evt = (UnityEngine.AnimationEvent)translator.GetObject(L, 2, typeof(UnityEngine.AnimationEvent));
				
				gen_to_be_invoked.AddEvent( _evt );
				
				
				
				return 0;
			}
			
            
        }
        
        
        
        
        int UnityEngineAnimationClip_g_get_length(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.AnimationClip gen_to_be_invoked = (UnityEngine.AnimationClip)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.length);
            return 1;
        }
        
        int UnityEngineAnimationClip_g_get_frameRate(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.AnimationClip gen_to_be_invoked = (UnityEngine.AnimationClip)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.frameRate);
            return 1;
        }
        
        int UnityEngineAnimationClip_g_get_wrapMode(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.AnimationClip gen_to_be_invoked = (UnityEngine.AnimationClip)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.wrapMode);
            return 1;
        }
        
        int UnityEngineAnimationClip_g_get_localBounds(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.AnimationClip gen_to_be_invoked = (UnityEngine.AnimationClip)translator.FastGetCSObj(L, 1);
			translator.PushUnityEngineBounds(L, gen_to_be_invoked.localBounds);
            return 1;
        }
        
        int UnityEngineAnimationClip_g_get_legacy(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.AnimationClip gen_to_be_invoked = (UnityEngine.AnimationClip)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.legacy);
            return 1;
        }
        
        int UnityEngineAnimationClip_g_get_humanMotion(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.AnimationClip gen_to_be_invoked = (UnityEngine.AnimationClip)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.humanMotion);
            return 1;
        }
        
        int UnityEngineAnimationClip_g_get_empty(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.AnimationClip gen_to_be_invoked = (UnityEngine.AnimationClip)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.empty);
            return 1;
        }
        
        int UnityEngineAnimationClip_g_get_hasGenericRootTransform(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.AnimationClip gen_to_be_invoked = (UnityEngine.AnimationClip)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.hasGenericRootTransform);
            return 1;
        }
        
        int UnityEngineAnimationClip_g_get_hasMotionFloatCurves(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.AnimationClip gen_to_be_invoked = (UnityEngine.AnimationClip)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.hasMotionFloatCurves);
            return 1;
        }
        
        int UnityEngineAnimationClip_g_get_hasMotionCurves(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.AnimationClip gen_to_be_invoked = (UnityEngine.AnimationClip)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.hasMotionCurves);
            return 1;
        }
        
        int UnityEngineAnimationClip_g_get_hasRootCurves(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.AnimationClip gen_to_be_invoked = (UnityEngine.AnimationClip)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.hasRootCurves);
            return 1;
        }
        
        int UnityEngineAnimationClip_g_get_events(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.AnimationClip gen_to_be_invoked = (UnityEngine.AnimationClip)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.events);
            return 1;
        }
        
        
        
        int UnityEngineAnimationClip_s_set_frameRate(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.AnimationClip gen_to_be_invoked = (UnityEngine.AnimationClip)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.frameRate = (float)LuaAPI.lua_tonumber(L, 2);
            
            return 0;
        }
        
        int UnityEngineAnimationClip_s_set_wrapMode(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.AnimationClip gen_to_be_invoked = (UnityEngine.AnimationClip)translator.FastGetCSObj(L, 1);
            UnityEngine.WrapMode gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.wrapMode = gen_value;
            
            return 0;
        }
        
        int UnityEngineAnimationClip_s_set_localBounds(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.AnimationClip gen_to_be_invoked = (UnityEngine.AnimationClip)translator.FastGetCSObj(L, 1);
            UnityEngine.Bounds gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.localBounds = gen_value;
            
            return 0;
        }
        
        int UnityEngineAnimationClip_s_set_legacy(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.AnimationClip gen_to_be_invoked = (UnityEngine.AnimationClip)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.legacy = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineAnimationClip_s_set_events(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.AnimationClip gen_to_be_invoked = (UnityEngine.AnimationClip)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.events = (UnityEngine.AnimationEvent[])translator.GetObject(L, 2, typeof(UnityEngine.AnimationEvent[]));
            
            return 0;
        }
        
		
		
		
		
    }
}
