using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Entities
{
    public class ProiectContext : IdentityDbContext<User, Role, string, IdentityUserClaim<string>,
        UserRole, IdentityUserLogin<string>, IdentityRoleClaim<string>, IdentityUserToken<string>>
    {
        public ProiectContext(DbContextOptions<ProiectContext> options) : base(options) { }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<PlaneRoute> PlaneRoutes { get; set; }
        public DbSet<UserInfo> UserInfos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Plane>()
                .HasMany(p => p.Tickets)
                .WithOne(t => t.Plane);

            builder.Entity<PlaneRoute>().HasKey(pr => new { pr.PlaneId, pr.RouteId });

            builder.Entity<PlaneRoute>()
                .HasOne<Plane>(pr => pr.Plane)
                .WithMany(p => p.PlaneRoutes)
                .HasForeignKey(pr => pr.PlaneId);

            builder.Entity<PlaneRoute>()
                .HasOne<Route>(pr => pr.Route)
                .WithMany(p => p.PlaneRoutes)
                .HasForeignKey(pr => pr.RouteId);

            builder.Entity<User>()
                .HasOne(u => u.UserInfo)
                .WithOne(ui => ui.User);

            builder.Entity<User>()
                .HasMany(u => u.Tickets)
                .WithOne(t => t.User);

        }
    }
}
