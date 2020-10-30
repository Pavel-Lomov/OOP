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

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox3.Text);
            double b = Convert.ToDouble(textBox4.Text);
            string name_tovar = textBox2.Text;
            string name_ctrana = textBox1.Text;
            Tovar d = new Tovar(name_tovar,name_ctrana, a, b);
            listBox1.Items.Add(d);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
