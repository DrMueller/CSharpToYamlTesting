using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models
{
public class Individual
{
    public List<Address> Addresses { get; set; }
    public DateTime Birthdate { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

public class Address
{
    public string City { get; set; }
    public IReadOnlyCollection<Street> Streets { get; set; }
    public int Zip { get; set; }
}

public class Street
{
    public bool IsMainStreet { get; set; }
    public string StreetName { get; set; }
    public int StreetNumber { get; set; }
}
}