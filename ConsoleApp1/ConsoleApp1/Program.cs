using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Models;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            var address1 = new Address
            {
                City = "Fake City",
                Zip = 1234,
                Streets = new List<Street>
                {
                    new Street
                    {
                       StreetName = "Grubbenmatte",
                        StreetNumber = 11,
                        IsMainStreet = true
                    },
                    new Street
                    {
                        StreetName = "Bonnetsacher",
                        StreetNumber = 22,
                        IsMainStreet = false
                    },
                    new Street
                    {
                        StreetName = "Hauptbahnhof",
                        StreetNumber = 33,
                        IsMainStreet = false
                    }
                }
            };

            var address2 = new Address
            {
                City = "Alterswil",
                Zip = 1715,
                Streets = new List<Street>
                {
                    new Street
                    {
                        StreetName = "Baker Street",
                        StreetNumber = 221,
                        IsMainStreet = true
                    },
                    new Street
                    {
                        StreetName = "Greenfield",
                        StreetNumber = 24,
                        IsMainStreet = false
                    }
                }
            };

            var individual = new Individual
            {
                Addresses = new List<Address> { address1, address2 },
                Birthdate = new DateTime(1986, 12, 29),
                FirstName = "Matthias",
                LastName = "Müller"
            };

            var serializer = new YamlDotNet.Serialization.Serializer();
            var yaml = serializer.Serialize(individual);
            Console.WriteLine(yaml);

            Console.ReadKey();
        }
    }
}
