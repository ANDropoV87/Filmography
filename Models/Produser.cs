using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmography.Models
{
    public class Produser : MovieEmployee, IMovieEmployee
    {
        public ICollection<Film> MovieProduce { get; set; }
        public Produser() // конструктор-объект класса
        {
            MovieProduce = new List<Film>();
        }
    }
}
