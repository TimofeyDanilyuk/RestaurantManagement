using RestaurantManagement.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace RestaurantManagement.Domain.Entities
{
    public class Order : BaseEntity
    {
        private int table_ID;
        private int waiter_ID;
        private OrderStatus status;
        private PaymentStatus paymentStatus;

        public int Table_ID
        {
            get => table_ID;
            set => SetProperty(ref table_ID, value);
        }

        public int Waiter_ID
        {
            get => waiter_ID;
            set => SetProperty(ref waiter_ID, value);
        }

        public OrderStatus Status
        {
            get => status;
            set => SetProperty(ref status, value);
        }

        public PaymentStatus PaymentStatus
        {
            get => paymentStatus;
            set => SetProperty(ref paymentStatus, value);
        }

        public ObservableCollection<OrderItem> Items { get; } = new();
    }
}
