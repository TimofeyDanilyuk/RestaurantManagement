using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagement.Application.DTOs.DishTags
{
    public class CreateDishTagDto
    {
        public string Name { get; set; } = null!;
        public bool IsActive { get; set; } = true;
    }
}
