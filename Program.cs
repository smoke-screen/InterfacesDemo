using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing Cars");
            Car zCar = new Car("Datsun", "280Z", "1978");
            Car vette = new Car("Chevrolet", "Corvette", "2019");
            Car zCar2 = new Car("Datsun", "280Z", "1978");

            Console.WriteLine($"{zCar.ToString()} is not equal to a {vette.ToString()}: " + zCar.Equals(vette));
            Console.WriteLine($"{zCar.ToString()} is equal to a {zCar2.ToString()}: " + zCar.Equals(zCar2));
        }
    }
}
