using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TSLuaFramework;
using TSLuaFramework.Tool;
using UnityEditor;
using UnityEngine;
using Debug = UnityEngine.Debug;
//using static TSFrame.Editor.Properties.Resources;

namespace TSLuaFramework.Editor
{
    internal static class ViewEditor
    {
        private const string SCRIPT_ROOT = "LuaScript";
        private const string ASSETS_ROOT = "Assets";
        [MenuItem("TSFrame/UI/生成View #V", false, 0)]
        internal static void GenerateView()
        {
            try
            {
                if (!FrameworkEditorUtils.CheckConfig())
                {
                    EditorUtility.DisplayDialog("错误", "配置表路径没有配置，请配置与Asset同级的config文件", "OK");
                    return;
                }
                CheckPath();
                //EditorUtility.DisplayProgressBar("生成View", "正在生成View", 0);
                List<ViewDto> viewList = new List<ViewDto>();
                LoadPanel(ref viewList);
                LoadItem(ref viewList);
                StringBuilder uiconfigSb = new StringBuilder();
                InitSb(uiconfigSb);
                GenerateConfig(uiconfigSb, viewList);
                StringBuilder uiCreateorSb = new StringBuilder();
                InitSb(uiCreateorSb);
                GenerateCreateor(uiCreateorSb, viewList);
                foreach (var item in viewList)
                {
                    string code = null;
                    if (File.Exists(item.ViewFilePath))
                    {
                        item.ViewCode = File.ReadAllText(item.ViewFilePath);
                    }
                    code = GenComponent(item);

                    File.WriteAllText(item.ViewFilePath, string.IsNullOrWhiteSpace(code) ? item.ViewCode : code, new UTF8Encoding());
                    if (!File.Exists(item.ModelFilePath))
                    {
                        File.WriteAllText(item.ModelFilePath, item.ModelCode, new UTF8Encoding());
                    }
                }
                File.WriteAllText(FrameworkEditorUtils.FRAMEWORK_CONFIG.ViewConfigPath + "/UIConfig.lua.txt", uiconfigSb.ToString(), new UTF8Encoding());
                File.WriteAllText(FrameworkEditorUtils.FRAMEWORK_CONFIG.ViewCreatorPath + "/UICreator.lua.txt", uiCreateorSb.ToString(), new UTF8Encoding());

                EditorUtility.DisplayDialog("Successful", "生成成功succeed", "确定");
                //EditorUtility.ClearProgressBar();
                AssetDatabase.Refresh();
            }
            catch (Exception ex)
            {
                Debug.LogError(ex);
            }
            finally
            {
                //EditorUtility.ClearProgressBar();
            }

        }

        private static string GenComponent(ViewDto item)
        {
            string[] strs = item.ViewCode.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            int startNum = item.ViewCode.IndexOf("---界面组件定义开始");
            startNum += "---界面组件定义开始".Length;
            int endNum = item.ViewCode.IndexOf("---界面组件定义结束");
            endNum--;
            StringBuilder sb = new StringBuilder();
            if (startNum > 0 && endNum > 0)
            {
                if (startNum > endNum)
                {
                    int temp = startNum;
                    startNum = endNum;
                    endNum = temp;
                }
                for (int i = 0; i < item.ViewCode.Length; i++)
                {
                    if (i != startNum)
                    {
                        sb.Append(item.ViewCode[i]);
                    }
                    else
                    {
                        sb.Append(item.ViewCode[startNum]);
                        foreach (var com in item.Components)
                        {
                            sb.AppendLine("---self." + com);
                        }
                        i = endNum;
                    }
                }
            }
            return sb.ToString();
        }

        private static void GenerateCreateor(StringBuilder uiCreateorSb, List<ViewDto> viewList)
        {
            foreach (var item in viewList)
            {
                uiCreateorSb.AppendLine($"local {item.Name}_Gen = require '{item.ViewIncludePath}'");
                uiCreateorSb.AppendLine();
                uiCreateorSb.AppendLine($"{item.Name}_Gen.InitializeElement = function(self)");
                //Debug.LogError(item.PrefabPath);
                GameObject obj = AssetDatabase.LoadAssetAtPath<GameObject>(item.PrefabPath);
                List<TranDto> trans = new List<TranDto>();
                FrameworkEditorUtils.GetTrans(obj.transform, "", trans);
                CreateComponent(trans, uiCreateorSb, item);
                //todo 获取所有组件
                uiCreateorSb.AppendLine("end");
                uiCreateorSb.AppendLine();
            }
        }

