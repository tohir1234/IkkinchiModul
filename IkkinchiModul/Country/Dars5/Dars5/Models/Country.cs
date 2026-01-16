using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dars5.Models
{
    public  class Country
    {

        public Guid CountryId { get; set; }
        public string FirstName { get; set; }
        public string Year { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }


    }
}
