using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            notifyIcon1.Icon = SystemIcons.Asterisk;

            this.ShowInTaskbar = false;
            notifyIcon1.Click += notifyIcon1_Click;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        //Кнопка "Перейти"
        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();

            DirectoryInfo di = new DirectoryInfo(textBox1.Text);
            DirectoryInfo[] d1 = di.GetDirectories();

            foreach (DirectoryInfo dd in d1)
            {

                listBox1.Items.Add(dd);

            }

            FileInfo[] files = di.GetFiles();

            foreach (FileInfo dd in files)
            {

                listBox1.Items.Add(dd);

            }
        }

        //Двойной щелчок в listbox'e
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = Path.Combine(textBox1.Text,listBox1.SelectedItem.ToString());

            listBox1.Items.Clear();

            DirectoryInfo di = new DirectoryInfo(textBox1.Text);
            DirectoryInfo[] d1 = di.GetDirectories();

            foreach (DirectoryInfo dd in d1)
            {

                listBox1.Items.Add(dd);

            }

            FileInfo[] files = di.GetFiles();

            foreach (FileInfo dd in files)
            {

                listBox1.Items.Add(dd);

            }
        }

        //Кнопка "Назад"
        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text[textBox1.Text.Length - 1] == '\\')
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);

                while (textBox1.Text[textBox1.Text.Length - 1] != '\\')
                {

                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);

                }
            }
            else if (textBox1.Text[textBox1.Text.Length - 1] != '\\')
            {
                while (textBox1.Text[textBox1.Text.Length - 1] != '\\')
                {

                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);

                }
            }

            listBox1.Items.Clear();

            DirectoryInfo di = new DirectoryInfo(textBox1.Text);
            DirectoryInfo[] d1 = di.GetDirectories();

            foreach (DirectoryInfo dd in d1)
            {

                listBox1.Items.Add(dd);

            }

            FileInfo[] files = di.GetFiles();

            foreach (FileInfo dd in files)
            {

                listBox1.Items.Add(dd);

            }
        }

        //трей
        private void notifyIcon1_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Normal;
            this.Show();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            e.Cancel = true;
            this.Hide();

        }
    }
}
