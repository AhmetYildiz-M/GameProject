using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;
using UserValidationServiceReference;

namespace GameProject.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool CheckUserValidation(User user)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest
                    (new TCKimlikNoDogrulaRequestBody(Convert.ToInt64(user.NationalityId), 
                    user.FirstName.ToUpper(),user.LastName.ToUpper(),user.DateOfBirth.Year)))
                .Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
