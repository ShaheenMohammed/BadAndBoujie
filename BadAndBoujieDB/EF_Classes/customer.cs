namespace BadAndBoujieMain.EF_Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("customer")]
    public partial class customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public customer()
        {
            shopping_basket = new HashSet<shopping_basket>();
        }

        [Key]
        [StringLength(10)]
        public string C_ID { get; set; }

        [Required]
        [StringLength(10)]
        public string Per_ID { get; set; }

        public virtual person person { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<shopping_basket> shopping_basket { get; set; }
    }
}
