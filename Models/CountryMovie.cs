using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmography.Models
{
    public class CountryMovie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Actor> Actors { get; set; }
        public ICollection<Produser> Produsers { get; set; }
        public ICollection<Film> FilmProduce { get; set; }
        public CountryMovie()
        {
            Actors = new List<Actor>();
            Produsers = new List<Produser>();
            FilmProduce = new List<Film>();
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
