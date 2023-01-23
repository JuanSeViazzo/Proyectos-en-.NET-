using System;


namespace LogicaDeNegocio
{
    public class Boligrafo
    {

        private const short cantidadTintaMaxima = 100;

        private ConsoleColor color;
        private short tinta;

        
        public Boligrafo (short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color; 
        }


        public ConsoleColor GetColor ()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        public void Recargar()
        {
            SetTinta((short)(Boligrafo.cantidadTintaMaxima-this.GetTinta()));
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            short tinta;
            dibujo = "";
            tinta = GetTinta();
            int tintaResultado;
            short tintaRestante;

            if (tinta > 0)
            {
                if (gasto < tinta)
                {
                    tintaResultado = tinta - gasto;
                    dibujo = dibujo.PadRight(tintaResultado,'*');
                    tintaRestante = Convert.ToInt16(gasto * -1);


                }
                else
                {
                    tintaResultado = tinta;
                    dibujo=dibujo.PadRight(tintaResultado,'*');
                    tintaRestante = Convert.ToInt16(tinta * -1);
                }



                SetTinta(tintaRestante);



                return true;

            }

            return false;

        }
        private void SetTinta(short tinta)
        {
            short tintaActual;

            tintaActual = GetTinta();

            tintaActual += tinta;

            //resultado = (tinta > 0) ? tintaActual + tinta : tintaActual - tinta;
  

            if (tintaActual >= 0 && tintaActual <= Boligrafo.cantidadTintaMaxima)
            {
                //tinta = Convert.ToInt16(tintaActual);

                this.tinta = tintaActual;
            }


        }




        }
    }
