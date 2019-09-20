using Microsoft.EntityFrameworkCore;
using FTMC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FTMC.Datas
{
    public class FTMCdb : DbContext
    {
        public FTMCdb(DbContextOptions<FTMCdb> options) : base(options)
        {

        }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<CustomerCountry> CustomerCountry { get; set; }

    }
}
