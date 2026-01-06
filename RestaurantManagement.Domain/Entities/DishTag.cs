using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagement.Domain.Entities
{
    public class DishTag : BaseEntity
    {
        private string name = null!;
        private bool isActive;

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
    }
}
