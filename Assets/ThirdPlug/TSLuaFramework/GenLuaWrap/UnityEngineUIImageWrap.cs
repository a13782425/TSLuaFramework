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
        public void __RegisterUnityEngineUIImage(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.UI.Image);
			Utils.BeginObjectRegister(type, L, this, 0, 7, 23, 13);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DisableSpriteOptimizations", UnityEngineUIImage_m_DisableSpriteOptimizations);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnBeforeSerialize", UnityEngineUIImage_m_OnBeforeSerialize);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnAfterDeserialize", UnityEngineUIImage_m_OnAfterDeserialize);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetNativeSize", UnityEngineUIImage_m_SetNativeSize);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CalculateLayoutInputHorizontal", UnityEngineUIImage_m_CalculateLayoutInputHorizontal);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CalculateLayoutInputVertical", UnityEngineUIImage_m_CalculateLayoutInputVertical);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsRaycastLocationValid", UnityEngineUIImage_m_IsRaycastLocationValid);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "sprite", UnityEngineUIImage_g_get_sprite);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "overrideSprite", UnityEngineUIImage_g_get_overrideSprite);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "type", UnityEngineUIImage_g_get_type);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "preserveAspect", UnityEngineUIImage_g_get_preserveAspect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "fillCenter", UnityEngineUIImage_g_get_fillCenter);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "fillMethod", UnityEngineUIImage_g_get_fillMethod);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "fillAmount", UnityEngineUIImage_g_get_fillAmount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "fillClockwise", UnityEngineUIImage_g_get_fillClockwise);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "fillOrigin", UnityEngineUIImage_g_get_fillOrigin);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "alphaHitTestMinimumThreshold", UnityEngineUIImage_g_get_alphaHitTestMinimumThreshold);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "useSpriteMesh", UnityEngineUIImage_g_get_useSpriteMesh);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "mainTexture", UnityEngineUIImage_g_get_mainTexture);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hasBorder", UnityEngineUIImage_g_get_hasBorder);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pixelsPerUnitMultiplier", UnityEngineUIImage_g_get_pixelsPerUnitMultiplier);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pixelsPerUnit", UnityEngineUIImage_g_get_pixelsPerUnit);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "material", UnityEngineUIImage_g_get_material);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "minWidth", UnityEngineUIImage_g_get_minWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "preferredWidth", UnityEngineUIImage_g_get_preferredWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "flexibleWidth", UnityEngineUIImage_g_get_flexibleWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "minHeight", UnityEngineUIImage_g_get_minHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "preferredHeight", UnityEngineUIImage_g_get_preferredHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "flexibleHeight", UnityEngineUIImage_g_get_flexibleHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "layoutPriority", UnityEngineUIImage_g_get_layoutPriority);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "sprite", UnityEngineUIImage_s_set_sprite);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "overrideSprite", UnityEngineUIImage_s_set_overrideSprite);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "type", UnityEngineUIImage_s_set_type);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "preserveAspect", UnityEngineUIImage_s_set_preserveAspect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "fillCenter", UnityEngineUIImage_s_set_fillCenter);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "fillMethod", UnityEngineUIImage_s_set_fillMethod);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "fillAmount", UnityEngineUIImage_s_set_fillAmount);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "fillClockwise", UnityEngineUIImage_s_set_fillClockwise);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "fillOrigin", UnityEngineUIImage_s_set_fillOrigin);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "alphaHitTestMinimumThreshold", UnityEngineUIImage_s_set_alphaHitTestMinimumThreshold);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "useSpriteMesh", UnityEngineUIImage_s_set_useSpriteMesh);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pixelsPerUnitMultiplier", UnityEngineUIImage_s_set_pixelsPerUnitMultiplier);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "material", UnityEngineUIImage_s_set_material);
            
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineUIImage, 1, 1, 0);
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "defaultETC1GraphicMaterial", UnityEngineUIImage_g_get_defaultETC1GraphicMaterial);
            
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineUIImage(RealStatePtr L, int gen_param_count) 
        {
            return LuaAPI.luaL_error(L, "UnityEngine.UI.Image does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        int UnityEngineUIImage_m_DisableSpriteOptimizations(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.Image gen_to_be_invoked = (UnityEngine.UI.Image)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.DisableSpriteOptimizations(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIImage_m_OnBeforeSerialize(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.Image gen_to_be_invoked = (UnityEngine.UI.Image)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.OnBeforeSerialize(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIImage_m_OnAfterDeserialize(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.Image gen_to_be_invoked = (UnityEngine.UI.Image)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.OnAfterDeserialize(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIImage_m_SetNativeSize(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.Image gen_to_be_invoked = (UnityEngine.UI.Image)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.SetNativeSize(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIImage_m_CalculateLayoutInputHorizontal(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.Image gen_to_be_invoked = (UnityEngine.UI.Image)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.CalculateLayoutInputHorizontal(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIImage_m_CalculateLayoutInputVertical(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.Image gen_to_be_invoked = (UnityEngine.UI.Image)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.CalculateLayoutInputVertical(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIImage_m_IsRaycastLocationValid(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.Image gen_to_be_invoked = (UnityEngine.UI.Image)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.Vector2 _screenPoint;translator.Get(L, 2, out _screenPoint);
				UnityEngine.Camera _eventCamera = (UnityEngine.Camera)translator.GetObject(L, 3, typeof(UnityEngine.Camera));
				
				bool gen_ret = gen_to_be_invoked.IsRaycastLocationValid( _screenPoint, _eventCamera );
				LuaAPI.lua_pushboolean(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        
        
        
        int UnityEngineUIImage_g_get_sprite(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Image gen_to_be_invoked = (UnityEngine.UI.Image)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.sprite);
            return 1;
        }
        
        int UnityEngineUIImage_g_get_overrideSprite(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Image gen_to_be_invoked = (UnityEngine.UI.Image)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.overrideSprite);
            return 1;
        }
        
        int UnityEngineUIImage_g_get_type(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Image gen_to_be_invoked = (UnityEngine.UI.Image)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.type);
            return 1;
        }
        
        int UnityEngineUIImage_g_get_preserveAspect(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Image gen_to_be_invoked = (UnityEngine.UI.Image)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.preserveAspect);
            return 1;
        }
        
        int UnityEngineUIImage_g_get_fillCenter(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Image gen_to_be_invoked = (UnityEngine.UI.Image)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.fillCenter);
            return 1;
        }
        
        int UnityEngineUIImage_g_get_fillMethod(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Image gen_to_be_invoked = (UnityEngine.UI.Image)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.fillMethod);
            return 1;
        }
        
        int UnityEngineUIImage_g_get_fillAmount(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Image gen_to_be_invoked = (UnityEngine.UI.Image)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.fillAmount);
            return 1;
        }
        
        int UnityEngineUIImage_g_get_fillClockwise(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Image gen_to_be_invoked = (UnityEngine.UI.Image)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.fillClockwise);
            return 1;
        }
        
        int UnityEngineUIImage_g_get_fillOrigin(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Image gen_to_be_invoked = (UnityEngine.UI.Image)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.fillOrigin);
            return 1;
        }
        
        int UnityEngineUIImage_g_get_alphaHitTestMinimumThreshold(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Image gen_to_be_invoked = (UnityEngine.UI.Image)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.alphaHitTestMinimumThreshold);
            return 1;
        }
        
        int UnityEngineUIImage_g_get_useSpriteMesh(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Image gen_to_be_invoked = (UnityEngine.UI.Image)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.useSpriteMesh);
            return 1;
        }
        
        int UnityEngineUIImage_g_get_defaultETC1GraphicMaterial(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			    translator.Push(L, UnityEngine.UI.Image.defaultETC1GraphicMaterial);
            return 1;
        }
        
        int UnityEngineUIImage_g_get_mainTexture(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Image gen_to_be_invoked = (UnityEngine.UI.Image)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.mainTexture);
            return 1;
        }
        
        int UnityEngineUIImage_g_get_hasBorder(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Image gen_to_be_invoked = (UnityEngine.UI.Image)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.hasBorder);
            return 1;
        }
        
        int UnityEngineUIImage_g_get_pixelsPerUnitMultiplier(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Image gen_to_be_invoked = (UnityEngine.UI.Image)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.pixelsPerUnitMultiplier);
            return 1;
        }
        
        int UnityEngineUIImage_g_get_pixelsPerUnit(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Image gen_to_be_invoked = (UnityEngine.UI.Image)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.pixelsPerUnit);
            return 1;
        }
        
        int UnityEngineUIImage_g_get_material(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Image gen_to_be_invoked = (UnityEngine.UI.Image)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.material);
            return 1;
        }
        
        int UnityEngineUIImage_g_get_minWidth(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Image gen_to_be_invoked = (UnityEngine.UI.Image)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.minWidth);
            return 1;
        }
        
        int UnityEngineUIImage_g_get_preferredWidth(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Image gen_to_be_invoked = (UnityEngine.UI.Image)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.preferredWidth);
            return 1;
        }
        
        int UnityEngineUIImage_g_get_flexibleWidth(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Image gen_to_be_invoked = (UnityEngine.UI.Image)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.flexibleWidth);
            return 1;
        }
        
        int UnityEngineUIImage_g_get_minHeight(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Image gen_to_be_invoked = (UnityEngine.UI.Image)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.minHeight);
            return 1;
        }
        
        int UnityEngineUIImage_g_get_preferredHeight(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Image gen_to_be_invoked = (UnityEngine.UI.Image)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.preferredHeight);
            return 1;
        }
        
        int UnityEngineUIImage_g_get_flexibleHeight(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Image gen_to_be_invoked = (UnityEngine.UI.Image)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.flexibleHeight);
            return 1;
        }
        
        int UnityEngineUIImage_g_get_layoutPriority(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Image gen_to_be_invoked = (UnityEngine.UI.Image)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.layoutPriority);
            return 1;
        }
        
        
        
        int UnityEngineUIImage_s_set_sprite(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.Image gen_to_be_invoked = (UnityEngine.UI.Image)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.sprite = (UnityEngine.Sprite)translator.GetObject(L, 2, typeof(UnityEngine.Sprite));
            
            return 0;
        }
        
        int UnityEngineUIImage_s_set_overrideSprite(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.Image gen_to_be_invoked = (UnityEngine.UI.Image)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.overrideSprite = (UnityEngine.Sprite)translator.GetObject(L, 2, typeof(UnityEngine.Sprite));
            
            return 0;
        }
        
        int UnityEngineUIImage_s_set_type(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.Image gen_to_be_invoked = (UnityEngine.UI.Image)translator.FastGetCSObj(L, 1);
            UnityEngine.UI.Image.Type gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.type = gen_value;
            
            return 0;
        }
        
        int UnityEngineUIImage_s_set_preserveAspect(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.Image gen_to_be_invoked = (UnityEngine.UI.Image)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.preserveAspect = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineUIImage_s_set_fillCenter(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.Image gen_to_be_invoked = (UnityEngine.UI.Image)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.fillCenter = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineUIImage_s_set_fillMethod(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.Image gen_to_be_invoked = (UnityEngine.UI.Image)translator.FastGetCSObj(L, 1);
            UnityEngine.UI.Image.FillMethod gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.fillMethod = gen_value;
            
            return 0;
        }
        
        int UnityEngineUIImage_s_set_fillAmount(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.Image gen_to_be_invoked = (UnityEngine.UI.Image)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.fillAmount = (float)LuaAPI.lua_tonumber(L, 2);
            
            return 0;
        }
        
        int UnityEngineUIImage_s_set_fillClockwise(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.Image gen_to_be_invoked = (UnityEngine.UI.Image)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.fillClockwise = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineUIImage_s_set_fillOrigin(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.Image gen_to_be_invoked = (UnityEngine.UI.Image)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.fillOrigin = LuaAPI.xlua_tointeger(L, 2);
            
            return 0;
        }
        
        int UnityEngineUIImage_s_set_alphaHitTestMinimumThreshold(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.Image gen_to_be_invoked = (UnityEngine.UI.Image)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.alphaHitTestMinimumThreshold = (float)LuaAPI.lua_tonumber(L, 2);
            
            return 0;
        }
        
        int UnityEngineUIImage_s_set_useSpriteMesh(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.Image gen_to_be_invoked = (UnityEngine.UI.Image)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.useSpriteMesh = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineUIImage_s_set_pixelsPerUnitMultiplier(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.Image gen_to_be_invoked = (UnityEngine.UI.Image)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.pixelsPerUnitMultiplier = (float)LuaAPI.lua_tonumber(L, 2);
            
            return 0;
        }
        
        int UnityEngineUIImage_s_set_material(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.Image gen_to_be_invoked = (UnityEngine.UI.Image)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.material = (UnityEngine.Material)translator.GetObject(L, 2, typeof(UnityEngine.Material));
            
            return 0;
        }
        
		
		
		
		
    }
}
