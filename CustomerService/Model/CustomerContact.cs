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
    
    public partial class CustomerContact
    {
        public int id { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public Nullable<bool> isPrimayContact { get; set; }
        public Nullable<bool> isActive { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<int> PoistionId { get; set; }
        public string Name { get; set; }
        public Nullable<int> databaseID { get; set; }
    }
}
