using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolucion
{
    public class Celular_Nuevo : Celular
    {
        public DateTime Fecha_Ingreso { get; set; }
        public int Precio { get; set; }

        public override void MostrarCelular() 
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("*****celulares nuevo******");
            Console.WriteLine("celular: " + Marca + "\nmodelo: " + Modelo+ "\nsistema operativo: " + SistemaOperativo + "\nram: " + Ram + "\nalmacenamiento: " + Almacenamiento+ "\nfechaIngreso: " + Fecha_Ingreso+ "\nprecio: " + Precio);
        
        }
    }
}
