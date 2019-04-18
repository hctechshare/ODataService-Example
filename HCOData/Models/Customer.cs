using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HCOData.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Csaorder = new HashSet<Csaorder>();
        }

        [Column("CustomerID")]
        public int CustomerId { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(50)]
        public string Phone { get; set; }
        [StringLength(100)]
        public string Address { get; set; }
        [StringLength(50)]
        public string City { get; set; }
        [StringLength(2)]
        public string State { get; set; }
        [StringLength(5)]
        public string Zip { get; set; }

        [InverseProperty("Customer")]
        public virtual ICollection<Csaorder> Csaorder { get; set; }
    }
}
