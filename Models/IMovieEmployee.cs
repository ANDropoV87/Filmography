using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmography.Models
{
    public interface IMovieEmployee
    {
        string FirstName { get; set; }//свойства если нет гета поля.Свойство это маленький метод, чтобы обратится в поле. гет посмотреть, сет поменять
        //инкапсуляция 3 пародигмы ООП-
        string LastName { get; set; }
        string Sex { get; set; }
        DateTime Birthday { get; set; }
        CountryMovie Nation { get; set; }
        string City { get; set; }
        Decimal FinState { get; set; }
    }
}
