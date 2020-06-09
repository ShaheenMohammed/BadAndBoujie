namespace BadAndBoujieMain.EF_Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("warehouse")]
    public partial class warehouse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public warehouse()
        {
            suppliers = new HashSet<supplier>();
        }

        [Key]
        [StringLength(10)]
        public string W_ID { get; set; }

        [Required]
        [StringLength(30)]
        public string W_name { get; set; }

        [Required]
        [StringLength(50)]
        public string W_addr { get; set; }

        [Required]
        [StringLength(11)]
        public string W_phone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<supplier> suppliers { get; set; }
    }
}
