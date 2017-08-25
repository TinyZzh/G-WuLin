using System;

namespace Assets.Scripts.Game.Cache
{
    [Serializable]
    internal class CfgLevel : CacheObject<int>
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

        public override string CacheName()
        {
            return "cfg_level";
        }

        public override void Load()
        {
            var m_bean = new CfgBuild();
            m_bean.CfgBuildId = 1001;
            CacheDic.Add(m_bean.GetKey(), m_bean);
        }

        public override void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}