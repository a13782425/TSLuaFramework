using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.EventSystems;

namespace TSLuaFramework.Tool
{
    public class UIEvent
    {
        private GameObject gameObject;

        public UIEvent(GameObject obj)
        {
            gameObject = obj;
            _eventDic = new Dictionary<EventTriggerType, UIEventBase>();
        }

        public void Destroy()
        {
            gameObject = null;
            _eventDic = null;
        }

        /// <summary>
        /// 事件字典
        /// </summary>
        private Dictionary<EventTriggerType, UIEventBase> _eventDic = null;

        public void AddPointerEvent(EventTriggerType triggerType, Action<PointerEventData> value)
        {
            Debug.LogError("AddPointerEvent:" + triggerType.ToString());
            if (_eventDic.ContainsKey(triggerType))
            {
                _eventDic[triggerType].pointerCallback += value;
            }
            else
            {
                UIEventBase uIEventBase = UITool.GetUIEventBase(this.gameObject, triggerType);
                if (uIEventBase == null)
                {
                    throw new Exception($"{triggerType}的事件类型没有找到！");
                }
                _eventDic.Add(triggerType, uIEventBase);
                uIEventBase.pointerCallback += value;
            }
        }
        public void AddBaseEvent(EventTriggerType triggerType, Action<BaseEventData> value)
        {
            if (_eventDic.ContainsKey(triggerType))
            {
                _eventDic[triggerType].baseCallback += value;
            }
            else
            {
                UIEventBase uIEventBase = UITool.GetUIEventBase(this.gameObject, triggerType);
                if (uIEventBase == null)
                {
                    throw new Exception($"{triggerType}的事件类型没有找到！");
                }
                _eventDic.Add(triggerType, uIEventBase);
                uIEventBase.baseCallback += value;
            }
        }
        public void AddAxisEvent(EventTriggerType triggerType, Action<AxisEventData> value)
        {
            if (_eventDic.ContainsKey(triggerType))
            {
                _eventDic[triggerType].axisCallback += value;
            }
            else
            {
                UIEventBase uIEventBase = UITool.GetUIEventBase(this.gameObject, triggerType);
                if (uIEventBase == null)
                {
                    throw new Exception($"{triggerType}的事件类型没有找到！");
                }
                _eventDic.Add(triggerType, uIEventBase);
                uIEventBase.axisCallback += value;
            }
        }

        public void RemovePointerEvent(EventTriggerType triggerType, Action<PointerEventData> value)
        {
            Debug.LogError("RemovePointerEvent:" + triggerType.ToString());
            if (_eventDic.ContainsKey(triggerType))
            {
                _eventDic[triggerType].pointerCallback -= value;
            }
        }
        public void RemoveBaseEvent(EventTriggerType triggerType, Action<BaseEventData> value)
        {
            if (_eventDic.ContainsKey(triggerType))
            {
                _eventDic[triggerType].baseCallback -= value;
            }
        }
        public void RemoveAxisEvent(EventTriggerType triggerType, Action<AxisEventData> value)
        {
            if (_eventDic.ContainsKey(triggerType))
            {
                _eventDic[triggerType].axisCallback -= value;
            }
        }
    }

    public class UIEventBase : MonoBehaviour
    {
        internal Action<PointerEventData> pointerCallback;
        internal Action<BaseEventData> baseCallback;
        internal Action<AxisEventData> axisCallback;
    }
    //IPointerEnterHandler
    public class UIPointerEnterEvent : UIEventBase, IPointerEnterHandler
    {
        //internal event Action<PointerEventData> callback;

        public void OnPointerEnter(PointerEventData eventData)
        {
            pointerCallback?.Invoke(eventData);
        }
    }
    //IPointerExitHandler
    public class UIPointerExitEvent : UIEventBase, IPointerExitHandler
    {
        //internal event Action<PointerEventData> callback;

        public void OnPointerExit(PointerEventData eventData)
        {
            pointerCallback?.Invoke(eventData);
        }
    }
    //IPointerDownHandler
    public class UIPointerDownEvent : UIEventBase, IPointerDownHandler
    {
        //internal event Action<PointerEventData> callback;

