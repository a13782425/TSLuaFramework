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
        public void __RegisterUnityEngineMathf(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.Mathf);
			Utils.BeginObjectRegister(type, L, this, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineMathf, 54, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "ClosestPowerOfTwo", UnityEngineMathf_m_ClosestPowerOfTwo_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IsPowerOfTwo", UnityEngineMathf_m_IsPowerOfTwo_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "NextPowerOfTwo", UnityEngineMathf_m_NextPowerOfTwo_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GammaToLinearSpace", UnityEngineMathf_m_GammaToLinearSpace_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LinearToGammaSpace", UnityEngineMathf_m_LinearToGammaSpace_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CorrelatedColorTemperatureToRGB", UnityEngineMathf_m_CorrelatedColorTemperatureToRGB_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FloatToHalf", UnityEngineMathf_m_FloatToHalf_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "HalfToFloat", UnityEngineMathf_m_HalfToFloat_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "PerlinNoise", UnityEngineMathf_m_PerlinNoise_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Sin", UnityEngineMathf_m_Sin_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Cos", UnityEngineMathf_m_Cos_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Tan", UnityEngineMathf_m_Tan_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Asin", UnityEngineMathf_m_Asin_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Acos", UnityEngineMathf_m_Acos_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Atan", UnityEngineMathf_m_Atan_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Atan2", UnityEngineMathf_m_Atan2_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Sqrt", UnityEngineMathf_m_Sqrt_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Abs", UnityEngineMathf_m_Abs_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Min", UnityEngineMathf_m_Min_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Max", UnityEngineMathf_m_Max_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Pow", UnityEngineMathf_m_Pow_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Exp", UnityEngineMathf_m_Exp_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Log", UnityEngineMathf_m_Log_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Log10", UnityEngineMathf_m_Log10_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Ceil", UnityEngineMathf_m_Ceil_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Floor", UnityEngineMathf_m_Floor_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Round", UnityEngineMathf_m_Round_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CeilToInt", UnityEngineMathf_m_CeilToInt_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FloorToInt", UnityEngineMathf_m_FloorToInt_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RoundToInt", UnityEngineMathf_m_RoundToInt_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Sign", UnityEngineMathf_m_Sign_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Clamp", UnityEngineMathf_m_Clamp_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Clamp01", UnityEngineMathf_m_Clamp01_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Lerp", UnityEngineMathf_m_Lerp_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LerpUnclamped", UnityEngineMathf_m_LerpUnclamped_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LerpAngle", UnityEngineMathf_m_LerpAngle_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MoveTowards", UnityEngineMathf_m_MoveTowards_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MoveTowardsAngle", UnityEngineMathf_m_MoveTowardsAngle_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SmoothStep", UnityEngineMathf_m_SmoothStep_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Gamma", UnityEngineMathf_m_Gamma_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Approximately", UnityEngineMathf_m_Approximately_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SmoothDamp", UnityEngineMathf_m_SmoothDamp_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SmoothDampAngle", UnityEngineMathf_m_SmoothDampAngle_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Repeat", UnityEngineMathf_m_Repeat_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "PingPong", UnityEngineMathf_m_PingPong_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "InverseLerp", UnityEngineMathf_m_InverseLerp_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DeltaAngle", UnityEngineMathf_m_DeltaAngle_xlua_st_);
            
			
            Utils.RegisterObject(L, this, Utils.CLS_IDX, "PI", UnityEngine.Mathf.PI);
            Utils.RegisterObject(L, this, Utils.CLS_IDX, "Infinity", UnityEngine.Mathf.Infinity);
            Utils.RegisterObject(L, this, Utils.CLS_IDX, "NegativeInfinity", UnityEngine.Mathf.NegativeInfinity);
            Utils.RegisterObject(L, this, Utils.CLS_IDX, "Deg2Rad", UnityEngine.Mathf.Deg2Rad);
            Utils.RegisterObject(L, this, Utils.CLS_IDX, "Rad2Deg", UnityEngine.Mathf.Rad2Deg);
            Utils.RegisterObject(L, this, Utils.CLS_IDX, "Epsilon", UnityEngine.Mathf.Epsilon);
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineMathf(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			
			if (gen_param_count == 1)
			{
				translator.Push(L, default(UnityEngine.Mathf));
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Mathf constructor!");
            
        }
        
		
        
		
        
        
        
        
        int UnityEngineMathf_m_ClosestPowerOfTwo_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				int _value = LuaAPI.xlua_tointeger(L, 1);
				
				int gen_ret = UnityEngine.Mathf.ClosestPowerOfTwo( _value );
				LuaAPI.xlua_pushinteger(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineMathf_m_IsPowerOfTwo_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				int _value = LuaAPI.xlua_tointeger(L, 1);
				
				bool gen_ret = UnityEngine.Mathf.IsPowerOfTwo( _value );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineMathf_m_NextPowerOfTwo_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				int _value = LuaAPI.xlua_tointeger(L, 1);
				
				int gen_ret = UnityEngine.Mathf.NextPowerOfTwo( _value );
				LuaAPI.xlua_pushinteger(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineMathf_m_GammaToLinearSpace_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				float _value = (float)LuaAPI.lua_tonumber(L, 1);
				
				float gen_ret = UnityEngine.Mathf.GammaToLinearSpace( _value );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineMathf_m_LinearToGammaSpace_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				float _value = (float)LuaAPI.lua_tonumber(L, 1);
				
				float gen_ret = UnityEngine.Mathf.LinearToGammaSpace( _value );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineMathf_m_CorrelatedColorTemperatureToRGB_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				float _kelvin = (float)LuaAPI.lua_tonumber(L, 1);
				
				UnityEngine.Color gen_ret = UnityEngine.Mathf.CorrelatedColorTemperatureToRGB( _kelvin );
				translator.PushUnityEngineColor(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineMathf_m_FloatToHalf_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				float _val = (float)LuaAPI.lua_tonumber(L, 1);
				
				ushort gen_ret = UnityEngine.Mathf.FloatToHalf( _val );
				LuaAPI.xlua_pushinteger(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineMathf_m_HalfToFloat_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				ushort _val = (ushort)LuaAPI.xlua_tointeger(L, 1);
				
				float gen_ret = UnityEngine.Mathf.HalfToFloat( _val );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineMathf_m_PerlinNoise_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				float _x = (float)LuaAPI.lua_tonumber(L, 1);
				float _y = (float)LuaAPI.lua_tonumber(L, 2);
				
				float gen_ret = UnityEngine.Mathf.PerlinNoise( _x, _y );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineMathf_m_Sin_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				float _f = (float)LuaAPI.lua_tonumber(L, 1);
				
				float gen_ret = UnityEngine.Mathf.Sin( _f );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineMathf_m_Cos_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				float _f = (float)LuaAPI.lua_tonumber(L, 1);
				
				float gen_ret = UnityEngine.Mathf.Cos( _f );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineMathf_m_Tan_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				float _f = (float)LuaAPI.lua_tonumber(L, 1);
				
				float gen_ret = UnityEngine.Mathf.Tan( _f );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineMathf_m_Asin_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				float _f = (float)LuaAPI.lua_tonumber(L, 1);
				
				float gen_ret = UnityEngine.Mathf.Asin( _f );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineMathf_m_Acos_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				float _f = (float)LuaAPI.lua_tonumber(L, 1);
				
				float gen_ret = UnityEngine.Mathf.Acos( _f );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineMathf_m_Atan_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				float _f = (float)LuaAPI.lua_tonumber(L, 1);
				
				float gen_ret = UnityEngine.Mathf.Atan( _f );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineMathf_m_Atan2_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				float _y = (float)LuaAPI.lua_tonumber(L, 1);
				float _x = (float)LuaAPI.lua_tonumber(L, 2);
				
				float gen_ret = UnityEngine.Mathf.Atan2( _y, _x );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineMathf_m_Sqrt_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				float _f = (float)LuaAPI.lua_tonumber(L, 1);
				
				float gen_ret = UnityEngine.Mathf.Sqrt( _f );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineMathf_m_Abs_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
			{
				float _f = (float)LuaAPI.lua_tonumber(L, 1);
				
				float gen_ret = UnityEngine.Mathf.Abs( _f );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
			{
				int _value = LuaAPI.xlua_tointeger(L, 1);
				
				int gen_ret = UnityEngine.Mathf.Abs( _value );
				LuaAPI.xlua_pushinteger(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Mathf.Abs!");
            
        }
        
        int UnityEngineMathf_m_Min_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
			{
				float _a = (float)LuaAPI.lua_tonumber(L, 1);
				float _b = (float)LuaAPI.lua_tonumber(L, 2);
				
				float gen_ret = UnityEngine.Mathf.Min( _a, _b );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
			{
				int _a = LuaAPI.xlua_tointeger(L, 1);
				int _b = LuaAPI.xlua_tointeger(L, 2);
				
				int gen_ret = UnityEngine.Mathf.Min( _a, _b );
				LuaAPI.xlua_pushinteger(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count >= 0&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 1) || LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1))) 
			{
				float[] _values = translator.GetParams<float>(L, 1);
				
				float gen_ret = UnityEngine.Mathf.Min( _values );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count >= 0&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 1) || LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1))) 
			{
				int[] _values = translator.GetParams<int>(L, 1);
				
				int gen_ret = UnityEngine.Mathf.Min( _values );
				LuaAPI.xlua_pushinteger(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Mathf.Min!");
            
        }
        
        int UnityEngineMathf_m_Max_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
			{
				float _a = (float)LuaAPI.lua_tonumber(L, 1);
				float _b = (float)LuaAPI.lua_tonumber(L, 2);
				
				float gen_ret = UnityEngine.Mathf.Max( _a, _b );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
			{
				int _a = LuaAPI.xlua_tointeger(L, 1);
				int _b = LuaAPI.xlua_tointeger(L, 2);
				
				int gen_ret = UnityEngine.Mathf.Max( _a, _b );
				LuaAPI.xlua_pushinteger(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count >= 0&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 1) || LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1))) 
			{
				float[] _values = translator.GetParams<float>(L, 1);
				
				float gen_ret = UnityEngine.Mathf.Max( _values );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count >= 0&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 1) || LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1))) 
			{
				int[] _values = translator.GetParams<int>(L, 1);
				
				int gen_ret = UnityEngine.Mathf.Max( _values );
				LuaAPI.xlua_pushinteger(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Mathf.Max!");
            
        }
        
        int UnityEngineMathf_m_Pow_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				float _f = (float)LuaAPI.lua_tonumber(L, 1);
				float _p = (float)LuaAPI.lua_tonumber(L, 2);
				
				float gen_ret = UnityEngine.Mathf.Pow( _f, _p );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineMathf_m_Exp_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				float _power = (float)LuaAPI.lua_tonumber(L, 1);
				
				float gen_ret = UnityEngine.Mathf.Exp( _power );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineMathf_m_Log_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
			{
				float _f = (float)LuaAPI.lua_tonumber(L, 1);
				
				float gen_ret = UnityEngine.Mathf.Log( _f );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
			{
				float _f = (float)LuaAPI.lua_tonumber(L, 1);
				float _p = (float)LuaAPI.lua_tonumber(L, 2);
				
				float gen_ret = UnityEngine.Mathf.Log( _f, _p );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Mathf.Log!");
            
        }
        
        int UnityEngineMathf_m_Log10_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				float _f = (float)LuaAPI.lua_tonumber(L, 1);
				
				float gen_ret = UnityEngine.Mathf.Log10( _f );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineMathf_m_Ceil_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				float _f = (float)LuaAPI.lua_tonumber(L, 1);
				
				float gen_ret = UnityEngine.Mathf.Ceil( _f );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineMathf_m_Floor_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				float _f = (float)LuaAPI.lua_tonumber(L, 1);
				
				float gen_ret = UnityEngine.Mathf.Floor( _f );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineMathf_m_Round_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				float _f = (float)LuaAPI.lua_tonumber(L, 1);
				
				float gen_ret = UnityEngine.Mathf.Round( _f );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineMathf_m_CeilToInt_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				float _f = (float)LuaAPI.lua_tonumber(L, 1);
				
				int gen_ret = UnityEngine.Mathf.CeilToInt( _f );
				LuaAPI.xlua_pushinteger(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineMathf_m_FloorToInt_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				float _f = (float)LuaAPI.lua_tonumber(L, 1);
				
				int gen_ret = UnityEngine.Mathf.FloorToInt( _f );
				LuaAPI.xlua_pushinteger(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineMathf_m_RoundToInt_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				float _f = (float)LuaAPI.lua_tonumber(L, 1);
				
				int gen_ret = UnityEngine.Mathf.RoundToInt( _f );
				LuaAPI.xlua_pushinteger(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineMathf_m_Sign_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				float _f = (float)LuaAPI.lua_tonumber(L, 1);
				
				float gen_ret = UnityEngine.Mathf.Sign( _f );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineMathf_m_Clamp_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
			{
				float _value = (float)LuaAPI.lua_tonumber(L, 1);
				float _min = (float)LuaAPI.lua_tonumber(L, 2);
				float _max = (float)LuaAPI.lua_tonumber(L, 3);
				
				float gen_ret = UnityEngine.Mathf.Clamp( _value, _min, _max );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
			{
				int _value = LuaAPI.xlua_tointeger(L, 1);
				int _min = LuaAPI.xlua_tointeger(L, 2);
				int _max = LuaAPI.xlua_tointeger(L, 3);
				
				int gen_ret = UnityEngine.Mathf.Clamp( _value, _min, _max );
				LuaAPI.xlua_pushinteger(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Mathf.Clamp!");
            
        }
        
        int UnityEngineMathf_m_Clamp01_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				float _value = (float)LuaAPI.lua_tonumber(L, 1);
				
				float gen_ret = UnityEngine.Mathf.Clamp01( _value );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineMathf_m_Lerp_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				float _a = (float)LuaAPI.lua_tonumber(L, 1);
				float _b = (float)LuaAPI.lua_tonumber(L, 2);
				float _t = (float)LuaAPI.lua_tonumber(L, 3);
				
				float gen_ret = UnityEngine.Mathf.Lerp( _a, _b, _t );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineMathf_m_LerpUnclamped_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				float _a = (float)LuaAPI.lua_tonumber(L, 1);
				float _b = (float)LuaAPI.lua_tonumber(L, 2);
				float _t = (float)LuaAPI.lua_tonumber(L, 3);
				
				float gen_ret = UnityEngine.Mathf.LerpUnclamped( _a, _b, _t );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineMathf_m_LerpAngle_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				float _a = (float)LuaAPI.lua_tonumber(L, 1);
				float _b = (float)LuaAPI.lua_tonumber(L, 2);
				float _t = (float)LuaAPI.lua_tonumber(L, 3);
				
				float gen_ret = UnityEngine.Mathf.LerpAngle( _a, _b, _t );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineMathf_m_MoveTowards_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				float _current = (float)LuaAPI.lua_tonumber(L, 1);
				float _target = (float)LuaAPI.lua_tonumber(L, 2);
				float _maxDelta = (float)LuaAPI.lua_tonumber(L, 3);
				
				float gen_ret = UnityEngine.Mathf.MoveTowards( _current, _target, _maxDelta );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineMathf_m_MoveTowardsAngle_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				float _current = (float)LuaAPI.lua_tonumber(L, 1);
				float _target = (float)LuaAPI.lua_tonumber(L, 2);
				float _maxDelta = (float)LuaAPI.lua_tonumber(L, 3);
				
				float gen_ret = UnityEngine.Mathf.MoveTowardsAngle( _current, _target, _maxDelta );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineMathf_m_SmoothStep_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				float _from = (float)LuaAPI.lua_tonumber(L, 1);
				float _to = (float)LuaAPI.lua_tonumber(L, 2);
				float _t = (float)LuaAPI.lua_tonumber(L, 3);
				
				float gen_ret = UnityEngine.Mathf.SmoothStep( _from, _to, _t );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineMathf_m_Gamma_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				float _value = (float)LuaAPI.lua_tonumber(L, 1);
				float _absmax = (float)LuaAPI.lua_tonumber(L, 2);
				float _gamma = (float)LuaAPI.lua_tonumber(L, 3);
				
				float gen_ret = UnityEngine.Mathf.Gamma( _value, _absmax, _gamma );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineMathf_m_Approximately_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				float _a = (float)LuaAPI.lua_tonumber(L, 1);
				float _b = (float)LuaAPI.lua_tonumber(L, 2);
				
				bool gen_ret = UnityEngine.Mathf.Approximately( _a, _b );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineMathf_m_SmoothDamp_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
			{
				float _current = (float)LuaAPI.lua_tonumber(L, 1);
				float _target = (float)LuaAPI.lua_tonumber(L, 2);
				float _currentVelocity = (float)LuaAPI.lua_tonumber(L, 3);
				float _smoothTime = (float)LuaAPI.lua_tonumber(L, 4);
				
				float gen_ret = UnityEngine.Mathf.SmoothDamp( _current, _target, ref _currentVelocity, _smoothTime );
				LuaAPI.lua_pushnumber(L, gen_ret);
				LuaAPI.lua_pushnumber(L, _currentVelocity);
					
				
				
				
				return 2;
			}
			if(gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
			{
				float _current = (float)LuaAPI.lua_tonumber(L, 1);
				float _target = (float)LuaAPI.lua_tonumber(L, 2);
				float _currentVelocity = (float)LuaAPI.lua_tonumber(L, 3);
				float _smoothTime = (float)LuaAPI.lua_tonumber(L, 4);
				float _maxSpeed = (float)LuaAPI.lua_tonumber(L, 5);
				
				float gen_ret = UnityEngine.Mathf.SmoothDamp( _current, _target, ref _currentVelocity, _smoothTime, _maxSpeed );
				LuaAPI.lua_pushnumber(L, gen_ret);
				LuaAPI.lua_pushnumber(L, _currentVelocity);
					
				
				
				
				return 2;
			}
			if(gen_param_count == 6&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
			{
				float _current = (float)LuaAPI.lua_tonumber(L, 1);
				float _target = (float)LuaAPI.lua_tonumber(L, 2);
				float _currentVelocity = (float)LuaAPI.lua_tonumber(L, 3);
				float _smoothTime = (float)LuaAPI.lua_tonumber(L, 4);
				float _maxSpeed = (float)LuaAPI.lua_tonumber(L, 5);
				float _deltaTime = (float)LuaAPI.lua_tonumber(L, 6);
				
				float gen_ret = UnityEngine.Mathf.SmoothDamp( _current, _target, ref _currentVelocity, _smoothTime, _maxSpeed, _deltaTime );
				LuaAPI.lua_pushnumber(L, gen_ret);
				LuaAPI.lua_pushnumber(L, _currentVelocity);
					
				
				
				
				return 2;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Mathf.SmoothDamp!");
            
        }
        
        int UnityEngineMathf_m_SmoothDampAngle_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
			{
				float _current = (float)LuaAPI.lua_tonumber(L, 1);
				float _target = (float)LuaAPI.lua_tonumber(L, 2);
				float _currentVelocity = (float)LuaAPI.lua_tonumber(L, 3);
				float _smoothTime = (float)LuaAPI.lua_tonumber(L, 4);
				
				float gen_ret = UnityEngine.Mathf.SmoothDampAngle( _current, _target, ref _currentVelocity, _smoothTime );
				LuaAPI.lua_pushnumber(L, gen_ret);
				LuaAPI.lua_pushnumber(L, _currentVelocity);
					
				
				
				
				return 2;
			}
			if(gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
			{
				float _current = (float)LuaAPI.lua_tonumber(L, 1);
				float _target = (float)LuaAPI.lua_tonumber(L, 2);
				float _currentVelocity = (float)LuaAPI.lua_tonumber(L, 3);
				float _smoothTime = (float)LuaAPI.lua_tonumber(L, 4);
				float _maxSpeed = (float)LuaAPI.lua_tonumber(L, 5);
				
				float gen_ret = UnityEngine.Mathf.SmoothDampAngle( _current, _target, ref _currentVelocity, _smoothTime, _maxSpeed );
				LuaAPI.lua_pushnumber(L, gen_ret);
				LuaAPI.lua_pushnumber(L, _currentVelocity);
					
				
				
				
				return 2;
			}
			if(gen_param_count == 6&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
			{
				float _current = (float)LuaAPI.lua_tonumber(L, 1);
				float _target = (float)LuaAPI.lua_tonumber(L, 2);
				float _currentVelocity = (float)LuaAPI.lua_tonumber(L, 3);
				float _smoothTime = (float)LuaAPI.lua_tonumber(L, 4);
				float _maxSpeed = (float)LuaAPI.lua_tonumber(L, 5);
				float _deltaTime = (float)LuaAPI.lua_tonumber(L, 6);
				
				float gen_ret = UnityEngine.Mathf.SmoothDampAngle( _current, _target, ref _currentVelocity, _smoothTime, _maxSpeed, _deltaTime );
				LuaAPI.lua_pushnumber(L, gen_ret);
				LuaAPI.lua_pushnumber(L, _currentVelocity);
					
				
				
				
				return 2;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Mathf.SmoothDampAngle!");
            
        }
        
        int UnityEngineMathf_m_Repeat_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				float _t = (float)LuaAPI.lua_tonumber(L, 1);
				float _length = (float)LuaAPI.lua_tonumber(L, 2);
				
				float gen_ret = UnityEngine.Mathf.Repeat( _t, _length );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineMathf_m_PingPong_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				float _t = (float)LuaAPI.lua_tonumber(L, 1);
				float _length = (float)LuaAPI.lua_tonumber(L, 2);
				
				float gen_ret = UnityEngine.Mathf.PingPong( _t, _length );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineMathf_m_InverseLerp_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				float _a = (float)LuaAPI.lua_tonumber(L, 1);
				float _b = (float)LuaAPI.lua_tonumber(L, 2);
				float _value = (float)LuaAPI.lua_tonumber(L, 3);
				
				float gen_ret = UnityEngine.Mathf.InverseLerp( _a, _b, _value );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineMathf_m_DeltaAngle_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				float _current = (float)LuaAPI.lua_tonumber(L, 1);
				float _target = (float)LuaAPI.lua_tonumber(L, 2);
				
				float gen_ret = UnityEngine.Mathf.DeltaAngle( _current, _target );
				LuaAPI.lua_pushnumber(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
