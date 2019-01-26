using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RealEstatePortal;
using RealEstatePortal.Models;

namespace RealEstatePortal.Models
{
    public class PortalContext : DbContext
    {
        public PortalContext (DbContextOptions<PortalContext> options)
            : base(options)
        {
        }

        public DbSet<RealEstatePortal.Models.Buyer> Buyer { get; set; }

        public DbSet<RealEstatePortal.Agent> Agent { get; set; }

        public DbSet<RealEstatePortal.Models.Seller> Seller { get; set; }

        public DbSet<RealEstatePortal.Models.Property> Property { get; set; }
    }
}
