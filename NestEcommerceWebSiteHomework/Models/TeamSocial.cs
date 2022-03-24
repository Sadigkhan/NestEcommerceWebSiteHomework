using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NestEcommerceWebSiteHomework.Models
{
    public class TeamSocial
    {
        public int Id { get; set; }
        [MaxLength(255)]
        public string AddressLink { get; set; }
        [MaxLength(255)]
        public string Icon { get; set; }
        public int TeamMemberId { get; set; }
        public TeamMember teamMember { get; set; }
    }
}
