using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libka
{
    public class Tiger : Catlike, IInfo, IAnimal
    {
        public Tiger(string name) : base(name)
        {
            Stamina = 80;

        }

        public override void Display()
        {
            Console.WriteLine($"{Name} - тигровое.");
        }
        public override void Info()
        {
            Console.WriteLine("Тигр[1] (лат. Panthera tigris) — вид хищных млекопитающих семейства кошачьих, один из пяти представителей рода пантера (лат. Panthera), который относится к подсемейству больших кошек. Слово «тигр» происходит от др.-греч. τίγρις, которое в свою очередь восходит к др.-перс. *tigri от корня «*taig» со значением «острый; быстрый»[2][3][4].");
        }
    }
}
