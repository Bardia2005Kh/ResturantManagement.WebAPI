using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums
{
    public enum OrderStatus
    {
        Pending = 0,
        ReadyToDelivery = 1,
        Delivered = 2,
        Cancel = 3
    }
}
