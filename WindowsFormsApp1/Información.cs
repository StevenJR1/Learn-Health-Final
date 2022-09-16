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
    public partial class Información : Form
    {
        Conexionsql2 con = new Conexionsql2();
        public Información()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var informacion = new iniciosesion();
            informacion.Show();
            this.Hide();
        }

        private void Btncrear_Click(object sender, EventArgs e)
        {
            var informacion = new menu();
            informacion.Show();
            this.Hide();
        }

        //Modificar la infomación ingresada
        private void bttnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                ElimError();
                if (validating())
                {
                    con.Modificar(txtBxCodigo.Text, txtPNombre.Text, txtSNombre.Text, txtPApellido.Text, txtSApellido.Text, txtNDoc.Text, txtBxTipodoc.Text, txtfechaNac.Text, txtBxSexo.Text, txtBxSalario.Text, txtNumTelefono.Text, txtDireccion.Text, txtUsuario.Text, txtContraseña.Text);

                    MessageBox.Show("La información se actualizó con éxito");
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

            if (txtBxCodigo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtBxCodigo, "Ingrese su código");
            }

            return ok;
        }
        private void ElimError()
        {
            errorProvider1.SetError(txtNDoc, "");
        }

        //Mostrar la información almacenada en la base de datos 
        private void bttnMInformacion_Click(object sender, EventArgs e)
        {
            try
            {
                ElimError1();
                if (validating1())
                {
                    var resultado = con.informacion(txtNDoc.Text);

                    txtBxCodigo.Text = resultado.Item1;
                    txtPNombre.Text = resultado.Item2;
                    txtSNombre.Text = resultado.Item3;
                    txtPApellido.Text = resultado.Item4;
                    txtSApellido.Text = resultado.Item5;
                    txtBxTipodoc.Text = resultado.Item6;
                    txtfechaNac.Text = resultado.Item7;

                    var resultado2 = con.informacion1(txtNDoc.Text);

                    txtBxSexo.Text = resultado2.Item1;
                    txtBxSalario.Text = resultado2.Item2;
                    txtNumTelefono.Text = resultado2.Item3;
                    txtDireccion.Text = resultado2.Item4;
                    txtUsuario.Text = resultado2.Item5;
                    txtContraseña.Text = resultado2.Item6;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, por favor verifique que los datos ingresados sean los correctos.");
            }
        }
        private bool validating1()
        {
            bool ok = true;

            if (txtNDoc.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNDoc, "Ingrese su número de documento");
            }

            return ok;
        }
        private void ElimError1()
        {
            errorProvider1.SetError(txtNDoc, "");
        }

        //Elimanar la información almacenada en la base de datos
        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ElimError2();
                if (validating2())
                {
                    con.Eliminar(txtNDoc.Text);

                    txtBxCodigo.Text = "";
                    txtPNombre.Text = "";
                    txtSNombre.Text = "";
                    txtPApellido.Text = "";
                    txtSApellido.Text = "";
                    txtNDoc.Text = "";
                    txtBxTipodoc.Text = "";
                    txtfechaNac.Text = "";
                    txtBxSexo.Text = "";
                    txtBxSalario.Text = "";
                    txtNumTelefono.Text = "";
                    txtDireccion.Text = "";
                    txtUsuario.Text = "";
                    txtContraseña.Text = "";

                    MessageBox.Show("La información se eliminó con éxito");
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error, por favor verifique que los datos ingresados sean los correctos.");
            }
        }
        private bool validating2()
        {
            bool ok = true;

            if (txtNDoc.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNDoc, "Ingrese su número de documento");
            }

            return ok;
        }

        private void ElimError2()
        {
            errorProvider1.SetError(txtNDoc, "");
        }
    }
}
