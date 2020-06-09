namespace BadAndBoujieMain.EF_Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("product")]
    public partial class product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public product()
        {
            basket_contents_line = new HashSet<basket_contents_line>();
        }

        [Key]
        [StringLength(10)]
        public string P_ID { get; set; }

        [Required]
        [StringLength(10)]
        public string S_ID { get; set; }

        [Required]
        [StringLength(10)]
        public string P_cat_ID { get; set; }

        [Required]
        [StringLength(10)]
        public string gender { get; set; }

        public int inStock { get; set; }

        [Required]
        [StringLength(10)]
        public string P_price { get; set; }

        [Required]
        [StringLength(1)]
        public string P_sale { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<basket_contents_line> basket_contents_line { get; set; }

        public virtual P_cat P_cat { get; set; }

        public virtual supplier supplier { get; set; }

        public virtual product_name product_name { get; set; }
    }
}
