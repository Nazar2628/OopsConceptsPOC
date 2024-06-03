using System;

namespace OOPConceptsPOC
{
    class Program
    {
        static void Main(string[] args)
        {
            // Encapsulation demonstration
            EncapsulationClass encapsulationObj = new EncapsulationClass();
            encapsulationObj.Name = "John";
            encapsulationObj.Age = 30;
            encapsulationObj.DisplayInfo();

            // Inheritance demonstration
            InheritanceClass inheritanceObj = new InheritanceClass();
            inheritanceObj.Name = "Buddy";
            inheritanceObj.Eat();
            inheritanceObj.Bark();

            // Polymorphism demonstration
            PolymorphismClass polymorphismObj = new PolymorphismClass();
            polymorphismObj.MakeSound(new Animal { Name = "Dog" });
            polymorphismObj.MakeSound(new Animal { Name = "Cat" });

            // Abstraction demonstration
            AbstractionClass abstractionObj = new DerivedAbstractionClass();
            abstractionObj.Name = "Abstract";
            abstractionObj.PerformAction();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
