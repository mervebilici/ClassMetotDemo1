using System;

namespace ClassMetotDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerAd = "Engin";
            customer1.CustomerSoyad = "Demiroğ";
            customer1.CustomerTc = "14569870485";
            customer1.CustomerId = 11;

            Customer customer2 = new Customer();
            customer2.CustomerAd = "Selma";
            customer2.CustomerSoyad = "Demir";
            customer2.CustomerTc = "14569870455";
            customer2.CustomerId = 12;

            Customer customer3 = new Customer();
            customer3.CustomerAd = "Cengiz";
            customer3.CustomerSoyad = "Yılmaz";
            customer3.CustomerTc = "14669870455";
            customer3.CustomerId = 13;

            Customer customer4 = new Customer();
            customer4.CustomerAd = "Bahar";
            customer4.CustomerSoyad = "Can";
            customer4.CustomerTc = "14478870455";
            customer4.CustomerId = 14;

            Customer eklenen = new Customer();
            CustomerManager add = new CustomerManager();
            add.Add(eklenen);

            CustomerManager listelemeCustomer = new CustomerManager();
            listelemeCustomer.ListelemeCustomers(customer1, customer2, customer3, customer4, eklenen);

            CustomerManager musteriSil = new CustomerManager();
            musteriSil.Delete(customer2);

            CustomerManager musteriGuncelle = new CustomerManager();
            Customer güncellenen = new Customer();
            musteriGuncelle.Update(güncellenen);
        }
    }
}
