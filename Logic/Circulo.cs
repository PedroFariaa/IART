using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Circulo : Object
    {
        float raio;

        public override float Area()
        {
            var ret =  2 * Math.PI * raio * raio;
            return (float) ret;
        }


    }
}
