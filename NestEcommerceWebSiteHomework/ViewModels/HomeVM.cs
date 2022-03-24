using NestEcommerceWebSiteHomework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NestEcommerceWebSiteHomework.ViewModels
{
    public class HomeVM
    {
        public List<Deal> Deals { get; set; }
        public List<Trending> Trendings { get; set; }
        public List<TopSelling> TopSellings { get; set; }
        public List<TopSellingImage> TopSellingImages { get; set; }
    }
}
