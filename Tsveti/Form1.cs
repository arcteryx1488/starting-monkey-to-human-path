using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tsveti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        private void button1_Click(object sender, EventArgs e)
        { if (textBox1.Text == "admin")
                {
                    if (textBox2.Text == "admin")
                    {
                        Form1 f1 = new Form1();
                        f1.ShowDialog();
                    }
                }
                else
                    MessageBox.Show("Не правильный логин или пароль");
        }
    }
}
