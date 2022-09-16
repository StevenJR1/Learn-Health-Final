using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void btnoferta_Click(object sender, EventArgs e)
        {
            var menu = new Pensum();
            menu.Show();
            this.Hide();
        }

        private void lnklblcerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var menu = new iniciosesion();
            menu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var menu = new Información();
            menu.Show();
            this.Hide();
        }
    }
}
