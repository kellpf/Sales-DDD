using Microsoft.EntityFrameworkCore;
using Pottencial.Domain.Sale.Models;
using Pottencial.Domain.Seller.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Context
{
    public class DbContextSales : DbContext
    {
        public DbContextSales(DbContextOptions<DbContextSales> options) : base(options)
        {
        }

        public DbSet<Sales> Sale { get; set; }
        public DbSet<Sellers> Seller { get; set; }
    }
}
