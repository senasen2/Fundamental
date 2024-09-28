using System.Globalization;

namespace _18_CustomerDosyasiOkuma
{
    public struct Customer 
    {
        public int Index;
        public string ID;
        public string Name;
        public string LastName;
        public string Company;
        public string City;
        public string Country;
        public string Phone1;
        public string Phone2;
        public string Email;
        public DateTime SubscriptionDate;
        public string Website;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //CustomerOku(); -> geriye List<Customer> dönecek.
            //CustomerOku();
            var liste = CustomerOku();
            liste.ForEach(e => Console.WriteLine($"{e.ID} + {e.Name} + {e.LastName} + {e.Company} + {e.City} + {e.Company} + {e.City} + {e.Country} + {e.Phone1} + {e.Phone2} {e.Email} + {e.SubscriptionDate} + {e.Website}"));
        }

        public static List<Customer> CustomerOku()
        {
            List<Customer> customers = new List<Customer>();
            var satirlar = File.ReadAllLines(@"c:\Dosyalar\customers-1000.csv");
            
                for (int i = 1; i < satirlar.Length; i++)
                {
                
                    var sonuc = satirlar[i].Split(',');
                    Customer cst = new Customer(); //structan örnek alınıyor

                    cst.Index = int.Parse(sonuc[0]);
                    cst.ID = sonuc[1];
                    cst.Name = sonuc[2];
                    cst.LastName = sonuc[3];
                    

                if (sonuc.Length == 12)
                {
                    cst.Company = sonuc[4];
                    cst.City = sonuc[5];
                    cst.Country = sonuc[6];
                    cst.Phone1 = sonuc[7];
                    cst.Phone2 = sonuc[8];
                    cst.Email = sonuc[9];
                    cst.SubscriptionDate = DateTime.Parse(sonuc[10]);
                    cst.Website = sonuc[11];
                }
                else if(sonuc.Length == 13)
                {
                    cst.Company = sonuc[4] + " " + sonuc[5];
                    cst.City = sonuc[6];
                    cst.Country = sonuc[7];
                    cst.Phone1 = sonuc[8];
                    cst.Phone2 = sonuc[9];
                    cst.Email = sonuc[10];
                    cst.SubscriptionDate = DateTime.Parse(sonuc[11]);
                    cst.Website = sonuc[12];
                }

                customers.Add(cst);
                }
            return customers;
        }
    }
}
