//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace L05_Task01
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rents
    {
        public int Id { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> DepartmentId { get; set; }
    
        public virtual Departments Departments { get; set; }
        public virtual Users Users { get; set; }
    }
}
