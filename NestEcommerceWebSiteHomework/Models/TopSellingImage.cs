using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NestEcommerceWebSiteHomework.Models
{
    public class TopSellingImage
    {
        public int Id { get; set; }
        [MaxLength(255)]
        public string Title { get; set; }
        public double OldPrice { get; set; }
        public double NewPrice { get; set; }
        public int TopSellingId { get; set; }
        public TopSelling topSelling { get; set; }
        public string Image { get; set; }
    }
}
