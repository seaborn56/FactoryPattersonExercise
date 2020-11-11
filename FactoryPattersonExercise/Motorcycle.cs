using System;
namespace FactoryPattersonExercise
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
        }

        public void Drive()
        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("The Motorcycle is revving up!");
            Console.WriteLine("vroooooom");
        }

    }
}
