// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: NLONGNDDAJK.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from NLONGNDDAJK.proto</summary>
  public static partial class NLONGNDDAJKReflection {

    #region Descriptor
    /// <summary>File descriptor for NLONGNDDAJK.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NLONGNDDAJKReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFOTE9OR05EREFKSy5wcm90bxoRR01IQ0NJRE1FTU8ucHJvdG8iWgoLTkxP",
            "TkdORERBSksSEwoLS0pKTERHTE1ET0EYBiABKA0SIQoLUERERUdPSkRCR0UY",
            "DCABKA4yDC5HTUhDQ0lETUVNTxITCgtDREhFSEdKTEZLTxgFIAEoDUIeqgIb",
            "RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.GMHCCIDMEMOReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.NLONGNDDAJK), global::EggLink.DanhengServer.Proto.NLONGNDDAJK.Parser, new[]{ "KJJLDGLMDOA", "PDDEGOJDBGE", "CDHEHGJLFKO" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class NLONGNDDAJK : pb::IMessage<NLONGNDDAJK>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<NLONGNDDAJK> _parser = new pb::MessageParser<NLONGNDDAJK>(() => new NLONGNDDAJK());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<NLONGNDDAJK> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.NLONGNDDAJKReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NLONGNDDAJK() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NLONGNDDAJK(NLONGNDDAJK other) : this() {
      kJJLDGLMDOA_ = other.kJJLDGLMDOA_;
      pDDEGOJDBGE_ = other.pDDEGOJDBGE_;
      cDHEHGJLFKO_ = other.cDHEHGJLFKO_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NLONGNDDAJK Clone() {
      return new NLONGNDDAJK(this);
    }

    /// <summary>Field number for the "KJJLDGLMDOA" field.</summary>
    public const int KJJLDGLMDOAFieldNumber = 6;
    private uint kJJLDGLMDOA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KJJLDGLMDOA {
      get { return kJJLDGLMDOA_; }
      set {
        kJJLDGLMDOA_ = value;
      }
    }

    /// <summary>Field number for the "PDDEGOJDBGE" field.</summary>
    public const int PDDEGOJDBGEFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.GMHCCIDMEMO pDDEGOJDBGE_ = global::EggLink.DanhengServer.Proto.GMHCCIDMEMO.RogueModifierContentDefinite;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.GMHCCIDMEMO PDDEGOJDBGE {
      get { return pDDEGOJDBGE_; }
      set {
        pDDEGOJDBGE_ = value;
      }
    }

    /// <summary>Field number for the "CDHEHGJLFKO" field.</summary>
    public const int CDHEHGJLFKOFieldNumber = 5;
    private uint cDHEHGJLFKO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CDHEHGJLFKO {
      get { return cDHEHGJLFKO_; }
      set {
        cDHEHGJLFKO_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as NLONGNDDAJK);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(NLONGNDDAJK other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (KJJLDGLMDOA != other.KJJLDGLMDOA) return false;
      if (PDDEGOJDBGE != other.PDDEGOJDBGE) return false;
      if (CDHEHGJLFKO != other.CDHEHGJLFKO) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (KJJLDGLMDOA != 0) hash ^= KJJLDGLMDOA.GetHashCode();
      if (PDDEGOJDBGE != global::EggLink.DanhengServer.Proto.GMHCCIDMEMO.RogueModifierContentDefinite) hash ^= PDDEGOJDBGE.GetHashCode();
      if (CDHEHGJLFKO != 0) hash ^= CDHEHGJLFKO.GetHashCode();
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
      if (CDHEHGJLFKO != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(CDHEHGJLFKO);
      }
      if (KJJLDGLMDOA != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(KJJLDGLMDOA);
      }
      if (PDDEGOJDBGE != global::EggLink.DanhengServer.Proto.GMHCCIDMEMO.RogueModifierContentDefinite) {
        output.WriteRawTag(96);
        output.WriteEnum((int) PDDEGOJDBGE);
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
      if (CDHEHGJLFKO != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(CDHEHGJLFKO);
      }
      if (KJJLDGLMDOA != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(KJJLDGLMDOA);
      }
      if (PDDEGOJDBGE != global::EggLink.DanhengServer.Proto.GMHCCIDMEMO.RogueModifierContentDefinite) {
        output.WriteRawTag(96);
        output.WriteEnum((int) PDDEGOJDBGE);
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
      if (KJJLDGLMDOA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KJJLDGLMDOA);
      }
      if (PDDEGOJDBGE != global::EggLink.DanhengServer.Proto.GMHCCIDMEMO.RogueModifierContentDefinite) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) PDDEGOJDBGE);
      }
      if (CDHEHGJLFKO != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CDHEHGJLFKO);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(NLONGNDDAJK other) {
      if (other == null) {
        return;
      }
      if (other.KJJLDGLMDOA != 0) {
        KJJLDGLMDOA = other.KJJLDGLMDOA;
      }
      if (other.PDDEGOJDBGE != global::EggLink.DanhengServer.Proto.GMHCCIDMEMO.RogueModifierContentDefinite) {
        PDDEGOJDBGE = other.PDDEGOJDBGE;
      }
      if (other.CDHEHGJLFKO != 0) {
        CDHEHGJLFKO = other.CDHEHGJLFKO;
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
          case 40: {
            CDHEHGJLFKO = input.ReadUInt32();
            break;
          }
          case 48: {
            KJJLDGLMDOA = input.ReadUInt32();
            break;
          }
          case 96: {
            PDDEGOJDBGE = (global::EggLink.DanhengServer.Proto.GMHCCIDMEMO) input.ReadEnum();
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
          case 40: {
            CDHEHGJLFKO = input.ReadUInt32();
            break;
          }
          case 48: {
            KJJLDGLMDOA = input.ReadUInt32();
            break;
          }
          case 96: {
            PDDEGOJDBGE = (global::EggLink.DanhengServer.Proto.GMHCCIDMEMO) input.ReadEnum();
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