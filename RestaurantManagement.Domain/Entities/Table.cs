using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagement.Domain.Entities
{
    public class Table : BaseEntity
    {
        private int number;
        private int seats;

        public int Number
        {
            get => number;
            set => SetProperty(ref number, value);
        }

        public int Seats
        {
            get => seats;
            set => SetProperty(ref seats, value);
        }
    }
}
