using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2._1_Lesson_6.BattleClasses
{
    class Tank:Charater
    {
        public void CreateTank()
        {
            int rand;
            Defense = rand = new Random().Next(1, 100);
            Dmg = rand = new Random().Next(1, 100);
            Health = rand = new Random().Next(1, 100);
            Console.WriteLine("Ввидите имя персонажа");
            string name = Console.ReadLine();
            Name = name;
            Console.WriteLine("ваше оружия это топор");
            Console.WriteLine($"Вы создали класс Воин с такими параметрами:\t Здоровье {Health}\t, \t Защита {Defense}\t Урон{Dmg} \t Имя:{Name} ");

        }
        public void RandomTank()
        {
            int rand;
            Health = rand = new Random().Next(1, 100);
            Dmg = rand = new Random().Next(1, 100);
            Defense = rand = new Random().Next(1, 100);
            Name = "Dob";
        }
    }
}
