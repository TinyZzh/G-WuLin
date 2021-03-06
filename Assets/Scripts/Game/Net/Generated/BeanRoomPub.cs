// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: BeanRoomPub.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Org.OkraAx.V3 {

  /// <summary>Holder for reflection information generated from BeanRoomPub.proto</summary>
  public static partial class BeanRoomPubReflection {

    #region Descriptor
    /// <summary>File descriptor for BeanRoomPub.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BeanRoomPubReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFCZWFuUm9vbVB1Yi5wcm90bxINb3JnLm9rcmFBeC52MxoLQXhBbnkucHJv",
            "dG8iMwoSQXBpT25QbGF5ZXJDb25uZWN0EgsKA3VpZBgBIAEoAxIQCghzZWN1",
            "cml0eRgCIAEoAyJJCg5BcGlPbkVudGVyUm9vbRIOCgZyb29tSWQYASABKAUS",
            "DAoEc2VhdBgCIAEoBRILCgN1aWQYAyABKAMSDAoEbmFtZRgEIAEoCSIeCg1B",
            "cGlPbkdldFJlYWR5Eg0KBXJlYWR5GAEgASgIIkgKDkFwaU9uTW92ZUNoZXNz",
            "Eg0KBWZyb21YGAEgASgFEg0KBWZyb21ZGAIgASgFEgsKA3RvWBgDIAEoBRIL",
            "CgN0b1kYBCABKAUiMwoJQXBpT25DaGF0EiYKBGNoYXQYASABKAsyGC5vcmcu",
            "b2tyYUF4LnYzLk1zZ09uQ2hhdCJ9CglNc2dPbkNoYXQSDwoHY2hhbm5lbBgB",
            "IAEoBRIsCgRmcm9tGAIgASgLMh4ub3JnLm9rcmFBeC52My5Nc2dDaGF0VXNl",
            "ckluZm8SIAoCdG8YAyABKAsyFC5vcmcub2tyYUF4LnYzLkF4QW55Eg8KB2Nv",
            "bnRlbnQYBCABKAkiOAoPTXNnQ2hhdFVzZXJJbmZvEgsKA3VpZBgBIAEoAxIM",
            "CgRuYW1lGAIgASgJEgoKAmx2GAMgASgFQi8KG29yZy5va3JhQXgudjMuYmVh",
            "bnMucm9vbVB1YkIMR3BjQm5Sb29tUHViSAFQAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Org.OkraAx.V3.AxAnyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Org.OkraAx.V3.ApiOnPlayerConnect), global::Org.OkraAx.V3.ApiOnPlayerConnect.Parser, new[]{ "Uid", "Security" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Org.OkraAx.V3.ApiOnEnterRoom), global::Org.OkraAx.V3.ApiOnEnterRoom.Parser, new[]{ "RoomId", "Seat", "Uid", "Name" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Org.OkraAx.V3.ApiOnGetReady), global::Org.OkraAx.V3.ApiOnGetReady.Parser, new[]{ "Ready" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Org.OkraAx.V3.ApiOnMoveChess), global::Org.OkraAx.V3.ApiOnMoveChess.Parser, new[]{ "FromX", "FromY", "ToX", "ToY" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Org.OkraAx.V3.ApiOnChat), global::Org.OkraAx.V3.ApiOnChat.Parser, new[]{ "Chat" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Org.OkraAx.V3.MsgOnChat), global::Org.OkraAx.V3.MsgOnChat.Parser, new[]{ "Channel", "From", "To", "Content" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Org.OkraAx.V3.MsgChatUserInfo), global::Org.OkraAx.V3.MsgChatUserInfo.Parser, new[]{ "Uid", "Name", "Lv" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///    Service Beans
  ///   角色
  /// </summary>
  public sealed partial class ApiOnPlayerConnect : pb::IMessage<ApiOnPlayerConnect> {
    private static readonly pb::MessageParser<ApiOnPlayerConnect> _parser = new pb::MessageParser<ApiOnPlayerConnect>(() => new ApiOnPlayerConnect());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ApiOnPlayerConnect> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Org.OkraAx.V3.BeanRoomPubReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApiOnPlayerConnect() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApiOnPlayerConnect(ApiOnPlayerConnect other) : this() {
      uid_ = other.uid_;
      security_ = other.security_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApiOnPlayerConnect Clone() {
      return new ApiOnPlayerConnect(this);
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 1;
    private long uid_;
    /// <summary>
    ///   角色唯一ID
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    /// <summary>Field number for the "security" field.</summary>
    public const int SecurityFieldNumber = 2;
    private long security_;
    /// <summary>
    ///   秘钥
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Security {
      get { return security_; }
      set {
        security_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ApiOnPlayerConnect);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ApiOnPlayerConnect other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Uid != other.Uid) return false;
      if (Security != other.Security) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Uid != 0L) hash ^= Uid.GetHashCode();
      if (Security != 0L) hash ^= Security.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Uid != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Uid);
      }
      if (Security != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Security);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Uid != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Uid);
      }
      if (Security != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Security);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ApiOnPlayerConnect other) {
      if (other == null) {
        return;
      }
      if (other.Uid != 0L) {
        Uid = other.Uid;
      }
      if (other.Security != 0L) {
        Security = other.Security;
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
            Uid = input.ReadInt64();
            break;
          }
          case 16: {
            Security = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ApiOnEnterRoom : pb::IMessage<ApiOnEnterRoom> {
    private static readonly pb::MessageParser<ApiOnEnterRoom> _parser = new pb::MessageParser<ApiOnEnterRoom>(() => new ApiOnEnterRoom());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ApiOnEnterRoom> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Org.OkraAx.V3.BeanRoomPubReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApiOnEnterRoom() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApiOnEnterRoom(ApiOnEnterRoom other) : this() {
      roomId_ = other.roomId_;
      seat_ = other.seat_;
      uid_ = other.uid_;
      name_ = other.name_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApiOnEnterRoom Clone() {
      return new ApiOnEnterRoom(this);
    }

    /// <summary>Field number for the "roomId" field.</summary>
    public const int RoomIdFieldNumber = 1;
    private int roomId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int RoomId {
      get { return roomId_; }
      set {
        roomId_ = value;
      }
    }

    /// <summary>Field number for the "seat" field.</summary>
    public const int SeatFieldNumber = 2;
    private int seat_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Seat {
      get { return seat_; }
      set {
        seat_ = value;
      }
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 3;
    private long uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 4;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ApiOnEnterRoom);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ApiOnEnterRoom other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RoomId != other.RoomId) return false;
      if (Seat != other.Seat) return false;
      if (Uid != other.Uid) return false;
      if (Name != other.Name) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (RoomId != 0) hash ^= RoomId.GetHashCode();
      if (Seat != 0) hash ^= Seat.GetHashCode();
      if (Uid != 0L) hash ^= Uid.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (RoomId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(RoomId);
      }
      if (Seat != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Seat);
      }
      if (Uid != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(Uid);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Name);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (RoomId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(RoomId);
      }
      if (Seat != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Seat);
      }
      if (Uid != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Uid);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ApiOnEnterRoom other) {
      if (other == null) {
        return;
      }
      if (other.RoomId != 0) {
        RoomId = other.RoomId;
      }
      if (other.Seat != 0) {
        Seat = other.Seat;
      }
      if (other.Uid != 0L) {
        Uid = other.Uid;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
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
            RoomId = input.ReadInt32();
            break;
          }
          case 16: {
            Seat = input.ReadInt32();
            break;
          }
          case 24: {
            Uid = input.ReadInt64();
            break;
          }
          case 34: {
            Name = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ApiOnGetReady : pb::IMessage<ApiOnGetReady> {
    private static readonly pb::MessageParser<ApiOnGetReady> _parser = new pb::MessageParser<ApiOnGetReady>(() => new ApiOnGetReady());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ApiOnGetReady> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Org.OkraAx.V3.BeanRoomPubReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApiOnGetReady() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApiOnGetReady(ApiOnGetReady other) : this() {
      ready_ = other.ready_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApiOnGetReady Clone() {
      return new ApiOnGetReady(this);
    }

    /// <summary>Field number for the "ready" field.</summary>
    public const int ReadyFieldNumber = 1;
    private bool ready_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Ready {
      get { return ready_; }
      set {
        ready_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ApiOnGetReady);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ApiOnGetReady other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Ready != other.Ready) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Ready != false) hash ^= Ready.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Ready != false) {
        output.WriteRawTag(8);
        output.WriteBool(Ready);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Ready != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ApiOnGetReady other) {
      if (other == null) {
        return;
      }
      if (other.Ready != false) {
        Ready = other.Ready;
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
            Ready = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ApiOnMoveChess : pb::IMessage<ApiOnMoveChess> {
    private static readonly pb::MessageParser<ApiOnMoveChess> _parser = new pb::MessageParser<ApiOnMoveChess>(() => new ApiOnMoveChess());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ApiOnMoveChess> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Org.OkraAx.V3.BeanRoomPubReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApiOnMoveChess() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApiOnMoveChess(ApiOnMoveChess other) : this() {
      fromX_ = other.fromX_;
      fromY_ = other.fromY_;
      toX_ = other.toX_;
      toY_ = other.toY_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApiOnMoveChess Clone() {
      return new ApiOnMoveChess(this);
    }

    /// <summary>Field number for the "fromX" field.</summary>
    public const int FromXFieldNumber = 1;
    private int fromX_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int FromX {
      get { return fromX_; }
      set {
        fromX_ = value;
      }
    }

    /// <summary>Field number for the "fromY" field.</summary>
    public const int FromYFieldNumber = 2;
    private int fromY_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int FromY {
      get { return fromY_; }
      set {
        fromY_ = value;
      }
    }

    /// <summary>Field number for the "toX" field.</summary>
    public const int ToXFieldNumber = 3;
    private int toX_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ToX {
      get { return toX_; }
      set {
        toX_ = value;
      }
    }

    /// <summary>Field number for the "toY" field.</summary>
    public const int ToYFieldNumber = 4;
    private int toY_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ToY {
      get { return toY_; }
      set {
        toY_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ApiOnMoveChess);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ApiOnMoveChess other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FromX != other.FromX) return false;
      if (FromY != other.FromY) return false;
      if (ToX != other.ToX) return false;
      if (ToY != other.ToY) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (FromX != 0) hash ^= FromX.GetHashCode();
      if (FromY != 0) hash ^= FromY.GetHashCode();
      if (ToX != 0) hash ^= ToX.GetHashCode();
      if (ToY != 0) hash ^= ToY.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (FromX != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(FromX);
      }
      if (FromY != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(FromY);
      }
      if (ToX != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(ToX);
      }
      if (ToY != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(ToY);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (FromX != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(FromX);
      }
      if (FromY != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(FromY);
      }
      if (ToX != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ToX);
      }
      if (ToY != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ToY);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ApiOnMoveChess other) {
      if (other == null) {
        return;
      }
      if (other.FromX != 0) {
        FromX = other.FromX;
      }
      if (other.FromY != 0) {
        FromY = other.FromY;
      }
      if (other.ToX != 0) {
        ToX = other.ToX;
      }
      if (other.ToY != 0) {
        ToY = other.ToY;
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
            FromX = input.ReadInt32();
            break;
          }
          case 16: {
            FromY = input.ReadInt32();
            break;
          }
          case 24: {
            ToX = input.ReadInt32();
            break;
          }
          case 32: {
            ToY = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ApiOnChat : pb::IMessage<ApiOnChat> {
    private static readonly pb::MessageParser<ApiOnChat> _parser = new pb::MessageParser<ApiOnChat>(() => new ApiOnChat());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ApiOnChat> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Org.OkraAx.V3.BeanRoomPubReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApiOnChat() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApiOnChat(ApiOnChat other) : this() {
      Chat = other.chat_ != null ? other.Chat.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApiOnChat Clone() {
      return new ApiOnChat(this);
    }

    /// <summary>Field number for the "chat" field.</summary>
    public const int ChatFieldNumber = 1;
    private global::Org.OkraAx.V3.MsgOnChat chat_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Org.OkraAx.V3.MsgOnChat Chat {
      get { return chat_; }
      set {
        chat_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ApiOnChat);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ApiOnChat other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Chat, other.Chat)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (chat_ != null) hash ^= Chat.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (chat_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Chat);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (chat_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Chat);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ApiOnChat other) {
      if (other == null) {
        return;
      }
      if (other.chat_ != null) {
        if (chat_ == null) {
          chat_ = new global::Org.OkraAx.V3.MsgOnChat();
        }
        Chat.MergeFrom(other.Chat);
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
          case 10: {
            if (chat_ == null) {
              chat_ = new global::Org.OkraAx.V3.MsgOnChat();
            }
            input.ReadMessage(chat_);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// </summary>
  public sealed partial class MsgOnChat : pb::IMessage<MsgOnChat> {
    private static readonly pb::MessageParser<MsgOnChat> _parser = new pb::MessageParser<MsgOnChat>(() => new MsgOnChat());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MsgOnChat> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Org.OkraAx.V3.BeanRoomPubReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MsgOnChat() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MsgOnChat(MsgOnChat other) : this() {
      channel_ = other.channel_;
      From = other.from_ != null ? other.From.Clone() : null;
      To = other.to_ != null ? other.To.Clone() : null;
      content_ = other.content_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MsgOnChat Clone() {
      return new MsgOnChat(this);
    }

    /// <summary>Field number for the "channel" field.</summary>
    public const int ChannelFieldNumber = 1;
    private int channel_;
    /// <summary>
    ///    聊天频道 [0:综合  1:私聊  2:房间]
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Channel {
      get { return channel_; }
      set {
        channel_ = value;
      }
    }

    /// <summary>Field number for the "from" field.</summary>
    public const int FromFieldNumber = 2;
    private global::Org.OkraAx.V3.MsgChatUserInfo from_;
    /// <summary>
    ///    发送者
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Org.OkraAx.V3.MsgChatUserInfo From {
      get { return from_; }
      set {
        from_ = value;
      }
    }

    /// <summary>Field number for the "to" field.</summary>
    public const int ToFieldNumber = 3;
    private global::Org.OkraAx.V3.AxAny to_;
    /// <summary>
    ///  私聊收信者
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Org.OkraAx.V3.AxAny To {
      get { return to_; }
      set {
        to_ = value;
      }
    }

    /// <summary>Field number for the "content" field.</summary>
    public const int ContentFieldNumber = 4;
    private string content_ = "";
    /// <summary>
    ///    内容
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Content {
      get { return content_; }
      set {
        content_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MsgOnChat);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MsgOnChat other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Channel != other.Channel) return false;
      if (!object.Equals(From, other.From)) return false;
      if (!object.Equals(To, other.To)) return false;
      if (Content != other.Content) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Channel != 0) hash ^= Channel.GetHashCode();
      if (from_ != null) hash ^= From.GetHashCode();
      if (to_ != null) hash ^= To.GetHashCode();
      if (Content.Length != 0) hash ^= Content.GetHashCode();
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
      if (from_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(From);
      }
      if (to_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(To);
      }
      if (Content.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Content);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Channel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Channel);
      }
      if (from_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(From);
      }
      if (to_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(To);
      }
      if (Content.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Content);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MsgOnChat other) {
      if (other == null) {
        return;
      }
      if (other.Channel != 0) {
        Channel = other.Channel;
      }
      if (other.from_ != null) {
        if (from_ == null) {
          from_ = new global::Org.OkraAx.V3.MsgChatUserInfo();
        }
        From.MergeFrom(other.From);
      }
      if (other.to_ != null) {
        if (to_ == null) {
          to_ = new global::Org.OkraAx.V3.AxAny();
        }
        To.MergeFrom(other.To);
      }
      if (other.Content.Length != 0) {
        Content = other.Content;
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
          case 18: {
            if (from_ == null) {
              from_ = new global::Org.OkraAx.V3.MsgChatUserInfo();
            }
            input.ReadMessage(from_);
            break;
          }
          case 26: {
            if (to_ == null) {
              to_ = new global::Org.OkraAx.V3.AxAny();
            }
            input.ReadMessage(to_);
            break;
          }
          case 34: {
            Content = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///    聊天角色基本信息
  /// </summary>
  public sealed partial class MsgChatUserInfo : pb::IMessage<MsgChatUserInfo> {
    private static readonly pb::MessageParser<MsgChatUserInfo> _parser = new pb::MessageParser<MsgChatUserInfo>(() => new MsgChatUserInfo());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MsgChatUserInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Org.OkraAx.V3.BeanRoomPubReflection.Descriptor.MessageTypes[6]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MsgChatUserInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MsgChatUserInfo(MsgChatUserInfo other) : this() {
      uid_ = other.uid_;
      name_ = other.name_;
      lv_ = other.lv_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MsgChatUserInfo Clone() {
      return new MsgChatUserInfo(this);
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 1;
    private long uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "lv" field.</summary>
    public const int LvFieldNumber = 3;
    private int lv_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Lv {
      get { return lv_; }
      set {
        lv_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MsgChatUserInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MsgChatUserInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Uid != other.Uid) return false;
      if (Name != other.Name) return false;
      if (Lv != other.Lv) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Uid != 0L) hash ^= Uid.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Lv != 0) hash ^= Lv.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Uid != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Uid);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (Lv != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Lv);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Uid != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Uid);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Lv != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Lv);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MsgChatUserInfo other) {
      if (other == null) {
        return;
      }
      if (other.Uid != 0L) {
        Uid = other.Uid;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Lv != 0) {
        Lv = other.Lv;
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
            Uid = input.ReadInt64();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 24: {
            Lv = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
