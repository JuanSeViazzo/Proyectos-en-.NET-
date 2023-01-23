using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pero_Que_Ensalada
{
    public class Rucula : Ingrediente
    {


        public override string Proceso { get => "cortar"; }
        public override string UnidadDeMedida { get => "hojas"; }

        public Rucula(string descripcion, int cantidad) : base(descripcion,cantidad)
        {

        }




    }
}
