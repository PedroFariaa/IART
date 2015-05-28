using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Cromossoma
    {
        List<int> genes;
        private int genesOpt;

        private float adpatacao;

        public Cromossoma(List<int> gen)
        {
            this.adpatacao = 0;
            this.genes = gen;
        }

        public Cromossoma(int tamanhoCromossoma, int genesOption)
        {
           this.adpatacao = 0;

           this.genesOpt = genesOption;
           genes = new List<int>();

           for (int i = 1; i <= tamanhoCromossoma; i++)
           {
               genes.Add(1+2*(i-1)); // adiciona apenas impares -> todos com a mesma orientacao
           }

           this.shuffle();
        }

        public void shuffle( )
        {
            var rnd = new Random();
            var shuffledList = this.genes.OrderBy(x => rnd.Next()).ToList();
        }

        public int getGene(int i)
        {
            return this.genes[i];
        }

        public List<int> getCromossoma()
        {
            return this.genes;
        }

        public void setGene(int i, int novo)
        {
            if (i >= genes.Count)
            {
                genes.Add(novo);
            }
            else
            {
                genes[i] = novo;
            }

            this.adpatacao = 0;
        }


        public float getAdaptacao()
        {
            if (adpatacao == 0)
            {
                /* CALCULAR O DESPERDICIO DA PLACA PARA CADA CROMOSSOMA */
            }

            return adpatacao;
        }

    
        public void imprimeGenes()
        {
            Console.WriteLine("imprimir genes");
        }


    }
}
