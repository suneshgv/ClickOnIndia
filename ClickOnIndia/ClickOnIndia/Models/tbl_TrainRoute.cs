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
    
    public partial class tbl_TrainRoute
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_TrainRoute()
        {
            this.tbl_TrainBooking = new HashSet<tbl_TrainBooking>();
            this.tbl_TrainBooking1 = new HashSet<tbl_TrainBooking>();
        }
    
        public int Trid { get; set; }
        public Nullable<int> Tid { get; set; }
        public Nullable<int> Roid { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<int> SortOrder { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual tbl_Route tbl_Route { get; set; }
        public virtual tbl_Train tbl_Train { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_TrainBooking> tbl_TrainBooking { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_TrainBooking> tbl_TrainBooking1 { get; set; }
    }
}
