using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
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
        /// 根据资源名获取一个资源
        /// </summary>
        /// <param name="assetName"></param>
        /// <returns></returns>
        internal async Task<Object> GetAsset(string assetName)
        {
            return await GetAsset(null, assetName);
        }

        /// <summary>
        /// 根据ab包和资源名获取一个资源
        /// </summary>
        /// <param name="bundleName"></param>
        /// <param name="assetName"></param>
        /// <returns></returns>
        internal async Task<Object> GetAsset(string bundleName, string assetName)
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

            AssetBundle assetBundle = await GetAssetBundle(bundleName);
            await new WaitForUnityThread();
            return assetBundle.LoadAsset(assetName);
        }

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


        /// <summary>
        /// 检查各个AB包使用时间
        /// </summary>
        internal async void CheckAssetBundleUseTime(int unusedTime)
        {
            Begin: if (Interlocked.CompareExchange(ref _currentLock, TRUE, FALSE) == FALSE)
            {
                DateTime dateTime = DateTime.Now;
                foreach (var item in AssetBundleInfoDtoList)
                {
                    int temp = (int)((dateTime - item.LastUseTime).TotalSeconds);
                    if (temp > unusedTime)
                    {
                        if (_alreadyLoadDic.ContainsKey(item.AssetBundleName))
                        {

                            await new WaitForUnityThread();
                            _alreadyLoadDic[item.AssetBundleName].Unload(true);
                            _alreadyLoadDic.Remove(item.AssetBundleName);
                        }
                    }
                }
                Interlocked.Exchange(ref _currentLock, FALSE);
            }
            else
            {
                Thread.Sleep(100);
                goto Begin;
            }
        }
        /// <summary>
        /// 卸载一个AB包
        /// </summary>
        internal async void UnloadAssetBundleByName(string bundleName)
        {
            Begin: if (Interlocked.CompareExchange(ref _currentLock, TRUE, FALSE) == FALSE)
            {
                if (_alreadyLoadDic.ContainsKey(bundleName))
                {
                    await new WaitForUnityThread();
                    _alreadyLoadDic[bundleName].Unload(true);
                    _alreadyLoadDic.Remove(bundleName);
                }
                Interlocked.Exchange(ref _currentLock, FALSE);
            }
            else
            {
                Thread.Sleep(100);
                goto Begin;
            }
        }

        private async Task<AssetBundle> GetAssetBundle(string bundleName)
        {
            Begin: if (Interlocked.CompareExchange(ref _currentLock, TRUE, FALSE) == FALSE)
            {
                AssetBundleInfoDto bundleInfoDto = GetBundleInfoDto(bundleName);
                if (!_alreadyLoadDic.ContainsKey(bundleName))
                {
                    if (bundleInfoDto != null)
                    {
                        await LoadAssetBundle(bundleInfoDto);
                    }
                    else
                    {
                        Interlocked.Exchange(ref _currentLock, FALSE);
                        return null;
                    }
                }
                bundleInfoDto.LastUseTime = DateTime.Now;
                Interlocked.Exchange(ref _currentLock, FALSE);
                return _alreadyLoadDic[bundleName];
            }
            else
            {
                await new WaitForRealSeconds(50);
                goto Begin;
            }
        }
        private AssetBundleInfoDto GetBundleInfoDto(string bundleName)
        {
            return AssetBundleInfoDtoList.FirstOrDefault(a => a.AssetBundleName == bundleName);
        }
        private async Task<object> LoadAssetBundle(AssetBundleInfoDto bundleInfoDto)
        {
            await new WaitForUnityThread();
            AssetBundleCreateRequest request = AssetBundle.LoadFromFileAsync(AssetBundlePath + "/" + bundleInfoDto.AssetBundleName);
            await request;
            _alreadyLoadDic.Add(bundleInfoDto.AssetBundleName, request.assetBundle);
            foreach (var item in bundleInfoDto.Dependencies)
            {
                if (!_alreadyLoadDic.ContainsKey(item))
                {
                    AssetBundleInfoDto temp = GetBundleInfoDto(item);
                    if (temp != null)
                    {
                        await LoadAssetBundle(temp);
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            return null;
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
