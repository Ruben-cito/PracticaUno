using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaNumero
{
    internal class Program
    {
        

        static Operaciones _operaciones = new Operaciones(); 
        static void Main(string[] args)
        {
            List<int> numero=new List<int>();
            Console.Write("cuantos numeros desea ingresar: ");
            int dato=int.Parse(Console.ReadLine());
            for (int i = 0; i < dato; i++) 
            {
                Console.Write("ingrese numeros {0}: ",i+1);
                int num=int.Parse(Console.ReadLine());
                numero.Add(num);
            }


            _operaciones.MultiplosDeDos(numero);
            _operaciones.MultiplosDecinco(numero);
            var primos = numero.Where(x => _operaciones.primos(x)).ToList();

                foreach (var item in primos)
                {
                    Console.WriteLine(item + " es primo");
                }
            
            

            var numeroperfecto = numero.Where(x => _operaciones.Numperfecto(x)).ToList();

           


            Console.ReadKey();
        }
    }
}
