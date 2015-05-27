using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Triangulo : Object
    {
        private float t_base;
        private float altura;

        public Triangulo(int p1, int p2) : base()
        {
            this.t_base = p1;
            this.altura = p2;
        }

        public override float Area()
        {
            return t_base * altura / 2;
        }

    }
}
