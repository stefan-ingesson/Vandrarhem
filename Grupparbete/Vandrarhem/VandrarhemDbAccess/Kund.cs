//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VandrarhemDbAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kund
    {
        public Kund()
        {
            this.KundBoknings = new HashSet<KundBokning>();
        }
    
        public int KundId { get; set; }
        public string ForNamn { get; set; }
        public string EfterNamn { get; set; }
        public string Personummer { get; set; }
        public string Telefon { get; set; }
        public string Epost { get; set; }
    
        public virtual ICollection<KundBokning> KundBoknings { get; set; }
    }
}
