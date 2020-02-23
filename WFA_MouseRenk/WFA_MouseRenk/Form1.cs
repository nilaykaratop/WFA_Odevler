using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_MouseRenk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Purple;
            textBox1.ForeColor = Color.Yellow;
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            textBox1.BackColor = default;
            textBox1.ForeColor = default;

        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.Pink;
            textBox2.ForeColor = Color.Blue;
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            textBox2.BackColor = default;
            textBox2.ForeColor = default;
        }
    }
}
