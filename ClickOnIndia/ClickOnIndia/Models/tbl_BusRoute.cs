//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClickOnIndia.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_BusRoute
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_BusRoute()
        {
            this.tbl_BusBoking = new HashSet<tbl_BusBoking>();
            this.tbl_BusBoking1 = new HashSet<tbl_BusBoking>();
            this.tbl_BusBoking2 = new HashSet<tbl_BusBoking>();
        }
    
        public int BrId { get; set; }
        public Nullable<int> Blid { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<int> Sortorder { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<int> BusId { get; set; }
    
        public virtual tbl_Bus tbl_Bus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_BusBoking> tbl_BusBoking { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_BusBoking> tbl_BusBoking1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_BusBoking> tbl_BusBoking2 { get; set; }
        public virtual tbl_BusLoc tbl_BusLoc { get; set; }
    }
}
