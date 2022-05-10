using System;
using RPG.src.Entities;
namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero
            {
                Name = "arus",
                Level = 15,
                HeroType = "Knight"
            };
            Wizard wizard = new Wizard{
                Name="Mariah",
                Level=26,
                HeroType="White Wizard"
            };
            System.Console.WriteLine(hero.Attack());
            System.Console.WriteLine("\n");
            System.Console.WriteLine(wizard.Attack(25));

        }
    }



}
