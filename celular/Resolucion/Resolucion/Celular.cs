using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolucion
{
    public abstract class Celular
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string SistemaOperativo { get; set; }
        public string Ram { get; set; }
        public string  Almacenamiento { get; set; }

        public virtual void MostrarCelular()
        {
            Console.WriteLine("celular " + Marca + "modelo"+"sistema operativo"+SistemaOperativo+"ram"+Ram+"almacenamiento"+Almacenamiento);
        }
    }
}
