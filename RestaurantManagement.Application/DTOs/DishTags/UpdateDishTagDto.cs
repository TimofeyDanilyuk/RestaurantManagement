using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagement.Application.DTOs.DishTags
{
    public class UpdateDishTagDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool IsActive { get; set; }
    }
}
