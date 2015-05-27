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
            Console.WriteLine("Otimiação de corte de objectos em placas de madeira");
            Console.WriteLine();
            Console.WriteLine("B_dimX");
            var input_B_dimX = Console.ReadLine();

            Console.WriteLine("B_dimY");
            var input_B_dimY = Console.ReadLine();

            Board placa = new Board(Convert.ToInt16(input_B_dimX), Convert.ToInt16(input_B_dimY));

            Console.WriteLine("Introduce the Number of objects you want to cut: ");
            var input_NO = Console.ReadLine();
            int Numb_Obj = Convert.ToInt32(input_NO);

            for(int a = 0; a < Numb_Obj; a++){
                Console.WriteLine("----------------------");
                Console.WriteLine("-- Adding an Object --");
                Console.WriteLine("----------------------");
                Console.WriteLine();

                Console.WriteLine("introduce forma geometrica");
                Console.WriteLine("1. rectangulo");
                Console.WriteLine("2. triangulo");
                Console.WriteLine("3. circulo");
                int input_O_formgeo = Convert.ToInt32(Console.ReadLine());

                if (input_O_formgeo == 1) 
                {
                    Console.WriteLine("introduce dimX");
                    var input_O_X = Console.ReadLine();
                    Console.WriteLine("introduce dimY");
                    var input_O_Y = Console.ReadLine();
                    placa.getObjects().Add(new Rectangulo(Convert.ToInt32(input_O_X), Convert.ToInt32(input_O_Y)));
                }
                else if(input_O_formgeo == 2)
                {
                    Console.WriteLine("introduce Base do triang");
                    var input_O_B = Console.ReadLine();
                    Console.WriteLine("introduce altura");
                    var input_O_H = Console.ReadLine();
                    placa.getObjects().Add(new Triangulo(Convert.ToInt32(input_O_B), Convert.ToInt32(input_O_H)));
                }
                else if(input_O_formgeo == 3)
                {
                    Console.WriteLine("introduce raio");
                    var input_O_R = Console.ReadLine();
                    placa.getObjects().Add(new Circulo(Convert.ToInt32(input_O_R)));
                }
                else
                {
                    Console.WriteLine("The option you have introduced is not valid");
                }
                

            }


            /*
                        DEFINIR A GRID
             *          
             *          PASSAR OBJECTOS PARA CROMOSSOMA 
             *          VERIFICAR SE O CROMOSSOMA É POSSIVEL
             *          
             *          CONVERTER CROMOSSOMA PARA STRING ?
             *          UTILIZAR AG
             *          
             *          VERIFICAR SE O CROMOSSOMA RESULTANTE É VALIDO
             *          APRESENTAR RESULTADOS
             
             */


            Console.WriteLine("SUCCESS !");
            Console.ReadKey();
        }
    }
}
