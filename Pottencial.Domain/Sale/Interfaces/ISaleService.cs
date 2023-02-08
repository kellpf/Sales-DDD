using Pottencial.Domain.Sale.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pottencial.Domain.Sale.Interfaces
{
    public interface ISaleService
    {
        Task CreateSale(Sales sale);
        Task FindSale(int id);
        Task FindAllSales();
        Task DeleteSale(int id);
        Task UpdateSatus(int id);
    }
}
