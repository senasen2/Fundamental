namespace _10_MetodlarLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Sorular
            /*
             * 1- KdvHesapla(100,20,dahil) ==> 83.33
             * KdvHesapla(100,20,haric) ==> 120
             * 
             * 2-HizHesapla(100km,30 dakika) ==> 200 km hızla gitmelisin.
             * 
             * 3-DiziOLustur(elemanSayisi) ==> int tipinden icerisinde 1-100 rastgele sayıların olduğu bir dizi dönecek
             * 
             * 
             * 4-SehirGetir(0) ==> rastgele bir şehir getirsin 
             * SehirGetir(34) ==> İstanbul'u getir
             * 
             * 5-SesliHarfSayisi(string) ==> 5 adet sesli harf vardır. a,e,i şeklinde bir çıktı versin.
             * 
             * 6-Sifrele(string) ==> sifrelenmis şekilde bastırsın. SifreCoz(sifrelenmis) ==> kelime
             * 
             * 7-Klavyeden girilen bir tam sayının basamaklarını ekrana yazdıran metod ==> BasamakBul(int)
             */

            //1-KdvHesapla metodu çağırma 
            //KdvHesapla(100, 20, true);

            //2-HizHesapla() metodu çağırma
            //hız = x*t  t = hiz/ x 
            //HizHesapla(100,0.5);

            //3-DiziOlustur() metodu çağırma
            //var dizi = DiziOlustur(10);
            //foreach (var item in dizi) 
            //{
            //    Console.WriteLine(item); 
            //}

            //4-SehirGetir Metodu Çağırma
            string[] sehirler ={"Adana","Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin",
            "Aydın", "Balıkesir","Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale",
            "Çankırı", "Çorum","Denizli","Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum ", "Eskişehir",
            "Gaziantep", "Giresun","Gümüşhane", "Hakkari", "Hatay", "Isparta", "Mersin", "İstanbul", "İzmir",
            "Kars", "Kastamonu", "Kayseri","Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya ", "Malatya",
            "Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya",
            "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon  ", "Tunceli", "Şanlıurfa", "Uşak",
            "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt ", "Karaman", "Kırıkkale", "Batman", "Şırnak",
            "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük ", "Kilis", "Osmaniye ", "Düzce"};
            //(sehirler, 6);

            //5-SesliHarfSayisi() Metodu Çağırma
            //esliHarfSayisi("Çiçekler çok güzeller.");

            //6-Sifreleme() metodu çağırma ***** 6-Sifrele(string) ==> sifrelenmis şekilde bastırsın. SifreCoz(sifrelenmis) ==> kelime
            Console.WriteLine("Mesajınızı yazınız:");
            string mesaj = Console.ReadLine();
            Sifreleme(mesaj);

            //7-BasamakBul Metodu çağrıma
            BasamakBul(1881);
            #endregion
        }

        //public static void KdvHesapla(int tutar, int kdv, bool dahilMi)
        //{
        //    if (dahilMi)
        //    {
        //        double kdvtutari = tutar * kdv / 100;
        //        Console.WriteLine($"Kdv Tutari:{kdvtutari}");
        //        Console.WriteLine($"Toplam Tutar:{tutar + kdvtutari}");
        //    }
        //    else
        //    {
        //        double kdvharictutar = tutar / ((100 + kdv) / 100);
        //        Console.WriteLine("Fiyat:" + tutar);
        //        Console.WriteLine($"Kdv Haric Tutai:{kdvharictutar}");
        //        Console.WriteLine($"Kdv Tutar:{tutar - kdvharictutar}");

        //    }
        //}

        //public static void HizHesapla(double yol, double sure) 
        //{
        //    double sonuc = 0;
        //    sonuc = yol / sure;
        //    Console.WriteLine($"İstediğiniz Saatte Varmak İçin Gitmeniz Gereken Hız: {sonuc}");
        //}

        //public static int[] DiziOlustur(int elemanSayisi)
        //{
        //    int [] randomDizi = new int [elemanSayisi];
        //    Random rnd = new Random();
        //    for (int i = 0; i < randomDizi.Length; i++)
        //    {
        //        randomDizi[i] = rnd.Next(1, 100);
        //    }
        //    Console.WriteLine($"Rastgele Diziniz Oluşturuldu Dizinin Eleman Sayısı:{elemanSayisi}");
        //    return randomDizi;
        //}

        //public static void SehirGetir(string[] sehirler, byte plaka) 
        //{
        //    Random rnd = new Random();
        //    if (plaka == 0)
        //    {
        //        Console.WriteLine(sehirler[rnd.Next(1, sehirler.Length)]);
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Aradığınız Şehir:{sehirler[plaka - 1]}");
        //    }
        //}

        //public static void SesliHarfSayisi(string cumle) 
        //{
        //    char[] sesliHarfler = { 'a', 'e' , 'ı', 'i' , 'o', 'ö', 'u', 'ü' };
        //    int sayac = 0;
        //    foreach (var harf in cumle)
        //    {
        //        for (int i = 0; i < sesliHarfler.Length; i++)
        //        {
        //            if (harf == sesliHarfler[i]) sayac++;
        //        }
        //    }
        //    Console.WriteLine(cumle);
        //    Console.WriteLine("Bulunan sesli harf sayısı:" + sayac);
        //}

        public static void Sifreleme(string mesaj)
        {
            string[] kelimeler = mesaj.Split(' ');
            string sonuc = "";

            foreach (string kelime in kelimeler)
            {
                // Kelimenin uzunluğuna göre şifreleme
                if (kelime.Length > 2)
                {
                    // İlk ve son harfi koru, diğerlerini yıldızla değiştir
                    string sifreliKelime = kelime[0] + new string('*', kelime.Length - 2) + kelime[kelime.Length - 1];
                    sonuc += sifreliKelime + " ";
                }
                else
                {
                    // Kelimenin uzunluğu 2 veya daha az ise olduğu gibi ekle
                    sonuc += kelime + " ";
                }
                
            }
            Console.WriteLine("Şifrelenmiş Mesaj: " + sonuc.Trim());
        }

        public static void BasamakBul(int number)
        {

            // int'i string'e çevir
            string sayiStr = number.ToString();

            // Her bir basamağı ayırmak için karakter dizisine dönüştürelim
            char[] sayiBasamaklari = sayiStr.ToCharArray();

            if (sayiBasamaklari.Length == 2)
            {
                Console.WriteLine($"Sayının onlar basamağı:{sayiStr[0]}, Sayının birler basamağı:{sayiStr[1]}");
            }
            else if (sayiBasamaklari.Length == 3)
            {
                Console.WriteLine($"Sayının yüzler basamağı:{sayiStr[0]}, Sayının onlar basamağı:{sayiStr[1]}, Sayının birler basamağı:{sayiStr[2]}");
            }
            else if (sayiBasamaklari.Length == 4)
            {
                Console.WriteLine($"Sayının Binler Basamağı:{sayiStr[0]},Sayının yüzler basamağı:{sayiStr[1]}, Sayının onlar basamağı:{sayiStr[2]}, Sayının birler basamağı:{sayiStr[3]}");
            }
            else if (sayiBasamaklari.Length == 5)
            {
                Console.WriteLine($"Sayının Onbinler Basamağı:{sayiStr[0]}, Sayının Binler Basamağı:{sayiStr[1]},Sayının yüzler basamağı:{sayiStr[2]}, Sayının onlar basamağı:{sayiStr[3]}, Sayının birler basamağı:{sayiStr[4]}");
            }
            else
            {
                Console.WriteLine("Sayı belirlenen aralıkta değildir.");
            }
        }

       }
    }
