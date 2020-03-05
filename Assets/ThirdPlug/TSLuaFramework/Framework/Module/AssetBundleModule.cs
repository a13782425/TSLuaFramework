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
            if (_waitParseABPaths != null)
            {
                if (_waitParseABPaths.Count > 0)
                {
                    string abPath = _waitParseABPaths.Dequeue();
                    if (abPath != null)
                    {
                        string catalogContent = FileTool.ReadFile(CATALOG_FILE_NAME, abPath);
                        AssetBundleDto assetBundleDto = JsonConvert.DeserializeObject<AssetBundleDto>(catalogContent);
                        assetBundleDto.AssetBundlePath = abPath;
                        _alreadyParseABList.Add(assetBundleDto);
                    }
                }
            }
            if (_handles != null)
            {
                if (_handles.Count > 0)
                {
                    var handle = _handles.Dequeue();
                    if (handle != null)
                    {
                        handle.Run();
                    }
                }
            }
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
                item.UnloadAssetBundleByName(bundleName);
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
            _waitParseABPaths.Enqueue(abPath);
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
        /// 根据资源名字加载资源
        /// </summary>
        /// <param name="assetName"></param>
        /// <returns></returns>
        public void LoadAsset(string assetName, Action<Object> callBack)
        {
            LoadAssetByBundleName(null, assetName, callBack);
        }

        /// <summary>
        /// 根据ab名字和资源名字
        /// </summary>
        /// <param name="bundleName"></param>
        /// <param name="assetName"></param>
        /// <returns></returns>
        public void LoadAssetByBundleName(string bundleName, string assetName, Action<Object> callBack)
        {
            AsyncOperationHandle asyncOperation = new AsyncOperationHandle(_counter, bundleName, assetName);
            if (_counter == int.MaxValue)
            {
                _counter = int.MinValue;
            }
            _counter++;
            asyncOperation.Completed += AsyncOperation_Completed;
            asyncOperation.Completed += callBack;
            _handles.Enqueue(asyncOperation);
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
        internal async Task<Object> GetAsset(string bundlePath, string assetName)
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
            Object obj = null;
            if (_alreadyParseABList.Count == 0)
            {
                Log.LogWarning("没有设置任何AssetBundle的路径");
            }
            foreach (var item in _alreadyParseABList)
            {
                obj = await item.GetAsset(bundlePath, assetName);
                if (obj != null)
                {
                    break;
                }
            }
            return obj;
        }

        private class AsyncOperationHandle : IEquatable<AsyncOperationHandle>
        {
            public Object Result { get; internal set; }
            public string BundleName { get; private set; }
            public string AssetName { get; private set; }

            public event Action<Object> Completed;

            internal int Version { get; private set; }
            public bool Equals(AsyncOperationHandle other)
            {
                return Version == other.Version;
            }

            internal async void Run()
            {
                //Task = Task<Object>.Factory.StartNew(LoadObject);
                Object obj = null;
                obj = await AssetBundleModule.Instance.GetAsset(BundleName, AssetName);

                Result = obj;
                await new WaitForUnityThread();
                if (Completed != null)
                {
                    Completed.Invoke(Result);
                }
            }

            internal AsyncOperationHandle(int version, string bundleName, string assetName)
            {
                Version = version;
                Result = default(Object);
                BundleName = bundleName;
                AssetName = assetName;
                Completed = null;
            }
        }
    }
}
