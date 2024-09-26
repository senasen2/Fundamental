namespace _18_DosyaOkuma
{
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

            #region Customer-1000.csv dosyasının okunması
            string path = "c:\\Dosyalar\\il.csv";
            //string path2= @"c:\Dosyalar\il.csv";
            //File.ReadAllLines("");

            try
            {
               string[] satirlar =  File.ReadAllLines(path);
                foreach (var item in satirlar)
                {
                    Console.WriteLine(item);
                }
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
            #endregion



            #endregion
        }
    }
}
