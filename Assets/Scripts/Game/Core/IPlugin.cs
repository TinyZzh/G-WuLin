using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Game.Core
{
    internal interface IPlugin
    {

        /// <summary>
        /// 插件是否已经初始化
        /// </summary>
        /// <returns>假如已经完成初始化,返回True, 否则False</returns>
        bool IsInitialized();

        /// <summary>
        /// 初始化插件
        /// </summary>
        void Initialize();

        

    }
}
