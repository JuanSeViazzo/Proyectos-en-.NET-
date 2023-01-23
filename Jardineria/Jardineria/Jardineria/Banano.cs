using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardineria
{
    public class Banano : Planta
    {

        private string codigo;

        public Banano(string nombre, int tamanio, string codigo) : base(nombre, tamanio)
        {
            this.codigo = codigo;   
        }

        public override bool TieneFlores { get => true; }
        public override bool TieneFruto { get => true; }


        public override string ResumenDeDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ResumenDeDatos());
            sb.AppendLine(String.Format($"Codigo Internacional: {this.codigo}"));

            return sb.ToString();
        }






    }
}
