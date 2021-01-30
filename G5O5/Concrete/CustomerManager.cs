using G5O5.Abstract;
using G5O5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace G5O5.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerCheckService _customerCheckService;
        public CustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
        public void Guncelle(Customer oyuncu)
        {
            Console.WriteLine(oyuncu.FirstName +" isimli kişinin kaydı güncellendi");
        }

        public void KayitSil(Customer oyuncu)
        {
            Console.WriteLine(oyuncu.FirstName + " isimli kişinin kaydı silindi");
        }


        public void KayıtOl(Customer oyuncu)
        {
            if (_customerCheckService.CheckIfRealPerson(oyuncu))
            {
                Console.WriteLine(oyuncu.FirstName + " isimli kişinin kaydı gerçekleştirildi");
            }
            else
            {
                Console.WriteLine("Böyle bir kişi yoktur");
            }
        }
    }
}
