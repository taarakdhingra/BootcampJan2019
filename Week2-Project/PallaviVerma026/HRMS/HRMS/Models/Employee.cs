//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HRMS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public string ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string Gender { get; set; }
        public string BloodGroup { get; set; }
        public string Contact_No { get; set; }
        public string HighestQualification { get; set; }
        public Nullable<int> Work_Ex { get; set; }
        public string E_ID { get; set; }
    
        public virtual Designation Designation { get; set; }
    }
}
