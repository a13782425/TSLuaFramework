﻿using CSObjectWrapEditor;
using System.Collections.Generic;
using XLua;

//配置的详细介绍请看Doc下《XLua的配置.doc》
public static class XLuaConfig
{
#pragma warning disable 0414
    [GenPath]
    private static string GenPath = "Assets/ThirdPlug/TSLuaFramework/GenLuaWrap";

    /****自己配置****/
    //lua中要使用到C#库的配置，比如C#标准库，或者Unity API，第三方库等。
    [LuaCallCSharp]
    public static List<System.Type> LuaCallCSharp = new List<System.Type>() {
		// unity
		typeof(System.Object),
        typeof(UnityEngine.Object),
        typeof(UnityEngine.Ray2D),
        typeof(UnityEngine.GameObject),
        typeof(UnityEngine.Component),
        typeof(UnityEngine.Behaviour),
        typeof(UnityEngine.Transform),
        //typeof(Resources),
        typeof(UnityEngine.TextAsset),
        typeof(UnityEngine.Keyframe),
        typeof(UnityEngine.KeyCode),
        typeof(UnityEngine.Input),
        typeof(UnityEngine.AnimationCurve),
        typeof(UnityEngine.AnimationClip),
        typeof(UnityEngine.MonoBehaviour),
        typeof(UnityEngine.ParticleSystem),
        typeof(UnityEngine.SkinnedMeshRenderer),
        typeof(UnityEngine.Renderer),
        typeof(UnityEngine.Networking.UnityWebRequest),
        typeof(System.Action<string>),
        typeof(UnityEngine.Debug),
        typeof(System.Delegate),
        typeof(UnityEngine.Events.UnityEvent),
        typeof(UnityEngine.Camera),
        typeof(UnityEngine.CameraClearFlags),
        typeof(UnityEngine.HideFlags),
        typeof(UnityEngine.EventSystems.EventTriggerType),

        // unity结合lua，这部分导出很多功能在lua侧重新实现，没有实现的功能才会跑到cs侧
        typeof(UnityEngine.Bounds),
        typeof(UnityEngine.Color),
        typeof(UnityEngine.LayerMask),
        typeof(UnityEngine.Mathf),
        typeof(UnityEngine.Plane),
        typeof(UnityEngine.Quaternion),
        typeof(UnityEngine.Ray),
        typeof(UnityEngine.RaycastHit),
        typeof(UnityEngine.Time),
        typeof(UnityEngine.Touch),
        typeof(UnityEngine.TouchPhase),
        typeof(UnityEngine.Vector2),
        typeof(UnityEngine.Vector3),
        typeof(UnityEngine.Vector4),
        
        // 渲染
        typeof(UnityEngine.RenderMode),
        
        // UGUI  
        typeof(UnityEngine.Canvas),
        typeof(UnityEngine.Rect),
        typeof(UnityEngine.RectTransform),
        typeof(UnityEngine.RectOffset),
        typeof(UnityEngine.Sprite),
        typeof(UnityEngine.CanvasGroup),
        typeof(UnityEngine.UI.CanvasScaler),
        typeof(UnityEngine.UI.CanvasScaler.ScaleMode),
        typeof(UnityEngine.UI.CanvasScaler.ScreenMatchMode),
        typeof(UnityEngine.UI.GraphicRaycaster),
        typeof(UnityEngine.UI.Text),
        typeof(UnityEngine.UI.InputField),
        typeof(UnityEngine.UI.Button),
        typeof(UnityEngine.UI.Image),
        typeof(UnityEngine.UI.ScrollRect),
        typeof(UnityEngine.UI.Scrollbar),
        typeof(UnityEngine.UI.Toggle),
        typeof(UnityEngine.UI.ToggleGroup),
        typeof(UnityEngine.UI.Button.ButtonClickedEvent),
        typeof(UnityEngine.UI.ScrollRect.ScrollRectEvent),
        typeof(UnityEngine.UI.GridLayoutGroup),
        typeof(UnityEngine.UI.ContentSizeFitter),
        typeof(UnityEngine.UI.Slider),
        typeof(TSLuaFramework.UI.TextPlus),
        typeof(TSLuaFramework.UI.UIParticle),

        //typeof(UnityEngine.EventSystems.EventSystem),
        //typeof(UnityEngine.EventSystems.StandaloneInputModule),

        // 场景、资源加载
        // typeof(UnityEngine.Resources),
        // typeof(UnityEngine.ResourceRequest),
        // typeof(UnityEngine.SceneManagement.SceneManager),
        
        // 其它
        typeof(UnityEngine.PlayerPrefs),
        typeof(System.GC),
        
        //框架
        //typeof(App),       
        typeof(System.Action<UnityEngine.Object>),
        typeof(TSLuaFramework.UnityLogger),
        typeof(TSLuaFramework.Module.AssetBundleModule),
        typeof(TSLuaFramework.Tool.GameTool),
        typeof(TSLuaFramework.Tool.UIEvent),
        typeof(UnityEngine.EventSystems.PointerEventData),
        typeof(UnityEngine.EventSystems.BaseEventData),
        typeof(UnityEngine.EventSystems.AxisEventData),
        //typeof(System.Action<System.Object,UnityEngine.EventSystems.PointerEventData>),
        //typeof(System.Action<System.Object,UnityEngine.EventSystems.BaseEventData>),
        //typeof(System.Action<System.Object,UnityEngine.EventSystems.BaseEventData>),

    };
    //C#静态调用Lua的配置（包括事件的原型），仅可以配delegate，interface

