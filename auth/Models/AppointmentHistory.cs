//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace auth.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AppointmentHistory
    {
        public int id { get; set; }
        public string identitiyNumber { get; set; }
        public Nullable<int> doctorId { get; set; }
        public Nullable<int> hospitalId { get; set; }
        public Nullable<int> sectionId { get; set; }
        public string complaint { get; set; }
        public Nullable<System.DateTime> date { get; set; }
    }
}