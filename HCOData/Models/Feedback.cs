using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HCOData.Models
{
    public partial class Feedback
    {
        [Column("FeedbackID")]
        public int FeedbackId { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        [Column("Feedback", TypeName = "text")]
        public string Feedback1 { get; set; }
    }
}
