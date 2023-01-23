using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaUniversidad;

namespace CieguitoVolador
{
    public partial class frmPantallaPrincipal : Form
    {
        public frmPantallaPrincipal()
        {
            InitializeComponent();
        }

        private void frmPantallaPrincipal_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Alumno item in Universidad.Alumnos)
            {

                try
                {
                    sb.AppendLine(item.ToString());

                }
                catch (Exception ex)
                {

                }



            }

            rtbAlumnos.Text = sb.ToString();
        }
    }
}
