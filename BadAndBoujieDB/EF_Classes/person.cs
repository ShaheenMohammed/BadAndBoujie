namespace BadAndBoujieMain.EF_Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("person")]
    public partial class person
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public person()
        {
            customers = new HashSet<customer>();
            staffs = new HashSet<staff>();
        }

        [Key]
        [StringLength(10)]
        public string Per_ID { get; set; }

        [StringLength(30)]
        public string Per_firstname { get; set; }

        [StringLength(30)]
        public string Per_lastname { get; set; }

        [StringLength(11)]
        public string Per_phone { get; set; }

        [StringLength(50)]
        public string Per_addr { get; set; }

        [Required]
        [StringLength(20)]
        public string Per_usrn { get; set; }

        [Required]
        [StringLength(30)]
        public string Per_PW { get; set; }

        [Required]
        [StringLength(10)]
        public string Per_type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<customer> customers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<staff> staffs { get; set; }
    }
}
