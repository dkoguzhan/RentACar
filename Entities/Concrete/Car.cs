﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int DailyPrice { get; set; }
        public short ModelYear { get; set; }
        public string Description { get; set; }
        public string Plaque { get; set; }
    }
}
