// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PNGOOBNCNKJ.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from PNGOOBNCNKJ.proto</summary>
  public static partial class PNGOOBNCNKJReflection {

    #region Descriptor
    /// <summary>File descriptor for PNGOOBNCNKJ.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PNGOOBNCNKJReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFQTkdPT0JOQ05LSi5wcm90byI3CgtQTkdPT0JOQ05LShITCgtFRUxGSE1F",
            "RU5ORBgBIAEoDRITCgtMS0RLREJDRUlDRxgLIAEoDUIeqgIbRWdnTGluay5E",
            "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.PNGOOBNCNKJ), global::EggLink.DanhengServer.Proto.PNGOOBNCNKJ.Parser, new[]{ "EELFHMEENND", "LKDKDBCEICG" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PNGOOBNCNKJ : pb::IMessage<PNGOOBNCNKJ>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PNGOOBNCNKJ> _parser = new pb::MessageParser<PNGOOBNCNKJ>(() => new PNGOOBNCNKJ());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PNGOOBNCNKJ> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.PNGOOBNCNKJReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PNGOOBNCNKJ() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PNGOOBNCNKJ(PNGOOBNCNKJ other) : this() {
      eELFHMEENND_ = other.eELFHMEENND_;
      lKDKDBCEICG_ = other.lKDKDBCEICG_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PNGOOBNCNKJ Clone() {
      return new PNGOOBNCNKJ(this);
    }

    /// <summary>Field number for the "EELFHMEENND" field.</summary>
    public const int EELFHMEENNDFieldNumber = 1;
    private uint eELFHMEENND_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EELFHMEENND {
      get { return eELFHMEENND_; }
      set {
        eELFHMEENND_ = value;
      }
    }

    /// <summary>Field number for the "LKDKDBCEICG" field.</summary>
    public const int LKDKDBCEICGFieldNumber = 11;
    private uint lKDKDBCEICG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LKDKDBCEICG {
      get { return lKDKDBCEICG_; }
      set {
        lKDKDBCEICG_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PNGOOBNCNKJ);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PNGOOBNCNKJ other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EELFHMEENND != other.EELFHMEENND) return false;
      if (LKDKDBCEICG != other.LKDKDBCEICG) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EELFHMEENND != 0) hash ^= EELFHMEENND.GetHashCode();
      if (LKDKDBCEICG != 0) hash ^= LKDKDBCEICG.GetHashCode();
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
      if (EELFHMEENND != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(EELFHMEENND);
      }
      if (LKDKDBCEICG != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(LKDKDBCEICG);
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
      if (EELFHMEENND != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(EELFHMEENND);
      }
      if (LKDKDBCEICG != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(LKDKDBCEICG);
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
      if (EELFHMEENND != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EELFHMEENND);
      }
      if (LKDKDBCEICG != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LKDKDBCEICG);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PNGOOBNCNKJ other) {
      if (other == null) {
        return;
      }
      if (other.EELFHMEENND != 0) {
        EELFHMEENND = other.EELFHMEENND;
      }
      if (other.LKDKDBCEICG != 0) {
        LKDKDBCEICG = other.LKDKDBCEICG;
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
          case 8: {
            EELFHMEENND = input.ReadUInt32();
            break;
          }
          case 88: {
            LKDKDBCEICG = input.ReadUInt32();
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
          case 8: {
            EELFHMEENND = input.ReadUInt32();
            break;
          }
          case 88: {
            LKDKDBCEICG = input.ReadUInt32();
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