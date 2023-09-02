using System;
namespace MultipleInheritance
{
    interface Car
    {
        void Drive();
    }
    interface Bus
    {
        void Drive();
    }
    class Vehicle : Car, Bus
    {

        void Car.Drive()
        {
            Console.WriteLine("Drive Car");
        }
        void Bus.Drive()
        {
            Console.WriteLine("Drive Bus");
        }
        static void Main()
        {
            Vehicle myVehicle = new Vehicle();
            ((Car)myVehicle).Drive();
            ((Bus)myVehicle).Drive();
      Console.Read();
        }
    }
}