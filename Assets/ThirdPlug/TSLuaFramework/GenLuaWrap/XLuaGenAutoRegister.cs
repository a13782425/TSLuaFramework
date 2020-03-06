#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using System;
using System.Collections.Generic;
using System.Reflection;


namespace XLua.CSObjectWrap
{
    public class XLua_Gen_Initer_Register__
	{
        
        
        static void wrapInit0(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(object), translator.__RegisterSystemObject);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Object), translator.__RegisterUnityEngineObject);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Ray2D), translator.__RegisterUnityEngineRay2D);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.GameObject), translator.__RegisterUnityEngineGameObject);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Component), translator.__RegisterUnityEngineComponent);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Behaviour), translator.__RegisterUnityEngineBehaviour);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Transform), translator.__RegisterUnityEngineTransform);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.TextAsset), translator.__RegisterUnityEngineTextAsset);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Keyframe), translator.__RegisterUnityEngineKeyframe);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.KeyCode), translator.__RegisterUnityEngineKeyCode);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Input), translator.__RegisterUnityEngineInput);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AnimationCurve), translator.__RegisterUnityEngineAnimationCurve);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AnimationClip), translator.__RegisterUnityEngineAnimationClip);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.MonoBehaviour), translator.__RegisterUnityEngineMonoBehaviour);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem), translator.__RegisterUnityEngineParticleSystem);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.SkinnedMeshRenderer), translator.__RegisterUnityEngineSkinnedMeshRenderer);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Renderer), translator.__RegisterUnityEngineRenderer);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Networking.UnityWebRequest), translator.__RegisterUnityEngineNetworkingUnityWebRequest);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Debug), translator.__RegisterUnityEngineDebug);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Events.UnityEvent), translator.__RegisterUnityEngineEventsUnityEvent);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Camera), translator.__RegisterUnityEngineCamera);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.CameraClearFlags), translator.__RegisterUnityEngineCameraClearFlags);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.HideFlags), translator.__RegisterUnityEngineHideFlags);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.EventTriggerType), translator.__RegisterUnityEngineEventSystemsEventTriggerType);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Bounds), translator.__RegisterUnityEngineBounds);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Color), translator.__RegisterUnityEngineColor);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.LayerMask), translator.__RegisterUnityEngineLayerMask);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Mathf), translator.__RegisterUnityEngineMathf);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Plane), translator.__RegisterUnityEnginePlane);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Quaternion), translator.__RegisterUnityEngineQuaternion);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Ray), translator.__RegisterUnityEngineRay);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.RaycastHit), translator.__RegisterUnityEngineRaycastHit);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Time), translator.__RegisterUnityEngineTime);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Touch), translator.__RegisterUnityEngineTouch);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.TouchPhase), translator.__RegisterUnityEngineTouchPhase);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Vector2), translator.__RegisterUnityEngineVector2);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Vector3), translator.__RegisterUnityEngineVector3);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Vector4), translator.__RegisterUnityEngineVector4);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.RenderMode), translator.__RegisterUnityEngineRenderMode);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Canvas), translator.__RegisterUnityEngineCanvas);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Rect), translator.__RegisterUnityEngineRect);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.RectTransform), translator.__RegisterUnityEngineRectTransform);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.RectOffset), translator.__RegisterUnityEngineRectOffset);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Sprite), translator.__RegisterUnityEngineSprite);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.CanvasGroup), translator.__RegisterUnityEngineCanvasGroup);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.CanvasScaler), translator.__RegisterUnityEngineUICanvasScaler);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.CanvasScaler.ScaleMode), translator.__RegisterUnityEngineUICanvasScalerScaleMode);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.CanvasScaler.ScreenMatchMode), translator.__RegisterUnityEngineUICanvasScalerScreenMatchMode);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.GraphicRaycaster), translator.__RegisterUnityEngineUIGraphicRaycaster);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Text), translator.__RegisterUnityEngineUIText);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.InputField), translator.__RegisterUnityEngineUIInputField);
        
        }
        
        static void wrapInit1(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Button), translator.__RegisterUnityEngineUIButton);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Image), translator.__RegisterUnityEngineUIImage);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.ScrollRect), translator.__RegisterUnityEngineUIScrollRect);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Scrollbar), translator.__RegisterUnityEngineUIScrollbar);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Toggle), translator.__RegisterUnityEngineUIToggle);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.ToggleGroup), translator.__RegisterUnityEngineUIToggleGroup);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Button.ButtonClickedEvent), translator.__RegisterUnityEngineUIButtonButtonClickedEvent);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.ScrollRect.ScrollRectEvent), translator.__RegisterUnityEngineUIScrollRectScrollRectEvent);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.GridLayoutGroup), translator.__RegisterUnityEngineUIGridLayoutGroup);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.ContentSizeFitter), translator.__RegisterUnityEngineUIContentSizeFitter);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Slider), translator.__RegisterUnityEngineUISlider);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.PlayerPrefs), translator.__RegisterUnityEnginePlayerPrefs);
        
        
            translator.DelayWrapLoader(typeof(System.GC), translator.__RegisterSystemGC);
        
        
            translator.DelayWrapLoader(typeof(TSLuaFramework.UnityLogger), translator.__RegisterTSLuaFrameworkUnityLogger);
        
        
            translator.DelayWrapLoader(typeof(TSLuaFramework.Module.AssetBundleModule), translator.__RegisterTSLuaFrameworkModuleAssetBundleModule);
        
        
            translator.DelayWrapLoader(typeof(TSLuaFramework.Tool.GameTool), translator.__RegisterTSLuaFrameworkToolGameTool);
        
        
            translator.DelayWrapLoader(typeof(TSLuaFramework.Tool.UIEvent), translator.__RegisterTSLuaFrameworkToolUIEvent);
        
        
            translator.DelayWrapLoader(typeof(System.IO.BinaryWriter), translator.__RegisterSystemIOBinaryWriter);
        
        
            translator.DelayWrapLoader(typeof(BinaryWriterExtentions), translator.__RegisterBinaryWriterExtentions);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.WaitForSeconds), translator.__RegisterUnityEngineWaitForSeconds);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.WaitForEndOfFrame), translator.__RegisterUnityEngineWaitForEndOfFrame);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.WaitForFixedUpdate), translator.__RegisterUnityEngineWaitForFixedUpdate);
        
        
            translator.DelayWrapLoader(typeof(UnityEngineObjectExtention), translator.__RegisterUnityEngineObjectExtention);
        
        
        
        }
        
        static void Init(LuaEnv luaenv, ObjectTranslator translator)
        {
            
            wrapInit0(luaenv, translator);
            
            wrapInit1(luaenv, translator);
            
            
            translator.AddInterfaceBridgeCreator(typeof(System.Collections.IEnumerator), SystemCollectionsIEnumeratorBridge.__Create);
            
        }
        
	    static XLua_Gen_Initer_Register__()
        {
		    XLua.LuaEnv.AddIniter(Init);
		}
		
		
	}
	
}
namespace XLua
{
	public partial class ObjectTranslator
	{
		static XLua.CSObjectWrap.XLua_Gen_Initer_Register__ s_gen_reg_dumb_obj = new XLua.CSObjectWrap.XLua_Gen_Initer_Register__();
		static XLua.CSObjectWrap.XLua_Gen_Initer_Register__ gen_reg_dumb_obj {get{return s_gen_reg_dumb_obj;}}
	}
	
	internal partial class InternalGlobals
    {
	    
	    static InternalGlobals()
		{
		    extensionMethodMap = new Dictionary<Type, IEnumerable<MethodInfo>>()
			{
			    
			};
			
			genTryArrayGetPtr = StaticLuaCallbacks.__tryArrayGet;
            genTryArraySetPtr = StaticLuaCallbacks.__tryArraySet;
		}
	}
}
