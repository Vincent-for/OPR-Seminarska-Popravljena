using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPR_Seminarska_Popravljena
{
    public partial class Form1 : Form
    {
        Enote Enote = new Enote();
        public Form1()
        {
            InitializeComponent();
            label9.Text = null;
            label13.Text = null;
            label17.Text = null;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void label13_Click(object sender, EventArgs e)
        {
        }

        private void label17_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "") { comboBox1.Text = "m"; }
            if (comboBox2.Text == "") { comboBox2.Text = "kW"; }
            if (comboBox3.Text != "$")
            {
                label9.Text = "€";
                label13.Text = "€";
                label17.Text = "€";
                comboBox3.Text = "€";
            }
            else
            {
                label9.Text = "$";
                label13.Text = "$";
                label17.Text = "$";
            }
            Enote.enotaCene = comboBox3.Text;
            Enote.enotaDolzine = comboBox1.Text;
            Enote.enotaMoci = comboBox2.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
