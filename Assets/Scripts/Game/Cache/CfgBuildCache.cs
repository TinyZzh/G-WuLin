using System;

namespace Assets.Scripts.Game.Cache
{
    [Serializable]
    public class CfgBuild : ICacheObject<int>
    {
        public int CfgBuildId;
        public string Desc;
        public int Income;
        public string Name;
        public int Prefix;
        public int Price;
        public int Type;

        public int GetKey()
        {
            return CfgBuildId;
        }
    }


    internal class CfgBuildCache : Cache<int, CfgBuild>
    {
        public CfgBuildCache() : base("cfg_build")
        {
        }
    }
}