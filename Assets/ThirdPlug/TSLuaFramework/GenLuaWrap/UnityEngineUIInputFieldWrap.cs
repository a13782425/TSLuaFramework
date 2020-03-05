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
        public void __RegisterUnityEngineUIInputField(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.UI.InputField);
			Utils.BeginObjectRegister(type, L, this, 0, 21, 34, 23);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetTextWithoutNotify", UnityEngineUIInputField_m_SetTextWithoutNotify);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MoveTextEnd", UnityEngineUIInputField_m_MoveTextEnd);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MoveTextStart", UnityEngineUIInputField_m_MoveTextStart);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnBeginDrag", UnityEngineUIInputField_m_OnBeginDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnDrag", UnityEngineUIInputField_m_OnDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnEndDrag", UnityEngineUIInputField_m_OnEndDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnPointerDown", UnityEngineUIInputField_m_OnPointerDown);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ProcessEvent", UnityEngineUIInputField_m_ProcessEvent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnUpdateSelected", UnityEngineUIInputField_m_OnUpdateSelected);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ForceLabelUpdate", UnityEngineUIInputField_m_ForceLabelUpdate);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Rebuild", UnityEngineUIInputField_m_Rebuild);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LayoutComplete", UnityEngineUIInputField_m_LayoutComplete);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GraphicUpdateComplete", UnityEngineUIInputField_m_GraphicUpdateComplete);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ActivateInputField", UnityEngineUIInputField_m_ActivateInputField);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnSelect", UnityEngineUIInputField_m_OnSelect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnPointerClick", UnityEngineUIInputField_m_OnPointerClick);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DeactivateInputField", UnityEngineUIInputField_m_DeactivateInputField);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnDeselect", UnityEngineUIInputField_m_OnDeselect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnSubmit", UnityEngineUIInputField_m_OnSubmit);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CalculateLayoutInputHorizontal", UnityEngineUIInputField_m_CalculateLayoutInputHorizontal);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CalculateLayoutInputVertical", UnityEngineUIInputField_m_CalculateLayoutInputVertical);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "shouldHideMobileInput", UnityEngineUIInputField_g_get_shouldHideMobileInput);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "text", UnityEngineUIInputField_g_get_text);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isFocused", UnityEngineUIInputField_g_get_isFocused);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "caretBlinkRate", UnityEngineUIInputField_g_get_caretBlinkRate);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "caretWidth", UnityEngineUIInputField_g_get_caretWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "textComponent", UnityEngineUIInputField_g_get_textComponent);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "placeholder", UnityEngineUIInputField_g_get_placeholder);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "caretColor", UnityEngineUIInputField_g_get_caretColor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "customCaretColor", UnityEngineUIInputField_g_get_customCaretColor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "selectionColor", UnityEngineUIInputField_g_get_selectionColor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onEndEdit", UnityEngineUIInputField_g_get_onEndEdit);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onValueChanged", UnityEngineUIInputField_g_get_onValueChanged);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onValidateInput", UnityEngineUIInputField_g_get_onValidateInput);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "characterLimit", UnityEngineUIInputField_g_get_characterLimit);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "contentType", UnityEngineUIInputField_g_get_contentType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lineType", UnityEngineUIInputField_g_get_lineType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "inputType", UnityEngineUIInputField_g_get_inputType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "touchScreenKeyboard", UnityEngineUIInputField_g_get_touchScreenKeyboard);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "keyboardType", UnityEngineUIInputField_g_get_keyboardType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "characterValidation", UnityEngineUIInputField_g_get_characterValidation);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "readOnly", UnityEngineUIInputField_g_get_readOnly);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "multiLine", UnityEngineUIInputField_g_get_multiLine);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "asteriskChar", UnityEngineUIInputField_g_get_asteriskChar);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "wasCanceled", UnityEngineUIInputField_g_get_wasCanceled);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "caretPosition", UnityEngineUIInputField_g_get_caretPosition);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "selectionAnchorPosition", UnityEngineUIInputField_g_get_selectionAnchorPosition);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "selectionFocusPosition", UnityEngineUIInputField_g_get_selectionFocusPosition);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "minWidth", UnityEngineUIInputField_g_get_minWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "preferredWidth", UnityEngineUIInputField_g_get_preferredWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "flexibleWidth", UnityEngineUIInputField_g_get_flexibleWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "minHeight", UnityEngineUIInputField_g_get_minHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "preferredHeight", UnityEngineUIInputField_g_get_preferredHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "flexibleHeight", UnityEngineUIInputField_g_get_flexibleHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "layoutPriority", UnityEngineUIInputField_g_get_layoutPriority);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "shouldHideMobileInput", UnityEngineUIInputField_s_set_shouldHideMobileInput);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "text", UnityEngineUIInputField_s_set_text);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "caretBlinkRate", UnityEngineUIInputField_s_set_caretBlinkRate);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "caretWidth", UnityEngineUIInputField_s_set_caretWidth);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "textComponent", UnityEngineUIInputField_s_set_textComponent);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "placeholder", UnityEngineUIInputField_s_set_placeholder);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "caretColor", UnityEngineUIInputField_s_set_caretColor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "customCaretColor", UnityEngineUIInputField_s_set_customCaretColor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "selectionColor", UnityEngineUIInputField_s_set_selectionColor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onEndEdit", UnityEngineUIInputField_s_set_onEndEdit);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onValueChanged", UnityEngineUIInputField_s_set_onValueChanged);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onValidateInput", UnityEngineUIInputField_s_set_onValidateInput);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "characterLimit", UnityEngineUIInputField_s_set_characterLimit);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "contentType", UnityEngineUIInputField_s_set_contentType);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "lineType", UnityEngineUIInputField_s_set_lineType);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "inputType", UnityEngineUIInputField_s_set_inputType);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "keyboardType", UnityEngineUIInputField_s_set_keyboardType);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "characterValidation", UnityEngineUIInputField_s_set_characterValidation);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "readOnly", UnityEngineUIInputField_s_set_readOnly);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "asteriskChar", UnityEngineUIInputField_s_set_asteriskChar);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "caretPosition", UnityEngineUIInputField_s_set_caretPosition);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "selectionAnchorPosition", UnityEngineUIInputField_s_set_selectionAnchorPosition);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "selectionFocusPosition", UnityEngineUIInputField_s_set_selectionFocusPosition);
            
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineUIInputField, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineUIInputField(RealStatePtr L, int gen_param_count) 
        {
            return LuaAPI.luaL_error(L, "UnityEngine.UI.InputField does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        int UnityEngineUIInputField_m_SetTextWithoutNotify(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
            
			
			{
				string _input = LuaAPI.lua_tostring(L, 2);
				
				gen_to_be_invoked.SetTextWithoutNotify( _input );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIInputField_m_MoveTextEnd(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
            
			
			{
				bool _shift = LuaAPI.lua_toboolean(L, 2);
				
				gen_to_be_invoked.MoveTextEnd( _shift );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIInputField_m_MoveTextStart(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
            
			
			{
				bool _shift = LuaAPI.lua_toboolean(L, 2);
				
				gen_to_be_invoked.MoveTextStart( _shift );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIInputField_m_OnBeginDrag(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.EventSystems.PointerEventData _eventData = (UnityEngine.EventSystems.PointerEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
				
				gen_to_be_invoked.OnBeginDrag( _eventData );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIInputField_m_OnDrag(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.EventSystems.PointerEventData _eventData = (UnityEngine.EventSystems.PointerEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
				
				gen_to_be_invoked.OnDrag( _eventData );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIInputField_m_OnEndDrag(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.EventSystems.PointerEventData _eventData = (UnityEngine.EventSystems.PointerEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
				
				gen_to_be_invoked.OnEndDrag( _eventData );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIInputField_m_OnPointerDown(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.EventSystems.PointerEventData _eventData = (UnityEngine.EventSystems.PointerEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
				
				gen_to_be_invoked.OnPointerDown( _eventData );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIInputField_m_ProcessEvent(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.Event _e = (UnityEngine.Event)translator.GetObject(L, 2, typeof(UnityEngine.Event));
				
				gen_to_be_invoked.ProcessEvent( _e );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIInputField_m_OnUpdateSelected(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.EventSystems.BaseEventData _eventData = (UnityEngine.EventSystems.BaseEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.BaseEventData));
				
				gen_to_be_invoked.OnUpdateSelected( _eventData );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIInputField_m_ForceLabelUpdate(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.ForceLabelUpdate(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIInputField_m_Rebuild(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.UI.CanvasUpdate _update;translator.Get(L, 2, out _update);
				
				gen_to_be_invoked.Rebuild( _update );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIInputField_m_LayoutComplete(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.LayoutComplete(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIInputField_m_GraphicUpdateComplete(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.GraphicUpdateComplete(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIInputField_m_ActivateInputField(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.ActivateInputField(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIInputField_m_OnSelect(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.EventSystems.BaseEventData _eventData = (UnityEngine.EventSystems.BaseEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.BaseEventData));
				
				gen_to_be_invoked.OnSelect( _eventData );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIInputField_m_OnPointerClick(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.EventSystems.PointerEventData _eventData = (UnityEngine.EventSystems.PointerEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
				
				gen_to_be_invoked.OnPointerClick( _eventData );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIInputField_m_DeactivateInputField(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.DeactivateInputField(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIInputField_m_OnDeselect(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.EventSystems.BaseEventData _eventData = (UnityEngine.EventSystems.BaseEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.BaseEventData));
				
				gen_to_be_invoked.OnDeselect( _eventData );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIInputField_m_OnSubmit(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
            
			
			{
				UnityEngine.EventSystems.BaseEventData _eventData = (UnityEngine.EventSystems.BaseEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.BaseEventData));
				
				gen_to_be_invoked.OnSubmit( _eventData );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIInputField_m_CalculateLayoutInputHorizontal(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.CalculateLayoutInputHorizontal(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIInputField_m_CalculateLayoutInputVertical(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.CalculateLayoutInputVertical(  );
				
				
				
				return 0;
			}
			
            
        }
        
        
        
        
        int UnityEngineUIInputField_g_get_shouldHideMobileInput(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.shouldHideMobileInput);
            return 1;
        }
        
        int UnityEngineUIInputField_g_get_text(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushstring(L, gen_to_be_invoked.text);
            return 1;
        }
        
        int UnityEngineUIInputField_g_get_isFocused(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isFocused);
            return 1;
        }
        
        int UnityEngineUIInputField_g_get_caretBlinkRate(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.caretBlinkRate);
            return 1;
        }
        
        int UnityEngineUIInputField_g_get_caretWidth(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.caretWidth);
            return 1;
        }
        
        int UnityEngineUIInputField_g_get_textComponent(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.textComponent);
            return 1;
        }
        
        int UnityEngineUIInputField_g_get_placeholder(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.placeholder);
            return 1;
        }
        
        int UnityEngineUIInputField_g_get_caretColor(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
			translator.PushUnityEngineColor(L, gen_to_be_invoked.caretColor);
            return 1;
        }
        
        int UnityEngineUIInputField_g_get_customCaretColor(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.customCaretColor);
            return 1;
        }
        
        int UnityEngineUIInputField_g_get_selectionColor(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
			translator.PushUnityEngineColor(L, gen_to_be_invoked.selectionColor);
            return 1;
        }
        
        int UnityEngineUIInputField_g_get_onEndEdit(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.onEndEdit);
            return 1;
        }
        
        int UnityEngineUIInputField_g_get_onValueChanged(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.onValueChanged);
            return 1;
        }
        
        int UnityEngineUIInputField_g_get_onValidateInput(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.onValidateInput);
            return 1;
        }
        
        int UnityEngineUIInputField_g_get_characterLimit(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.characterLimit);
            return 1;
        }
        
        int UnityEngineUIInputField_g_get_contentType(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.contentType);
            return 1;
        }
        
        int UnityEngineUIInputField_g_get_lineType(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.lineType);
            return 1;
        }
        
        int UnityEngineUIInputField_g_get_inputType(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.inputType);
            return 1;
        }
        
        int UnityEngineUIInputField_g_get_touchScreenKeyboard(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.touchScreenKeyboard);
            return 1;
        }
        
        int UnityEngineUIInputField_g_get_keyboardType(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.keyboardType);
            return 1;
        }
        
        int UnityEngineUIInputField_g_get_characterValidation(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.characterValidation);
            return 1;
        }
        
        int UnityEngineUIInputField_g_get_readOnly(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.readOnly);
            return 1;
        }
        
        int UnityEngineUIInputField_g_get_multiLine(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.multiLine);
            return 1;
        }
        
        int UnityEngineUIInputField_g_get_asteriskChar(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.asteriskChar);
            return 1;
        }
        
        int UnityEngineUIInputField_g_get_wasCanceled(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.wasCanceled);
            return 1;
        }
        
        int UnityEngineUIInputField_g_get_caretPosition(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.caretPosition);
            return 1;
        }
        
        int UnityEngineUIInputField_g_get_selectionAnchorPosition(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.selectionAnchorPosition);
            return 1;
        }
        
        int UnityEngineUIInputField_g_get_selectionFocusPosition(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.selectionFocusPosition);
            return 1;
        }
        
        int UnityEngineUIInputField_g_get_minWidth(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.minWidth);
            return 1;
        }
        
        int UnityEngineUIInputField_g_get_preferredWidth(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.preferredWidth);
            return 1;
        }
        
        int UnityEngineUIInputField_g_get_flexibleWidth(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.flexibleWidth);
            return 1;
        }
        
        int UnityEngineUIInputField_g_get_minHeight(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.minHeight);
            return 1;
        }
        
        int UnityEngineUIInputField_g_get_preferredHeight(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.preferredHeight);
            return 1;
        }
        
        int UnityEngineUIInputField_g_get_flexibleHeight(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.flexibleHeight);
            return 1;
        }
        
        int UnityEngineUIInputField_g_get_layoutPriority(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.layoutPriority);
            return 1;
        }
        
        
        
        int UnityEngineUIInputField_s_set_shouldHideMobileInput(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.shouldHideMobileInput = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineUIInputField_s_set_text(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.text = LuaAPI.lua_tostring(L, 2);
            
            return 0;
        }
        
        int UnityEngineUIInputField_s_set_caretBlinkRate(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.caretBlinkRate = (float)LuaAPI.lua_tonumber(L, 2);
            
            return 0;
        }
        
        int UnityEngineUIInputField_s_set_caretWidth(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.caretWidth = LuaAPI.xlua_tointeger(L, 2);
            
            return 0;
        }
        
        int UnityEngineUIInputField_s_set_textComponent(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.textComponent = (UnityEngine.UI.Text)translator.GetObject(L, 2, typeof(UnityEngine.UI.Text));
            
            return 0;
        }
        
        int UnityEngineUIInputField_s_set_placeholder(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.placeholder = (UnityEngine.UI.Graphic)translator.GetObject(L, 2, typeof(UnityEngine.UI.Graphic));
            
            return 0;
        }
        
        int UnityEngineUIInputField_s_set_caretColor(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
            UnityEngine.Color gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.caretColor = gen_value;
            
            return 0;
        }
        
        int UnityEngineUIInputField_s_set_customCaretColor(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.customCaretColor = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineUIInputField_s_set_selectionColor(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
            UnityEngine.Color gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.selectionColor = gen_value;
            
            return 0;
        }
        
        int UnityEngineUIInputField_s_set_onEndEdit(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.onEndEdit = (UnityEngine.UI.InputField.SubmitEvent)translator.GetObject(L, 2, typeof(UnityEngine.UI.InputField.SubmitEvent));
            
            return 0;
        }
        
        int UnityEngineUIInputField_s_set_onValueChanged(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.onValueChanged = (UnityEngine.UI.InputField.OnChangeEvent)translator.GetObject(L, 2, typeof(UnityEngine.UI.InputField.OnChangeEvent));
            
            return 0;
        }
        
        int UnityEngineUIInputField_s_set_onValidateInput(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.onValidateInput = translator.GetDelegate<UnityEngine.UI.InputField.OnValidateInput>(L, 2);
            
            return 0;
        }
        
        int UnityEngineUIInputField_s_set_characterLimit(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.characterLimit = LuaAPI.xlua_tointeger(L, 2);
            
            return 0;
        }
        
        int UnityEngineUIInputField_s_set_contentType(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
            UnityEngine.UI.InputField.ContentType gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.contentType = gen_value;
            
            return 0;
        }
        
        int UnityEngineUIInputField_s_set_lineType(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
            UnityEngine.UI.InputField.LineType gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.lineType = gen_value;
            
            return 0;
        }
        
        int UnityEngineUIInputField_s_set_inputType(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
            UnityEngine.UI.InputField.InputType gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.inputType = gen_value;
            
            return 0;
        }
        
        int UnityEngineUIInputField_s_set_keyboardType(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
            UnityEngine.TouchScreenKeyboardType gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.keyboardType = gen_value;
            
            return 0;
        }
        
        int UnityEngineUIInputField_s_set_characterValidation(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
            UnityEngine.UI.InputField.CharacterValidation gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.characterValidation = gen_value;
            
            return 0;
        }
        
        int UnityEngineUIInputField_s_set_readOnly(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.readOnly = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineUIInputField_s_set_asteriskChar(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.asteriskChar = (char)LuaAPI.xlua_tointeger(L, 2);
            
            return 0;
        }
        
        int UnityEngineUIInputField_s_set_caretPosition(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.caretPosition = LuaAPI.xlua_tointeger(L, 2);
            
            return 0;
        }
        
        int UnityEngineUIInputField_s_set_selectionAnchorPosition(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.selectionAnchorPosition = LuaAPI.xlua_tointeger(L, 2);
            
            return 0;
        }
        
        int UnityEngineUIInputField_s_set_selectionFocusPosition(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.InputField gen_to_be_invoked = (UnityEngine.UI.InputField)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.selectionFocusPosition = LuaAPI.xlua_tointeger(L, 2);
            
            return 0;
        }
        
		
		
		
		
    }
}
