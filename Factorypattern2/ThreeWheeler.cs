using System;
namespace FactoryPatternApp
{
    public class ThreeWheeler : IVehicle
    {
        public ThreeWheeler()
        {
        }

        public void Drive()

        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("Let's get going!");
        }
    }
}
