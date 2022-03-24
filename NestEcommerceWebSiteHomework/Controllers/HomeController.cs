using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NestEcommerceWebSiteHomework.DAL;
using NestEcommerceWebSiteHomework.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NestEcommerceWebSiteHomework.Controllers
{
    public class HomeController : Controller
    {


        private readonly NestDB _context;
        public HomeController(NestDB context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            HomeVM homeVM = new HomeVM
            {
                Trendings = _context.Trendings.ToList(),
                Deals = _context.Deals.ToList(),
                //TopSellings = _context.TopSellings.ToList(),
                TopSellings = _context.TopSellings.Include(a => a.TopSellingImages).ToList(),
                //TopSellingImages = _context.TopSellingImages.ToList()
                

            };
            return View(homeVM);
        }
    }
}

