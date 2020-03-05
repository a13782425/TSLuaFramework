using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSLuaFramework.Module
{
    /// <summary>
    /// Module中间类，用于lua获取各种Manager
    /// </summary>
    public static class ModuleManager
    {

        public static AssetBundleModule GetAssetBundleModule()
        {
            return AssetBundleModule.Instance;
        }
    }
}
