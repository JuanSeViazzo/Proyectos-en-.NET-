using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtrapameSiPuedes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(txtKms.Text) || string.IsNullOrWhiteSpace(txtLitros.Text))
                {
                    throw new ParametrosVaciosException("Los Parametros estan vacios");

                }
            }
            catch (ParametrosVaciosException ex)
            {
               richTextBox1.Text = ex.Message;
            }

        }
    }
}
