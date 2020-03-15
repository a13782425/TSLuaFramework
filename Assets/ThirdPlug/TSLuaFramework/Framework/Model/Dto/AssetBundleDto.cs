using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using static TSLuaFramework.Module.AssetBundleModule;
using Object = UnityEngine.Object;

namespace TSLuaFramework.Model
{
    /// <summary>
    /// ab资源包dto
    /// </summary>
    public sealed class AssetBundleDto
    {
        private const int TRUE = 1;
        private const int FALSE = 0;
        /// <summary>
        /// 当前锁的值
        /// </summary>
        private int _currentLock = 0;
        public AssetBundleDto()
        {
            AssetBundleInfoDtoList = new List<AssetBundleInfoDto>();
            AssetInfoDtoList = new List<AssetInfoDto>();
        }
        public string AssetBundlePath { get; set; }
        public List<AssetBundleInfoDto> AssetBundleInfoDtoList { get; set; }
        public List<AssetInfoDto> AssetInfoDtoList { get; set; }
        /// <summary>
        /// 已经加载的ab包
        /// key:bundleName,value包
        /// </summary>
        private Dictionary<string, AssetBundle> _alreadyLoadDic = new Dictionary<string, AssetBundle>();

        /// <summary>
        /// 卸载该路径包
        /// </summary>
        /// <param name="unloadAllObjects"></param>
        internal void UnLoadAllAB(bool unloadAllObjects)
        {
            Begin: if (Interlocked.CompareExchange(ref _currentLock, TRUE, FALSE) == FALSE)
            {
                foreach (var item in _alreadyLoadDic)
                {
                    item.Value.Unload(unloadAllObjects);
                }
                _alreadyLoadDic.Clear();
                Interlocked.Exchange(ref _currentLock, FALSE);
            }
            else
            {
                Thread.Sleep(100);
                goto Begin;
            }
        }
        private AssetBundleInfoDto GetBundleInfoDto(string bundleName)
        {
            return AssetBundleInfoDtoList.FirstOrDefault(a => a.AssetBundleName == bundleName);
        }
        /// <summary>
        /// 检查各个AB包使用时间
        /// </summary>
        internal void CheckAssetBundleUseTime(int unusedTime)
        {
            DateTime dateTime = DateTime.Now;
            foreach (var item in AssetBundleInfoDtoList)
            {
                int temp = (int)((dateTime - item.LastUseTime).TotalSeconds);
                if (temp > unusedTime)
                {
                    if (_alreadyLoadDic.ContainsKey(item.AssetBundleName))
                    {

                        _alreadyLoadDic[item.AssetBundleName].Unload(true);
                        _alreadyLoadDic.Remove(item.AssetBundleName);
                    }
                }
            }
        }
        /// <summary>
        /// 卸载一个AB包
        /// </summary>
        internal void UnloadAssetBundle(string bundleName)
        {
            if (_alreadyLoadDic.ContainsKey(bundleName))
            {
                _alreadyLoadDic[bundleName].Unload(true);
                _alreadyLoadDic.Remove(bundleName);
            }
        }
        internal Object GetAsset(string assetName)
        {
            return GetAsset(null, assetName);
        }
        internal Object GetAsset(string bundleName, string assetName)
        {
            if (string.IsNullOrWhiteSpace(bundleName))
            {
                var assetInfoDto = AssetInfoDtoList.FirstOrDefault(a => a.AssetName == assetName);
                if (assetInfoDto != null)
                {
                    bundleName = assetInfoDto.AssetBundleName;
                }
                else
                {
                    Debug.LogError($"没有找到资源:{assetName}对应的包名");
                    return null;
                }
            }
            AssetBundleInfoDto bundleInfoDto = GetBundleInfoDto(bundleName);
            if (!_alreadyLoadDic.ContainsKey(bundleName))
            {
                if (bundleInfoDto != null)
                {
                    LoadAssetBundle(bundleInfoDto);
                }
                else
                {
                    Debug.LogError($"没有找到资源:{bundleName}包");
                    return null;
                }
            }

            AssetBundle assetBundle = _alreadyLoadDic[bundleName];
            return assetBundle.LoadAsset(assetName);
        }
        internal IEnumerator GetAssetAsync(string assetName, AsyncOperationHandle handle)
        {
            yield return GameApp.Instance.StartCoroutine(GetAssetAsync(null, assetName, handle));
        }

