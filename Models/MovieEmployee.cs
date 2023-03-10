using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmography.Models
{
    public class MovieEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public DateTime Birthday { get; set; }
        public CountryMovie Nation { get; set; }
        public string City { get; set; }
        public Decimal FinState { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
