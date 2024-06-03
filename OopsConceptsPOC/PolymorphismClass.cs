using System;

namespace OOPConceptsPOC
{
    // Polymorphism class
    public class PolymorphismClass
    {
        // Method with polymorphic behavior
        public void MakeSound(Animal animal)
        {
            Console.WriteLine($"{animal.Name} makes a sound.");
        }
    }
}
