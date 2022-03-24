using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NestEcommerceWebSiteHomework.Models
{
    public class AboutImage
    {
        public int Id { get; set; }
        [MaxLength(1000)]
        public string Image { get; set; }
        public int AboutId { get; set; }
        public About About { get; set; }

    }


}

