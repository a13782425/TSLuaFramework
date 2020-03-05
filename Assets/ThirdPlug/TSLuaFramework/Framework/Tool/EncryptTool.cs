using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace TSLuaFramework.Tool
{
    public sealed class EncryptTool
    {

        private static string strkeyValue = "abcdefghijklmnopqrstuvwxyzzyxwvu";

        private static string _archivedEncryptKey;

        private static string _defaultMd5;

        private static EncryptTool _instance;
        public static EncryptTool Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EncryptTool();
                }
                return _instance;
            }
        }
        private EncryptTool() { }

        public static string ArchivedEncryptKey
        {
            get
            {
                if (string.IsNullOrEmpty(_archivedEncryptKey))
                {
                    //_archivedEncryptKey = PlatformModule.Instance.CurrentPlatform.Id;
                }
                return _archivedEncryptKey;
            }
        }

        public static string DefaultMD5
        {
            get
            {
                if (string.IsNullOrEmpty(_defaultMd5))
                {
                    _defaultMd5 = Instance.MD5Encrypt(ArchivedEncryptKey);
                }
                return _defaultMd5;
            }
        }

        public string Encryption(string inputText, string encryptKey = null)
        {
            return encryptionContent(inputText, checkEncryptKey(encryptKey));
        }

        public string Decipher(string inputText, string encryptKey = null)
        {
            return decipheringContent(inputText, checkEncryptKey(encryptKey));
        }

        private string checkEncryptKey(string encryptKey)
        {
            string text = (!string.IsNullOrEmpty(encryptKey)) ? encryptKey : ArchivedEncryptKey;
            while (text.Length < strkeyValue.Length)
            {
                text += text;
            }
            return text.Substring(0, strkeyValue.Length);
        }

        private string encryptionContent(string ContentInfo, string strkey)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(strkey);
            byte[] array;
            using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
            {
                rijndaelManaged.Key = bytes;
                rijndaelManaged.Mode = CipherMode.ECB;
                rijndaelManaged.Padding = PaddingMode.PKCS7;
                ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor();
                byte[] bytes2 = Encoding.UTF8.GetBytes(ContentInfo);
                array = cryptoTransform.TransformFinalBlock(bytes2, 0, bytes2.Length);
            }
            return Convert.ToBase64String(array, 0, array.Length);
        }

        private string decipheringContent(string encryptionContent, string strkey)
        {
            try
            {
                byte[] bytes = Encoding.UTF8.GetBytes(strkey);
                byte[] bytes2;
                using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
                {
                    rijndaelManaged.Key = bytes;
                    rijndaelManaged.Mode = CipherMode.ECB;
                    rijndaelManaged.Padding = PaddingMode.PKCS7;
                    ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
                    byte[] array = Convert.FromBase64String(encryptionContent);
                    bytes2 = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
                }
                return Encoding.UTF8.GetString(bytes2);
            }
            catch (Exception ex)
            {
                Debug.LogError(ex.Message);
                return null;
            }
        }

        public string MD5EncryptFile(string filePath, MD5EncryptEnum encryptEnum = MD5EncryptEnum.Default)
        {
            using (FileStream stream = File.Open(filePath, FileMode.Open))
            {
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                byte[] b = md5.ComputeHash(stream);
                md5.Clear();
                return MD5Encrypt(b, encryptEnum);
            }
        }

        public string MD5Encrypt(string strSource, MD5EncryptEnum encryptEnum = MD5EncryptEnum.Default)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(strSource);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] arrays = md5.ComputeHash(bytes);
            md5.Clear();
            return MD5Encrypt(arrays, encryptEnum);
        }

        private string MD5Encrypt(byte[] bytes, MD5EncryptEnum encryptEnum)
        {

            StringBuilder stringBuilder = new StringBuilder();
            switch (encryptEnum)
            {
                case MD5EncryptEnum.Short:
                    for (int j = 4; j < 12; j++)
                    {
                        stringBuilder.Append(bytes[j].ToString("x2"));
                    }
                    break;
                case MD5EncryptEnum.Long:
                    for (int k = 0; k < 16; k++)
                    {
                        stringBuilder.Append(bytes[k].ToString("x2"));
                    }
                    break;
                default:
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        stringBuilder.Append(bytes[i].ToString("x2"));
                    }
                    break;
            }
            return stringBuilder.ToString();
        }

    }

    /// <summary>
    /// MD5加密模式
    /// </summary>
    public enum MD5EncryptEnum
    {
        /// <summary>
        /// 16位
        /// </summary>
        Short,
        /// <summary>
        /// 32位
        /// </summary>
        Long,
        /// <summary>
        /// c#默认
        /// </summary>
        Default
    }
}
