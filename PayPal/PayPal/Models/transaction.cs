//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PayPal.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class transaction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public transaction()
        {
            this.Ads = new HashSet<Ad>();
        }
    
        public int id { get; set; }
        public string status { get; set; }
        public Nullable<decimal> amount { get; set; }
        public string paypal_transaction_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ad> Ads { get; set; }
    }
}
