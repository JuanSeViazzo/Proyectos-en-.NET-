using System;
using System.Text;
namespace Veterinaria_De_Campo
{
    public abstract class Animal

    {

        private int kiloAlimentos;
        private string nombre;

        protected Animal(int volumen, string nombre)
        {
            kiloAlimentos = volumen;
            this.nombre = nombre;
        }

        public int KiloAlimentos { get { return kiloAlimentos; } } // {get => kiloAlimentos};

        public abstract bool ComePasto { get;}  
        public abstract bool ComeBalanceado { get;}



        public virtual string Datos()
        {
            StringBuilder sb = new StringBuilder(); 

            sb.AppendLine(string.Format($"Se llama {nombre.ToUpper()} y come {KiloAlimentos}"));
            sb.AppendLine(string.Format($"Come Balanceado? {(ComeBalanceado ? "SI" : "NO")}"));
            sb.AppendLine(string.Format($"Consume Pasto? {(ComePasto ? "SI" : "NO")}"));

            return sb.ToString();
        }



    }
}
