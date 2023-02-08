using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pottencial.Domain.Sale.Models
{
    public enum StatusSaleEnum
    {
        WaitPayment = 0,
        PaymentAccept = 1,
        SendToCarrier = 2,
        Delivered = 3,
        Canceled = 4
    }
}
