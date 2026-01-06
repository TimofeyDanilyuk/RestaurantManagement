using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagement.Domain.Entities
{
    public class DishCategory : BaseEntity
    {
        private string name = null!;
        private bool isActive;
        private int? parentCategory_ID;

        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        public bool IsActive
        {
            get => isActive;
            set => SetProperty(ref isActive, value);
        }

        // Для иерархии
        public int? ParentCategory_ID
        {
            get => parentCategory_ID;
            set => SetProperty(ref parentCategory_ID, value);
        }
    }
}
