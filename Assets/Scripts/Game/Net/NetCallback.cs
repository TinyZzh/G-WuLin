using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Game.Net
{
    internal class NetCallback
    {
        /// <summary>
        /// 唯一ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 回调函数注册时间点. 用于处理回调等待超时
        /// </summary>
        public long Dateline { get; set; }
        /// <summary>
        /// 参数
        /// </summary>
        public Type Param { get; set; }
        /// <summary>
        /// 回调函数
        /// </summary>
        public Action<IMessage> InvokedMethod { get; set; }

    }
}
