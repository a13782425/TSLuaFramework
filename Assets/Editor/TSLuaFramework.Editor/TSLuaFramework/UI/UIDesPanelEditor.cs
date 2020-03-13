using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace TSLuaFramework.Editor
{
    public sealed class UIDesPanelEditor : EditorWindow
    {
        [MenuItem("TSFrame/UI/帮助", false, 100)]
        public static void OpenWindow()
        {
            EditorWindow.GetWindowWithRect<UIDesPanelEditor>(new Rect(100, 100, 600, 240), true, "帮助");
        }


        private void OnGUI()
        {
            EditorGUILayout.BeginVertical();
            EditorGUILayout.Space();
            EditorGUILayout.LabelField(UIEditorUtils.UITemplate_Ref.UIDescription.text, new GUIStyle() { fontSize = 20 });
            EditorGUILayout.EndVertical();

        }
    }
}

