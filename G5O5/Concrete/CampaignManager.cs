using G5O5.Abstract;
using G5O5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace G5O5.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Ekle(Campaign campaign)
        {
            Console.WriteLine(campaign.Ad +" kampanyası eklenmiştir.");
        }

        public void Guncelle(Campaign campaign)
        {
            Console.WriteLine(campaign.Ad + " kampanyası güncellenmiştir.");
        }

        public void Sil(Campaign campaign)
        {
            Console.WriteLine(campaign.Ad + " kampanyası silinmiştir.");
        }
    }
}
