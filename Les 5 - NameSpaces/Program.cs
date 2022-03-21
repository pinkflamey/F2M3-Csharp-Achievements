using System;
using Les_5___NameSpaces_Profile;
using Les_5___NameSpaces_Address;

namespace Les_5___NameSpaces
{
    class Program
    {

        static void Main(string[] args)
        {
            Persoon p1 = new Persoon("Mavis", "de Ridder", 17, 23, "2171cw", "Sassenheim");

            Console.WriteLine($"Full identity: {p1.FullIdentity}");
            Console.WriteLine($"Full name: {p1.FullName}");
            Console.WriteLine($"Age: {p1.Age}");
            Console.WriteLine($"First name: {p1.FirstName}");
            Console.WriteLine($"Last name: {p1.LastName}");
            Console.WriteLine($"Address: {p1.Address}");



        }

        
    }
}

