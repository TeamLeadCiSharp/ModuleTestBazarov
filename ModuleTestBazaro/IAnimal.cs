using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleTestBazaro
{
    public interface IAnimal
    {
        string Name { get; }
        IEnclosure Enclosure { get; }
        string Show();
    }
}