        private static void CreateComponent(List<TranDto> trans, StringBuilder uiCreateorSb, ViewDto viewDto)
        {
            trans.Reverse();
            uiCreateorSb.AppendLine();
            foreach (var item in trans)
            {
                string comName = item.Tran.name;
                string typeName = FrameworkEditorUtils.GetExportType(comName);
                string mvvmName = FrameworkEditorUtils.GetMVVMExportType(typeName);
                if (viewDto.Components.Contains(comName))
                {
                    throw new Exception($"界面:{viewDto.Name},存在重复命名组件:{comName}");
                }
                viewDto.Components.Add(comName);
                if (typeName == typeof(Transform).Name)
                {
                    uiCreateorSb.AppendLine($"    self.{comName} = self.transform:Find('{comName}')");
                }
                else if (typeName == typeof(GameObject).Name)
                {
                    uiCreateorSb.AppendLine($"    self.{comName} = self.transform:Find('{comName}').gameObject");
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(mvvmName))
                    {
                        uiCreateorSb.AppendLine($"    self.{comName} = self.transform:Find('{comName}'):GetComponent(typeof({typeName}))");
                    }
                    else
                    {
                        uiCreateorSb.AppendLine($"    self.raw_{comName} = self.transform:Find('{comName}'):GetComponent(typeof({typeName}))");
                        uiCreateorSb.AppendLine($"    self.{comName} = self:BindingElement(self.raw_{comName})");
                    }
                }
            }
            uiCreateorSb.AppendLine();
        }

        private static void GenerateConfig(StringBuilder uiconfigSb, List<ViewDto> viewList)
        {
            uiconfigSb.AppendLine("local UIConfig = {");
            uiconfigSb.AppendLine("    Panel = {");
            List<ViewDto> views = viewList.Where((a) => a.BaseName == "UIPanel").ToList();
            foreach (var item in views)
            {
                uiconfigSb.AppendLine($"        {item.Name} = {{");
                uiconfigSb.AppendLine($"            --页面名称");
                uiconfigSb.AppendLine($"            ViewName = '{item.Name}',");
                uiconfigSb.AppendLine($"            --页面预制的名称");
                uiconfigSb.AppendLine($"            PrefabName = '{item.Name.ToLower()}',");
                uiconfigSb.AppendLine($"            View = require '{item.ViewIncludePath}',");
                uiconfigSb.AppendLine($"            ViewModel = require '{item.ModelIncludePath}',");
                uiconfigSb.AppendLine("        },");
            }
            uiconfigSb.AppendLine("    },");

            uiconfigSb.AppendLine("    Item = {");
            views = viewList.Where((a) => a.BaseName != "UIPanel").ToList();
            foreach (var item in views)
            {
                uiconfigSb.AppendLine($"        {item.Name} = {{");
                uiconfigSb.AppendLine($"            --页面名称");
                uiconfigSb.AppendLine($"            ViewName = '{item.Name}',");
                uiconfigSb.AppendLine($"            --页面预制的名称");
                uiconfigSb.AppendLine($"            PrefabName = '{item.Name.ToLower()}',");
                uiconfigSb.AppendLine($"            View = require '{item.ViewIncludePath}',");
                uiconfigSb.AppendLine($"            ViewModel = require '{item.ModelIncludePath}',");
                uiconfigSb.AppendLine("        },");
            }
            uiconfigSb.AppendLine("    }");
            uiconfigSb.AppendLine("}");
            uiconfigSb.AppendLine("return ConstClass('UIConfig', UIConfig);");
        }