        public void OnPointerDown(PointerEventData eventData)
        {
            pointerCallback?.Invoke(eventData);
        }
    }
    //IPointerUpHandler
    public class UIPointerUpEvent : UIEventBase, IPointerUpHandler
    {
        //internal event Action<PointerEventData> callback;

        public void OnPointerUp(PointerEventData eventData)
        {
            pointerCallback?.Invoke(eventData);
        }
    }
    //IPointerClickHandler
    public class UIPointerClickEvent : UIEventBase, IPointerClickHandler
    {
        //internal event Action<PointerEventData> callback;

        public void OnPointerClick(PointerEventData eventData)
        {
            pointerCallback?.Invoke(eventData);
        }
    }
    //IInitializePotentialDragHandler
    public class UIInitializePotentialDragEvent : UIEventBase, IInitializePotentialDragHandler
    {
        //internal event Action<PointerEventData> callback;

        public void OnInitializePotentialDrag(PointerEventData eventData)
        {
            pointerCallback?.Invoke(eventData);
        }
    }
    //IBeginDragHandler
    public class UIBeginDragEvent : UIEventBase, IBeginDragHandler
    {
        //internal event Action<PointerEventData> callback;

        public void OnBeginDrag(PointerEventData eventData)
        {
            pointerCallback?.Invoke(eventData);
        }
    }
    //IDragHandler
    public class UIDragEvent : UIEventBase, IDragHandler
    {
        //internal event Action<PointerEventData> callback;

        public void OnDrag(PointerEventData eventData)
        {
            pointerCallback?.Invoke(eventData);
        }
    }
    //IEndDragHandler
    public class UIEndDragEvent : UIEventBase, IEndDragHandler
    {
        //internal event Action<PointerEventData> callback;

        public void OnEndDrag(PointerEventData eventData)
        {
            pointerCallback?.Invoke(eventData);
        }
    }
    //IDropHandler
    public class UIDropEvent : UIEventBase, IDropHandler
    {
        //internal event Action<PointerEventData> callback;

        public void OnDrop(PointerEventData eventData)
        {
            pointerCallback?.Invoke(eventData);
        }
    }
    //IScrollHandler
    public class UIScrollEvent : UIEventBase, IScrollHandler
    {
        //internal event Action<PointerEventData> callback;

        public void OnScroll(PointerEventData eventData)
        {
            pointerCallback?.Invoke(eventData);
        }
    }
    //IUpdateSelectedHandler
    public class UIUpdateSelectedEvent : UIEventBase, IUpdateSelectedHandler
    {
        //internal event Action<BaseEventData> callback;

        public void OnUpdateSelected(BaseEventData eventData)
        {
            baseCallback?.Invoke(eventData);
        }
    }
    //ISelectHandler
    public class UISelectEvent : UIEventBase, ISelectHandler
    {
        //internal event Action<BaseEventData> callback;

        public void OnSelect(BaseEventData eventData)
        {
            baseCallback?.Invoke(eventData);
        }
    }
    //IDeselectHandler
    public class UIDeselectEvent : UIEventBase, IDeselectHandler
    {
        //internal event Action<BaseEventData> callback;

        public void OnDeselect(BaseEventData eventData)
        {
            baseCallback?.Invoke(eventData); ;
        }
    }
    //IMoveHandler
    public class UIMoveEvent : UIEventBase, IMoveHandler
    {
        //internal event Action<AxisEventData> callback;

        public void OnMove(AxisEventData eventData)
        {
            axisCallback?.Invoke(eventData);
        }
    }
    //ISubmitHandler
    public class UISubmitEvent : UIEventBase, ISubmitHandler
    {
        //internal event Action<BaseEventData> callback;

        public void OnSubmit(BaseEventData eventData)
        {
            baseCallback?.Invoke(eventData);
        }
    }
    //ICancelHandler
    public class UICancelEvent : UIEventBase, ICancelHandler
    {
        //internal event Action<BaseEventData> callback;

        public void OnCancel(BaseEventData eventData)
        {
            baseCallback?.Invoke(eventData);
        }
    }

}
