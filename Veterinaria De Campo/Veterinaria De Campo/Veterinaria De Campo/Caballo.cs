using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria_De_Campo
{
    public class Caballo : Animal 
    {

        private bool corredor;

        public Caballo(string nombre, int kiloAlimentos, bool corredor) : base(kiloAlimentos, nombre)
        {
        }

        public override bool ComePasto { get { return true; } }
        public override bool ComeBalanceado { get => false; }



        public override string Datos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Datos());
            sb.AppendLine($"Es de carreras? : {(corredor ? "SI" : "NO") }");

            return sb.ToString();

        }




    }
}
