﻿using BlazorServerApp.Areas.Identity.Data;
using BlazorServerApp.Models.EF.NautralKey;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerApp.Data
{
    public class LocalApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public LocalApplicationDbContext(DbContextOptions<LocalApplicationDbContext> options)
            : base(options) {

        }

        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);

            //builder.Entity<Customer>().HasKey(c => new { c.FirstName, c.LastName, c.EmailAddress });
            //builder.Entity<Membership>().HasKey(m => m.Id);
            //builder.Entity<Membership>()
            //    .Property(o => o.Type)
            //    .HasConversion<string>();
            //builder.Entity<CustomerMemberShip>()
            //    .HasKey(c => new { c.FirstName, c.LastName, c.EmailAddress, c.MembershipId });
            //builder.Entity<CustomerMemberShip>()
            //    .HasOne(c => c.Customer)
            //    .WithMany(c => c.CustomerMemberShips)
            //    .HasForeignKey(c => new { c.FirstName, c.LastName, c.EmailAddress })
            //    .OnDelete(DeleteBehavior.SetNull);
            //builder.Entity<CustomerMemberShip>()
            //    .HasOne(c => c.Membership)
            //    .WithMany(m => m.OwnedByMembers)
            //    .HasForeignKey(c => new { c.MembershipId })
            //    .OnDelete(DeleteBehavior.SetNull);
        }
        //public DbSet<Customer> Customer { get; set; }
        //public DbSet<Membership> Membership { get; set; }
        //public DbSet<CustomerMemberShip> CustomerMemberShip { get; set; }
    }
}