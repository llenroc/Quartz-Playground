// Generated by ProtoGen, Version=2.4.1.555, Culture=neutral, PublicKeyToken=55f7125234beb589.  DO NOT EDIT!
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace Proto {
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class DefeatMessage {
  
    #region Extension registration
    public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
    }
    #endregion
    #region Static variables
    internal static pbd::MessageDescriptor internal__static_DefeatMessage__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::DefeatMessage, global::DefeatMessage.Builder> internal__static_DefeatMessage__FieldAccessorTable;
    #endregion
    #region Descriptor
    public static pbd::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbd::FileDescriptor descriptor;
    
    static DefeatMessage() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNEZWZlYXRNZXNzYWdlLnByb3RvGhFCYWNrTWVzc2FnZS5wcm90bxoRQ2Fs", 
            "bE1lc3NhZ2UucHJvdG8iogEKDURlZmVhdE1lc3NhZ2USIQoEdHlwZRgBIAIo", 
            "DjITLkRlZmVhdE1lc3NhZ2UuVHlwZRIhCgtjYWxsTWVzc2FnZRgCIAEoCzIM", 
            "LkNhbGxNZXNzYWdlEiEKC2JhY2tNZXNzYWdlGAMgASgLMgwuQmFja01lc3Nh", 
          "Z2UiKAoEVHlwZRIPCgtDYWxsTWVzc2FnZRABEg8KC0JhY2tNZXNzYWdlEAI="));
      pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
        descriptor = root;
        internal__static_DefeatMessage__Descriptor = Descriptor.MessageTypes[0];
        internal__static_DefeatMessage__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::DefeatMessage, global::DefeatMessage.Builder>(internal__static_DefeatMessage__Descriptor,
                new string[] { "Type", "CallMessage", "BackMessage", });
        return null;
      };
      pbd::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
          new pbd::FileDescriptor[] {
          global::Proto.BackMessage.Descriptor, 
          global::Proto.CallMessage.Descriptor, 
          }, assigner);
    }
    #endregion
    
  }
}
#region Messages
[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
public sealed partial class DefeatMessage : pb::GeneratedMessage<DefeatMessage, DefeatMessage.Builder> {
  private DefeatMessage() { }
  private static readonly DefeatMessage defaultInstance = new DefeatMessage().MakeReadOnly();
  private static readonly string[] _defeatMessageFieldNames = new string[] { "backMessage", "callMessage", "type" };
  private static readonly uint[] _defeatMessageFieldTags = new uint[] { 26, 18, 8 };
  public static DefeatMessage DefaultInstance {
    get { return defaultInstance; }
  }
  
  public override DefeatMessage DefaultInstanceForType {
    get { return DefaultInstance; }
  }
  
  protected override DefeatMessage ThisMessage {
    get { return this; }
  }
  
  public static pbd::MessageDescriptor Descriptor {
    get { return global::Proto.DefeatMessage.internal__static_DefeatMessage__Descriptor; }
  }
  
  protected override pb::FieldAccess.FieldAccessorTable<DefeatMessage, DefeatMessage.Builder> InternalFieldAccessors {
    get { return global::Proto.DefeatMessage.internal__static_DefeatMessage__FieldAccessorTable; }
  }
  
  #region Nested types
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class Types {
    public enum Type {
      CallMessage = 1,
      BackMessage = 2,
    }
    
  }
  #endregion
  
  public const int TypeFieldNumber = 1;
  private bool hasType;
  private global::DefeatMessage.Types.Type type_ = global::DefeatMessage.Types.Type.CallMessage;
  public bool HasType {
    get { return hasType; }
  }
  public global::DefeatMessage.Types.Type Type {
    get { return type_; }
  }
  
  public const int CallMessageFieldNumber = 2;
  private bool hasCallMessage;
  private global::CallMessage callMessage_;
  public bool HasCallMessage {
    get { return hasCallMessage; }
  }
  public global::CallMessage CallMessage {
    get { return callMessage_ ?? global::CallMessage.DefaultInstance; }
  }
  
  public const int BackMessageFieldNumber = 3;
  private bool hasBackMessage;
  private global::BackMessage backMessage_;
  public bool HasBackMessage {
    get { return hasBackMessage; }
  }
  public global::BackMessage BackMessage {
    get { return backMessage_ ?? global::BackMessage.DefaultInstance; }
  }
  
  public override bool IsInitialized {
    get {
      if (!hasType) return false;
      return true;
    }
  }
  
  public override void WriteTo(pb::ICodedOutputStream output) {
    CalcSerializedSize();
    string[] field_names = _defeatMessageFieldNames;
    if (hasType) {
      output.WriteEnum(1, field_names[2], (int) Type, Type);
    }
    if (hasCallMessage) {
      output.WriteMessage(2, field_names[1], CallMessage);
    }
    if (hasBackMessage) {
      output.WriteMessage(3, field_names[0], BackMessage);
    }
    UnknownFields.WriteTo(output);
  }
  
  private int memoizedSerializedSize = -1;
  public override int SerializedSize {
    get {
      int size = memoizedSerializedSize;
      if (size != -1) return size;
      return CalcSerializedSize();
    }
  }
  
  private int CalcSerializedSize() {
    int size = memoizedSerializedSize;
    if (size != -1) return size;
    
    size = 0;
    if (hasType) {
      size += pb::CodedOutputStream.ComputeEnumSize(1, (int) Type);
    }
    if (hasCallMessage) {
      size += pb::CodedOutputStream.ComputeMessageSize(2, CallMessage);
    }
    if (hasBackMessage) {
      size += pb::CodedOutputStream.ComputeMessageSize(3, BackMessage);
    }
    size += UnknownFields.SerializedSize;
    memoizedSerializedSize = size;
    return size;
  }
  public static DefeatMessage ParseFrom(pb::ByteString data) {
    return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
  }
  public static DefeatMessage ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
    return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
  }
  public static DefeatMessage ParseFrom(byte[] data) {
    return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
  }
  public static DefeatMessage ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
    return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
  }
  public static DefeatMessage ParseFrom(global::System.IO.Stream input) {
    return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
  }
  public static DefeatMessage ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
    return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
  }
  public static DefeatMessage ParseDelimitedFrom(global::System.IO.Stream input) {
    return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
  }
  public static DefeatMessage ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
    return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
  }
  public static DefeatMessage ParseFrom(pb::ICodedInputStream input) {
    return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
  }
  public static DefeatMessage ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
    return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
  }
  private DefeatMessage MakeReadOnly() {
    return this;
  }
  
  public static Builder CreateBuilder() { return new Builder(); }
  public override Builder ToBuilder() { return CreateBuilder(this); }
  public override Builder CreateBuilderForType() { return new Builder(); }
  public static Builder CreateBuilder(DefeatMessage prototype) {
    return new Builder(prototype);
  }
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Builder : pb::GeneratedBuilder<DefeatMessage, Builder> {
    protected override Builder ThisBuilder {
      get { return this; }
    }
    public Builder() {
      result = DefaultInstance;
      resultIsReadOnly = true;
    }
    internal Builder(DefeatMessage cloneFrom) {
      result = cloneFrom;
      resultIsReadOnly = true;
    }
    
    private bool resultIsReadOnly;
    private DefeatMessage result;
    
    private DefeatMessage PrepareBuilder() {
      if (resultIsReadOnly) {
        DefeatMessage original = result;
        result = new DefeatMessage();
        resultIsReadOnly = false;
        MergeFrom(original);
      }
      return result;
    }
    
    public override bool IsInitialized {
      get { return result.IsInitialized; }
    }
    
    protected override DefeatMessage MessageBeingBuilt {
      get { return PrepareBuilder(); }
    }
    
    public override Builder Clear() {
      result = DefaultInstance;
      resultIsReadOnly = true;
      return this;
    }
    
    public override Builder Clone() {
      if (resultIsReadOnly) {
        return new Builder(result);
      } else {
        return new Builder().MergeFrom(result);
      }
    }
    
    public override pbd::MessageDescriptor DescriptorForType {
      get { return global::DefeatMessage.Descriptor; }
    }
    
    public override DefeatMessage DefaultInstanceForType {
      get { return global::DefeatMessage.DefaultInstance; }
    }
    
    public override DefeatMessage BuildPartial() {
      if (resultIsReadOnly) {
        return result;
      }
      resultIsReadOnly = true;
      return result.MakeReadOnly();
    }
    
    public override Builder MergeFrom(pb::IMessage other) {
      if (other is DefeatMessage) {
        return MergeFrom((DefeatMessage) other);
      } else {
        base.MergeFrom(other);
        return this;
      }
    }
    
    public override Builder MergeFrom(DefeatMessage other) {
      if (other == global::DefeatMessage.DefaultInstance) return this;
      PrepareBuilder();
      if (other.HasType) {
        Type = other.Type;
      }
      if (other.HasCallMessage) {
        MergeCallMessage(other.CallMessage);
      }
      if (other.HasBackMessage) {
        MergeBackMessage(other.BackMessage);
      }
      this.MergeUnknownFields(other.UnknownFields);
      return this;
    }
    
    public override Builder MergeFrom(pb::ICodedInputStream input) {
      return MergeFrom(input, pb::ExtensionRegistry.Empty);
    }
    
    public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      PrepareBuilder();
      pb::UnknownFieldSet.Builder unknownFields = null;
      uint tag;
      string field_name;
      while (input.ReadTag(out tag, out field_name)) {
        if(tag == 0 && field_name != null) {
          int field_ordinal = global::System.Array.BinarySearch(_defeatMessageFieldNames, field_name, global::System.StringComparer.Ordinal);
          if(field_ordinal >= 0)
            tag = _defeatMessageFieldTags[field_ordinal];
          else {
            if (unknownFields == null) {
              unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
            }
            ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
            continue;
          }
        }
        switch (tag) {
          case 0: {
            throw pb::InvalidProtocolBufferException.InvalidTag();
          }
          default: {
            if (pb::WireFormat.IsEndGroupTag(tag)) {
              if (unknownFields != null) {
                this.UnknownFields = unknownFields.Build();
              }
              return this;
            }
            if (unknownFields == null) {
              unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
            }
            ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
            break;
          }
          case 8: {
            object unknown;
            if(input.ReadEnum(ref result.type_, out unknown)) {
              result.hasType = true;
            } else if(unknown is int) {
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              unknownFields.MergeVarintField(1, (ulong)(int)unknown);
            }
            break;
          }
          case 18: {
            global::CallMessage.Builder subBuilder = global::CallMessage.CreateBuilder();
            if (result.hasCallMessage) {
              subBuilder.MergeFrom(CallMessage);
            }
            input.ReadMessage(subBuilder, extensionRegistry);
            CallMessage = subBuilder.BuildPartial();
            break;
          }
          case 26: {
            global::BackMessage.Builder subBuilder = global::BackMessage.CreateBuilder();
            if (result.hasBackMessage) {
              subBuilder.MergeFrom(BackMessage);
            }
            input.ReadMessage(subBuilder, extensionRegistry);
            BackMessage = subBuilder.BuildPartial();
            break;
          }
        }
      }
      
      if (unknownFields != null) {
        this.UnknownFields = unknownFields.Build();
      }
      return this;
    }
    
    
    public bool HasType {
     get { return result.hasType; }
    }
    public global::DefeatMessage.Types.Type Type {
      get { return result.Type; }
      set { SetType(value); }
    }
    public Builder SetType(global::DefeatMessage.Types.Type value) {
      PrepareBuilder();
      result.hasType = true;
      result.type_ = value;
      return this;
    }
    public Builder ClearType() {
      PrepareBuilder();
      result.hasType = false;
      result.type_ = global::DefeatMessage.Types.Type.CallMessage;
      return this;
    }
    
    public bool HasCallMessage {
     get { return result.hasCallMessage; }
    }
    public global::CallMessage CallMessage {
      get { return result.CallMessage; }
      set { SetCallMessage(value); }
    }
    public Builder SetCallMessage(global::CallMessage value) {
      pb::ThrowHelper.ThrowIfNull(value, "value");
      PrepareBuilder();
      result.hasCallMessage = true;
      result.callMessage_ = value;
      return this;
    }
    public Builder SetCallMessage(global::CallMessage.Builder builderForValue) {
      pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
      PrepareBuilder();
      result.hasCallMessage = true;
      result.callMessage_ = builderForValue.Build();
      return this;
    }
    public Builder MergeCallMessage(global::CallMessage value) {
      pb::ThrowHelper.ThrowIfNull(value, "value");
      PrepareBuilder();
      if (result.hasCallMessage &&
          result.callMessage_ != global::CallMessage.DefaultInstance) {
          result.callMessage_ = global::CallMessage.CreateBuilder(result.callMessage_).MergeFrom(value).BuildPartial();
      } else {
        result.callMessage_ = value;
      }
      result.hasCallMessage = true;
      return this;
    }
    public Builder ClearCallMessage() {
      PrepareBuilder();
      result.hasCallMessage = false;
      result.callMessage_ = null;
      return this;
    }
    
    public bool HasBackMessage {
     get { return result.hasBackMessage; }
    }
    public global::BackMessage BackMessage {
      get { return result.BackMessage; }
      set { SetBackMessage(value); }
    }
    public Builder SetBackMessage(global::BackMessage value) {
      pb::ThrowHelper.ThrowIfNull(value, "value");
      PrepareBuilder();
      result.hasBackMessage = true;
      result.backMessage_ = value;
      return this;
    }
    public Builder SetBackMessage(global::BackMessage.Builder builderForValue) {
      pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
      PrepareBuilder();
      result.hasBackMessage = true;
      result.backMessage_ = builderForValue.Build();
      return this;
    }
    public Builder MergeBackMessage(global::BackMessage value) {
      pb::ThrowHelper.ThrowIfNull(value, "value");
      PrepareBuilder();
      if (result.hasBackMessage &&
          result.backMessage_ != global::BackMessage.DefaultInstance) {
          result.backMessage_ = global::BackMessage.CreateBuilder(result.backMessage_).MergeFrom(value).BuildPartial();
      } else {
        result.backMessage_ = value;
      }
      result.hasBackMessage = true;
      return this;
    }
    public Builder ClearBackMessage() {
      PrepareBuilder();
      result.hasBackMessage = false;
      result.backMessage_ = null;
      return this;
    }
  }
  static DefeatMessage() {
    object.ReferenceEquals(global::Proto.DefeatMessage.Descriptor, null);
  }
}

#endregion


#endregion Designer generated code