        private static void LoadPanel(ref List<ViewDto> viewList)
        {
            string[] panels = Directory.GetFiles(Path.Combine(Application.dataPath, FrameworkEditorUtils.FRAMEWORK_CONFIG.PanelPath), "*.prefab");
            foreach (var item in panels)
            {
                ViewDto viewDto = new ViewDto();
                viewDto.BaseName = "UIPanel";
                viewDto.Name = Path.GetFileNameWithoutExtension(item);
                viewDto.ViewName = viewDto.Name + "View";
                string viewTemp = FrameworkEditorUtils.FRAMEWORK_CONFIG.ViewTemplate.text;
                viewTemp = viewTemp.Replace("{ClassName}", viewDto.ViewName);
                viewTemp = viewTemp.Replace("{Base}", viewDto.BaseName);
                viewDto.ViewCode = viewTemp;
                viewDto.ViewFilePath = FrameworkEditorUtils.FRAMEWORK_CONFIG.PanelScriptPath + "/" + viewDto.ViewName + ".lua.txt";
                int num = FrameworkEditorUtils.FRAMEWORK_CONFIG.PanelScriptPath.IndexOf(SCRIPT_ROOT);
                num = num + SCRIPT_ROOT.Length + 1;
                viewDto.ViewIncludePath = FrameworkEditorUtils.FRAMEWORK_CONFIG.PanelScriptPath.Substring(num, FrameworkEditorUtils.FRAMEWORK_CONFIG.PanelScriptPath.Length - num);
                viewDto.ViewIncludePath = viewDto.ViewIncludePath.Replace("/", ".");
                viewDto.ViewIncludePath = viewDto.ViewIncludePath.Replace("\\", ".");
                viewDto.ViewIncludePath = viewDto.ViewIncludePath + "." + viewDto.ViewName;

                viewDto.ModelName = viewDto.Name + "ViewModel";
                viewTemp = FrameworkEditorUtils.FRAMEWORK_CONFIG.ModelTemplate.text;
                viewTemp = viewTemp.Replace("{ClassName}", viewDto.ModelName);
                viewDto.ModelCode = viewTemp;
                viewDto.ModelFilePath = FrameworkEditorUtils.FRAMEWORK_CONFIG.PanelViewModelPath + "/" + viewDto.ModelName + ".lua.txt";
                num = FrameworkEditorUtils.FRAMEWORK_CONFIG.PanelViewModelPath.LastIndexOf(SCRIPT_ROOT);
                num = num + SCRIPT_ROOT.Length + 1;
                viewDto.ModelIncludePath = FrameworkEditorUtils.FRAMEWORK_CONFIG.PanelViewModelPath.Substring(num, FrameworkEditorUtils.FRAMEWORK_CONFIG.PanelViewModelPath.Length - num);
                viewDto.ModelIncludePath = viewDto.ModelIncludePath.Replace("/", ".");
                viewDto.ModelIncludePath = viewDto.ModelIncludePath.Replace("\\", ".");
                viewDto.ModelIncludePath = viewDto.ModelIncludePath + "." + viewDto.ModelName;
                num = item.LastIndexOf(ASSETS_ROOT);
                string path = item.Substring(num, item.Length - num);
                //path = Path.GetDirectoryName(path);
                //viewDto.PrefabPath = path + "\\" + Path.GetFileNameWithoutExtension(item);
                viewDto.PrefabPath = path;
                viewList.Add(viewDto);
            }
        }
        private static void LoadItem(ref List<ViewDto> viewList)
        {
            string[] panels = Directory.GetFiles(Path.Combine(Application.dataPath, FrameworkEditorUtils.FRAMEWORK_CONFIG.ItemPath), "*.prefab");
            foreach (var item in panels)
            {
                ViewDto viewDto = new ViewDto();
                viewDto.BaseName = "UIItem";
                viewDto.Name = Path.GetFileNameWithoutExtension(item);
                viewDto.ViewName = viewDto.Name + "View";
                string viewTemp = FrameworkEditorUtils.FRAMEWORK_CONFIG.ViewTemplate.text;
                viewTemp = viewTemp.Replace("{ClassName}", viewDto.ViewName);
                viewTemp = viewTemp.Replace("{Base}", viewDto.BaseName);
                viewDto.ViewCode = viewTemp;
                viewDto.ViewFilePath = FrameworkEditorUtils.FRAMEWORK_CONFIG.ItemScriptPath + "/" + viewDto.ViewName + ".lua.txt";
                int num = FrameworkEditorUtils.FRAMEWORK_CONFIG.ItemScriptPath.LastIndexOf(SCRIPT_ROOT);
                num = num + SCRIPT_ROOT.Length + 1;
                viewDto.ViewIncludePath = FrameworkEditorUtils.FRAMEWORK_CONFIG.ItemScriptPath.Substring(num, FrameworkEditorUtils.FRAMEWORK_CONFIG.ItemScriptPath.Length - num);
                viewDto.ViewIncludePath = viewDto.ViewIncludePath.Replace("/", ".");
                viewDto.ViewIncludePath = viewDto.ViewIncludePath.Replace("\\", ".");
                viewDto.ViewIncludePath = viewDto.ViewIncludePath + "." + viewDto.ViewName;

                viewDto.ModelName = viewDto.Name + "ViewModel";
                viewTemp = FrameworkEditorUtils.FRAMEWORK_CONFIG.ModelTemplate.text;
                viewTemp = viewTemp.Replace("{ClassName}", viewDto.ModelName);
                viewDto.ModelCode = viewTemp;
                viewDto.ModelFilePath = FrameworkEditorUtils.FRAMEWORK_CONFIG.ItemViewModelPath + "/" + viewDto.ModelName + ".lua.txt";
                num = FrameworkEditorUtils.FRAMEWORK_CONFIG.ItemViewModelPath.LastIndexOf(SCRIPT_ROOT);
                num = num + SCRIPT_ROOT.Length + 1;
                viewDto.ModelIncludePath = FrameworkEditorUtils.FRAMEWORK_CONFIG.ItemViewModelPath.Substring(num, FrameworkEditorUtils.FRAMEWORK_CONFIG.ItemViewModelPath.Length - num);
                viewDto.ModelIncludePath = viewDto.ModelIncludePath.Replace("/", ".");
                viewDto.ModelIncludePath = viewDto.ModelIncludePath.Replace("\\", ".");
                viewDto.ModelIncludePath = viewDto.ModelIncludePath + "." + viewDto.ModelName;
                num = item.LastIndexOf(ASSETS_ROOT);
                string path = item.Substring(num, item.Length - num);
                //path = Path.GetDirectoryName(path);
                //viewDto.PrefabPath = path + "\\" + Path.GetFileNameWithoutExtension(item);
                viewDto.PrefabPath = path;
                viewList.Add(viewDto);
            }
        }

