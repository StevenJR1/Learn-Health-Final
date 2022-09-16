using System;
using System.Windows.Forms;
using Capa2;

namespace WindowsFormsApp1
{
    public partial class iniciosesion : Form
    {
        Conexionsql2 con = new Conexionsql2();
        public iniciosesion()
        {
            InitializeComponent();
        }

        private void iniciosesion_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var iniciosesion = new btncrearUsuario();
            iniciosesion.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (con.conSQL(textBox1.Text, txtcontraseña.Text) == 1)
            {
                var iniciosesion = new menu();
                iniciosesion.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Usuario o contraseña invalidos");
            }


            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtcontraseña.PasswordChar == (char)0)
                txtcontraseña.PasswordChar = '*';
            else            
                txtcontraseña.PasswordChar = (char)0;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var iniciosesion = new Cambiarcontraseña();
            iniciosesion.Show();
            this.Hide();
        }
    }
}
