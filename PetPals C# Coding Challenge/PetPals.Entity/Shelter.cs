using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.Entity
{
    public class Shelter
    {
       
        public string Name { get; set; }
        public string Location { get; set; }

       
        public Shelter(string name, string location)
        {
            Name = name;
            Location = location;
           
        }

       
        public void DisplayShelterInfo()
        {
            Console.WriteLine($"Shelter Name: {Name}");
            Console.WriteLine($"Location: {Location}");
           
        }
    }
}
