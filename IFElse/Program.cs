namespace IFElse;

class Program
{
    static void Main(string[] args)
    {
        #region Girilen Sayı Okuma


        // /*
        // Girilen 2 sayının 
        // */

        // int sayi1 = 5;
        // int sayi2 = 5;

        // if(sayi1 == 5)
        // {
        //     System.Console.WriteLine("Sayı 5 dir");
        // }
        // else
        // {
        //     System.Console.WriteLine("Sayı 5 değildir.");
        // }

        // if(sayi1 >sayi2)
        // {
        //     System.Console.WriteLine(sayi1 + " > " + sayi2);
        // }
        // else if(sayi1 == sayi2)
        // {
        //     System.Console.WriteLine(sayi1 + " = " + sayi2);
        // }
        // else
        // {
        //     System.Console.WriteLine(sayi1 + " < " + sayi2);
        // }
        #endregion

        #region Su Sıcaklığı
        // int suSicakligi;
        // string temp;
        // Console.WriteLine("Suyun sıcaklığını giriniz:");

        // temp = Console.ReadLine();
        // suSicakligi = Convert.ToInt16(temp);

        // if(suSicakligi <= 0)
        // {
        //     Console.WriteLine("Katı.");
        // }
        // else if(suSicakligi>=100)
        // {
        //     Console.WriteLine("Sıvı.");
        // }
        // else
        // {
        //     Console.WriteLine("Gaz.");
        // }
        #endregion

        #region Haftanın Günleri
        /*Pazartesi haftanın birinci günü olmak 
        üzere, erkandan haftanın gününü okutun. 
        1 = pazartesi, 2=salı ......şeklinde bastırın.
        */

        // Console.WriteLine("Sayıyı Giriniz.");
        // byte gun;
        // gun = byte.Parse(Console.ReadLine());

        // if(gun == 1)
        // {
        //     Console.WriteLine("Pazartesi.");
        // }
        // else if(gun == 2)
        // {
        //     Console.WriteLine("Salı.");
        // }
        // else if(gun == 3)
        // {
        //     Console.WriteLine("Çarşamba.");
        // }
        // else if(gun == 4)
        // {
        //     Console.WriteLine("Perşembe.");
        // }
        // else if(gun == 5)
        // {
        //     Console.WriteLine("Cuma.");
        // }
        // else if(gun == 6)
        // {
        //     Console.WriteLine("Cumartesi.");
        // }
        // else if(gun == 7)
        // {
        //     Console.WriteLine("Pazar.");
        // }

        #endregion

        #region Final Notu Bulma
        /*
        2 vize 1 final alınacak. Vizenin %30 finalin %70 alınacak
        eğer çıkan sonuç 
             0-29 arası ise D
             30-49 arası ise C
             50-69 arası ise B
             70-100 arasında ise A
        && = ve || = ya da anlamındadır.

        */

        // byte vizeNotu1, vizeNotu2, finalNotu;
        // double sonuc;
        // Console.WriteLine("Birinci vize notunu giriniz:");
        // vizeNotu1 = byte.Parse(Console.ReadLine());
        // Console.WriteLine("İkinci vize notunu giriniz:");
        // vizeNotu2 = byte.Parse(Console.ReadLine());
        // Console.WriteLine("Final notunu giriniz:");
        // finalNotu = byte.Parse(Console.ReadLine());

        // sonuc = 0.15* vizeNotu1 + 0.15* vizeNotu2 + 0.7* finalNotu;

        // if(sonuc > 0 && sonuc <= 29)
        // {
        //     Console.WriteLine("Notunuz 'D' ");
        // }
        // else if(sonuc > 29 && sonuc <= 49)
        // {
        //     Console.WriteLine("Notunuz 'C'");
        // }
        // else if(sonuc > 49 && sonuc <= 69)
        // {
        //     Console.WriteLine("Notunuz 'B'");
        // }
        // else if(sonuc > 69 && sonuc <= 100)
        // {
        //     Console.WriteLine("Notunuz 'A'");
        // }

        #endregion

        #region Reyon Bulma
        /*
        Dışardan ürün adı girilecek program ürününün
        hangi reyonda olduğunu söyleyecek
        Domates, biber, patlıcan, için Sebze Reyonu
        Diş macunu, Parfum, Krem için Kozmetik Reyonu
        Telefon, Bilgisayar, Ses sistemleri için teknoloji reyonu
        Bunlardan farklı bir ürün girerse "Bu ürün bizde yok" uyarısı verecek
        */

        // string urunAdi;

        // Console.WriteLine("Ürünü giriniz:");

        // urunAdi = Console.ReadLine();

        // if(urunAdi == "Domates" || urunAdi == "Biber" || urunAdi == "Patlıcan")
        // {
        //     Console.WriteLine("Sebze Reyonu");
        // }
        // else if(urunAdi == "Diş Macunu" || urunAdi == "Parfüm" || urunAdi == "Krem")
        // {
        //     Console.WriteLine("Kozmetik Reyonu");
        // }
        // else if(urunAdi == "Telefon" || urunAdi == "Bilgisayar" || urunAdi == "Kulaklık")
        // {
        //     Console.WriteLine("Teknoloji Reyonu");
        // }
        // else
        // {
        //     Console.WriteLine("Ürün Yok!");
        // }
        #endregion

        #region Fiyat Tespit
        /*
        Urun Fiyatı 5 TL olsun
        Dışardan girilecek siparis sayisina göre 
        20 den az ise toplam ücretten %5 indirim yapılacak
        20 - 49 arasında ise %10 indirim
        50 - 99 arasında ise %15 indirim
        100 ve üzeri için %20 indirim yapılacak.
        Ekrana toplam tutar, indirim miktarı ve ödenecek tutar bilgilerini yazdırın.
        */

        //double urunFiyati = 5.0;
        //Console.WriteLine("Sipariş sayinizi giriniz");
        //int siparisSayisi = Convert.ToInt32(Console.ReadLine());

        //double toplamTutar = urunFiyati * siparisSayisi;
        //double indirimOrani = 0;

        //if (siparisSayisi < 20)
        //{
        //    indirimOrani = 0.05;
        //}
        //else if(siparisSayisi >=20 && siparisSayisi <50)
        //{
        //    indirimOrani = 0.10;
        //}
        //else if(siparisSayisi >=50 && siparisSayisi <100)
        //{
        //    indirimOrani = 0.15;
        //}
        //else if(siparisSayisi >=100 )
        //{
        //    indirimOrani = 0.20;
        //}

        //double indirimMiktari = toplamTutar * indirimOrani;
        //double odenecekTutar = toplamTutar - indirimMiktari;
        //Console.WriteLine($"Toplam Tutar: {toplamTutar} TL");
        //Console.WriteLine($"İndirim Miktarı: {indirimMiktari} TL");
        //Console.WriteLine($"Ödenecek Tutar: {odenecekTutar} TL");

        #endregion

        #region Ternary IF
        //Eğer tek satırda ufak bir karar mekanizması ile yola devam etmek istiyorsak
        //? operatörü kullanmamız gerekecektir.
        //Yazı formati => sonuc > 10 ? "True" : "False";
        //Genelde Database'den gelen ya da
        //apiden gelen değerleri kontrol etmekte sıklıkca kullanılır.
        //Ya da bir değişkene değer atarken kullanılır.

        //int yas = 20;
        //var sonuc = yas > 18 ? "Reşit" : "Reşit Değildir.";
        //Console.WriteLine(sonuc);

        //string result;
        //if (yas > 18)
        //{
        //    result = "Reşit";
        //}
        //else 
        //{
        //    result = "Reşit Değil";
        //}

        #endregion

        #region Switch Case
        /*
         * if - else mantığı ile çalışır.
         * IF ELSE büyük, küçük, eşit vb durumları
         * kontrol ederken switch case esitlik durumlarına bakar.
         * kendi içerisinde bir indelemeye sahiptir
         * eşitlik koşulları fazla olan durumlarda performans açısından 
         * switch case tavsiye edilir.
         */
        #region Haftanın Günleri
        //byte gunler;
        //Console.WriteLine("Günü Giriniz:");
        //gunler = byte.Parse(Console.ReadLine());
        //switch (gunler)
        //{
        //    case 1:
        //        Console.WriteLine("Pazartesi");
        //        break;
        //    case 2: //birden fazla satır kod yazılacak ise {} arasında yazılabilir.
        //        Console.WriteLine("Salı");
        //        break;
        //    case 3:
        //        Console.WriteLine("Çarşamba");
        //        break;
        //    case 4:
        //        Console.WriteLine("Perşembe");
        //        break;
        //    case 5:
        //        Console.WriteLine("Cuma");
        //        break;
        //    case 6:
        //        Console.WriteLine("Cumartesi");
        //        break;
        //    case 7:
        //        Console.WriteLine("Pazar");
        //        break;

        //}
        #endregion

        //Switch içerisindek veri tipi ne ise case kısmında buna uygun kontrol yapılması gerekiyor
        //bu durum en sık yapı-ılan hatalardandır.
        #region Ornek 1 : Ekrandan Mevsim Okutun ve Ayları bastırın. switch case ile yapılacak.
        
        Console.WriteLine("Mevsim Giriniz;");
        string mevsim = Console.ReadLine();

        switch (mevsim)
        {
            case "Kış":
                Console.WriteLine("Aralık, Ocak, Şubat");
                break;
            case "İlkbahar":
                Console.WriteLine("Mart,Nisan, Mayıs");
                break;
            case "Yaz":
                Console.WriteLine("Haziran, Temmuz, Ağustos");
                break;
            case "Sonbahar":
                Console.WriteLine("Eylül, Ekim, Kasım");
                break;
            default:
                break;
        }
        #endregion

        #endregion

    }


}
