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
        public void __RegisterUnityEngineRectOffset(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.RectOffset);
			Utils.BeginObjectRegister(type, L, this, 0, 3, 6, 4);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToString", UnityEngineRectOffset_m_ToString);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Add", UnityEngineRectOffset_m_Add);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Remove", UnityEngineRectOffset_m_Remove);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "left", UnityEngineRectOffset_g_get_left);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "right", UnityEngineRectOffset_g_get_right);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "top", UnityEngineRectOffset_g_get_top);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "bottom", UnityEngineRectOffset_g_get_bottom);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "horizontal", UnityEngineRectOffset_g_get_horizontal);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "vertical", UnityEngineRectOffset_g_get_vertical);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "left", UnityEngineRectOffset_s_set_left);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "right", UnityEngineRectOffset_s_set_right);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "top", UnityEngineRectOffset_s_set_top);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "bottom", UnityEngineRectOffset_s_set_bottom);
            
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineRectOffset, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineRectOffset(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			if(gen_param_count == 1)
			{
				
				UnityEngine.RectOffset gen_ret = new UnityEngine.RectOffset();
				translator.Push(L, gen_ret);
				
				return 1;
			}
			if(gen_param_count == 5 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5))
			{
				int _left = LuaAPI.xlua_tointeger(L, 2);
				int _right = LuaAPI.xlua_tointeger(L, 3);
				int _top = LuaAPI.xlua_tointeger(L, 4);
				int _bottom = LuaAPI.xlua_tointeger(L, 5);
				
				UnityEngine.RectOffset gen_ret = new UnityEngine.RectOffset(_left, _right, _top, _bottom);
				translator.Push(L, gen_ret);
				
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.RectOffset constructor!");
            
        }
        
		
        
		
        
        
        
        
        int UnityEngineRectOffset_m_ToString(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.RectOffset gen_to_be_invoked = (UnityEngine.RectOffset)translator.FastGetCSObj(L, 1);
            
			
			{
				
				string gen_ret = gen_to_be_invoked.ToString(  );
				LuaAPI.lua_pushstring(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineRectOffset_m_Add(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.RectOffset gen_to_be_invoked = (UnityEngine.RectOffset)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.Rect _rect;translator.Get(L, 2, out _rect);
				
				UnityEngine.Rect gen_ret = gen_to_be_invoked.Add( _rect );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineRectOffset_m_Remove(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.RectOffset gen_to_be_invoked = (UnityEngine.RectOffset)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.Rect _rect;translator.Get(L, 2, out _rect);
				
				UnityEngine.Rect gen_ret = gen_to_be_invoked.Remove( _rect );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        
        
        
        int UnityEngineRectOffset_g_get_left(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.RectOffset gen_to_be_invoked = (UnityEngine.RectOffset)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.left);
            return 1;
        }
        
        int UnityEngineRectOffset_g_get_right(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.RectOffset gen_to_be_invoked = (UnityEngine.RectOffset)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.right);
            return 1;
        }
        
        int UnityEngineRectOffset_g_get_top(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.RectOffset gen_to_be_invoked = (UnityEngine.RectOffset)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.top);
            return 1;
        }
        
        int UnityEngineRectOffset_g_get_bottom(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.RectOffset gen_to_be_invoked = (UnityEngine.RectOffset)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.bottom);
            return 1;
        }
        
        int UnityEngineRectOffset_g_get_horizontal(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.RectOffset gen_to_be_invoked = (UnityEngine.RectOffset)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.horizontal);
            return 1;
        }
        
        int UnityEngineRectOffset_g_get_vertical(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.RectOffset gen_to_be_invoked = (UnityEngine.RectOffset)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.vertical);
            return 1;
        }
        
        
        
        int UnityEngineRectOffset_s_set_left(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.RectOffset gen_to_be_invoked = (UnityEngine.RectOffset)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.left = LuaAPI.xlua_tointeger(L, 2);
            
            return 0;
        }
        
        int UnityEngineRectOffset_s_set_right(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.RectOffset gen_to_be_invoked = (UnityEngine.RectOffset)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.right = LuaAPI.xlua_tointeger(L, 2);
            
            return 0;
        }
        
        int UnityEngineRectOffset_s_set_top(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.RectOffset gen_to_be_invoked = (UnityEngine.RectOffset)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.top = LuaAPI.xlua_tointeger(L, 2);
            
            return 0;
        }
        
        int UnityEngineRectOffset_s_set_bottom(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.RectOffset gen_to_be_invoked = (UnityEngine.RectOffset)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.bottom = LuaAPI.xlua_tointeger(L, 2);
            
            return 0;
        }
        
		
		
		
		
    }
}
