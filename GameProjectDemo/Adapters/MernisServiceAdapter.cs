using GameProjectDemo.Abstract;
using GameProjectDemo.Entites;
using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Adapters;
using MernisServiceReference;

namespace GameProjectDemo.Adapters
{
    public class MernisServiceAdapter : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            //MernisServiceReference.KPSPublicSoapClient client = new MernisServiceReference.KPSPublicSoapClient();
            //return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.NationaltyId), gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(), gamer.DateOfBirth.Year);

            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.NationaltyId), gamer.FirstName.ToUpper(),
                gamer.LastName.ToUpper(), gamer.DateOfBirth.Year).Result;
            return result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
