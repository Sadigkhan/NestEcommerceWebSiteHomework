using Microsoft.EntityFrameworkCore;
using NestEcommerceWebSiteHomework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NestEcommerceWebSiteHomework.DAL
{
    public class NestDB : DbContext
    {
        public NestDB(DbContextOptions<NestDB> options) : base(options)
        {

        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<AboutImage> AboutImages { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<Performance> Performances { get; set; }
        public DbSet<Provide> Provides { get; set; }
        public DbSet<TeamInfo> TeamInfos { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<TeamSocial> TeamSocials { get; set; }
        public DbSet<Deal> Deals { get; set; }
        public DbSet<Trending> Trendings { get; set; }
        public DbSet<TopSelling> TopSellings { get; set; }
        public DbSet<TopSellingImage> TopSellingImages { get; set; }
    }
}
