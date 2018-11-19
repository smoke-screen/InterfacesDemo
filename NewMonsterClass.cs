using System;
 
namespace InterfacesDemo
{
    interface IAttacker
    {
       double Attack(double armor);
       void TakeDamage(double attack);
    }
    public class Elf : Monster, IAttacker
    {
        double Strength;
        public Elf(string name, int level) : base(name, level)
        {
            this.Health = 3 * level;
            this.Armor = 10;
            this.Strength = 10;
        }
       public double Attack(double armor)
        {
            double damage = this.Strength;
            return damage;
        }

       public void TakeDamage(double attack)
        {
            double damageDealt = attack - this.Armor;
            this.Health = this.Health - damageDealt;
        }
    }

    public class Orc : Monster, IAttacker
    {
        double Strength;
        public Orc(string name, int level): base (name,level)
        {
            this.Health = 2 * level;
            this.Armor = 8;
            this.Strength = 8;
        }
   public double Attack(double armor)
        {
            double damage = this.Strength;
            return damage;
        }

    public void TakeDamage(double attack)
        {
            double damageDealt = attack - this.Armor;
            this.Health = this.Health - damageDealt;
        }
    }

}