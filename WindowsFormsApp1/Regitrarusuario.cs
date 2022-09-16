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
    public partial class btncrearUsuario : Form
    {
        Conexionsql2 con = new Conexionsql2();
        public btncrearUsuario()
        {
            InitializeComponent();
        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ElimError();
           if (validating())           
           {
                con.CrearUsuario(txtPnombre.Text, txtBxSnombre.Text, txtPApellido.Text, txtBxSApellido.Text, txtNDoc.Text, cbxtipoDoc.Text, dtTmPckrFecha.Text, cmbBxSexo.Text, cmbBxSalario.Text, txtNumTelefono.Text, txtDireccion.Text, txtUsuario.Text, txtContraseña.Text);

                MessageBox.Show("El usuario se ha creado con éxito");

                txtPnombre.Text = "";
                txtBxSnombre.Text = "";
                txtPApellido.Text = "";
                txtBxSApellido.Text = "";
                txtNDoc.Text = "";
                cbxtipoDoc.Text = "";
                dtTmPckrFecha.Text = "";
                cmbBxSexo.Text = "";
                cmbBxSalario.Text = "";
                txtNumTelefono.Text = "";
                txtDireccion.Text = "";
                txtUsuario.Text = "";
                txtContraseña.Text = "";
           }
        }

        private bool validating()
        {
            bool ok = true;

            if (txtNDoc.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNDoc, "Ingrese nombre");
            }

            if (cbxtipoDoc.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cbxtipoDoc, "Ingrese nombre");
            }

            if (txtPnombre.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtPnombre, "Ingrese nombre");
            }

            if (txtPApellido.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtPApellido, "Ingrese Primer apellido");
            }

            if (txtBxSApellido.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtBxSApellido, "Ingrese Segundo apellido");
            }

            if (cmbBxSexo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cmbBxSexo, "Ingrese su sexo");
            }

            if (cmbBxSalario.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cmbBxSalario, "Ingrese su salario");
            }

            if (txtNumTelefono.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNumTelefono, "Ingrese su Numero de teléfono");
            }

            if (txtDireccion.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtDireccion, "Ingrese su dirección");
            }

            if (txtUsuario.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtUsuario, "Ingrese el usuario");
            }

            if (txtContraseña.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtContraseña, "Ingrese la contraseña");
            }            

            return ok;
        }

        private void ElimError()
        {
            errorProvider1.SetError(txtNDoc, "");
            errorProvider1.SetError(cbxtipoDoc, "");
            errorProvider1.SetError(txtPnombre, "");
            errorProvider1.SetError(txtBxSnombre, "");
            errorProvider1.SetError(txtPApellido, "");
            errorProvider1.SetError(txtBxSApellido, "");
            errorProvider1.SetError(cmbBxSexo, "");
            errorProvider1.SetError(cmbBxSalario, "");
            errorProvider1.SetError(txtNumTelefono, "");
            errorProvider1.SetError(txtDireccion, "");
            errorProvider1.SetError(txtUsuario, "");
            errorProvider1.SetError(txtContraseña, "");
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            var Regitrausuario = new iniciosesion();
            Regitrausuario.Show();
            this.Hide();
        }
    }
}
