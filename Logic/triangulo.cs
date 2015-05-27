using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class triangulo : Object
    {
        private int t_base;
        private int altura;

        public override float Area()
        {
            return t_base * altura / 2;
        }

    }
}
