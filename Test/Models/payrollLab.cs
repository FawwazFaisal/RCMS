//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class payrollLab
    {
        public int prLab_id { get; set; }
        public Nullable<int> prLab_OrgId { get; set; }
        public Nullable<int> prLab_LabId { get; set; }
        public Nullable<double> prLab_paymnt { get; set; }
        public string Date { get; set; }
    
        public virtual Labor Labor { get; set; }
        public virtual Labor Labor1 { get; set; }
        public virtual Organization Organization { get; set; }
    }
}
