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
        public void __RegisterUnityEngineColor(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.Color);
			Utils.BeginObjectRegister(type, L, this, 5, 3, 8, 4);
			Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__add", UnityEngineColor__AddMeta);
            Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__sub", UnityEngineColor__SubMeta);
            Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__mul", UnityEngineColor__MulMeta);
            Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__div", UnityEngineColor__DivMeta);
            Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__eq", UnityEngineColor__EqMeta);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToString", UnityEngineColor_m_ToString);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetHashCode", UnityEngineColor_m_GetHashCode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Equals", UnityEngineColor_m_Equals);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "grayscale", UnityEngineColor_g_get_grayscale);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "linear", UnityEngineColor_g_get_linear);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "gamma", UnityEngineColor_g_get_gamma);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "maxColorComponent", UnityEngineColor_g_get_maxColorComponent);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "r", UnityEngineColor_g_get_r);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "g", UnityEngineColor_g_get_g);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "b", UnityEngineColor_g_get_b);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "a", UnityEngineColor_g_get_a);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "r", UnityEngineColor_s_set_r);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "g", UnityEngineColor_s_set_g);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "b", UnityEngineColor_s_set_b);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "a", UnityEngineColor_s_set_a);
            
			
			Utils.EndObjectRegister(type, L, this, __CSIndexerUnityEngineColor, __NewIndexerUnityEngineColor,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineColor, 5, 11, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Lerp", UnityEngineColor_m_Lerp_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LerpUnclamped", UnityEngineColor_m_LerpUnclamped_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RGBToHSV", UnityEngineColor_m_RGBToHSV_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "HSVToRGB", UnityEngineColor_m_HSVToRGB_xlua_st_);
            
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "red", UnityEngineColor_g_get_red);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "green", UnityEngineColor_g_get_green);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "blue", UnityEngineColor_g_get_blue);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "white", UnityEngineColor_g_get_white);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "black", UnityEngineColor_g_get_black);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "yellow", UnityEngineColor_g_get_yellow);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "cyan", UnityEngineColor_g_get_cyan);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "magenta", UnityEngineColor_g_get_magenta);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "gray", UnityEngineColor_g_get_gray);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "grey", UnityEngineColor_g_get_grey);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "clear", UnityEngineColor_g_get_clear);
            
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineColor(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			if(gen_param_count == 5 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5))
			{
				float _r = (float)LuaAPI.lua_tonumber(L, 2);
				float _g = (float)LuaAPI.lua_tonumber(L, 3);
				float _b = (float)LuaAPI.lua_tonumber(L, 4);
				float _a = (float)LuaAPI.lua_tonumber(L, 5);
				
				UnityEngine.Color gen_ret = new UnityEngine.Color(_r, _g, _b, _a);
				translator.PushUnityEngineColor(L, gen_ret);
				
				return 1;
			}
			if(gen_param_count == 4 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4))
			{
				float _r = (float)LuaAPI.lua_tonumber(L, 2);
				float _g = (float)LuaAPI.lua_tonumber(L, 3);
				float _b = (float)LuaAPI.lua_tonumber(L, 4);
				
				UnityEngine.Color gen_ret = new UnityEngine.Color(_r, _g, _b);
				translator.PushUnityEngineColor(L, gen_ret);
				
				return 1;
			}
			
			if (gen_param_count == 1)
			{
				translator.PushUnityEngineColor(L, default(UnityEngine.Color));
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Color constructor!");
            
        }
        
		
        int __CSIndexerUnityEngineColor(RealStatePtr L, int gen_param_count) 
        {
			ObjectTranslator translator = this;
			
			if (translator.Assignable<UnityEngine.Color>(L, 1) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2))
			{
				
				UnityEngine.Color gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
				int index = LuaAPI.xlua_tointeger(L, 2);
				LuaAPI.lua_pushboolean(L, true);
				LuaAPI.lua_pushnumber(L, gen_to_be_invoked[index]);
				return 2;
			}
			
            LuaAPI.lua_pushboolean(L, false);
			return 1;
        }
		
        
		
        int __NewIndexerUnityEngineColor(RealStatePtr L, int gen_param_count) 
        {
			ObjectTranslator translator = this;
			
			
			if (translator.Assignable<UnityEngine.Color>(L, 1) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3))
			{
				
				UnityEngine.Color gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
				int key = LuaAPI.xlua_tointeger(L, 2);
				gen_to_be_invoked[key] = (float)LuaAPI.lua_tonumber(L, 3);
				LuaAPI.lua_pushboolean(L, true);
				return 1;
			}
			
			LuaAPI.lua_pushboolean(L, false);
            return 1;
        }
		
        
        
        int UnityEngineColor__AddMeta(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
            
			if (translator.Assignable<UnityEngine.Color>(L, 1) && translator.Assignable<UnityEngine.Color>(L, 2))
			{
				UnityEngine.Color leftside;translator.Get(L, 1, out leftside);
				UnityEngine.Color rightside;translator.Get(L, 2, out rightside);
				
				translator.PushUnityEngineColor(L, leftside + rightside);
				
				return 1;
			}
            
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of + operator, need UnityEngine.Color!");
            
        }
        
        int UnityEngineColor__SubMeta(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
            
			if (translator.Assignable<UnityEngine.Color>(L, 1) && translator.Assignable<UnityEngine.Color>(L, 2))
			{
				UnityEngine.Color leftside;translator.Get(L, 1, out leftside);
				UnityEngine.Color rightside;translator.Get(L, 2, out rightside);
				
				translator.PushUnityEngineColor(L, leftside - rightside);
				
				return 1;
			}
            
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of - operator, need UnityEngine.Color!");
            
        }
        
        int UnityEngineColor__MulMeta(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
            
			if (translator.Assignable<UnityEngine.Color>(L, 1) && translator.Assignable<UnityEngine.Color>(L, 2))
			{
				UnityEngine.Color leftside;translator.Get(L, 1, out leftside);
				UnityEngine.Color rightside;translator.Get(L, 2, out rightside);
				
				translator.PushUnityEngineColor(L, leftside * rightside);
				
				return 1;
			}
            
			if (translator.Assignable<UnityEngine.Color>(L, 1) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2))
			{
				UnityEngine.Color leftside;translator.Get(L, 1, out leftside);
				float rightside = (float)LuaAPI.lua_tonumber(L, 2);
				
				translator.PushUnityEngineColor(L, leftside * rightside);
				
				return 1;
			}
            
			if (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1) && translator.Assignable<UnityEngine.Color>(L, 2))
			{
				float leftside = (float)LuaAPI.lua_tonumber(L, 1);
				UnityEngine.Color rightside;translator.Get(L, 2, out rightside);
				
				translator.PushUnityEngineColor(L, leftside * rightside);
				
				return 1;
			}
            
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of * operator, need UnityEngine.Color!");
            
        }
        
        int UnityEngineColor__DivMeta(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
            
			if (translator.Assignable<UnityEngine.Color>(L, 1) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2))
			{
				UnityEngine.Color leftside;translator.Get(L, 1, out leftside);
				float rightside = (float)LuaAPI.lua_tonumber(L, 2);
				
				translator.PushUnityEngineColor(L, leftside / rightside);
				
				return 1;
			}
            
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of / operator, need UnityEngine.Color!");
            
        }
        
        int UnityEngineColor__EqMeta(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
            
			if (translator.Assignable<UnityEngine.Color>(L, 1) && translator.Assignable<UnityEngine.Color>(L, 2))
			{
				UnityEngine.Color leftside;translator.Get(L, 1, out leftside);
				UnityEngine.Color rightside;translator.Get(L, 2, out rightside);
				
				LuaAPI.lua_pushboolean(L, leftside == rightside);
				
				return 1;
			}
            
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of == operator, need UnityEngine.Color!");
            
        }
        
        
        
        int UnityEngineColor_m_ToString(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Color gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			if(gen_param_count == 1) 
			{
				
				string gen_ret = gen_to_be_invoked.ToString(  );
				LuaAPI.lua_pushstring(L, gen_ret);
				
				
				translator.UpdateUnityEngineColor(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
			{
				string _format = LuaAPI.lua_tostring(L, 2);
				
				string gen_ret = gen_to_be_invoked.ToString( _format );
				LuaAPI.lua_pushstring(L, gen_ret);
				
				
				translator.UpdateUnityEngineColor(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Color.ToString!");
            
        }
        
        int UnityEngineColor_m_GetHashCode(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Color gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			
			{
				
				int gen_ret = gen_to_be_invoked.GetHashCode(  );
				LuaAPI.xlua_pushinteger(L, gen_ret);
				
				
				translator.UpdateUnityEngineColor(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineColor_m_Equals(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Color gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			if(gen_param_count == 2&& translator.Assignable<object>(L, 2)) 
			{
				object _other = translator.GetObject(L, 2, typeof(object));
				
				bool gen_ret = gen_to_be_invoked.Equals( _other );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				translator.UpdateUnityEngineColor(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.Color>(L, 2)) 
			{
				UnityEngine.Color _other;translator.Get(L, 2, out _other);
				
				bool gen_ret = gen_to_be_invoked.Equals( _other );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				translator.UpdateUnityEngineColor(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Color.Equals!");
            
        }
        
        int UnityEngineColor_m_Lerp_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Color _a;translator.Get(L, 1, out _a);
				UnityEngine.Color _b;translator.Get(L, 2, out _b);
				float _t = (float)LuaAPI.lua_tonumber(L, 3);
				
				UnityEngine.Color gen_ret = UnityEngine.Color.Lerp( _a, _b, _t );
				translator.PushUnityEngineColor(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineColor_m_LerpUnclamped_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Color _a;translator.Get(L, 1, out _a);
				UnityEngine.Color _b;translator.Get(L, 2, out _b);
				float _t = (float)LuaAPI.lua_tonumber(L, 3);
				
				UnityEngine.Color gen_ret = UnityEngine.Color.LerpUnclamped( _a, _b, _t );
				translator.PushUnityEngineColor(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineColor_m_RGBToHSV_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Color _rgbColor;translator.Get(L, 1, out _rgbColor);
				float _H;
				float _S;
				float _V;
				
				UnityEngine.Color.RGBToHSV( _rgbColor, out _H, out _S, out _V );
				LuaAPI.lua_pushnumber(L, _H);
					
				LuaAPI.lua_pushnumber(L, _S);
					
				LuaAPI.lua_pushnumber(L, _V);
					
				
				
				
				return 3;
			}
			
            
        }
        
        int UnityEngineColor_m_HSVToRGB_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
			{
				float _H = (float)LuaAPI.lua_tonumber(L, 1);
				float _S = (float)LuaAPI.lua_tonumber(L, 2);
				float _V = (float)LuaAPI.lua_tonumber(L, 3);
				
				UnityEngine.Color gen_ret = UnityEngine.Color.HSVToRGB( _H, _S, _V );
				translator.PushUnityEngineColor(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)) 
			{
				float _H = (float)LuaAPI.lua_tonumber(L, 1);
				float _S = (float)LuaAPI.lua_tonumber(L, 2);
				float _V = (float)LuaAPI.lua_tonumber(L, 3);
				bool _hdr = LuaAPI.lua_toboolean(L, 4);
				
				UnityEngine.Color gen_ret = UnityEngine.Color.HSVToRGB( _H, _S, _V, _hdr );
				translator.PushUnityEngineColor(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Color.HSVToRGB!");
            
        }
        
        
        
        
        int UnityEngineColor_g_get_red(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.PushUnityEngineColor(L, UnityEngine.Color.red);
            return 1;
        }
        
        int UnityEngineColor_g_get_green(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.PushUnityEngineColor(L, UnityEngine.Color.green);
            return 1;
        }
        
        int UnityEngineColor_g_get_blue(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.PushUnityEngineColor(L, UnityEngine.Color.blue);
            return 1;
        }
        
        int UnityEngineColor_g_get_white(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.PushUnityEngineColor(L, UnityEngine.Color.white);
            return 1;
        }
        
        int UnityEngineColor_g_get_black(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.PushUnityEngineColor(L, UnityEngine.Color.black);
            return 1;
        }
        
        int UnityEngineColor_g_get_yellow(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.PushUnityEngineColor(L, UnityEngine.Color.yellow);
            return 1;
        }
        
        int UnityEngineColor_g_get_cyan(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.PushUnityEngineColor(L, UnityEngine.Color.cyan);
            return 1;
        }
        
        int UnityEngineColor_g_get_magenta(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.PushUnityEngineColor(L, UnityEngine.Color.magenta);
            return 1;
        }
        
        int UnityEngineColor_g_get_gray(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.PushUnityEngineColor(L, UnityEngine.Color.gray);
            return 1;
        }
        
        int UnityEngineColor_g_get_grey(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.PushUnityEngineColor(L, UnityEngine.Color.grey);
            return 1;
        }
        
        int UnityEngineColor_g_get_clear(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.PushUnityEngineColor(L, UnityEngine.Color.clear);
            return 1;
        }
        
        int UnityEngineColor_g_get_grayscale(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Color gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.grayscale);
            return 1;
        }
        
        int UnityEngineColor_g_get_linear(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Color gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			translator.PushUnityEngineColor(L, gen_to_be_invoked.linear);
            return 1;
        }
        
        int UnityEngineColor_g_get_gamma(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Color gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			translator.PushUnityEngineColor(L, gen_to_be_invoked.gamma);
            return 1;
        }
        
        int UnityEngineColor_g_get_maxColorComponent(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Color gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.maxColorComponent);
            return 1;
        }
        
        int UnityEngineColor_g_get_r(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Color gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.r);
            return 1;
        }
        
        int UnityEngineColor_g_get_g(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Color gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.g);
            return 1;
        }
        
        int UnityEngineColor_g_get_b(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Color gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.b);
            return 1;
        }
        
        int UnityEngineColor_g_get_a(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Color gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.a);
            return 1;
        }
        
        
        
        int UnityEngineColor_s_set_r(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Color gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            gen_to_be_invoked.r = (float)LuaAPI.lua_tonumber(L, 2);
            
            translator.UpdateUnityEngineColor(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineColor_s_set_g(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Color gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            gen_to_be_invoked.g = (float)LuaAPI.lua_tonumber(L, 2);
            
            translator.UpdateUnityEngineColor(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineColor_s_set_b(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Color gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            gen_to_be_invoked.b = (float)LuaAPI.lua_tonumber(L, 2);
            
            translator.UpdateUnityEngineColor(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineColor_s_set_a(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Color gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            gen_to_be_invoked.a = (float)LuaAPI.lua_tonumber(L, 2);
            
            translator.UpdateUnityEngineColor(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
		
		
		
		
    }
}
