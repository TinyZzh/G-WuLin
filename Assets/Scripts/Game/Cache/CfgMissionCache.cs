using System;

namespace Assets.Scripts.Game.Cache
{
    [Serializable]
    internal class CfgTask : ICacheObject<int>
    {
        public int After; // 后续任务     array   后续[lineId_index]列表
        public int BusId; // 对应的活动进度ID - 用于记录进度

        public int CfgRewardId; // 任务奖励

        // [事件相关参数]
        public int Events; // 注册事件     array   注册事件列表

        public int IsDaily; // 是否日常
        public int Keys; // 检索Key      array   事件相关的key
        public int Level; // 等级限制
        public int PreIndex; // 前置任务线次序
        public int PreTaskLineId; // 前置任务线

        public int Score; // 奖励活跃度

        //    public $cfgTaskLineId;  // 任务线
        //    public $index;          // 任务线次序   -   hashKey
        public int TaskType; // 任务类型

        public int Values; // 完成值       array   事件完成值


        public int GetKey()
        {
            return Level;
        }
    }


    internal class CfgTaskCache : Cache<int, CfgBuild>
    {
        public CfgTaskCache() : base("cfg_level")
        {
        }
    }
}