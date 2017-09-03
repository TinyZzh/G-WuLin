// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Gpc.proto

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;

namespace Org.OkraAx.V3
{
    /// <summary>Holder for reflection information generated from Gpc.proto</summary>
    public static partial class GpcReflection
    {
        #region Descriptor

        /// <summary>File descriptor for Gpc.proto</summary>
        public static pbr::FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

        private static pbr::FileDescriptor descriptor;

        static GpcReflection()
        {
            var descriptorData = global::System.Convert.FromBase64String(
                string.Concat(
                    "CglHcGMucHJvdG8SDW9yZy5va3JhQXgudjMaC0F4QW55LnByb3RvIikKB0dw",
                    "Y0NhbGwSDgoGbWV0aG9kGAEgASgJEg4KBnBhcmFtcxgCIAEoDCIJCgdHcGNW",
                    "b2lkIj4KCEdwY1JlbGF5EiQKBnNvdXJjZRgBIAEoCzIULm9yZy5va3JhQXgu",
                    "djMuQXhBbnkSDAoEZGF0YRgCIAEoDCImCghHcGNFcnJvchINCgVzdGF0ZRgB",
                    "IAEoBRILCgNtc2cYAiABKAlCGAoNb3JnLm9rcmFBeC52M0IDR3BjSAFQAWIG",
                    "cHJvdG8z"));
            descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
                new pbr::FileDescriptor[] {global::Org.OkraAx.V3.AxAnyReflection.Descriptor,},
                new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[]
                {
                    new pbr::GeneratedClrTypeInfo(typeof(global::Org.OkraAx.V3.GpcCall),
                        global::Org.OkraAx.V3.GpcCall.Parser, new[] {"Method", "Params"}, null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::Org.OkraAx.V3.GpcVoid),
                        global::Org.OkraAx.V3.GpcVoid.Parser, null, null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::Org.OkraAx.V3.GpcRelay),
                        global::Org.OkraAx.V3.GpcRelay.Parser, new[] {"Source", "Data"}, null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::Org.OkraAx.V3.GpcError),
                        global::Org.OkraAx.V3.GpcError.Parser, new[] {"State", "Msg"}, null, null, null)
                }));
        }

        #endregion
    }

    #region Messages

    /// <summary>
    ///     Gpc Call Message.
    ///     Async remote produce call based on GPB(Google Protocol Buffers).
    /// </summary>
    public sealed partial class GpcCall : pb::IMessage<GpcCall>
    {
        /// <summary>Field number for the "method" field.</summary>
        public const int MethodFieldNumber = 1;

        /// <summary>Field number for the "params" field.</summary>
        public const int ParamsFieldNumber = 2;

        private static readonly pb::MessageParser<GpcCall> _parser =
            new pb::MessageParser<GpcCall>(() => new GpcCall());

        private string method_ = "";
        private pb::ByteString params_ = pb::ByteString.Empty;

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public GpcCall()
        {
            OnConstruction();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public GpcCall(GpcCall other) : this()
        {
            method_ = other.method_;
            params_ = other.params_;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<GpcCall> Parser
        {
            get { return _parser; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::Org.OkraAx.V3.GpcReflection.Descriptor.MessageTypes[0]; }
        }

        /// <summary>
        ///     the remote call produce name.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Method
        {
            get { return method_; }
            set { method_ = pb::ProtoPreconditions.CheckNotNull(value, "value"); }
        }

        /// <summary>
        ///     the request param message. the message must be gpb message.
        ///     the gpb param message will be covert to args array for java method.
        ///     example:
        ///     take the {@link GpcError} in this proto file as an example.
        ///     define the gpb service:
        ///     ...
        ///     service  XXXService {
        ///     rpc doAction (GpcError) returns (GpcVoid);
        ///     ... define any more rpc.
        ///     }
        ///     map the java method:
        ///     void doAction(int state, String msg).
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pb::ByteString Params
        {
            get { return params_; }
            set { params_ = pb::ProtoPreconditions.CheckNotNull(value, "value"); }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public GpcCall Clone()
        {
            return new GpcCall(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(GpcCall other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Method != other.Method) return false;
            if (Params != other.Params) return false;
            return true;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output)
        {
            if (Method.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Method);
            }
            if (Params.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteBytes(Params);
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize()
        {
            var size = 0;
            if (Method.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(Method);
            }
            if (Params.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeBytesSize(Params);
            }
            return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(GpcCall other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Method.Length != 0)
            {
                Method = other.Method;
            }
            if (other.Params.Length != 0)
            {
                Params = other.Params;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 10:
                    {
                        Method = input.ReadString();
                        break;
                    }
                    case 18:
                    {
                        Params = input.ReadBytes();
                        break;
                    }
                }
            }
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other)
        {
            return Equals(other as GpcCall);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode()
        {
            var hash = 1;
            if (Method.Length != 0) hash ^= Method.GetHashCode();
            if (Params.Length != 0) hash ^= Params.GetHashCode();
            return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    /// <summary>
    ///     Gpc Void Message.
    ///     the vold param or returns.
    /// </summary>
    public sealed partial class GpcVoid : pb::IMessage<GpcVoid>
    {
        private static readonly pb::MessageParser<GpcVoid> _parser =
            new pb::MessageParser<GpcVoid>(() => new GpcVoid());

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public GpcVoid()
        {
            OnConstruction();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public GpcVoid(GpcVoid other) : this()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<GpcVoid> Parser
        {
            get { return _parser; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::Org.OkraAx.V3.GpcReflection.Descriptor.MessageTypes[1]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public GpcVoid Clone()
        {
            return new GpcVoid(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(GpcVoid other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            return true;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize()
        {
            var size = 0;
            return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(GpcVoid other)
        {
            if (other == null)
            {
                return;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                }
            }
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other)
        {
            return Equals(other as GpcVoid);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode()
        {
            var hash = 1;
            return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    /// <summary>
    ///     Gpc relay message.
    ///     GpcRelay message use to forward the message data to other target without any logic.
    /// </summary>
    public sealed partial class GpcRelay : pb::IMessage<GpcRelay>
    {
        /// <summary>Field number for the "source" field.</summary>
        public const int SourceFieldNumber = 1;

        /// <summary>Field number for the "data" field.</summary>
        public const int DataFieldNumber = 2;

        private static readonly pb::MessageParser<GpcRelay> _parser =
            new pb::MessageParser<GpcRelay>(() => new GpcRelay());

        private pb::ByteString data_ = pb::ByteString.Empty;
        private global::Org.OkraAx.V3.AxAny source_;

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public GpcRelay()
        {
            OnConstruction();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public GpcRelay(GpcRelay other) : this()
        {
            Source = other.source_ != null ? other.Source.Clone() : null;
            data_ = other.data_;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<GpcRelay> Parser
        {
            get { return _parser; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::Org.OkraAx.V3.GpcReflection.Descriptor.MessageTypes[2]; }
        }

        /// <summary>
        ///     the forward target.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::Org.OkraAx.V3.AxAny Source
        {
            get { return source_; }
            set { source_ = value; }
        }

        /// <summary>
        ///     the relay message.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pb::ByteString Data
        {
            get { return data_; }
            set { data_ = pb::ProtoPreconditions.CheckNotNull(value, "value"); }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public GpcRelay Clone()
        {
            return new GpcRelay(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(GpcRelay other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!Equals(Source, other.Source)) return false;
            if (Data != other.Data) return false;
            return true;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output)
        {
            if (source_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(Source);
            }
            if (Data.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteBytes(Data);
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize()
        {
            var size = 0;
            if (source_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(Source);
            }
            if (Data.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeBytesSize(Data);
            }
            return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(GpcRelay other)
        {
            if (other == null)
            {
                return;
            }
            if (other.source_ != null)
            {
                if (source_ == null)
                {
                    source_ = new global::Org.OkraAx.V3.AxAny();
                }
                Source.MergeFrom(other.Source);
            }
            if (other.Data.Length != 0)
            {
                Data = other.Data;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 10:
                    {
                        if (source_ == null)
                        {
                            source_ = new global::Org.OkraAx.V3.AxAny();
                        }
                        input.ReadMessage(source_);
                        break;
                    }
                    case 18:
                    {
                        Data = input.ReadBytes();
                        break;
                    }
                }
            }
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other)
        {
            return Equals(other as GpcRelay);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode()
        {
            var hash = 1;
            if (source_ != null) hash ^= Source.GetHashCode();
            if (Data.Length != 0) hash ^= Data.GetHashCode();
            return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    /// <summary>
    ///     Gpc Error Message.
    ///     the normal error message callback by remote service.
    /// </summary>
    public sealed partial class GpcError : pb::IMessage<GpcError>
    {
        /// <summary>Field number for the "state" field.</summary>
        public const int StateFieldNumber = 1;

        /// <summary>Field number for the "msg" field.</summary>
        public const int MsgFieldNumber = 2;

        private static readonly pb::MessageParser<GpcError> _parser =
            new pb::MessageParser<GpcError>(() => new GpcError());

        private string msg_ = "";
        private int state_;

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public GpcError()
        {
            OnConstruction();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public GpcError(GpcError other) : this()
        {
            state_ = other.state_;
            msg_ = other.msg_;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<GpcError> Parser
        {
            get { return _parser; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::Org.OkraAx.V3.GpcReflection.Descriptor.MessageTypes[3]; }
        }

        /// <summary>
        ///     error code
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int State
        {
            get { return state_; }
            set { state_ = value; }
        }

        /// <summary>
        ///     response special error message. [Nullable].
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Msg
        {
            get { return msg_; }
            set { msg_ = pb::ProtoPreconditions.CheckNotNull(value, "value"); }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public GpcError Clone()
        {
            return new GpcError(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(GpcError other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (State != other.State) return false;
            if (Msg != other.Msg) return false;
            return true;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output)
        {
            if (State != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(State);
            }
            if (Msg.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(Msg);
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize()
        {
            var size = 0;
            if (State != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(State);
            }
            if (Msg.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(Msg);
            }
            return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(GpcError other)
        {
            if (other == null)
            {
                return;
            }
            if (other.State != 0)
            {
                State = other.State;
            }
            if (other.Msg.Length != 0)
            {
                Msg = other.Msg;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                    {
                        State = input.ReadInt32();
                        break;
                    }
                    case 18:
                    {
                        Msg = input.ReadString();
                        break;
                    }
                }
            }
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other)
        {
            return Equals(other as GpcError);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode()
        {
            var hash = 1;
            if (State != 0) hash ^= State.GetHashCode();
            if (Msg.Length != 0) hash ^= Msg.GetHashCode();
            return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    #endregion
}

#endregion Designer generated code