using RestaurantManagement.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagement.Application.DTOs.Users
{
    public class CreateUserDto
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public RoleType Role { get; set; }
        public string Password { get; set; } = null!;
    }
}
