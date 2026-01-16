using Dars5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dars5.Services;

public class CountryServices : ICountryServices
{
    List<Country> Countrys;
    public CountryServices()
    {
        Countrys = new List<Country>();
    }
    public Guid AddCountry(Country country)
    {

        country.CountryId = Guid.NewGuid();
        Countrys.Add(country);
        return country.CountryId;
       
    }

    public bool DeleteCountry(Guid countryId)
    {
       foreach (var country in Countrys)
        {
            if (country.CountryId == countryId)
            {
                Countrys.Remove(country);
                return true;
            }
        }
        return false;
    }

    public List<Country> GetCountries()
    {
        return Countrys;
    }

    public Country? GetCountryById(Guid countryId)
    {
       foreach (var country in Countrys)
        {
            if (country.CountryId == countryId)
            {
                return country;
            }
        }
       return null;
    }

    public bool UpdateCountry(Country acountry)
    {
       foreach (var country in Countrys)
        {
            if (country.CountryId == country.CountryId)
            {
                country.FirstName = acountry.FirstName;
                country.LastName = acountry.LastName;
                country.CountryId = country.CountryId;
                country.DateOfBirth = country.DateOfBirth;

            }
            return true;

        }
        return false;
    }
}
