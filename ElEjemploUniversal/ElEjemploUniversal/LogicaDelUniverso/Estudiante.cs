using System;
using System.Text;

namespace LogicaDelUniverso
{
    public class Estudiante
    {

        public static Random random;
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;


        static Estudiante ()
        {
            Random random = new Random();
        }


        public Estudiante(string apellido, string nombre, string legajo)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.legajo = legajo;
            this.notaPrimerParcial = 0;
            this.notaSegundoParcial = 0;
            
        }

        public string GetApellido()
        {
            return this.apellido;
        }
        public string GetLegajo()
        {
            return this.legajo;
        }
        public string GetNombre()
        {
            return this.nombre;
        }

        public int GetNotaPrimerParcial()
        {
            return this.notaPrimerParcial;
        }

        public int GetNotaSegundoParcial()
        {
            return this.notaSegundoParcial;
        }


        public string Mostrar()
        {
            string texto;

            StringBuilder sb = new StringBuilder();

            sb.Append("Apellido: ");
            sb.AppendLine(GetApellido());
            sb.Append("Nombre: ");
            sb.AppendLine(GetNombre());
            sb.Append("Legajo: ");
            sb.AppendLine(GetLegajo());
            sb.Append("Nota de Primer Parcial: ");
            sb.AppendLine(GetNotaPrimerParcial().ToString());
            sb.Append("Nota de Segundo Parcial: ");
            sb.AppendLine(GetNotaSegundoParcial().ToString());
            sb.Append("Nota Promedio: ");
            sb.AppendLine(CalcularPromedio().ToString());
            sb.Append("Nota Final: ");
            if (CalcularNotaFinal()<=-1)
            {
                sb.AppendLine("Alumno Desaprobado");
            }else
                sb.AppendLine(CalcularNotaFinal().ToString());
            texto = sb.ToString();

            return texto;
        }


        public void SetNotaPrimerParcial (int NotaPrimerParcial)
        {
            this.notaPrimerParcial = NotaPrimerParcial;
        }

        public void SetNotaSegundoParcial (int NotaSegundoParcial)
        {
            this.notaSegundoParcial = NotaSegundoParcial;
        }


        public int CalcularPromedio()
        {
            int primerNota = GetNotaPrimerParcial();
            int segundaNota = GetNotaSegundoParcial();
            int promedio;

            promedio = (primerNota + segundaNota)/2;

            return promedio;
        }

        public int CalcularNotaFinal()
        {
            int primerNota = GetNotaPrimerParcial();
            int segundaNota = GetNotaSegundoParcial();
            int notaFinal;
            if (primerNota >= 4 && segundaNota >= 4)
            {
                Random rnd = new Random();
                notaFinal = rnd.Next(6, 10);
            }
            else
                notaFinal = -1;

            return notaFinal;
        }

	
    }
}
/*El método privado CalcularPromedio retornará el promedio de las dos notas.
El método CalcularNotaFinal deberá retornar la nota del final con un numero aleatorio 
entre 6 y 10 incluidos siempre y cuando las notas del primer y segundo parcial sean mayores 
o iguales a 4, caso contrario la inicializará con el valor -1.*/