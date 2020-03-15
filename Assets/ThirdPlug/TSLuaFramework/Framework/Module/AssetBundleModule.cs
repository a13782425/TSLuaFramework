using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TSLuaFramework.Model;
using TSLuaFramework.Tool;
using UnityEngine;
using Object = UnityEngine.Object;

namespace TSLuaFramework.Module
{
    public sealed class AssetBundleModule : BaseModule<AssetBundleModule>
    {
        private const string CATALOG_FILE_NAME = "catalog";

        /// <summary>
        /// 等待解析的目录
        /// </summary>
        private Queue<string> _waitParseABPaths = null;

        /// <summary>
        /// 解析完毕的ab包
        /// </summary>
        private List<AssetBundleDto> _alreadyParseABList;

        /// <summary>
        /// 加载计数器
        /// </summary>
        private int _counter = int.MinValue;

        /// <summary>
        /// 等待加载的资源
        /// </summary>
        private Queue<AsyncOperationHandle> _handles;

        /// <summary>
        /// 自动卸载时间
        /// -1为不卸载
        /// </summary>
        private int _unloadSecond = -1;

        private float _unloadCheckTime = 0;

        public override void Init()
        {
            _waitParseABPaths = new Queue<string>();
            _alreadyParseABList = new List<AssetBundleDto>();
            _handles = new Queue<AsyncOperationHandle>();
        }

        public override void Update(float deltaTime)
        {
            if (_unloadSecond > 0 && _unloadCheckTime > 1)
            {
                //自动检测回收资源
                foreach (var item in _alreadyParseABList)
                {
                    item.CheckAssetBundleUseTime(_unloadSecond);
                }
                _unloadCheckTime = 0;
            }
            _unloadCheckTime += deltaTime;
        }

        public override void Freed()
        {
            foreach (var item in _alreadyParseABList)
            {
                item.UnLoadAllAB(true);
            }
        }
        /// <summary>
        /// 卸载一个ab包
        /// </summary>
        /// <param name="bundleName"></param>
        public void UnloadAssetBundleByName(string bundleName)
        {
            foreach (var item in _alreadyParseABList)
            {
                item.UnloadAssetBundle(bundleName);
            }
        }

        /// <summary>
        /// 设置资源信息
        /// </summary>
        /// <param name="abPath">路径地址</param>
        /// <param name="catalogFile">目录文件</param>
        /// <returns></returns>
        public AssetBundleModule SetAssetBundleInfo(string abPath)
        {
            if (string.IsNullOrWhiteSpace(abPath))
            {
                throw new Exception("资源路径或者资源目录为空");
            }
            if (_alreadyParseABList.FirstOrDefault(a => a.AssetBundlePath == abPath) != null)
            {
                GameApp.Instance.LogWarning($"{abPath}路径下的ab包被重复加载");
                return this;
            }
            if (abPath != null)
            {
                string catalogContent = FileTool.ReadFile(CATALOG_FILE_NAME, abPath);
                AssetBundleDto assetBundleDto = JsonConvert.DeserializeObject<AssetBundleDto>(catalogContent);
                assetBundleDto.AssetBundlePath = abPath;
                _alreadyParseABList.Add(assetBundleDto);
            }
            return this;
        }
        /// <summary>
        /// 删除一个ab路径
        /// </summary>
        /// <param name="abPath"></param>
        /// <param name="unloadAllObjects">true:删除该路径ab包加载的所有资源,false:仅删除ab包,不删除已加载的资源</param>
        public AssetBundleModule RemoveAssetBundleInfo(string abPath, bool unloadAllObjects)
        {
            var assetBundleDto = _alreadyParseABList.FirstOrDefault(a => a.AssetBundlePath == abPath);
            _alreadyParseABList.Remove(assetBundleDto);
            assetBundleDto.UnLoadAllAB(unloadAllObjects);
            assetBundleDto = null;
            return this;
        }

        /// <summary>
        /// 自动卸载资源
        /// 自动卸载时会将已创建的资源也删除
        /// <para name="second">-1为不卸载</para>
        /// </summary>
        public void AutoUnload(int second)
        {
            _unloadSecond = second;
            _unloadCheckTime = 0;
        }

