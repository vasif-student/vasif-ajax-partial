﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ajaxPartialProj.Models
{
    public class Category : BasicEntity
    {
        public List<Product> Products { get; set; }
    }
}
