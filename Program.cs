using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            double v1, area;
            Console.WriteLine("Digite o Valor da aresta");

            v1 = double.Parse(Console.ReadLine());

            area = Math.Pow(v1, 2);

            Console.WriteLine("Area do quadrado:"+area);
         
        }
    }
}
