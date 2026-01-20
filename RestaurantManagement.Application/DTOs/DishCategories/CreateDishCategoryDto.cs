using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagement.Application.DTOs.DishCategories
{
    public class CreateDishCategoryDto
    {
        public string Name { get; set; } = null!;
        public bool IsActive { get; set; } = true;
        public int? ParentCategory_ID { get; set; }
    }
}
