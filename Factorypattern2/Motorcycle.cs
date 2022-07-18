using System;
namespace FactoryPatternApp
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
        }

        public void Drive()

        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("The Motorcycle is reving up!");
            Console.WriteLine("Vroooooooom");
        }
    }
}
