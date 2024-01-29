using epita_dummy_data_with_faker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epita_dummy_data_with_faker.Services
{
    public static class GenerateUserProfiles
    {
        public static List<UserProfile> Profiles()
        {
            List<UserProfile> listOfProfiles = new List<UserProfile>();
            for (int i = 0; i < 25; i++)
            {

                UserProfile profile = new UserProfile();
                profile.Name = Faker.Name.FullName(Faker.NameFormats.WithPrefix);
                profile.Area = $"{Faker.Address.Country()} , {Faker.Address.City()}";
                profile.GovernmentId = Faker.Identification.UKNationalInsuranceNumber();
                profile.Followers = Faker.RandomNumber.Next(0,1000);
                profile.Biography = String.Join("",Faker.Lorem.Sentences(3));
                listOfProfiles.Add(profile);
            }

            return listOfProfiles;
        }
    }
}
