using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.EventSystems;

namespace TSLuaFramework.Tool
{
    internal class UITool
    {
        internal static UIEventBase GetUIEventBase(GameObject obj, EventTriggerType triggerType)
        {
            UIEventBase uIEventBase = null;
            switch (triggerType)
            {
                case EventTriggerType.PointerEnter:
                    uIEventBase = obj.AddComponent<UIPointerEnterEvent>();
                    break;
                case EventTriggerType.PointerExit:
                    uIEventBase = obj.AddComponent<UIPointerExitEvent>();
                    break;
                case EventTriggerType.PointerDown:
                    uIEventBase = obj.AddComponent<UIPointerDownEvent>();
                    break;
                case EventTriggerType.PointerUp:
                    uIEventBase = obj.AddComponent<UIPointerUpEvent>();
                    break;
                case EventTriggerType.PointerClick:
                    uIEventBase = obj.AddComponent<UIPointerClickEvent>();
                    break;
                case EventTriggerType.Drag:
                    uIEventBase = obj.AddComponent<UIDragEvent>();
                    break;
                case EventTriggerType.BeginDrag:
                    uIEventBase = obj.AddComponent<UIBeginDragEvent>();
                    break;
                case EventTriggerType.EndDrag:
                    uIEventBase = obj.AddComponent<UIEndDragEvent>();
                    break;
                case EventTriggerType.Submit:
                    uIEventBase = obj.AddComponent<UISubmitEvent>();
                    break;
                case EventTriggerType.Cancel:
                    uIEventBase = obj.AddComponent<UICancelEvent>();
                    break;
                case EventTriggerType.Drop:
                    uIEventBase = obj.AddComponent<UIDropEvent>();
                    break;
                case EventTriggerType.Scroll:
                    uIEventBase = obj.AddComponent<UIScrollEvent>();
                    break;
                case EventTriggerType.UpdateSelected:
                    uIEventBase = obj.AddComponent<UIUpdateSelectedEvent>();
                    break;
                case EventTriggerType.Select:
                    uIEventBase = obj.AddComponent<UISelectEvent>();
                    break;
                case EventTriggerType.Deselect:
                    uIEventBase = obj.AddComponent<UIDeselectEvent>();
                    break;
                case EventTriggerType.Move:
                    uIEventBase = obj.AddComponent<UIMoveEvent>();
                    break;
                case EventTriggerType.InitializePotentialDrag:
                    uIEventBase = obj.AddComponent<UIInitializePotentialDragEvent>();
                    break;
            }
            return uIEventBase;
        }
    }
}
