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
    public partial class Pensum : Form
    {
        Conexionsql2 con = new Conexionsql2();
        public Pensum()
        {
            InitializeComponent();
            dtGrPensum.DataSource = con.Pensum();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form1 = new Form2();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var pensum = new iniciosesion();
            pensum.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form1 = new Form3();
            form1.Show();
        }

        private void bttn1volvermenu_Click(object sender, EventArgs e)
        {
            var iniciosesion = new menu();
            iniciosesion.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form1 = new Ais();
            form1.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form1 = new Es();
            form1.Show();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form1 = new Me();
            form1.Show();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form1 = new Ca();
            form1.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form1 = new Or();
            form1.Show();
        }
    }
}
