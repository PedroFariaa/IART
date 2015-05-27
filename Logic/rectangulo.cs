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

        public Rectangulo(int p1, int p2) : base()
        {
            this.dimX = p1;
            this.dimY = p2;
        }

        public override float Area()
        {
            var ret = dimX* dimY;
            return (float) ret;
        }
    }
}
