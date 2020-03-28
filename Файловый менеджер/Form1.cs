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

namespace Файловый_менеджер
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();

            DirectoryInfo dir = new DirectoryInfo(textBox1.Text);
            DirectoryInfo[] dirs = dir.GetDirectories();

            foreach (DirectoryInfo cd in dirs)
            {
                listBox1.Items.Add(cd);
            }

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo cf in files)
            {
                listBox1.Items.Add(cf);
            }
            
        }
    }
}
