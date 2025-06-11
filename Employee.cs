using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    class Employee : Person
    {

        public string Degree { get; set; }
        public Employee(string name, string address, string email, string phone, string degree) : base(name, address, email, phone)
        {
            Degree = degree;
        }
        public string DisplayInformationWithDegreeToScreen()
        {
            return $"{DisplayInformationToScreen()}, Degree: {Degree}";
        }
    }
}
