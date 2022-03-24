using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NestEcommerceWebSiteHomework.DAL;
using NestEcommerceWebSiteHomework.Models;
using NestEcommerceWebSiteHomework.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NestEcommerceWebSiteHomework.Controllers
{
    public class AboutController : Controller
    {
        private readonly NestDB _context;
        public AboutController(NestDB context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            AboutVM aboutVM = new AboutVM
            {
                About = _context.Abouts.Include(a => a.AboutImages).FirstOrDefault(),
                Provides = _context.Provides.ToList(),
                Performance = _context.Performances.FirstOrDefault(),
                Histories = _context.Histories.ToList(),
                TeamInfo = _context.TeamInfos.FirstOrDefault(),
                TeamMembers = _context.TeamMembers.ToList()
               
            };
            return View(aboutVM);
        }
    }
}
