using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagement.Domain.Entities
{
    public class OrderItem : BaseEntity
    {
        private int order_ID;
        private int dish_ID;
        private int quantity;
        private decimal price;

        public int Order_ID
        {
            get => order_ID;
            set => SetProperty(ref order_ID, value);
        }
        public Order Order { get; set; } = null!;

        public int Dish_ID
        {
            get => dish_ID;
            set => SetProperty(ref dish_ID, value);
        }

        public int Quantity
        {
            get => quantity;
            set => SetProperty(ref quantity, value);
        }

        public decimal Price
        {
            get => price;
            set => SetProperty(ref price, value);
        }
    }
}
