using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2._1_Lesson_6
{
   public class Charater
    {
        //public Charater(int dmg,int defense,string name,string weapon)
        //{
        //    Dmg = dmg;
        //    Defense = defense;
        //    Name = name;
        //    Weapon = weapon;
        //}
       
        public int Health { get; set; } 
        public int Dmg { get; set; }
        public int Defense { get; set; }
        public string Name { get; set; }
        //public string Weapon { get; set; }
        //public virtual void  TakeAllInfo()
        //{
        //    Console.WriteLine($"Кол-во здоровья {Health},Дпс {Dmg},Защита {Defense} ");
        //}

    }
}
