﻿using System;

namespace RentApi.Infrastructure.Database.Models
{
    public class Rent
    {
        public int Id { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}
