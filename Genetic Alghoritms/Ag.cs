using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Genetic_Alghoritms
{
    class Ag
    {
        private static float crossOver_rate = 0.6F;
        private static float Mutation_rate = 0.1F;
        public static bool elitism;

        public Ag(float p1, float p2, bool p3)
        {
            crossOver_rate = p1;
            Mutation_rate = p2;
            elitism = p3;
        }


        public Populacao evolucao(Populacao popAnt, Grid g, List<Object> objectos)
        {
            Populacao popNova = new Populacao();
            int i = 1;

            if (elitism == true)
            {
                Cromossoma crom = popAnt.getMelhorAdaptado(g, objectos);

                if (crom.getAdaptacao(g, objectos) > 0)
                {
                    popNova.setCromossoma(0, crom);
                }
            }
            else
            {
                i = 0;
            }


            /* CROSSOVER ALEATORIO */
            for (; i < popAnt.Ncromossomas(); i++ )
            {
                Cromossoma crom1 = selecionaCromossoma(popAnt, g, objectos);
                Cromossoma crom2 = selecionaCromossoma(popAnt, g, objectos);

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
            for (; i < popNova.Ncromossomas(); i++)
            {
                mutacao(popNova.getCromossoma(i));
            }

            return popNova;
        }

        private static Cromossoma selecionaCromossoma(Populacao pop, Grid g, List<Object> objectos)
        {
            Populacao temp = new Populacao();

            Random r = new Random();
            for(int i = 0; i < pop.Ncromossomas() ; i++)
            {
                int random = r.Next(0, pop.Ncromossomas() - 1);
                temp.setCromossoma(i, pop.getCromossoma(random));
            }
            // get the fittest
            Cromossoma melhor = temp.getMelhorAdaptado(g, objectos);
            return melhor;

        }

        /* A mutacao vai apenas alterar a orientacao do objecto */
        public static void mutacao(Cromossoma crom)
        {
            Random rand = new Random();
            for (int i = 0; i < crom.NumberGenes(); i++)
            {
                int random = rand.Next(0, 1);
                if(random <= Mutation_rate)
                {
                    crom.mutate(i);
                }
            }
        }


        /* EFECTUA O MULTIPOINT CROSSOVER */
        private static Cromossoma crossOver(Cromossoma crom1, Cromossoma crom2)
        {
            List<KeyValuePair<int, int>> genes = new List<KeyValuePair<int, int>>();

            if (crom2.NumberGenes() < crom1.NumberGenes())
            {
                Cromossoma temp = new Cromossoma(crom2.getCromossoma());
                crom2 = crom1;
                crom1 = temp;
            }

            Random rand = new Random();
            int random = rand.Next(0, 1);
            
            for (int i = 0; i < crom2.NumberGenes(); i++)
            {
                if (random < crossOver_rate)
                {
                    genes.Add(crom1.getGene(i));
                }
                else
                {
                    genes.Add(crom2.getGene(i));
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
