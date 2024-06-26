// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1/notebook_euc_config.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AIPlatform.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/aiplatform/v1/notebook_euc_config.proto</summary>
  public static partial class NotebookEucConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/aiplatform/v1/notebook_euc_config.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NotebookEucConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRnb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MS9ub3RlYm9va19ldWNfY29u",
            "ZmlnLnByb3RvEhpnb29nbGUuY2xvdWQuYWlwbGF0Zm9ybS52MRofZ29vZ2xl",
            "L2FwaS9maWVsZF9iZWhhdmlvci5wcm90byJPChFOb3RlYm9va0V1Y0NvbmZp",
            "ZxIZCgxldWNfZGlzYWJsZWQYASABKAhCA+BBBBIfChJieXBhc3NfYWN0YXNf",
            "Y2hlY2sYAiABKAhCA+BBA0LUAQoeY29tLmdvb2dsZS5jbG91ZC5haXBsYXRm",
            "b3JtLnYxQhZOb3RlYm9va0V1Y0NvbmZpZ1Byb3RvUAFaPmNsb3VkLmdvb2ds",
            "ZS5jb20vZ28vYWlwbGF0Zm9ybS9hcGl2MS9haXBsYXRmb3JtcGI7YWlwbGF0",
            "Zm9ybXBiqgIaR29vZ2xlLkNsb3VkLkFJUGxhdGZvcm0uVjHKAhpHb29nbGVc",
            "Q2xvdWRcQUlQbGF0Zm9ybVxWMeoCHUdvb2dsZTo6Q2xvdWQ6OkFJUGxhdGZv",
            "cm06OlYxYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1.NotebookEucConfig), global::Google.Cloud.AIPlatform.V1.NotebookEucConfig.Parser, new[]{ "EucDisabled", "BypassActasCheck" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The euc configuration of NotebookRuntimeTemplate.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class NotebookEucConfig : pb::IMessage<NotebookEucConfig>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<NotebookEucConfig> _parser = new pb::MessageParser<NotebookEucConfig>(() => new NotebookEucConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<NotebookEucConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1.NotebookEucConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NotebookEucConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NotebookEucConfig(NotebookEucConfig other) : this() {
      eucDisabled_ = other.eucDisabled_;
      bypassActasCheck_ = other.bypassActasCheck_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NotebookEucConfig Clone() {
      return new NotebookEucConfig(this);
    }

    /// <summary>Field number for the "euc_disabled" field.</summary>
    public const int EucDisabledFieldNumber = 1;
    private bool eucDisabled_;
    /// <summary>
    /// Input only. Whether EUC is disabled in this NotebookRuntimeTemplate.
    /// In proto3, the default value of a boolean is false. In this way, by default
    /// EUC will be enabled for NotebookRuntimeTemplate.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool EucDisabled {
      get { return eucDisabled_; }
      set {
        eucDisabled_ = value;
      }
    }

    /// <summary>Field number for the "bypass_actas_check" field.</summary>
    public const int BypassActasCheckFieldNumber = 2;
    private bool bypassActasCheck_;
    /// <summary>
    /// Output only. Whether ActAs check is bypassed for service account attached
    /// to the VM. If false, we need ActAs check for the default Compute Engine
    /// Service account. When a Runtime is created, a VM is allocated using Default
    /// Compute Engine Service Account. Any user requesting to use this Runtime
    /// requires Service Account User (ActAs) permission over this SA. If true,
    /// Runtime owner is using EUC and does not require the above permission as VM
    /// no longer use default Compute Engine SA, but a P4SA.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool BypassActasCheck {
      get { return bypassActasCheck_; }
      set {
        bypassActasCheck_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as NotebookEucConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(NotebookEucConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EucDisabled != other.EucDisabled) return false;
      if (BypassActasCheck != other.BypassActasCheck) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EucDisabled != false) hash ^= EucDisabled.GetHashCode();
      if (BypassActasCheck != false) hash ^= BypassActasCheck.GetHashCode();
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
      if (EucDisabled != false) {
        output.WriteRawTag(8);
        output.WriteBool(EucDisabled);
      }
      if (BypassActasCheck != false) {
        output.WriteRawTag(16);
        output.WriteBool(BypassActasCheck);
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
      if (EucDisabled != false) {
        output.WriteRawTag(8);
        output.WriteBool(EucDisabled);
      }
      if (BypassActasCheck != false) {
        output.WriteRawTag(16);
        output.WriteBool(BypassActasCheck);
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
      if (EucDisabled != false) {
        size += 1 + 1;
      }
      if (BypassActasCheck != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(NotebookEucConfig other) {
      if (other == null) {
        return;
      }
      if (other.EucDisabled != false) {
        EucDisabled = other.EucDisabled;
      }
      if (other.BypassActasCheck != false) {
        BypassActasCheck = other.BypassActasCheck;
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
            EucDisabled = input.ReadBool();
            break;
          }
          case 16: {
            BypassActasCheck = input.ReadBool();
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
            EucDisabled = input.ReadBool();
            break;
          }
          case 16: {
            BypassActasCheck = input.ReadBool();
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
