//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAOLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    public partial class tblCake
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCake()
        {
            this.tblOrderDetails = new HashSet<tblOrderDetail>();
        }
    
        public string cakeId { get; set; }
        public string name { get; set; }
        public string origin { get; set; }
        public Nullable<double> price { get; set; }
        public int bought { get; set; }
        public Nullable<int> quantity { get; set; }
        public string categoryId { get; set; }
        public byte[] img1 { get; set; }
        public string description { get; set; }
        public bool status { get; set; }
    
        public virtual tblCategory tblCategory { get; set; }
        [XmlIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrderDetail> tblOrderDetails { get; set; }
    }
}
