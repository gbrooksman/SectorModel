﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SectorModel.Shared.Entities;

namespace SectorModel.QuoteLoader
{ 
    public class ReadContext : DbContext
    {
        private readonly string connString;

        public ReadContext(AppSettings appSettings) 
        {
            connString = appSettings.DBConnectionString;
        }

        public DbSet<Equity> Equities { get; set; }

        public DbSet<Quote> Quotes { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Model> Models { get; set; }

        public DbSet<ModelItem> ModelItems { get; set; }

        public DbSet<ModelComment> ModelComments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connString);
                optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            }
           
        }
    }
}
