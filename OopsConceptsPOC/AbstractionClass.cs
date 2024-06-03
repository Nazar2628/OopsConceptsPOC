using System;

namespace OOPConceptsPOC
{
    // Abstract class for abstraction
    public abstract class AbstractionClass
    {
        public string Name { get; set; }

        // Abstract method
        public abstract void PerformAction();
    }

    // Concrete class implementing abstraction
    public class DerivedAbstractionClass : AbstractionClass
    {
        public override void PerformAction()
        {
            Console.WriteLine($"{Name} performs an action.");
        }
    }
}
