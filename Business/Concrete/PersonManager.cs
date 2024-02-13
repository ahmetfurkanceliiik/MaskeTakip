using Business.Abstract;
using Entities.Concrete;
using mERNİSServiceReference;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonManager:IApplicantService
    {
        public void ApplyForMask(Person person)
        {

        }

        public List<Person> GetList()
        {
            return null;
        }

        public bool CheckPerson(Person person)
        {
            //mernis kontrol yapılacak.
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody( person.NationalIdentity,person.FirstName,person.LastName,person.DateOfBrithYear))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }


}
