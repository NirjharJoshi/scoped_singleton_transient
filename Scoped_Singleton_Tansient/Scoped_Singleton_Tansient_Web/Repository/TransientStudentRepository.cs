using Scoped_Singleton_Tansient_Web.Models;
using Scoped_Singleton_Tansient_Web.Repository.IRepository;

namespace Scoped_Singleton_Tansient_Web.Repository
{
    public class TransientStudentRepository : ITransientStudentRepository
    {
        public List<Student> Students { get; set; }

        public TransientStudentRepository()
        {
            Students = new List<Student>()
            {
                new Student(){ RollNumber = 1, Class = 5, Section = "A", Name = "Darshan"  },
                new Student(){ RollNumber = 2, Class = 5, Section = "A", Name = "Sinat" },
                new Student(){ RollNumber = 3, Class = 5, Section = "A", Name = "Rehaan" },
                new Student(){ RollNumber = 4, Class = 5, Section = "A", Name = "Manan" },
                new Student(){ RollNumber = 5, Class = 5, Section = "A", Name = "Jannat" },
            };
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
            return;
        }

        public int TotalStudent()
        {
            return Students.Count;
        }
    }
}
