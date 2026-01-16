using Dars5.Models;
using Dars5.Services;

namespace Dars5;

internal class Program
{
    static void Main(string[] args)
    {
        //ICountryServices countryServices= new CountryServices();
        //Country country = new Country()
        //{
        //    FirstName = "John",
        //    LastName = "Doe",
        //    DateOfBirth = new DateTime(2000,4,4)

        //};

        //Guid countryId=countryServices.AddCountry(country);

        //Console.WriteLine($"Country ID : {countryId}");
        //Console.WriteLine($"Country ID : {}");


        IBlackBoardServices  blackboardServices = new BlackBoardServices();
        BlackBoard blackboard = new BlackBoard()
        {
            Color = "Black",
            Widht = 2.50,
            Height = 1.80,
            Weight = 8,
            Type = "simple",
            Price = 200000,
        };

        Guid blackboardId = blackboardServices.AddBlackBoard(blackboard);
    }
}
