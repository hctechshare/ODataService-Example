using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HCOData.Models
{
    [Table("CSAOrder")]
    public partial class Csaorder
    {
        public int OrderNumber { get; set; }
        [Column("CustomerID")]
        public int CustomerId { get; set; }
        [Column("FullSeasonCSA")]
        public bool? FullSeasonCsa { get; set; }
        public bool? MeatAddOn { get; set; }
        public bool? HardCiderAddOn { get; set; }
        public bool? Fruit { get; set; }

        [ForeignKey("CustomerId")]
        [InverseProperty("Csaorder")]
        public virtual Customer Customer { get; set; }
    }
}
