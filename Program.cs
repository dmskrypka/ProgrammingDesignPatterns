using System;
using DesignPatterns.Creational;
using DesignPatterns.Structural;
using DesignPatterns.Behavioral;

// Code from site: http://www.dofactory.com/net/design-patterns

namespace DesignPatterns
{
    class Program
    {
        public static void Main()
        {
            CreationalController creational = new CreationalController();
            StructuralController structural = new StructuralController();
            BehavioralController behavioral = new BehavioralController();



            // Wait for user input
            Console.ReadKey();
        }
    }    
}
