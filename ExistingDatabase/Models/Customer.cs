using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ExistingDatabase.Models
{
    [Table("Customer")]
    public partial class Customer
    {
        [Key]
        public int Id { get; set; }
        [StringLength(10)]
        public string Name { get; set; }
        [StringLength(10)]
        public string Address { get; set; }
    }
}
