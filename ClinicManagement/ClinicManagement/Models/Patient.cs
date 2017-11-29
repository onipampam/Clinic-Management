//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClinicManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Patient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patient()
        {
            this.MedCheckHeaders = new HashSet<MedCheckHeader>();
        }
    
        public int PatientID { get; set; }
        public string PatientLast { get; set; }
        public string PatientFirst { get; set; }
        public string PatientMid { get; set; }
        public Nullable<int> PatientGender { get; set; }
        public Nullable<System.DateTime> PatientBDate { get; set; }
        public string PatientAddrss { get; set; }
        public Nullable<int> PatientType { get; set; }
        public Nullable<int> PatientClass { get; set; }
        public int CollegeID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedCheckHeader> MedCheckHeaders { get; set; }
        public virtual PCollege PCollege { get; set; }
    }
}
