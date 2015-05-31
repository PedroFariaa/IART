using ConsoleApplication1.Genetic_Alghoritms;
using ConsoleApplication1.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************************************");
            Console.WriteLine("** OPTIMIZAÇÃO DE CORTE DE OBECJTOS EM PLACAS DE MADEIRA **");
            Console.WriteLine("***********************************************************");
            Console.WriteLine();
            Console.Write("Largura da Placa: ");
            var input_B_dimX = Console.ReadLine();

            Console.Write("Altura da Placa: ");
            var input_B_dimY = Console.ReadLine();

            Board placa = new Board(float.Parse(input_B_dimX), float.Parse(input_B_dimY));
            
            Console.WriteLine();
            Console.Write("Número de objectos a cortar: ");
            var input_NO = Console.ReadLine();
            int Numb_Obj = Convert.ToInt32(input_NO);

            for(int a = 0; a < Numb_Obj; a++){
                Console.WriteLine();
                Console.WriteLine("----------------------");
                Console.WriteLine("-- Adding an Object --");
                Console.WriteLine("----------------------");
                Console.WriteLine();

                Console.WriteLine("1. rectângulo");
                Console.WriteLine("2. triângulo");
                Console.WriteLine("3. círculo");
                Console.WriteLine("Forma geométrica pretendida: ");
                int input_O_formgeo = Convert.ToInt32(Console.ReadLine());

                if (input_O_formgeo == 1) 
                {
                    Console.Write("Largura do rectângulo: ");
                    var input_O_X = Console.ReadLine();
                    Console.Write("Altura do rectângulo: ");
                    var input_O_Y = Console.ReadLine();
                    /* VERIFICAR TAMANHO DAS PEÇAS */
                    if (float.Parse(input_O_X) > float.Parse(input_B_dimX) || float.Parse(input_O_Y) > float.Parse(input_B_dimY))
                    {
                        a--;
                        Console.WriteLine("\nO objecto tem tamanho superior ao da placa. Introduz novas medidas!");
                    }
                    else
                    {
                        placa.getObjects().Add(new Rectangulo(float.Parse(input_O_X), float.Parse(input_O_Y)));
                    }                    
                }
                else if (input_O_formgeo == 2)
                {
                    Console.Write("Base do triângulo: ");
                    var input_O_B = Console.ReadLine();
                    Console.Write("Altura do triângulo: ");
                    var input_O_H = Console.ReadLine();
                    if (float.Parse(input_O_B) > float.Parse(input_B_dimX) || float.Parse(input_O_H) > float.Parse(input_B_dimY))
                    {
                        a--;
                        Console.WriteLine("\nO objecto tem tamanho superior ao da placa. Introduz novas medidas!");
                    }
                    else
                    {
                        placa.getObjects().Add(new Triangulo(float.Parse(input_O_B), float.Parse(input_O_H)));
                    }
                }
                else if (input_O_formgeo == 3)
                {
                    Console.Write("Raio do círculo: ");
                    var input_O_R = Console.ReadLine();
                    if (float.Parse(input_O_R) > float.Parse(input_B_dimX) || float.Parse(input_O_R) > float.Parse(input_B_dimY))
                    {
                        a--;
                        Console.WriteLine("\nO objecto tem tamanho superior ao da placa. Introduz novas medidas!");
                    }
                    else
                    {
                        placa.getObjects().Add(new Circulo(float.Parse(input_O_R)));
                    }
                }
                else
                {
                    Console.WriteLine("A opção introduzida é inválida");
                }
                

            }

            Grid g = new Grid(float.Parse(input_B_dimX), float.Parse(input_B_dimY), placa.getObjects());

            Populacao pInicial = new Populacao(5, placa.getObjects().Count);
            
            Ag evo = new Ag(0.6F, 0.1F, true);

            Populacao pFinal = evo.evolucao(pInicial, g, placa.getObjects());
            Cromossoma best = pFinal.getMelhorAdaptado(g, placa.getObjects());

            best.imprimeGenes(placa.getObjects());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("DESPERDÍCIO: " + placa.getDesperdicio()*100 + "%");

            Console.ReadKey();
        }
    }
}
