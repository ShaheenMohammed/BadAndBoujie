namespace BadAndBoujieMain.EF_Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class shopping_basket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int shopping_basket_ID { get; set; }

        [Required]
        [StringLength(10)]
        public string C_ID { get; set; }

        public int basket_contents_line_ID { get; set; }

        public DateTime basket_datetime { get; set; }

        public virtual basket_contents_line basket_contents_line { get; set; }

        public virtual customer customer { get; set; }
    }
}
