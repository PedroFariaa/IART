using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Board
    {
        int[][] cel; //array de celulas
        List<Object> objectos;
        int B_dimX, B_dimY;
        private short p1;
        private short p2;

        public Board(short p1, short p2)
        {
            this.B_dimX = p1;
            this.B_dimY = p2;
        }


        public void addObj(Object ob1)
        {
            objectos.Add(ob1);
        }

        public float getOcupacao()
        {
            float area_parcelas = 0;
            foreach(Object obj in objectos){
                area_parcelas = obj.Area();
            }
            float area_placa = B_dimX * B_dimY;
            return area_parcelas / area_placa;
        }

        public float getDesperdicio()
        {
            return 1 - getOcupacao();
        }

    }
}
