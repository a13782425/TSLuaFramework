using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.EventSystems;
using XLua;

namespace TSLuaFramework.Tool
{
    public class UIEvent
    {
        private GameObject _gameObject;

        public UIEvent(GameObject obj)
        {
            _gameObject = obj;
            _eventDic = new Dictionary<EventTriggerType, UIEventBase>();
        }

        public void Destroy()
        {
            foreach (var item in _eventDic)
            {
                item.Value.luaTables.Clear();
            }
            _gameObject = null;
            _eventDic = null;
        }

        /// <summary>
        /// 事件字典
        /// </summary>
        private Dictionary<EventTriggerType, UIEventBase> _eventDic = null;

        public void AddPointerEvent(EventTriggerType triggerType, LuaTable value)
        {
            if (_eventDic.ContainsKey(triggerType))
            {
                _eventDic[triggerType].luaTables.Add(value.Get<int>("_instanceId"), value);
            }
            else
            {
                UIEventBase uIEventBase = UITool.GetUIEventBase(this._gameObject, triggerType);
                if (uIEventBase == null)
                {
                    throw new Exception($"{triggerType}的事件类型没有找到！");
                }
                _eventDic.Add(triggerType, uIEventBase);
                uIEventBase.luaTables.Add(value.Get<int>("_instanceId"), value);
            }
        }
        public void AddBaseEvent(EventTriggerType triggerType, LuaTable value)
        {
            if (_eventDic.ContainsKey(triggerType))
            {
                _eventDic[triggerType].luaTables.Add(value.Get<int>("_instanceId"), value);
            }
            else
            {
                UIEventBase uIEventBase = UITool.GetUIEventBase(this._gameObject, triggerType);
                if (uIEventBase == null)
                {
                    throw new Exception($"{triggerType}的事件类型没有找到！");
                }
                _eventDic.Add(triggerType, uIEventBase);
                uIEventBase.luaTables.Add(value.Get<int>("_instanceId"), value);
            }
        }
        public void AddAxisEvent(EventTriggerType triggerType, LuaTable value)
        {
            if (_eventDic.ContainsKey(triggerType))
            {
                _eventDic[triggerType].luaTables.Add(value.Get<int>("_instanceId"), value);
            }
            else
            {
                UIEventBase uIEventBase = UITool.GetUIEventBase(this._gameObject, triggerType);
                if (uIEventBase == null)
                {
                    throw new Exception($"{triggerType}的事件类型没有找到！");
                }
                _eventDic.Add(triggerType, uIEventBase);
                uIEventBase.luaTables.Add(value.Get<int>("_instanceId"), value);
            }
        }

        public void RemovePointerEvent(EventTriggerType triggerType, LuaTable value)
        {
            if (_eventDic.ContainsKey(triggerType))
            {
                int key = value.Get<int>("_instanceId");
                if (_eventDic[triggerType].luaTables.ContainsKey(key))
                {
                    _eventDic[triggerType].luaTables.Remove(key);
                }
            }
        }
        public void RemoveBaseEvent(EventTriggerType triggerType, LuaTable value)
        {
            if (_eventDic.ContainsKey(triggerType))
            {
                int key = value.Get<int>("_instanceId");
                if (_eventDic[triggerType].luaTables.ContainsKey(key))
                {
                    _eventDic[triggerType].luaTables.Remove(key);
                }
            }
        }
        public void RemoveAxisEvent(EventTriggerType triggerType, LuaTable value)
        {
            if (_eventDic.ContainsKey(triggerType))
            {
                int key = value.Get<int>("_instanceId");
                if (_eventDic[triggerType].luaTables.ContainsKey(key))
                {
                    _eventDic[triggerType].luaTables.Remove(key);
                }
            }
        }
    }

    public class UIEventBase : MonoBehaviour
    {
        internal Dictionary<int, LuaTable> luaTables = new Dictionary<int, LuaTable>();
    }
    //IPointerEnterHandler
    public class UIPointerEnterEvent : UIEventBase, IPointerEnterHandler
    {
        //internal event Action<PointerEventData> callback;

        public void OnPointerEnter(PointerEventData eventData)
        {
            List<int> keys= luaTables.Keys.ToList();
            foreach (var item in keys)
            {
                if (luaTables.ContainsKey(item))
                {
                    LuaFunction luaFunction = luaTables[item].Get<LuaFunction>("_func");
                    LuaTable luaObj = luaTables[item].Get<LuaTable>("_obj");
                    luaFunction.Call(luaObj, eventData);
                }
            }
        }
    }
    //IPointerExitHandler
    public class UIPointerExitEvent : UIEventBase, IPointerExitHandler
    {
        //internal event Action<PointerEventData> callback;

