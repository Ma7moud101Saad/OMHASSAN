//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OMHASSEN
{
    using System;
    using System.Collections.Generic;
    
    public partial class ClientBillDetail
    {
        public int ID { get; set; }
        public double Amount { get; set; }
        public System.DateTime Date { get; set; }
        public double Paid { get; set; }
        public double Debt { get; set; }
        public string Type { get; set; }
        public string SaleType { get; set; }
        public double AmountPrice { get; set; }
        public string AdeyMortagaType { get; set; }
        public Nullable<int> ClientBillObj_ID { get; set; }
        public Nullable<int> ProductOpj_ID { get; set; }
        public Nullable<int> RepresentitiveBillDetailsObj_ID { get; set; }
    
        public virtual ClientBill ClientBill { get; set; }
        public virtual Product Product { get; set; }
        public virtual RepresentitiveBillDetail RepresentitiveBillDetail { get; set; }
    }
}