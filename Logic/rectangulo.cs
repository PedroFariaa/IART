using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Logic
{
    class Rectangulo : Object
    {
        private float dimX, dimY;

        public override float Area()
        {
            return dimX * dimY;
        }
    }
}
