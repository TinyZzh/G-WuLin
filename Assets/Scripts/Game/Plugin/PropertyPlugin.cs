using Assets.Scripts.Game.Bean;
using Google.Protobuf;
using Org.OkraAx.V3;

namespace Assets.Scripts.Game.Plugin
{
    /// <summary>
    ///     玩家属性插件
    /// </summary>
    internal class PropertyPlugin : ComplexNetPlugin
    {
        public RoleSkillPointBean UserSkillPointData;

        #region API接口

        /// <summary>
        ///     使用技能点
        /// </summary>
        /// <param name="point">使用数量</param>
        public void UseSkillPoint(PropertyType type, int point)
        {
            if (!IsInitialized()) return;
            if (UserSkillPointData == null) return;
            if ((int) type < 1 || (int) type > 4) return;
            if (UserSkillPointData.SkillPoints < point)
                return;
            PushEvent("", new AxAny());
        }

        #endregion


        #region 初始化

        public override void InitPlugin()
        {
            //  TODO: 从服务器获取技能点信息
        }

        /// <summary>
        ///     注册回调函数
        /// </summary>
        public void InitNetApi()
        {
//            RegisterMethod("CallbackGetPropertyData", typeof(GpcCall), CallbackGetPropertyData);
        }

        #endregion

        #region  回调接口

        public void CallbackGetPropertyData(IMessage param)
        {
        }

        public void CallbackUseSkillPoint(PropertyType type, int point)
        {
            switch (type)
            {
                case PropertyType.None:
                    //  TODO: 参数错误
                    return;
                case PropertyType.Attack:
                    UserSkillPointData.Attack += point;
                    break;
                case PropertyType.Defense:
                    UserSkillPointData.Defense += point;
                    break;
                case PropertyType.Energy:
                    UserSkillPointData.Energy += point * 10;
                    break;
                case PropertyType.Stamina:
                    UserSkillPointData.Stamina += point / 2.0f;
                    break;
            }
            UserSkillPointData.SkillPoints -= point;
        }

        #endregion
    }
}