    [CSharpCallLua]
    public static List<System.Type> CSharpCallLua = new List<System.Type>() {
		// unity
		typeof(System.Action),
        typeof(System.Action<int>),
        typeof(System.Action<UnityEngine.Networking.UnityWebRequest>),
        typeof(UnityEngine.Event),
        typeof(UnityEngine.Events.UnityAction),
        typeof(System.Collections.IEnumerator),
        typeof(UnityEngine.Events.UnityAction<UnityEngine.Vector2>),
        // update
        typeof(System.Action),
        typeof(System.Action<float>),
        typeof(System.Action<float, float>),
    };

    /***************如果你全lua编程，可以参考这份自动化配置***************/
    //--------------begin 纯lua编程配置参考----------------------------
    //static List<string> exclude = new List<string> {
    //    "HideInInspector", "ExecuteInEditMode",
    //    "AddComponentMenu", "ContextMenu",
    //    "RequireComponent", "DisallowMultipleComponent",
    //    "SerializeField", "AssemblyIsEditorAssembly",
    //    "Attribute", "Types",
    //    "UnitySurrogateSelector", "TrackedReference",
    //    "TypeInferenceRules", "FFTWindow",
    //    "RPC", "Network", "MasterServer",
    //    "BitStream", "HostData",
    //    "ConnectionTesterStatus", "GUI", "EventType",
    //    "EventModifiers", "FontStyle", "TextAlignment",
    //    "TextEditor", "TextEditorDblClickSnapping",
    //    "TextGenerator", "TextClipping", "Gizmos",
    //    "ADBannerView", "ADInterstitialAd",
    //    "Android", "Tizen", "jvalue",
    //    "iPhone", "iOS", "Windows", "CalendarIdentifier",
    //    "CalendarUnit", "CalendarUnit",
    //    "ClusterInput", "FullScreenMovieControlMode",
    //    "FullScreenMovieScalingMode", "Handheld",
    //    "LocalNotification", "NotificationServices",
    //    "RemoteNotificationType", "RemoteNotification",
    //    "SamsungTV", "TextureCompressionQuality",
    //    "TouchScreenKeyboardType", "TouchScreenKeyboard",
    //    "MovieTexture", "UnityEngineInternal",
    //    "Terrain", "Tree", "SplatPrototype",
    //    "DetailPrototype", "DetailRenderMode",
    //    "MeshSubsetCombineUtility", "AOT", "Social", "Enumerator",
    //    "SendMouseEvents", "Cursor", "Flash", "ActionScript",
    //    "OnRequestRebuild", "Ping",
    //    "ShaderVariantCollection", "SimpleJson.Reflection",
    //    "CoroutineTween", "GraphicRebuildTracker",
    //    "Advertisements", "UnityEditor", "WSA",
    //    "EventProvider", "Apple",
    //    "ClusterInput", "Motion",
    //    "UnityEngine.UI.ReflectionMethodsCache", "NativeLeakDetection",
    //    "NativeLeakDetectionMode", "WWWAudioExtensions", "UnityEngine.Experimental",
    //};

    //static bool isExcluded(Type type)
    //{
    //    var fullName = type.FullName;
    //    for (int i = 0; i < exclude.Count; i++)
    //    {
    //        if (fullName.Contains(exclude[i]))
    //        {
    //            return true;
    //        }
    //    }
    //    return false;
    //}

