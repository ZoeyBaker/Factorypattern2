using System;
namespace FactoryPatternApp
{
    public class Car : IVehicle
    {
        public Car()
        {
        }

        public void Drive()

        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("The Car is driving at a safe pace. Oh boy!");
        }
    }
}
