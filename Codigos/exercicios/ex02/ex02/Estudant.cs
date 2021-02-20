using System;
using System.Collections.Generic;
using System.Text;

namespace ex02
{
    class Estudant
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public Estudant(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
                return Name + ", " + Email;
        }
    }
}
