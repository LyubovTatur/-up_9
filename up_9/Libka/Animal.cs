using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libka
{
    public abstract class Animal : IInfo, IAnimal
    {
        protected Animal(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public int Stamina = 0;
        public virtual void Display()
        {
            Console.WriteLine($"{Name} - животное.");
        }
        public virtual void Info()
        {
            Console.WriteLine("Живо́тные (лат. Animalia) — традиционно (со времён Аристотеля) выделяемая категория организмов, в настоящее время рассматривается в качестве биологического царства. Животные являются основным объектом изучения зоологии.");
        }
        public int Race()
        {
            Stamina--;
            if (Stamina<0)
            {
                Stamina = 0;
            }
            return Stamina;
        }
    }

}

//  Создать классы, состоящие из 15 кошачьих и списка их силы и
//  выносливости. Необходимо рассчитать общие затраты сил за на указанное количество
//  забегов, учитывая, что забеги каждый раз будет выполнять следующий из списка
//  кошачий.
