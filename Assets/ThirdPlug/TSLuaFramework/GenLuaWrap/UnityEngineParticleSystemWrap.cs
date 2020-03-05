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
        public void __RegisterUnityEngineParticleSystem(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.ParticleSystem);
			Utils.BeginObjectRegister(type, L, this, 0, 16, 31, 3);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetParticles", UnityEngineParticleSystem_m_SetParticles);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetParticles", UnityEngineParticleSystem_m_GetParticles);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetCustomParticleData", UnityEngineParticleSystem_m_SetCustomParticleData);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetCustomParticleData", UnityEngineParticleSystem_m_GetCustomParticleData);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPlaybackState", UnityEngineParticleSystem_m_GetPlaybackState);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetPlaybackState", UnityEngineParticleSystem_m_SetPlaybackState);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetTrails", UnityEngineParticleSystem_m_GetTrails);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetTrails", UnityEngineParticleSystem_m_SetTrails);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Simulate", UnityEngineParticleSystem_m_Simulate);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Play", UnityEngineParticleSystem_m_Play);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Pause", UnityEngineParticleSystem_m_Pause);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Stop", UnityEngineParticleSystem_m_Stop);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Clear", UnityEngineParticleSystem_m_Clear);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsAlive", UnityEngineParticleSystem_m_IsAlive);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Emit", UnityEngineParticleSystem_m_Emit);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TriggerSubEmitter", UnityEngineParticleSystem_m_TriggerSubEmitter);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "isPlaying", UnityEngineParticleSystem_g_get_isPlaying);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isEmitting", UnityEngineParticleSystem_g_get_isEmitting);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isStopped", UnityEngineParticleSystem_g_get_isStopped);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isPaused", UnityEngineParticleSystem_g_get_isPaused);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "particleCount", UnityEngineParticleSystem_g_get_particleCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "time", UnityEngineParticleSystem_g_get_time);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "randomSeed", UnityEngineParticleSystem_g_get_randomSeed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "useAutoRandomSeed", UnityEngineParticleSystem_g_get_useAutoRandomSeed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "proceduralSimulationSupported", UnityEngineParticleSystem_g_get_proceduralSimulationSupported);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "main", UnityEngineParticleSystem_g_get_main);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "emission", UnityEngineParticleSystem_g_get_emission);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "shape", UnityEngineParticleSystem_g_get_shape);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "velocityOverLifetime", UnityEngineParticleSystem_g_get_velocityOverLifetime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "limitVelocityOverLifetime", UnityEngineParticleSystem_g_get_limitVelocityOverLifetime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "inheritVelocity", UnityEngineParticleSystem_g_get_inheritVelocity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "forceOverLifetime", UnityEngineParticleSystem_g_get_forceOverLifetime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "colorOverLifetime", UnityEngineParticleSystem_g_get_colorOverLifetime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "colorBySpeed", UnityEngineParticleSystem_g_get_colorBySpeed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sizeOverLifetime", UnityEngineParticleSystem_g_get_sizeOverLifetime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sizeBySpeed", UnityEngineParticleSystem_g_get_sizeBySpeed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rotationOverLifetime", UnityEngineParticleSystem_g_get_rotationOverLifetime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rotationBySpeed", UnityEngineParticleSystem_g_get_rotationBySpeed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "externalForces", UnityEngineParticleSystem_g_get_externalForces);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "noise", UnityEngineParticleSystem_g_get_noise);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "collision", UnityEngineParticleSystem_g_get_collision);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "trigger", UnityEngineParticleSystem_g_get_trigger);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "subEmitters", UnityEngineParticleSystem_g_get_subEmitters);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "textureSheetAnimation", UnityEngineParticleSystem_g_get_textureSheetAnimation);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lights", UnityEngineParticleSystem_g_get_lights);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "trails", UnityEngineParticleSystem_g_get_trails);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "customData", UnityEngineParticleSystem_g_get_customData);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "time", UnityEngineParticleSystem_s_set_time);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "randomSeed", UnityEngineParticleSystem_s_set_randomSeed);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "useAutoRandomSeed", UnityEngineParticleSystem_s_set_useAutoRandomSeed);
            
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineParticleSystem, 2, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "ResetPreMappedBufferMemory", UnityEngineParticleSystem_m_ResetPreMappedBufferMemory_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineParticleSystem(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			if(gen_param_count == 1)
			{
				
				UnityEngine.ParticleSystem gen_ret = new UnityEngine.ParticleSystem();
				translator.Push(L, gen_ret);
				
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ParticleSystem constructor!");
            
        }
        
		
        
		
        
        
        
        
        int UnityEngineParticleSystem_m_SetParticles(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.ParticleSystem.Particle[]>(L, 2)) 
			{
				UnityEngine.ParticleSystem.Particle[] _particles = (UnityEngine.ParticleSystem.Particle[])translator.GetObject(L, 2, typeof(UnityEngine.ParticleSystem.Particle[]));
				
				gen_to_be_invoked.SetParticles( _particles );
				
				
				
				return 1;
			}
			if(gen_param_count == 3&& translator.Assignable<UnityEngine.ParticleSystem.Particle[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
			{
				UnityEngine.ParticleSystem.Particle[] _particles = (UnityEngine.ParticleSystem.Particle[])translator.GetObject(L, 2, typeof(UnityEngine.ParticleSystem.Particle[]));
				int _size = LuaAPI.xlua_tointeger(L, 3);
				
				gen_to_be_invoked.SetParticles( _particles, _size );
				
				
				
				return 1;
			}
			if(gen_param_count == 4&& translator.Assignable<UnityEngine.ParticleSystem.Particle[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
			{
				UnityEngine.ParticleSystem.Particle[] _particles = (UnityEngine.ParticleSystem.Particle[])translator.GetObject(L, 2, typeof(UnityEngine.ParticleSystem.Particle[]));
				int _size = LuaAPI.xlua_tointeger(L, 3);
				int _offset = LuaAPI.xlua_tointeger(L, 4);
				
				gen_to_be_invoked.SetParticles( _particles, _size, _offset );
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ParticleSystem.SetParticles!");
            
        }
        
        int UnityEngineParticleSystem_m_GetParticles(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.ParticleSystem.Particle[]>(L, 2)) 
			{
				UnityEngine.ParticleSystem.Particle[] _particles = (UnityEngine.ParticleSystem.Particle[])translator.GetObject(L, 2, typeof(UnityEngine.ParticleSystem.Particle[]));
				
				int gen_ret = gen_to_be_invoked.GetParticles( _particles );
				LuaAPI.xlua_pushinteger(L, gen_ret);
				
				
				
				return 2;
			}
			if(gen_param_count == 3&& translator.Assignable<UnityEngine.ParticleSystem.Particle[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
			{
				UnityEngine.ParticleSystem.Particle[] _particles = (UnityEngine.ParticleSystem.Particle[])translator.GetObject(L, 2, typeof(UnityEngine.ParticleSystem.Particle[]));
				int _size = LuaAPI.xlua_tointeger(L, 3);
				
				int gen_ret = gen_to_be_invoked.GetParticles( _particles, _size );
				LuaAPI.xlua_pushinteger(L, gen_ret);
				
				
				
				return 2;
			}
			if(gen_param_count == 4&& translator.Assignable<UnityEngine.ParticleSystem.Particle[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
			{
				UnityEngine.ParticleSystem.Particle[] _particles = (UnityEngine.ParticleSystem.Particle[])translator.GetObject(L, 2, typeof(UnityEngine.ParticleSystem.Particle[]));
				int _size = LuaAPI.xlua_tointeger(L, 3);
				int _offset = LuaAPI.xlua_tointeger(L, 4);
				
				int gen_ret = gen_to_be_invoked.GetParticles( _particles, _size, _offset );
				LuaAPI.xlua_pushinteger(L, gen_ret);
				
				
				
				return 2;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ParticleSystem.GetParticles!");
            
        }
        
        int UnityEngineParticleSystem_m_SetCustomParticleData(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
            
			
			{
				System.Collections.Generic.List<UnityEngine.Vector4> _customData = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
				UnityEngine.ParticleSystemCustomData _streamIndex;translator.Get(L, 3, out _streamIndex);
				
				gen_to_be_invoked.SetCustomParticleData( _customData, _streamIndex );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineParticleSystem_m_GetCustomParticleData(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
            
			
			{
				System.Collections.Generic.List<UnityEngine.Vector4> _customData = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
				UnityEngine.ParticleSystemCustomData _streamIndex;translator.Get(L, 3, out _streamIndex);
				
				int gen_ret = gen_to_be_invoked.GetCustomParticleData( _customData, _streamIndex );
				LuaAPI.xlua_pushinteger(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineParticleSystem_m_GetPlaybackState(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
            
			
			{
				
				UnityEngine.ParticleSystem.PlaybackState gen_ret = gen_to_be_invoked.GetPlaybackState(  );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineParticleSystem_m_SetPlaybackState(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.ParticleSystem.PlaybackState _playbackState;translator.Get(L, 2, out _playbackState);
				
				gen_to_be_invoked.SetPlaybackState( _playbackState );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineParticleSystem_m_GetTrails(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
            
			
			{
				
				UnityEngine.ParticleSystem.Trails gen_ret = gen_to_be_invoked.GetTrails(  );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineParticleSystem_m_SetTrails(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.ParticleSystem.Trails _trailData;translator.Get(L, 2, out _trailData);
				
				gen_to_be_invoked.SetTrails( _trailData );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineParticleSystem_m_Simulate(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
			{
				float _t = (float)LuaAPI.lua_tonumber(L, 2);
				
				gen_to_be_invoked.Simulate( _t );
				
				
				
				return 0;
			}
			if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
			{
				float _t = (float)LuaAPI.lua_tonumber(L, 2);
				bool _withChildren = LuaAPI.lua_toboolean(L, 3);
				
				gen_to_be_invoked.Simulate( _t, _withChildren );
				
				
				
				return 0;
			}
			if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)) 
			{
				float _t = (float)LuaAPI.lua_tonumber(L, 2);
				bool _withChildren = LuaAPI.lua_toboolean(L, 3);
				bool _restart = LuaAPI.lua_toboolean(L, 4);
				
				gen_to_be_invoked.Simulate( _t, _withChildren, _restart );
				
				
				
				return 0;
			}
			if(gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5)) 
			{
				float _t = (float)LuaAPI.lua_tonumber(L, 2);
				bool _withChildren = LuaAPI.lua_toboolean(L, 3);
				bool _restart = LuaAPI.lua_toboolean(L, 4);
				bool _fixedTimeStep = LuaAPI.lua_toboolean(L, 5);
				
				gen_to_be_invoked.Simulate( _t, _withChildren, _restart, _fixedTimeStep );
				
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ParticleSystem.Simulate!");
            
        }
        
        int UnityEngineParticleSystem_m_Play(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 1) 
			{
				
				gen_to_be_invoked.Play(  );
				
				
				
				return 0;
			}
			if(gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
			{
				bool _withChildren = LuaAPI.lua_toboolean(L, 2);
				
				gen_to_be_invoked.Play( _withChildren );
				
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ParticleSystem.Play!");
            
        }
        
        int UnityEngineParticleSystem_m_Pause(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 1) 
			{
				
				gen_to_be_invoked.Pause(  );
				
				
				
				return 0;
			}
			if(gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
			{
				bool _withChildren = LuaAPI.lua_toboolean(L, 2);
				
				gen_to_be_invoked.Pause( _withChildren );
				
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ParticleSystem.Pause!");
            
        }
        
        int UnityEngineParticleSystem_m_Stop(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 1) 
			{
				
				gen_to_be_invoked.Stop(  );
				
				
				
				return 0;
			}
			if(gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
			{
				bool _withChildren = LuaAPI.lua_toboolean(L, 2);
				
				gen_to_be_invoked.Stop( _withChildren );
				
				
				
				return 0;
			}
			if(gen_param_count == 3&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.ParticleSystemStopBehavior>(L, 3)) 
			{
				bool _withChildren = LuaAPI.lua_toboolean(L, 2);
				UnityEngine.ParticleSystemStopBehavior _stopBehavior;translator.Get(L, 3, out _stopBehavior);
				
				gen_to_be_invoked.Stop( _withChildren, _stopBehavior );
				
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ParticleSystem.Stop!");
            
        }
        
        int UnityEngineParticleSystem_m_Clear(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 1) 
			{
				
				gen_to_be_invoked.Clear(  );
				
				
				
				return 0;
			}
			if(gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
			{
				bool _withChildren = LuaAPI.lua_toboolean(L, 2);
				
				gen_to_be_invoked.Clear( _withChildren );
				
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ParticleSystem.Clear!");
            
        }
        
        int UnityEngineParticleSystem_m_IsAlive(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 1) 
			{
				
				bool gen_ret = gen_to_be_invoked.IsAlive(  );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
			{
				bool _withChildren = LuaAPI.lua_toboolean(L, 2);
				
				bool gen_ret = gen_to_be_invoked.IsAlive( _withChildren );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ParticleSystem.IsAlive!");
            
        }
        
        int UnityEngineParticleSystem_m_Emit(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
			{
				int _count = LuaAPI.xlua_tointeger(L, 2);
				
				gen_to_be_invoked.Emit( _count );
				
				
				
				return 0;
			}
			if(gen_param_count == 3&& translator.Assignable<UnityEngine.ParticleSystem.EmitParams>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
			{
				UnityEngine.ParticleSystem.EmitParams _emitParams;translator.Get(L, 2, out _emitParams);
				int _count = LuaAPI.xlua_tointeger(L, 3);
				
				gen_to_be_invoked.Emit( _emitParams, _count );
				
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ParticleSystem.Emit!");
            
        }
        
        int UnityEngineParticleSystem_m_TriggerSubEmitter(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
			{
				int _subEmitterIndex = LuaAPI.xlua_tointeger(L, 2);
				
				gen_to_be_invoked.TriggerSubEmitter( _subEmitterIndex );
				
				
				
				return 0;
			}
			if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.ParticleSystem.Particle>(L, 3)) 
			{
				int _subEmitterIndex = LuaAPI.xlua_tointeger(L, 2);
				UnityEngine.ParticleSystem.Particle _particle;translator.Get(L, 3, out _particle);
				
				gen_to_be_invoked.TriggerSubEmitter( _subEmitterIndex, ref _particle );
				translator.Push(L, _particle);
					translator.Update(L, 3, _particle);
					
				
				
				
				return 1;
			}
			if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle>>(L, 3)) 
			{
				int _subEmitterIndex = LuaAPI.xlua_tointeger(L, 2);
				System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle> _particles = (System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle>));
				
				gen_to_be_invoked.TriggerSubEmitter( _subEmitterIndex, _particles );
				
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ParticleSystem.TriggerSubEmitter!");
            
        }
        
        int UnityEngineParticleSystem_m_ResetPreMappedBufferMemory_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				
				UnityEngine.ParticleSystem.ResetPreMappedBufferMemory(  );
				
				
				
				return 0;
			}
			
            
        }
        
        
        
        
        int UnityEngineParticleSystem_g_get_isPlaying(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isPlaying);
            return 1;
        }
        
        int UnityEngineParticleSystem_g_get_isEmitting(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isEmitting);
            return 1;
        }
        
        int UnityEngineParticleSystem_g_get_isStopped(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isStopped);
            return 1;
        }
        
        int UnityEngineParticleSystem_g_get_isPaused(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isPaused);
            return 1;
        }
        
        int UnityEngineParticleSystem_g_get_particleCount(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.particleCount);
            return 1;
        }
        
        int UnityEngineParticleSystem_g_get_time(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.time);
            return 1;
        }
        
        int UnityEngineParticleSystem_g_get_randomSeed(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushuint(L, gen_to_be_invoked.randomSeed);
            return 1;
        }
        
        int UnityEngineParticleSystem_g_get_useAutoRandomSeed(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.useAutoRandomSeed);
            return 1;
        }
        
        int UnityEngineParticleSystem_g_get_proceduralSimulationSupported(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.proceduralSimulationSupported);
            return 1;
        }
        
        int UnityEngineParticleSystem_g_get_main(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.main);
            return 1;
        }
        
        int UnityEngineParticleSystem_g_get_emission(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.emission);
            return 1;
        }
        
        int UnityEngineParticleSystem_g_get_shape(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.shape);
            return 1;
        }
        
        int UnityEngineParticleSystem_g_get_velocityOverLifetime(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.velocityOverLifetime);
            return 1;
        }
        
        int UnityEngineParticleSystem_g_get_limitVelocityOverLifetime(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.limitVelocityOverLifetime);
            return 1;
        }
        
        int UnityEngineParticleSystem_g_get_inheritVelocity(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.inheritVelocity);
            return 1;
        }
        
        int UnityEngineParticleSystem_g_get_forceOverLifetime(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.forceOverLifetime);
            return 1;
        }
        
        int UnityEngineParticleSystem_g_get_colorOverLifetime(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.colorOverLifetime);
            return 1;
        }
        
        int UnityEngineParticleSystem_g_get_colorBySpeed(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.colorBySpeed);
            return 1;
        }
        
        int UnityEngineParticleSystem_g_get_sizeOverLifetime(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.sizeOverLifetime);
            return 1;
        }
        
        int UnityEngineParticleSystem_g_get_sizeBySpeed(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.sizeBySpeed);
            return 1;
        }
        
        int UnityEngineParticleSystem_g_get_rotationOverLifetime(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.rotationOverLifetime);
            return 1;
        }
        
        int UnityEngineParticleSystem_g_get_rotationBySpeed(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.rotationBySpeed);
            return 1;
        }
        
        int UnityEngineParticleSystem_g_get_externalForces(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.externalForces);
            return 1;
        }
        
        int UnityEngineParticleSystem_g_get_noise(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.noise);
            return 1;
        }
        
        int UnityEngineParticleSystem_g_get_collision(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.collision);
            return 1;
        }
        
        int UnityEngineParticleSystem_g_get_trigger(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.trigger);
            return 1;
        }
        
        int UnityEngineParticleSystem_g_get_subEmitters(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.subEmitters);
            return 1;
        }
        
        int UnityEngineParticleSystem_g_get_textureSheetAnimation(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.textureSheetAnimation);
            return 1;
        }
        
        int UnityEngineParticleSystem_g_get_lights(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.lights);
            return 1;
        }
        
        int UnityEngineParticleSystem_g_get_trails(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.trails);
            return 1;
        }
        
        int UnityEngineParticleSystem_g_get_customData(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.customData);
            return 1;
        }
        
        
        
        int UnityEngineParticleSystem_s_set_time(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.time = (float)LuaAPI.lua_tonumber(L, 2);
            
            return 0;
        }
        
        int UnityEngineParticleSystem_s_set_randomSeed(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.randomSeed = LuaAPI.xlua_touint(L, 2);
            
            return 0;
        }
        
        int UnityEngineParticleSystem_s_set_useAutoRandomSeed(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.ParticleSystem gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.useAutoRandomSeed = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
		
		
		
		
    }
}
