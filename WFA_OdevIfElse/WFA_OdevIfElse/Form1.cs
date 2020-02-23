using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_OdevIfElse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            //Girilen not 0 - 30 araligi ise "FF" 30 - 50 araligi "DD" 50 - 70 "BB" 70 - 100 "AA" aldınız seklinde kullaniciyi uyariniz..
            int not = Int32.Parse(txtDeger1.Text);
            if (not <= 30)
            {
                MessageBox.Show("Notunuz: FF");
                //elseif ort>= 81 & ort < 89
            }
            else if (not >= 30 & not <= 50)
            {
                MessageBox.Show("Notunuz: DD");
            }
            else if (not >= 50 & not <= 70)
            {
                MessageBox.Show("Notunuz : BB");
            }
            else if (not >= 70 & not <= 100)
            {
                MessageBox.Show("Notunuz : AA");
            }
            else
            {
                MessageBox.Show("lÜTFEN 0-100 Aralığında Not Giriniz");
            }

        }

        private void btnOrnek4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtDeger2.Text.Length > 0 ? txtDeger2.Text : "Lütfen bir ürün giriniz!");
            

            string urunadı = txtDeger2.Text;
            if (urunadı == "Domates" || urunadı == "Biber" || urunadı == "Patlican")
            {
                MessageBox.Show("Sebze Reyonu");
            }
            else if (urunadı == "Diş Macunu" || urunadı == "Parmün" || urunadı == "Şampuan")
            {
                MessageBox.Show("Kozmetik Reyonu");
            }
            else if (urunadı == "Cep Telefonu" || urunadı == "Bilgisayar" || urunadı == "Ses Sistemi")
            {
                MessageBox.Show("Teknoloji");
            }
            else
            {
                MessageBox.Show("BU URUN BULUNMAMAKTADIR!");
            }
               

        }

        private void btnOrnek5_Click(object sender, EventArgs e)
        {


            double siparis = double.Parse(txtDeger3.Text);
            double indirimsiz;
            double indirim;
            double tutar;

            if (siparis <= 20)
            {

                indirimsiz = (siparis * 5);
                indirim = indirimsiz * 5 / 100;
                tutar = (indirimsiz - indirim);
                MessageBox.Show("toplam tutar:" + tutar);
            }
            else if (siparis >= 20 & siparis <= 50)
            {
                indirimsiz = (siparis * 5);
                indirim = indirimsiz * 10 / 100;
                tutar = (indirimsiz - indirim);
                MessageBox.Show("toplam tutar:" + tutar);

            }
            else if (siparis >= 50 & siparis <= 100)
            {
                indirimsiz = siparis * 5;
                indirim = indirimsiz * 15 / 100;
                tutar = indirimsiz - indirim;
                MessageBox.Show("toplam tutar:" + tutar);
            }
            else if (siparis >= 100)
            {
                indirimsiz = siparis * 5;
                indirim = indirimsiz * 25 / 100;
                tutar = indirimsiz - indirim;
                MessageBox.Show("toplam tutar:" + tutar);
            }






        }
    }
}
