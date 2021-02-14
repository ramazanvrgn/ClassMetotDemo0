using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 2564511;
            customer1.CustomerName = "Ahmet";
            customer1.CustomerSurname = "Yılık";
            customer1.CustomerGender = "Erkek";
            customer1.CustomerAge = 36;

            Customer customer2 = new Customer();
            customer2.Id = 256952;
            customer2.CustomerName = "Ayşe";
            customer2.CustomerSurname = "Sezgin";
            customer2.CustomerGender = "Kadın";
            customer2.CustomerAge = 26;

            Customer customer3 = new Customer();
            customer3.Id = 563411;
            customer3.CustomerName = "Sezai";
            customer3.CustomerSurname = "Karabıyık";
            customer3.CustomerGender = "Erkek";
            customer3.CustomerAge = 30;
            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            CustomerManager customerManager = new CustomerManager();
            // Ekleme
            customerManager.Ekle(customer1);
            Console.WriteLine();
            customerManager.Ekle(customer2);
            Console.WriteLine();
            customerManager.Ekle(customer3);
            Console.WriteLine();
            //Silme
            customerManager.Sil(customer1);
            Console.WriteLine();

            //Listeleme
            Console.WriteLine("*******************************************************************");
            foreach (var c in customers)
            {
                customerManager.Listele(c);
                Console.WriteLine("-------------------------------------------------------");
            }
            
            
        }
    }
}
