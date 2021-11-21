using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2._1_Lesson_6
{
  class Create
    {
        private string choise { get; set; }
      public  int NumOfChoise { get; set; }
     
        public void Creat()
        {
            Console.WriteLine("создаем новй класс");
           do
            {
                int rand = new Random().Next(0, 6);
                if (rand == 0)
                {
                    NumOfChoise = rand;
                    Console.WriteLine("Воин:Создать? Да, Нет");
                    choise = Console.ReadLine();
                    Console.WriteLine(NumOfChoise);
                }
                if (rand == 1)
                {
                    NumOfChoise = rand;
                    Console.WriteLine("Разбийник: Создать?да,НЕт");
                    choise = Console.ReadLine();
                    Console.WriteLine(NumOfChoise);
                }
                if (rand == 2)
                {
                    NumOfChoise = rand;
                    Console.WriteLine("Танк: Создать?да,НЕт");
                    choise = Console.ReadLine();
                    Console.WriteLine(NumOfChoise);
                }
                if (rand == 3)
                {
                    NumOfChoise = rand;
                    Console.WriteLine("Хил: Создать?да,НЕт");
                    choise = Console.ReadLine();
                    Console.WriteLine(NumOfChoise);
                }
                if (rand == 4)
                {
                    NumOfChoise = rand;
                    Console.WriteLine("БЕрс: Создать?да,НЕт");
                    choise = Console.ReadLine();
                    Console.WriteLine(NumOfChoise);
                }
                if (rand == 5)
                {
                    NumOfChoise = rand;
                    Console.WriteLine("ЛУчник: Создать?да,НЕт");
                    choise = Console.ReadLine();
                    Console.WriteLine(NumOfChoise);
                }

            } while (choise == "Нет" || choise == "нет");
        }
      
    }
}
