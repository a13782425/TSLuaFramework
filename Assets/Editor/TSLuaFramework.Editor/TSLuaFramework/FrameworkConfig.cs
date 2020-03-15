using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace TSLuaFramework.Editor
{
    public class FrameworkConfig : ScriptableObject
    {
        //TemplateRef template_ref = ScriptableObject.CreateInstance<TemplateRef>();
        //public TextAsset UIDescription;
        public TextAsset ViewTemplate;
        public TextAsset ModelTemplate;

        public string PanelPath = "";
        public string ItemPath = "";
        public string ViewConfigPath = "";
        public string ViewCreatorPath = "";
        public string PanelScriptPath = "";
        public string ItemScriptPath = "";
        public string PanelViewModelPath = "";
        public string ItemViewModelPath = "";

        //public List<ExportDto> UIExports = new List<ExportDto>();
        [HideInInspector]
        [NonSerialized]
        public Dictionary<string, string> UIExportDic = new Dictionary<string, string>()
        {
            {"btn_", "Button" },
            {"img_", "Image" },
            {"txt_", "Text" },
            {"txtp_", "TextPlus" },
            {"inp_", "InputField" },
            {"srect_", "ScrollRect" },
            {"sbar_", "Scrollbar" },
            {"tog_", "Toggle" },
            {"sli_", "Slider" },
            {"drop_", "Dropdown" },
            {"can_", "Canvas" },
            {"go_", "GameObject" },
            {"tran_", "Transform" },
            {"rtran_", "RectTransform" }
        };
        [HideInInspector]
        [NonSerialized]
        public Dictionary<string, string> MVVMTypeDic = new Dictionary<string, string>()
        {
            {"Button", "UIButton" },
            {"Image", "UIImage" },
            {"Text", "UIText" },
            {"InputField", "UIInputField" },
            {"TextPlus", "UITextPlus" },
            {"Toggle", "UIToggle" },
            {"Slider", "UISlider" },
            {"Scrollbar", "UIScrollbar" },
            {"Dropdown", "UIDropdown" }
        };

        internal bool CheckPath()
        {
            return ViewTemplate != null && ModelTemplate != null && !string.IsNullOrWhiteSpace(PanelPath) && !string.IsNullOrWhiteSpace(ItemPath) && !string.IsNullOrWhiteSpace(ViewConfigPath) && !string.IsNullOrWhiteSpace(ViewCreatorPath) && !string.IsNullOrWhiteSpace(PanelScriptPath) && !string.IsNullOrWhiteSpace(ItemScriptPath) && !string.IsNullOrWhiteSpace(PanelViewModelPath) && !string.IsNullOrWhiteSpace(ItemViewModelPath);
        }
        //[Serializable]
        //public class ExportDto
        //{
        //    public string Key;
        //    public string Value;
        //}
        //public Dictionary<string, string> UIExportDic;
    }
}
