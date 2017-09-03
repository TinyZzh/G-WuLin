using System;

namespace Assets.Scripts.Game.Cache
{
    [Serializable]
    internal class CfgLevel : ICacheObject<int>
    {
        public int Level { get; set; }
        public int Exp { get; set; }


        public int GetKey()
        {
            return Level;
        }
    }


    internal class CfgLevelCache : Cache<int, CfgBuild>
    {
        public CfgLevelCache() : base("cfg_level")
        {
        }
    }
}