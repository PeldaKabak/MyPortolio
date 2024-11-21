﻿using Microsoft.EntityFrameworkCore;
using MyPortfolio.DAL.Entities;
using MyPortolio.DAL.Entities;

namespace MyPortfolio.DAL.Context
{
    public class MyPortfolioContext  : DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-9AM96JJ\\DEVELOPEREDITION;initial Catalog=MyPortfolioDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences{ get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
      
    }
}