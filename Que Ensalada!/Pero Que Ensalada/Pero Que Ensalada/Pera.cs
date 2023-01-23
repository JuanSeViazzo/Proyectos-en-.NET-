using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pero_Que_Ensalada
{
    public class Pera : Ingrediente
    {


        string tipo;

        public override string Proceso {get => "cubitar";}

        public override string UnidadDeMedida {get => "unidades";}    


        public override string Informacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Informacion());
            sb.AppendLine(String.Format($"Tipo: {this.tipo}"));
            sb.AppendLine(String.Format($"Su unidad de medida es: {this.UnidadDeMedida} y su proceso es: {this.Proceso}"));
            

            return sb.ToString();   


        }

        public Pera(string descripcion, int cantidad, string tipo) : base(descripcion,cantidad)
        {
            this.tipo = tipo;   
        }









    }
}