        public void OnPointerExit(PointerEventData eventData)
        {
            List<int> keys = luaTables.Keys.ToList();
            foreach (var item in keys)
            {
                if (luaTables.ContainsKey(item))
                {
                    LuaFunction luaFunction = luaTables[item].Get<LuaFunction>("_func");
                    LuaTable luaObj = luaTables[item].Get<LuaTable>("_obj");
                    luaFunction.Call(luaObj, eventData);
                }
            }
        }
    }
    //IPointerDownHandler
    public class UIPointerDownEvent : UIEventBase, IPointerDownHandler
    {
        //internal event Action<PointerEventData> callback;

        public void OnPointerDown(PointerEventData eventData)
        {
            List<int> keys = luaTables.Keys.ToList();
            foreach (var item in keys)
            {
                if (luaTables.ContainsKey(item))
                {
                    LuaFunction luaFunction = luaTables[item].Get<LuaFunction>("_func");
                    LuaTable luaObj = luaTables[item].Get<LuaTable>("_obj");
                    luaFunction.Call(luaObj, eventData);
                }
            }
        }
    }
    //IPointerUpHandler
    public class UIPointerUpEvent : UIEventBase, IPointerUpHandler
    {
        //internal event Action<PointerEventData> callback;

        public void OnPointerUp(PointerEventData eventData)
        {
            List<int> keys = luaTables.Keys.ToList();
            foreach (var item in keys)
            {
                if (luaTables.ContainsKey(item))
                {
                    LuaFunction luaFunction = luaTables[item].Get<LuaFunction>("_func");
                    LuaTable luaObj = luaTables[item].Get<LuaTable>("_obj");
                    luaFunction.Call(luaObj, eventData);
                }
            }
        }
    }
    //IPointerClickHandler
    public class UIPointerClickEvent : UIEventBase, IPointerClickHandler
    {
        //internal event Action<PointerEventData> callback;

        public void OnPointerClick(PointerEventData eventData)
        {
            List<int> keys = luaTables.Keys.ToList();
            foreach (var item in keys)
            {
                if (luaTables.ContainsKey(item))
                {
                    LuaFunction luaFunction = luaTables[item].Get<LuaFunction>("_func");
                    LuaTable luaObj = luaTables[item].Get<LuaTable>("_obj");
                    luaFunction.Call(luaObj, eventData);
                }
            }
        }
    }
    //IInitializePotentialDragHandler
    public class UIInitializePotentialDragEvent : UIEventBase, IInitializePotentialDragHandler
    {
        //internal event Action<PointerEventData> callback;

        public void OnInitializePotentialDrag(PointerEventData eventData)
        {
            List<int> keys = luaTables.Keys.ToList();
            foreach (var item in keys)
            {
                if (luaTables.ContainsKey(item))
                {
                    LuaFunction luaFunction = luaTables[item].Get<LuaFunction>("_func");
                    LuaTable luaObj = luaTables[item].Get<LuaTable>("_obj");
                    luaFunction.Call(luaObj, eventData);
                }
            }
        }
    }
    //IBeginDragHandler
    public class UIBeginDragEvent : UIEventBase, IBeginDragHandler
    {
        //internal event Action<PointerEventData> callback;

        public void OnBeginDrag(PointerEventData eventData)
        {
            List<int> keys = luaTables.Keys.ToList();
            foreach (var item in keys)
            {
                if (luaTables.ContainsKey(item))
                {
                    LuaFunction luaFunction = luaTables[item].Get<LuaFunction>("_func");
                    LuaTable luaObj = luaTables[item].Get<LuaTable>("_obj");
                    luaFunction.Call(luaObj, eventData);
                }
            }
        }
    }
    //IDragHandler
    public class UIDragEvent : UIEventBase, IDragHandler
    {
        //internal event Action<PointerEventData> callback;

        public void OnDrag(PointerEventData eventData)
        {
            List<int> keys = luaTables.Keys.ToList();
            foreach (var item in keys)
            {
                if (luaTables.ContainsKey(item))
                {
                    LuaFunction luaFunction = luaTables[item].Get<LuaFunction>("_func");
                    LuaTable luaObj = luaTables[item].Get<LuaTable>("_obj");
                    luaFunction.Call(luaObj, eventData);
                }
            }
        }
    }
    //IEndDragHandler
    public class UIEndDragEvent : UIEventBase, IEndDragHandler
    {
        //internal event Action<PointerEventData> callback;

        public void OnEndDrag(PointerEventData eventData)
        {
            List<int> keys = luaTables.Keys.ToList();
            foreach (var item in keys)
            {
                if (luaTables.ContainsKey(item))
                {
                    LuaFunction luaFunction = luaTables[item].Get<LuaFunction>("_func");
                    LuaTable luaObj = luaTables[item].Get<LuaTable>("_obj");
                    luaFunction.Call(luaObj, eventData);
                }
            }
        }
    }
    //IDropHandler
    public class UIDropEvent : UIEventBase, IDropHandler
    {
        //internal event Action<PointerEventData> callback;

