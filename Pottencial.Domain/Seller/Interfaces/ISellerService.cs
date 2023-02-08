using Pottencial.Domain.Seller.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pottencial.Domain.Seller.Interfaces
{
    public interface ISellerService
    {
        Task Create(Sellers sale);
        Task Find(int id);
        Task FindAll();
        Task Delete(int id);
        Task UpdateSeller(int id);
    }
}
