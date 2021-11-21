using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2._1_Lesson_6
{
    class Fight:Arena
    {
        public Warrior warrior { get; set; } 
        public Rogue rogue { get; set; } 
        public Create create { get; set; } = new Create();

enum Rpgclass
        {
            warrior,
           rogue,
            Healler=3
        }

   
     public void Fights()
        {

            var dict = new Dictionary<int, string>()
            {
              
                [0] = "warrior",
                [1] = "rogue",
                [2]="Tank",
                [3]="Хил",
                [4]="Bers",
                [5]="Arrow"
            };
            create.Creat();
            Console.WriteLine("Вы создали класс");
            
            Console.WriteLine(string.Join("; ", dict.Select(entry => $" {entry.Key}:{entry.Value}")));
            Console.WriteLine(string.Join(",",dict[create.NumOfChoise]));
            
            
            int rand = new Random().Next(0,6);
            battle(create.NumOfChoise,rand);
            Console.WriteLine("Ваши дейсвтия 1-Бой\t 2-Разговор \t3-Уйти");
            int chois= Convert.ToInt32(Console.ReadLine());
            switch (chois)
            {
                case 1:
                   

                        int random = new Random().Next(1, 4);
                        Console.WriteLine($"Вы начинаете бой с {SecondName}");
                        Console.WriteLine("Ваши сопобности \t 1-Ударить \t2-Выпить хилку \t3 Усилить броню");
                    while (true) 
                    {
                        int spel = Convert.ToInt32(Console.ReadLine());
                        if (spel == 1)
                        {
                            Punch();
                            RandomSpell(random);

                        }
                        if (spel == 2)
                        {
                            Restore();
                            RandomSpell(random);
                        }
                        else
                        {
                            Spell();
                            RandomSpell(random);
                        }
                        if(SecondHealth <= 0 || FirstHealth <= 0)
                        {
                            break;
                        }
                    };

                        break;
                case 2:
                    Console.WriteLine("Варинаты диалога ");
                    Console.WriteLine("1-Дарова\t 2-Cпросить как жизнь\t 3-дать пять");
                    int choise1 = Convert.ToInt32(Console.ReadLine());
                    if(choise1==1)
                    {
                        Console.WriteLine(  $"вы поздароволись с {SecondName}");
                    }
                    if(choise1==2)
                    {
                        Console.WriteLine($"{SecondName} отвечает ");
                        Console.WriteLine("Было лучше пока тебя не встретил");
                    }
                    else
                    {
                        Console.WriteLine("Вы дали друг другу пять");
                    }
                    break;



                     
            }

        }
    }
}
