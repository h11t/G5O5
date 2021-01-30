using G5O5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace G5O5.Abstract
{
   public interface ISaleService
    {
        void Sell(ICustomerService customer, ICampaignService campaign);
    }
}
