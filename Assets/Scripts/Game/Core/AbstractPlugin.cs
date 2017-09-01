using System;

namespace Assets.Scripts.Game.Core
{
    internal abstract class AbstractPlugin : IPlugin
    {
        /// <summary>
        ///     插件是否启用
        /// </summary>
        private bool _isEnable;

        /// <summary>
        ///     插件是否完成初始化
        /// </summary>
        private bool _isInited;

        public AbstractPlugin()
        {
            Enable = true;
        }

        /// <summary>
        ///     启用插件
        /// </summary>
        public bool Enable
        {
            get { return _isEnable; }
            protected set
            {
                if (_isEnable != value)
                    if (value)
                    {
                        if (OnPluginEnable != null)
                            OnPluginEnable(this, null);
                    }
                    else
                    {
                        if (OnPluginDisable != null)
                            OnPluginDisable(this, null);
                    }
                _isEnable = value;
            }
        }


        public void Initialize()
        {
            if (_isInited)
                return;
            InitPlugin();
            _isInited = true;
        }


        public bool IsInitialized()
        {
            return _isInited;
        }


        public abstract void InitPlugin();

        /// <summary>
        ///     插件启用事件
        /// </summary>
        public event EventHandler OnPluginEnable;

        /// <summary>
        ///     插件禁用事件
        /// </summary>
        public event EventHandler OnPluginDisable;
    }
}