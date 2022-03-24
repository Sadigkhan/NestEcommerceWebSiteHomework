using NestEcommerceWebSiteHomework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NestEcommerceWebSiteHomework.ViewModels
{
    public class AboutVM
    {
        public About About { get; set; }
        public List<Provide> Provides { get; set; }
        public Performance Performance { get; set; }
        public List<History> Histories { get; set; }
        public TeamInfo TeamInfo { get; set; }
        public List<TeamMember> TeamMembers { get; set; }
        
    }
}
