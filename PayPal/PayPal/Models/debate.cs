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
    
    public partial class debate
    {
        public int id { get; set; }
        public System.DateTime requested_date { get; set; }
        public string topic { get; set; }
        public int first_list { get; set; }
        public int second_list { get; set; }
        public string status { get; set; }
        public string Zoom_link { get; set; }
        public string details { get; set; }
        public Nullable<System.DateTime> debate_date { get; set; }
    
        public virtual election_list election_list { get; set; }
        public virtual election_list election_list1 { get; set; }
    }
}