        /// <summary>
        /// 卸载全部包
        /// </summary>
        public void UnloadAll()
        {
            foreach (var item in _alreadyParseABList)
            {
                item.UnLoadAllAB(true);
            }
        }


        /// <summary>
        /// 根据资源名字同步加载资源
        /// </summary>
        /// <param name="assetName"></param>
        /// <returns></returns>
        public Object LoadAsset(string assetName)
        {
            return LoadAsset(null, assetName);
        }

        /// <summary>
        /// 根据ab名字和资源名字同步加载
        /// </summary>
        /// <param name="bundleName"></param>
        /// <param name="assetName"></param>
        /// <returns></returns>
        public Object LoadAsset(string bundleName, string assetName)
        {
            return GetAsset(bundleName, assetName);
        }

        /// <summary>
        /// 根据资源名字异步加载资源
        /// </summary>
        /// <param name="assetName"></param>
        /// <returns></returns>
        public void LoadAssetAsync(string assetName, Action<Object> callBack)
        {
            LoadAssetAsync(null, assetName, callBack);
        }

        /// <summary>
        /// 根据ab名字和资源名字异步加载
        /// </summary>
        /// <param name="bundleName"></param>
        /// <param name="assetName"></param>
        /// <returns></returns>
        public void LoadAssetAsync(string bundleName, string assetName, Action<Object> callBack)
        {
            AsyncOperationHandle asyncOperationHandle = new AsyncOperationHandle(bundleName, assetName);
            asyncOperationHandle.Completed += AsyncOperation_Completed;
            asyncOperationHandle.Completed += callBack;
            StartCoroutine(GetAssetAsync(bundleName, assetName, asyncOperationHandle));
        }



        /// <summary>
        /// 加载完成回调
        /// </summary>
        /// <param name="obj"></param>
        private void AsyncOperation_Completed(Object obj)
        {

        }

        /// <summary>
        /// 获取一个资源
        /// </summary>
        /// <param name="bundlePath"></param>
        /// <param name="assetName"></param>
        /// <returns></returns>
        internal Object GetAsset(string bundlePath, string assetName)
        {
            if (string.IsNullOrWhiteSpace(assetName))
            {
                Debug.LogError("资源名为空!");
                return null;
            }
            if (string.IsNullOrWhiteSpace(bundlePath))
            {
                bundlePath = "";
            }
            bundlePath = bundlePath.ToLower();
            assetName = assetName.ToLower();
            if (_alreadyParseABList.Count == 0)
            {
                Log.LogWarning("没有设置任何AssetBundle的路径");
            }
            Object obj = null;
            foreach (var item in _alreadyParseABList)
            {
                obj = item.GetAsset(bundlePath, assetName);
                if (obj != null)
                {
                    break;
                }
            }
            return obj;
        }

        /// <summary>
        /// 获取一个资源
        /// </summary>
        /// <param name="bundlePath"></param>
        /// <param name="assetName"></param>
        /// <returns></returns>
        internal IEnumerator GetAssetAsync(string bundlePath, string assetName, AsyncOperationHandle handle)
        {
            if (string.IsNullOrWhiteSpace(assetName))
            {
                Debug.LogError("资源名为空!");
                yield break;
            }
            if (string.IsNullOrWhiteSpace(bundlePath))
            {
                bundlePath = "";
            }
            bundlePath = bundlePath.ToLower();
            assetName = assetName.ToLower();
            if (_alreadyParseABList.Count == 0)
            {
                Log.LogWarning("没有设置任何AssetBundle的路径");
            }
            foreach (var item in _alreadyParseABList)
            {
                yield return StartCoroutine(item.GetAssetAsync(bundlePath, assetName, handle));
                if (handle.Result != null)
                {
                    break;
                }
            }
            handle.Invoke();
        }

        internal class AsyncOperationHandle
        {
            public string BundleName { get; private set; }
            public string AssetName { get; private set; }
            public Object Result;

            public event Action<Object> Completed;
            internal AsyncOperationHandle(string bundleName, string assetName)
            {
                BundleName = bundleName;
                AssetName = assetName;
                Completed = null;
                Result = null;

            }

            internal void Invoke()
            {
                if (Completed != null && Result != null)
                {
                    Completed.Invoke(Result);
                }
            }
        }
    }
}
