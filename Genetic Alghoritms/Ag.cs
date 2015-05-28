using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Genetic_Alghoritms
{
    class Ag
    {
        private static float CrossOver_rate;
        private static float Mutation_rate;
        private static int tamanhoPopRandom; //??
        public static bool elitism;


        public static Populacao evolucao(Populacao popAnt)
        {
            Populacao popNova = new Populacao(popAnt.ToString().Length);
            int i = 1;

            if (elitism == true)
            {
                Cromossoma crom = popAnt.getMelhorAdaptado();

                if (crom.getAdaptacao() > 0)
                {
                    popNova.setCromossoma(0, crom);
                }
            }
            else
            {
                i = 0;
            }


            /* CROSSOVER ALEATORIO */
            for (; i < popAnt.ToString().Length; i++ )
            {
                Cromossoma crom1 = selecionaCromossoma(popAnt);
                Cromossoma crom2 = selecionaCromossoma(popAnt);

                Cromossoma cromNovo = crossOver(crom1, crom2);
                popNova.setCromossoma(i, cromNovo);
            }

            if (elitism == true)
            {
                i = 1;
            }
            else
            {
                i = 0;
            }

            /* RANDOM MUTATIONS -> INDIVIDUO PERFEITO NAO SOFRE MUTAÇOES */
            for (; i < popNova.ToString().Length; i++)
            {
                mutacao(popNova[i]);
            }

            return popNova;
        }

        private static Cromossoma selecionaCromossoma(Populacao pop)
        {
            Populacao temp = new Populacao(tamanhoPopRandom);

            Random r = new Random();
            for(int i = 0; i < tamanhoPopRandom; i++)
            {
                int random = r.Next(0, pop.ToString().Length);
                temp.setCromossoma(i, pop.getCromossoma(random));
            }
            // get the fittest
            Cromossoma melhor = temp.getMelhorAdaptado();
            return melhor;

        }


        public static void mutacao(Cromossoma crom)
        {
            Random rand = new Random();
            for (int i = 0; i < crom.count; i++)
            {
                int random = rand.Next(0, 1);
                if(random <= Mutation_rate)
                {
                    crom.setGene(i, crom.geraGene());
                }
            }
        }


        /* EFECTUA O CROSSOVER GENE A GENE */
        private static Cromossoma crossOver(Cromossoma crom1, Cromossoma crom2)
        {
            List<int> genes = new List<int>();
            Random rand = new Random();

            for (int i = 0; i < crom1.count; i++)
            {
                int random = rand.Next(0, 1);
                if(random <= CrossOver_rate)
                {
                    genes.Add(i, crom1.getGene(i));
                }
                else
                {
                    genes.Add(i, crom2.getGene(i));
                }
            }

            Cromossoma novo = new Cromossoma(genes);
            return novo;
        }

        public static void setElitism(bool e)
        {
            elitism = e;
        }

    }
}
