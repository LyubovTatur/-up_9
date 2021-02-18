using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libka;

namespace up_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[] {new Cat("1"), new Tiger("2"), new Cat("3"), new Tiger("4"), new Cat("5"), new Tiger("6"), new Cat("7"), new Tiger("8"), new Cat("9"), new Tiger("10"), new Cat("11"), new Tiger("12"), new Cat("13"), new Tiger("14"), new Cat("15")};
            var a = new Catlike("0");
            var b = new Cat("0");
            var c = new Tiger("0");
            a.Info();
            b.Info();
            c.Info();
            for (int i = 0; i < animals.Length+1; i++)
            {
                try
                {

                
                animals[i].Display();
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Бой {j+1}. Осталось {animals[i].Race()} выносливости.");
                }
                }
                catch (IndexOutOfRangeException)
                {

                    Console.WriteLine("АУТ ОФ РЕНДЖ ЭКСЕПТИОН!!!!!!");           
                }
            }
            try
            {
                int i = 0;
                Console.WriteLine(1/i);
            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("ДИВАЙД БАЙ ЗИРО ЭКСЕПШОН!!!!!!!!!!");
            }
            Console.ReadLine();
        }
    }
}
