// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TextJoinInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from TextJoinInfo.proto</summary>
  public static partial class TextJoinInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for TextJoinInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TextJoinInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJUZXh0Sm9pbkluZm8ucHJvdG8idwoMVGV4dEpvaW5JbmZvEhMKC09LSkZG",
            "Q0JORkFPGAQgASgJEhMKC0RCSUFNQUJPTkRLGAogASgNEhMKC09BQ0pQRkFI",
            "S0ZLGAIgASgJEhMKC09NSUZQS0tETE5LGA8gASgNEhMKC09GTE5ETUZFSkJQ",
            "GAcgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.TextJoinInfo), global::EggLink.DanhengServer.Proto.TextJoinInfo.Parser, new[]{ "OKJFFCBNFAO", "DBIAMABONDK", "OACJPFAHKFK", "OMIFPKKDLNK", "OFLNDMFEJBP" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class TextJoinInfo : pb::IMessage<TextJoinInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TextJoinInfo> _parser = new pb::MessageParser<TextJoinInfo>(() => new TextJoinInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TextJoinInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.TextJoinInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TextJoinInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TextJoinInfo(TextJoinInfo other) : this() {
      oKJFFCBNFAO_ = other.oKJFFCBNFAO_;
      dBIAMABONDK_ = other.dBIAMABONDK_;
      oACJPFAHKFK_ = other.oACJPFAHKFK_;
      oMIFPKKDLNK_ = other.oMIFPKKDLNK_;
      oFLNDMFEJBP_ = other.oFLNDMFEJBP_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TextJoinInfo Clone() {
      return new TextJoinInfo(this);
    }

    /// <summary>Field number for the "OKJFFCBNFAO" field.</summary>
    public const int OKJFFCBNFAOFieldNumber = 4;
    private string oKJFFCBNFAO_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string OKJFFCBNFAO {
      get { return oKJFFCBNFAO_; }
      set {
        oKJFFCBNFAO_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "DBIAMABONDK" field.</summary>
    public const int DBIAMABONDKFieldNumber = 10;
    private uint dBIAMABONDK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DBIAMABONDK {
      get { return dBIAMABONDK_; }
      set {
        dBIAMABONDK_ = value;
      }
    }

    /// <summary>Field number for the "OACJPFAHKFK" field.</summary>
    public const int OACJPFAHKFKFieldNumber = 2;
    private string oACJPFAHKFK_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string OACJPFAHKFK {
      get { return oACJPFAHKFK_; }
      set {
        oACJPFAHKFK_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "OMIFPKKDLNK" field.</summary>
    public const int OMIFPKKDLNKFieldNumber = 15;
    private uint oMIFPKKDLNK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OMIFPKKDLNK {
      get { return oMIFPKKDLNK_; }
      set {
        oMIFPKKDLNK_ = value;
      }
    }

    /// <summary>Field number for the "OFLNDMFEJBP" field.</summary>
    public const int OFLNDMFEJBPFieldNumber = 7;
    private uint oFLNDMFEJBP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OFLNDMFEJBP {
      get { return oFLNDMFEJBP_; }
      set {
        oFLNDMFEJBP_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TextJoinInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TextJoinInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OKJFFCBNFAO != other.OKJFFCBNFAO) return false;
      if (DBIAMABONDK != other.DBIAMABONDK) return false;
      if (OACJPFAHKFK != other.OACJPFAHKFK) return false;
      if (OMIFPKKDLNK != other.OMIFPKKDLNK) return false;
      if (OFLNDMFEJBP != other.OFLNDMFEJBP) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (OKJFFCBNFAO.Length != 0) hash ^= OKJFFCBNFAO.GetHashCode();
      if (DBIAMABONDK != 0) hash ^= DBIAMABONDK.GetHashCode();
      if (OACJPFAHKFK.Length != 0) hash ^= OACJPFAHKFK.GetHashCode();
      if (OMIFPKKDLNK != 0) hash ^= OMIFPKKDLNK.GetHashCode();
      if (OFLNDMFEJBP != 0) hash ^= OFLNDMFEJBP.GetHashCode();
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
      if (OACJPFAHKFK.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(OACJPFAHKFK);
      }
      if (OKJFFCBNFAO.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(OKJFFCBNFAO);
      }
      if (OFLNDMFEJBP != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(OFLNDMFEJBP);
      }
      if (DBIAMABONDK != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(DBIAMABONDK);
      }
      if (OMIFPKKDLNK != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(OMIFPKKDLNK);
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
      if (OACJPFAHKFK.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(OACJPFAHKFK);
      }
      if (OKJFFCBNFAO.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(OKJFFCBNFAO);
      }
      if (OFLNDMFEJBP != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(OFLNDMFEJBP);
      }
      if (DBIAMABONDK != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(DBIAMABONDK);
      }
      if (OMIFPKKDLNK != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(OMIFPKKDLNK);
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
      if (OKJFFCBNFAO.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OKJFFCBNFAO);
      }
      if (DBIAMABONDK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DBIAMABONDK);
      }
      if (OACJPFAHKFK.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OACJPFAHKFK);
      }
      if (OMIFPKKDLNK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OMIFPKKDLNK);
      }
      if (OFLNDMFEJBP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OFLNDMFEJBP);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TextJoinInfo other) {
      if (other == null) {
        return;
      }
      if (other.OKJFFCBNFAO.Length != 0) {
        OKJFFCBNFAO = other.OKJFFCBNFAO;
      }
      if (other.DBIAMABONDK != 0) {
        DBIAMABONDK = other.DBIAMABONDK;
      }
      if (other.OACJPFAHKFK.Length != 0) {
        OACJPFAHKFK = other.OACJPFAHKFK;
      }
      if (other.OMIFPKKDLNK != 0) {
        OMIFPKKDLNK = other.OMIFPKKDLNK;
      }
      if (other.OFLNDMFEJBP != 0) {
        OFLNDMFEJBP = other.OFLNDMFEJBP;
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
          case 18: {
            OACJPFAHKFK = input.ReadString();
            break;
          }
          case 34: {
            OKJFFCBNFAO = input.ReadString();
            break;
          }
          case 56: {
            OFLNDMFEJBP = input.ReadUInt32();
            break;
          }
          case 80: {
            DBIAMABONDK = input.ReadUInt32();
            break;
          }
          case 120: {
            OMIFPKKDLNK = input.ReadUInt32();
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
          case 18: {
            OACJPFAHKFK = input.ReadString();
            break;
          }
          case 34: {
            OKJFFCBNFAO = input.ReadString();
            break;
          }
          case 56: {
            OFLNDMFEJBP = input.ReadUInt32();
            break;
          }
          case 80: {
            DBIAMABONDK = input.ReadUInt32();
            break;
          }
          case 120: {
            OMIFPKKDLNK = input.ReadUInt32();
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