using ajaxPartialProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ajaxPartialProj.ViewModels
{
    public class ProductIndexViewModel
    {
        public List<Product> Products { get; set; }
        public Category Categories { get; set; }
    }
}
