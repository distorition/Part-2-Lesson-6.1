using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2._1_Lesson_6
{
   public  class Warrior:Charater
    {
    
        public Dictionary<string,int> listWAriror{ get; set; }
        public Warrior()
        {
            listWAriror = new Dictionary<string, int>();
          

        }
        public void CreateWarrior()
        {
            int rand;
            listWAriror["Defense"] = Defense = rand = new Random().Next(1, 100);
            listWAriror["Dmg"] = Dmg = rand = new Random().Next(1, 100);
            listWAriror["Health"] = Health = rand = new Random().Next(1, 100);
            Console.WriteLine("Ввидите имя персонажа");
            string name = Console.ReadLine();
            Name = name;
            Console.WriteLine("ваше оружия это топор");
            Console.WriteLine($"Вы создали класс Воин с такими параметрами:\t Здоровье {Health}\t, \t Защита {Defense}\t Урон{Dmg} \t Имя:{Name} ");

        }
        public void RandomWarrior()
        {
            int rand;
            Health = rand = new Random().Next(1, 100); 
            Dmg = rand = new Random().Next(1, 100); 
            Defense = rand = new Random().Next(1, 100); 
            Name = "Djo";
        }
        //public void Show()
        //{
        //    Console.WriteLine($"Класс Воин ,Здоровье {Health}, Урон {Dmg}, Защита {Defense} ");
        //}
        //public void OnePunch()
        //{
        //    Console.WriteLine("воин бить рука");
        //    Health -=new Random().Next(1, 10);
        //    Console.WriteLine($"Осталось здоврья {Health}");
        //}
        //public override void Punch(int dmg)
        //{
        //    Console.WriteLine("воин делает удар ");
        //    base.Punch(dmg);
        //}
        //public override void Restore(int hp)
        //{
        //    base.Restore(hp);
        //}
        //public override void Spell()
        //{
        //    base.Spell();
        //    Console.WriteLine("Усиления");
        //    int def = 10;
        //    Defense += def;
        //    Console.WriteLine($"Защита увеличина на {def}");
        //    Console.WriteLine($"теперь ваша защита составляет {Defense}");
        //}
    }
}
