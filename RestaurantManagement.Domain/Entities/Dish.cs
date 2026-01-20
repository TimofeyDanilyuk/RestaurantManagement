using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagement.Domain.Entities
{
    public class Dish : BaseEntity
    {
        private string name = null!;
        private decimal price;
        private bool isAvailable;
        private int category_ID;

        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        public decimal Price
        {
            get => price;
            set => SetProperty(ref price, value);
        }

        public bool IsAvailable
        {
            get => isAvailable;
            set => SetProperty(ref isAvailable, value);
        }

        public int Category_ID
        {
            get => category_ID;
            set => SetProperty(ref category_ID, value);
        }

        private List<DishTagLink> dishTagLinks = new();
        public IReadOnlyList<DishTagLink> DishTagLinks => dishTagLinks.AsReadOnly();
    }
}
