using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    //cıplak class kalmasın
    // service gibi benzer işlem yapmaıs icin olusturuldu
    public class PersonManager : IApplicantService
    {
        //encapsulation Person olarak almadır, string name , int age olarak almak saglıklı degil degisiklik oldugu zaman
        public void ApplyForMask(Person person)
        {


        }

        public List<Person> GetList()
        {
            return null;
        }

        public async Task<bool> CheckPerson(Person person)
        {
            // Mernis kontrolü

            using (var client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap))
            {
                var response = await client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(123, "ŞULE NUR", "SEKMEN", 1998)));

                return response.Body.TCKimlikNoDogrulaResult;
            }
        }

        bool IApplicantService.CheckPerson(Person person)
        {
            throw new NotImplementedException();
        }
    }


}
