// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MonopolySelectOptionScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MonopolySelectOptionScRsp.proto</summary>
  public static partial class MonopolySelectOptionScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for MonopolySelectOptionScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MonopolySelectOptionScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9Nb25vcG9seVNlbGVjdE9wdGlvblNjUnNwLnByb3RvGhFHTVBETE9CREZG",
            "Si5wcm90bxoRTk5MTkJGQUNQQkEucHJvdG8imQEKGU1vbm9wb2x5U2VsZWN0",
            "T3B0aW9uU2NSc3ASEwoLTEJMT0RDQ0xOTEkYDyABKA0SDwoHcmV0Y29kZRgD",
            "IAEoDRIhCgtQQ0pPS0JHT0VLShgJIAEoCzIMLk5OTE5CRkFDUEJBEiEKC0xQ",
            "SEFIRU9FTENMGAggAygLMgwuR01QRExPQkRGRkoSEAoIZXZlbnRfaWQYByAB",
            "KA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.GMPDLOBDFFJReflection.Descriptor, global::EggLink.DanhengServer.Proto.NNLNBFACPBAReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.MonopolySelectOptionScRsp), global::EggLink.DanhengServer.Proto.MonopolySelectOptionScRsp.Parser, new[]{ "LBLODCCLNLI", "Retcode", "PCJOKBGOEKJ", "LPHAHEOELCL", "EventId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MonopolySelectOptionScRsp : pb::IMessage<MonopolySelectOptionScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MonopolySelectOptionScRsp> _parser = new pb::MessageParser<MonopolySelectOptionScRsp>(() => new MonopolySelectOptionScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MonopolySelectOptionScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.MonopolySelectOptionScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonopolySelectOptionScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonopolySelectOptionScRsp(MonopolySelectOptionScRsp other) : this() {
      lBLODCCLNLI_ = other.lBLODCCLNLI_;
      retcode_ = other.retcode_;
      pCJOKBGOEKJ_ = other.pCJOKBGOEKJ_ != null ? other.pCJOKBGOEKJ_.Clone() : null;
      lPHAHEOELCL_ = other.lPHAHEOELCL_.Clone();
      eventId_ = other.eventId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonopolySelectOptionScRsp Clone() {
      return new MonopolySelectOptionScRsp(this);
    }

    /// <summary>Field number for the "LBLODCCLNLI" field.</summary>
    public const int LBLODCCLNLIFieldNumber = 15;
    private uint lBLODCCLNLI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LBLODCCLNLI {
      get { return lBLODCCLNLI_; }
      set {
        lBLODCCLNLI_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 3;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "PCJOKBGOEKJ" field.</summary>
    public const int PCJOKBGOEKJFieldNumber = 9;
    private global::EggLink.DanhengServer.Proto.NNLNBFACPBA pCJOKBGOEKJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.NNLNBFACPBA PCJOKBGOEKJ {
      get { return pCJOKBGOEKJ_; }
      set {
        pCJOKBGOEKJ_ = value;
      }
    }

    /// <summary>Field number for the "LPHAHEOELCL" field.</summary>
    public const int LPHAHEOELCLFieldNumber = 8;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.GMPDLOBDFFJ> _repeated_lPHAHEOELCL_codec
        = pb::FieldCodec.ForMessage(66, global::EggLink.DanhengServer.Proto.GMPDLOBDFFJ.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.GMPDLOBDFFJ> lPHAHEOELCL_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.GMPDLOBDFFJ>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.GMPDLOBDFFJ> LPHAHEOELCL {
      get { return lPHAHEOELCL_; }
    }

    /// <summary>Field number for the "event_id" field.</summary>
    public const int EventIdFieldNumber = 7;
    private uint eventId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EventId {
      get { return eventId_; }
      set {
        eventId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MonopolySelectOptionScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MonopolySelectOptionScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LBLODCCLNLI != other.LBLODCCLNLI) return false;
      if (Retcode != other.Retcode) return false;
      if (!object.Equals(PCJOKBGOEKJ, other.PCJOKBGOEKJ)) return false;
      if(!lPHAHEOELCL_.Equals(other.lPHAHEOELCL_)) return false;
      if (EventId != other.EventId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (LBLODCCLNLI != 0) hash ^= LBLODCCLNLI.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (pCJOKBGOEKJ_ != null) hash ^= PCJOKBGOEKJ.GetHashCode();
      hash ^= lPHAHEOELCL_.GetHashCode();
      if (EventId != 0) hash ^= EventId.GetHashCode();
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
      if (Retcode != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Retcode);
      }
      if (EventId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(EventId);
      }
      lPHAHEOELCL_.WriteTo(output, _repeated_lPHAHEOELCL_codec);
      if (pCJOKBGOEKJ_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(PCJOKBGOEKJ);
      }
      if (LBLODCCLNLI != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(LBLODCCLNLI);
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
      if (Retcode != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Retcode);
      }
      if (EventId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(EventId);
      }
      lPHAHEOELCL_.WriteTo(ref output, _repeated_lPHAHEOELCL_codec);
      if (pCJOKBGOEKJ_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(PCJOKBGOEKJ);
      }
      if (LBLODCCLNLI != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(LBLODCCLNLI);
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
      if (LBLODCCLNLI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LBLODCCLNLI);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (pCJOKBGOEKJ_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PCJOKBGOEKJ);
      }
      size += lPHAHEOELCL_.CalculateSize(_repeated_lPHAHEOELCL_codec);
      if (EventId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EventId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MonopolySelectOptionScRsp other) {
      if (other == null) {
        return;
      }
      if (other.LBLODCCLNLI != 0) {
        LBLODCCLNLI = other.LBLODCCLNLI;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.pCJOKBGOEKJ_ != null) {
        if (pCJOKBGOEKJ_ == null) {
          PCJOKBGOEKJ = new global::EggLink.DanhengServer.Proto.NNLNBFACPBA();
        }
        PCJOKBGOEKJ.MergeFrom(other.PCJOKBGOEKJ);
      }
      lPHAHEOELCL_.Add(other.lPHAHEOELCL_);
      if (other.EventId != 0) {
        EventId = other.EventId;
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
          case 24: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 56: {
            EventId = input.ReadUInt32();
            break;
          }
          case 66: {
            lPHAHEOELCL_.AddEntriesFrom(input, _repeated_lPHAHEOELCL_codec);
            break;
          }
          case 74: {
            if (pCJOKBGOEKJ_ == null) {
              PCJOKBGOEKJ = new global::EggLink.DanhengServer.Proto.NNLNBFACPBA();
            }
            input.ReadMessage(PCJOKBGOEKJ);
            break;
          }
          case 120: {
            LBLODCCLNLI = input.ReadUInt32();
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
          case 24: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 56: {
            EventId = input.ReadUInt32();
            break;
          }
          case 66: {
            lPHAHEOELCL_.AddEntriesFrom(ref input, _repeated_lPHAHEOELCL_codec);
            break;
          }
          case 74: {
            if (pCJOKBGOEKJ_ == null) {
              PCJOKBGOEKJ = new global::EggLink.DanhengServer.Proto.NNLNBFACPBA();
            }
            input.ReadMessage(PCJOKBGOEKJ);
            break;
          }
          case 120: {
            LBLODCCLNLI = input.ReadUInt32();
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
