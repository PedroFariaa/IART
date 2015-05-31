using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Cromossoma
    {
        List<KeyValuePair<int, int>> genes;

        private float adpatacao;

        public Cromossoma(List<KeyValuePair<int, int>> gen)
        {
            this.adpatacao = 0;
            this.genes = gen;
        }

        public Cromossoma(int tamanhoCromossoma)
        {
           this.adpatacao = 0;

           genes = new List<KeyValuePair<int, int>>();

           for (int i = 1; i <= tamanhoCromossoma; i++)
           {
               genes.Add(new KeyValuePair<int, int>(i, 0));
           }

           this.shuffle();
        }

        public int NumberGenes()
        {
            return this.genes.Count;
        }

        public void shuffle( )
        {
            var rnd = new Random();
            var shuffledList = this.genes.OrderBy(x => rnd.Next()).ToList();
            this.genes = shuffledList;
        }

        public KeyValuePair<int, int> getGene(int i)
        {
            return this.genes[i];
        }

        public List<KeyValuePair<int, int>> getCromossoma()
        {
            return this.genes;
        }

        public void mutate(int i)
        {
            if (this.getGene(i).Value == 0)
            {
                genes[i] = new KeyValuePair<int, int>(this.getGene(i).Key, 1);
            }
            else
            {
                genes[i] = new KeyValuePair<int, int>(this.getGene(i).Key, 0);
            }
        }

        public void setGene(int i, int novo)
        {
            if (i >= genes.Count)
            {
                genes.Add(new KeyValuePair<int, int>(novo, 0));
            }
            else
            {
                genes[i] = new KeyValuePair<int, int>(novo, 0);
            }

            this.adpatacao = 0;
        }


        public float getAdaptacao(Grid g, List<Object> objectos)
        {
            List<KeyValuePair<int, int>> aux = genes;
            float sumArea = 0;
            bool placed = false;

            foreach (KeyValuePair<int, int> obj in aux)
            {
                for (int i = 0; i < g.getGrelha().Count; i++)
                {
                    for (int j = 0; j < g.getColunas(); j++)
                    {
                        if (g.getGrelha()[i][j] == 0)
                        {
                            if (fit(g, objectos[obj.Key], i, j) == true)
                            {
                                place(g, objectos[obj.Key], i, j);
                                sumArea += objectos[obj.Key].Area();
                                placed = true;
                                break;
                            }
                        }
                    }
                    if (placed)
                    {
                        break;
                    }
                }
                if (!placed)
                {
                    break;
                }
            }
            return sumArea / (g.B_dimX * g.B_dimY);
        }

        private void place(Grid g, Object p, int i, int j)
        {
            for (int a = 0; a < p.Obj_X; a++)
            {
                for (int b = 0; b < p.Obj_Y; b++)
                {
                    g.getGrelha()[i + a][j + b] = 1;
                }
            }
        }

        private bool fit(Grid g, Object p, int i, int j)
        {
            for (int a = 0; a < p.Obj_X; a++)
            {
                for (int b = 0; b < p.Obj_Y; b++)
                {
                    if (g.getGrelha()[i + a][j + b] != 0)
                    {
                        return false;
                    }
                }
            }
            
            return true;
        }

    
        public void imprimeGenes()
        {
            Console.WriteLine("imprimir genes");
        }


    }
}
