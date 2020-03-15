using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSLuaFramework.Module;
using TSLuaFramework.Tool;
using UnityEngine;

namespace TSLuaFramework
{
    internal static class GameSetting
    {
        private static ILogger _log = LogModule.Instance.GetLogger("GameSetting");

        /// <summary>
        /// 获取核心Lua的路径
        /// </summary>
        /// <returns></returns>
        public static string GetLuaLibraryPath()
        {
#if UNITY_EDITOR
            return $"{Application.dataPath}/../EditorData/LuaLibrary";
#else
            return $"{Application.persistentDataPath}/LuaLibrary";
#endif
        }

        /// <summary>
        /// 获取游戏路径
        /// </summary>
        /// <param name="subGameDto"></param>
        /// <returns></returns>
        public static string GetGamePath()
        {
#if UNITY_EDITOR
            return $"{Application.dataPath}/../EditorData/Game";
#else
            return $"{Application.persistentDataPath}/Game";
#endif
        }

        /// <summary>
        /// 获取游戏Lua路径
        /// </summary>
        /// <param name="subGameDto"></param>
        /// <returns></returns>
        public static string GetLuaScriptPath()
        {
#if UNITY_EDITOR
            return $"{Application.dataPath}/../EditorData/Game/LuaScript";
#else
            return $"{Application.persistentDataPath}/Game/LuaScript";
#endif
        }

        /// <summary>
        /// 获取游戏数据路径
        /// </summary>
        /// <param name="subGameDto"></param>
        /// <returns></returns>
        public static string GetGameDataPath()
        {
#if UNITY_EDITOR
            return $"{Application.dataPath}/../EditorData/Game/GameData";
#else
            return $"{Application.persistentDataPath}/Game/GameData";
#endif
        }
        /// <summary>
        /// 获取游戏数据路径
        /// </summary>
        /// <param name="subGameDto"></param>
        /// <returns></returns>
        public static string GetGameAssetBundlePath()
        {
#if UNITY_EDITOR
            return $"{Application.dataPath}/../EditorData/Game/AssetBundle";
#else
            return $"{Application.persistentDataPath}/Game/AssetBundle";
#endif
        }


        /// <summary>
        /// 自定义Lua加载器
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns></returns>
        public static byte[] CustomLoader(ref string filepath)
        {
#if UNITY_EDITOR
            //Debug.LogError(filepath);
            string file = filepath.Replace('.', '/');
            int flag = 0;
            if (FileTool.FileExist($"{file}.lua.txt", GameSetting.GetLuaLibraryPath()))
                return FileTool.ReadFileByByte($"{file}.lua.txt", GameSetting.GetLuaLibraryPath());
            else
                flag = -1;

            if (FileTool.FileExist($"{file}.lua.txt", GameSetting.GetLuaScriptPath()))
                return FileTool.ReadFileByByte($"{file}.lua.txt", GameSetting.GetLuaScriptPath());
            else
                flag = 1;

            if (flag == -1)
                _log.LogError($"filepath = {filepath},从库目录没有找到文件:{file},库路径为:{GameSetting.GetLuaLibraryPath()}/{file}.lua.txt");
            else if (flag == 1)
                _log.LogError($"filepath = {filepath},从游戏目录没有找到文件:{file},游戏路径为:{GameSetting.GetLuaScriptPath()}/{file}.lua.txt");
            return new byte[0];
#endif
            return new byte[0];
        }
    }
}
