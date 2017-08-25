using System;
using System.Collections.Generic;
using Assets.Scripts.Game.Core;
using Google.Protobuf;
using Org.OkraAx.V3;

namespace Assets.Scripts.Game.Plugin
{
    /// <summary>
    ///     帮派成员
    /// </summary>
    internal class MafiaMemberPlugin : ComplexNetPlugin
    {

        public Dictionary<long, MafiaMemberInfo> MafiaMemberInfos = new Dictionary<long, MafiaMemberInfo>();

        public override void Initialize()
        {
            RegisterMethod<GpcVoid>("CallbackMafiaMemberDetail", CallbackMafiaMemberDetail);
        }


        public void InitMafiaMember()
        {
            PushEvent("getMafiaMemberDatail", new GpcVoid());
        }

        public void CallbackMafiaMemberDetail(GpcVoid msg)
        {
            
        }



    }

    /// <summary>
    /// 帮派成员信息
    /// </summary>
    internal struct MafiaMemberInfo
    {
        /// <summary>
        /// 唯一ID
        /// </summary>
        public long Uid { get; set; }
        /// <summary>
        /// 角色名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 等级
        /// </summary>
        public int Level { get; set; }
        /// <summary>
        /// 成为好友的时间
        /// </summary>
        public long Timestamp { get; set; }
    }
}