using G5O5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace G5O5.Abstract
{
   public interface ICampaignService
    {
        void Ekle(Campaign campaign);
        void Sil(Campaign campaign);
        void Guncelle(Campaign campaign);

    }
}
