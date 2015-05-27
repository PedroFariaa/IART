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
        private List<Object> objectos = new List<Object> ();
        float B_dimX, B_dimY;

        public Board(float p1, float p2)
        {
            this.B_dimX = p1;
            this.B_dimY = p2;
        }


        public List<Object> getObjects()
        {
            return objectos;
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
