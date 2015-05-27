using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    abstract class Object
    {
        public static int lastID = -1;
        int id, dimX, dimY;
        float areaObj;
        string formaGeo;

        public Object(int p1, int p2, string input_O_formgeo)
        {
            this.id = lastID+2;
            this.dimX = p1;
            this.dimY = p2;
            this.formaGeo = input_O_formgeo;
        }

        public void rodar(Object ob1)
        {
            if (this.id % 2 == 0)
                this.id = id--;
            else if (this.id % 2 != 0)
                this.id = id++;
        }

        abstract public float Area();
        
    }
}
