// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: LoginBeans.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Org.OkraAx.V3 {

  /// <summary>Holder for reflection information generated from LoginBeans.proto</summary>
  public static partial class LoginBeansReflection {

    #region Descriptor
    /// <summary>File descriptor for LoginBeans.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LoginBeansReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBMb2dpbkJlYW5zLnByb3RvEg1vcmcub2tyYUF4LnYzIj4KDkNyZWF0ZVJv",
            "bGVCZWFuEg4KBm9wZW5JZBgBIAEoCRIMCgRuYW1lGAIgASgJEg4KBmZpZ3Vy",
            "ZRgDIAEoBSIbCglMb2dpbkJlYW4SDgoGb3BlbklkGAEgASgJIhYKB1JldEJl",
            "YW4SCwoDcmV0GAEgASgFQi4KGW9yZy5va3JhQXgudjMubG9naW4uYmVhbnNC",
            "DVByb0xvZ2luQmVhbnNIAVABYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Org.OkraAx.V3.CreateRoleBean), global::Org.OkraAx.V3.CreateRoleBean.Parser, new[]{ "OpenId", "Name", "Figure" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Org.OkraAx.V3.LoginBean), global::Org.OkraAx.V3.LoginBean.Parser, new[]{ "OpenId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Org.OkraAx.V3.RetBean), global::Org.OkraAx.V3.RetBean.Parser, new[]{ "Ret" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///   创建角色
  /// </summary>
  public sealed partial class CreateRoleBean : pb::IMessage<CreateRoleBean> {
    private static readonly pb::MessageParser<CreateRoleBean> _parser = new pb::MessageParser<CreateRoleBean>(() => new CreateRoleBean());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CreateRoleBean> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Org.OkraAx.V3.LoginBeansReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CreateRoleBean() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CreateRoleBean(CreateRoleBean other) : this() {
      openId_ = other.openId_;
      name_ = other.name_;
      figure_ = other.figure_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CreateRoleBean Clone() {
      return new CreateRoleBean(this);
    }

    /// <summary>Field number for the "openId" field.</summary>
    public const int OpenIdFieldNumber = 1;
    private string openId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string OpenId {
      get { return openId_; }
      set {
        openId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
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

    /// <summary>Field number for the "figure" field.</summary>
    public const int FigureFieldNumber = 3;
    private int figure_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Figure {
      get { return figure_; }
      set {
        figure_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CreateRoleBean);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CreateRoleBean other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OpenId != other.OpenId) return false;
      if (Name != other.Name) return false;
      if (Figure != other.Figure) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (OpenId.Length != 0) hash ^= OpenId.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Figure != 0) hash ^= Figure.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (OpenId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(OpenId);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (Figure != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Figure);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (OpenId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OpenId);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Figure != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Figure);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CreateRoleBean other) {
      if (other == null) {
        return;
      }
      if (other.OpenId.Length != 0) {
        OpenId = other.OpenId;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Figure != 0) {
        Figure = other.Figure;
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
            OpenId = input.ReadString();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 24: {
            Figure = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class LoginBean : pb::IMessage<LoginBean> {
    private static readonly pb::MessageParser<LoginBean> _parser = new pb::MessageParser<LoginBean>(() => new LoginBean());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LoginBean> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Org.OkraAx.V3.LoginBeansReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LoginBean() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LoginBean(LoginBean other) : this() {
      openId_ = other.openId_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LoginBean Clone() {
      return new LoginBean(this);
    }

    /// <summary>Field number for the "openId" field.</summary>
    public const int OpenIdFieldNumber = 1;
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
      return Equals(other as LoginBean);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LoginBean other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OpenId != other.OpenId) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (OpenId.Length != 0) hash ^= OpenId.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (OpenId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(OpenId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (OpenId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OpenId);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(LoginBean other) {
      if (other == null) {
        return;
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
          case 10: {
            OpenId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///   callback
  ///   Simple callback bean
  /// </summary>
  public sealed partial class RetBean : pb::IMessage<RetBean> {
    private static readonly pb::MessageParser<RetBean> _parser = new pb::MessageParser<RetBean>(() => new RetBean());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RetBean> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Org.OkraAx.V3.LoginBeansReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RetBean() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RetBean(RetBean other) : this() {
      ret_ = other.ret_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RetBean Clone() {
      return new RetBean(this);
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
      return Equals(other as RetBean);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RetBean other) {
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
    public void MergeFrom(RetBean other) {
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

  #endregion

}

#endregion Designer generated code
