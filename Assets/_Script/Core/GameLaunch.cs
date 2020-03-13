using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSLuaFramework;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;

public sealed class GameLaunch : MonoBehaviour
{
    private void Start()
    {
        //byte[] test = new byte[] { 10, 5 };
        //TSByte.EncryptDecrypt(test);
        //foreach (var item in test)
        //{
        //    Debug.LogError("加密后：" + item);
        //}
        //TSByte.EncryptDecrypt(test);
        //foreach (var item in test)
        //{
        //    Debug.LogError("解密后：" + item);
        //}
        Application.targetFrameRate = 60;
        GameApp.Instance.Init();
        //GameApp.Instance.SetLuaLibraryPath("Assets/ThirdPlug/TSFrame/LuaScript").Init().SetAssetBundlePath("AssetBundles/StandaloneWindows64");
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Q))
        {
            //ResourcesModule.Instance.LoadAsset("testpanel").Completed += GameLaunch_Completed;
        }
    }

    private void GameLaunch_Completed(Object obj)
    {
        //GameObject.Instantiate(obj.Result);
    }
}