        private static void InitSb(StringBuilder sb)
        {
            //------------------------------------------------------------------------------------------------------------
            //-----------------------------------generate file {GeneratedTime}----------------------------------------
            //------------------------------------------------------------------------------------------------------------
            sb.AppendLine("------------------------------------------------------------------------------------------------------------");
            sb.AppendLine($"-----------------------------------generate file {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}----------------------------------------");
            sb.AppendLine("------------------------------------------------------------------------------------------------------------");
            sb.AppendLine();
        }

        private static void CheckPath()
        {
            if (!Directory.Exists(FrameworkEditorUtils.FRAMEWORK_CONFIG.PanelPath))
            {
                Directory.CreateDirectory(FrameworkEditorUtils.FRAMEWORK_CONFIG.PanelPath);
            }
            if (!Directory.Exists(FrameworkEditorUtils.FRAMEWORK_CONFIG.ItemPath))
            {
                Directory.CreateDirectory(FrameworkEditorUtils.FRAMEWORK_CONFIG.ItemPath);
            }
            if (!Directory.Exists(FrameworkEditorUtils.FRAMEWORK_CONFIG.ViewConfigPath))
            {
                Directory.CreateDirectory(FrameworkEditorUtils.FRAMEWORK_CONFIG.ViewConfigPath);
            }
            if (!Directory.Exists(FrameworkEditorUtils.FRAMEWORK_CONFIG.ViewCreatorPath))
            {
                Directory.CreateDirectory(FrameworkEditorUtils.FRAMEWORK_CONFIG.ViewCreatorPath);
            }
            if (!Directory.Exists(FrameworkEditorUtils.FRAMEWORK_CONFIG.PanelScriptPath))
            {
                Directory.CreateDirectory(FrameworkEditorUtils.FRAMEWORK_CONFIG.PanelScriptPath);
            }
            if (!Directory.Exists(FrameworkEditorUtils.FRAMEWORK_CONFIG.ItemScriptPath))
            {
                Directory.CreateDirectory(FrameworkEditorUtils.FRAMEWORK_CONFIG.ItemScriptPath);
            }
            if (!Directory.Exists(FrameworkEditorUtils.FRAMEWORK_CONFIG.PanelViewModelPath))
            {
                Directory.CreateDirectory(FrameworkEditorUtils.FRAMEWORK_CONFIG.PanelViewModelPath);
            }
            if (!Directory.Exists(FrameworkEditorUtils.FRAMEWORK_CONFIG.ItemViewModelPath))
            {
                Directory.CreateDirectory(FrameworkEditorUtils.FRAMEWORK_CONFIG.ItemViewModelPath);
            }
        }

