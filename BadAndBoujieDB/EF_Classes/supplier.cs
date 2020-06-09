namespace BadAndBoujieMain.EF_Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("supplier")]
    public partial class supplier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public supplier()
        {
            products = new HashSet<product>();
        }

        [Key]
        [StringLength(10)]
        public string S_ID { get; set; }

        [Required]
        [StringLength(10)]
        public string W_ID { get; set; }

        [Required]
        [StringLength(30)]
        public string S_name { get; set; }

        [Required]
        [StringLength(50)]
        public string S_addr { get; set; }

        [Required]
        [StringLength(11)]
        public string S_phone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<product> products { get; set; }

        public virtual warehouse warehouse { get; set; }
    }
}
