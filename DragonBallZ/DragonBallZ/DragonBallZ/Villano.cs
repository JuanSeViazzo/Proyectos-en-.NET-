using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonBallZ
{
    public class Villano : Personaje
    {

        private bool maximoPoder;
        EOrigen origen;

        public Villano(string nombre,int  nivelPoder,List<EHabilidades>ataques, EOrigen origen) : base(ataques,nivelPoder,nombre)
        {
            this.origen = origen;
        }

        protected override string Descripcion
        {
           // get => "Soy Malísimo. Diabólico. Así como los profes de labo de la noche";
        
            get { return "Soy Malísimo. Diabólico. Así como los profes de labo de la noche"; }
        }

        public override string InfoPersonaje()
        {
            StringBuilder sb = new StringBuilder(); 

            sb.Append(base.InfoPersonaje());
            sb.AppendLine(string.Format($"El origen es {origen}"));
            sb.AppendLine(string.Format($"El maximo poder es {maximoPoder}"));

            return sb.ToString();   
        }

        public override string Transformarse()
        {
            if (maximoPoder is false)
            {
                nivelDePoder = 80;
                maximoPoder = true;
                return "Poder aumentado al maximo";


            }else
            {
                return "El poder ya esta al limite";
            }

        }





    }
}
