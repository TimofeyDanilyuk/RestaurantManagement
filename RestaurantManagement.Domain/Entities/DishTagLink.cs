using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagement.Domain.Entities
{
    public class DishTagLink : BaseEntity
    {
        private int dish_ID;
        private int tag_ID;

        public int Dish_ID
        {
            get => dish_ID;
            set => SetProperty(ref dish_ID, value);
        }

        public int Tag_ID
        {
            get => tag_ID;
            set => SetProperty(ref tag_ID, value);
        }
    }
}
