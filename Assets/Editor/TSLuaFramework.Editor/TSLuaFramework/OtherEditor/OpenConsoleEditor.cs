using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace TSLuaFramework.Editor
{
    static class OpenConsoleEditor
    {
        private static string LuaLibraryPath = $"{Application.dataPath}/../EditorData/LuaLibrary";
        private static string LuaScriptPath = $"{Application.dataPath}/../EditorData/Game/LuaScript";
        private static string LuaExtension = ".lua.txt";
        const string logColor = "yellow";
        const string errorColor = "red";
        const string warningColor = "yellow";
        [Conditional("LOG")]
        public static void Log(string msg)
        {
            UnityEngine.Debug.Log(GetColor(msg, logColor));
        }
        static string GetColor(string msg, string color)
        {
            return $"<color={color}>{msg}</color>";
        }
        [OnOpenAsset(0)]
        public static bool OnOpenAsset(int instanceID, int line)
        {
            string stack_trace = GetStackTrace();

            if (!string.IsNullOrWhiteSpace(stack_trace) && (stack_trace.StartsWith("[Lua]") || stack_trace.StartsWith("LuaException")))
            {

                string[] strs = stack_trace.Split(new char[] { '\r', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                string text = "";
                bool begin = false;
                string[] temp = null;
                for (int i = 0; i < strs.Length; i++)
                {
                    if (strs[i].Trim() == "stack traceback:")
                    {
                        begin = true;
                    }
                    else if (begin)
                    {
                        text = strs[i].Trim();
                        temp = text.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                        if (temp.Length >= 3)
                        {
                            break;
                        }
                        temp = null;
                    }
                }
                if (temp != null)
                {
                    //strs = text.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                    string fileName = temp[0].Replace(".", "/") + LuaExtension;
                    string lineNum = temp[1];
                    if (File.Exists(LuaScriptPath + "/" + fileName))
                    {
                        return OpenFile(LuaScriptPath + "/" + fileName, lineNum);
                    }
                    if (File.Exists(LuaLibraryPath + "/" + fileName))
                    {
                        return OpenFile(LuaLibraryPath + "/" + fileName, lineNum);
                    }
                }
                return false;
            }
            else
            {
                return false;
            }
        }
        static bool OpenFile(string fileName, string line)
        {
            try
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.UseShellExecute = false;    //是否使用操作系统shell启动
                startInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
                startInfo.RedirectStandardOutput = true;//由调用程序获取输出信息
                startInfo.RedirectStandardError = true;//重定向标准错误输出
                startInfo.CreateNoWindow = true;
                //startInfo.Arguments = strFileName;
                process.StartInfo = startInfo;
                process.Start();
                process.StandardInput.WriteLine($"code -g {fileName}:{line} &exit");
                process.WaitForExit();
                process.Close();
                return true;
            }
            catch (Exception ex)
            {
                Debug.LogError(ex.Message);
                return false;
            }
        }
        static string GetStackTrace()
        {
            // 找到UnityEditor.EditorWindow的assembly
            var assembly_unity_editor = Assembly.GetAssembly(typeof(UnityEditor.EditorWindow));
            if (assembly_unity_editor == null) return null;

            // 找到类UnityEditor.ConsoleWindow
            var type_console_window = assembly_unity_editor.GetType("UnityEditor.ConsoleWindow");
            if (type_console_window == null) return null;
            // 找到UnityEditor.ConsoleWindow中的成员ms_ConsoleWindow
            var field_console_window = type_console_window.GetField("ms_ConsoleWindow", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic);
            if (field_console_window == null) return null;
            // 获取ms_ConsoleWindow的值
            var instance_console_window = field_console_window.GetValue(null);
            if (instance_console_window == null) return null;

            // 如果console窗口时焦点窗口的话，获取stacktrace
            if ((object)UnityEditor.EditorWindow.focusedWindow == instance_console_window)
            {
                // 通过assembly获取类ListViewState
                var type_list_view_state = assembly_unity_editor.GetType("UnityEditor.ListViewState");
                if (type_list_view_state == null) return null;

                // 找到类UnityEditor.ConsoleWindow中的成员m_ListView
                var field_list_view = type_console_window.GetField("m_ListView", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                if (field_list_view == null) return null;

                // 获取m_ListView的值
                var value_list_view = field_list_view.GetValue(instance_console_window);
                if (value_list_view == null) return null;

                // 下面是stacktrace中一些可能有用的数据、函数和使用方法，这里就不一一说明了，我们这里暂时还用不到
                /*
                var field_row = type_list_view_state.GetField("row”, System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
                if (field_row == null) return null;

                var field_total_rows = type_list_view_state.GetField("totalRows”, System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
                if (field_total_rows == null) return null;

                var type_log_entries = assembly_unity_editor.GetType("UnityEditorInternal.LogEntries”);
                if (type_log_entries == null) return null;

                var method_get_entry = type_log_entries.GetMethod("GetEntryInternal”, BindingFlags.Static | BindingFlags.Public);
                if (method_get_entry == null) return null;

                var type_log_entry = assembly_unity_editor.GetType("UnityEditorInternal.LogEntry”);
                if (type_log_entry == null) return null;

                var field_instance_id = type_log_entry.GetField("instanceID”, BindingFlags.Instance | BindingFlags.Public);
                if (field_instance_id == null) return null;

                var field_line = type_log_entry.GetField("line”, BindingFlags.Instance | BindingFlags.Public);
                if (field_line == null) return null;

                var field_condition = type_log_entry.GetField("condition”, BindingFlags.Instance | BindingFlags.Public);
                if (field_condition == null) return null;

                object instance_log_entry = Activator.CreateInstance(type_log_entry);
                int value_row = (int)field_row.GetValue(value_list_view);
                int value_total_rows = (int)field_total_rows.GetValue(value_list_view);
                int log_by_this_count = 0;
                for (int i = value_total_rows – 1; i > value_row; i–) {
                method_get_entry.Invoke(null, new object[] { i, instance_log_entry });
                string value_condition = field_condition.GetValue(instance_log_entry) as string;
                if (value_condition.Contains("[SDebug]”)) {
                log_by_this_count++;
                }
                }
                    }
                }
                */
                // 找到类UnityEditor.ConsoleWindow中的成员m_ActiveText
                var field_active_text = type_console_window.GetField("m_ActiveText", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                if (field_active_text == null) return null;

                // 获得m_ActiveText的值，就是我们需要的stacktrace
                string value_active_text = field_active_text.GetValue(instance_console_window).ToString();
                return value_active_text;
            }

            return null;
        }
    }
}