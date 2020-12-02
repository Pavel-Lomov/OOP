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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = true;
            label2.Visible = true;
            label1.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = false;
            label1.Visible = true;
            label2.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                double n = Convert.ToDouble(textBox4.Text);
                double m = Convert.ToInt32(textBox2.Text);
                double v= Convert.ToInt32(textBox5.Text);
                Dvakrana d = new Dvakrana(v,n, m);
                listBox1.Items.Add(d);
            }
            else if (radioButton2.Checked)
            {
                double n = Convert.ToDouble(textBox4.Text);
                double m = Convert.ToInt32(textBox1.Text);
                double v = Convert.ToDouble(textBox5.Text);
                Kran_cliv k = new Kran_cliv(v,n,m);
                listBox1.Items.Add(k);
            }
            else if (radioButton3.Checked)
            {
                double n = Convert.ToDouble(textBox4.Text);
                double v = Convert.ToDouble(textBox5.Text);
                Kran k = new Kran(v,n);
                listBox1.Items.Add(k);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (listBox1.SelectedIndex !=-1)
            {
                Volume v = listBox1.Items[listBox1.SelectedIndex] as Volume;
                double t = v.Calc();
                textBox3.Text = t.ToString();
            }
        }
    }
}
