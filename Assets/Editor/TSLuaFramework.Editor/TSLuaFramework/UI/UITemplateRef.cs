using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace TSLuaFramework.Editor
{
    public class UITemplateRef : ScriptableObject
    {
        //TemplateRef template_ref = ScriptableObject.CreateInstance<TemplateRef>();
        public TextAsset UIDescription;
        public TextAsset ModelTemplate;
        public TextAsset ConfigTemplate;
    }
}
