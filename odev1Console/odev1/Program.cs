using System;

namespace odev1
{
    class Program
    {
        static void Main(string[] args)
        {

            //1) Disaridan alinan iki sayının toplamiyla farkinin birbirine bolumunden kalanin sonucu kactir? (Farkın toplama bolumunden kalan kactir?)

            Console.WriteLine("lütfen birinci sayısı giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("lütfen ikinci sayısı giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int toplam = sayi1 + sayi2;
            int fark = sayi1 - sayi2;
            int sonuc = fark % toplam;
            Console.WriteLine("islem sonucu : " + sonuc);
            Console.WriteLine("islem sonucu : {0}", sonuc); (2.yol)


             //2) Disaridan girilen bir sayının 10 eksiginin 20 fazlasinin 2ye bolumunden kalaninin karesi kactir?


            Console.WriteLine("lütfen bir sayı giriniz.");
            int sayi3 = Convert.ToInt32(Console.ReadLine());
            int farkı = sayi3 - 10;
            int toplamı = farkı + 20;
            int bölüm = toplamı % 2;
            int kare = bölüm * bölüm;
            Console.WriteLine("sonuc:{0} ", kare);
            int sonuc = ((sayi - 10) + 20) % 2; (2.yol)
              Console.WriteLine("İşlem Sonucu : {0}", (sonuc * sonuc));






            //3) Vize notu'nun % 30'u, final notu'nun % 70'ini alıp öğrencinin not ortalamasini cikartan bir uygulama yaziniz... DİKKAT => Notlar ondalikli olabilir?

            Console.WriteLine("vize notu giriniz");
            double vize = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("final notunu giriniz");
            double final = Convert.ToDouble(Console.ReadLine());
            double sonuc = (vize * 0.30) + (final * 0.70);
            string result = string.Format("Not Ortalamanız : {0}", sonuc);
            Console.WriteLine(sonuc);



            //4) Dışarıdan kullanıcı adını ve soyadını ayrı ayrı olarak alnız ve  adi.soyadi@hotmail.com şeklinde mail adresi oluşturup kullanıcıya gösteriniz

            Console.WriteLine("lütfen adınız giriniz");
            string ad = Console.ReadLine().ToLower();
            Console.WriteLine("lütfen soyadınızı giriniz");
            string soyad = Console.ReadLine().ToLower();
            string mail = string.Format("{0}.{1}@hotmail.com", ad, soyad);
            Console.WriteLine(mail);
            // Console.WriteLine("{0}.{1}@gmail.com", ad , soyad);(2.yol)





            //5) Disaridan girilen iki sayının karelerinin toplami ile karelerinin farki toplami kactir? 
            Console.WriteLine("lütfen sayı giriniz");
            int sayi1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("lütfen sayı giriniz");
            int sayi2 = Int32.Parse(Console.ReadLine());
            int k1 = sayi1 * sayi1;
            int k2 = sayi2 * sayi2;
            int fark = k1 - k2;
            int toplam = k2 + k1;
            Console.WriteLine("sonuc: {0}", (toplam + fark));































        }
    }
}
