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

    public struct People
    {
        //Index,User Id,First Name,Last Name,Sex,Email,Phone,Date of birth,Job Title
        public int Index; //0
        public string ID; //1
        public string Name; //2
        public string LastName; //3
        public string Gender;  //4
        public string Email; //5
        public string Phone; //6
        public DateTime Birthday; //7
        public string Job; //8
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //var liste = CustomerOku();
            //liste.ForEach(e => Console.WriteLine($"{e.ID} + {e.Name} + {e.LastName} + {e.Company} + {e.City} + {e.Company} + {e.City} + {e.Country} + {e.Phone1} + {e.Phone2} {e.Email} + {e.SubscriptionDate} + {e.Website}"));

            #region Odev
            /*
             * People datasini okuyun
             * Games developer sayisi nedir. 
             * En kucuk ve en buyuk yastaki developer'lari bulun
             * yas ortalamasini bulun
             * 
             */
            //Index,User Id,First Name,Last Name,Sex,Email,Phone,Date of birth,Job Title
            var liste = PeopleOku();
            liste.ForEach(x => Console.WriteLine($"{x.Index} - {x.ID} - {x.Name} - {x.LastName} - {x.Gender} - {x.Email} - {x.Phone} - {x.Birthday} - {x.Job}"));
            #endregion
        }

        public static List<People> PeopleOku()
        {
            List<People> peopleList = new List<People>();
            var satirlar2 = File.ReadAllLines(@"c:\Dosyalar\people-100.csv");

            for (int i = 1; i < satirlar2.Length; i++)
            {
                var result = satirlar2[i].Split(',');
                People insan = new People(); //örnek alımı

                insan.Index = int.Parse(result[0]);
                insan.ID = result[1];
                insan.Name = result[2];
                insan.LastName = result[3];
                insan.Gender = result[4];
                insan.Email = result[5];
                insan.Phone = result[6];
                insan.Birthday = DateTime.Parse(result[7]);
                insan.Job = result[8];


                //if (satirlar2.Length == 12)
                //{
                //    insan.Phone = result[6];
                //    insan.Birthday = DateTime.Parse(result[7]);
                //    insan.Job = result[8]; 
                //}
                //else if (satirlar2.Length == 13)
                //{
                //    insan.Phone = result[7];
                //    insan.Birthday = DateTime.Parse(result[8]);
                //    insan.Job = result[9];
                //}

                peopleList.Add(insan);
            }
            return peopleList;
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
