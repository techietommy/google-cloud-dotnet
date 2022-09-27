// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/dialogflow/v2beta1/human_agent_assistant_event.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Dialogflow.V2Beta1 {

  /// <summary>Holder for reflection information generated from google/cloud/dialogflow/v2beta1/human_agent_assistant_event.proto</summary>
  public static partial class HumanAgentAssistantEventReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/dialogflow/v2beta1/human_agent_assistant_event.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HumanAgentAssistantEventReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkFnb29nbGUvY2xvdWQvZGlhbG9nZmxvdy92MmJldGExL2h1bWFuX2FnZW50",
            "X2Fzc2lzdGFudF9ldmVudC5wcm90bxIfZ29vZ2xlLmNsb3VkLmRpYWxvZ2Zs",
            "b3cudjJiZXRhMRoxZ29vZ2xlL2Nsb3VkL2RpYWxvZ2Zsb3cvdjJiZXRhMS9w",
            "YXJ0aWNpcGFudC5wcm90byKUAQoYSHVtYW5BZ2VudEFzc2lzdGFudEV2ZW50",
            "EhQKDGNvbnZlcnNhdGlvbhgBIAEoCRITCgtwYXJ0aWNpcGFudBgDIAEoCRJN",
            "ChJzdWdnZXN0aW9uX3Jlc3VsdHMYBSADKAsyMS5nb29nbGUuY2xvdWQuZGlh",
            "bG9nZmxvdy52MmJldGExLlN1Z2dlc3Rpb25SZXN1bHRCuwEKI2NvbS5nb29n",
            "bGUuY2xvdWQuZGlhbG9nZmxvdy52MmJldGExQh1IdW1hbkFnZW50QXNzaXN0",
            "YW50RXZlbnRQcm90b1ABWklnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9n",
            "b29nbGVhcGlzL2Nsb3VkL2RpYWxvZ2Zsb3cvdjJiZXRhMTtkaWFsb2dmbG93",
            "+AEBogICREaqAh9Hb29nbGUuQ2xvdWQuRGlhbG9nZmxvdy5WMkJldGExYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Cloud.Dialogflow.V2Beta1.ParticipantReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Dialogflow.V2Beta1.HumanAgentAssistantEvent), global::Google.Cloud.Dialogflow.V2Beta1.HumanAgentAssistantEvent.Parser, new[]{ "Conversation", "Participant", "SuggestionResults" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Output only. Represents a notification sent to Pub/Sub subscribers for
  /// agent assistant events in a specific conversation.
  /// </summary>
  public sealed partial class HumanAgentAssistantEvent : pb::IMessage<HumanAgentAssistantEvent>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HumanAgentAssistantEvent> _parser = new pb::MessageParser<HumanAgentAssistantEvent>(() => new HumanAgentAssistantEvent());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HumanAgentAssistantEvent> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Dialogflow.V2Beta1.HumanAgentAssistantEventReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HumanAgentAssistantEvent() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HumanAgentAssistantEvent(HumanAgentAssistantEvent other) : this() {
      conversation_ = other.conversation_;
      participant_ = other.participant_;
      suggestionResults_ = other.suggestionResults_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HumanAgentAssistantEvent Clone() {
      return new HumanAgentAssistantEvent(this);
    }

    /// <summary>Field number for the "conversation" field.</summary>
    public const int ConversationFieldNumber = 1;
    private string conversation_ = "";
    /// <summary>
    /// The conversation this notification refers to.
    /// Format: `projects/&lt;Project ID>/conversations/&lt;Conversation ID>`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Conversation {
      get { return conversation_; }
      set {
        conversation_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "participant" field.</summary>
    public const int ParticipantFieldNumber = 3;
    private string participant_ = "";
    /// <summary>
    /// The participant that the suggestion is compiled for. And This field is used
    /// to call [Participants.ListSuggestions][google.cloud.dialogflow.v2beta1.Participants.ListSuggestions] API. Format:
    /// `projects/&lt;Project ID>/conversations/&lt;Conversation
    /// ID>/participants/&lt;Participant ID>`.
    /// It will not be set in legacy workflow.
    /// [HumanAgentAssistantConfig.name][google.cloud.dialogflow.v2beta1.HumanAgentAssistantConfig.name] for more
    /// information.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Participant {
      get { return participant_; }
      set {
        participant_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "suggestion_results" field.</summary>
    public const int SuggestionResultsFieldNumber = 5;
    private static readonly pb::FieldCodec<global::Google.Cloud.Dialogflow.V2Beta1.SuggestionResult> _repeated_suggestionResults_codec
        = pb::FieldCodec.ForMessage(42, global::Google.Cloud.Dialogflow.V2Beta1.SuggestionResult.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.Dialogflow.V2Beta1.SuggestionResult> suggestionResults_ = new pbc::RepeatedField<global::Google.Cloud.Dialogflow.V2Beta1.SuggestionResult>();
    /// <summary>
    /// The suggestion results payload that this notification refers to. It will
    /// only be set when
    /// [HumanAgentAssistantConfig.SuggestionConfig.group_suggestion_responses][google.cloud.dialogflow.v2beta1.HumanAgentAssistantConfig.SuggestionConfig.group_suggestion_responses]
    /// sets to true.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Cloud.Dialogflow.V2Beta1.SuggestionResult> SuggestionResults {
      get { return suggestionResults_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HumanAgentAssistantEvent);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HumanAgentAssistantEvent other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Conversation != other.Conversation) return false;
      if (Participant != other.Participant) return false;
      if(!suggestionResults_.Equals(other.suggestionResults_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Conversation.Length != 0) hash ^= Conversation.GetHashCode();
      if (Participant.Length != 0) hash ^= Participant.GetHashCode();
      hash ^= suggestionResults_.GetHashCode();
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
      if (Conversation.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Conversation);
      }
      if (Participant.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Participant);
      }
      suggestionResults_.WriteTo(output, _repeated_suggestionResults_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Conversation.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Conversation);
      }
      if (Participant.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Participant);
      }
      suggestionResults_.WriteTo(ref output, _repeated_suggestionResults_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Conversation.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Conversation);
      }
      if (Participant.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Participant);
      }
      size += suggestionResults_.CalculateSize(_repeated_suggestionResults_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HumanAgentAssistantEvent other) {
      if (other == null) {
        return;
      }
      if (other.Conversation.Length != 0) {
        Conversation = other.Conversation;
      }
      if (other.Participant.Length != 0) {
        Participant = other.Participant;
      }
      suggestionResults_.Add(other.suggestionResults_);
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
          case 10: {
            Conversation = input.ReadString();
            break;
          }
          case 26: {
            Participant = input.ReadString();
            break;
          }
          case 42: {
            suggestionResults_.AddEntriesFrom(input, _repeated_suggestionResults_codec);
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
          case 10: {
            Conversation = input.ReadString();
            break;
          }
          case 26: {
            Participant = input.ReadString();
            break;
          }
          case 42: {
            suggestionResults_.AddEntriesFrom(ref input, _repeated_suggestionResults_codec);
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