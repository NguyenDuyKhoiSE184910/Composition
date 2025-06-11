using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Person(string name, string address, string email, string phone)
        {
            Name = name;
            Address = address;
            Email = email;
            Phone = phone;
        }

        public string DisplayInformationToScreen()
        {
            return $"Name: {Name}, Address: {Address}, Email: {Email}, Phone: {Phone}";
        }
    }
}
