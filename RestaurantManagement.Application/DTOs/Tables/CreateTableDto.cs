using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagement.Application.DTOs.Tables
{
    public class CreateTableDto
    {
        public int Number { get; set; }
        public int Seats { get; set; }
    }
}