    //[LuaCallCSharp]
    //public static IEnumerable<Type> LuaCallCSharp
    //{
    //    get
    //    {
    //        List<string> namespaces = new List<string>() // 在这里添加名字空间
    //        {
    //            "UnityEngine",
    //            "UnityEngine.UI"
    //        };
    //        var unityTypes = (from assembly in AppDomain.CurrentDomain.GetAssemblies()
    //                          where !(assembly.ManifestModule is System.Reflection.Emit.ModuleBuilder)
    //                          from type in assembly.GetExportedTypes()
    //                          where type.Namespace != null && namespaces.Contains(type.Namespace) && !isExcluded(type)
    //                                  && type.BaseType != typeof(MulticastDelegate) && !type.IsInterface && !type.IsEnum
    //                          select type);

    //        string[] customAssemblys = new string[] {
    //            "Assembly-CSharp",
    //        };
    //        var customTypes = (from assembly in customAssemblys.Select(s => Assembly.Load(s))
    //                           from type in assembly.GetExportedTypes()
    //                           where type.Namespace == null || !type.Namespace.StartsWith("XLua")
    //                                   && type.BaseType != typeof(MulticastDelegate) && !type.IsInterface && !type.IsEnum
    //                           select type);
    //        return unityTypes.Concat(customTypes);
    //    }
    //}

    ////自动把LuaCallCSharp涉及到的delegate加到CSharpCallLua列表，后续可以直接用lua函数做callback
    //[CSharpCallLua]
    //public static List<Type> CSharpCallLua
    //{
    //    get
    //    {
    //        var lua_call_csharp = LuaCallCSharp;
    //        var delegate_types = new List<Type>();
    //        var flag = BindingFlags.Public | BindingFlags.Instance
    //            | BindingFlags.Static | BindingFlags.IgnoreCase | BindingFlags.DeclaredOnly;
    //        foreach (var field in (from type in lua_call_csharp select type).SelectMany(type => type.GetFields(flag)))
    //        {
    //            if (typeof(Delegate).IsAssignableFrom(field.FieldType))
    //            {
    //                delegate_types.Add(field.FieldType);
    //            }
    //        }

    //        foreach (var method in (from type in lua_call_csharp select type).SelectMany(type => type.GetMethods(flag)))
    //        {
    //            if (typeof(Delegate).IsAssignableFrom(method.ReturnType))
    //            {
    //                delegate_types.Add(method.ReturnType);
    //            }
    //            foreach (var param in method.GetParameters())
    //            {
    //                var paramType = param.ParameterType.IsByRef ? param.ParameterType.GetElementType() : param.ParameterType;
    //                if (typeof(Delegate).IsAssignableFrom(paramType))
    //                {
    //                    delegate_types.Add(paramType);
    //                }
    //            }
    //        }
    //        return delegate_types.Distinct().ToList();
    //    }
    //}
    //--------------end 纯lua编程配置参考----------------------------

    /***************热补丁可以参考这份自动化配置***************/
    //[Hotfix]
    //static IEnumerable<Type> HotfixInject
    //{
    //    get
    //    {
    //        return (from type in Assembly.Load("Assembly-CSharp").GetExportedTypes()
    //                           where type.Namespace == null || !type.Namespace.StartsWith("XLua")
    //                           select type);
    //    }
    //}
    //--------------begin 热补丁自动化配置-------------------------
    //static bool hasGenericParameter(Type type)
    //{
    //    if (type.IsGenericTypeDefinition) return true;
    //    if (type.IsGenericParameter) return true;
    //    if (type.IsByRef || type.IsArray)
    //    {
    //        return hasGenericParameter(type.GetElementType());
    //    }
    //    if (type.IsGenericType)
    //    {
    //        foreach (var typeArg in type.GetGenericArguments())
    //        {
    //            if (hasGenericParameter(typeArg))
    //            {
    //                return true;
    //            }
    //        }
    //    }
    //    return false;
    //}

    //static bool typeHasEditorRef(Type type)
    //{
    //    if (type.Namespace != null && (type.Namespace == "UnityEditor" || type.Namespace.StartsWith("UnityEditor.")))
    //    {
    //        return true;
    //    }
    //    if (type.IsNested)
    //    {
    //        return typeHasEditorRef(type.DeclaringType);
    //    }
    //    if (type.IsByRef || type.IsArray)
    //    {
    //        return typeHasEditorRef(type.GetElementType());
    //    }
    //    if (type.IsGenericType)
    //    {
    //        foreach (var typeArg in type.GetGenericArguments())
    //        {
    //            if (typeHasEditorRef(typeArg))
    //            {
    //                return true;
    //            }
    //        }
    //    }
    //    return false;
    //}

