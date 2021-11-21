using Part_2._1_Lesson_6.BattleClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2._1_Lesson_6
{
    class Arena:ClassForbattle
    {
      
         
        public void battle(int FirstNum,int SecndNum)
        {
            var rand = new Random().Next(1, 100);
         if(FirstNum== 0)
            {
                Warrior warrior = new Warrior();
                warrior.CreateWarrior();
                FirstHealth = warrior.Health;
                FirstDmg = warrior.Dmg;
                FirstDefense = warrior.Defense;
            }
         if(FirstNum==1)
            {
                Rogue rogue = new Rogue();
                rogue.CreateRogue();
                FirstDefense = rogue.Defense;
                FirstDmg = rogue.Dmg;
                FirstHealth = rogue.Health;
            }
            if (FirstNum == 2)
            {
                Tank rogue = new Tank();
                rogue.CreateTank();
                FirstDefense = rogue.Defense;
                FirstDmg = rogue.Dmg;
                FirstHealth = rogue.Health;
            }
            if (FirstNum == 3)
            {
                Healer rogue = new Healer();
                rogue.CreateHealler();
                FirstDefense = rogue.Defense;
                FirstDmg = rogue.Dmg;
                FirstHealth = rogue.Health;
            }
            if (FirstNum == 4)
            {
                Berserk rogue = new Berserk();
                rogue.CreateBerserk();
                FirstDefense = rogue.Defense;
                FirstDmg = rogue.Dmg;
                FirstHealth = rogue.Health;
            }
            if (FirstNum == 5)
            {
                arrow rogue = new arrow();
                rogue.CreateArrow();
                FirstDefense = rogue.Defense;
                FirstDmg = rogue.Dmg;
                FirstHealth = rogue.Health;
            }
            if (SecndNum==0)
            {
                Warrior warrior = new Warrior();
                warrior.RandomWarrior();
                SecondDmg = warrior.Dmg;
                SecondHealth = warrior.Health;
                SecondDefense = warrior.Defense;
                SecondName = warrior.Name;
                Console.WriteLine($"Вы встретиили война {SecondName}");
                Console.WriteLine($"С такими вот параметрами Здоровье {SecondHealth} ");
                Console.WriteLine($"Защита { SecondDefense}");
                Console.WriteLine($"Урон {SecondDmg}");
            }
            if (SecndNum == 1)
            {
                Rogue rogue = new Rogue();
                rogue.RandomRogue();
                SecondDmg = rogue.Dmg;
                SecondHealth = rogue.Health;
                SecondDefense = rogue.Defense;
                SecondName = rogue.Name; 
                Console.WriteLine($"Вы встретиили война {SecondName}");
                Console.WriteLine($"С такими вот параметрами Здоровье {SecondHealth} ");
                Console.WriteLine($"Защита { SecondDefense}");
                Console.WriteLine($"Урон {SecondDmg}");
            }
            if (SecndNum == 2)
            {
                Tank warrior = new Tank();
                warrior.RandomTank();
                SecondDmg = warrior.Dmg;
                SecondHealth = warrior.Health;
                SecondDefense = warrior.Defense;
                SecondName = warrior.Name;
                Console.WriteLine($"Вы встретиили tank {SecondName}");
                Console.WriteLine($"С такими вот параметрами Здоровье {SecondHealth} ");
                Console.WriteLine($"Защита { SecondDefense}");
                Console.WriteLine($"Урон {SecondDmg}");
            }
            if (SecndNum == 3)
            {
                Healer warrior = new Healer();
                warrior.RandomHealler();
                SecondDmg = warrior.Dmg;
                SecondHealth = warrior.Health;
                SecondDefense = warrior.Defense;
                SecondName = warrior.Name;
                Console.WriteLine($"Вы встретиили tank {SecondName}");
                Console.WriteLine($"С такими вот параметрами Здоровье {SecondHealth} ");
                Console.WriteLine($"Защита { SecondDefense}");
                Console.WriteLine($"Урон {SecondDmg}");
            }
            if (SecndNum == 4)
            {
                Berserk warrior = new Berserk();
                warrior.RandomBerserk();
                SecondDmg = warrior.Dmg;
                SecondHealth = warrior.Health;
                SecondDefense = warrior.Defense;
                SecondName = warrior.Name;
                Console.WriteLine($"Вы встретиили tank {SecondName}");
                Console.WriteLine($"С такими вот параметрами Здоровье {SecondHealth} ");
                Console.WriteLine($"Защита { SecondDefense}");
                Console.WriteLine($"Урон {SecondDmg}");
            }
            if (SecndNum == 5)
            {
                arrow warrior = new arrow();
                warrior.RandomArrow();
                SecondDmg = warrior.Dmg;
                SecondHealth = warrior.Health;
                SecondDefense = warrior.Defense;
                SecondName = warrior.Name;
                Console.WriteLine($"Вы встретиили tank {SecondName}");
                Console.WriteLine($"С такими вот параметрами Здоровье {SecondHealth} ");
                Console.WriteLine($"Защита { SecondDefense}");
                Console.WriteLine($"Урон {SecondDmg}");
            }
        }
    }
}
