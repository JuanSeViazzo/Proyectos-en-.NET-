using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veterinaria_De_Campo;


namespace VistaVeteCampo
{
    public partial class Campo : Form
    {
        Veterinaria_De_Campo.Campo campo;

        public Campo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.campo = new Veterinaria_De_Campo.Campo(1500);
            Veterinaria_De_Campo.Campo.TipoServicio = Veterinaria_De_Campo.Campo.Tipo.Pastoreo;
            bool pudo = this.campo + new Cerdo("Pegy", 300);
            pudo = this.campo + new Cerdo("Babe", 250);
            pudo = this.campo + new Vaca("Rosalinda", 450, Vaca.Clasificacion.Lechera);
            pudo = this.campo + new Vaca("Lola", 325);
            pudo = this.campo + new Caballo("Secretariat", 175, true);
            if (!(this.campo + new Caballo("BoJack", 1, false)))

            {
                MessageBox.Show("OK","OK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            rtbSalidaDeTest.Text = campo.ToString();

        }
    }
}
