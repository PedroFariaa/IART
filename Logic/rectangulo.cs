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

        public Rectangulo(float p1, float p2) : base()
        {
            this.dimX = p1;
            this.dimY = p2;
            this.Obj_X = p1;
            this.Obj_Y = p2;
        }

        public override float Area()
        {
            var ret = dimX * dimY;
            return (float) ret;
        }

        public override float dimMenor()
        {
            if (dimX < dimY)
            {
                return dimX;
            }
            else
            {
                return dimY;
            }
        }
    }
}
