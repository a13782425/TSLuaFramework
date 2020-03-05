using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TSLuaFramework.Tool;
using TSLuaFramework.Model;
using UnityEditor;
using UnityEngine;

internal static class PackResourceEditor
{
    private const string PACK_LUA_PATH = "Pack";

    [MenuItem("TSFrame/资源/打包Lua", false, 0)]
    private static void PackLuaCore()
    {
        var dirPath = EditorUtility.OpenFolderPanel("选择文件夹", string.Empty, string.Empty);
        List<string> files = new List<string>();
        GetFiles(dirPath, ref files);
        files.RemoveAll(a => Path.GetExtension(a) == ".meta");
        Md5Dto md5Dto = new Md5Dto();

        foreach (var item in files)
        {
            md5Dto.FileCount++;
            Md5Dto.Md5InfoDto md5InfoDto = new Md5Dto.Md5InfoDto();
            md5InfoDto.FileName = Path.GetFileNameWithoutExtension(item);
            md5InfoDto.FileName = Path.GetFileNameWithoutExtension(md5InfoDto.FileName);
            FileInfo fileInfo = new FileInfo(item);
            md5InfoDto.Md5 = EncryptTool.Instance.MD5EncryptFile(item);
            md5InfoDto.FileSize = fileInfo.Length;
            md5Dto.FileAllSize += md5InfoDto.FileSize;
            md5InfoDto.Path = Path.GetDirectoryName(item.Remove(0, dirPath.Length + 1));
            md5Dto.Md5InfoDtoList.Add(md5InfoDto);
        }
        string str = Newtonsoft.Json.JsonConvert.SerializeObject(md5Dto);
        File.WriteAllText(dirPath + "/MD5", str, new UTF8Encoding());
        EditorUtility.DisplayDialog("Successful", "打包成功succeed", "确定");
    }


    private static void GetFiles(string path, ref List<string> files)
    {
        string[] paths = Directory.GetDirectories(path);
        foreach (var item in paths)
        {
            GetFiles(item, ref files);
        }
        files.AddRange(Directory.GetFiles(path));
    }
}
