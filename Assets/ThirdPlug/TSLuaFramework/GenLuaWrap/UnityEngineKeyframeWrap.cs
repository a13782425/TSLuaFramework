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
        public void __RegisterUnityEngineKeyframe(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.Keyframe);
			Utils.BeginObjectRegister(type, L, this, 0, 0, 7, 7);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "time", UnityEngineKeyframe_g_get_time);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "value", UnityEngineKeyframe_g_get_value);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "inTangent", UnityEngineKeyframe_g_get_inTangent);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "outTangent", UnityEngineKeyframe_g_get_outTangent);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "inWeight", UnityEngineKeyframe_g_get_inWeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "outWeight", UnityEngineKeyframe_g_get_outWeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "weightedMode", UnityEngineKeyframe_g_get_weightedMode);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "time", UnityEngineKeyframe_s_set_time);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "value", UnityEngineKeyframe_s_set_value);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "inTangent", UnityEngineKeyframe_s_set_inTangent);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "outTangent", UnityEngineKeyframe_s_set_outTangent);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "inWeight", UnityEngineKeyframe_s_set_inWeight);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "outWeight", UnityEngineKeyframe_s_set_outWeight);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "weightedMode", UnityEngineKeyframe_s_set_weightedMode);
            
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineKeyframe, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineKeyframe(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			if(gen_param_count == 3 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3))
			{
				float _time = (float)LuaAPI.lua_tonumber(L, 2);
				float _value = (float)LuaAPI.lua_tonumber(L, 3);
				
				UnityEngine.Keyframe gen_ret = new UnityEngine.Keyframe(_time, _value);
				translator.Push(L, gen_ret);
				
				return 1;
			}
			if(gen_param_count == 5 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5))
			{
				float _time = (float)LuaAPI.lua_tonumber(L, 2);
				float _value = (float)LuaAPI.lua_tonumber(L, 3);
				float _inTangent = (float)LuaAPI.lua_tonumber(L, 4);
				float _outTangent = (float)LuaAPI.lua_tonumber(L, 5);
				
				UnityEngine.Keyframe gen_ret = new UnityEngine.Keyframe(_time, _value, _inTangent, _outTangent);
				translator.Push(L, gen_ret);
				
				return 1;
			}
			if(gen_param_count == 7 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7))
			{
				float _time = (float)LuaAPI.lua_tonumber(L, 2);
				float _value = (float)LuaAPI.lua_tonumber(L, 3);
				float _inTangent = (float)LuaAPI.lua_tonumber(L, 4);
				float _outTangent = (float)LuaAPI.lua_tonumber(L, 5);
				float _inWeight = (float)LuaAPI.lua_tonumber(L, 6);
				float _outWeight = (float)LuaAPI.lua_tonumber(L, 7);
				
				UnityEngine.Keyframe gen_ret = new UnityEngine.Keyframe(_time, _value, _inTangent, _outTangent, _inWeight, _outWeight);
				translator.Push(L, gen_ret);
				
				return 1;
			}
			
			if (gen_param_count == 1)
			{
				translator.Push(L, default(UnityEngine.Keyframe));
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Keyframe constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        int UnityEngineKeyframe_g_get_time(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Keyframe gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.time);
            return 1;
        }
        
        int UnityEngineKeyframe_g_get_value(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Keyframe gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.value);
            return 1;
        }
        
        int UnityEngineKeyframe_g_get_inTangent(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Keyframe gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.inTangent);
            return 1;
        }
        
        int UnityEngineKeyframe_g_get_outTangent(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Keyframe gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.outTangent);
            return 1;
        }
        
        int UnityEngineKeyframe_g_get_inWeight(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Keyframe gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.inWeight);
            return 1;
        }
        
        int UnityEngineKeyframe_g_get_outWeight(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Keyframe gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.outWeight);
            return 1;
        }
        
        int UnityEngineKeyframe_g_get_weightedMode(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Keyframe gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			translator.Push(L, gen_to_be_invoked.weightedMode);
            return 1;
        }
        
        
        
        int UnityEngineKeyframe_s_set_time(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Keyframe gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            gen_to_be_invoked.time = (float)LuaAPI.lua_tonumber(L, 2);
            
            translator.Update(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineKeyframe_s_set_value(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Keyframe gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            gen_to_be_invoked.value = (float)LuaAPI.lua_tonumber(L, 2);
            
            translator.Update(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineKeyframe_s_set_inTangent(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Keyframe gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            gen_to_be_invoked.inTangent = (float)LuaAPI.lua_tonumber(L, 2);
            
            translator.Update(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineKeyframe_s_set_outTangent(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Keyframe gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            gen_to_be_invoked.outTangent = (float)LuaAPI.lua_tonumber(L, 2);
            
            translator.Update(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineKeyframe_s_set_inWeight(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Keyframe gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            gen_to_be_invoked.inWeight = (float)LuaAPI.lua_tonumber(L, 2);
            
            translator.Update(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineKeyframe_s_set_outWeight(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Keyframe gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            gen_to_be_invoked.outWeight = (float)LuaAPI.lua_tonumber(L, 2);
            
            translator.Update(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineKeyframe_s_set_weightedMode(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Keyframe gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            UnityEngine.WeightedMode gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.weightedMode = gen_value;
            
            translator.Update(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
		
		
		
		
    }
}
