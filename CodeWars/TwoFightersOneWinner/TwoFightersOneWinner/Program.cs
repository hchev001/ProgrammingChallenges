using System;
using System.Collections.Generic;

namespace TwoFightersOneWinner
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    public class Fighter
    {
        public string Name;
        public int Health, DamagePerAttack;

        public Fighter(string name, int health, int damagePerAttack)
        {
            this.Name = name;
            this.Health = health;
            this.DamagePerAttack = damagePerAttack;
        }

        public static string declareWinner(Fighter fighter1, Fighter fighter2, string firstAttacker)
        {
            //TODO
            return "";
        }
    }
}