// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: NMOMEMMFJNF.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from NMOMEMMFJNF.proto</summary>
  public static partial class NMOMEMMFJNFReflection {

    #region Descriptor
    /// <summary>File descriptor for NMOMEMMFJNF.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NMOMEMMFJNFReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFOTU9NRU1NRkpORi5wcm90byI3CgtOTU9NRU1NRkpORhITCgtCSUxLRk5B",
            "TEdMQRgCIAEoDRITCgtBR0lKQVBLS0xOThgPIAEoDUIeqgIbRWdnTGluay5E",
            "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.NMOMEMMFJNF), global::EggLink.DanhengServer.Proto.NMOMEMMFJNF.Parser, new[]{ "BILKFNALGLA", "AGIJAPKKLNN" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class NMOMEMMFJNF : pb::IMessage<NMOMEMMFJNF>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<NMOMEMMFJNF> _parser = new pb::MessageParser<NMOMEMMFJNF>(() => new NMOMEMMFJNF());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<NMOMEMMFJNF> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.NMOMEMMFJNFReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NMOMEMMFJNF() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NMOMEMMFJNF(NMOMEMMFJNF other) : this() {
      bILKFNALGLA_ = other.bILKFNALGLA_;
      aGIJAPKKLNN_ = other.aGIJAPKKLNN_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NMOMEMMFJNF Clone() {
      return new NMOMEMMFJNF(this);
    }

    /// <summary>Field number for the "BILKFNALGLA" field.</summary>
    public const int BILKFNALGLAFieldNumber = 2;
    private uint bILKFNALGLA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BILKFNALGLA {
      get { return bILKFNALGLA_; }
      set {
        bILKFNALGLA_ = value;
      }
    }

    /// <summary>Field number for the "AGIJAPKKLNN" field.</summary>
    public const int AGIJAPKKLNNFieldNumber = 15;
    private uint aGIJAPKKLNN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AGIJAPKKLNN {
      get { return aGIJAPKKLNN_; }
      set {
        aGIJAPKKLNN_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as NMOMEMMFJNF);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(NMOMEMMFJNF other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BILKFNALGLA != other.BILKFNALGLA) return false;
      if (AGIJAPKKLNN != other.AGIJAPKKLNN) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BILKFNALGLA != 0) hash ^= BILKFNALGLA.GetHashCode();
      if (AGIJAPKKLNN != 0) hash ^= AGIJAPKKLNN.GetHashCode();
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
      if (BILKFNALGLA != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(BILKFNALGLA);
      }
      if (AGIJAPKKLNN != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(AGIJAPKKLNN);
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
      if (BILKFNALGLA != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(BILKFNALGLA);
      }
      if (AGIJAPKKLNN != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(AGIJAPKKLNN);
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
      if (BILKFNALGLA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BILKFNALGLA);
      }
      if (AGIJAPKKLNN != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AGIJAPKKLNN);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(NMOMEMMFJNF other) {
      if (other == null) {
        return;
      }
      if (other.BILKFNALGLA != 0) {
        BILKFNALGLA = other.BILKFNALGLA;
      }
      if (other.AGIJAPKKLNN != 0) {
        AGIJAPKKLNN = other.AGIJAPKKLNN;
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
          case 16: {
            BILKFNALGLA = input.ReadUInt32();
            break;
          }
          case 120: {
            AGIJAPKKLNN = input.ReadUInt32();
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
          case 16: {
            BILKFNALGLA = input.ReadUInt32();
            break;
          }
          case 120: {
            AGIJAPKKLNN = input.ReadUInt32();
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
