using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2._1_Lesson_6
{
    class ClassForbattle:ClassForStat
    {
        public virtual void Punch()
        {
          SecondHealth  =-FirstDmg;
            Console.WriteLine($"у {SecondName }осталось здовроья {SecondHealth}");
        }
        public virtual void Restore()
        {
            int hp;
            FirstHealth += hp= new Random().Next(1,10);
            Console.WriteLine($"вы востановили здоровья теперь у вас {FirstHealth}hp");
        }
        public virtual void Spell()
        {
            int defense;
            FirstDefense += defense = new Random().Next(1, 10);
            Console.WriteLine("Использовал заклинание  усиления");
            Console.WriteLine($"Вы усилели свою броню на {defense} теперь у вас {FirstDefense}");
        }
        public void RandomSpell(int num)
        {
            if(num==1)
            {
                Console.WriteLine($"{SecondName} делает удар по вам");
                FirstHealth= - SecondDmg;
                Console.WriteLine($"у вас осталось {FirstHealth}");
                
            }
            if(num==2)
            {
                int hp;
                SecondHealth += hp = new Random().Next(1, 10);
                Console.WriteLine($"{SecondName} выпивает банку хп");
                Console.WriteLine($"он восстановил {hp} теперь у него {SecondHealth}");
            }
            if(num==3)
            {
                int defense;
                FirstDefense -= defense = new Random().Next(1, 10);
                Console.WriteLine($"{SecondName} использовал заклинание уменьшение брони");
                Console.WriteLine($"Ваша броня уменьшилась на {defense} теперь у вас {FirstDefense}");
            }
        }
    }
}
