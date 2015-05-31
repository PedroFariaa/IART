using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Object
    {
        public static int lastID = -1;
        int id;
        float areaObj;
        public float Obj_X, Obj_Y;

        public Object()
        {
            this.id = lastID + 2;
            lastID = lastID + 2;
            this.areaObj = Area();
        }

        public void rodar(Object ob1)
        {
            if (this.id % 2 == 0)
                this.id = id--;
            else if (this.id % 2 != 0)
                this.id = id++;
        }

        public virtual float Area()
        {
            return 0;
        }
        
        public virtual float dimMenor()
        {
            return 0;
        }

        internal void imprime()
        {
            Console.WriteLine();
            Console.WriteLine(" - - - - -  Object  - - - - - ");
            Console.WriteLine();
            Console.WriteLine(this.getClass());

            if (this.getClass() == "triangulo")
            {
                Console.WriteLine("Tamnho da base" + this.getMedida1());
                Console.WriteLine("Altura" + this.getMedida2());
            }
            else if (this.getClass() == "rectangulo")
            {
                Console.WriteLine("Comprimento" + this.getMedida1());
                Console.WriteLine("Largura" + this.getMedida2());
            }
            else
            {
                Console.WriteLine("Raio" + this.getMedida1());
            }


        }

        public virtual string getClass()
        {
            return "";
        }

        public virtual string getMedida2()
        {
            return "";
        }

        public virtual string getMedida1()
        {
            return "";
        }
    }
}
