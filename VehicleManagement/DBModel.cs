using Fahrzeugverwaltung.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverwaltung
{
    public class DBModel : DbContext
    {
        public DbSet<_Brand> _Brands { get; set; }
        public DbSet<_Model> _Models { get; set; }
        public DbSet<Details> Details { get; set; }
        public DbSet<EuroNorm> EuroNorm { get; set; }
        public DbSet<Fuel> Fuel { get; set; }
        public DbSet<Paint> Paint { get; set; }

        public DBModel() 
        { 
            //Context
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["FahrzeugverwaltungCore"].ConnectionString);
        }
    }
}
