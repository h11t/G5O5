using G5O5.Abstract;
using G5O5.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference;

namespace G5O5.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(Convert.ToInt64(customer.TCNo), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.BirthDate.Year))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
