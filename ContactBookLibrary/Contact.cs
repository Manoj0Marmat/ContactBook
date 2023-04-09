using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBookLibrary
{
    public class Contact
    {
        public string Name { get; set; }
        public long Number { get; set; }
        public string Email { get; set; }

        public Contact(string name, long number, string email)
        {
            Name = name;
            Number = number;
            Email = email;
        }

        public override string ToString()
        {
            return $"{Name}\t{Number}";
        }

    }
}
