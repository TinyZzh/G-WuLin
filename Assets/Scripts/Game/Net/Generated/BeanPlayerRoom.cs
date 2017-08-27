// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: BeanPlayerRoom.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Okra.Gpb.Generated {

  /// <summary>Holder for reflection information generated from BeanPlayerRoom.proto</summary>
  public static partial class BeanPlayerRoomReflection {

    #region Descriptor
    /// <summary>File descriptor for BeanPlayerRoom.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BeanPlayerRoomReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRCZWFuUGxheWVyUm9vbS5wcm90bxINb3JnLm9rcmFBeC52MxoLQXhBbnku",
            "cHJvdG8iLgoNUG1PbkVudGVyUm9vbRIOCgZyb29tSWQYASABKAMSDQoFaW5k",
            "ZXgYAiABKAUiHgoMUG1PbkV4aXRSb29tEg4KBnJvb21JZBgBIAEoAyJ4CghQ",
            "bU9uQ2hhdBIPCgdjaGFubmVsGAEgASgFEg4KBnJvb21JZBgCIAEoAxIPCgdt",
            "ZXNzYWdlGAMgASgJEgwKBGZyb20YBCABKAMSEAoIZnJvbU5hbWUYBSABKAkS",
            "CgoCdG8YBiABKAMSDgoGdG9OYW1lGAcgASgJQkcKG29yZy5va3JhQXgudjMu",
            "YmVhbnMucm9vbVB1YkIPR3BjQm5QbGF5ZXJSb29tSAFQAaoCEk9rcmEuR3Bi",
            "LkdlbmVyYXRlZGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Org.OkraAx.V3.AxAnyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Okra.Gpb.Generated.PmOnEnterRoom), global::Okra.Gpb.Generated.PmOnEnterRoom.Parser, new[]{ "RoomId", "Index" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Okra.Gpb.Generated.PmOnExitRoom), global::Okra.Gpb.Generated.PmOnExitRoom.Parser, new[]{ "RoomId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Okra.Gpb.Generated.PmOnChat), global::Okra.Gpb.Generated.PmOnChat.Parser, new[]{ "Channel", "RoomId", "Message", "From", "FromName", "To", "ToName" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///   RoomPublicService#onEnterRoom
  /// </summary>
  public sealed partial class PmOnEnterRoom : pb::IMessage<PmOnEnterRoom> {
    private static readonly pb::MessageParser<PmOnEnterRoom> _parser = new pb::MessageParser<PmOnEnterRoom>(() => new PmOnEnterRoom());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PmOnEnterRoom> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Okra.Gpb.Generated.BeanPlayerRoomReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PmOnEnterRoom() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PmOnEnterRoom(PmOnEnterRoom other) : this() {
      roomId_ = other.roomId_;
      index_ = other.index_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PmOnEnterRoom Clone() {
      return new PmOnEnterRoom(this);
    }

    /// <summary>Field number for the "roomId" field.</summary>
    public const int RoomIdFieldNumber = 1;
    private long roomId_;
    /// <summary>
    ///   房间ID
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long RoomId {
      get { return roomId_; }
      set {
        roomId_ = value;
      }
    }

    /// <summary>Field number for the "index" field.</summary>
    public const int IndexFieldNumber = 2;
    private int index_;
    /// <summary>
    ///   指定位置
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Index {
      get { return index_; }
      set {
        index_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PmOnEnterRoom);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PmOnEnterRoom other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RoomId != other.RoomId) return false;
      if (Index != other.Index) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (RoomId != 0L) hash ^= RoomId.GetHashCode();
      if (Index != 0) hash ^= Index.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (RoomId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(RoomId);
      }
      if (Index != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Index);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (RoomId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(RoomId);
      }
      if (Index != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Index);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PmOnEnterRoom other) {
      if (other == null) {
        return;
      }
      if (other.RoomId != 0L) {
        RoomId = other.RoomId;
      }
      if (other.Index != 0) {
        Index = other.Index;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            RoomId = input.ReadInt64();
            break;
          }
          case 16: {
            Index = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///   RoomPublicService#onExitRoom
  /// </summary>
  public sealed partial class PmOnExitRoom : pb::IMessage<PmOnExitRoom> {
    private static readonly pb::MessageParser<PmOnExitRoom> _parser = new pb::MessageParser<PmOnExitRoom>(() => new PmOnExitRoom());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PmOnExitRoom> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Okra.Gpb.Generated.BeanPlayerRoomReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PmOnExitRoom() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PmOnExitRoom(PmOnExitRoom other) : this() {
      roomId_ = other.roomId_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PmOnExitRoom Clone() {
      return new PmOnExitRoom(this);
    }

    /// <summary>Field number for the "roomId" field.</summary>
    public const int RoomIdFieldNumber = 1;
    private long roomId_;
    /// <summary>
    ///   房间ID
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long RoomId {
      get { return roomId_; }
      set {
        roomId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PmOnExitRoom);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PmOnExitRoom other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RoomId != other.RoomId) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (RoomId != 0L) hash ^= RoomId.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (RoomId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(RoomId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (RoomId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(RoomId);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PmOnExitRoom other) {
      if (other == null) {
        return;
      }
      if (other.RoomId != 0L) {
        RoomId = other.RoomId;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            RoomId = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///   RoomPublicService#onChat
  /// </summary>
  public sealed partial class PmOnChat : pb::IMessage<PmOnChat> {
    private static readonly pb::MessageParser<PmOnChat> _parser = new pb::MessageParser<PmOnChat>(() => new PmOnChat());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PmOnChat> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Okra.Gpb.Generated.BeanPlayerRoomReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PmOnChat() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PmOnChat(PmOnChat other) : this() {
      channel_ = other.channel_;
      roomId_ = other.roomId_;
      message_ = other.message_;
      from_ = other.from_;
      fromName_ = other.fromName_;
      to_ = other.to_;
      toName_ = other.toName_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PmOnChat Clone() {
      return new PmOnChat(this);
    }

    /// <summary>Field number for the "channel" field.</summary>
    public const int ChannelFieldNumber = 1;
    private int channel_;
    /// <summary>
    ///   聊天频道
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Channel {
      get { return channel_; }
      set {
        channel_ = value;
      }
    }

    /// <summary>Field number for the "roomId" field.</summary>
    public const int RoomIdFieldNumber = 2;
    private long roomId_;
    /// <summary>
    ///   房间ID
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long RoomId {
      get { return roomId_; }
      set {
        roomId_ = value;
      }
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 3;
    private string message_ = "";
    /// <summary>
    ///   聊天内容
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "from" field.</summary>
    public const int FromFieldNumber = 4;
    private long from_;
    /// <summary>
    ///   发送人
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long From {
      get { return from_; }
      set {
        from_ = value;
      }
    }

    /// <summary>Field number for the "fromName" field.</summary>
    public const int FromNameFieldNumber = 5;
    private string fromName_ = "";
    /// <summary>
    ///   发送人名称
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FromName {
      get { return fromName_; }
      set {
        fromName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "to" field.</summary>
    public const int ToFieldNumber = 6;
    private long to_;
    /// <summary>
    ///   收信人
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long To {
      get { return to_; }
      set {
        to_ = value;
      }
    }

    /// <summary>Field number for the "toName" field.</summary>
    public const int ToNameFieldNumber = 7;
    private string toName_ = "";
    /// <summary>
    ///   收信人名称
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ToName {
      get { return toName_; }
      set {
        toName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PmOnChat);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PmOnChat other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Channel != other.Channel) return false;
      if (RoomId != other.RoomId) return false;
      if (Message != other.Message) return false;
      if (From != other.From) return false;
      if (FromName != other.FromName) return false;
      if (To != other.To) return false;
      if (ToName != other.ToName) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Channel != 0) hash ^= Channel.GetHashCode();
      if (RoomId != 0L) hash ^= RoomId.GetHashCode();
      if (Message.Length != 0) hash ^= Message.GetHashCode();
      if (From != 0L) hash ^= From.GetHashCode();
      if (FromName.Length != 0) hash ^= FromName.GetHashCode();
      if (To != 0L) hash ^= To.GetHashCode();
      if (ToName.Length != 0) hash ^= ToName.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Channel != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Channel);
      }
      if (RoomId != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(RoomId);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Message);
      }
      if (From != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(From);
      }
      if (FromName.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(FromName);
      }
      if (To != 0L) {
        output.WriteRawTag(48);
        output.WriteInt64(To);
      }
      if (ToName.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(ToName);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Channel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Channel);
      }
      if (RoomId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(RoomId);
      }
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (From != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(From);
      }
      if (FromName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FromName);
      }
      if (To != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(To);
      }
      if (ToName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ToName);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PmOnChat other) {
      if (other == null) {
        return;
      }
      if (other.Channel != 0) {
        Channel = other.Channel;
      }
      if (other.RoomId != 0L) {
        RoomId = other.RoomId;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
      }
      if (other.From != 0L) {
        From = other.From;
      }
      if (other.FromName.Length != 0) {
        FromName = other.FromName;
      }
      if (other.To != 0L) {
        To = other.To;
      }
      if (other.ToName.Length != 0) {
        ToName = other.ToName;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Channel = input.ReadInt32();
            break;
          }
          case 16: {
            RoomId = input.ReadInt64();
            break;
          }
          case 26: {
            Message = input.ReadString();
            break;
          }
          case 32: {
            From = input.ReadInt64();
            break;
          }
          case 42: {
            FromName = input.ReadString();
            break;
          }
          case 48: {
            To = input.ReadInt64();
            break;
          }
          case 58: {
            ToName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
