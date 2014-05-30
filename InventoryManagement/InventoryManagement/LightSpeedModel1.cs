using System;

using Mindscape.LightSpeed;
using Mindscape.LightSpeed.Validation;
using Mindscape.LightSpeed.Linq;

namespace InventoryManagement
{
  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  [Table("cust_orders")]
  public partial class CustOrder : Entity<int>
  {
    #region Fields
  
    [Column("order_date")]
    private System.DateTime _orderDate;
    [Column("cust_id")]
    private int _custId;

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the OrderDate entity attribute.</summary>
    public const string OrderDateField = "OrderDate";
    /// <summary>Identifies the CustId entity attribute.</summary>
    public const string CustIdField = "CustId";


    #endregion
    
    #region Relationships

    [ReverseAssociation("Orders")]
    private readonly EntityCollection<ItemOrder> _itemOrders = new EntityCollection<ItemOrder>();
    [ReverseAssociation("CustOrders")]
    private readonly EntityHolder<Customer> _cust = new EntityHolder<Customer>();


    #endregion
    
    #region Properties

    [System.Diagnostics.DebuggerNonUserCode]
    public EntityCollection<ItemOrder> ItemOrders
    {
      get { return Get(_itemOrders); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public Customer Cust
    {
      get { return Get(_cust); }
      set { Set(_cust, value); }
    }


    [System.Diagnostics.DebuggerNonUserCode]
    public System.DateTime OrderDate
    {
      get { return Get(ref _orderDate, "OrderDate"); }
      set { Set(ref _orderDate, value, "OrderDate"); }
    }

    /// <summary>Gets or sets the ID for the <see cref="Cust" /> property.</summary>
    [System.Diagnostics.DebuggerNonUserCode]
    public int CustId
    {
      get { return Get(ref _custId, "CustId"); }
      set { Set(ref _custId, value, "CustId"); }
    }

    #endregion
  }


  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  [Table("stock_items")]
  public partial class StockItem : Entity<int>
  {
    #region Fields
  
    [ValidatePresence]
    [ValidateLength(0, 50)]
    private string _name;
    private decimal _price;
    private int _quantity;

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the Name entity attribute.</summary>
    public const string NameField = "Name";
    /// <summary>Identifies the Price entity attribute.</summary>
    public const string PriceField = "Price";
    /// <summary>Identifies the Quantity entity attribute.</summary>
    public const string QuantityField = "Quantity";


    #endregion
    
    #region Relationships

    [ReverseAssociation("StockItems")]
    private readonly EntityCollection<ItemOrder> _itemOrders = new EntityCollection<ItemOrder>();


    #endregion
    
    #region Properties

    [System.Diagnostics.DebuggerNonUserCode]
    public EntityCollection<ItemOrder> ItemOrders
    {
      get { return Get(_itemOrders); }
    }


    [System.Diagnostics.DebuggerNonUserCode]
    public string Name
    {
      get { return Get(ref _name, "Name"); }
      set { Set(ref _name, value, "Name"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public decimal Price
    {
      get { return Get(ref _price, "Price"); }
      set { Set(ref _price, value, "Price"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public int Quantity
    {
      get { return Get(ref _quantity, "Quantity"); }
      set { Set(ref _quantity, value, "Quantity"); }
    }

    #endregion
  }


  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  [Table("customers")]
  public partial class Customer : Entity<int>
  {
    #region Fields
  
    [ValidatePresence]
    [ValidateLength(0, 50)]
    private string _name;
    [ValidatePresence]
    [ValidateLength(0, 50)]
    private string _address;

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the Name entity attribute.</summary>
    public const string NameField = "Name";
    /// <summary>Identifies the Address entity attribute.</summary>
    public const string AddressField = "Address";


    #endregion
    
    #region Relationships

    [ReverseAssociation("Cust")]
    private readonly EntityCollection<CustOrder> _custOrders = new EntityCollection<CustOrder>();


    #endregion
    
    #region Properties

    [System.Diagnostics.DebuggerNonUserCode]
    public EntityCollection<CustOrder> CustOrders
    {
      get { return Get(_custOrders); }
    }


    [System.Diagnostics.DebuggerNonUserCode]
    public string Name
    {
      get { return Get(ref _name, "Name"); }
      set { Set(ref _name, value, "Name"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string Address
    {
      get { return Get(ref _address, "Address"); }
      set { Set(ref _address, value, "Address"); }
    }

    #endregion
  }


  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  [Table("item_orders")]
  public partial class ItemOrder : Entity<int>
  {
    #region Fields
  
    [Column("order_quantity")]
    private int _orderQuantity;
    [Column("orders_id")]
    private int _ordersId;
    [Column("stock_items_id")]
    private int _stockItemsId;

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the OrderQuantity entity attribute.</summary>
    public const string OrderQuantityField = "OrderQuantity";
    /// <summary>Identifies the OrdersId entity attribute.</summary>
    public const string OrdersIdField = "OrdersId";
    /// <summary>Identifies the StockItemsId entity attribute.</summary>
    public const string StockItemsIdField = "StockItemsId";


    #endregion
    
    #region Relationships

    [ReverseAssociation("ItemOrders")]
    private readonly EntityHolder<CustOrder> _orders = new EntityHolder<CustOrder>();
    [ReverseAssociation("ItemOrders")]
    private readonly EntityHolder<StockItem> _stockItems = new EntityHolder<StockItem>();


    #endregion
    
    #region Properties

    [System.Diagnostics.DebuggerNonUserCode]
    public CustOrder Orders
    {
      get { return Get(_orders); }
      set { Set(_orders, value); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public StockItem StockItems
    {
      get { return Get(_stockItems); }
      set { Set(_stockItems, value); }
    }


    [System.Diagnostics.DebuggerNonUserCode]
    public int OrderQuantity
    {
      get { return Get(ref _orderQuantity, "OrderQuantity"); }
      set { Set(ref _orderQuantity, value, "OrderQuantity"); }
    }

    /// <summary>Gets or sets the ID for the <see cref="Orders" /> property.</summary>
    [System.Diagnostics.DebuggerNonUserCode]
    public int OrdersId
    {
      get { return Get(ref _ordersId, "OrdersId"); }
      set { Set(ref _ordersId, value, "OrdersId"); }
    }

    /// <summary>Gets or sets the ID for the <see cref="StockItems" /> property.</summary>
    [System.Diagnostics.DebuggerNonUserCode]
    public int StockItemsId
    {
      get { return Get(ref _stockItemsId, "StockItemsId"); }
      set { Set(ref _stockItemsId, value, "StockItemsId"); }
    }

    #endregion
  }




  /// <summary>
  /// Provides a strong-typed unit of work for working with the LightSpeedModel1 model.
  /// </summary>
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  public partial class LightSpeedModel1UnitOfWork : Mindscape.LightSpeed.UnitOfWork
  {

    public System.Linq.IQueryable<CustOrder> CustOrders
    {
      get { return this.Query<CustOrder>(); }
    }
    
    public System.Linq.IQueryable<StockItem> StockItems
    {
      get { return this.Query<StockItem>(); }
    }
    
    public System.Linq.IQueryable<Customer> Customers
    {
      get { return this.Query<Customer>(); }
    }
    
    public System.Linq.IQueryable<ItemOrder> ItemOrders
    {
      get { return this.Query<ItemOrder>(); }
    }
    
  }

}
