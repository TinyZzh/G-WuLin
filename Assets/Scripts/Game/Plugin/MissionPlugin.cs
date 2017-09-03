namespace Assets.Scripts.Game.Plugin
{
    /// <summary>
    ///     任务组件
    /// </summary>
    internal class MissionPlugin : ComplexNetPlugin
    {
        public override void InitPlugin()
        {
        }
    }

    internal class TaskCycle
    {
        /// <summary>
        ///     任务链ID
        /// </summary>
        private int TaskCycleId { get; set; }

        /// <summary>
        ///     进度
        /// </summary>
        private int Index { get; set; }
    }
}