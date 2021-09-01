using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Exceptions
{
    public class SystemNotFoundException : Exception
    {
        public SystemNotFoundException() : base("Netačna šifra ili korisničko ime!")
        {
        }
        public SystemNotFoundException(String text) : base(text)
        {
        }
    }
}
