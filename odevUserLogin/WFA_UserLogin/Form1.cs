using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace WFA_UserLogin
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        int hak = 5;
        Random rnd = new Random();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            hak--;

            if (txtGirisAlani.Text == lblRastgeleSayi.Text)
            {
                MessageBox.Show("Başarıyla Giriş Sağlandı:)");
                Close();

            }
            else if (hak == 4)
            {
                int sayi = rnd.Next(10000000, 99999999);
                lblRastgeleSayi.Text = sayi.ToString();
                txtGirisAlani.Clear();
                txtGirisAlani.Focus();
                star5.Hide();

            }
            else if (hak == 3)
            {
                int sayi = rnd.Next(10000000, 99999999);
                lblRastgeleSayi.Text = sayi.ToString();
                txtGirisAlani.Clear();
                txtGirisAlani.Focus();
                star4.Hide();

            }
            else if (hak == 2)
            {
                int sayi = rnd.Next(10000000, 99999999);
                lblRastgeleSayi.Text = sayi.ToString();
                txtGirisAlani.Clear();
                txtGirisAlani.Focus();
                star3.Hide();
            }
            else if (hak == 1)
            {
                int sayi = rnd.Next(100000000, 999999999);
                lblRastgeleSayi.Text = sayi.ToString();
                txtGirisAlani.Clear();
                txtGirisAlani.Focus();
                star2.Hide();
            }
            else if (hak == 0)
            {
                this.lblRastgeleSayi.Text = " * * * * * * * * ";

                txtGirisAlani.Clear();


                star1.Show();
                star2.Show();
                star3.Show();
                star4.Show();
                star5.Show();
                txtGirisAlani.Enabled = false;
                btnLogin.Enabled = false;
                lblRastgeleSayi.Enabled = false;


                MessageBox.Show("Giriş Sağlanamadı:(");
            }

        }

        private void lblRastgeleSayi_Click(object sender, EventArgs e)
        {
            //int sayi = rnd.Next(10000000, 99999999);
            //lblRastgeleSayi.Text = sayi.ToString();

        }


        private void txtGirisAlani_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int sayi = rnd.Next(10000000, 99999999);
            lblRastgeleSayi.Text = sayi.ToString();
        }

        private void star1_Click(object sender, EventArgs e)
        {

        }

        private void lblRastgeleSayi_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRastgeleSayi_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {

        }
    }
}

