// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1beta1/schema/predict/params/image_segmentation.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AIPlatform.V1Beta1.Schema.Predict.Params {

  /// <summary>Holder for reflection information generated from google/cloud/aiplatform/v1beta1/schema/predict/params/image_segmentation.proto</summary>
  public static partial class ImageSegmentationReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/aiplatform/v1beta1/schema/predict/params/image_segmentation.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ImageSegmentationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ck5nb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MWJldGExL3NjaGVtYS9wcmVk",
            "aWN0L3BhcmFtcy9pbWFnZV9zZWdtZW50YXRpb24ucHJvdG8SNWdvb2dsZS5j",
            "bG91ZC5haXBsYXRmb3JtLnYxYmV0YTEuc2NoZW1hLnByZWRpY3QucGFyYW1z",
            "IkEKIUltYWdlU2VnbWVudGF0aW9uUHJlZGljdGlvblBhcmFtcxIcChRjb25m",
            "aWRlbmNlX3RocmVzaG9sZBgBIAEoAkLmAgo5Y29tLmdvb2dsZS5jbG91ZC5h",
            "aXBsYXRmb3JtLnYxYmV0YTEuc2NoZW1hLnByZWRpY3QucGFyYW1zQiZJbWFn",
            "ZVNlZ21lbnRhdGlvblByZWRpY3Rpb25QYXJhbXNQcm90b1ABWlFjbG91ZC5n",
            "b29nbGUuY29tL2dvL2FpcGxhdGZvcm0vYXBpdjFiZXRhMS9zY2hlbWEvcHJl",
            "ZGljdC9wYXJhbXMvcGFyYW1zcGI7cGFyYW1zcGKqAjVHb29nbGUuQ2xvdWQu",
            "QUlQbGF0Zm9ybS5WMUJldGExLlNjaGVtYS5QcmVkaWN0LlBhcmFtc8oCNUdv",
            "b2dsZVxDbG91ZFxBSVBsYXRmb3JtXFYxYmV0YTFcU2NoZW1hXFByZWRpY3Rc",
            "UGFyYW1z6gI7R29vZ2xlOjpDbG91ZDo6QUlQbGF0Zm9ybTo6VjFiZXRhMTo6",
            "U2NoZW1hOjpQcmVkaWN0OjpQYXJhbXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1Beta1.Schema.Predict.Params.ImageSegmentationPredictionParams), global::Google.Cloud.AIPlatform.V1Beta1.Schema.Predict.Params.ImageSegmentationPredictionParams.Parser, new[]{ "ConfidenceThreshold" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Prediction model parameters for Image Segmentation.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ImageSegmentationPredictionParams : pb::IMessage<ImageSegmentationPredictionParams>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ImageSegmentationPredictionParams> _parser = new pb::MessageParser<ImageSegmentationPredictionParams>(() => new ImageSegmentationPredictionParams());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ImageSegmentationPredictionParams> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1Beta1.Schema.Predict.Params.ImageSegmentationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ImageSegmentationPredictionParams() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ImageSegmentationPredictionParams(ImageSegmentationPredictionParams other) : this() {
      confidenceThreshold_ = other.confidenceThreshold_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ImageSegmentationPredictionParams Clone() {
      return new ImageSegmentationPredictionParams(this);
    }

    /// <summary>Field number for the "confidence_threshold" field.</summary>
    public const int ConfidenceThresholdFieldNumber = 1;
    private float confidenceThreshold_;
    /// <summary>
    /// When the model predicts category of pixels of the image, it will only
    /// provide predictions for pixels that it is at least this much confident
    /// about. All other pixels will be classified as background. Default value is
    /// 0.5.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float ConfidenceThreshold {
      get { return confidenceThreshold_; }
      set {
        confidenceThreshold_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ImageSegmentationPredictionParams);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ImageSegmentationPredictionParams other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ConfidenceThreshold, other.ConfidenceThreshold)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ConfidenceThreshold != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ConfidenceThreshold);
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
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ImageSegmentationPredictionParams other) {
      if (other == null) {
        return;
      }
      if (other.ConfidenceThreshold != 0F) {
        ConfidenceThreshold = other.ConfidenceThreshold;
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
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
