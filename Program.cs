using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main()
        {
            Elf legolas = new Elf("legolas",10);
            Orc ugluk = new Orc("ugluk",8);
            Console.WriteLine("The Orc's Health:" + ugluk.Health.ToString());
            Console.WriteLine("The Elf's Health:" + legolas.Health.ToString());

            /*for (ugluk.Health && legolas.Health; ugluk.Health && legolas.Health > 0; IAttacker<>.Battle())
            {
                Console.WriteLine("The ugluk's Health:" + Orc.Health.ToString());
                Console.WriteLine("The legolas's Health:" + Elf.Health.ToString());
            }*/

            while(legolas.Health > 0 && ugluk.Health > 0)
            {
                ugluk.TakeDamage(legolas.Attack(ugluk.Armor));
                legolas.TakeDamage(ugluk.Attack(legolas.Armor));
                Console.WriteLine("The Orc's Health:" + ugluk.Health.ToString());
                Console.WriteLine("The Elf's Health:" + legolas.Health.ToString());

            }

            if (ugluk.Health < 0)
            {
                Console.WriteLine("legolas wins!");
            }

            else if (legolas.Health < 0)
            {
                Console.WriteLine("ugluk wins!");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
