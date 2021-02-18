using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libka
{
    public class Cat : Catlike, IInfo, IAnimal
    {
        public Cat(string name) : base(name)
        {
            Stamina = 4;
        }

        public override void Display()
        {
            Console.WriteLine($"{Name} - кот.");
        }
        public override void Info()
        {
            Console.WriteLine("Ко́шка, или дома́шняя ко́шка (лат. Félis silvéstris cátus[источник не указан 284 дня]), — домашнее животное, одно из наиболее популярных[1] (наряду с собакой) «животных-компаньонов»[2][3][4].");
        }
    }
}
