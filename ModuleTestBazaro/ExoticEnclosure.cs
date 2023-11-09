using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleTestBazaro
{
    public class ExoticEnclosure : Enclosure
    {
        public double LakeWidth { get; private set; }
        public double LakeHeight { get; private set; }

        public ExoticEnclosure(double width, double height, double lakeWidth, double lakeHeight)
            : base(width, height)
        {
            LakeWidth = lakeWidth;
            LakeHeight = lakeHeight;
        }

        public new double Area
        {
            get { return base.Area + (LakeWidth * LakeHeight); }
        }
    }
}
