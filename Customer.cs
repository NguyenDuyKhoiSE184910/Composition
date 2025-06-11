using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    class Customer : Person
    {

        public Customer(string name, string address, string email, string phone, string Type) : base(name, address, email, phone)
        {
            this.Type = Type;
        }

        public string Type { get; set; }
       

        public string DisplayInformationWithTypeToScreen()
        {
            return $"{DisplayInformationToScreen()}, Type: {Type}";
        }

        
    }
}
