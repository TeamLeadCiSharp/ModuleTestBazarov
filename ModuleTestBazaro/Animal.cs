using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleTestBazaro
{
    public class Animal: IAnimal
    {
        public string Name { get; private set; }
        public IEnclosure Enclosure { get; private set; }

        public Animal(string name, IEnclosure enclosure)
        {
            Name = name;
            Enclosure = enclosure;
        }
        public string Show()
        {
            return $"Тварина: Ім'я - {Name}, {Enclosure.Show()}";
        }
    }
}
