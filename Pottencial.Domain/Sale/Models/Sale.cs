using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pottencial.Domain.Sale.Models
{
    public class Sales
    {
        public int Id { get; set; }
        public int Seller { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string Items { get; set; } 
        public int Status { get; set; }
    }
}
