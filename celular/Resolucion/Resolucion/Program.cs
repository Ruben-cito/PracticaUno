using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Resolucion
{
    class Program
    {
        static void Main(string[] args)
        {
           
           Celular_Nuevo NuevoCel= new Celular_Nuevo();
            NuevoCel.Marca = "apple";
            NuevoCel.Modelo = "iphone 14 pro";
            NuevoCel.SistemaOperativo = "android";
            NuevoCel.Ram = "16 GB";
            NuevoCel.Almacenamiento = "128 GB";
            NuevoCel.Fecha_Ingreso = DateTime.Parse("02/04/2000");
            NuevoCel.Precio = 1500;

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


            //ingresando por listas
            //incluyendo al anterior nuevo celular
            List<Celular_Nuevo> listNuevoCelular = new List<Celular_Nuevo>();
            listNuevoCelular.Add(NuevoCel);

            //nuevos celulares
            listNuevoCelular.Add(new Celular_Nuevo()
            {
                Marca = "samsung",
                Modelo = "galaxy s8",
                SistemaOperativo = "android",
                Ram = "4 GB",
                Almacenamiento = "64 GB",
                Fecha_Ingreso = DateTime.Parse("05/04/2021"),
                Precio = 1000,

            });

            listNuevoCelular.Add(new Celular_Nuevo()
            {
                Marca = "honor",
                Modelo = "x8a",
                SistemaOperativo = "android",
                Ram = "8 GB",
                Almacenamiento = "128 GB",
                Fecha_Ingreso = DateTime.Parse("15/04/2022"),
                Precio = 5000,

            });

            listNuevoCelular.Add(new Celular_Nuevo()
            {
                Marca = "motorola",
                Modelo = "moto g32",
                SistemaOperativo = "android",
                Ram = "4 GB",
                Almacenamiento = "128 GB",
                Fecha_Ingreso = DateTime.Parse("25/04/2023"),
                Precio = 2000,

            });
            listNuevoCelular.Add(new Celular_Nuevo()
            {
                Marca = "realme",
                Modelo = "c55",
                SistemaOperativo = "android",
                Ram = "6 GB",
                Almacenamiento = "128 GB",
                Fecha_Ingreso = DateTime.Parse("01/05/2023"),
                Precio = 1800,

            });
            listNuevoCelular.Add(new Celular_Nuevo()
            {
                Marca = "xiaomi",
                Modelo = "x5 pro 5g",
                SistemaOperativo = "android",
                Ram = "8 GB",
                Almacenamiento = "256 GB",
                Fecha_Ingreso = DateTime.Parse("05/06/2022"),
                Precio = 3500,

            });
            listNuevoCelular.Add(new Celular_Nuevo()
            {
                Marca = "samsung",
                Modelo = "galaxy s3",
                SistemaOperativo = "android",
                Ram = "4 GB",
                Almacenamiento = "16 GB",
                Fecha_Ingreso = DateTime.Parse("01/01/2023"),
                Precio = 800,

            });
            listNuevoCelular.Add(new Celular_Nuevo()
            {
                Marca = "apple",
                Modelo = "a14",
                SistemaOperativo = "android",
                Ram = "6 GB",
                Almacenamiento = "64 GB",
                Fecha_Ingreso = DateTime.Parse("02/06/2022"),
                Precio = 4500,

            });
            listNuevoCelular.Add(new Celular_Nuevo()
            {
                Marca = "samsung",
                Modelo = "galaxy s21",
                SistemaOperativo = "android",
                Ram = "6 GB",
                Almacenamiento = "128 GB",
                Fecha_Ingreso = DateTime.Parse("05/03/2022"),
                Precio = 2000,

            });
            listNuevoCelular.Add(new Celular_Nuevo()
            {
                Marca = "motorolo",
                Modelo = "moto G4",
                SistemaOperativo = "android",
                Ram = "8 GB",
                Almacenamiento = "128 GB",
                Fecha_Ingreso = DateTime.Parse("01/01/2005"),
                Precio = 1500,

            });

            foreach (var ver in listNuevoCelular)
            {
                ver.MostrarCelular();
            }

            //funciones landa
            Console.WriteLine("****************************************");
            Console.WriteLine("espresiones landa");
            double PromedioPrecio=listNuevoCelular.Average(x=> x.Precio);
            Console.WriteLine("promedio de precio de los nuevos celular es:"+PromedioPrecio);

            //funcion
            Cel_MarcaS();

             void Cel_MarcaS()
            {
                Console.WriteLine("*******************************************");
                var CelularSamsung = listNuevoCelular.Where(x => x.Marca == "samsung");
                Console.WriteLine("celulares samsung");
                foreach (var item2 in CelularSamsung)
                {
                    Console.WriteLine(item2.Marca+" "+item2.Modelo+" "+item2.Ram+" "+item2.Almacenamiento+" "+item2.Precio);
                }
            }
            VerCelular();
           
                  void VerCelular()
            {
                Console.WriteLine("*******************************************");
                var CelularApple= listNuevoCelular.Where(x => x.Marca == "apple");
                Console.WriteLine("celulares apple linq");
                foreach (var item2 in CelularApple)
                {
                    Console.WriteLine(item2.Modelo +" " + item2.Precio);
                }
            }
           



            Console.WriteLine("***************************************");
            Console.WriteLine("espresiones linq");
            Celular_RSA(listNuevoCelular);
            Celular_Ingreso(listNuevoCelular);


            verCelular2(listNuevoCelular);

            void verCelular2(List<Celular_Nuevo> liscel)
            {
                Console.WriteLine("*************************************************************");
                var vercel = from Nuevo1 in liscel where Nuevo1.Marca =="apple" select Nuevo1;
                Console.WriteLine("celular apple por lambda");
                foreach (var item in vercel)
                {
                    Console.WriteLine(item.Modelo + " " +item.Precio);
                }
            }


            Console.ReadKey();

        }

        private static void Celular_Ingreso(List<Celular_Nuevo> celingreso)
        {
            Console.WriteLine("*************************************************************");
            var vercelular = from Nuevo in celingreso where Nuevo.Fecha_Ingreso.Year==2005 select Nuevo;
            Console.WriteLine("celular que ingreso el año 2005");
            foreach (var item in vercelular)
            {
                Console.WriteLine(item.Marca + "," + item.Modelo + " " + item.Ram + " " + item.SistemaOperativo + " " + item.Almacenamiento);
            }
        }

        private static void Celular_RSA(List<Celular_Nuevo> cel)
        {
            Console.WriteLine("*************************************************************");
            var vercelular=from Nuevo in cel where Nuevo.Ram=="8 GB"& Nuevo.SistemaOperativo=="android" & Nuevo.Almacenamiento=="128 GB" select Nuevo;
            Console.WriteLine("celular con especificaciones corespondientes");
            foreach (var item in vercelular)
            {
                Console.WriteLine(item.Marca + "," + item.Modelo + " "+item.Ram+" "+item.SistemaOperativo+" "+item.Almacenamiento);
            }
        }
    }
}
