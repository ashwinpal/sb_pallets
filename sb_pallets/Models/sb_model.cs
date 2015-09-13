using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;
using System.Data.Linq;

namespace sb_pallets.Models
{
    public class sb_model
    {
    }

    public partial class Customer_Detail
    {
    }

    [MetadataType(typeof(item_validation_model))]
    public partial class Item_Detail
    {
    }

    public partial class Pallets_Description
    {

    }

    public partial class Production_Order
    {

    }

    [MetadataType(typeof(purchase_validation_model))]
    public partial class Purchased_Order
    { 
    }

    [MetadataType(typeof(vendor_validation_model))]
    public partial class Vendor_Detail
    {

    }

    /*
     * All the models for the views 
     * 
     */

    [Bind(Exclude = "vendor_id")]
    public class vendor_validation_model
    {
        public string vendor_id { get; set; }

        [DisplayName("Vendor Address")]
        [Required(ErrorMessage = "Please enter the Vendor Address")]
        public string vendor_address { get; set; }

    }


    [Bind(Exclude = "item_id")]
    public class item_validation_model
    {
        public string item_id { get; set; }

        [DisplayName("Item Description")]
        [Required(ErrorMessage = "Please enter the Item Description")]
        public string item_description { get; set; }
    }


    [Bind(Exclude = "purchase_id, order_number, amount")]
    public class purchase_validation_model
    {
        public int purchase_id { get; set; }

        public int vendor_id {get; set;}

        public List<int> item_ids { get; set; }

        [DisplayName("Order Date")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please enter the Order Date Description")]
        public System.DateTime order_date {get; set;}

        [DisplayName("Request Date")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please enter the Request Date")]
        public System.DateTime request_date { get; set; }

        [DisplayName("Ordered By")]
        [Required(ErrorMessage = "Please enter the Name")]
        public string order_by_name { get; set; }

        [DisplayName("Confirmed By")]
        [Required(ErrorMessage = "Please enter the Name")]
        public string confirm_by_name { get; set; }

        [DisplayName("Term(days)")]
        [Required(ErrorMessage = "Please enter the number of days")]
        public int terms_days { get; set; }

        [DisplayName("Ship Via")]
        [Required(ErrorMessage = "Please choose a Shipping Method")]
        public bool ship_via { get; set; }

        public int order_number { get; set; }

        [DisplayName("Quantity")]
        [Required(ErrorMessage = "Please enter the Item Quantity")]
        public int item_quantity { get; set; }

        [DisplayName("Unit Price")]
        [Required(ErrorMessage = "Please enter the Item's Unit Price")]
        public decimal unit_price { get; set; }

        [DisplayName("Price F.B.M")]
        [Required(ErrorMessage = "Please enter the Price F.B.M")]
        public decimal price_fbm { get; set; }

        public decimal amount { get; set; }

        public EntityRef<Vendor_Detail> Vendor_Detail { get; set; }

        public EntityRef<Item_Detail> Item_Detail { get; set; }

    }


}