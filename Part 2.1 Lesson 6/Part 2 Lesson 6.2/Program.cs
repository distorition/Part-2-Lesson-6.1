using System;

namespace Part_2_Lesson_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Figure figure = new Figure(12,14);
            //figure.MakeFigure(12);
            //figure.MakeTreangle();
            Circle circle = new Circle();
            circle.MakeCircle(12,12,6);
        }
    }
}
