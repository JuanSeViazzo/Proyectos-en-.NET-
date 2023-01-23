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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int id;

            int.TryParse(txtId.Text, out id);

            try
            {
                if (Universidad.Loguear(id, txtPass.Text))
                {

                    frmPantallaPrincipal pantallaPrincipal = new frmPantallaPrincipal();



                    pantallaPrincipal.Show();
                    this.Hide();

                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }






        }
    }
}
