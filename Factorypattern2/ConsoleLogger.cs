using System;
using System.Threading;

namespace FactoryPatternApp
{
    public class ConsoleLogger
    {
        public static void VehicleStartUpDialogue()

        {
            Console.WriteLine("Put Key in Ignition");
            Thread.Sleep(1000);
            Console.WriteLine("Turn Key!");
            Thread.Sleep(1000);


        }




}   }