        /// <summary>
        /// 根据ab包和资源名获取一个资源
        /// </summary>
        /// <param name="bundleName"></param>
        /// <param name="assetName"></param>
        /// <returns></returns>
        internal IEnumerator GetAssetAsync(string bundleName, string assetName, AsyncOperationHandle handle)
        {
            if (string.IsNullOrWhiteSpace(bundleName))
            {
                var assetInfoDto = AssetInfoDtoList.FirstOrDefault(a => a.AssetName == assetName);
                if (assetInfoDto != null)
                {
                    bundleName = assetInfoDto.AssetBundleName;
                }
                else
                {
                    Debug.LogError($"没有找到资源:{assetName}对应的包名");
                    yield break;
                }
            }
            AssetBundleInfoDto bundleInfoDto = GetBundleInfoDto(bundleName);
            if (!_alreadyLoadDic.ContainsKey(bundleName))
            {
                if (bundleInfoDto != null)
                {
                    yield return GameApp.Instance.StartCoroutine(LoadAssetBundleAsync(bundleInfoDto));
                }
                else
                {
                    Debug.LogError($"没有找到资源:{bundleName}包");
                    yield break;
                }
            }

            AssetBundle assetBundle = _alreadyLoadDic[bundleName];
            handle.Result = assetBundle.LoadAsset(assetName);
        }

        private IEnumerator LoadAssetBundleAsync(AssetBundleInfoDto bundleInfoDto)
        {
            AssetBundleCreateRequest request = AssetBundle.LoadFromFileAsync(AssetBundlePath + "/" + bundleInfoDto.AssetBundleName);
            yield return request;
            bundleInfoDto.LastUseTime = DateTime.Now;
            _alreadyLoadDic.Add(bundleInfoDto.AssetBundleName, request.assetBundle);
            foreach (var item in bundleInfoDto.Dependencies)
            {
                if (!_alreadyLoadDic.ContainsKey(item))
                {
                    AssetBundleInfoDto temp = GetBundleInfoDto(item);
                    if (temp != null)
                    {
                        yield return GameApp.Instance.StartCoroutine(LoadAssetBundleAsync(temp));
                    }
                }
            }
        }

        private void LoadAssetBundle(AssetBundleInfoDto bundleInfoDto)
        {
            AssetBundle assetBundle = AssetBundle.LoadFromFile(AssetBundlePath + "/" + bundleInfoDto.AssetBundleName);
            bundleInfoDto.LastUseTime = DateTime.Now;
            _alreadyLoadDic.Add(bundleInfoDto.AssetBundleName, assetBundle);
            foreach (var item in bundleInfoDto.Dependencies)
            {
                if (!_alreadyLoadDic.ContainsKey(item))
                {
                    AssetBundleInfoDto temp = GetBundleInfoDto(item);
                    if (temp != null)
                    {
                        LoadAssetBundle(temp);
                    }
                }
            }
        }

        /// <summary>
        /// 资源包信息
        /// </summary>
        public sealed class AssetBundleInfoDto
        {
            public AssetBundleInfoDto()
            {
                Dependencies = new List<string>();
            }
            /// <summary>
            /// 包名
            /// </summary>
            public string AssetBundleName { get; set; }
            /// <summary>
            /// 依赖包
            /// </summary>
            public List<string> Dependencies { get; set; }
            /// <summary>
            /// 最后使用时间
            /// </summary>
            internal DateTime LastUseTime { get; set; }
        }
        /// <summary>
        /// 资源信息
        /// </summary>
        public sealed class AssetInfoDto
        {
            /// <summary>
            /// 文件名
            /// </summary>
            public string AssetName { get; set; }
            /// <summary>
            /// 包名
            /// </summary>
            public string AssetBundleName { get; set; }
        }
    }
}
