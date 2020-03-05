using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSLuaFramework.Module;
using UnityEngine;
using ILogger = TSLuaFramework.ILogger;

/// <summary>
/// Lua更新
/// </summary>
internal class LuaUpdater : MonoBehaviour
{
    Action<float, float> _luaUpdate = null;
    Action _luaLateUpdate = null;
    Action<float> _luaFixedUpdate = null;
    ILogger _logger = LogModule.Instance.GetLogger("LuaUpdater");
    internal void Init()
    {
        _luaUpdate = LuaModule.Instance.CurrentLuaEnv.Global.Get<Action<float, float>>("Update");
        _luaLateUpdate = LuaModule.Instance.CurrentLuaEnv.Global.Get<Action>("LateUpdate");
        _luaFixedUpdate = LuaModule.Instance.CurrentLuaEnv.Global.Get<Action<float>>("FixedUpdate");
    }

    void Update()
    {
        if (_luaUpdate != null)
        {
            try
            {
                _luaUpdate(Time.deltaTime, Time.unscaledDeltaTime);
            }
            catch (Exception ex)
            {
                _logger.LogError("luaUpdate err : " + ex.Message + "\n" + ex.StackTrace);
            }
        }
    }
    void LateUpdate()
    {
        if (_luaLateUpdate != null)
        {

            try
            {
                _luaLateUpdate();
            }
            catch (Exception ex)
            {
                _logger.LogError("luaLateUpdate err : " + ex.Message + "\n" + ex.StackTrace);
            }

        }
    }

    void FixedUpdate()
    {
        if (_luaFixedUpdate != null)
        {
            try
            {
                _luaFixedUpdate(Time.fixedDeltaTime);
            }
            catch (Exception ex)
            {
                _logger.LogError("luaFixedUpdate err : " + ex.Message + "\n" + ex.StackTrace);
            }

        }
    }
    void OnDestroy()
    {
        _luaUpdate = null;
        _luaLateUpdate = null;
        _luaFixedUpdate = null;
    }
}
