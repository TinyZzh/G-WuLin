// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: AxAny.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Org.OkraAx.V3 {

  /// <summary>Holder for reflection information generated from AxAny.proto</summary>
  public static partial class AxAnyReflection {

    #region Descriptor
    /// <summary>File descriptor for AxAny.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AxAnyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgtBeEFueS5wcm90bxINb3JnLm9rcmFBeC52MyIjCgVBeEFueRILCgNrZXkY",
            "ASABKAMSDQoFdmFsdWUYAiABKAxCGwoNb3JnLm9rcmFBeC52M0IKQXhBbnlQ",
            "cm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Org.OkraAx.V3.AxAny), global::Org.OkraAx.V3.AxAny.Parser, new[]{ "Key", "Value" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///
  ///   See {@link google.protobuf.Any}.
  ///   the message full name's hash code is the message default unique id.
  ///   and you can obviously specify the message unique id by {@link org.okraAx.v3.AxOptions#messageId} option.
  ///   &lt;pre>
  ///   Example for Java :
  ///       Foo foo = ....;
  ///       AxAny any = AxAnyUtil.pack(foo);
  ///       Foo foo = AxAnyUtil.unpack(any, Foo.class);
  ///   &lt;/pre>
  /// </summary>
  public sealed partial class AxAny : pb::IMessage<AxAny> {
    private static readonly pb::MessageParser<AxAny> _parser = new pb::MessageParser<AxAny>(() => new AxAny());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AxAny> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Org.OkraAx.V3.AxAnyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AxAny() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AxAny(AxAny other) : this() {
      key_ = other.key_;
      value_ = other.value_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AxAny Clone() {
      return new AxAny(this);
    }

    /// <summary>Field number for the "key" field.</summary>
    public const int KeyFieldNumber = 1;
    private long key_;
    /// <summary>
    ///   Target message's id. this value should be different to other message's id.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Key {
      get { return key_; }
      set {
        key_ = value;
      }
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 2;
    private pb::ByteString value_ = pb::ByteString.Empty;
    /// <summary>
    ///   Must be a valid serialized protocol buffer of the above specified type.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Value {
      get { return value_; }
      set {
        value_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AxAny);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AxAny other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Key != other.Key) return false;
      if (Value != other.Value) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Key != 0L) hash ^= Key.GetHashCode();
      if (Value.Length != 0) hash ^= Value.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Key != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Key);
      }
      if (Value.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(Value);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Key != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Key);
      }
      if (Value.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Value);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AxAny other) {
      if (other == null) {
        return;
      }
      if (other.Key != 0L) {
        Key = other.Key;
      }
      if (other.Value.Length != 0) {
        Value = other.Value;
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
            Key = input.ReadInt64();
            break;
          }
          case 18: {
            Value = input.ReadBytes();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code