using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagement.Application.DTOs.DishTagLinks
{
    public class DishTagLinkDto
    {
        public int Id { get; set; }
        public int Dish_ID { get; set; }
        public int Tag_ID { get; set; }
    }
}
