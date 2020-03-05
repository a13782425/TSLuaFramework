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
        public void __RegisterUnityEngineRect(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.Rect);
			Utils.BeginObjectRegister(type, L, this, 1, 6, 13, 13);
			Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__eq", UnityEngineRect__EqMeta);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Set", UnityEngineRect_m_Set);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Contains", UnityEngineRect_m_Contains);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Overlaps", UnityEngineRect_m_Overlaps);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetHashCode", UnityEngineRect_m_GetHashCode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Equals", UnityEngineRect_m_Equals);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToString", UnityEngineRect_m_ToString);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "x", UnityEngineRect_g_get_x);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "y", UnityEngineRect_g_get_y);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "position", UnityEngineRect_g_get_position);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "center", UnityEngineRect_g_get_center);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "min", UnityEngineRect_g_get_min);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "max", UnityEngineRect_g_get_max);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "width", UnityEngineRect_g_get_width);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "height", UnityEngineRect_g_get_height);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "size", UnityEngineRect_g_get_size);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "xMin", UnityEngineRect_g_get_xMin);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "yMin", UnityEngineRect_g_get_yMin);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "xMax", UnityEngineRect_g_get_xMax);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "yMax", UnityEngineRect_g_get_yMax);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "x", UnityEngineRect_s_set_x);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "y", UnityEngineRect_s_set_y);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "position", UnityEngineRect_s_set_position);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "center", UnityEngineRect_s_set_center);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "min", UnityEngineRect_s_set_min);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "max", UnityEngineRect_s_set_max);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "width", UnityEngineRect_s_set_width);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "height", UnityEngineRect_s_set_height);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "size", UnityEngineRect_s_set_size);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "xMin", UnityEngineRect_s_set_xMin);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "yMin", UnityEngineRect_s_set_yMin);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "xMax", UnityEngineRect_s_set_xMax);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "yMax", UnityEngineRect_s_set_yMax);
            
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineRect, 4, 1, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "MinMaxRect", UnityEngineRect_m_MinMaxRect_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "NormalizedToPoint", UnityEngineRect_m_NormalizedToPoint_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "PointToNormalized", UnityEngineRect_m_PointToNormalized_xlua_st_);
            
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "zero", UnityEngineRect_g_get_zero);
            
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineRect(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			if(gen_param_count == 5 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5))
			{
				float _x = (float)LuaAPI.lua_tonumber(L, 2);
				float _y = (float)LuaAPI.lua_tonumber(L, 3);
				float _width = (float)LuaAPI.lua_tonumber(L, 4);
				float _height = (float)LuaAPI.lua_tonumber(L, 5);
				
				UnityEngine.Rect gen_ret = new UnityEngine.Rect(_x, _y, _width, _height);
				translator.Push(L, gen_ret);
				
				return 1;
			}
			if(gen_param_count == 3 && translator.Assignable<UnityEngine.Vector2>(L, 2) && translator.Assignable<UnityEngine.Vector2>(L, 3))
			{
				UnityEngine.Vector2 _position;translator.Get(L, 2, out _position);
				UnityEngine.Vector2 _size;translator.Get(L, 3, out _size);
				
				UnityEngine.Rect gen_ret = new UnityEngine.Rect(_position, _size);
				translator.Push(L, gen_ret);
				
				return 1;
			}
			if(gen_param_count == 2 && translator.Assignable<UnityEngine.Rect>(L, 2))
			{
				UnityEngine.Rect _source;translator.Get(L, 2, out _source);
				
				UnityEngine.Rect gen_ret = new UnityEngine.Rect(_source);
				translator.Push(L, gen_ret);
				
				return 1;
			}
			
			if (gen_param_count == 1)
			{
				translator.Push(L, default(UnityEngine.Rect));
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rect constructor!");
            
        }
        
		
        
		
        
        
        int UnityEngineRect__EqMeta(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
            
			if (translator.Assignable<UnityEngine.Rect>(L, 1) && translator.Assignable<UnityEngine.Rect>(L, 2))
			{
				UnityEngine.Rect leftside;translator.Get(L, 1, out leftside);
				UnityEngine.Rect rightside;translator.Get(L, 2, out rightside);
				
				LuaAPI.lua_pushboolean(L, leftside == rightside);
				
				return 1;
			}
            
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of == operator, need UnityEngine.Rect!");
            
        }
        
        
        
        int UnityEngineRect_m_MinMaxRect_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				float _xmin = (float)LuaAPI.lua_tonumber(L, 1);
				float _ymin = (float)LuaAPI.lua_tonumber(L, 2);
				float _xmax = (float)LuaAPI.lua_tonumber(L, 3);
				float _ymax = (float)LuaAPI.lua_tonumber(L, 4);
				
				UnityEngine.Rect gen_ret = UnityEngine.Rect.MinMaxRect( _xmin, _ymin, _xmax, _ymax );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineRect_m_Set(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Rect gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			
			{
				float _x = (float)LuaAPI.lua_tonumber(L, 2);
				float _y = (float)LuaAPI.lua_tonumber(L, 3);
				float _width = (float)LuaAPI.lua_tonumber(L, 4);
				float _height = (float)LuaAPI.lua_tonumber(L, 5);
				
				gen_to_be_invoked.Set( _x, _y, _width, _height );
				
				
				translator.Update(L, 1, gen_to_be_invoked);
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineRect_m_Contains(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Rect gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector2>(L, 2)) 
			{
				UnityEngine.Vector2 _point;translator.Get(L, 2, out _point);
				
				bool gen_ret = gen_to_be_invoked.Contains( _point );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				translator.Update(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
			{
				UnityEngine.Vector3 _point;translator.Get(L, 2, out _point);
				
				bool gen_ret = gen_to_be_invoked.Contains( _point );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				translator.Update(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
			{
				UnityEngine.Vector3 _point;translator.Get(L, 2, out _point);
				bool _allowInverse = LuaAPI.lua_toboolean(L, 3);
				
				bool gen_ret = gen_to_be_invoked.Contains( _point, _allowInverse );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				translator.Update(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rect.Contains!");
            
        }
        
        int UnityEngineRect_m_Overlaps(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Rect gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.Rect>(L, 2)) 
			{
				UnityEngine.Rect _other;translator.Get(L, 2, out _other);
				
				bool gen_ret = gen_to_be_invoked.Overlaps( _other );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				translator.Update(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			if(gen_param_count == 3&& translator.Assignable<UnityEngine.Rect>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
			{
				UnityEngine.Rect _other;translator.Get(L, 2, out _other);
				bool _allowInverse = LuaAPI.lua_toboolean(L, 3);
				
				bool gen_ret = gen_to_be_invoked.Overlaps( _other, _allowInverse );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				translator.Update(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rect.Overlaps!");
            
        }
        
        int UnityEngineRect_m_NormalizedToPoint_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Rect _rectangle;translator.Get(L, 1, out _rectangle);
				UnityEngine.Vector2 _normalizedRectCoordinates;translator.Get(L, 2, out _normalizedRectCoordinates);
				
				UnityEngine.Vector2 gen_ret = UnityEngine.Rect.NormalizedToPoint( _rectangle, _normalizedRectCoordinates );
				translator.PushUnityEngineVector2(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineRect_m_PointToNormalized_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.Rect _rectangle;translator.Get(L, 1, out _rectangle);
				UnityEngine.Vector2 _point;translator.Get(L, 2, out _point);
				
				UnityEngine.Vector2 gen_ret = UnityEngine.Rect.PointToNormalized( _rectangle, _point );
				translator.PushUnityEngineVector2(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineRect_m_GetHashCode(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Rect gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			
			{
				
				int gen_ret = gen_to_be_invoked.GetHashCode(  );
				LuaAPI.xlua_pushinteger(L, gen_ret);
				
				
				translator.Update(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineRect_m_Equals(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Rect gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			if(gen_param_count == 2&& translator.Assignable<object>(L, 2)) 
			{
				object _other = translator.GetObject(L, 2, typeof(object));
				
				bool gen_ret = gen_to_be_invoked.Equals( _other );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				translator.Update(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.Rect>(L, 2)) 
			{
				UnityEngine.Rect _other;translator.Get(L, 2, out _other);
				
				bool gen_ret = gen_to_be_invoked.Equals( _other );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				translator.Update(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rect.Equals!");
            
        }
        
        int UnityEngineRect_m_ToString(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Rect gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
			if(gen_param_count == 1) 
			{
				
				string gen_ret = gen_to_be_invoked.ToString(  );
				LuaAPI.lua_pushstring(L, gen_ret);
				
				
				translator.Update(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
			{
				string _format = LuaAPI.lua_tostring(L, 2);
				
				string gen_ret = gen_to_be_invoked.ToString( _format );
				LuaAPI.lua_pushstring(L, gen_ret);
				
				
				translator.Update(L, 1, gen_to_be_invoked);
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rect.ToString!");
            
        }
        
        
        
        
        int UnityEngineRect_g_get_zero(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.Push(L, UnityEngine.Rect.zero);
            return 1;
        }
        
        int UnityEngineRect_g_get_x(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Rect gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.x);
            return 1;
        }
        
        int UnityEngineRect_g_get_y(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Rect gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.y);
            return 1;
        }
        
        int UnityEngineRect_g_get_position(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Rect gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			translator.PushUnityEngineVector2(L, gen_to_be_invoked.position);
            return 1;
        }
        
        int UnityEngineRect_g_get_center(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Rect gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			translator.PushUnityEngineVector2(L, gen_to_be_invoked.center);
            return 1;
        }
        
        int UnityEngineRect_g_get_min(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Rect gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			translator.PushUnityEngineVector2(L, gen_to_be_invoked.min);
            return 1;
        }
        
        int UnityEngineRect_g_get_max(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Rect gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			translator.PushUnityEngineVector2(L, gen_to_be_invoked.max);
            return 1;
        }
        
        int UnityEngineRect_g_get_width(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Rect gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.width);
            return 1;
        }
        
        int UnityEngineRect_g_get_height(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Rect gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.height);
            return 1;
        }
        
        int UnityEngineRect_g_get_size(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Rect gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			translator.PushUnityEngineVector2(L, gen_to_be_invoked.size);
            return 1;
        }
        
        int UnityEngineRect_g_get_xMin(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Rect gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.xMin);
            return 1;
        }
        
        int UnityEngineRect_g_get_yMin(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Rect gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.yMin);
            return 1;
        }
        
        int UnityEngineRect_g_get_xMax(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Rect gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.xMax);
            return 1;
        }
        
        int UnityEngineRect_g_get_yMax(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Rect gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.yMax);
            return 1;
        }
        
        
        
        int UnityEngineRect_s_set_x(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Rect gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            gen_to_be_invoked.x = (float)LuaAPI.lua_tonumber(L, 2);
            
            translator.Update(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineRect_s_set_y(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Rect gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            gen_to_be_invoked.y = (float)LuaAPI.lua_tonumber(L, 2);
            
            translator.Update(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineRect_s_set_position(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Rect gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.position = gen_value;
            
            translator.Update(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineRect_s_set_center(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Rect gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.center = gen_value;
            
            translator.Update(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineRect_s_set_min(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Rect gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.min = gen_value;
            
            translator.Update(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineRect_s_set_max(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Rect gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.max = gen_value;
            
            translator.Update(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineRect_s_set_width(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Rect gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            gen_to_be_invoked.width = (float)LuaAPI.lua_tonumber(L, 2);
            
            translator.Update(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineRect_s_set_height(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Rect gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            gen_to_be_invoked.height = (float)LuaAPI.lua_tonumber(L, 2);
            
            translator.Update(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineRect_s_set_size(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Rect gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.size = gen_value;
            
            translator.Update(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineRect_s_set_xMin(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Rect gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            gen_to_be_invoked.xMin = (float)LuaAPI.lua_tonumber(L, 2);
            
            translator.Update(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineRect_s_set_yMin(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Rect gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            gen_to_be_invoked.yMin = (float)LuaAPI.lua_tonumber(L, 2);
            
            translator.Update(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineRect_s_set_xMax(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Rect gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            gen_to_be_invoked.xMax = (float)LuaAPI.lua_tonumber(L, 2);
            
            translator.Update(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
        int UnityEngineRect_s_set_yMax(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Rect gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            gen_to_be_invoked.yMax = (float)LuaAPI.lua_tonumber(L, 2);
            
            translator.Update(L, 1, gen_to_be_invoked);
            
            return 0;
        }
        
		
		
		
		
    }
}
