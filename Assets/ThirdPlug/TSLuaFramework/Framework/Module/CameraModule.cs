using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace TSLuaFramework.Module
{
    //public sealed class CameraModule : BaseModule<CameraModule>
    //{
    //    internal GameObject MainCamObj { get; private set; }
    //    internal Transform MainCamTran { get; private set; }
    //    internal Camera MainCam { get; private set; }

    //    public override void Init()
    //    {
    //        GameObject obj = Resources.Load<GameObject>("Prefab/MainCamera");
    //        MainCamObj = GameObject.Instantiate(obj, transform);
    //        MainCamTran = MainCamObj.transform;
    //        MainCam = MainCamObj.GetComponent<Camera>();
    //        MainCam.clearFlags = CameraClearFlags.Nothing;
    //        MainCam.orthographic = true;
    //        MainCam.orthographicSize = 20;
    //    }
    //}
}
