//     +------------------------+
//     |    Author : TinyZ      |
//     |   Data : 2014-08-20    |
//     |Ma-il : zou90512@126.com|
//     +------------------------+
//      ��������: 
//      [�Ƽ�]protobuf-csharp-port��https://code.google.com/p/protobuf-csharp-port/ . PB���,��������C#ʵ��.ʹ��.net 20�汾����������֧��Unity3D 4.3x���ϰ汾
//      protobuf-net: https://code.google.com/p/protobuf-net/ 


//#define PROTOBUF_CAHARP_2_X


#if PROTOBUF_CAHARP_2_X

using System;
using Google.ProtocolBuffers;

namespace Assets.Scripts.Game.Net.Codec
{
    /// <summary>
    /// Protocol Buffers ������
    /// </summary>
    public class ProtobufDecoder
    {
        private readonly IMessageLite _prototype;

        /// <summary>
        /// ��չ��Ϣע��
        /// </summary>
        private readonly ExtensionRegistry _extensionRegistry;

        public ProtobufDecoder(IMessageLite prototype)
        {
            _prototype = prototype.WeakDefaultInstanceForType;
        }

        public ProtobufDecoder(IMessageLite prototype, ExtensionRegistry extensionRegistry)
            : this(prototype)
        {
            _extensionRegistry = extensionRegistry;
        }

        /// <summary>
        /// ע����չ
        /// </summary>
        /// <param name="extension">protobuf��չ��Ϣ</param>
        public void RegisterExtension(IGeneratedExtensionLite extension)
        {
            if (_extensionRegistry == null)
            {
                throw new Exception("ExtensionRegistry must using InitProtobufDecoder method to initialize. ");
            }
            _extensionRegistry.Add(extension);
        }

        /// <summary>
        /// ����
        /// </summary>
        /// <param name="data">protobuf�����ֽ�����</param>
        /// <returns>���ؽ���֮�����Ϣ</returns>
        public IMessageLite Decode(byte[] data)
        {
            if (_prototype == null)
            {
                throw new Exception("_prototype must using InitProtobufDecoder method to initialize.");
            }
            IMessageLite message;
            if (_extensionRegistry == null)
            {
                message = (_prototype.WeakCreateBuilderForType().WeakMergeFrom(ByteString.CopyFrom(data))).WeakBuild();
            }
            else
            {
                message =
                    (_prototype.WeakCreateBuilderForType().WeakMergeFrom(ByteString.CopyFrom(data), _extensionRegistry))
                        .WeakBuild();
            }
            if (message == null)
            {
                throw new Exception("Decode message failed");
            }
            return message;
        }
    }
}
#endif