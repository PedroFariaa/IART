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

        public Populacao(int tamanhoPopulacao, int tamanhoCromossoma, int OpcaoGenes)
        {
            cromossomas = new List<Cromossoma>();
            for (int i = 0; i < tamanhoPopulacao; i++)
            {
                Cromossoma novo = new Cromossoma(tamanhoCromossoma, OpcaoGenes);
                cromossomas.Add(novo);
            }
        }

        public Cromossoma getCromossoma(int pos)
        {
            return cromossomas[pos];
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

        public Cromossoma getMelhorAdaptado()
        {
            Cromossoma melhor = cromossomas[0];

            foreach (Cromossoma crom in cromossomas)
            {
                if (melhor.getAdaptaca() < crom.getAdaptacao())
                {
                    melhor = crom;
                }
            }

            if ( melhor.getAdaptacao() == 0 )
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
