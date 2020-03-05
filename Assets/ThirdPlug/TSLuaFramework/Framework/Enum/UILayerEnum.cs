using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSLuaFramework.Enum
{
    /// <summary>
    /// UI层级
    /// </summary>
    [Flags]
    public enum UILayerEnum
    {
        /// <summary>
        /// 初始层
        /// </summary>
        None = 1 << 0,
        /// <summary>
        /// 底部层级
        /// </summary>
        Bottom = 1 << 1,
        /// <summary>
        /// 普通层级
        /// </summary>
        Normal = 1 << 4,
        /// <summary>
        /// 固定层级
        /// </summary>
        Fixed = 1 << 8,
        /// <summary>
        /// 提示层级
        /// </summary>
        Tooltip = 1 << 12,
        /// <summary>
        /// 弹窗层级
        /// </summary>
        Dialog = 1 << 16,
        /// <summary>
        /// 公告层级
        /// </summary>
        Notice = 1 << 20,
        /// <summary>
        /// (最高层级)
        /// </summary>
        Max = 1 << 24,
    }
}
