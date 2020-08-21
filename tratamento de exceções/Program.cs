using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tratamento_de_exceções
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    int A, B;
                    Console.Write("\nDivisão de A por B\nDigite A:");
                    A = int.Parse(Console.ReadLine());
                    Console.Write("\nDigite B:");
                    B = int.Parse(Console.ReadLine());
                    Console.WriteLine(A / B);
                }
                catch (DivideByZeroException X)
                {
                    Console.WriteLine(X.Message);
                }
                catch (FormatException lul)
                {
                    Console.WriteLine(lul.Message);
                }
                Console.ReadKey();
            }
        }
    }
}
