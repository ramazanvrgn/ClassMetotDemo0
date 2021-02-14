using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Ekle(Customer customer)
        {
            Console.WriteLine("{0} nolu ve {1} {2}  adlı müşteri eklendi!  ", customer.Id , customer.CustomerName, customer.CustomerSurname);
        }
        public void Sil(Customer customer)
        {
            Console.WriteLine("{0} nolu ve {1} {2}  adlı müşteri Silindi!  ", customer.Id, customer.CustomerName, customer.CustomerSurname);

        }
        public void Listele(Customer customer)
        {
            Console.WriteLine(" Müşteri Numarası : " + customer.Id 
                +"\n Müşteri Adı : "+ customer.CustomerName 
                + "\n Müşteri Soyadı : " + customer.CustomerSurname
                + "\n Müşteri Yaşı : " + customer.CustomerAge
                + "\n Cinsiyet : " +customer.CustomerGender 
                );
        }
    }
}
