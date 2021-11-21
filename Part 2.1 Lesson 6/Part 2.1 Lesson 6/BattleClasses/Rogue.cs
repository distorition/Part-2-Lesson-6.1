using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2._1_Lesson_6
{
    class Rogue:Charater
    {
        public Dictionary<string, int> listRogue { get; set; }
        public Rogue()
        {
            listRogue = new Dictionary<string, int>();
            
        }
        public void CreateRogue()
        {
            int rand ;
            listRogue["Defense"] = Defense = rand = new Random().Next(1, 100);
            listRogue["Dmg"] = Dmg = rand = new Random().Next(1, 100);
            listRogue["Health"] = Health = rand = new Random().Next(1, 100);
            Console.WriteLine("Ввидите имя персонажа");
            string name = Console.ReadLine();
            Name = name;
            Console.WriteLine("ваше оружия это кинжал");
            Console.WriteLine($"Вы создали класс Разбойник с такими параметрами:\tЗдоровье {Health}\t Защита {Defense}\t Урон{Dmg} \t Имя:{Name} ");

        }
        public void RandomRogue()
        {

            int rand ;
            Health = rand = new Random().Next(1, 100);
            Dmg = rand = new Random().Next(1, 100);
            Defense = rand = new Random().Next(1, 100);
            Name = "martin";
        }
        //public override void Spell()
        //{
        //    Console.WriteLine("Разбойник ");
        //    base.Spell();
        //    Console.WriteLine("веер клинков и нанес 12 урона ");
        //    Health -= 12;
            
        //}
        //public override void Punch(int dmg)
        //{

        //    base.Punch(dmg);
        //}
    }
}
