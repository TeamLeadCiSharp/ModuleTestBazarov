using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleTestBazaro
{
    public class Enclosure : IEnclosure
    {
        public double Width { get; private set; }
        public double Height { get; private set; }

        public double Area
        {
            get { return Width * Height; }
        }

        public Enclosure(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public string Show()
        {
            return $"Вольєр: Ширина - {Width}, Висота - {Height}, Площа - {Area}";
        }
    }
}
