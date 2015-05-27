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
                string input_O_formgeo = Console.ReadLine();
                Console.WriteLine("introduce dimX");
                var input_O_X = Console.ReadLine();
                Console.WriteLine("introduce dimY");
                var input_O_Y = Console.ReadLine();

             /*   Object ob1 = new Object(Convert.ToInt32(input_O_X), Convert.ToInt32(input_O_Y), input_O_formgeo);*/
                Rectangulo ob1;
                placa.addObj(ob1);

            }
            

            Console.WriteLine("SUCCESS !");
            Console.ReadKey();
        }
    }
}
