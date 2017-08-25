namespace Assets.Scripts.Game.Core
{
    internal abstract class AbstractPlugin : IPlugin
    {
        /// <summary>
        ///     插件是否完成初始化
        /// </summary>
        protected bool IsInited = false;

        public AbstractPlugin()
        {
            Enable = true;
        }

        /// <summary>
        ///     启用插件
        /// </summary>
        protected bool Enable { get; set; }


        public abstract void Initialize();


        public bool IsInitialized()
        {
            return IsInited;
        }
    }
}