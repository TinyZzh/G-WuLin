// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: protoc/include/google/protobuf/wrappers.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Protobuf.WellKnownTypes {

  /// <summary>Holder for reflection information generated from protoc/include/google/protobuf/wrappers.proto</summary>
  public static partial class WrappersReflection {

    #region Descriptor
    /// <summary>File descriptor for protoc/include/google/protobuf/wrappers.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WrappersReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1wcm90b2MvaW5jbHVkZS9nb29nbGUvcHJvdG9idWYvd3JhcHBlcnMucHJv",
            "dG8SD2dvb2dsZS5wcm90b2J1ZiIcCgtEb3VibGVWYWx1ZRINCgV2YWx1ZRgB",
            "IAEoASIbCgpGbG9hdFZhbHVlEg0KBXZhbHVlGAEgASgCIhsKCkludDY0VmFs",
            "dWUSDQoFdmFsdWUYASABKAMiHAoLVUludDY0VmFsdWUSDQoFdmFsdWUYASAB",
            "KAQiGwoKSW50MzJWYWx1ZRINCgV2YWx1ZRgBIAEoBSIcCgtVSW50MzJWYWx1",
            "ZRINCgV2YWx1ZRgBIAEoDSIaCglCb29sVmFsdWUSDQoFdmFsdWUYASABKAgi",
            "HAoLU3RyaW5nVmFsdWUSDQoFdmFsdWUYASABKAkiGwoKQnl0ZXNWYWx1ZRIN",
            "CgV2YWx1ZRgBIAEoDEJ8ChNjb20uZ29vZ2xlLnByb3RvYnVmQg1XcmFwcGVy",
            "c1Byb3RvUAFaKmdpdGh1Yi5jb20vZ29sYW5nL3Byb3RvYnVmL3B0eXBlcy93",
            "cmFwcGVyc/gBAaICA0dQQqoCHkdvb2dsZS5Qcm90b2J1Zi5XZWxsS25vd25U",
            "eXBlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Protobuf.WellKnownTypes.DoubleValue), global::Google.Protobuf.WellKnownTypes.DoubleValue.Parser, new[]{ "Value" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Protobuf.WellKnownTypes.FloatValue), global::Google.Protobuf.WellKnownTypes.FloatValue.Parser, new[]{ "Value" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Protobuf.WellKnownTypes.Int64Value), global::Google.Protobuf.WellKnownTypes.Int64Value.Parser, new[]{ "Value" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Protobuf.WellKnownTypes.UInt64Value), global::Google.Protobuf.WellKnownTypes.UInt64Value.Parser, new[]{ "Value" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Protobuf.WellKnownTypes.Int32Value), global::Google.Protobuf.WellKnownTypes.Int32Value.Parser, new[]{ "Value" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Protobuf.WellKnownTypes.UInt32Value), global::Google.Protobuf.WellKnownTypes.UInt32Value.Parser, new[]{ "Value" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Protobuf.WellKnownTypes.BoolValue), global::Google.Protobuf.WellKnownTypes.BoolValue.Parser, new[]{ "Value" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Protobuf.WellKnownTypes.StringValue), global::Google.Protobuf.WellKnownTypes.StringValue.Parser, new[]{ "Value" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Protobuf.WellKnownTypes.BytesValue), global::Google.Protobuf.WellKnownTypes.BytesValue.Parser, new[]{ "Value" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///  Wrapper message for `double`.
  ///
  ///  The JSON representation for `DoubleValue` is JSON number.
  /// </summary>
  public sealed partial class DoubleValue : pb::IMessage<DoubleValue> {
    private static readonly pb::MessageParser<DoubleValue> _parser = new pb::MessageParser<DoubleValue>(() => new DoubleValue());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DoubleValue> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DoubleValue() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DoubleValue(DoubleValue other) : this() {
      value_ = other.value_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DoubleValue Clone() {
      return new DoubleValue(this);
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 1;
    private double value_;
    /// <summary>
    ///  The double value.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Value {
      get { return value_; }
      set {
        value_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DoubleValue);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DoubleValue other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Value != other.Value) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Value != 0D) hash ^= Value.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Value != 0D) {
        output.WriteRawTag(9);
        output.WriteDouble(Value);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Value != 0D) {
        size += 1 + 8;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DoubleValue other) {
      if (other == null) {
        return;
      }
      if (other.Value != 0D) {
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
          case 9: {
            Value = input.ReadDouble();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  Wrapper message for `float`.
  ///
  ///  The JSON representation for `FloatValue` is JSON number.
  /// </summary>
  public sealed partial class FloatValue : pb::IMessage<FloatValue> {
    private static readonly pb::MessageParser<FloatValue> _parser = new pb::MessageParser<FloatValue>(() => new FloatValue());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FloatValue> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FloatValue() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FloatValue(FloatValue other) : this() {
      value_ = other.value_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FloatValue Clone() {
      return new FloatValue(this);
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 1;
    private float value_;
    /// <summary>
    ///  The float value.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Value {
      get { return value_; }
      set {
        value_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FloatValue);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FloatValue other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Value != other.Value) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Value != 0F) hash ^= Value.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Value != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(Value);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Value != 0F) {
        size += 1 + 4;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FloatValue other) {
      if (other == null) {
        return;
      }
      if (other.Value != 0F) {
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
          case 13: {
            Value = input.ReadFloat();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  Wrapper message for `int64`.
  ///
  ///  The JSON representation for `Int64Value` is JSON string.
  /// </summary>
  public sealed partial class Int64Value : pb::IMessage<Int64Value> {
    private static readonly pb::MessageParser<Int64Value> _parser = new pb::MessageParser<Int64Value>(() => new Int64Value());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Int64Value> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Int64Value() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Int64Value(Int64Value other) : this() {
      value_ = other.value_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Int64Value Clone() {
      return new Int64Value(this);
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 1;
    private long value_;
    /// <summary>
    ///  The int64 value.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Value {
      get { return value_; }
      set {
        value_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Int64Value);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Int64Value other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Value != other.Value) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Value != 0L) hash ^= Value.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Value != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Value);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Value != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Value);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Int64Value other) {
      if (other == null) {
        return;
      }
      if (other.Value != 0L) {
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
            Value = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  Wrapper message for `uint64`.
  ///
  ///  The JSON representation for `UInt64Value` is JSON string.
  /// </summary>
  public sealed partial class UInt64Value : pb::IMessage<UInt64Value> {
    private static readonly pb::MessageParser<UInt64Value> _parser = new pb::MessageParser<UInt64Value>(() => new UInt64Value());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UInt64Value> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UInt64Value() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UInt64Value(UInt64Value other) : this() {
      value_ = other.value_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UInt64Value Clone() {
      return new UInt64Value(this);
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 1;
    private ulong value_;
    /// <summary>
    ///  The uint64 value.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong Value {
      get { return value_; }
      set {
        value_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UInt64Value);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UInt64Value other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Value != other.Value) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Value != 0UL) hash ^= Value.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Value != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(Value);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Value != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Value);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UInt64Value other) {
      if (other == null) {
        return;
      }
      if (other.Value != 0UL) {
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
            Value = input.ReadUInt64();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  Wrapper message for `int32`.
  ///
  ///  The JSON representation for `Int32Value` is JSON number.
  /// </summary>
  public sealed partial class Int32Value : pb::IMessage<Int32Value> {
    private static readonly pb::MessageParser<Int32Value> _parser = new pb::MessageParser<Int32Value>(() => new Int32Value());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Int32Value> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Int32Value() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Int32Value(Int32Value other) : this() {
      value_ = other.value_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Int32Value Clone() {
      return new Int32Value(this);
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 1;
    private int value_;
    /// <summary>
    ///  The int32 value.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Value {
      get { return value_; }
      set {
        value_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Int32Value);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Int32Value other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Value != other.Value) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Value != 0) hash ^= Value.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Value != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Value);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Value != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Value);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Int32Value other) {
      if (other == null) {
        return;
      }
      if (other.Value != 0) {
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
            Value = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  Wrapper message for `uint32`.
  ///
  ///  The JSON representation for `UInt32Value` is JSON number.
  /// </summary>
  public sealed partial class UInt32Value : pb::IMessage<UInt32Value> {
    private static readonly pb::MessageParser<UInt32Value> _parser = new pb::MessageParser<UInt32Value>(() => new UInt32Value());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UInt32Value> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UInt32Value() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UInt32Value(UInt32Value other) : this() {
      value_ = other.value_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UInt32Value Clone() {
      return new UInt32Value(this);
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 1;
    private uint value_;
    /// <summary>
    ///  The uint32 value.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Value {
      get { return value_; }
      set {
        value_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UInt32Value);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UInt32Value other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Value != other.Value) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Value != 0) hash ^= Value.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Value != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Value);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Value != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Value);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UInt32Value other) {
      if (other == null) {
        return;
      }
      if (other.Value != 0) {
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
            Value = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  Wrapper message for `bool`.
  ///
  ///  The JSON representation for `BoolValue` is JSON `true` and `false`.
  /// </summary>
  public sealed partial class BoolValue : pb::IMessage<BoolValue> {
    private static readonly pb::MessageParser<BoolValue> _parser = new pb::MessageParser<BoolValue>(() => new BoolValue());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BoolValue> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor.MessageTypes[6]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BoolValue() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BoolValue(BoolValue other) : this() {
      value_ = other.value_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BoolValue Clone() {
      return new BoolValue(this);
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 1;
    private bool value_;
    /// <summary>
    ///  The bool value.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Value {
      get { return value_; }
      set {
        value_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BoolValue);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BoolValue other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Value != other.Value) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Value != false) hash ^= Value.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Value != false) {
        output.WriteRawTag(8);
        output.WriteBool(Value);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Value != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BoolValue other) {
      if (other == null) {
        return;
      }
      if (other.Value != false) {
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
            Value = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  Wrapper message for `string`.
  ///
  ///  The JSON representation for `StringValue` is JSON string.
  /// </summary>
  public sealed partial class StringValue : pb::IMessage<StringValue> {
    private static readonly pb::MessageParser<StringValue> _parser = new pb::MessageParser<StringValue>(() => new StringValue());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<StringValue> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor.MessageTypes[7]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StringValue() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StringValue(StringValue other) : this() {
      value_ = other.value_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StringValue Clone() {
      return new StringValue(this);
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 1;
    private string value_ = "";
    /// <summary>
    ///  The string value.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Value {
      get { return value_; }
      set {
        value_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as StringValue);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(StringValue other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Value != other.Value) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Value.Length != 0) hash ^= Value.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Value.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Value);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Value.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Value);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(StringValue other) {
      if (other == null) {
        return;
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
          case 10: {
            Value = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  Wrapper message for `bytes`.
  ///
  ///  The JSON representation for `BytesValue` is JSON string.
  /// </summary>
  public sealed partial class BytesValue : pb::IMessage<BytesValue> {
    private static readonly pb::MessageParser<BytesValue> _parser = new pb::MessageParser<BytesValue>(() => new BytesValue());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BytesValue> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor.MessageTypes[8]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BytesValue() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BytesValue(BytesValue other) : this() {
      value_ = other.value_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BytesValue Clone() {
      return new BytesValue(this);
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 1;
    private pb::ByteString value_ = pb::ByteString.Empty;
    /// <summary>
    ///  The bytes value.
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
      return Equals(other as BytesValue);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BytesValue other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Value != other.Value) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Value.Length != 0) hash ^= Value.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Value.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(Value);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Value.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Value);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BytesValue other) {
      if (other == null) {
        return;
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
          case 10: {
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
