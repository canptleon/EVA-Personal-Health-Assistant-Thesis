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
    
    public partial class analysisValues
    {
        public int id { get; set; }
        public Nullable<int> analysisReferenceId { get; set; }
        public Nullable<int> analysisTypeId { get; set; }
        public Nullable<double> value { get; set; }
        public string sessionId { get; set; }
    }
}