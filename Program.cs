using System;
using System.Linq;
using System.Collections.Generic;

namespace Exercise002
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simulated Customer data
            List<Customer> customers = GetCustomers(); // You would replace this with your actual DB query

            // Display all unique cities
            var cities = customers.Select(c => c.City).Distinct().OrderBy(c => c);
            Console.WriteLine("Available Cities:");
            Console.WriteLine(string.Join(", ", cities));
            Console.WriteLine();

            // Ask user to enter a city
            Console.Write("Enter the name of a city: ");
            string inputCity = Console.ReadLine();

            // Query matching customers
            var cityCustomers = customers
                .Where(c => c.City.Equals(inputCity, StringComparison.OrdinalIgnoreCase))
                .Select(c => c.CompanyName)
                .ToList();

            // Show results
            Console.WriteLine($"\nThere are {cityCustomers.Count} customers in {inputCity}:");
            foreach (var name in cityCustomers)
            {
                Console.WriteLine(name);
            }
        }

        // Simulated method to fetch customer data 
        static List<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { City = "Kathmandu", CompanyName = "Evergreen Mobile & Computer Parts" },
                new Customer { City = "Kathmandu", CompanyName = "Dipu Enterprises" },
                new Customer { City = "Kathmandu", CompanyName = "Dari Daiko chiya" },
                new Customer { City = "London", CompanyName = "Around the Horn" },
                new Customer { City = "London", CompanyName = "B's Beverages" },
                new Customer { City = "London", CompanyName = "Consolidated Holdings" },
                new Customer { City = "London", CompanyName = "Eastern Connection" },
                new Customer { City = "London", CompanyName = "North/South" },
                new Customer { City = "London", CompanyName = "Seven Seas Imports" },
                new Customer { City = "Paris", CompanyName = "Bon App'" },
                new Customer { City = "Berlin", CompanyName = "Alfreds Futterkiste" }
               
            };
        }
    }

    class Customer
    {
        public string City { get; set; }
        public string CompanyName { get; set; }
    }
}
