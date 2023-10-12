using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolucion
{
    class Program
    {
        static void Main(string[] args)
        {
           
           Celular_Nuevo NuevoCel= new Celular_Nuevo();
            NuevoCel.Marca = "samsung";
            NuevoCel.Modelo = "galaxy s8";
            NuevoCel.SistemaOperativo = "android";
            NuevoCel.Ram = "8 GB";
            NuevoCel.Almacenamiento = "16 GB";
            NuevoCel.Fecha_Ingreso = DateTime.Parse("02/03/2021");
            NuevoCel.Precio = 45;
            NuevoCel.MostrarCelular();

            
            Celular_Defectuoso defetuosoCelu=new Celular_Defectuoso();
            defetuosoCelu.Marca = "guaguey";
            defetuosoCelu.Modelo = "xperia5";
            defetuosoCelu.SistemaOperativo = "android";
            defetuosoCelu.Ram = "4 GB";
            defetuosoCelu.Almacenamiento = "32 GB";
            
            defetuosoCelu.Fechadefectuoso = DateTime.Parse("01/01/2023");
            defetuosoCelu.Motivo = "pantalla clizada";


            defetuosoCelu.MostrarCelular();

            Console.ReadKey();

        }

    }
}
