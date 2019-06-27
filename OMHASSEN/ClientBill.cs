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
    
    public partial class ClientBill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ClientBill()
        {
            this.ClientBillDetails = new HashSet<ClientBillDetail>();
        }
    
        public int ID { get; set; }
        public string type { get; set; }
        public string AgelCahType { get; set; }
        public Nullable<double> PaidPrice { get; set; }
        public Nullable<double> DeptPrice { get; set; }
        public Nullable<double> TotalPrice { get; set; }
        public Nullable<int> ClientObj_NationalID { get; set; }
        public Nullable<int> RepresentiveOBject_NationalID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientBillDetail> ClientBillDetails { get; set; }
        public virtual Client Client { get; set; }
        public virtual Representitive Representitive { get; set; }
    }
}