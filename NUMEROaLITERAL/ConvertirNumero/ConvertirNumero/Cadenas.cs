using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConvertirNumero
{
    public class Cadenas

    { //vectores publicas declaradas 
        public static string[] unidadesUnaCifra = { "cero", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve" };
        public static string[] decenasDosCifras = { "","diez", "veinte", "trienta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa"};
        public static string[] especiales = { "diez","once", "doce", "trece", "catorce", "quince", "dieciseis", "diecisieste", "dieciocho", "diecinueve" };

        //funciones o metodos
        public static string ConvertirNumero(int numero)
        {
            if (numero < 10)
                return unidadesUnaCifra[numero];
            else if (numero < 20)
                return especiales[(numero +1)-11];
            else
            {       
                int unidad = numero % 10;//19/10=el modulo es 9
                int decenas = numero / 10;//19/10=el cociente es 1
                return decenasDosCifras[decenas]+" y "+ unidadesUnaCifra[unidad];
                
            }


        }

    }
}
