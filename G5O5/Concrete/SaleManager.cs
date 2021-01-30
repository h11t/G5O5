using G5O5.Abstract;
using G5O5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace G5O5.Concrete
{
    public class SaleManager : ISaleService
    {
        ICustomerService _customerService;
        ICampaignService _campaignService;
        public SaleManager(ICustomerService customerService, ICampaignService campaignService)
        {
            _customerService = customerService;
            _campaignService = campaignService;
        }

        public  void Sell(ICustomerService customer, ICampaignService campaign)
        {
            Console.WriteLine("bu kişi şu kampanyalı ürünü almıştır");
        }
    }
}
