//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BussinessLogic.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bike
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bike()
        {
            this.MaintenanceBills = new HashSet<MaintenanceBill>();
            this.SaleReceipts = new HashSet<SaleReceipt>();
        }
    
        public long ID { get; set; }
        public string EngineNumber { get; set; }
        public string ChassisNumber { get; set; }
        public string Brand { get; set; }
        public string ModelCode { get; set; }
        public Nullable<int> Capacity { get; set; }
        public string Color { get; set; }
        public string PlateNumber { get; set; }
        public Nullable<long> StoreID { get; set; }
        public Nullable<long> Price { get; set; }
        public Nullable<long> CustomerID { get; set; }
        public string WarrantyPeriod { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Store Store { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaintenanceBill> MaintenanceBills { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaleReceipt> SaleReceipts { get; set; }
    }
}
