using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 
            ////type safety= tip güvenliği
            ////Do not repeat yourself = Kendini tekrarlama
            //string kategoriEtiketi = "Kategori";  //kategoriEtiketi=değer tutucudur,alias.
            //int ogrenciSayisi = 32000;
            //bool sistemeGirisYapmisMi = true;

            //if (sistemeGirisYapmisMi==true)
            //{
            //    Console.WriteLine("Ayarlar Butonu");
            //}
            //else
            //{
            //    Console.WriteLine("Giriş yap butonu");
            //}
            //Console.WriteLine(kategoriEtiketi);

            #endregion
            #region Döngüler


            //string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            //string kurs2 = "Programlamaya giriş";
            //string kurs3 = "Java";
            ////array-dizi
            //string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya giriş", "Java" };
            //for (int i=0; i<kurslar.Length;i++ )
            //{
            //    Console.WriteLine(kurslar[i]);
            //}
            //Console.WriteLine("----------------For bitti----------------------");
            //foreach (var kurs in kurslar)
            //{
            //    Console.WriteLine(kurs);
            //}  
            #endregion
            #region Classlar

            //string adi = "Engin";
            //int yas = 36;

            //Kurs kurs1 = new Kurs();
            //kurs1.KursAdi = "C#";
            //kurs1.Egitmen = "Engin Demiroğ";
            //kurs1.İzlenmeOrani = 68;

            //Kurs kurs2 = new Kurs();
            //kurs2.KursAdi = "Java";
            //kurs2.Egitmen = "Kerem";
            //kurs2.İzlenmeOrani = 64;
            ////Console.WriteLine(kurs1.KursAdi + ":" + kurs1.Egitmen);

            //Kurs[] kurslar = new Kurs[] { kurs1, kurs2 };

            //foreach (var kurs in kurslar)
            //{
            //    Console.WriteLine(kurs.KursAdi+" "+kurs.Egitmen);
            //}

            #endregion

            #region Metotlar
            // do not repeat yourself- DRY- Clean Code - Best Practice
            
            Product product1 = new Product();//ürün tipinde ürün oluşturduk.
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya Elması";

            Product product2 = new Product();//ürün tipinde ürün oluşturduk.
            product2.Adi = "Elma";
            product2.Fiyati = 15;
            product2.Aciklama = "Amasya Elması";

            Product[] products = new Product[] { product1,product2 };
            //type-safe(tip güvenliği)
            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("-----------------------------------------------");
                //instance-ornek
                //encapsulation
                SepetManager sepetManager = new SepetManager();
                sepetManager.Ekle(product1);
                sepetManager.Ekle(product2);
                Console.WriteLine("------------------------------------------------");
                sepetManager.Ekle2("Kivi", "Ekşili kivi", 12,10);
                sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 80,9);
                sepetManager.Ekle2("Elma", "Ekşili elma", 10,8);
            }

            #endregion

        }
        //class Kurs
        //{
        //    public string KursAdi { get; set; }
        //    public string Egitmen { get; set; }
        //    public int İzlenmeOrani { get; set; }
        //}
    }
}
