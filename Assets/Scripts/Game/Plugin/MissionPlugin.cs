using System;
using System.Collections.Generic;
using Assets.Scripts.Game.Bean;
using Assets.Scripts.Game.Cache;
using Org.OkraAx.V3;

namespace Assets.Scripts.Game.Plugin
{
    /// <summary>
    ///     任务组件
    /// </summary>
    internal class MissionPlugin : ComplexNetPlugin
    {
        

        public override void Initialize()
        {
            
        }

    }

    internal class TaskCycle
    {
        /// <summary>
        /// 任务链ID
        /// </summary>
        private int TaskCycleId { get; set; }
        /// <summary>
        /// 进度
        /// </summary>
        private int Index { get; set; }


    }
}