using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
 public   class CarFilterDto : IDto
    {
        public int? BrandId { get; set; }
        public int? ColorId { get; set; }
    }
}
