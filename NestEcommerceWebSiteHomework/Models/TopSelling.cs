using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NestEcommerceWebSiteHomework.Models
{
    public class TopSelling
    {
        public int Id { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
        public IEnumerable<TopSellingImage> TopSellingImages { get; set; }
        
    }
}
