using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NestEcommerceWebSiteHomework.Models
{
    public class About
    {
        public int Id { get; set; }
        [MaxLength(255)]
        public string Title { get; set; }
        [MaxLength(1000)]
        public string Content { get; set; }
        [MaxLength(1000)]
        public string Image { get; set; }

        public IEnumerable<AboutImage> AboutImages { get; set; }
    }
}
