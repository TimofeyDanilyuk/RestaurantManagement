using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagement.Domain.Enums
{
    public enum OrderStatus
    {
        Created = 1,
        SentToKitchen = 2,
        InProgress = 3,
        Ready = 4,
        Closed = 5,
        Cancelled = 6
    }
}
