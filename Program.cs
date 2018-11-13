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

            Console.WriteLine("\n");

            Console.WriteLine("Testing Monsters");
            Monster sully = new Monster("Sully", 17);
            Monster mike = new Monster("Mike Wizowski", 15);
            Monster randall = new Monster("Randall", 17);

            Console.WriteLine($"{sully} is not equal to {mike}: " + sully.Equals(mike));
            Console.WriteLine($"{sully} is equal to {randall}: " + sully.Equals(randall));
        }
    }
}
