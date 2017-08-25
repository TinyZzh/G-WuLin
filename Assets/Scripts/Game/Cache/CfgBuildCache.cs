using System;

namespace Assets.Scripts.Game.Cache
{

    [Serializable]
    internal class CfgBuild : CacheObject<int>
    {
        public int CfgBuildId { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }


        public int GetKey()
        {
            return this.CfgBuildId;
        }
    }


    internal class CfgBuildCache : Cache<int, CfgBuild>
    {
        public override void Dispose()
        {
            throw new NotImplementedException();
        }

        public override string CacheName()
        {
            return "cfg_build";
        }

        public override void Load()
        {
            CfgBuild m_bean = new CfgBuild();
            m_bean.CfgBuildId = 1001;
            CacheDic.Add(m_bean.GetKey(), m_bean);
        }
    }
}
