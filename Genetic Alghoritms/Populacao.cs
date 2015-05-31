using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1.Genetic_Alghoritms
{
    class Populacao
    {
        List<Cromossoma> cromossomas;


        public Populacao( )
        {
            cromossomas = new List<Cromossoma> ();
        }

        public Populacao(int tamanhoPopulacao, int tamanhoCromossoma)
        {
            cromossomas = new List<Cromossoma>();
            for (int i = 0; i < tamanhoPopulacao; i++)
            {
                Cromossoma novo = new Cromossoma(tamanhoCromossoma);
                cromossomas.Add(novo);
            }
        }

        public int Ncromossomas()
        {
            return this.cromossomas.Count;
        }

        public Cromossoma getCromossoma(int pos)
        {
            if (pos < cromossomas.Count)
                return cromossomas[pos];
            else
                return null;
        }

        public void setCromossoma(int pos, Cromossoma crom1)
        {
            if (pos >= cromossomas.Count)
            {
                cromossomas.Add(crom1);
            }
            else
            {
                cromossomas[pos] = crom1;
            }
        }

        public Cromossoma getMelhorAdaptado(Grid g, List<Object> objectos)
        {
            Cromossoma melhor = cromossomas[0];

            foreach (Cromossoma crom in cromossomas)
            {
                if (melhor.getAdaptacao(g, objectos) < crom.getAdaptacao(g, objectos))
                {
                    melhor = crom;
                }
            }

            if ( melhor.getAdaptacao(g, objectos) == 0 )
            {
                Random r = new Random();
                int random = r.Next(1, cromossomas.Count);
                return cromossomas[random-1];
            }

            return melhor;
        }

        public void imprimePopulacao()
        {
            foreach(Cromossoma crom in cromossomas)
            {
                crom.imprimeGenes();
            }
        }
    }
}
