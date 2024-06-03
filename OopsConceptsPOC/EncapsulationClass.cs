using System;

namespace OOPConceptsPOC
{
    // Encapsulation class
    public class EncapsulationClass
    {
        // Encapsulated fields with properties
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        // Method to display information
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
