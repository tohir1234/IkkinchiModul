using CRUD.Models;


namespace CRUD.Services
{
    public class SchoolService
    {
        private List<School> Schools = new List<School>();

        public Guid AddSchool(School school)
        {
            school.SchoolId = Guid.NewGuid();
            school.Created = DateTime.UtcNow;
            Schools.Add(school);
            return school.SchoolId;
        }

        public Guid DeleteSchool(Guid schoolId)
        {
            School school = null;

            foreach (var c in Schools)
            {
                if (c.SchoolId == schoolId)
                {
                    school = c;
                    break;
                }
            }

            if (school != null)
            {
                Schools.Remove(school);
                return schoolId;
            }

            return Guid.Empty;
        }


        public List<School> GetAllSchools()
        {
            return new List<School>(Schools);
        }

        public void UpdateSchool(School updatedSchool)
        {
            School existingSchool = null;

            foreach (var c in Schools)
            {
                if (c.SchoolId == updatedSchool.SchoolId)
                {
                    existingSchool = c;
                    break;
                }
            }

            if (existingSchool != null)
            {
                existingSchool.SchoolName = updatedSchool.SchoolName;
                existingSchool.SchoolDescription = updatedSchool.SchoolDescription;
                existingSchool.Capacity = updatedSchool.Capacity;
                existingSchool.Points = updatedSchool.Points;
                existingSchool.Rooms = updatedSchool.Rooms;
                existingSchool.Number = updatedSchool.Number;
                existingSchool.CurrentStudents = updatedSchool.CurrentStudents;
                existingSchool.Created = updatedSchool.Created;
                existingSchool.UpdatedAt = DateTime.UtcNow;

            }
        }

        public School GetById(Guid schoolId)
        {
            foreach (var c in Schools)
            {
                if (c.SchoolId == schoolId)
                {
                    return c;
                }
            }

            return null;
        }




    }
}
