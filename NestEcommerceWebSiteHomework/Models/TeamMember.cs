using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NestEcommerceWebSiteHomework.Models
{
    public class TeamMember
    {
        public int Id { get; set; }
        [MaxLength(1000)]
        public string Image { get; set; }
        [MaxLength(255)]
        public string FullName { get; set; }
        [MaxLength(255)]
        public string Position { get; set; }
        public IEnumerable<TeamSocial> teamSocials { get; set; }
    }
}
