using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public class School
    {
        public Guid SchoolId { get; set; }
        public string SchoolName { get; set; }

        public string SchoolDescription { get; set; }
        public int Capacity { get; set; }
        public int Points { get; set; }
        public int Rooms { get; set; }
        public int Number {  get; set; }
        public int CurrentStudents { get; set; }
        public DateTime Created { get; set; }
        public DateTime? UpdatedAt { get; set; }





    }
}
