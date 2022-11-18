using Creto.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Creto.Web.Data
{
    public class CretoDbContext : IdentityDbContext
    {
        public CretoDbContext(DbContextOptions<CretoDbContext> options)
            : base(options)
        {
        }


		public DbSet<Bike> Bikes { get; set; }
		public DbSet<QandA> QandAs { get; set; }
		public DbSet<Country> Countries { get; set; }
		public DbSet<Brand> Brands { get; set; }



	}
}