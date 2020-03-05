using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSLuaFramework.Model;
using TSLuaFramework.Tool;
using XLua;
using UnityEngine;

namespace TSLuaFramework.Module
{
    internal sealed class LuaModule : BaseModule<LuaModule>
    {
        LuaEnv _luaEnv;
        GameObject _luaUpdateObj = null;

        public LuaEnv CurrentLuaEnv { get => _luaEnv; }

        public override void Init()
        {
            _luaEnv = new LuaEnv();
            _luaEnv.AddLoader(GameSetting.CustomLoader);
            _luaEnv.DoString("require 'AppConfig'");
            GameStart();
        }

        public void GameStart()
        {
            SetGameConfig();
            _luaUpdateObj = new GameObject("LuaUpdate");
            _luaUpdateObj.transform.SetParent(transform);
            _luaUpdateObj.AddComponent<LuaUpdater>().Init();
            _luaEnv.DoString("require 'GameMain'");
            _luaEnv.DoString("GameMain.Start()");
        }
        public override void Update(float deltaTime)
        {
            if (_luaEnv != null)
            {
                _luaEnv.Tick();

                if (Time.frameCount % 200 == 0)
                {
                    _luaEnv.FullGc();
                    System.GC.Collect();
                }
            }
        }

        public override void Freed()
        {
            _luaEnv.DoString("GameMain.OnApplicationQuit()");
        }
        private void SetGameConfig()
        {
            StringBuilder sb = new StringBuilder();
            //todo 赋值
            sb.AppendLine("local t = {}");
            sb.AppendLine($"t.debug = false");
            sb.AppendLine($"t.gamePath = '{GameSetting.GetGamePath()}'");
            sb.AppendLine($"t.gameAssetBundlePath = '{GameSetting.GetGameAssetBundlePath()}'");
            sb.AppendLine($"t.gameDataPath = '{GameSetting.GetGameDataPath()}'");
            sb.AppendLine($"App = ConstClass('App',t)");
            sb.AppendLine($"t = nil");

            _luaEnv.DoString(sb.ToString());
        }
    }
}
