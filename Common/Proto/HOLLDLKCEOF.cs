// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HOLLDLKCEOF.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from HOLLDLKCEOF.proto</summary>
  public static partial class HOLLDLKCEOFReflection {

    #region Descriptor
    /// <summary>File descriptor for HOLLDLKCEOF.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HOLLDLKCEOFReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFIT0xMRExLQ0VPRi5wcm90byJgCgtIT0xMRExLQ0VPRhITCgtlbGl0ZV9n",
            "cm91cBgOIAEoDRINCgVsZXZlbBgHIAEoDRITCgtPTk1NRE1DQUNNQhgNIAEo",
            "DRIYChBoYXJkX2xldmVsX2dyb3VwGA8gASgNQh6qAhtFZ2dMaW5rLkRhbmhl",
            "bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.HOLLDLKCEOF), global::EggLink.DanhengServer.Proto.HOLLDLKCEOF.Parser, new[]{ "EliteGroup", "Level", "ONMMDMCACMB", "HardLevelGroup" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class HOLLDLKCEOF : pb::IMessage<HOLLDLKCEOF>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HOLLDLKCEOF> _parser = new pb::MessageParser<HOLLDLKCEOF>(() => new HOLLDLKCEOF());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HOLLDLKCEOF> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.HOLLDLKCEOFReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HOLLDLKCEOF() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HOLLDLKCEOF(HOLLDLKCEOF other) : this() {
      eliteGroup_ = other.eliteGroup_;
      level_ = other.level_;
      oNMMDMCACMB_ = other.oNMMDMCACMB_;
      hardLevelGroup_ = other.hardLevelGroup_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HOLLDLKCEOF Clone() {
      return new HOLLDLKCEOF(this);
    }

    /// <summary>Field number for the "elite_group" field.</summary>
    public const int EliteGroupFieldNumber = 14;
    private uint eliteGroup_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EliteGroup {
      get { return eliteGroup_; }
      set {
        eliteGroup_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 7;
    private uint level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "ONMMDMCACMB" field.</summary>
    public const int ONMMDMCACMBFieldNumber = 13;
    private uint oNMMDMCACMB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ONMMDMCACMB {
      get { return oNMMDMCACMB_; }
      set {
        oNMMDMCACMB_ = value;
      }
    }

    /// <summary>Field number for the "hard_level_group" field.</summary>
    public const int HardLevelGroupFieldNumber = 15;
    private uint hardLevelGroup_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HardLevelGroup {
      get { return hardLevelGroup_; }
      set {
        hardLevelGroup_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HOLLDLKCEOF);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HOLLDLKCEOF other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EliteGroup != other.EliteGroup) return false;
      if (Level != other.Level) return false;
      if (ONMMDMCACMB != other.ONMMDMCACMB) return false;
      if (HardLevelGroup != other.HardLevelGroup) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EliteGroup != 0) hash ^= EliteGroup.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      if (ONMMDMCACMB != 0) hash ^= ONMMDMCACMB.GetHashCode();
      if (HardLevelGroup != 0) hash ^= HardLevelGroup.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Level != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Level);
      }
      if (ONMMDMCACMB != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ONMMDMCACMB);
      }
      if (EliteGroup != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(EliteGroup);
      }
      if (HardLevelGroup != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(HardLevelGroup);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Level != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Level);
      }
      if (ONMMDMCACMB != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ONMMDMCACMB);
      }
      if (EliteGroup != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(EliteGroup);
      }
      if (HardLevelGroup != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(HardLevelGroup);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (EliteGroup != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EliteGroup);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      if (ONMMDMCACMB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ONMMDMCACMB);
      }
      if (HardLevelGroup != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HardLevelGroup);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HOLLDLKCEOF other) {
      if (other == null) {
        return;
      }
      if (other.EliteGroup != 0) {
        EliteGroup = other.EliteGroup;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.ONMMDMCACMB != 0) {
        ONMMDMCACMB = other.ONMMDMCACMB;
      }
      if (other.HardLevelGroup != 0) {
        HardLevelGroup = other.HardLevelGroup;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 56: {
            Level = input.ReadUInt32();
            break;
          }
          case 104: {
            ONMMDMCACMB = input.ReadUInt32();
            break;
          }
          case 112: {
            EliteGroup = input.ReadUInt32();
            break;
          }
          case 120: {
            HardLevelGroup = input.ReadUInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 56: {
            Level = input.ReadUInt32();
            break;
          }
          case 104: {
            ONMMDMCACMB = input.ReadUInt32();
            break;
          }
          case 112: {
            EliteGroup = input.ReadUInt32();
            break;
          }
          case 120: {
            HardLevelGroup = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code