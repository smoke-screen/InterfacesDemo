using System;
 
namespace InterfacesDemo
{
    public class Monster : IEquatable<Monster>
    {
        public int Health;
        private int Armor;
        private int Level;
        public string Name;
        public int Strength;
        public Monster(string name, int level)
        {
            this.Name = name;
            this.Level = level;
        }

        public bool Equals(Monster other)
        {
            return this.Level == other.Level;
        }

        override public string ToString()
        {
            return this.Name;
        }
    }

    interface IAttacker<Monster>
    {
        public int Attack(Monster obj)
        {
            int damage = obj.Strength;
            return damage;
        }

        public void TakeDamage(int damage, Monster obj)
        {
            int damageDealt = damage - obj.armor;
            obj.Health = obj.Health - damageDealt;
        }
        public void Battle(obj Attacker, obj Defender)
        {
            int damageDealt = Attack(Attacker);
            TakeDamage(damageDealt, Defender);
            damageDealt = Attack(Defender);
            TakeDamage(damageDealt, Attacker);
        }
    }
    public class Elf : Monster, IAttacker
    {
        public Elf()
        {
            this.Health = 0.8 * Level;
            this.Armor = 3;
            this.Strength = 10;
        }
    }

    public class Orc : Monster, IAttacker
    {
        public Orc()
        {
            this.Health = 1.5 * Level;
            this.Armor = 7;
            this.Strength = 5;
        }
    }
    class Program
    {

        static void Main()
        {
            Elf Elf = new Elf();
            Orc Orc = new Orc();
            Console.WriteLine("The Orc's Health:" + Orc.Health.ToString());
            Console.WriteLine("The Elf's Health:" + Elf.Health.ToString());

            for (Orc.Health && Elf.Health; Orc.Health && Elf.Health > 0; IAttacker<>.Battle())
            {
                Console.WriteLine("The Orc's Health:" + Orc.Health.ToString());
                Console.WriteLine("The Elf's Health:" + Elf.Health.ToString());
            }

            if (Orc.Health < 0)
            {
                Console.WriteLine("The Elf wins!");
            }

            else if (Elf.Health < 0)
            {
                Console.WriteLine("The Orc wins!");
            }
            else
            {
                Console.WriteLine("error");
            }
        }

    }

}