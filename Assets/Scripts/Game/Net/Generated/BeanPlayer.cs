// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: BeanPlayer.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Org.OkraAx.V3 {

  /// <summary>Holder for reflection information generated from BeanPlayer.proto</summary>
  public static partial class BeanPlayerReflection {

    #region Descriptor
    /// <summary>File descriptor for BeanPlayer.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BeanPlayerReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBCZWFuUGxheWVyLnByb3RvEg1vcmcub2tyYUF4LnYzIiUKFkNhbGxiYWNr",
            "Q3JlYXRlUm9sZUJlYW4SCwoDcmV0GAEgASgFIjAKEUNhbGxiYWNrTG9naW5C",
            "ZWFuEgsKA3JldBgBIAEoBRIOCgZvcGVuSWQYAiABKAkiJQoQQ2FsbGJhY2tT",
            "eW5jVGltZRIRCgl0aW1lc3RhbXAYASABKANCLQoab3JnLm9rcmFBeC52My5i",
            "ZWFucy5wbGF5ZXJCC0dwY0JuUGxheWVySAFQAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Org.OkraAx.V3.CallbackCreateRoleBean), global::Org.OkraAx.V3.CallbackCreateRoleBean.Parser, new[]{ "Ret" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Org.OkraAx.V3.CallbackLoginBean), global::Org.OkraAx.V3.CallbackLoginBean.Parser, new[]{ "Ret", "OpenId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Org.OkraAx.V3.CallbackSyncTime), global::Org.OkraAx.V3.CallbackSyncTime.Parser, new[]{ "Timestamp" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///   创建角色
  /// </summary>
  public sealed partial class CallbackCreateRoleBean : pb::IMessage<CallbackCreateRoleBean> {
    private static readonly pb::MessageParser<CallbackCreateRoleBean> _parser = new pb::MessageParser<CallbackCreateRoleBean>(() => new CallbackCreateRoleBean());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CallbackCreateRoleBean> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Org.OkraAx.V3.BeanPlayerReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CallbackCreateRoleBean() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CallbackCreateRoleBean(CallbackCreateRoleBean other) : this() {
      ret_ = other.ret_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CallbackCreateRoleBean Clone() {
      return new CallbackCreateRoleBean(this);
    }

    /// <summary>Field number for the "ret" field.</summary>
    public const int RetFieldNumber = 1;
    private int ret_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Ret {
      get { return ret_; }
      set {
        ret_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CallbackCreateRoleBean);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CallbackCreateRoleBean other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Ret != other.Ret) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Ret != 0) hash ^= Ret.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Ret != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Ret);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Ret != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Ret);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CallbackCreateRoleBean other) {
      if (other == null) {
        return;
      }
      if (other.Ret != 0) {
        Ret = other.Ret;
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
            Ret = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// </summary>
  public sealed partial class CallbackLoginBean : pb::IMessage<CallbackLoginBean> {
    private static readonly pb::MessageParser<CallbackLoginBean> _parser = new pb::MessageParser<CallbackLoginBean>(() => new CallbackLoginBean());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CallbackLoginBean> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Org.OkraAx.V3.BeanPlayerReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CallbackLoginBean() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CallbackLoginBean(CallbackLoginBean other) : this() {
      ret_ = other.ret_;
      openId_ = other.openId_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CallbackLoginBean Clone() {
      return new CallbackLoginBean(this);
    }

    /// <summary>Field number for the "ret" field.</summary>
    public const int RetFieldNumber = 1;
    private int ret_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Ret {
      get { return ret_; }
      set {
        ret_ = value;
      }
    }

    /// <summary>Field number for the "openId" field.</summary>
    public const int OpenIdFieldNumber = 2;
    private string openId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string OpenId {
      get { return openId_; }
      set {
        openId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CallbackLoginBean);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CallbackLoginBean other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Ret != other.Ret) return false;
      if (OpenId != other.OpenId) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Ret != 0) hash ^= Ret.GetHashCode();
      if (OpenId.Length != 0) hash ^= OpenId.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Ret != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Ret);
      }
      if (OpenId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(OpenId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Ret != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Ret);
      }
      if (OpenId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OpenId);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CallbackLoginBean other) {
      if (other == null) {
        return;
      }
      if (other.Ret != 0) {
        Ret = other.Ret;
      }
      if (other.OpenId.Length != 0) {
        OpenId = other.OpenId;
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
            Ret = input.ReadInt32();
            break;
          }
          case 18: {
            OpenId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///   同步系统时间
  /// </summary>
  public sealed partial class CallbackSyncTime : pb::IMessage<CallbackSyncTime> {
    private static readonly pb::MessageParser<CallbackSyncTime> _parser = new pb::MessageParser<CallbackSyncTime>(() => new CallbackSyncTime());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CallbackSyncTime> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Org.OkraAx.V3.BeanPlayerReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CallbackSyncTime() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CallbackSyncTime(CallbackSyncTime other) : this() {
      timestamp_ = other.timestamp_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CallbackSyncTime Clone() {
      return new CallbackSyncTime(this);
    }

    /// <summary>Field number for the "timestamp" field.</summary>
    public const int TimestampFieldNumber = 1;
    private long timestamp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Timestamp {
      get { return timestamp_; }
      set {
        timestamp_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CallbackSyncTime);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CallbackSyncTime other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Timestamp != other.Timestamp) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Timestamp != 0L) hash ^= Timestamp.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Timestamp != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Timestamp);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Timestamp != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Timestamp);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CallbackSyncTime other) {
      if (other == null) {
        return;
      }
      if (other.Timestamp != 0L) {
        Timestamp = other.Timestamp;
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
            Timestamp = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code