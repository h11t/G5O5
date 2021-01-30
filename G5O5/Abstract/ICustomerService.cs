using G5O5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace G5O5.Abstract
{
    public interface ICustomerService
    {
        void KayıtOl(Customer oyuncu);
        void Guncelle(Customer oyuncu);

        void KayitSil(Customer oyuncu);

       // Customer Find();
    }
}
