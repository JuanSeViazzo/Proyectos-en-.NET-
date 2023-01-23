using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElDispositivo
{
    public class AppJuegos : Aplicacion
    {

        protected override int Tamanio { get => base.tamanioMB; }

        public AppJuegos(string nombre, Dispositivo.SistemaOperativo sistemaOperativo, int tamanio) : base(nombre, sistemaOperativo,tamanio)
        {

        }








    }
}
