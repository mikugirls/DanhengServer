// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FightMatch3OpponentDataScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from FightMatch3OpponentDataScNotify.proto</summary>
  public static partial class FightMatch3OpponentDataScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for FightMatch3OpponentDataScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FightMatch3OpponentDataScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVGaWdodE1hdGNoM09wcG9uZW50RGF0YVNjTm90aWZ5LnByb3RvGhFFRkVF",
            "TVBITUZLSS5wcm90byKGAQofRmlnaHRNYXRjaDNPcHBvbmVudERhdGFTY05v",
            "dGlmeRIQCghzY29yZV9pZBgCIAEoDRIKCgJocBgEIAEoDRIbCgVzdGF0ZRgL",
            "IAEoDjIMLkVGRUVNUEhNRktJEhMKC0hIR0xCREhPSEtKGAogASgNEhMKC09D",
            "SEdKQ0JPTkhLGAkgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv",
            "dG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.EFEEMPHMFKIReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.FightMatch3OpponentDataScNotify), global::EggLink.DanhengServer.Proto.FightMatch3OpponentDataScNotify.Parser, new[]{ "ScoreId", "Hp", "State", "HHGLBDHOHKJ", "OCHGJCBONHK" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class FightMatch3OpponentDataScNotify : pb::IMessage<FightMatch3OpponentDataScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FightMatch3OpponentDataScNotify> _parser = new pb::MessageParser<FightMatch3OpponentDataScNotify>(() => new FightMatch3OpponentDataScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FightMatch3OpponentDataScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.FightMatch3OpponentDataScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FightMatch3OpponentDataScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FightMatch3OpponentDataScNotify(FightMatch3OpponentDataScNotify other) : this() {
      scoreId_ = other.scoreId_;
      hp_ = other.hp_;
      state_ = other.state_;
      hHGLBDHOHKJ_ = other.hHGLBDHOHKJ_;
      oCHGJCBONHK_ = other.oCHGJCBONHK_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FightMatch3OpponentDataScNotify Clone() {
      return new FightMatch3OpponentDataScNotify(this);
    }

    /// <summary>Field number for the "score_id" field.</summary>
    public const int ScoreIdFieldNumber = 2;
    private uint scoreId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ScoreId {
      get { return scoreId_; }
      set {
        scoreId_ = value;
      }
    }

    /// <summary>Field number for the "hp" field.</summary>
    public const int HpFieldNumber = 4;
    private uint hp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Hp {
      get { return hp_; }
      set {
        hp_ = value;
      }
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.EFEEMPHMFKI state_ = global::EggLink.DanhengServer.Proto.EFEEMPHMFKI.Match3PlayerStateAlive;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.EFEEMPHMFKI State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    /// <summary>Field number for the "HHGLBDHOHKJ" field.</summary>
    public const int HHGLBDHOHKJFieldNumber = 10;
    private uint hHGLBDHOHKJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HHGLBDHOHKJ {
      get { return hHGLBDHOHKJ_; }
      set {
        hHGLBDHOHKJ_ = value;
      }
    }

    /// <summary>Field number for the "OCHGJCBONHK" field.</summary>
    public const int OCHGJCBONHKFieldNumber = 9;
    private uint oCHGJCBONHK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OCHGJCBONHK {
      get { return oCHGJCBONHK_; }
      set {
        oCHGJCBONHK_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FightMatch3OpponentDataScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FightMatch3OpponentDataScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ScoreId != other.ScoreId) return false;
      if (Hp != other.Hp) return false;
      if (State != other.State) return false;
      if (HHGLBDHOHKJ != other.HHGLBDHOHKJ) return false;
      if (OCHGJCBONHK != other.OCHGJCBONHK) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ScoreId != 0) hash ^= ScoreId.GetHashCode();
      if (Hp != 0) hash ^= Hp.GetHashCode();
      if (State != global::EggLink.DanhengServer.Proto.EFEEMPHMFKI.Match3PlayerStateAlive) hash ^= State.GetHashCode();
      if (HHGLBDHOHKJ != 0) hash ^= HHGLBDHOHKJ.GetHashCode();
      if (OCHGJCBONHK != 0) hash ^= OCHGJCBONHK.GetHashCode();
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
      if (ScoreId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ScoreId);
      }
      if (Hp != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Hp);
      }
      if (OCHGJCBONHK != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(OCHGJCBONHK);
      }
      if (HHGLBDHOHKJ != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(HHGLBDHOHKJ);
      }
      if (State != global::EggLink.DanhengServer.Proto.EFEEMPHMFKI.Match3PlayerStateAlive) {
        output.WriteRawTag(88);
        output.WriteEnum((int) State);
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
      if (ScoreId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ScoreId);
      }
      if (Hp != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Hp);
      }
      if (OCHGJCBONHK != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(OCHGJCBONHK);
      }
      if (HHGLBDHOHKJ != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(HHGLBDHOHKJ);
      }
      if (State != global::EggLink.DanhengServer.Proto.EFEEMPHMFKI.Match3PlayerStateAlive) {
        output.WriteRawTag(88);
        output.WriteEnum((int) State);
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
      if (ScoreId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ScoreId);
      }
      if (Hp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Hp);
      }
      if (State != global::EggLink.DanhengServer.Proto.EFEEMPHMFKI.Match3PlayerStateAlive) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
      }
      if (HHGLBDHOHKJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HHGLBDHOHKJ);
      }
      if (OCHGJCBONHK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OCHGJCBONHK);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FightMatch3OpponentDataScNotify other) {
      if (other == null) {
        return;
      }
      if (other.ScoreId != 0) {
        ScoreId = other.ScoreId;
      }
      if (other.Hp != 0) {
        Hp = other.Hp;
      }
      if (other.State != global::EggLink.DanhengServer.Proto.EFEEMPHMFKI.Match3PlayerStateAlive) {
        State = other.State;
      }
      if (other.HHGLBDHOHKJ != 0) {
        HHGLBDHOHKJ = other.HHGLBDHOHKJ;
      }
      if (other.OCHGJCBONHK != 0) {
        OCHGJCBONHK = other.OCHGJCBONHK;
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
            ScoreId = input.ReadUInt32();
            break;
          }
          case 32: {
            Hp = input.ReadUInt32();
            break;
          }
          case 72: {
            OCHGJCBONHK = input.ReadUInt32();
            break;
          }
          case 80: {
            HHGLBDHOHKJ = input.ReadUInt32();
            break;
          }
          case 88: {
            State = (global::EggLink.DanhengServer.Proto.EFEEMPHMFKI) input.ReadEnum();
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
            ScoreId = input.ReadUInt32();
            break;
          }
          case 32: {
            Hp = input.ReadUInt32();
            break;
          }
          case 72: {
            OCHGJCBONHK = input.ReadUInt32();
            break;
          }
          case 80: {
            HHGLBDHOHKJ = input.ReadUInt32();
            break;
          }
          case 88: {
            State = (global::EggLink.DanhengServer.Proto.EFEEMPHMFKI) input.ReadEnum();
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