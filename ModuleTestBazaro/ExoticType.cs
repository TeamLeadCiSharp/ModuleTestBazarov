using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleTestBazaro
{
    public class ExoticType
    {
        public string TypeName => "Exotic";

        public IEnclosure CreateEnclosure()
        {
            return new ExoticEnclosure(10, 5, 3, 3);
        }
    }
}
