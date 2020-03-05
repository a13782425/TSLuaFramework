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
        public void __RegisterUnityEngineRectTransform(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.RectTransform);
			Utils.BeginObjectRegister(type, L, this, 0, 5, 9, 8);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ForceUpdateRectTransforms", UnityEngineRectTransform_m_ForceUpdateRectTransforms);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetLocalCorners", UnityEngineRectTransform_m_GetLocalCorners);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetWorldCorners", UnityEngineRectTransform_m_GetWorldCorners);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetInsetAndSizeFromParentEdge", UnityEngineRectTransform_m_SetInsetAndSizeFromParentEdge);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetSizeWithCurrentAnchors", UnityEngineRectTransform_m_SetSizeWithCurrentAnchors);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "rect", UnityEngineRectTransform_g_get_rect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "anchorMin", UnityEngineRectTransform_g_get_anchorMin);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "anchorMax", UnityEngineRectTransform_g_get_anchorMax);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "anchoredPosition", UnityEngineRectTransform_g_get_anchoredPosition);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sizeDelta", UnityEngineRectTransform_g_get_sizeDelta);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pivot", UnityEngineRectTransform_g_get_pivot);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "anchoredPosition3D", UnityEngineRectTransform_g_get_anchoredPosition3D);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "offsetMin", UnityEngineRectTransform_g_get_offsetMin);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "offsetMax", UnityEngineRectTransform_g_get_offsetMax);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "anchorMin", UnityEngineRectTransform_s_set_anchorMin);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "anchorMax", UnityEngineRectTransform_s_set_anchorMax);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "anchoredPosition", UnityEngineRectTransform_s_set_anchoredPosition);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sizeDelta", UnityEngineRectTransform_s_set_sizeDelta);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pivot", UnityEngineRectTransform_s_set_pivot);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "anchoredPosition3D", UnityEngineRectTransform_s_set_anchoredPosition3D);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "offsetMin", UnityEngineRectTransform_s_set_offsetMin);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "offsetMax", UnityEngineRectTransform_s_set_offsetMax);
            
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineRectTransform, 2, 0, 0);
			
			Utils.RegisterFunc(L, Utils.CLS_IDX, "reapplyDrivenProperties", UnityEngineRectTransform_e_reapplyDrivenProperties);
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineRectTransform(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			if(gen_param_count == 1)
			{
				
				UnityEngine.RectTransform gen_ret = new UnityEngine.RectTransform();
				translator.Push(L, gen_ret);
				
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.RectTransform constructor!");
            
        }
        
		
        
		
        
        
        
        
        int UnityEngineRectTransform_m_ForceUpdateRectTransforms(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.RectTransform gen_to_be_invoked = (UnityEngine.RectTransform)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.ForceUpdateRectTransforms(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineRectTransform_m_GetLocalCorners(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.RectTransform gen_to_be_invoked = (UnityEngine.RectTransform)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.Vector3[] _fourCornersArray = (UnityEngine.Vector3[])translator.GetObject(L, 2, typeof(UnityEngine.Vector3[]));
				
				gen_to_be_invoked.GetLocalCorners( _fourCornersArray );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineRectTransform_m_GetWorldCorners(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.RectTransform gen_to_be_invoked = (UnityEngine.RectTransform)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.Vector3[] _fourCornersArray = (UnityEngine.Vector3[])translator.GetObject(L, 2, typeof(UnityEngine.Vector3[]));
				
				gen_to_be_invoked.GetWorldCorners( _fourCornersArray );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineRectTransform_m_SetInsetAndSizeFromParentEdge(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.RectTransform gen_to_be_invoked = (UnityEngine.RectTransform)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.RectTransform.Edge _edge;translator.Get(L, 2, out _edge);
				float _inset = (float)LuaAPI.lua_tonumber(L, 3);
				float _size = (float)LuaAPI.lua_tonumber(L, 4);
				
				gen_to_be_invoked.SetInsetAndSizeFromParentEdge( _edge, _inset, _size );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineRectTransform_m_SetSizeWithCurrentAnchors(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.RectTransform gen_to_be_invoked = (UnityEngine.RectTransform)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.RectTransform.Axis _axis;translator.Get(L, 2, out _axis);
				float _size = (float)LuaAPI.lua_tonumber(L, 3);
				
				gen_to_be_invoked.SetSizeWithCurrentAnchors( _axis, _size );
				
				
				
				return 0;
			}
			
            
        }
        
        
        
        
        int UnityEngineRectTransform_g_get_rect(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.RectTransform gen_to_be_invoked = (UnityEngine.RectTransform)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.rect);
            return 1;
        }
        
        int UnityEngineRectTransform_g_get_anchorMin(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.RectTransform gen_to_be_invoked = (UnityEngine.RectTransform)translator.FastGetCSObj(L, 1);
			translator.PushUnityEngineVector2(L, gen_to_be_invoked.anchorMin);
            return 1;
        }
        
        int UnityEngineRectTransform_g_get_anchorMax(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.RectTransform gen_to_be_invoked = (UnityEngine.RectTransform)translator.FastGetCSObj(L, 1);
			translator.PushUnityEngineVector2(L, gen_to_be_invoked.anchorMax);
            return 1;
        }
        
        int UnityEngineRectTransform_g_get_anchoredPosition(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.RectTransform gen_to_be_invoked = (UnityEngine.RectTransform)translator.FastGetCSObj(L, 1);
			translator.PushUnityEngineVector2(L, gen_to_be_invoked.anchoredPosition);
            return 1;
        }
        
        int UnityEngineRectTransform_g_get_sizeDelta(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.RectTransform gen_to_be_invoked = (UnityEngine.RectTransform)translator.FastGetCSObj(L, 1);
			translator.PushUnityEngineVector2(L, gen_to_be_invoked.sizeDelta);
            return 1;
        }
        
        int UnityEngineRectTransform_g_get_pivot(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.RectTransform gen_to_be_invoked = (UnityEngine.RectTransform)translator.FastGetCSObj(L, 1);
			translator.PushUnityEngineVector2(L, gen_to_be_invoked.pivot);
            return 1;
        }
        
        int UnityEngineRectTransform_g_get_anchoredPosition3D(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.RectTransform gen_to_be_invoked = (UnityEngine.RectTransform)translator.FastGetCSObj(L, 1);
			translator.PushUnityEngineVector3(L, gen_to_be_invoked.anchoredPosition3D);
            return 1;
        }
        
        int UnityEngineRectTransform_g_get_offsetMin(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.RectTransform gen_to_be_invoked = (UnityEngine.RectTransform)translator.FastGetCSObj(L, 1);
			translator.PushUnityEngineVector2(L, gen_to_be_invoked.offsetMin);
            return 1;
        }
        
        int UnityEngineRectTransform_g_get_offsetMax(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.RectTransform gen_to_be_invoked = (UnityEngine.RectTransform)translator.FastGetCSObj(L, 1);
			translator.PushUnityEngineVector2(L, gen_to_be_invoked.offsetMax);
            return 1;
        }
        
        
        
        int UnityEngineRectTransform_s_set_anchorMin(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.RectTransform gen_to_be_invoked = (UnityEngine.RectTransform)translator.FastGetCSObj(L, 1);
            UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.anchorMin = gen_value;
            
            return 0;
        }
        
        int UnityEngineRectTransform_s_set_anchorMax(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.RectTransform gen_to_be_invoked = (UnityEngine.RectTransform)translator.FastGetCSObj(L, 1);
            UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.anchorMax = gen_value;
            
            return 0;
        }
        
        int UnityEngineRectTransform_s_set_anchoredPosition(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.RectTransform gen_to_be_invoked = (UnityEngine.RectTransform)translator.FastGetCSObj(L, 1);
            UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.anchoredPosition = gen_value;
            
            return 0;
        }
        
        int UnityEngineRectTransform_s_set_sizeDelta(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.RectTransform gen_to_be_invoked = (UnityEngine.RectTransform)translator.FastGetCSObj(L, 1);
            UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.sizeDelta = gen_value;
            
            return 0;
        }
        
        int UnityEngineRectTransform_s_set_pivot(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.RectTransform gen_to_be_invoked = (UnityEngine.RectTransform)translator.FastGetCSObj(L, 1);
            UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.pivot = gen_value;
            
            return 0;
        }
        
        int UnityEngineRectTransform_s_set_anchoredPosition3D(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.RectTransform gen_to_be_invoked = (UnityEngine.RectTransform)translator.FastGetCSObj(L, 1);
            UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.anchoredPosition3D = gen_value;
            
            return 0;
        }
        
        int UnityEngineRectTransform_s_set_offsetMin(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.RectTransform gen_to_be_invoked = (UnityEngine.RectTransform)translator.FastGetCSObj(L, 1);
            UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.offsetMin = gen_value;
            
            return 0;
        }
        
        int UnityEngineRectTransform_s_set_offsetMax(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.RectTransform gen_to_be_invoked = (UnityEngine.RectTransform)translator.FastGetCSObj(L, 1);
            UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.offsetMax = gen_value;
            
            return 0;
        }
        
		
		
		
		
        int UnityEngineRectTransform_e_reapplyDrivenProperties(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			UnityEngine.RectTransform.ReapplyDrivenProperties gen_delegate = translator.GetDelegate<UnityEngine.RectTransform.ReapplyDrivenProperties>(L, 2);
			if (gen_delegate == null) {
				return LuaAPI.luaL_error(L, "#2 need UnityEngine.RectTransform.ReapplyDrivenProperties!");
			}
			
			
			if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
				UnityEngine.RectTransform.reapplyDrivenProperties += gen_delegate;
				return 0;
			} 
			
			
			if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
				UnityEngine.RectTransform.reapplyDrivenProperties -= gen_delegate;
				return 0;
			} 
			
			return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.RectTransform.reapplyDrivenProperties!");
        }
        
    }
}
