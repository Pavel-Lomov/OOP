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

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)

                try
                {
                    if (textBox1.Text.Trim() == "")
                    {
                        textBox1.Focus();
                        throw new Exception("Вы не ввели ФИО человека");
                    }
                    if (textBox2.Text.Trim() == "")
                    {
                        textBox2.Focus();
                        throw new Exception("Вы не ввели серию паспорта");
                    }
                    int n = Convert.ToInt32(textBox3.Text);
                    if (n < 1 || n > 999999)
                    {
                        textBox3.Focus();
                        throw new Exception("Номер паспорта должен быть в диапазоне 1..999999");
                    }
                }
                catch (FormatException)
                {
                    e.Cancel = true;
                    textBox3.Focus();
                    MessageBox.Show("Номер паспорта должен быть целым числом", "Ошибка");
                }
                catch (Exception E)
                {
                    e.Cancel = true;
                    MessageBox.Show(E.Message, "Ошибка");
                }
            
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
