using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSLuaFramework.Module
{
    [Priority(int.MinValue)]
    public sealed class LogModule : BaseModule<LogModule>
    {
        private Dictionary<string, ILogger> _logDic;
        public override void Init()
        {
            base.Init();
            _logDic = new Dictionary<string, ILogger>();
        }

        public ILogger GetLogger(string name)
        {
            if (_logDic.ContainsKey(name))
            {
                return _logDic[name];
            }
            return new UnityLogger(name);
        }
    }
}
