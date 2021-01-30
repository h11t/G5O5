using G5O5.Abstract;
using G5O5.Adapters;
using G5O5.Concrete;
using G5O5.Entities;
using System;

namespace G5O5
{
    class Program
    {
        static void Main(string[] args)
        {
            //tckimli no boş bırakılmıştır
            ICustomerService customer1 = new CustomerManager(new MernisServiceAdapter());
            customer1.KayıtOl(new Customer { Id=1 , BirthDate=new DateTime(1992,6,6), FirstName="hilal", LastName="tekdemir", TCNo=""});
            customer1.Guncelle(new Customer { FirstName = "hilal" });
            customer1.KayitSil(new Customer { FirstName = "hilal" });

            customer1.KayıtOl(new Customer {Id=1, BirthDate = new DateTime(1992, 6, 6), FirstName = "hilal", LastName = "tekdemir", TCNo = "" });
            ICustomerService customer2 = new CustomerManager(new MernisServiceAdapter());
            customer1.KayıtOl(new Customer { Id = 1, BirthDate = new DateTime(1993, 6, 6), FirstName = "hilal", LastName = "tekdemir", TCNo = "" });



            ICampaignService campaign1 = new CampaignManager();
            campaign1.Ekle(new Campaign { Id=1,Ad="3 ALANA 1 BEDAVA", Aciklama="Seçili ürünlerde bu kampanya geçerlidir.", Fiyat=99.9  });
            campaign1.Guncelle(new Campaign { Ad = "3 ALANA 1 BEDAVA", Aciklama = "Seçili ürünlerde bu kampanya geçerlidir.", Fiyat = 100 });
            campaign1.Sil(new Campaign { Ad = "3 ALANA 1 BEDAVA" });

            campaign1.Ekle(new Campaign { Id = 1, Ad = "3 ALANA 1 BEDAVA", Aciklama = "Seçili ürünlerde bu kampanya geçerlidir.", Fiyat = 99.9 });

            ISaleService sale1 = new SaleManager(customer1,campaign1);
            sale1.Sell(customer1, campaign1);




        }
    }
}
