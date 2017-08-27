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
        private bool _isInited = false;

        public AbstractPlugin()
        {
            Enable = true;
        }

        /// <summary>
        ///     启用插件
        /// </summary>
        protected bool Enable
        {
            get { return _isEnable; }
            set
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
            this._isInited = true;
        }


        public abstract void InitPlugin();


        public bool IsInitialized()
        {
            return _isInited;
        }

        public event EventHandler OnPluginEnable;
        public event EventHandler OnPluginDisable;
    }
}