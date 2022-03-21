using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_5___NameSpaces_Address
{
    internal class Address
    {
        private int _number;
        private string _postalCode;
        private string _city;
    
        public Address(int number, string postalCode, string city)
        {
            _number = number;
            _postalCode = postalCode;
            _city = city;
        }

        public int HouseNumber => _number;
        public string PostalCode => _postalCode;
        public string City => _city;
    }
}
