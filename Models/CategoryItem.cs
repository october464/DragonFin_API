﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DragonFin_API.Models
{
    public class CategoryItem
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        
        public decimal TargetAmount { get; set; }

     
        public decimal ActualAmount { get; set; }
        
    }
}
