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
        public void __RegisterUnityEngineTransform(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.Transform);
			Utils.BeginObjectRegister(type, L, this, 0, 21, 19, 13);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetParent", UnityEngineTransform_m_SetParent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetPositionAndRotation", UnityEngineTransform_m_SetPositionAndRotation);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Translate", UnityEngineTransform_m_Translate);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Rotate", UnityEngineTransform_m_Rotate);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RotateAround", UnityEngineTransform_m_RotateAround);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LookAt", UnityEngineTransform_m_LookAt);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TransformDirection", UnityEngineTransform_m_TransformDirection);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "InverseTransformDirection", UnityEngineTransform_m_InverseTransformDirection);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TransformVector", UnityEngineTransform_m_TransformVector);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "InverseTransformVector", UnityEngineTransform_m_InverseTransformVector);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TransformPoint", UnityEngineTransform_m_TransformPoint);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "InverseTransformPoint", UnityEngineTransform_m_InverseTransformPoint);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DetachChildren", UnityEngineTransform_m_DetachChildren);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetAsFirstSibling", UnityEngineTransform_m_SetAsFirstSibling);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetAsLastSibling", UnityEngineTransform_m_SetAsLastSibling);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetSiblingIndex", UnityEngineTransform_m_SetSiblingIndex);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetSiblingIndex", UnityEngineTransform_m_GetSiblingIndex);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Find", UnityEngineTransform_m_Find);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsChildOf", UnityEngineTransform_m_IsChildOf);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetEnumerator", UnityEngineTransform_m_GetEnumerator);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetChild", UnityEngineTransform_m_GetChild);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "position", UnityEngineTransform_g_get_position);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "localPosition", UnityEngineTransform_g_get_localPosition);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "eulerAngles", UnityEngineTransform_g_get_eulerAngles);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "localEulerAngles", UnityEngineTransform_g_get_localEulerAngles);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "right", UnityEngineTransform_g_get_right);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "up", UnityEngineTransform_g_get_up);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "forward", UnityEngineTransform_g_get_forward);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rotation", UnityEngineTransform_g_get_rotation);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "localRotation", UnityEngineTransform_g_get_localRotation);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "localScale", UnityEngineTransform_g_get_localScale);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "parent", UnityEngineTransform_g_get_parent);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "worldToLocalMatrix", UnityEngineTransform_g_get_worldToLocalMatrix);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "localToWorldMatrix", UnityEngineTransform_g_get_localToWorldMatrix);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "root", UnityEngineTransform_g_get_root);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "childCount", UnityEngineTransform_g_get_childCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lossyScale", UnityEngineTransform_g_get_lossyScale);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hasChanged", UnityEngineTransform_g_get_hasChanged);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hierarchyCapacity", UnityEngineTransform_g_get_hierarchyCapacity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hierarchyCount", UnityEngineTransform_g_get_hierarchyCount);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "position", UnityEngineTransform_s_set_position);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "localPosition", UnityEngineTransform_s_set_localPosition);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "eulerAngles", UnityEngineTransform_s_set_eulerAngles);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "localEulerAngles", UnityEngineTransform_s_set_localEulerAngles);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "right", UnityEngineTransform_s_set_right);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "up", UnityEngineTransform_s_set_up);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "forward", UnityEngineTransform_s_set_forward);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "rotation", UnityEngineTransform_s_set_rotation);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "localRotation", UnityEngineTransform_s_set_localRotation);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "localScale", UnityEngineTransform_s_set_localScale);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "parent", UnityEngineTransform_s_set_parent);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "hasChanged", UnityEngineTransform_s_set_hasChanged);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "hierarchyCapacity", UnityEngineTransform_s_set_hierarchyCapacity);
            
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineTransform, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineTransform(RealStatePtr L, int gen_param_count) 
        {
            return LuaAPI.luaL_error(L, "UnityEngine.Transform does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        int UnityEngineTransform_m_SetParent(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.Transform>(L, 2)) 
			{
				UnityEngine.Transform _p = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
				
				gen_to_be_invoked.SetParent( _p );
				
				
				
				return 0;
			}
			if(gen_param_count == 3&& translator.Assignable<UnityEngine.Transform>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
			{
				UnityEngine.Transform _parent = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
				bool _worldPositionStays = LuaAPI.lua_toboolean(L, 3);
				
				gen_to_be_invoked.SetParent( _parent, _worldPositionStays );
				
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Transform.SetParent!");
            
        }
        
        int UnityEngineTransform_m_SetPositionAndRotation(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.Vector3 _position;translator.Get(L, 2, out _position);
				UnityEngine.Quaternion _rotation;translator.Get(L, 3, out _rotation);
				
				gen_to_be_invoked.SetPositionAndRotation( _position, _rotation );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineTransform_m_Translate(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
			{
				float _x = (float)LuaAPI.lua_tonumber(L, 2);
				float _y = (float)LuaAPI.lua_tonumber(L, 3);
				float _z = (float)LuaAPI.lua_tonumber(L, 4);
				
				gen_to_be_invoked.Translate( _x, _y, _z );
				
				
				
				return 0;
			}
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
			{
				UnityEngine.Vector3 _translation;translator.Get(L, 2, out _translation);
				
				gen_to_be_invoked.Translate( _translation );
				
				
				
				return 0;
			}
			if(gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Space>(L, 5)) 
			{
				float _x = (float)LuaAPI.lua_tonumber(L, 2);
				float _y = (float)LuaAPI.lua_tonumber(L, 3);
				float _z = (float)LuaAPI.lua_tonumber(L, 4);
				UnityEngine.Space _relativeTo;translator.Get(L, 5, out _relativeTo);
				
				gen_to_be_invoked.Translate( _x, _y, _z, _relativeTo );
				
				
				
				return 0;
			}
			if(gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Transform>(L, 5)) 
			{
				float _x = (float)LuaAPI.lua_tonumber(L, 2);
				float _y = (float)LuaAPI.lua_tonumber(L, 3);
				float _z = (float)LuaAPI.lua_tonumber(L, 4);
				UnityEngine.Transform _relativeTo = (UnityEngine.Transform)translator.GetObject(L, 5, typeof(UnityEngine.Transform));
				
				gen_to_be_invoked.Translate( _x, _y, _z, _relativeTo );
				
				
				
				return 0;
			}
			if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Space>(L, 3)) 
			{
				UnityEngine.Vector3 _translation;translator.Get(L, 2, out _translation);
				UnityEngine.Space _relativeTo;translator.Get(L, 3, out _relativeTo);
				
				gen_to_be_invoked.Translate( _translation, _relativeTo );
				
				
				
				return 0;
			}
			if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Transform>(L, 3)) 
			{
				UnityEngine.Vector3 _translation;translator.Get(L, 2, out _translation);
				UnityEngine.Transform _relativeTo = (UnityEngine.Transform)translator.GetObject(L, 3, typeof(UnityEngine.Transform));
				
				gen_to_be_invoked.Translate( _translation, _relativeTo );
				
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Transform.Translate!");
            
        }
        
        int UnityEngineTransform_m_Rotate(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
			{
				float _xAngle = (float)LuaAPI.lua_tonumber(L, 2);
				float _yAngle = (float)LuaAPI.lua_tonumber(L, 3);
				float _zAngle = (float)LuaAPI.lua_tonumber(L, 4);
				
				gen_to_be_invoked.Rotate( _xAngle, _yAngle, _zAngle );
				
				
				
				return 0;
			}
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
			{
				UnityEngine.Vector3 _eulers;translator.Get(L, 2, out _eulers);
				
				gen_to_be_invoked.Rotate( _eulers );
				
				
				
				return 0;
			}
			if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
			{
				UnityEngine.Vector3 _axis;translator.Get(L, 2, out _axis);
				float _angle = (float)LuaAPI.lua_tonumber(L, 3);
				
				gen_to_be_invoked.Rotate( _axis, _angle );
				
				
				
				return 0;
			}
			if(gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Space>(L, 5)) 
			{
				float _xAngle = (float)LuaAPI.lua_tonumber(L, 2);
				float _yAngle = (float)LuaAPI.lua_tonumber(L, 3);
				float _zAngle = (float)LuaAPI.lua_tonumber(L, 4);
				UnityEngine.Space _relativeTo;translator.Get(L, 5, out _relativeTo);
				
				gen_to_be_invoked.Rotate( _xAngle, _yAngle, _zAngle, _relativeTo );
				
				
				
				return 0;
			}
			if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Space>(L, 3)) 
			{
				UnityEngine.Vector3 _eulers;translator.Get(L, 2, out _eulers);
				UnityEngine.Space _relativeTo;translator.Get(L, 3, out _relativeTo);
				
				gen_to_be_invoked.Rotate( _eulers, _relativeTo );
				
				
				
				return 0;
			}
			if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Space>(L, 4)) 
			{
				UnityEngine.Vector3 _axis;translator.Get(L, 2, out _axis);
				float _angle = (float)LuaAPI.lua_tonumber(L, 3);
				UnityEngine.Space _relativeTo;translator.Get(L, 4, out _relativeTo);
				
				gen_to_be_invoked.Rotate( _axis, _angle, _relativeTo );
				
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Transform.Rotate!");
            
        }
        
        int UnityEngineTransform_m_RotateAround(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.Vector3 _point;translator.Get(L, 2, out _point);
				UnityEngine.Vector3 _axis;translator.Get(L, 3, out _axis);
				float _angle = (float)LuaAPI.lua_tonumber(L, 4);
				
				gen_to_be_invoked.RotateAround( _point, _axis, _angle );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineTransform_m_LookAt(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.Transform>(L, 2)) 
			{
				UnityEngine.Transform _target = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
				
				gen_to_be_invoked.LookAt( _target );
				
				
				
				return 0;
			}
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
			{
				UnityEngine.Vector3 _worldPosition;translator.Get(L, 2, out _worldPosition);
				
				gen_to_be_invoked.LookAt( _worldPosition );
				
				
				
				return 0;
			}
			if(gen_param_count == 3&& translator.Assignable<UnityEngine.Transform>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)) 
			{
				UnityEngine.Transform _target = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
				UnityEngine.Vector3 _worldUp;translator.Get(L, 3, out _worldUp);
				
				gen_to_be_invoked.LookAt( _target, _worldUp );
				
				
				
				return 0;
			}
			if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)) 
			{
				UnityEngine.Vector3 _worldPosition;translator.Get(L, 2, out _worldPosition);
				UnityEngine.Vector3 _worldUp;translator.Get(L, 3, out _worldUp);
				
				gen_to_be_invoked.LookAt( _worldPosition, _worldUp );
				
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Transform.LookAt!");
            
        }
        
        int UnityEngineTransform_m_TransformDirection(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
			{
				float _x = (float)LuaAPI.lua_tonumber(L, 2);
				float _y = (float)LuaAPI.lua_tonumber(L, 3);
				float _z = (float)LuaAPI.lua_tonumber(L, 4);
				
				UnityEngine.Vector3 gen_ret = gen_to_be_invoked.TransformDirection( _x, _y, _z );
				translator.PushUnityEngineVector3(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
			{
				UnityEngine.Vector3 _direction;translator.Get(L, 2, out _direction);
				
				UnityEngine.Vector3 gen_ret = gen_to_be_invoked.TransformDirection( _direction );
				translator.PushUnityEngineVector3(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Transform.TransformDirection!");
            
        }
        
        int UnityEngineTransform_m_InverseTransformDirection(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
			{
				float _x = (float)LuaAPI.lua_tonumber(L, 2);
				float _y = (float)LuaAPI.lua_tonumber(L, 3);
				float _z = (float)LuaAPI.lua_tonumber(L, 4);
				
				UnityEngine.Vector3 gen_ret = gen_to_be_invoked.InverseTransformDirection( _x, _y, _z );
				translator.PushUnityEngineVector3(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
			{
				UnityEngine.Vector3 _direction;translator.Get(L, 2, out _direction);
				
				UnityEngine.Vector3 gen_ret = gen_to_be_invoked.InverseTransformDirection( _direction );
				translator.PushUnityEngineVector3(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Transform.InverseTransformDirection!");
            
        }
        
        int UnityEngineTransform_m_TransformVector(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
			{
				float _x = (float)LuaAPI.lua_tonumber(L, 2);
				float _y = (float)LuaAPI.lua_tonumber(L, 3);
				float _z = (float)LuaAPI.lua_tonumber(L, 4);
				
				UnityEngine.Vector3 gen_ret = gen_to_be_invoked.TransformVector( _x, _y, _z );
				translator.PushUnityEngineVector3(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
			{
				UnityEngine.Vector3 _vector;translator.Get(L, 2, out _vector);
				
				UnityEngine.Vector3 gen_ret = gen_to_be_invoked.TransformVector( _vector );
				translator.PushUnityEngineVector3(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Transform.TransformVector!");
            
        }
        
        int UnityEngineTransform_m_InverseTransformVector(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
			{
				float _x = (float)LuaAPI.lua_tonumber(L, 2);
				float _y = (float)LuaAPI.lua_tonumber(L, 3);
				float _z = (float)LuaAPI.lua_tonumber(L, 4);
				
				UnityEngine.Vector3 gen_ret = gen_to_be_invoked.InverseTransformVector( _x, _y, _z );
				translator.PushUnityEngineVector3(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
			{
				UnityEngine.Vector3 _vector;translator.Get(L, 2, out _vector);
				
				UnityEngine.Vector3 gen_ret = gen_to_be_invoked.InverseTransformVector( _vector );
				translator.PushUnityEngineVector3(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Transform.InverseTransformVector!");
            
        }
        
        int UnityEngineTransform_m_TransformPoint(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
			{
				float _x = (float)LuaAPI.lua_tonumber(L, 2);
				float _y = (float)LuaAPI.lua_tonumber(L, 3);
				float _z = (float)LuaAPI.lua_tonumber(L, 4);
				
				UnityEngine.Vector3 gen_ret = gen_to_be_invoked.TransformPoint( _x, _y, _z );
				translator.PushUnityEngineVector3(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
			{
				UnityEngine.Vector3 _position;translator.Get(L, 2, out _position);
				
				UnityEngine.Vector3 gen_ret = gen_to_be_invoked.TransformPoint( _position );
				translator.PushUnityEngineVector3(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Transform.TransformPoint!");
            
        }
        
        int UnityEngineTransform_m_InverseTransformPoint(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
			{
				float _x = (float)LuaAPI.lua_tonumber(L, 2);
				float _y = (float)LuaAPI.lua_tonumber(L, 3);
				float _z = (float)LuaAPI.lua_tonumber(L, 4);
				
				UnityEngine.Vector3 gen_ret = gen_to_be_invoked.InverseTransformPoint( _x, _y, _z );
				translator.PushUnityEngineVector3(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
			{
				UnityEngine.Vector3 _position;translator.Get(L, 2, out _position);
				
				UnityEngine.Vector3 gen_ret = gen_to_be_invoked.InverseTransformPoint( _position );
				translator.PushUnityEngineVector3(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Transform.InverseTransformPoint!");
            
        }
        
        int UnityEngineTransform_m_DetachChildren(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.DetachChildren(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineTransform_m_SetAsFirstSibling(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.SetAsFirstSibling(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineTransform_m_SetAsLastSibling(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.SetAsLastSibling(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineTransform_m_SetSiblingIndex(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            
			
			{
				int _index = LuaAPI.xlua_tointeger(L, 2);
				
				gen_to_be_invoked.SetSiblingIndex( _index );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineTransform_m_GetSiblingIndex(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            
			
			{
				
				int gen_ret = gen_to_be_invoked.GetSiblingIndex(  );
				LuaAPI.xlua_pushinteger(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineTransform_m_Find(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            
			
			{
				string _n = LuaAPI.lua_tostring(L, 2);
				
				UnityEngine.Transform gen_ret = gen_to_be_invoked.Find( _n );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineTransform_m_IsChildOf(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.Transform _parent = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
				
				bool gen_ret = gen_to_be_invoked.IsChildOf( _parent );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineTransform_m_GetEnumerator(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            
			
			{
				
				System.Collections.IEnumerator gen_ret = gen_to_be_invoked.GetEnumerator(  );
				translator.PushAny(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineTransform_m_GetChild(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            
			
			{
				int _index = LuaAPI.xlua_tointeger(L, 2);
				
				UnityEngine.Transform gen_ret = gen_to_be_invoked.GetChild( _index );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        
        
        
        int UnityEngineTransform_g_get_position(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
			translator.PushUnityEngineVector3(L, gen_to_be_invoked.position);
            return 1;
        }
        
        int UnityEngineTransform_g_get_localPosition(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
			translator.PushUnityEngineVector3(L, gen_to_be_invoked.localPosition);
            return 1;
        }
        
        int UnityEngineTransform_g_get_eulerAngles(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
			translator.PushUnityEngineVector3(L, gen_to_be_invoked.eulerAngles);
            return 1;
        }
        
        int UnityEngineTransform_g_get_localEulerAngles(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
			translator.PushUnityEngineVector3(L, gen_to_be_invoked.localEulerAngles);
            return 1;
        }
        
        int UnityEngineTransform_g_get_right(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
			translator.PushUnityEngineVector3(L, gen_to_be_invoked.right);
            return 1;
        }
        
        int UnityEngineTransform_g_get_up(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
			translator.PushUnityEngineVector3(L, gen_to_be_invoked.up);
            return 1;
        }
        
        int UnityEngineTransform_g_get_forward(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
			translator.PushUnityEngineVector3(L, gen_to_be_invoked.forward);
            return 1;
        }
        
        int UnityEngineTransform_g_get_rotation(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
			translator.PushUnityEngineQuaternion(L, gen_to_be_invoked.rotation);
            return 1;
        }
        
        int UnityEngineTransform_g_get_localRotation(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
			translator.PushUnityEngineQuaternion(L, gen_to_be_invoked.localRotation);
            return 1;
        }
        
        int UnityEngineTransform_g_get_localScale(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
			translator.PushUnityEngineVector3(L, gen_to_be_invoked.localScale);
            return 1;
        }
        
        int UnityEngineTransform_g_get_parent(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.parent);
            return 1;
        }
        
        int UnityEngineTransform_g_get_worldToLocalMatrix(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.worldToLocalMatrix);
            return 1;
        }
        
        int UnityEngineTransform_g_get_localToWorldMatrix(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.localToWorldMatrix);
            return 1;
        }
        
        int UnityEngineTransform_g_get_root(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.root);
            return 1;
        }
        
        int UnityEngineTransform_g_get_childCount(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.childCount);
            return 1;
        }
        
        int UnityEngineTransform_g_get_lossyScale(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
			translator.PushUnityEngineVector3(L, gen_to_be_invoked.lossyScale);
            return 1;
        }
        
        int UnityEngineTransform_g_get_hasChanged(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.hasChanged);
            return 1;
        }
        
        int UnityEngineTransform_g_get_hierarchyCapacity(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.hierarchyCapacity);
            return 1;
        }
        
        int UnityEngineTransform_g_get_hierarchyCount(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.hierarchyCount);
            return 1;
        }
        
        
        
        int UnityEngineTransform_s_set_position(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.position = gen_value;
            
            return 0;
        }
        
        int UnityEngineTransform_s_set_localPosition(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.localPosition = gen_value;
            
            return 0;
        }
        
        int UnityEngineTransform_s_set_eulerAngles(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.eulerAngles = gen_value;
            
            return 0;
        }
        
        int UnityEngineTransform_s_set_localEulerAngles(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.localEulerAngles = gen_value;
            
            return 0;
        }
        
        int UnityEngineTransform_s_set_right(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.right = gen_value;
            
            return 0;
        }
        
        int UnityEngineTransform_s_set_up(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.up = gen_value;
            
            return 0;
        }
        
        int UnityEngineTransform_s_set_forward(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.forward = gen_value;
            
            return 0;
        }
        
        int UnityEngineTransform_s_set_rotation(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            UnityEngine.Quaternion gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.rotation = gen_value;
            
            return 0;
        }
        
        int UnityEngineTransform_s_set_localRotation(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            UnityEngine.Quaternion gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.localRotation = gen_value;
            
            return 0;
        }
        
        int UnityEngineTransform_s_set_localScale(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.localScale = gen_value;
            
            return 0;
        }
        
        int UnityEngineTransform_s_set_parent(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.parent = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
            
            return 0;
        }
        
        int UnityEngineTransform_s_set_hasChanged(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.hasChanged = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineTransform_s_set_hierarchyCapacity(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Transform gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.hierarchyCapacity = LuaAPI.xlua_tointeger(L, 2);
            
            return 0;
        }
        
		
		
		
		
    }
}
