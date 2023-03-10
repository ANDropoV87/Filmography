using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmography.Models
{
    public interface IEncryption
    {
        string HashPassword(string password, string salt);
    }
}
