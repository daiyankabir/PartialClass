using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    class Customer
    {
        string firstName, lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public void GetFullName()
        {
            Console.WriteLine(firstName + ", " + lastName);
        }
    }
}
