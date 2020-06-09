namespace BadAndBoujieMain.EF_Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class basket_contents_line
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public basket_contents_line()
        {
            shopping_basket = new HashSet<shopping_basket>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int basket_contents_line_ID { get; set; }

        [Required]
        [StringLength(10)]
        public string P_ID { get; set; }

        public int quantity { get; set; }

        public virtual product product { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<shopping_basket> shopping_basket { get; set; }
    }
}
