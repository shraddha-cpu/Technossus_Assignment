using Technossus_Assignment.Models;

namespace Technossus_Assignment.Repositories
{
    public interface IStudentRepositories
    {
        List<Student> GetAllStudents();
        Student GetStudentById(int id);
        int AddStudent(Student stud);
        int UpdateStudent(Student stud);
        int DeleteStudent(int id);
    }
}
