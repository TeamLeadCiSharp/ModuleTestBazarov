using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleTestBazaro
{
    public class AquaticType
    {
        public string TypeName => "Aquatic";

        public IEnclosure CreateEnclosure()
        {
            return new LakeEnclosure(6, 7);
        }
    }
}
