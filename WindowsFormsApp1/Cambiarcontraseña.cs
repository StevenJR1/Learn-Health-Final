using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa2;

namespace WindowsFormsApp1
{
    public partial class Cambiarcontraseña : Form
    {
        Conexionsql2 con = new Conexionsql2();
        public Cambiarcontraseña()
        {
            InitializeComponent();
        }

        private void Btncrear_Click(object sender, EventArgs e)
        {
            var camcontra = new iniciosesion();
            camcontra.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var camcontra = new Cerrar();
            camcontra.Show();
        }

        private void bttnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                ElimError();
                if (validating())
                {
                    con.ModificarCuenta(txtUsuario.Text, txtContraseña.Text);

                    MessageBox.Show("La contraseña se actualizó con éxito");
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error, por favor verifique que los datos ingresados sean los correctos.");
            }
        }
        private bool validating()
        {
            bool ok = true;

            if (txtUsuario.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtUsuario, "Ingrese nombre");
            }

            return ok;
        }
        private void ElimError()
        {
            errorProvider1.SetError(txtUsuario, "");
        }
    }
}
