//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CustomerService.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class AddOn
    {
        public int id { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> PeriscopeCost { get; set; }
        public Nullable<bool> RxNT { get; set; }
        public Nullable<bool> OQAnalyst { get; set; }
        public Nullable<bool> Availity { get; set; }
        public Nullable<int> PeriscopeStatus { get; set; }
        public string PeriscopeStatusOther { get; set; }
        public Nullable<int> databaseID { get; set; }
    }
}
