using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TSLuaFramework.Model;
using UnityEditor;
using UnityEngine;

internal class AssetBundleBuilder
{
    [MenuItem("TSFrame/资源/生成AB目录", false, 102)]
    private static void GenAssetBundleCatalog()
    {
        var newPath = EditorUtility.OpenFilePanelWithFilters("选择文件", string.Empty, new string[] { "清单", "manifest" });
        if (!string.IsNullOrEmpty(newPath))
        {
            string abPath = Path.GetDirectoryName(newPath);
            string abFileName = Path.GetFileNameWithoutExtension(newPath);
            if (abFileName.ToLower() == "catalog")
            {
                EditorUtility.DisplayDialog("错误", "文件名不能存在catalog", "确定");
                return;
            }
            AssetBundle assetBundle = AssetBundle.LoadFromFile(abPath + "/" + abFileName);
            AssetBundleManifest manifest = assetBundle.LoadAsset<AssetBundleManifest>("AssetBundleManifest");
            if (manifest == null)
            {
                EditorUtility.DisplayDialog("错误", "请选择AssetBundle清单文件", "确定");
                assetBundle.Unload(true);
                AssetBundle.UnloadAllAssetBundles(true);
                Resources.UnloadUnusedAssets();
                return;
            }
            string[] strs = manifest.GetAllAssetBundles();
            if (strs.FirstOrDefault(a => a.ToLower() == "catalog") != null)
            {
                EditorUtility.DisplayDialog("错误", "文件名不能存在catalog", "确定");
                assetBundle.Unload(true);
                AssetBundle.UnloadAllAssetBundles(true);
                Resources.UnloadUnusedAssets();
                return;
            }
            AssetBundleDto assetBundleDto = new AssetBundleDto();
            foreach (var item in strs)
            {
                string file = abPath + "/" + item;
                AssetBundle tempAb = AssetBundle.LoadFromFile(file);
                string[] names = tempAb.GetAllAssetNames();
                string[] dependencies = manifest.GetDirectDependencies(item);
                AssetBundleDto.AssetBundleInfoDto bundleInfoDto = new AssetBundleDto.AssetBundleInfoDto();
                bundleInfoDto.AssetBundleName = item.ToLower();
                bundleInfoDto.Dependencies.AddRange(dependencies);
                assetBundleDto.AssetBundleInfoDtoList.Add(bundleInfoDto);
                foreach (var name in names)
                {
                    string assetName = Path.GetFileNameWithoutExtension(name);
                    AssetBundleDto.AssetInfoDto assetInfo = new AssetBundleDto.AssetInfoDto() { AssetName = assetName, AssetBundleName = item };
                    assetBundleDto.AssetInfoDtoList.Add(assetInfo);
                }
                tempAb.Unload(true);
            }
            File.WriteAllText(abPath + "/catalog", Newtonsoft.Json.JsonConvert.SerializeObject(assetBundleDto), new System.Text.UTF8Encoding());

            assetBundle.Unload(true);
            AssetBundle.UnloadAllAssetBundles(true);
            Resources.UnloadUnusedAssets();
            EditorUtility.DisplayDialog("Successful", "生成成功succeed", "确定");
        }
    }
}
