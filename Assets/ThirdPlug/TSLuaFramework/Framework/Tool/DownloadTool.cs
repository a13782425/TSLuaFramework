using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;

namespace TSLuaFramework.Tool
{
    public sealed class DownloadTool
    {

        private const string URL = "http://resource.timeslip.cn/MUD/Mod/Default/MD5.txt";

        private DownloadTool _instance = null;

        public DownloadTool Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DownloadTool();
                }
                return _instance;
            }
        }

        //resource.timeslip.cn/MUD/Mod/Default/
        public static event Action<double, double> OnDownloadProgressEvent;
        //下载完成事件
        public static event Action<string> OnDownloadCompleteEvent;

        private DownloadTool() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="url">网络路径</param>
        /// <param name="targetPath">下载到哪里</param>
        /// <returns></returns>
        public static IEnumerator DownLoad(string url, string targetPath)
        {
            if (!File.Exists(targetPath))
            {
                UnityWebRequest request = UnityWebRequest.Get(url);
                yield return request.SendWebRequest();
                if (request.isDone)
                {
                    int packLength = 1024 * 20;
                    byte[] data = request.downloadHandler.data;
                    int nReadSize = 0;
                    byte[] nbytes = new byte[packLength];
                    using (FileStream fs = new FileStream(targetPath, FileMode.Create))
                    {
                        using (Stream netStream = new MemoryStream(data))
                        {
                            nReadSize = netStream.Read(nbytes, 0, packLength);
                            while (nReadSize > 0)
                            {
                                fs.Write(nbytes, 0, nReadSize);
                                nReadSize = netStream.Read(nbytes, 0, packLength);
                                double dDownloadedLength = fs.Length * 1.0 / (1024 * 1024);
                                double dTotalLength = data.Length * 1.0 / (1024 * 1024);
                                string ss = string.Format("已下载 {0:F}M / {1:F}M", dDownloadedLength, dTotalLength);
                                if (OnDownloadProgressEvent != null)
                                {
                                    OnDownloadProgressEvent.Invoke(dDownloadedLength, dTotalLength);
                                }
                                Debug.Log(ss);
                                yield return null;
                            }

                        }
                    }
                }

            }
            if (OnDownloadCompleteEvent != null)
            {
                Debug.Log("download  finished");
                OnDownloadCompleteEvent.Invoke(targetPath);
            }
        }
    }
}
