//     +------------------------+
//     |    Author : TinyZ      |
//     |   Data : 2014-08-20    |
//     |Ma-il : zou90512@126.com|
//     +------------------------+
//      ��������: 
//      [�Ƽ�]protobuf-csharp-port��https://code.google.com/p/protobuf-csharp-port/ . PB���,��������C#ʵ��.ʹ��.net 20�汾����������֧��Unity3D 4.3x���ϰ汾
//      protobuf-net: https://code.google.com/p/protobuf-net/ 



#if PROTOBUF_CAHARP_2_X
using Google.ProtocolBuffers;

namespace Assets.Scripts.Game.Net.Codec
{
    /// <summary>
    /// Protocol Buffers ������
    /// </summary>
    public class ProtobufEncoder
    {
        /// <summary>
        /// [����]Messageת��Ϊbyte[]
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="generatedExtensionLite"></param>
        /// <param name="messageLite"></param>
        /// <returns></returns>
        public static byte[] ConvertMessageToByteArray<T>(GeneratedExtensionLite<ServerMessage, T> generatedExtensionLite, T messageLite) where T : IMessageLite
        {
            ServerMessage.Builder builder = ServerMessage.CreateBuilder();
            builder.SetMsgId("" + generatedExtensionLite.Number);
            builder.SetExtension(generatedExtensionLite, messageLite);
            ServerMessage serverMessage = builder.Build();
            return serverMessage.ToByteArray();
        }

        public static byte[] Encode(IMessageLite messageLite)
        {
            return messageLite.ToByteArray();
        }

        public static byte[] Encode(IBuilder builder)
        {
            return builder.WeakBuild().ToByteArray();
        }
    }
}
#endif