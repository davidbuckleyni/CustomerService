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
    
    public partial class ContractDetail
    {
        public int id { get; set; }
        public Nullable<System.DateTime> SignOffGoLive { get; set; }
        public Nullable<int> NoOfUsers { get; set; }
        public Nullable<decimal> BasePrice { get; set; }
        public Nullable<int> BaseUsers { get; set; }
        public Nullable<decimal> CostExtraUser { get; set; }
        public Nullable<decimal> MonthlyCharge { get; set; }
        public Nullable<decimal> RRARR { get; set; }
    }
}