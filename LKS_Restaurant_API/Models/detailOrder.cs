//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LKS_Restaurant_API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class detailOrder
    {
        public int detailID { get; set; }
        public int orderId { get; set; }
        public int menuId { get; set; }
        public int qty { get; set; }
        public int price { get; set; }
        public string status { get; set; }
        public string paymentStatus { get; set; }
    
        public virtual msMenu msMenu { get; set; }
        public virtual headerOrder headerOrder { get; set; }
    }
}