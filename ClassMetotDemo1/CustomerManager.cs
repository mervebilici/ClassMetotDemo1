using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo1
{
    class CustomerManager
    {
        public void Add(Customer musteri)
        {
            musteri.CustomerAd = "Merve";
            musteri.CustomerSoyad = "Bilici";
            musteri.CustomerTc = "111444111777";
            musteri.CustomerId = 15;
            Console.WriteLine("Müşteri Eklendi." + "Müşteri Adı:" + musteri.CustomerAd + " " + musteri.CustomerSoyad);
        }

        public void Delete(Customer musteri)
        {
            
            Console.WriteLine(musteri.CustomerAd + " " + musteri.CustomerSoyad +"Müşteri Kaydı Silinmiştir.");
        }

        public void Update(Customer musteri)
        {
            int yeniId = Convert.ToInt16(Console.ReadLine());
            musteri.CustomerId = yeniId;
            if (musteri.CustomerId == yeniId)
                Console.WriteLine("Müşteri Güncellendi");
        }

        public void ListelemeCustomers(params Customer[] musteriler)
        {
            foreach (var listeleMusteri in musteriler)
            {
                Console.WriteLine(listeleMusteri.CustomerAd + ":" + listeleMusteri.CustomerSoyad + ":" + listeleMusteri.CustomerTc + ":" + listeleMusteri.CustomerId); ;
            }
        }
    }
}
