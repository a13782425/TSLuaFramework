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
        public void __RegisterUnityEngineUIText(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.UI.Text);
			Utils.BeginObjectRegister(type, L, this, 0, 4, 24, 13);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FontTextureChanged", UnityEngineUIText_m_FontTextureChanged);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetGenerationSettings", UnityEngineUIText_m_GetGenerationSettings);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CalculateLayoutInputHorizontal", UnityEngineUIText_m_CalculateLayoutInputHorizontal);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CalculateLayoutInputVertical", UnityEngineUIText_m_CalculateLayoutInputVertical);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "cachedTextGenerator", UnityEngineUIText_g_get_cachedTextGenerator);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "cachedTextGeneratorForLayout", UnityEngineUIText_g_get_cachedTextGeneratorForLayout);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "mainTexture", UnityEngineUIText_g_get_mainTexture);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "font", UnityEngineUIText_g_get_font);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "text", UnityEngineUIText_g_get_text);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "supportRichText", UnityEngineUIText_g_get_supportRichText);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "resizeTextForBestFit", UnityEngineUIText_g_get_resizeTextForBestFit);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "resizeTextMinSize", UnityEngineUIText_g_get_resizeTextMinSize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "resizeTextMaxSize", UnityEngineUIText_g_get_resizeTextMaxSize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "alignment", UnityEngineUIText_g_get_alignment);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "alignByGeometry", UnityEngineUIText_g_get_alignByGeometry);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "fontSize", UnityEngineUIText_g_get_fontSize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "horizontalOverflow", UnityEngineUIText_g_get_horizontalOverflow);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "verticalOverflow", UnityEngineUIText_g_get_verticalOverflow);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lineSpacing", UnityEngineUIText_g_get_lineSpacing);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "fontStyle", UnityEngineUIText_g_get_fontStyle);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pixelsPerUnit", UnityEngineUIText_g_get_pixelsPerUnit);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "minWidth", UnityEngineUIText_g_get_minWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "preferredWidth", UnityEngineUIText_g_get_preferredWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "flexibleWidth", UnityEngineUIText_g_get_flexibleWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "minHeight", UnityEngineUIText_g_get_minHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "preferredHeight", UnityEngineUIText_g_get_preferredHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "flexibleHeight", UnityEngineUIText_g_get_flexibleHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "layoutPriority", UnityEngineUIText_g_get_layoutPriority);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "font", UnityEngineUIText_s_set_font);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "text", UnityEngineUIText_s_set_text);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "supportRichText", UnityEngineUIText_s_set_supportRichText);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "resizeTextForBestFit", UnityEngineUIText_s_set_resizeTextForBestFit);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "resizeTextMinSize", UnityEngineUIText_s_set_resizeTextMinSize);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "resizeTextMaxSize", UnityEngineUIText_s_set_resizeTextMaxSize);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "alignment", UnityEngineUIText_s_set_alignment);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "alignByGeometry", UnityEngineUIText_s_set_alignByGeometry);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "fontSize", UnityEngineUIText_s_set_fontSize);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "horizontalOverflow", UnityEngineUIText_s_set_horizontalOverflow);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "verticalOverflow", UnityEngineUIText_s_set_verticalOverflow);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "lineSpacing", UnityEngineUIText_s_set_lineSpacing);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "fontStyle", UnityEngineUIText_s_set_fontStyle);
            
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineUIText, 2, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "GetTextAnchorPivot", UnityEngineUIText_m_GetTextAnchorPivot_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineUIText(RealStatePtr L, int gen_param_count) 
        {
            return LuaAPI.luaL_error(L, "UnityEngine.UI.Text does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        int UnityEngineUIText_m_FontTextureChanged(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.Text gen_to_be_invoked = (UnityEngine.UI.Text)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.FontTextureChanged(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIText_m_GetGenerationSettings(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.Text gen_to_be_invoked = (UnityEngine.UI.Text)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.Vector2 _extents;translator.Get(L, 2, out _extents);
				
				UnityEngine.TextGenerationSettings gen_ret = gen_to_be_invoked.GetGenerationSettings( _extents );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineUIText_m_GetTextAnchorPivot_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				UnityEngine.TextAnchor _anchor;translator.Get(L, 1, out _anchor);
				
				UnityEngine.Vector2 gen_ret = UnityEngine.UI.Text.GetTextAnchorPivot( _anchor );
				translator.PushUnityEngineVector2(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineUIText_m_CalculateLayoutInputHorizontal(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.Text gen_to_be_invoked = (UnityEngine.UI.Text)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.CalculateLayoutInputHorizontal(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIText_m_CalculateLayoutInputVertical(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.Text gen_to_be_invoked = (UnityEngine.UI.Text)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.CalculateLayoutInputVertical(  );
				
				
				
				return 0;
			}
			
            
        }
        
        
        
        
        int UnityEngineUIText_g_get_cachedTextGenerator(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Text gen_to_be_invoked = (UnityEngine.UI.Text)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.cachedTextGenerator);
            return 1;
        }
        
        int UnityEngineUIText_g_get_cachedTextGeneratorForLayout(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Text gen_to_be_invoked = (UnityEngine.UI.Text)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.cachedTextGeneratorForLayout);
            return 1;
        }
        
        int UnityEngineUIText_g_get_mainTexture(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Text gen_to_be_invoked = (UnityEngine.UI.Text)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.mainTexture);
            return 1;
        }
        
        int UnityEngineUIText_g_get_font(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Text gen_to_be_invoked = (UnityEngine.UI.Text)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.font);
            return 1;
        }
        
        int UnityEngineUIText_g_get_text(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Text gen_to_be_invoked = (UnityEngine.UI.Text)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushstring(L, gen_to_be_invoked.text);
            return 1;
        }
        
        int UnityEngineUIText_g_get_supportRichText(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Text gen_to_be_invoked = (UnityEngine.UI.Text)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.supportRichText);
            return 1;
        }
        
        int UnityEngineUIText_g_get_resizeTextForBestFit(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Text gen_to_be_invoked = (UnityEngine.UI.Text)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.resizeTextForBestFit);
            return 1;
        }
        
        int UnityEngineUIText_g_get_resizeTextMinSize(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Text gen_to_be_invoked = (UnityEngine.UI.Text)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.resizeTextMinSize);
            return 1;
        }
        
        int UnityEngineUIText_g_get_resizeTextMaxSize(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Text gen_to_be_invoked = (UnityEngine.UI.Text)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.resizeTextMaxSize);
            return 1;
        }
        
        int UnityEngineUIText_g_get_alignment(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Text gen_to_be_invoked = (UnityEngine.UI.Text)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.alignment);
            return 1;
        }
        
        int UnityEngineUIText_g_get_alignByGeometry(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Text gen_to_be_invoked = (UnityEngine.UI.Text)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.alignByGeometry);
            return 1;
        }
        
        int UnityEngineUIText_g_get_fontSize(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Text gen_to_be_invoked = (UnityEngine.UI.Text)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.fontSize);
            return 1;
        }
        
        int UnityEngineUIText_g_get_horizontalOverflow(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Text gen_to_be_invoked = (UnityEngine.UI.Text)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.horizontalOverflow);
            return 1;
        }
        
        int UnityEngineUIText_g_get_verticalOverflow(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Text gen_to_be_invoked = (UnityEngine.UI.Text)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.verticalOverflow);
            return 1;
        }
        
        int UnityEngineUIText_g_get_lineSpacing(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Text gen_to_be_invoked = (UnityEngine.UI.Text)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.lineSpacing);
            return 1;
        }
        
        int UnityEngineUIText_g_get_fontStyle(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Text gen_to_be_invoked = (UnityEngine.UI.Text)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.fontStyle);
            return 1;
        }
        
        int UnityEngineUIText_g_get_pixelsPerUnit(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Text gen_to_be_invoked = (UnityEngine.UI.Text)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.pixelsPerUnit);
            return 1;
        }
        
        int UnityEngineUIText_g_get_minWidth(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Text gen_to_be_invoked = (UnityEngine.UI.Text)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.minWidth);
            return 1;
        }
        
        int UnityEngineUIText_g_get_preferredWidth(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Text gen_to_be_invoked = (UnityEngine.UI.Text)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.preferredWidth);
            return 1;
        }
        
        int UnityEngineUIText_g_get_flexibleWidth(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Text gen_to_be_invoked = (UnityEngine.UI.Text)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.flexibleWidth);
            return 1;
        }
        
        int UnityEngineUIText_g_get_minHeight(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Text gen_to_be_invoked = (UnityEngine.UI.Text)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.minHeight);
            return 1;
        }
        
        int UnityEngineUIText_g_get_preferredHeight(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Text gen_to_be_invoked = (UnityEngine.UI.Text)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.preferredHeight);
            return 1;
        }
        
        int UnityEngineUIText_g_get_flexibleHeight(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Text gen_to_be_invoked = (UnityEngine.UI.Text)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.flexibleHeight);
            return 1;
        }
        
        int UnityEngineUIText_g_get_layoutPriority(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.Text gen_to_be_invoked = (UnityEngine.UI.Text)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.layoutPriority);
            return 1;
        }
        
        
        
        int UnityEngineUIText_s_set_font(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.Text gen_to_be_invoked = (UnityEngine.UI.Text)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.font = (UnityEngine.Font)translator.GetObject(L, 2, typeof(UnityEngine.Font));
            
            return 0;
        }
        
        int UnityEngineUIText_s_set_text(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.Text gen_to_be_invoked = (UnityEngine.UI.Text)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.text = LuaAPI.lua_tostring(L, 2);
            
            return 0;
        }
        
        int UnityEngineUIText_s_set_supportRichText(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.Text gen_to_be_invoked = (UnityEngine.UI.Text)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.supportRichText = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineUIText_s_set_resizeTextForBestFit(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.Text gen_to_be_invoked = (UnityEngine.UI.Text)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.resizeTextForBestFit = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineUIText_s_set_resizeTextMinSize(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.Text gen_to_be_invoked = (UnityEngine.UI.Text)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.resizeTextMinSize = LuaAPI.xlua_tointeger(L, 2);
            
            return 0;
        }
        
        int UnityEngineUIText_s_set_resizeTextMaxSize(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.Text gen_to_be_invoked = (UnityEngine.UI.Text)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.resizeTextMaxSize = LuaAPI.xlua_tointeger(L, 2);
            
            return 0;
        }
        
        int UnityEngineUIText_s_set_alignment(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.Text gen_to_be_invoked = (UnityEngine.UI.Text)translator.FastGetCSObj(L, 1);
            UnityEngine.TextAnchor gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.alignment = gen_value;
            
            return 0;
        }
        
        int UnityEngineUIText_s_set_alignByGeometry(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.Text gen_to_be_invoked = (UnityEngine.UI.Text)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.alignByGeometry = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineUIText_s_set_fontSize(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.Text gen_to_be_invoked = (UnityEngine.UI.Text)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.fontSize = LuaAPI.xlua_tointeger(L, 2);
            
            return 0;
        }
        
        int UnityEngineUIText_s_set_horizontalOverflow(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.Text gen_to_be_invoked = (UnityEngine.UI.Text)translator.FastGetCSObj(L, 1);
            UnityEngine.HorizontalWrapMode gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.horizontalOverflow = gen_value;
            
            return 0;
        }
        
        int UnityEngineUIText_s_set_verticalOverflow(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.Text gen_to_be_invoked = (UnityEngine.UI.Text)translator.FastGetCSObj(L, 1);
            UnityEngine.VerticalWrapMode gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.verticalOverflow = gen_value;
            
            return 0;
        }
        
        int UnityEngineUIText_s_set_lineSpacing(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.Text gen_to_be_invoked = (UnityEngine.UI.Text)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.lineSpacing = (float)LuaAPI.lua_tonumber(L, 2);
            
            return 0;
        }
        
        int UnityEngineUIText_s_set_fontStyle(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.Text gen_to_be_invoked = (UnityEngine.UI.Text)translator.FastGetCSObj(L, 1);
            UnityEngine.FontStyle gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.fontStyle = gen_value;
            
            return 0;
        }
        
		
		
		
		
    }
}
