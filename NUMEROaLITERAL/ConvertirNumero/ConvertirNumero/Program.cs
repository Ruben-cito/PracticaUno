using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertirNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string numtexto;
            Console.Write("ingres un numero: ");
            numero=int.Parse(Console.ReadLine());
            if (numero >= 100)
                Console.WriteLine("ingrese un numero entre 0 y 99");
            else
            {
                numtexto = Cadenas.ConvertirNumero(numero);
                Console.Write("la parte literal es:{0}",numtexto);
            }
            Console.ReadKey();
        }
    }
}
