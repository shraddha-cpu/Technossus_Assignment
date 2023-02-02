using Technossus_Assignment.Models;
using Technossus_Assignment.Repositories;

namespace Technossus_Assignment.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepositories repo;
        public StudentService(IStudentRepositories repo)
        {
            this.repo = repo;
        }
        public int AddStudent(Student stud)
        {
            stud.IsActive = 1;
            return repo.AddStudent(stud);
        }

        public int DeleteStudent(int id)
        {
            return repo.DeleteStudent(id);
        }

        public List<Student> GetAllStudents()
        {
            return repo.GetAllStudents();
        }

        public Student GetStudentById(int id)
        {
            return repo.GetStudentById(id);
        }

        public int UpdateStudent(Student stud)
        {
            return repo.UpdateStudent(stud);
        }
    }
}
