using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Les_5___NameSpaces_Address;

namespace Les_5___NameSpaces_Profile
{
    internal class Persoon
    {
        private string _firstName;
        private string _lastName;
        private int _age;
        private int _addressNumber;
        private string _addressPostalCode;
        private string _addressCity;

        public Persoon(string first, string last, int age, int addressNumber, string addressPostalCode, string addressCity)
        {
            Address address = new Address(addressNumber, addressPostalCode, addressCity);

            _firstName = first;
            _lastName = last;
            _age = age;
            _addressNumber = address.HouseNumber;
            _addressPostalCode = address.PostalCode;
            _addressCity = address.City;
        }

        public string FullIdentity => $"{_firstName} {_lastName}, {_age}";
        public string FullName => $"{_lastName}, {_firstName} ({_firstName} {_lastName})";
        public string FirstName => _firstName;
        public string LastName => _lastName;
        public int Age => _age;
        public string Address => $"{_addressPostalCode} {_addressNumber}, {_addressCity}";
    }
}
