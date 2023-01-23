using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria_De_Campo
{
    public class Vaca : Animal
    {

        public enum Clasificacion
        {
            Lechera, Normando, Pasiega, HolandoArgentina, Tudanca
        }
        private Clasificacion clasificacion;

        public Vaca(string nombre, int kilosAlimentos) : base(kilosAlimentos,nombre)
        {
        }
        public Vaca(string nombre, int kilosAlimentos, Clasificacion clasificacion) : this(nombre, kilosAlimentos)
        {

        }



        public override bool ComePasto { get { return true; } }
        public override bool ComeBalanceado { get => true; }


        public override string Datos()
        {
            StringBuilder sb = new StringBuilder ();  
            sb.Append(base.Datos());
            sb.AppendLine($"Clasificada como : {this.clasificacion}");
            return sb.ToString ();  
        }















    }
}
