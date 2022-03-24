using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NestEcommerceWebSiteHomework.Models
{
    public class Trending
    {
        public int Id { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
        [MaxLength(1000)]
        public string Image1 { get; set; }
        [MaxLength(1000)]
        public string Image2 { get; set; }
        public double NewPrice { get; set; }
        public double OldPrice { get; set; }
    }
}
