using System;
namespace FactoryPattersonExercise
{
    public class Car : IVehicle
    {
        public Car()
        {
        }

        public void Drive()
        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("The Car is driving! Woo!");
        }
    }
}
