//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MedicoRx_V2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Medicine
    {
        public int MId { get; set; }
        public string MedicineName { get; set; }
        public string Formula { get; set; }
        public Nullable<int> DisseaseId { get; set; }
        public string Comment { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> Updationdate { get; set; }
    }
}
