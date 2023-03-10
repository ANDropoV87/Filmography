﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pbkdf2;

namespace Filmography.Models
{
    public class Encryption: IEncryption
    {
        public string HashPassword(string password, string salt)
        {
            return Convert.ToBase64String(Pbkdf2.Pbkdf2.HashData("SHA512", Encoding.ASCII.GetBytes(password), Encoding.ASCII.GetBytes(salt), 350000, 64));
        }
    }
}
