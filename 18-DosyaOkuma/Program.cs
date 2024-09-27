using System.IO;

namespace _18_DosyaOkuma
{
    struct Sehir
    {
        public int plakaKodu;
        public string il;
        public DateTime CreateDate;
        public bool isActive;
    }

    public struct Ilce
    {
        public int IlceKodu;
        public int IlKodu;
        public string IlceAdi;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Dosya Okuma İşlemleri

            #region Konu Anlatımı
            /*
             * Dosya Nedir?
             * İçerisinde çeşitli bilgileri saklayan yapılara dosya denir.
             * Bilgi Türleri ==> Metinsel veriler, ses dosyaları, fotoğraf ve resim dosyaları 
             * Database dosyaları, html dosyaları, office dosyaları v.b
             * 
             * Bunlar arasında bizim en çok üzerinde duracağımız .csv dosyaları olacaktır.
             * Csv(Comma Seperated values) veriler arasında bir ayraç ile 
             * (Genelde ',' ya da ';' olur) ayrılmış dosyalara csv dosyaları denir.
             * 
             * C# da dosya okumanın birçok yolu vardır. En hızlı ve kolay olanı File sınıfıdır.
             * 
             */

            #endregion
            var sehirler = SehirleriOKu();
            var sonuc = sehirler.OrderBy(p => p.plakaKodu).ToList();
            //foreach (var sehir in sonuc)
            //{
            //    Console.WriteLine($"{sehir.plakaKodu} -> {sehir.il}");
            //}

            sonuc.ForEach(p => Console.WriteLine($"{p.plakaKodu} -> {p.il}"));

            IlceleriOku(); //Geriye Ilceler Listesi Dönsün
            #region Customer-1000.csv dosyasının okunması ve listelere atılması

            #endregion
            var ilceler = IlceleriOku();
            //foreach (var item in ilceler)
            //{
            //    Console.WriteLine($"{item.IlceKodu} {item.IlKodu} {item.IlceAdi}");
            //}

            #region Ilceler üzerinde İstanbul'un ilçelerini bulma
            var ilceSonuc = ilceler.OrderBy(p => p.IlKodu).ToList();
            foreach (var ilce in ilceler)
            {
                //if (ilce.IlKodu == 22)
                    Console.WriteLine(ilce.IlKodu + " " + ilce.IlceAdi);
                
            }

            //Listelerde Arama Yapma. Izmirin ilceleri 
            var izmirIlceler = ilceler.Where(p => p.IlKodu == 35).ToList();
            izmirIlceler.ForEach(p => Console.WriteLine(p.IlKodu + " " + p.IlceAdi));

            // IStanbulda ki ilcelerin icerisinde 'B' olan ilceler hangileridir.

            var result = ilceler.Where(p => p.IlKodu == 34 && p.IlceAdi.Contains('B')).ToList();
            Console.WriteLine("IStanbuldaki Icerisinde B olan ilcelerin listesi");
            result.ForEach(p => Console.WriteLine(p.IlceAdi));
            #endregion
            #endregion
        }

        #region IlceleriOku methodu 
        private static List<Ilce> IlceleriOku()
        {
            string path2 = "c:\\Dosyalar\\ilce.csv";
            List<Ilce> ilceler = new List<Ilce>();
            try
            {
                string[] satirlar = File.ReadAllLines(path2);

                foreach (var satir in satirlar)
                {
                    Ilce ilce = new Ilce(); // Sehir struct 'dan ornek alinmasi

                    var sonuc = satir.Split(','); //Gelen satiri ',' gore ayirir.
                    #region Eger Tirnaklar gorunmek istenmiyorsa 1. Yol Replace Etmektir.
                    //ilce.IlceKodu = sonuc[0].Replace('"',' ');
                    //ilce.IlKodu = sonuc[1].Replace('"', ' '); 
                    #endregion

                    #region Eger Tirnaklar gorunmek istenmiyorsa 2. Yol int cevirmektir.
                    ilce.IlceKodu = int.Parse(sonuc[0].Replace('"', ' ').Trim());
                    ilce.IlKodu = int.Parse(sonuc[1].Replace('"', ' ').Trim());
                    ilce.IlceAdi = sonuc[1].Replace('"', ' ').Trim();
                    #endregion
                    ilce.IlceAdi = sonuc[2];

                    ilceler.Add(ilce);


                }

            }
            catch (PathTooLongException ex)
            {
                Console.WriteLine("Dosya yolu cok uzun:" + ex.Message);
            }
            catch (FileNotFoundException ex)
            {

                Console.WriteLine("Hata:Aradiginiz dosyaya su an ulasilamadi:" + ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Hata:Aradiginiz Klasore ulasilamadi:" + ex.Message);

            }

            catch (Exception ex)
            {
                Console.WriteLine("Hat:" + ex.Message);

            }



            return ilceler;
        
    }

        #endregion

        #region SehirleriOku methodu
        private static List<Sehir> SehirleriOKu()
        {
            string path = "c:\\Dosyalar\\il.csv";
            //string path2= @"c:\Dosyalar\il.csv";
            //File.ReadAllLines("");
            List<string> plakalar = new List<string>();
            List<string> iller = new List<string>();
            List<Sehir> sehirler = new List<Sehir>();

            try
            {
                string[] satirlar = File.ReadAllLines(path);
                foreach (var satir in satirlar)
                {
                    Sehir sehir = new Sehir(); //sehir struct dan ornek alınması
                    var sonuc = satir.Split(','); //gelen satırı ',' göre ayırır.
                    sehir.plakaKodu = int.Parse(sonuc[0].Replace('"', ' ').Trim());
                    sehir.il = sonuc[1].Replace('"', ' ').Trim();
                    sehir.CreateDate = DateTime.Now;
                    sehir.isActive = true;

                    #region Amele Yöntemi
                    //plakalar.Add(sonuc[0]); // ayrılan parçanın 0. elemanı plaka kodu 
                    //iller.Add(sonuc[1]); // ayrılan parçanın 1.elemanı şehir kodu
                    //Console.WriteLine(item); 
                    #endregion

                    #region Modern Yöntem
                    sehirler.Add(sehir);
                    #endregion

                    #region Amele Yöntemi
                    //for (int i = 0; i < plakalar.Count; i++)
                    //{
                    //    Console.WriteLine($"{plakalar[i]} => {iller[i]} ");
                    //} 
                    #endregion

                }
                //foreach (Sehir sehir in sehirler)
                //{
                //    Console.WriteLine($"{sehir.plakaKodu}=>{sehir.il}\t\tKayit Zamani=>{sehir.CreateDate}\tAktifmi=>{sehir.isActive}");
                //}
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Hata:Aradığınız dosyaya şu an ulaşılamadı:" + ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Hata: Aradığınız klasöre ulaşılamadı: " + ex.Message);
            }
            catch (PathTooLongException ex)
            {
                Console.WriteLine("Dosya yolu çok uzun:" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata" + ex.Message);
            }
            return sehirler;
        } 
        #endregion
    }
}
