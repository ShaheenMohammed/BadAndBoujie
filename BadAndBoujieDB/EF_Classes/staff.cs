namespace BadAndBoujieMain.EF_Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("staff")]
    public partial class staff
    {
        [Key]
        [StringLength(10)]
        public string stf_ID { get; set; }

        [Required]
        [StringLength(10)]
        public string Per_ID { get; set; }

        public virtual person person { get; set; }
    }
}
