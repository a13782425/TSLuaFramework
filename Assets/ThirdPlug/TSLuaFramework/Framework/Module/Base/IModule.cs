

namespace TSLuaFramework.Module
{
    /// <summary>
    /// 模块一般是游戏启动时加载的,结束时卸载的
    /// </summary>
    internal interface IModule
    {
        /// <summary>
        /// 初始化
        /// </summary>
        void Init();
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="deltaTime">更新时间</param>
        void Update(float deltaTime);
        /// <summary>
        /// 释放
        /// </summary>
        void Freed();
    }
}
