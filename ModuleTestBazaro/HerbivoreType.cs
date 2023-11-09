using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleTestBazaro
{
    public class HerbivoreType
    {
        public string TypeName => "Herbivore";

        public IEnclosure CreateEnclosure()
        {
            return new Enclosure(5, 6);
        }
    }
}
