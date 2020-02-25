using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Loops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Asagidaki dizide yer alan her bir elemani, listbox icerisine ekleyiniz...
            string[] takimlar = { "Galatasaray", "Fenerbahce", "Besiktas", "Trabzonspor", "Bursaspor", "Ankaragücü" };
            listBox1.Items.AddRange(takimlar);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Sayisal bir dizi tanimlayin ve Array sınıfını kullanmadan o dizinin en buyuk elemanini gosterin...
            int[] sayisal = { 12, 45, 23, 76, 119, 85, 46, 223, 4, 6 };
            int buyuk = 0;
            for (int i = 0; i < sayisal.Length; i++)
            {
                if (buyuk < sayisal[i])
                {
                    buyuk = sayisal[i];
                }
            }
            MessageBox.Show("en büyük sayı" + buyuk);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Asagidaki dizide kac tane cift kac tane tek sayi vardir kullaniciyi bilgilendiriniz..

            int[] sayisal = { 12, 45, 23, 76, 119, 85, 46, 223, 4, 6, 25 };
            int cift = 0;
            int tek = 0;
            for (int i = 0; i < sayisal.Length; i++)
            {
                if (sayisal[i] % 2 == 0)
                {
                    cift++;
                }
                else
                {
                    tek++;
                }
            }
            MessageBox.Show(string.Format("Çift Sayılar ={0}\n Tek Sayılar ={1}", cift, tek));


        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        Random rnd = new Random();
        private void button5_Click(object sender, EventArgs e)
        {
            int sayi = 0;
            listBox1.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                sayi = rnd.Next(100, 1000);
                listBox1.Items.Add(sayi);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.Control ButonDegis in this.Controls)
            {
                if (ButonDegis is System.Windows.Forms.Button)
                {

                    ButonDegis.BackColor = Color.Red;


                    ButonDegis.ForeColor = Color.Yellow;

                }
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Disaridan girilen sayisal ifadenin rakam degerleri toplamini gosteriniz...
            //Ornegin 123 girilirse 1+2+3 = 6 sonucu donmelidir...

            int sonuc = 0;
            try
            {
                int sayi = Int32.Parse(textBox1.Text);
                while (sayi > 0)
                {
                    sonuc += (sayi % 10);
                    sayi = sayi / 10;
                }
                MessageBox.Show(sonuc.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("lütfen bir sayı yazınız");

            }


        }
    }
}

