namespace IFElse;

class Program
{
    static void Main(string[] args)
    {
        /*
        Girilen 2 sayının 
        */

        int sayi1 = 5;
        int sayi2 = 5;

        if(sayi1 == 5)
        {
            System.Console.WriteLine("Sayı 5 dir");
        }
        else
        {
            System.Console.WriteLine("Sayı 5 değildir.");
        }

        if(sayi1 >sayi2)
        {
            System.Console.WriteLine(sayi1 + " > " + sayi2);
        }
        else if(sayi1 == sayi2)
        {
            System.Console.WriteLine(sayi1 + " = " + sayi2);
        }
        else
        {
            System.Console.WriteLine(sayi1 + " < " + sayi2);
        }
    }
}
