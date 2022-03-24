using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NestEcommerceWebSiteHomework.Models
{
    public class Deal
    {
        public int Id { get; set; }
        [Range(0, 60)]
        public int SecNum { get; set; }
        [Range(0, 60)]
        public int MinNUm { get; set; }
        [Range(0, 60)]
        public int HourNum { get; set; }
        [Range(0, 60)]
        public int DayNum { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
        [MaxLength(1000)]
        public string Image { get; set;}
        public double OldPrice { get; set; }
        public double NewPrice { get; set; }
    }
}
