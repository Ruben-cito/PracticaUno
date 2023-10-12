using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ListaNumero
{
    class Operaciones
    {
        public void imprimir2(List<int> numero)
        {

            foreach (var item in numero)
            {
                Console.WriteLine(item + " es multiplo de dos");
            }
        }
        public void imprimir5(List<int> numero)
        {

            foreach (var item in numero)
            {
                Console.WriteLine(item + " es multiplo de cinco");
            }
        }

    
        internal void MultiplosDeDos(List<int> numero)
        {
            
            var multiplosDeDos2 = numero.Where(x => x % 2 == 0).ToList();
           
            this.imprimir2(multiplosDeDos2);
          


        }

        internal void MultiplosDecinco(List<int> numero) //utilizando expresion lamba
        {

            var multiplosDeCinco5 = numero.Where(x => x % 5 == 0).ToList();

            this.imprimir5(multiplosDeCinco5);
        }

        internal bool primos(int x)
        {
            
            for (int i = 2; i*i<=x; i++) 
            {
                if (x % i == 0)
                    return false;
            }
            return true;
            

            
        }

        internal bool Numperfecto(int x)
        {
            int divisores = 0;
            for (int i = 1; i < x; i++)
            {
                if (x % i == 0)
                {
                    divisores = divisores + i;
                }

            }
            if (divisores == x)
                Console.WriteLine(x + " es numero perfecto");
            else
                Console.WriteLine(x + " No es perfecto");

            return false;



        }
    }
}
