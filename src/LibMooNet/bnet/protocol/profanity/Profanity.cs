// Generated by ProtoGen, Version=2.4.1.473, Culture=neutral, PublicKeyToken=55f7125234beb589.  DO NOT EDIT!
#pragma warning disable 1591, 0612
#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace bnet.protocol.profanity {
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
  public static partial class Profanity {
  
    #region Extension registration
    public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
    }
    #endregion
    #region Static variables
    internal static pbd::MessageDescriptor internal__static_bnet_protocol_profanity_WordFilter__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::bnet.protocol.profanity.WordFilter, global::bnet.protocol.profanity.WordFilter.Builder> internal__static_bnet_protocol_profanity_WordFilter__FieldAccessorTable;
    internal static pbd::MessageDescriptor internal__static_bnet_protocol_profanity_WordFilters__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::bnet.protocol.profanity.WordFilters, global::bnet.protocol.profanity.WordFilters.Builder> internal__static_bnet_protocol_profanity_WordFilters__FieldAccessorTable;
    #endregion
    #region Descriptor
    public static pbd::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbd::FileDescriptor descriptor;
    
    static Profanity() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          "Ch1saWIvcHJvZmFuaXR5L3Byb2Zhbml0eS5wcm90bxIXYm5ldC5wcm90b2Nv" + 
          "bC5wcm9mYW5pdHkiKQoKV29yZEZpbHRlchIMCgR0eXBlGAEgAigJEg0KBXJl" + 
          "Z2V4GAIgAigJIkMKC1dvcmRGaWx0ZXJzEjQKB2ZpbHRlcnMYASADKAsyIy5i" + 
          "bmV0LnByb3RvY29sLnByb2Zhbml0eS5Xb3JkRmlsdGVy");
      pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
        descriptor = root;
        internal__static_bnet_protocol_profanity_WordFilter__Descriptor = Descriptor.MessageTypes[0];
        internal__static_bnet_protocol_profanity_WordFilter__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::bnet.protocol.profanity.WordFilter, global::bnet.protocol.profanity.WordFilter.Builder>(internal__static_bnet_protocol_profanity_WordFilter__Descriptor,
                new string[] { "Type", "Regex", });
        internal__static_bnet_protocol_profanity_WordFilters__Descriptor = Descriptor.MessageTypes[1];
        internal__static_bnet_protocol_profanity_WordFilters__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::bnet.protocol.profanity.WordFilters, global::bnet.protocol.profanity.WordFilters.Builder>(internal__static_bnet_protocol_profanity_WordFilters__Descriptor,
                new string[] { "Filters", });
        return null;
      };
      pbd::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
          new pbd::FileDescriptor[] {
          }, assigner);
    }
    #endregion
    
  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
  public sealed partial class WordFilter : pb::GeneratedMessage<WordFilter, WordFilter.Builder> {
    private WordFilter() { }
    private static readonly WordFilter defaultInstance = new WordFilter().MakeReadOnly();
    private static readonly string[] _wordFilterFieldNames = new string[] { "regex", "type" };
    private static readonly uint[] _wordFilterFieldTags = new uint[] { 18, 10 };
    public static WordFilter DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override WordFilter DefaultInstanceForType {
      get { return DefaultInstance; }
    }
    
    protected override WordFilter ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::bnet.protocol.profanity.Profanity.internal__static_bnet_protocol_profanity_WordFilter__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<WordFilter, WordFilter.Builder> InternalFieldAccessors {
      get { return global::bnet.protocol.profanity.Profanity.internal__static_bnet_protocol_profanity_WordFilter__FieldAccessorTable; }
    }
    
    public const int TypeFieldNumber = 1;
    private bool hasType;
    private string type_ = "";
    public bool HasType {
      get { return hasType; }
    }
    public string Type {
      get { return type_; }
    }
    
    public const int RegexFieldNumber = 2;
    private bool hasRegex;
    private string regex_ = "";
    public bool HasRegex {
      get { return hasRegex; }
    }
    public string Regex {
      get { return regex_; }
    }
    
    public override bool IsInitialized {
      get {
        if (!hasType) return false;
        if (!hasRegex) return false;
        return true;
      }
    }
    
    public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _wordFilterFieldNames;
      if (hasType) {
        output.WriteString(1, field_names[1], Type);
      }
      if (hasRegex) {
        output.WriteString(2, field_names[0], Regex);
      }
      UnknownFields.WriteTo(output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasType) {
          size += pb::CodedOutputStream.ComputeStringSize(1, Type);
        }
        if (hasRegex) {
          size += pb::CodedOutputStream.ComputeStringSize(2, Regex);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }
    
    public static WordFilter ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static WordFilter ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static WordFilter ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static WordFilter ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static WordFilter ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static WordFilter ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static WordFilter ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static WordFilter ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static WordFilter ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static WordFilter ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    private WordFilter MakeReadOnly() {
      return this;
    }
    
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(WordFilter prototype) {
      return new Builder(prototype);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
    public sealed partial class Builder : pb::GeneratedBuilder<WordFilter, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(WordFilter cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }
      
      private bool resultIsReadOnly;
      private WordFilter result;
      
      private WordFilter PrepareBuilder() {
        if (resultIsReadOnly) {
          WordFilter original = result;
          result = new WordFilter();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }
      
      public override bool IsInitialized {
        get { return result.IsInitialized; }
      }
      
      protected override WordFilter MessageBeingBuilt {
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
        get { return global::bnet.protocol.profanity.WordFilter.Descriptor; }
      }
      
      public override WordFilter DefaultInstanceForType {
        get { return global::bnet.protocol.profanity.WordFilter.DefaultInstance; }
      }
      
      public override WordFilter BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is WordFilter) {
          return MergeFrom((WordFilter) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(WordFilter other) {
        if (other == global::bnet.protocol.profanity.WordFilter.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasType) {
          Type = other.Type;
        }
        if (other.HasRegex) {
          Regex = other.Regex;
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
            int field_ordinal = global::System.Array.BinarySearch(_wordFilterFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _wordFilterFieldTags[field_ordinal];
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
            case 10: {
              result.hasType = input.ReadString(ref result.type_);
              break;
            }
            case 18: {
              result.hasRegex = input.ReadString(ref result.regex_);
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
      public string Type {
        get { return result.Type; }
        set { SetType(value); }
      }
      public Builder SetType(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasType = true;
        result.type_ = value;
        return this;
      }
      public Builder ClearType() {
        PrepareBuilder();
        result.hasType = false;
        result.type_ = "";
        return this;
      }
      
      public bool HasRegex {
        get { return result.hasRegex; }
      }
      public string Regex {
        get { return result.Regex; }
        set { SetRegex(value); }
      }
      public Builder SetRegex(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasRegex = true;
        result.regex_ = value;
        return this;
      }
      public Builder ClearRegex() {
        PrepareBuilder();
        result.hasRegex = false;
        result.regex_ = "";
        return this;
      }
    }
    static WordFilter() {
      object.ReferenceEquals(global::bnet.protocol.profanity.Profanity.Descriptor, null);
    }
  }
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
  public sealed partial class WordFilters : pb::GeneratedMessage<WordFilters, WordFilters.Builder> {
    private WordFilters() { }
    private static readonly WordFilters defaultInstance = new WordFilters().MakeReadOnly();
    private static readonly string[] _wordFiltersFieldNames = new string[] { "filters" };
    private static readonly uint[] _wordFiltersFieldTags = new uint[] { 10 };
    public static WordFilters DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override WordFilters DefaultInstanceForType {
      get { return DefaultInstance; }
    }
    
    protected override WordFilters ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::bnet.protocol.profanity.Profanity.internal__static_bnet_protocol_profanity_WordFilters__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<WordFilters, WordFilters.Builder> InternalFieldAccessors {
      get { return global::bnet.protocol.profanity.Profanity.internal__static_bnet_protocol_profanity_WordFilters__FieldAccessorTable; }
    }
    
    public const int FiltersFieldNumber = 1;
    private pbc::PopsicleList<global::bnet.protocol.profanity.WordFilter> filters_ = new pbc::PopsicleList<global::bnet.protocol.profanity.WordFilter>();
    public scg::IList<global::bnet.protocol.profanity.WordFilter> FiltersList {
      get { return filters_; }
    }
    public int FiltersCount {
      get { return filters_.Count; }
    }
    public global::bnet.protocol.profanity.WordFilter GetFilters(int index) {
      return filters_[index];
    }
    
    public override bool IsInitialized {
      get {
        foreach (global::bnet.protocol.profanity.WordFilter element in FiltersList) {
          if (!element.IsInitialized) return false;
        }
        return true;
      }
    }
    
    public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _wordFiltersFieldNames;
      if (filters_.Count > 0) {
        output.WriteMessageArray(1, field_names[0], filters_);
      }
      UnknownFields.WriteTo(output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        foreach (global::bnet.protocol.profanity.WordFilter element in FiltersList) {
          size += pb::CodedOutputStream.ComputeMessageSize(1, element);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }
    
    public static WordFilters ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static WordFilters ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static WordFilters ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static WordFilters ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static WordFilters ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static WordFilters ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static WordFilters ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static WordFilters ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static WordFilters ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static WordFilters ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    private WordFilters MakeReadOnly() {
      filters_.MakeReadOnly();
      return this;
    }
    
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(WordFilters prototype) {
      return new Builder(prototype);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
    public sealed partial class Builder : pb::GeneratedBuilder<WordFilters, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(WordFilters cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }
      
      private bool resultIsReadOnly;
      private WordFilters result;
      
      private WordFilters PrepareBuilder() {
        if (resultIsReadOnly) {
          WordFilters original = result;
          result = new WordFilters();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }
      
      public override bool IsInitialized {
        get { return result.IsInitialized; }
      }
      
      protected override WordFilters MessageBeingBuilt {
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
        get { return global::bnet.protocol.profanity.WordFilters.Descriptor; }
      }
      
      public override WordFilters DefaultInstanceForType {
        get { return global::bnet.protocol.profanity.WordFilters.DefaultInstance; }
      }
      
      public override WordFilters BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is WordFilters) {
          return MergeFrom((WordFilters) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(WordFilters other) {
        if (other == global::bnet.protocol.profanity.WordFilters.DefaultInstance) return this;
        PrepareBuilder();
        if (other.filters_.Count != 0) {
          result.filters_.Add(other.filters_);
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
            int field_ordinal = global::System.Array.BinarySearch(_wordFiltersFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _wordFiltersFieldTags[field_ordinal];
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
            case 10: {
              input.ReadMessageArray(tag, field_name, result.filters_, global::bnet.protocol.profanity.WordFilter.DefaultInstance, extensionRegistry);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }
      
      
      public pbc::IPopsicleList<global::bnet.protocol.profanity.WordFilter> FiltersList {
        get { return PrepareBuilder().filters_; }
      }
      public int FiltersCount {
        get { return result.FiltersCount; }
      }
      public global::bnet.protocol.profanity.WordFilter GetFilters(int index) {
        return result.GetFilters(index);
      }
      public Builder SetFilters(int index, global::bnet.protocol.profanity.WordFilter value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.filters_[index] = value;
        return this;
      }
      public Builder SetFilters(int index, global::bnet.protocol.profanity.WordFilter.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.filters_[index] = builderForValue.Build();
        return this;
      }
      public Builder AddFilters(global::bnet.protocol.profanity.WordFilter value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.filters_.Add(value);
        return this;
      }
      public Builder AddFilters(global::bnet.protocol.profanity.WordFilter.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.filters_.Add(builderForValue.Build());
        return this;
      }
      public Builder AddRangeFilters(scg::IEnumerable<global::bnet.protocol.profanity.WordFilter> values) {
        PrepareBuilder();
        result.filters_.Add(values);
        return this;
      }
      public Builder ClearFilters() {
        PrepareBuilder();
        result.filters_.Clear();
        return this;
      }
    }
    static WordFilters() {
      object.ReferenceEquals(global::bnet.protocol.profanity.Profanity.Descriptor, null);
    }
  }
  
  #endregion
  
}

#endregion Designer generated code
