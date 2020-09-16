using System;
namespace HelloWorld
{
    public class Car : Vehicle
    {
        public Car(string reg) :base(reg)
        {
            Console.WriteLine("Car is being initialized");
        }
    }
}
