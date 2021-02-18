using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libka
{
    public class Catlike : Animal, IInfo, IAnimal
    {
        public Catlike(string name) : base(name)
        {
        }
        public override void Display()
        {
            Console.WriteLine($"{Name} - животное из рода кошачьих.");
        }
        public override void Info()
        {
            Console.WriteLine("Коша́чьи, или ко́шки[2][3], или фели́ды[4] (лат. Felidae), — семейство млекопитающих отряда хищных. Наиболее специализированные из хищников, приспособленные к добыванию животной пищи путём подкрадывания, подкарауливания, реже — преследования.");
        }
    }
}
