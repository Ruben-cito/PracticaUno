using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolucion
{
    public class Celular_Defectuoso : Celular
    {
        public DateTime Fechadefectuoso { get; set; }
        public string Motivo { get; set; }
        public override void MostrarCelular()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("\n*****celulares defectutoso******");
            Console.WriteLine("celular: " + Marca + " \nmodelo: "+Modelo + "\nsistema operativo: "
                + SistemaOperativo + "\nram: " + Ram + "\nalmacenamiento: " + Almacenamiento+ "\nfechaDefectuoso: " + Fechadefectuoso+ "\nmotivo: " + Motivo);
        }
    }
}
