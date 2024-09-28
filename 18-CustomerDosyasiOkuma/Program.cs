namespace _18_CustomerDosyasiOkuma
{
    public struct Customer 
    {
        public string Index;
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
            var customers = CustomerOku();
            #region Sorular

            #endregion
        }

        public static List<Customer> CustomerOku()
        {

            string path = "c:\\Dosyalar\\customers-1000.csv";
            List<Customer> customers = new List<Customer>();

            try
            {
                string[] satirlar = File.ReadAllLines(path);
                foreach (var satir in satirlar) 
                {
                    Customer cst = new Customer(); //structan örnek alınıyor
                    var sonuc = satir.Split(','); //verileri ',' e göre ayırır
                                                  //
                    cst.Index = sonuc[0].Replace('"', ' ').Trim();
                    cst.ID = sonuc[1].Replace('"', ' ').Trim();
                    cst.Name = sonuc[2].Replace('"', ' ').Trim();
                    cst.LastName = sonuc[3].Replace('"', ' ').Trim();
                    cst.Company = sonuc[4].Replace('"', ' ').Trim();
                    cst.City = sonuc[5].Replace('"', ' ').Trim();
                    cst.Country = sonuc[6].Replace('"', ' ').Trim();
                    cst.Phone1 = sonuc[7].Replace('"', ' ').Trim();
                    cst.Phone2 = sonuc[8].Replace('"', ' ').Trim();
                    cst.Email = sonuc[9].Replace('"', ' ').Trim();
                    string subscriptionDateString = sonuc[10].Replace('"', ' ').Trim();
                    cst.Website = sonuc[11].Replace('"', ' ').Trim();

                    customers.Add( cst );
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

            return customers;
        }
    }
}
