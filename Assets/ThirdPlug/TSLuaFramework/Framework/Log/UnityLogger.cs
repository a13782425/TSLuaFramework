using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace TSLuaFramework
{
    public sealed class UnityLogger : ILogger
    {
        private readonly string Name;
        public UnityLogger(string name)
        {
            IsEnable = true;
            Name = name;
        }
        public bool IsEnable { get; set; }

        public void Log(string message)
        {
            if (IsEnable)
            {
                Debug.Log($"[{Name}]:{message}");
            }
        }

        public void Log(object message)
        {
            if (IsEnable)
            {
                Debug.Log($"[{Name}]:{message}");
            }
        }

        public void LogWarning(string message)
        {
            if (IsEnable)
            {
                Debug.LogWarning($"[{Name}]:{message}");
            }
        }

        public void LogWarning(object message)
        {
            if (IsEnable)
            {
                Debug.LogWarning($"[{Name}]:{message}");
            }
        }

        public void LogError(string message)
        {
            if (IsEnable)
            {
                Debug.LogError($"[{Name}]:{message}");
            }
        }

        public void LogError(object message)
        {
            if (IsEnable)
            {
                Debug.LogError($"[{Name}]:{message}");
            }
        }
    }
}
