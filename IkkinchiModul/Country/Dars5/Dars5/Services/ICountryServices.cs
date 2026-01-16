using Dars5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dars5.Services
{
    public interface ICountryServices
    {
        public Guid AddCountry(Country country);
        public bool UpdateCountry(Country country);
        public bool DeleteCountry(Guid countryId);
        public Country? GetCountryById(Guid countryId);
        public List<Country> GetCountries();


    }
}
