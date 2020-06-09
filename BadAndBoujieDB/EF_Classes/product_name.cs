namespace BadAndBoujieMain.EF_Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class product_name
    {
        [Key]
        [StringLength(10)]
        public string P_ID { get; set; }

        [Required]
        [StringLength(30)]
        public string P_name { get; set; }

        public virtual product product { get; set; }
    }
}