        public void OnDrop(PointerEventData eventData)
        {
            List<int> keys = luaTables.Keys.ToList();
            foreach (var item in keys)
            {
                if (luaTables.ContainsKey(item))
                {
                    LuaFunction luaFunction = luaTables[item].Get<LuaFunction>("_func");
                    LuaTable luaObj = luaTables[item].Get<LuaTable>("_obj");
                    luaFunction.Call(luaObj, eventData);
                }
            }
        }
    }
    //IScrollHandler
    public class UIScrollEvent : UIEventBase, IScrollHandler
    {
        //internal event Action<PointerEventData> callback;

        public void OnScroll(PointerEventData eventData)
        {
            List<int> keys = luaTables.Keys.ToList();
            foreach (var item in keys)
            {
                if (luaTables.ContainsKey(item))
                {
                    LuaFunction luaFunction = luaTables[item].Get<LuaFunction>("_func");
                    LuaTable luaObj = luaTables[item].Get<LuaTable>("_obj");
                    luaFunction.Call(luaObj, eventData);
                }
            }
        }
    }
    //IUpdateSelectedHandler
    public class UIUpdateSelectedEvent : UIEventBase, IUpdateSelectedHandler
    {
        //internal event Action<BaseEventData> callback;

        public void OnUpdateSelected(BaseEventData eventData)
        {
            List<int> keys = luaTables.Keys.ToList();
            foreach (var item in keys)
            {
                if (luaTables.ContainsKey(item))
                {
                    LuaFunction luaFunction = luaTables[item].Get<LuaFunction>("_func");
                    LuaTable luaObj = luaTables[item].Get<LuaTable>("_obj");
                    luaFunction.Call(luaObj, eventData);
                }
            }
        }
    }
    //ISelectHandler
    public class UISelectEvent : UIEventBase, ISelectHandler
    {
        //internal event Action<BaseEventData> callback;

        public void OnSelect(BaseEventData eventData)
        {
            List<int> keys = luaTables.Keys.ToList();
            foreach (var item in keys)
            {
                if (luaTables.ContainsKey(item))
                {
                    LuaFunction luaFunction = luaTables[item].Get<LuaFunction>("_func");
                    LuaTable luaObj = luaTables[item].Get<LuaTable>("_obj");
                    luaFunction.Call(luaObj, eventData);
                }
            }
        }
    }
    //IDeselectHandler
    public class UIDeselectEvent : UIEventBase, IDeselectHandler
    {
        //internal event Action<BaseEventData> callback;

        public void OnDeselect(BaseEventData eventData)
        {
            List<int> keys = luaTables.Keys.ToList();
            foreach (var item in keys)
            {
                if (luaTables.ContainsKey(item))
                {
                    LuaFunction luaFunction = luaTables[item].Get<LuaFunction>("_func");
                    LuaTable luaObj = luaTables[item].Get<LuaTable>("_obj");
                    luaFunction.Call(luaObj, eventData);
                }
            }
        }
    }
    //IMoveHandler
    public class UIMoveEvent : UIEventBase, IMoveHandler
    {
        //internal event Action<AxisEventData> callback;

        public void OnMove(AxisEventData eventData)
        {
            List<int> keys = luaTables.Keys.ToList();
            foreach (var item in keys)
            {
                if (luaTables.ContainsKey(item))
                {
                    LuaFunction luaFunction = luaTables[item].Get<LuaFunction>("_func");
                    LuaTable luaObj = luaTables[item].Get<LuaTable>("_obj");
                    luaFunction.Call(luaObj, eventData);
                }
            }
        }
    }
    //ISubmitHandler
    public class UISubmitEvent : UIEventBase, ISubmitHandler
    {
        //internal event Action<BaseEventData> callback;

        public void OnSubmit(BaseEventData eventData)
        {
            List<int> keys = luaTables.Keys.ToList();
            foreach (var item in keys)
            {
                if (luaTables.ContainsKey(item))
                {
                    LuaFunction luaFunction = luaTables[item].Get<LuaFunction>("_func");
                    LuaTable luaObj = luaTables[item].Get<LuaTable>("_obj");
                    luaFunction.Call(luaObj, eventData);
                }
            }
        }
    }
    //ICancelHandler
    public class UICancelEvent : UIEventBase, ICancelHandler
    {
        //internal event Action<BaseEventData> callback;

        public void OnCancel(BaseEventData eventData)
        {
            List<int> keys = luaTables.Keys.ToList();
            foreach (var item in keys)
            {
                if (luaTables.ContainsKey(item))
                {
                    LuaFunction luaFunction = luaTables[item].Get<LuaFunction>("_func");
                    LuaTable luaObj = luaTables[item].Get<LuaTable>("_obj");
                    luaFunction.Call(luaObj, eventData);
                }
            }
        }
    }

}
