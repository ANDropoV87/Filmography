using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Filmography.Models;

namespace Filmography.Models
{
    public class FG_DbNewContext:DbContext
    {
        public FG_DbNewContext() : base("DefaultConnection")
        {

        }
        public DbSet<CountryMovie> Countries { get; set; } //Списки сущностей
        
        public DbSet<DemoCountry> DemoCountries { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Produser> Produsers { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<User> Users { get; set; }
    }
}

