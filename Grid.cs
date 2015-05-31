using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Grid
    {
        List<List<int>> grelha = new List<List<int>>();
        public float B_dimX, B_dimY;
        public int Blinhas, Bcolunas;

        public Grid(float B_dimX, float B_dimY, List<Object> obj)
        {
            this.B_dimX = B_dimX;
            this.B_dimY = B_dimY;
            Object menor = procuraObjMenor(obj);
            this.Blinhas = Convert.ToInt32(B_dimX) / Convert.ToInt32(menor.dimMenor());
            this.Bcolunas = Convert.ToInt32(B_dimY) / Convert.ToInt32(menor.dimMenor());
                                    
            for (int i = 0; i < Blinhas; i++)
            {
                List<int> linha = new List<int>();
                for (int j = 0; j < Bcolunas; j++)
                {
                    linha.Add(0);
                }
                grelha.Add(linha);
            }

        }

        public List<List<int>> getGrelha()
        {
            return this.grelha;
        }

        public int getColunas()
        {
            return grelha[0].Count;
        }

        private Object procuraObjMenor(List<Object> objectos)
        {
            Object temp = new Object() ;
            float menorVal = 999999;

            for (int i = 0; i < objectos.Count; i++ )
            {
                if (menorVal > objectos[i].dimMenor())
                {
                    menorVal = objectos[i].dimMenor();
                    temp = objectos[i];
                }
            }

            return temp;
        }

        public bool preenche(List<Object> objectos)
        {
            return true;
        }
    }
}