    //static bool delegateHasEditorRef(Type delegateType)
    //{
    //    if (typeHasEditorRef(delegateType)) return true;
    //    var method = delegateType.GetMethod("Invoke");
    //    if (method == null)
    //    {
    //        return false;
    //    }
    //    if (typeHasEditorRef(method.ReturnType)) return true;
    //    return method.GetParameters().Any(pinfo => typeHasEditorRef(pinfo.ParameterType));
    //}

    // 配置某Assembly下所有涉及到的delegate到CSharpCallLua下，Hotfix下拿不准那些delegate需要适配到lua function可以这么配置
    //[CSharpCallLua]
    //static IEnumerable<Type> AllDelegate
    //{
    //    get
    //    {
    //        BindingFlags flag = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public;
    //        List<Type> allTypes = new List<Type>();
    //        var allAssemblys = new Assembly[]
    //        {
    //            Assembly.Load("Assembly-CSharp")
    //        };
    //        foreach (var t in (from assembly in allAssemblys from type in assembly.GetTypes() select type))
    //        {
    //            var p = t;
    //            while (p != null)
    //            {
    //                allTypes.Add(p);
    //                p = p.BaseType;
    //            }
    //        }
    //        allTypes = allTypes.Distinct().ToList();
    //        var allMethods = from type in allTypes
    //                         from method in type.GetMethods(flag)
    //                         select method;
    //        var returnTypes = from method in allMethods
    //                          select method.ReturnType;
    //        var paramTypes = allMethods.SelectMany(m => m.GetParameters()).Select(pinfo => pinfo.ParameterType.IsByRef ? pinfo.ParameterType.GetElementType() : pinfo.ParameterType);
    //        var fieldTypes = from type in allTypes
    //                         from field in type.GetFields(flag)
    //                         select field.FieldType;
    //        return (returnTypes.Concat(paramTypes).Concat(fieldTypes)).Where(t => t.BaseType == typeof(MulticastDelegate) && !hasGenericParameter(t) && !delegateHasEditorRef(t)).Distinct();
    //    }
    //}
    //--------------end 热补丁自动化配置-------------------------

    //黑名单
    [BlackList]
    public static List<List<string>> BlackList = new List<List<string>>()  {
                new List<string>(){"System.Xml.XmlNodeList", "ItemOf"},
                new List<string>(){"UnityEngine.WWW", "movie"},
    #if UNITY_WEBGL
                new List<string>(){"UnityEngine.WWW", "threadPriority"},
    #endif
                new List<string>(){"UnityEngine.Texture2D", "alphaIsTransparency"},
                new List<string>(){"UnityEngine.Security", "GetChainOfTrustValue"},
                new List<string>(){"UnityEngine.CanvasRenderer", "onRequestRebuild"},
                new List<string>(){"UnityEngine.Light", "areaSize"},
                new List<string>(){"UnityEngine.Light", "lightmapBakeType"},
                new List<string>(){"UnityEngine.WWW", "MovieTexture"},
                new List<string>(){"UnityEngine.WWW", "GetMovieTexture"},
                new List<string>(){"UnityEngine.AnimatorOverrideController", "PerformOverrideClipListCleanup"},
    #if !UNITY_WEBPLAYER
                new List<string>(){"UnityEngine.Application", "ExternalEval"},
    #endif
                new List<string>(){"UnityEngine.GameObject", "networkView"}, //4.6.2 not support
                new List<string>(){"UnityEngine.Component", "networkView"},  //4.6.2 not support
                new List<string>(){"System.IO.FileInfo", "GetAccessControl", "System.Security.AccessControl.AccessControlSections"},
                new List<string>(){"System.IO.FileInfo", "SetAccessControl", "System.Security.AccessControl.FileSecurity"},
                new List<string>(){"System.IO.DirectoryInfo", "GetAccessControl", "System.Security.AccessControl.AccessControlSections"},
                new List<string>(){"System.IO.DirectoryInfo", "SetAccessControl", "System.Security.AccessControl.DirectorySecurity"},
                new List<string>(){"System.IO.DirectoryInfo", "CreateSubdirectory", "System.String", "System.Security.AccessControl.DirectorySecurity"},
                new List<string>(){"System.IO.DirectoryInfo", "Create", "System.Security.AccessControl.DirectorySecurity"},
                new List<string>(){"UnityEngine.MonoBehaviour", "runInEditMode"},
                new List<string>(){"UnityEngine.Light", "SetLightDirty"},
                new List<string>(){"UnityEngine.Light", "shadowRadius"},
                new List<string>(){"UnityEngine.Light", "shadowAngle"},
                new List<string>(){"UnityEngine.UI.Text", "OnRebuildRequested"},
                new List<string>(){"UnityEngine.Input", "IsJoystickPreconfigured" ,"System.String"},
            };
}
