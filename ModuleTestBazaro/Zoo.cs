using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleTestBazaro
{
    public class Zoo
    {
        private List<IAnimal> animals;

        public Zoo()
        {
            animals = new List<IAnimal>();
        }

        public double CalculateTotalEnclosureArea()
        {
            double totalArea = 0;
            foreach (var animal in animals)
            {
                totalArea += animal.Enclosure.Area;
            }
            return totalArea;
        }
        public string ShowAnimalsInfo()
        {
            StringBuilder info = new StringBuilder();
            foreach (var animal in animals)
            {
                info.AppendLine(animal.Show());
            }
            return info.ToString();
        }
    }
}