        private class ViewDto
        {
            public string Name;
            public string ViewName;
            public string ModelName;
            public string BaseName;
            public string PrefabPath;

            public string ViewCode;

            public string ViewFilePath;
            public string ViewIncludePath;

            public string ModelCode;
            public string ModelFilePath;
            public string ModelIncludePath;

            public List<string> Components;

            public ViewDto()
            {
                Components = new List<string>();
            }
        }
    }
}

//internal static class PanelEditor
//{
//    /// <summary>
//    /// Resources读取路径
//    /// </summary>
//    internal static string _panelUIResPath = null;
//    /// <summary>
//    /// UI在Asset的路径
//    /// </summary>
//    internal static string _panelUIPath = null;
//    /// <summary>
//    /// 代码所在路径
//    /// </summary>
//    internal static string _panelCodePath = null;

//    internal static IniTool _iniTool = null;

//    //internal static FieldInfo _injectModelField = null;

//    [MenuItem("TSFrame/UI/生成Panel #P", false, 0)]
//    internal static void GeneratePanel()
//    {
//        try
//        {
//            if (!UIEditorUtils.CheckUIConfig())
//            {
//                EditorUtility.DisplayDialog("错误", "配置表路径没有配置，请配置与Asset同级的config文件", "OK");
//                return;
//            }
//            InitData();

//            if (!Directory.Exists(_panelCodePath))
//            {
//                Directory.CreateDirectory(_panelCodePath);
//            }
//            EditorUtility.DisplayProgressBar("生成Panel", "正在生成Panel", 0);
//            UIEditorUtils.ErrorList = new List<string>();
//            Thread.Sleep(200);
//            string[] strs = Directory.GetFiles(Path.Combine(Application.dataPath, _panelUIPath), "*.prefab");
//            float length = strs.Length;
//            float index = 0;
//            foreach (var item in strs)
//            {
//                index++;
//                //_injectModelField = null;
//                EditorUtility.DisplayProgressBar("生成Panel", $"正在生成{Path.GetFileNameWithoutExtension(item)}", index / length);
//                GameObject obj = AssetDatabase.LoadAssetAtPath<GameObject>(Path.Combine("Assets", _panelUIPath, Path.GetFileName(item)));
//                List<TranDto> trans = new List<TranDto>();
//                UIEditorUtils.GetTrans(obj.transform, "", trans);
//                trans.Reverse();
//                GenerateUserCode(obj.name);
//                GenerateCode(obj.name + ".gen.cs", PanelTemplate, trans, _panelCodePath, Path.Combine(_panelUIResPath, Path.GetFileNameWithoutExtension(item)));
//                Thread.Sleep(200);
//            }
//            EditorUtility.DisplayProgressBar("生成Panel", "生成Panel完成", 1);
//            Thread.Sleep(200);
//            EditorUtility.ClearProgressBar();
//            if (UIEditorUtils.ErrorList.Count > 0)
//            {
//                foreach (var item in UIEditorUtils.ErrorList)
//                {
//                    EditorUtility.DisplayDialog("警告", item, "OK");
//                }
//            }
//            AssetDatabase.Refresh();
//        }
//        catch (Exception ex)
//        {
//            Debug.LogError(ex);
//        }
//        finally
//        {
//            if (_iniTool != null)
//            {
//                _iniTool.Close();
//            }
//            _iniTool = null;
//            //_injectModelField = null;
//            EditorUtility.ClearProgressBar();
//        }
//    }

