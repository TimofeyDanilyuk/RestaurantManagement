using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagement.Application.DTOs.DishCategories
{
    public class DishCategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool IsActive { get; set; }
        public int? ParentCategory_ID { get; set; }
    }
}
