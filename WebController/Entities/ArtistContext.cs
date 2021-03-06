﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebController.Entities;

namespace WebController.Entities
{
    public class ArtistContext : DbContext
    {
        public ArtistContext(DbContextOptions<ArtistContext> options) : base(options) { }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<ArtistSkill> ArtistSkill { get; set; }
        public DbSet<Review> Review { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Artist>().Property(x => x.City).HasMaxLength(50);
            builder.Entity<Artist>().Property(x => x.Country).HasMaxLength(50);
            builder.Entity<Artist>().Property(x => x.Provence).HasMaxLength(50);
            builder.Entity<Artist>().Property(x => x.UserName).IsRequired(true).HasMaxLength(50);
            builder.Entity<Artist>().Property(x => x.WebSite).HasMaxLength(255);



            builder.Entity<ArtistSkill>().Property(x => x.Details).HasMaxLength(255);
            builder.Entity<ArtistSkill>().Property(x => x.TalentName).IsRequired(true).HasMaxLength(50);
            builder.Entity<ArtistSkill>().Property(x => x.Styles).HasMaxLength(255);
        }



        
    }
}
