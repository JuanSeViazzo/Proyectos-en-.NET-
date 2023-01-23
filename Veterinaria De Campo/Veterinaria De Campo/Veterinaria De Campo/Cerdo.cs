using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria_De_Campo
{
    public class Cerdo : Animal
    {



        public override bool ComePasto { get { return false; } }
        public override bool ComeBalanceado { get => true; }


        public Cerdo (string nombre, int kiloAlimento) : base (kiloAlimento, nombre)    
        {
        }















    }
}
