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
            Form2 Dialog = new Form2();
            Dialog.Text = "Добавление человека";
            Dialog.textBox1.Text = "";
            Dialog.textBox2.Text = "";
            Dialog.textBox3.Text = "";
            if (Dialog.ShowDialog()==DialogResult.OK)
            {
                TPeople People = new TPeople();
                People.FIO = Dialog.textBox1.Text.Trim();
                People.Series = Dialog.textBox2.Text.Trim();
                People.Number = Convert.ToInt32(Dialog.textBox3.Text);
                listBox1.Items.Add(People);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex!=-1)
            {
                Form2 Dialog = new Form2();
                Dialog.Text = "Изменение данных человека";
                TPeople People = listBox1.SelectedItem as TPeople;
                Dialog.textBox1.Text = People.FIO;
                Dialog.textBox2.Text = People.Series;
                Dialog.textBox3.Text = People.Number.ToString();
                if (Dialog.ShowDialog()==DialogResult.OK)
                {
                    People.FIO = Dialog.textBox1.Text.Trim();
                    People.Series = Dialog.textBox2.Text.Trim();
                    People.Number = Convert.ToInt32(Dialog.textBox3.Text);
                    listBox1.Items[listBox1.SelectedIndex] = People;
                }
            }
            else
            {
                MessageBox.Show("Не выбран элемент в списке", "Информация");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex!=-1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Не выбран элемент в списке", "Информация");
            }
        }
    }
}
