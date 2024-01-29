// See https://aka.ms/new-console-template for more information
using epita_dummy_data_with_faker.Models;
using epita_dummy_data_with_faker.Services;

//Console.WriteLine("Dummy Data with Faker");
//UserProfile up = new UserProfile();
//Console.WriteLine(up.ToString());

List<UserProfile> users = GenerateUserProfiles.Profiles();
foreach (UserProfile profile in users)
{
    Console.WriteLine(profile.ToString());
}
