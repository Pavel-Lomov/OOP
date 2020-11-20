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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                int k = 0;
                try
                {

                    if (Convert.ToInt32(numericUpDown1.Value) == 0)
                    {
                        throw new Exception("Введите X отличный от 0");
                    }
                    k++;
                    if (Convert.ToInt32(numericUpDown2.Value) == 0)
                    {
                        throw new Exception("Введите Y отличный от 0");
                    }
                    k++;
                    if (Convert.ToInt32(numericUpDown3.Value) == 0)
                    {
                        throw new Exception("Введите масштаб отличный от 0");
                    }
                    k++;
                    if (Convert.ToInt32(numericUpDown4.Value) == 0)
                    {
                        throw new Exception("Введите скорость отличную от 0");
                    }
                    k++;

                }
                catch (Exception E)
                {
                    if (k == 0) numericUpDown1.Focus();
                    if (k == 1) numericUpDown2.Focus();
                    if (k == 2) numericUpDown3.Focus();
                    if (k == 3) numericUpDown4.Focus();
                    MessageBox.Show(E.Message);
                    e.Cancel = true;
                }
            }
        }
    }
}
