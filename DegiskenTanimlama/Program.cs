using System;

public class Program
{
    public static void Main(string[] args)
    {
        #region VERİ TİPLERİ
        // byte a;
        // short b;
        // ushort b1;
        // int c;
        // uint d;
        // Console.WriteLine("Hello, World!");
        // Console.WriteLine("Degişken Uzunlukları");
        // Console.WriteLine("Byte ............");
        // Console.WriteLine(byte.MinValue);
        // Console.WriteLine(byte.MaxValue);
        // Console.WriteLine("short ........");
        // Console.WriteLine(short.MinValue);
        // Console.WriteLine(short.MaxValue);
        // Console.WriteLine("unsign short .........");
        // Console.WriteLine(ushort.MinValue);
        // Console.WriteLine(ushort.MaxValue);
        #endregion

        #region ÖRNEKLER
        // string ad = "Ali", soyad;
        // DateTime DogumTarihi;
        // DateTime Bugun = DateTime.Now;//ilk değer ataması
        // byte ayakkabiNumarasi = 42;
        // string tcno = "15862944866" ; tcno.Substring(7,11);
        // string gsm = "+90535 563 98 65";
        #endregion

    //Runtime sırasında tipi belirleme
        // var temp = "12";
        // System.Console.WriteLine(temp);
        #region KÜSÜRLÜ SAYILAR
        // var sayi = 12.3; //bu hali ile double olur
        // var sayi2 = 12.3f; //Default olarak double olur, float için f yazmamız gerekir.
        // var sayi3 = 12.3m; //decimal
        #endregion

        #region SABİTLER
        // const float pi = 3.14f; //const değişkenlere sonradan değer ataması yapılamaz.
        // System.Console.WriteLine(pi);
        #endregion

        #region DEĞİŞKENLERİN YAŞAM ÖMRÜ
        // int yas = 20;
        // {
        //     string email = "snjsnd@gmail.com";
        //     System.Console.WriteLine(email);
        //     System.Console.WriteLine(yas);
        //     {
        //         int sayi = 10;
        //         System.Console.WriteLine(email);
        //         System.Console.WriteLine(yas);
        //         System.Console.WriteLine(sayi);
        //     }
         //System.Console.WriteLine(sayi); //Hata verir!
        // }
        //System.Console.WriteLine(email); //Hata verir!
        //System.Console.WriteLine(sayi); //Hata verir!
        #endregion
    
    #region Nullable Değişken Tanımlama ve ?
    //bir değişkene null değerler atilabilir demek için ? ile işaretlemek gerekir.
        string str = "";

    #endregion
    }

}


