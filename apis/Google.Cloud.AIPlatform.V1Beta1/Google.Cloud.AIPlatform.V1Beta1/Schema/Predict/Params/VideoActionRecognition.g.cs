// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1beta1/schema/predict/params/video_action_recognition.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AIPlatform.V1Beta1.Schema.Predict.Params {

  /// <summary>Holder for reflection information generated from google/cloud/aiplatform/v1beta1/schema/predict/params/video_action_recognition.proto</summary>
  public static partial class VideoActionRecognitionReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/aiplatform/v1beta1/schema/predict/params/video_action_recognition.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VideoActionRecognitionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ClRnb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MWJldGExL3NjaGVtYS9wcmVk",
            "aWN0L3BhcmFtcy92aWRlb19hY3Rpb25fcmVjb2duaXRpb24ucHJvdG8SNWdv",
            "b2dsZS5jbG91ZC5haXBsYXRmb3JtLnYxYmV0YTEuc2NoZW1hLnByZWRpY3Qu",
            "cGFyYW1zIl8KJlZpZGVvQWN0aW9uUmVjb2duaXRpb25QcmVkaWN0aW9uUGFy",
            "YW1zEhwKFGNvbmZpZGVuY2VfdGhyZXNob2xkGAEgASgCEhcKD21heF9wcmVk",
            "aWN0aW9ucxgCIAEoBULrAgo5Y29tLmdvb2dsZS5jbG91ZC5haXBsYXRmb3Jt",
            "LnYxYmV0YTEuc2NoZW1hLnByZWRpY3QucGFyYW1zQitWaWRlb0FjdGlvblJl",
            "Y29nbml0aW9uUHJlZGljdGlvblBhcmFtc1Byb3RvUAFaUWNsb3VkLmdvb2ds",
            "ZS5jb20vZ28vYWlwbGF0Zm9ybS9hcGl2MWJldGExL3NjaGVtYS9wcmVkaWN0",
            "L3BhcmFtcy9wYXJhbXNwYjtwYXJhbXNwYqoCNUdvb2dsZS5DbG91ZC5BSVBs",
            "YXRmb3JtLlYxQmV0YTEuU2NoZW1hLlByZWRpY3QuUGFyYW1zygI1R29vZ2xl",
            "XENsb3VkXEFJUGxhdGZvcm1cVjFiZXRhMVxTY2hlbWFcUHJlZGljdFxQYXJh",
            "bXPqAjtHb29nbGU6OkNsb3VkOjpBSVBsYXRmb3JtOjpWMWJldGExOjpTY2hl",
            "bWE6OlByZWRpY3Q6OlBhcmFtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1Beta1.Schema.Predict.Params.VideoActionRecognitionPredictionParams), global::Google.Cloud.AIPlatform.V1Beta1.Schema.Predict.Params.VideoActionRecognitionPredictionParams.Parser, new[]{ "ConfidenceThreshold", "MaxPredictions" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Prediction model parameters for Video Action Recognition.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class VideoActionRecognitionPredictionParams : pb::IMessage<VideoActionRecognitionPredictionParams>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<VideoActionRecognitionPredictionParams> _parser = new pb::MessageParser<VideoActionRecognitionPredictionParams>(() => new VideoActionRecognitionPredictionParams());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<VideoActionRecognitionPredictionParams> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1Beta1.Schema.Predict.Params.VideoActionRecognitionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VideoActionRecognitionPredictionParams() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VideoActionRecognitionPredictionParams(VideoActionRecognitionPredictionParams other) : this() {
      confidenceThreshold_ = other.confidenceThreshold_;
      maxPredictions_ = other.maxPredictions_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VideoActionRecognitionPredictionParams Clone() {
      return new VideoActionRecognitionPredictionParams(this);
    }

    /// <summary>Field number for the "confidence_threshold" field.</summary>
    public const int ConfidenceThresholdFieldNumber = 1;
    private float confidenceThreshold_;
    /// <summary>
    /// The Model only returns predictions with at least this confidence score.
    /// Default value is 0.0
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float ConfidenceThreshold {
      get { return confidenceThreshold_; }
      set {
        confidenceThreshold_ = value;
      }
    }

    /// <summary>Field number for the "max_predictions" field.</summary>
    public const int MaxPredictionsFieldNumber = 2;
    private int maxPredictions_;
    /// <summary>
    /// The model only returns up to that many top, by confidence score,
    /// predictions per frame of the video. If this number is very high, the
    /// Model may return fewer predictions per frame. Default value is 50.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int MaxPredictions {
      get { return maxPredictions_; }
      set {
        maxPredictions_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as VideoActionRecognitionPredictionParams);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(VideoActionRecognitionPredictionParams other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ConfidenceThreshold, other.ConfidenceThreshold)) return false;
      if (MaxPredictions != other.MaxPredictions) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ConfidenceThreshold != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ConfidenceThreshold);
      if (MaxPredictions != 0) hash ^= MaxPredictions.GetHashCode();
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
      if (ConfidenceThreshold != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(ConfidenceThreshold);
      }
      if (MaxPredictions != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(MaxPredictions);
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
      if (ConfidenceThreshold != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(ConfidenceThreshold);
      }
      if (MaxPredictions != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(MaxPredictions);
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
      if (ConfidenceThreshold != 0F) {
        size += 1 + 4;
      }
      if (MaxPredictions != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxPredictions);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(VideoActionRecognitionPredictionParams other) {
      if (other == null) {
        return;
      }
      if (other.ConfidenceThreshold != 0F) {
        ConfidenceThreshold = other.ConfidenceThreshold;
      }
      if (other.MaxPredictions != 0) {
        MaxPredictions = other.MaxPredictions;
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
          case 13: {
            ConfidenceThreshold = input.ReadFloat();
            break;
          }
          case 16: {
            MaxPredictions = input.ReadInt32();
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
          case 13: {
            ConfidenceThreshold = input.ReadFloat();
            break;
          }
          case 16: {
            MaxPredictions = input.ReadInt32();
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
