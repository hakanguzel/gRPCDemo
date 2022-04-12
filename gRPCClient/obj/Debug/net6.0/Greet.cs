// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: greet.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace GrpcService.Protos {

  /// <summary>Holder for reflection information generated from greet.proto</summary>
  public static partial class GreetReflection {

    #region Descriptor
    /// <summary>File descriptor for greet.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GreetReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgtncmVldC5wcm90bxIFc2FsZXMaH2dvb2dsZS9wcm90b2J1Zi90aW1lc3Rh",
            "bXAucHJvdG8iGgoHUmVxdWVzdBIPCgdmaWx0ZXJzGAEgASgJIqcCCg5TYWxl",
            "c0RhdGFNb2RlbBIPCgdPcmRlcklEGAEgASgFEg4KBlJlZ2lvbhgCIAEoCRIP",
            "CgdDb3VudHJ5GAMgASgJEhAKCEl0ZW1UeXBlGAQgASgJEi0KCU9yZGVyRGF0",
            "ZRgFIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1lc3RhbXASLAoIU2hpcERh",
            "dGUYBiABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1wEhEKCVVuaXRz",
            "U29sZBgHIAEoBRIQCghVbml0Q29zdBgIIAEoAhIRCglVbml0UHJpY2UYCSAB",
            "KAISFAoMVG90YWxSZXZlbnVlGAogASgFEhEKCVRvdGFsQ29zdBgLIAEoBRIT",
            "CgtUb3RhbFByb2ZpdBgMIAEoBTJJCgxTYWxlc1NlcnZpY2USOQoMR2V0U2Fs",
            "ZXNEYXRhEg4uc2FsZXMuUmVxdWVzdBoVLnNhbGVzLlNhbGVzRGF0YU1vZGVs",
            "IgAwAUIVqgISR3JwY1NlcnZpY2UuUHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcService.Protos.Request), global::GrpcService.Protos.Request.Parser, new[]{ "Filters" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcService.Protos.SalesDataModel), global::GrpcService.Protos.SalesDataModel.Parser, new[]{ "OrderID", "Region", "Country", "ItemType", "OrderDate", "ShipDate", "UnitsSold", "UnitCost", "UnitPrice", "TotalRevenue", "TotalCost", "TotalProfit" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Request : pb::IMessage<Request>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Request> _parser = new pb::MessageParser<Request>(() => new Request());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Request> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcService.Protos.GreetReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Request() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Request(Request other) : this() {
      filters_ = other.filters_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Request Clone() {
      return new Request(this);
    }

    /// <summary>Field number for the "filters" field.</summary>
    public const int FiltersFieldNumber = 1;
    private string filters_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Filters {
      get { return filters_; }
      set {
        filters_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Request);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Request other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Filters != other.Filters) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Filters.Length != 0) hash ^= Filters.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Filters.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Filters);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Filters.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Filters);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Filters.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Filters);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Request other) {
      if (other == null) {
        return;
      }
      if (other.Filters.Length != 0) {
        Filters = other.Filters;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
            Filters = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Filters = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class SalesDataModel : pb::IMessage<SalesDataModel>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SalesDataModel> _parser = new pb::MessageParser<SalesDataModel>(() => new SalesDataModel());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SalesDataModel> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcService.Protos.GreetReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SalesDataModel() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SalesDataModel(SalesDataModel other) : this() {
      orderID_ = other.orderID_;
      region_ = other.region_;
      country_ = other.country_;
      itemType_ = other.itemType_;
      orderDate_ = other.orderDate_ != null ? other.orderDate_.Clone() : null;
      shipDate_ = other.shipDate_ != null ? other.shipDate_.Clone() : null;
      unitsSold_ = other.unitsSold_;
      unitCost_ = other.unitCost_;
      unitPrice_ = other.unitPrice_;
      totalRevenue_ = other.totalRevenue_;
      totalCost_ = other.totalCost_;
      totalProfit_ = other.totalProfit_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SalesDataModel Clone() {
      return new SalesDataModel(this);
    }

    /// <summary>Field number for the "OrderID" field.</summary>
    public const int OrderIDFieldNumber = 1;
    private int orderID_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int OrderID {
      get { return orderID_; }
      set {
        orderID_ = value;
      }
    }

    /// <summary>Field number for the "Region" field.</summary>
    public const int RegionFieldNumber = 2;
    private string region_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Region {
      get { return region_; }
      set {
        region_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Country" field.</summary>
    public const int CountryFieldNumber = 3;
    private string country_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Country {
      get { return country_; }
      set {
        country_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ItemType" field.</summary>
    public const int ItemTypeFieldNumber = 4;
    private string itemType_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ItemType {
      get { return itemType_; }
      set {
        itemType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "OrderDate" field.</summary>
    public const int OrderDateFieldNumber = 5;
    private global::Google.Protobuf.WellKnownTypes.Timestamp orderDate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp OrderDate {
      get { return orderDate_; }
      set {
        orderDate_ = value;
      }
    }

    /// <summary>Field number for the "ShipDate" field.</summary>
    public const int ShipDateFieldNumber = 6;
    private global::Google.Protobuf.WellKnownTypes.Timestamp shipDate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp ShipDate {
      get { return shipDate_; }
      set {
        shipDate_ = value;
      }
    }

    /// <summary>Field number for the "UnitsSold" field.</summary>
    public const int UnitsSoldFieldNumber = 7;
    private int unitsSold_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int UnitsSold {
      get { return unitsSold_; }
      set {
        unitsSold_ = value;
      }
    }

    /// <summary>Field number for the "UnitCost" field.</summary>
    public const int UnitCostFieldNumber = 8;
    private float unitCost_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float UnitCost {
      get { return unitCost_; }
      set {
        unitCost_ = value;
      }
    }

    /// <summary>Field number for the "UnitPrice" field.</summary>
    public const int UnitPriceFieldNumber = 9;
    private float unitPrice_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float UnitPrice {
      get { return unitPrice_; }
      set {
        unitPrice_ = value;
      }
    }

    /// <summary>Field number for the "TotalRevenue" field.</summary>
    public const int TotalRevenueFieldNumber = 10;
    private int totalRevenue_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int TotalRevenue {
      get { return totalRevenue_; }
      set {
        totalRevenue_ = value;
      }
    }

    /// <summary>Field number for the "TotalCost" field.</summary>
    public const int TotalCostFieldNumber = 11;
    private int totalCost_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int TotalCost {
      get { return totalCost_; }
      set {
        totalCost_ = value;
      }
    }

    /// <summary>Field number for the "TotalProfit" field.</summary>
    public const int TotalProfitFieldNumber = 12;
    private int totalProfit_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int TotalProfit {
      get { return totalProfit_; }
      set {
        totalProfit_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SalesDataModel);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SalesDataModel other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OrderID != other.OrderID) return false;
      if (Region != other.Region) return false;
      if (Country != other.Country) return false;
      if (ItemType != other.ItemType) return false;
      if (!object.Equals(OrderDate, other.OrderDate)) return false;
      if (!object.Equals(ShipDate, other.ShipDate)) return false;
      if (UnitsSold != other.UnitsSold) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(UnitCost, other.UnitCost)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(UnitPrice, other.UnitPrice)) return false;
      if (TotalRevenue != other.TotalRevenue) return false;
      if (TotalCost != other.TotalCost) return false;
      if (TotalProfit != other.TotalProfit) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (OrderID != 0) hash ^= OrderID.GetHashCode();
      if (Region.Length != 0) hash ^= Region.GetHashCode();
      if (Country.Length != 0) hash ^= Country.GetHashCode();
      if (ItemType.Length != 0) hash ^= ItemType.GetHashCode();
      if (orderDate_ != null) hash ^= OrderDate.GetHashCode();
      if (shipDate_ != null) hash ^= ShipDate.GetHashCode();
      if (UnitsSold != 0) hash ^= UnitsSold.GetHashCode();
      if (UnitCost != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(UnitCost);
      if (UnitPrice != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(UnitPrice);
      if (TotalRevenue != 0) hash ^= TotalRevenue.GetHashCode();
      if (TotalCost != 0) hash ^= TotalCost.GetHashCode();
      if (TotalProfit != 0) hash ^= TotalProfit.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (OrderID != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(OrderID);
      }
      if (Region.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Region);
      }
      if (Country.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Country);
      }
      if (ItemType.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ItemType);
      }
      if (orderDate_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(OrderDate);
      }
      if (shipDate_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(ShipDate);
      }
      if (UnitsSold != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(UnitsSold);
      }
      if (UnitCost != 0F) {
        output.WriteRawTag(69);
        output.WriteFloat(UnitCost);
      }
      if (UnitPrice != 0F) {
        output.WriteRawTag(77);
        output.WriteFloat(UnitPrice);
      }
      if (TotalRevenue != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(TotalRevenue);
      }
      if (TotalCost != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(TotalCost);
      }
      if (TotalProfit != 0) {
        output.WriteRawTag(96);
        output.WriteInt32(TotalProfit);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (OrderID != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(OrderID);
      }
      if (Region.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Region);
      }
      if (Country.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Country);
      }
      if (ItemType.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ItemType);
      }
      if (orderDate_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(OrderDate);
      }
      if (shipDate_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(ShipDate);
      }
      if (UnitsSold != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(UnitsSold);
      }
      if (UnitCost != 0F) {
        output.WriteRawTag(69);
        output.WriteFloat(UnitCost);
      }
      if (UnitPrice != 0F) {
        output.WriteRawTag(77);
        output.WriteFloat(UnitPrice);
      }
      if (TotalRevenue != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(TotalRevenue);
      }
      if (TotalCost != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(TotalCost);
      }
      if (TotalProfit != 0) {
        output.WriteRawTag(96);
        output.WriteInt32(TotalProfit);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (OrderID != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(OrderID);
      }
      if (Region.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Region);
      }
      if (Country.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Country);
      }
      if (ItemType.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ItemType);
      }
      if (orderDate_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(OrderDate);
      }
      if (shipDate_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ShipDate);
      }
      if (UnitsSold != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(UnitsSold);
      }
      if (UnitCost != 0F) {
        size += 1 + 4;
      }
      if (UnitPrice != 0F) {
        size += 1 + 4;
      }
      if (TotalRevenue != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(TotalRevenue);
      }
      if (TotalCost != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(TotalCost);
      }
      if (TotalProfit != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(TotalProfit);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SalesDataModel other) {
      if (other == null) {
        return;
      }
      if (other.OrderID != 0) {
        OrderID = other.OrderID;
      }
      if (other.Region.Length != 0) {
        Region = other.Region;
      }
      if (other.Country.Length != 0) {
        Country = other.Country;
      }
      if (other.ItemType.Length != 0) {
        ItemType = other.ItemType;
      }
      if (other.orderDate_ != null) {
        if (orderDate_ == null) {
          OrderDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        OrderDate.MergeFrom(other.OrderDate);
      }
      if (other.shipDate_ != null) {
        if (shipDate_ == null) {
          ShipDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        ShipDate.MergeFrom(other.ShipDate);
      }
      if (other.UnitsSold != 0) {
        UnitsSold = other.UnitsSold;
      }
      if (other.UnitCost != 0F) {
        UnitCost = other.UnitCost;
      }
      if (other.UnitPrice != 0F) {
        UnitPrice = other.UnitPrice;
      }
      if (other.TotalRevenue != 0) {
        TotalRevenue = other.TotalRevenue;
      }
      if (other.TotalCost != 0) {
        TotalCost = other.TotalCost;
      }
      if (other.TotalProfit != 0) {
        TotalProfit = other.TotalProfit;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
            OrderID = input.ReadInt32();
            break;
          }
          case 18: {
            Region = input.ReadString();
            break;
          }
          case 26: {
            Country = input.ReadString();
            break;
          }
          case 34: {
            ItemType = input.ReadString();
            break;
          }
          case 42: {
            if (orderDate_ == null) {
              OrderDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(OrderDate);
            break;
          }
          case 50: {
            if (shipDate_ == null) {
              ShipDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ShipDate);
            break;
          }
          case 56: {
            UnitsSold = input.ReadInt32();
            break;
          }
          case 69: {
            UnitCost = input.ReadFloat();
            break;
          }
          case 77: {
            UnitPrice = input.ReadFloat();
            break;
          }
          case 80: {
            TotalRevenue = input.ReadInt32();
            break;
          }
          case 88: {
            TotalCost = input.ReadInt32();
            break;
          }
          case 96: {
            TotalProfit = input.ReadInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            OrderID = input.ReadInt32();
            break;
          }
          case 18: {
            Region = input.ReadString();
            break;
          }
          case 26: {
            Country = input.ReadString();
            break;
          }
          case 34: {
            ItemType = input.ReadString();
            break;
          }
          case 42: {
            if (orderDate_ == null) {
              OrderDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(OrderDate);
            break;
          }
          case 50: {
            if (shipDate_ == null) {
              ShipDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ShipDate);
            break;
          }
          case 56: {
            UnitsSold = input.ReadInt32();
            break;
          }
          case 69: {
            UnitCost = input.ReadFloat();
            break;
          }
          case 77: {
            UnitPrice = input.ReadFloat();
            break;
          }
          case 80: {
            TotalRevenue = input.ReadInt32();
            break;
          }
          case 88: {
            TotalCost = input.ReadInt32();
            break;
          }
          case 96: {
            TotalProfit = input.ReadInt32();
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
