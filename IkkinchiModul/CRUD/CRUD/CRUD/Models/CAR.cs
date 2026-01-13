using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public class Car
    {
        public Guid CarId { get; set; }
        public string CarName { get; set; }
        public string CarDescription { get; set; }
        public string CarColor { get; set; }
        public string CarBrand { get; set; }
        public int CarPrice {  get; set; }
        public int CarSpeed { get; set; }
        public DateTime Created {  get; set; }
        public DateTime? UpdatedAd { get; set; }

    }
}
