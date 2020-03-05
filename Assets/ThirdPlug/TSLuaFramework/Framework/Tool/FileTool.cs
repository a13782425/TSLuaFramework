using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace TSLuaFramework.Tool
{
    public static class FileTool
    {
        private static Encoding _encoding = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false);

        public static void DeleteDir(string url = "", bool recursive = false)
        {
            if (string.IsNullOrEmpty(url))
            {
                Debug.LogError("Url is error！");
            }
            else if (Directory.Exists(url))
            {
                Directory.Delete(url, recursive);
            }
        }

        public static bool CreateDir(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                Debug.LogError("Url is error！");
                return false;
            }
            if (Directory.Exists(url))
            {
                return true;
            }
            try
            {
                Directory.CreateDirectory(url);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// 判断文件是否存在,URL为空时为Application.persistentDataPath根目录
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        public static bool FileExist(string fileName, string url = "")
        {
            string str = (!(url == string.Empty)) ? url : Application.persistentDataPath;
            return File.Exists(str + "//" + fileName);
        }
        /// <summary>
        /// 删除文件,URL为空时为Application.persistentDataPath根目录
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="url"></param>
        public static void DeleteFile(string fileName, string url = "")
        {
            string str = (!(url == string.Empty)) ? url : Application.persistentDataPath;
            if (FileExist(fileName, url))
            {
                File.Delete(str + "//" + fileName);
            }
        }

        /// <summary>
        /// 读取文件,URL为空时为Application.persistentDataPath根目录
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        public static string ReadFile(string fileName, string url = "")
        {
            if (FileExist(fileName, url))
            {
                string str = (!(url == string.Empty)) ? url : Application.persistentDataPath;
                FileStream fileStream = File.OpenRead(str + "//" + fileName);
                BinaryReader binaryReader = new BinaryReader(fileStream);
                byte[] array = new byte[fileStream.Length];
                binaryReader.Read(array, 0, (int)fileStream.Length);
                string @string = _encoding.GetString(array, 0, array.Length);
                binaryReader.Close();
                fileStream.Dispose();
                fileStream.Close();
                return @string;
            }
            return string.Empty;
        }
        /// <summary>
        /// 读取文件,URL为空时为Application.persistentDataPath根目录
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        public static byte[] ReadFileByByte(string fileName, string url = "")
        {
            if (FileExist(fileName, url))
            {
                string str = (!(url == string.Empty)) ? url : Application.persistentDataPath;
                FileStream fileStream = File.OpenRead(str + "//" + fileName);
                BinaryReader binaryReader = new BinaryReader(fileStream);
                byte[] array = new byte[fileStream.Length];
                binaryReader.Read(array, 0, (int)fileStream.Length);
                binaryReader.Close();
                fileStream.Dispose();
                fileStream.Close();
                return array;
            }
            return new byte[0];
        }

        /// <summary>
        /// 写文件,URL为空时为Application.persistentDataPath根目录
        /// </summary>
        /// <param name="content"></param>
        /// <param name="fileName"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        public static bool WriteFile(string content, string fileName, string url = "")
        {
            if (!FileExist(fileName, url))
            {
                CreateFile(fileName, url);
            }
            string str = (!(url == string.Empty)) ? url : Application.persistentDataPath;
            StreamWriter streamWriter = new StreamWriter(str + "//" + fileName, append: false, _encoding);
            streamWriter.Write(content);
            streamWriter.Dispose();
            streamWriter.Close();
            return true;
        }

        /// <summary>
        /// 创建文件
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        public static bool CreateFile(string fileName, string url = "")
        {
            string text = (!(url == string.Empty)) ? url : Application.persistentDataPath;
            CreateDir(text);
            Debug.LogError("mainPath=" + text);
            Debug.LogError("fileName=" + fileName);
            FileStream fileStream = File.Create(text + "//" + fileName);
            fileStream.Dispose();
            fileStream.Close();
            return true;
        }
    }
}
