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
            label17.Text = null;
            label22.Text = null;
            label9.Text = null;
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
            listBox1.Items.Clear();
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
            if (comboBox1.Text == "") 
            { 
                comboBox1.Text = "km";
                label9.Text = "km";
            }
            if (comboBox2.Text == "") { comboBox2.Text = "kW"; }
            if (comboBox3.Text != "$")
            {
                label17.Text = "€";
                label22.Text = "€";
                comboBox3.Text = "€";
            }
            else
            {
                label22.Text = "$";
                label17.Text = "$";
            }
            Enote.enotaCene = comboBox3.Text;
            Enote.enotaDolzine = comboBox1.Text;
            Enote.enotaMoci = comboBox2.Text;

            label18.Text = Enote.enotaCene;
            label19.Text = Enote.enotaDolzine;
            label20.Text = Enote.enotaMoci;
            label9.Text = Enote.enotaDolzine;
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

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                Avto avto1 = new Avto(textBox1.Text, Convert.ToInt16(textBox2.Text), Convert.ToInt16(textBox9.Text));

                listBox1.Items.Add($"═══════════════════════════════════");
                listBox1.Items.Add($"  SPECIFIKACIJE AVTOMOBILA         ");
                listBox1.Items.Add($"═══════════════════════════════════");
                listBox1.Items.Add($"Znamka: {avto1.znamka}");
                listBox1.Items.Add($"Letnik: {2026 - avto1.starost}");
                listBox1.Items.Add($"Starost avtomobila je {avto1.starost} let");
                listBox1.Items.Add($"Cena avtomobila je: {avto1.cena} {Enote.enotaCene}");

            }
            catch(Exception)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add($"═══════════════════════════════════");
                listBox1.Items.Add("            Izpolni vse podatke!");
                listBox1.Items.Add($"═══════════════════════════════════");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }
    }
}
