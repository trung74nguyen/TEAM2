//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication
{
    using System;
    using System.Collections.Generic;
    
    public partial class PriceHistory
    {
        public string ProductCode { get; set; }
        public double Price { get; set; }
        public System.DateTime EffectiveDate { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
