using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odevkaraktersayısı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text.Length > 500)
            {
                MessageBox.Show("500 Karakter Yazma sınırını aştınız...");
            }
            else
            {
                label1.Text = Convert.ToString(500 - textBox1.Text.Length);

            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
