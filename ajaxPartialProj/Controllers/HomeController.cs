using ajaxPartialProj.DAL;
using ajaxPartialProj.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ajaxPartialProj.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(new HomeIndexViewModel { 
                Products = _context.Products.Include(p => p.Category).ToList(),
                Categories = _context.Categories.FirstOrDefault()
            });
        }
    }
}
