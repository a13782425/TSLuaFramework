//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using TSLuaFramework.Enum;
//using UnityEngine;
//using UnityEngine.EventSystems;
//using UnityEngine.UI;

//namespace TSLuaFramework.Module
//{
//    internal sealed class UIModule : BaseModule<UIModule>
//    {
//        private Canvas _canvas = null;
//        private GameObject _eventSystem = null;
//        private GameObject _mainObj = null;
//        public GameObject MainUIObj => _mainObj;
//        public Canvas MainCanvas => _canvas;
//        private Dictionary<UILayerEnum, RectTransform> _tranDic = null;

//        public override void Init()
//        {
//            base.Init();
//            CreateMainObj();
//            CreateLayerObj();
//        }

//        internal RectTransform GetRectTransformByLayer(UILayerEnum layerEnum)
//        {
//            if (_tranDic.ContainsKey(layerEnum))
//            {
//                return _tranDic[layerEnum];
//            }
//            GameApp.Instance.LogError($"{layerEnum.ToString()}  不存在");
//            return null;
//        }

//        private void CreateMainObj()
//        {
//            _mainObj = new GameObject("MainUI", typeof(RectTransform), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
//            _mainObj.transform.SetParent(this.transform);
//            _canvas = _mainObj.GetComponent<Canvas>();
//            _canvas.renderMode = RenderMode.ScreenSpaceOverlay;
//            _tranDic = new Dictionary<UILayerEnum, RectTransform>();
//            _eventSystem = new GameObject("System", typeof(EventSystem), typeof(StandaloneInputModule));
//            _eventSystem.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector;
//            _eventSystem.transform.SetParent(this.transform);
//        }
//        private void CreateLayerObj()
//        {
//            Type enumType = typeof(UILayerEnum);
//            string[] strs = System.Enum.GetNames(enumType);
//            foreach (var item in strs)
//            {
//                UILayerEnum uILayerEnum = (UILayerEnum)System.Enum.Parse(enumType, item);
//                GameObject obj = new GameObject(uILayerEnum.ToString(), typeof(RectTransform), typeof(CanvasGroup));
//                obj.transform.SetParent(MainUIObj.transform);
//                RectTransform rectTransform = obj.GetComponent<RectTransform>();

//                rectTransform.anchorMin = Vector2.zero;
//                rectTransform.anchorMax = Vector2.one;
//                //if (GameSetting.IsNotchScreen)
//                //{
//                //    float width = Screen.width;
//                //    float height = Screen.height;
//                //    float offsetY = (height - GameSetting.SafeArea.y) / 2f;
//                //    float offsetX = (width - GameSetting.SafeArea.x) / 2f;
//                //    rectTransform.offsetMax = new Vector2(offsetX * -1, offsetY * -1);
//                //    rectTransform.offsetMin = new Vector2(offsetX, offsetY);
//                //}
//                //else
//                //{
//                //    rectTransform.offsetMax = Vector2.zero;
//                //    rectTransform.offsetMin = Vector2.zero;
//                //}
//                rectTransform.offsetMax = Vector2.zero;
//                rectTransform.offsetMin = Vector2.zero;
//                rectTransform.SetSiblingIndex((int)uILayerEnum);
//                _tranDic.Add(uILayerEnum, rectTransform);
//            }
//        }
//    }
//}