//    private static void GenerateUserCode(string name)
//    {
//        string panelPath = _iniTool.ReadValue("UIScript", "PanelScriptPath", "");
//        string panelModelPath = _iniTool.ReadValue("UIScript", "PanelDataModelPath", "");
//        string modelName = "";
//        if (!string.IsNullOrWhiteSpace(panelModelPath))
//        {
//            modelName = name + "Data";
//            panelModelPath = Path.Combine(Application.dataPath, panelModelPath, modelName + ".cs");
//            if (!File.Exists(panelModelPath))
//            {
//                string temp = ModelTemplate;
//                temp = temp.Replace("{ClassName}", modelName);
//                File.WriteAllText(panelModelPath, temp, new UTF8Encoding());
//            }
//        }
//        if (!string.IsNullOrWhiteSpace(panelPath))
//        {
//            panelPath = Path.Combine(Application.dataPath, panelPath, name + ".cs");
//            if (!File.Exists(panelPath))
//            {
//                if (string.IsNullOrWhiteSpace(modelName))
//                {
//                    modelName = "NullModel";
//                }
//                string modelFieldName = modelName;
//                string tempChar = modelFieldName[0].ToString();
//                tempChar = tempChar.ToLower();
//                modelFieldName = modelFieldName.Remove(0, 1);
//                modelFieldName = modelFieldName.Insert(0, tempChar);
//                string temp = UITemplate;
//                temp = temp.Replace("{ClassName}", name);
//                temp = temp.Replace("{ModelClass}", modelName);
//                temp = temp.Replace("{ModelClassName}", modelFieldName);
//                File.WriteAllText(panelPath, temp, new UTF8Encoding());
//            }
//        }
//    }

//    private static void GenerateCode(string scriptName, string templateText, List<TranDto> trans, string panelCodePath, string uiPath)
//    {
//        uiPath = uiPath.Replace(@"\", "/");
//        string temp = templateText;
//        string varCode = UIEditorUtils.GetVarCode(trans, _iniTool);
//        string componentCode = UIEditorUtils.GetComponentCode(trans, _iniTool);
//        FieldInfo injectField = null;
//        string injectData = UIEditorUtils.GetInjectModelField(UIEditorUtils.GetTypeForPanel(Path.GetFileName(uiPath)), ref injectField);
//        string bindingData = UIEditorUtils.GetBindingData(UIEditorUtils.GetTypeForPanel(Path.GetFileName(uiPath)), injectField);

//        temp = temp.Replace("{GeneratedTime}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
//        temp = temp.Replace("{UIPath}", uiPath);
//        temp = temp.Replace("{ClassName}", Path.GetFileName(uiPath));
//        temp = temp.Replace("{InjectData}", injectData);
//        temp = temp.Replace("{BindData}", bindingData);
//        temp = temp.Replace("{Variable}", varCode);
//        temp = temp.Replace("{BindComponent}", componentCode);

//        File.WriteAllText(Path.Combine(panelCodePath, scriptName), temp, new UTF8Encoding());
//    }

//    private static void InitData()
//    {
//        _iniTool = new IniTool();
//        _iniTool.Open(UIEditorUtils._configFilePath);
//        _panelUIPath = _iniTool.ReadValue("UI", "PanelPath", "");
//        _panelCodePath = _iniTool.ReadValue("UIScript", "PanelGeneratedScriptPath", "");
//        _panelCodePath = Path.Combine(Application.dataPath, _panelCodePath);
//        int index = _panelUIPath.IndexOf("Resources");
//        _panelUIResPath = _panelUIPath.Substring(index + UIEditorUtils.RESOURCES_LENGTH, _panelUIPath.Length - index - UIEditorUtils.RESOURCES_LENGTH);
//    }
//}

