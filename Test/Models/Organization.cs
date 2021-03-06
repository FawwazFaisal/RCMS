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
    using System.ComponentModel.DataAnnotations;
    
    public partial class Organization
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Organization()
        {
            this.Complaints = new HashSet<Complaint>();
            this.LabAsigns = new HashSet<LabAsign>();
            this.LabAsigns1 = new HashSet<LabAsign>();
            this.Labors = new HashSet<Labor>();
            this.PayrollCusts = new HashSet<PayrollCust>();
            this.payrollLabs = new HashSet<payrollLab>();
            this.Ratings = new HashSet<Rating>();
            this.Reviews = new HashSet<Review>();
            this.Reviews1 = new HashSet<Review>();
        }
    
        public int org_id { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name ="Name")]
        public string org_name { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Address")]
        public string address { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone No.")]
        public string Ph_no { get; set; }

        public Nullable<int> RoleID { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="Confirm Password")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Complaint> Complaints { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LabAsign> LabAsigns { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LabAsign> LabAsigns1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Labor> Labors { get; set; }
        public virtual Role Role { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PayrollCust> PayrollCusts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<payrollLab> payrollLabs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rating> Ratings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Review> Reviews { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Review> Reviews1 { get; set; }
    }
}
