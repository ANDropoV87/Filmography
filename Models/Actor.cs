using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmography.Models
{
    public class Actor :MovieEmployee, IMovieEmployee // наследование класса, интерфейс это реализация
    {
        public ICollection<Film> MovieLibrary { get; set; } //коллекция-списки
        public Actor()
        {
            MovieLibrary = new List<Film>();
        }
    }
}
