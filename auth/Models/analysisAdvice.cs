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
    
    public partial class analysisAdvice
    {
        public int id { get; set; }
        public Nullable<int> analysisTypeId { get; set; }
        public Nullable<int> analysisReferenceId { get; set; }
        public string analysisAdviceHigh { get; set; }
        public string analysisAdviceLow { get; set; }
    }
}