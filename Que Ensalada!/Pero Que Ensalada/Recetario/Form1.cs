using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pero_Que_Ensalada;

namespace Recetario
{
    public partial class Receta : Form
    {
        Pero_Que_Ensalada.Receta receta;
        public Receta()
        {
            InitializeComponent();
            this.receta = new Pero_Que_Ensalada.Receta(45);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bool pudo = this.receta + new Rucula("Eruca sativa", 10);
            pudo = this.receta + new Rucula("Diplotaxis muralis", 15);
            pudo = this.receta + new QuesoAzul("Roquefort", 3,
            QuesoAzul.Procedencia.Francia);
            pudo = this.receta + new QuesoAzul("Clásico", 5);
            pudo = this.receta + new Pera("Dulce", 12, "Williams");
            if (this.receta + new Pera("Seca", 1, "Blanquilla"))
            {
                MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnReceta_Click(object sender, EventArgs e)
        {

           rtbReceta.Text = receta.ToString();  


        }
    }
}
