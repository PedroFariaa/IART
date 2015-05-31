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

        public Circulo(float p) : base()
        {
            this.raio = p;
            this.Obj_X = 2 * p;
            this.Obj_Y = 2 * p;
        }

        public override string getClass()
        {
            return "circulo";
        }

        public override string getMedida1()
        {
            return raio.ToString();
        }

        public override float Area()
        {
            var ret =  2 * Math.PI * raio * raio;
            return (float) ret;
        }

        public override float dimMenor()
        {
            return 2 * raio;
        }


    }
}
