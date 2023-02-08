using Pottencial.Domain.Sale.Interfaces;
using Pottencial.Domain.Sale.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories.Sale
{
    internal class SaleRepository : ISaleService
    {
        public Task CreateSale(Sales sale)
        {
            throw new NotImplementedException();
        }

        public Task DeleteSale(int id)
        {
            throw new NotImplementedException();
        }

        public Task FindAllSales()
        {
            throw new NotImplementedException();
        }

        public Task FindSale(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateSatus(int id)
        {
            throw new NotImplementedException();
        }
    }
}
