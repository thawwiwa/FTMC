using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FTMC.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerID { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        public string CustomerName { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        public string CustomerEmail { get; set; }

        [Column(TypeName = "DECIMAL(20,2)")]
        public decimal CustomerBudget { get; set; }

        [Column(TypeName = "DECIMAL(20,2)")]
        public decimal CustomerUsed { get; set; }

        [Column(TypeName = "VARCHAR(5)")]
        public string CountryCode { get; set; }
    }
}
