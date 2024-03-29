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
    
    public partial class RepresentitiveBillDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RepresentitiveBillDetail()
        {
            this.ClientBillDetails = new HashSet<ClientBillDetail>();
        }
    
        public int ID { get; set; }
        public double GivenAmount { get; set; }
        public double SaledAmount { get; set; }
        public double ReturnedAmount { get; set; }
        public double GivenAmountPrice { get; set; }
        public double SaledAmountPrice { get; set; }
        public double ReturnedAmountPrice { get; set; }
        public System.DateTime Date { get; set; }
        public string SaleType { get; set; }
        public Nullable<int> ProductObj_ID { get; set; }
        public Nullable<int> RepresentitiveBillObj_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientBillDetail> ClientBillDetails { get; set; }
        public virtual Product Product { get; set; }
        public virtual RepresentitiveBill RepresentitiveBill { get; set; }
    }
}
