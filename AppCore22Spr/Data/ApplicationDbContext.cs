using System;
using System.Collections.Generic;
using System.Text;
using AppCore22Spr.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AppCore22Spr.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);
            builder.Entity<TopicDivision>().HasKey(t => new {t.DivisionID, t.TopicId});
        }

        public DbSet<Topic> Topics { get; set; }
        public DbSet<Division> Divisions { get; set; }
        public DbSet<TopicDivision> TopicDivisions { get; set; }
        public DbSet<SchoolType> SchoolTypes { get; set; }
    }
}
