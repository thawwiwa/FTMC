using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FTMC.Models
{
    public class CustomerCountry
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CountryID { get; set; }

        [Column(TypeName = "VARCHAR(5)")]
        public string CountryCode { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        public string CountryName { get; set; }

    }
}
