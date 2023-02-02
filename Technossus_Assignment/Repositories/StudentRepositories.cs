using Technossus_Assignment.Data;
using Technossus_Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Technossus_Assignment.Repositories
{
    public class StudentRepositories : IStudentRepositories
    {
        private readonly ApplicationDbContext db;
        public StudentRepositories(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int AddStudent(Student stud)
        {
            db.Student.Add(stud);
            int res = db.SaveChanges();
            return res;
        }

        public int DeleteStudent(int id)
        {
            int res = 0;
            var s = db.Student.Where(x => x.Id == id).FirstOrDefault();
            if (s != null)
            {
                s.IsActive = 0;
                res = db.SaveChanges();

            }
            return res;
        }

        public List<Student> GetAllStudents()
        {
            var model = (from s in db.Student
                         where s.IsActive == 1
                         select s).ToList();

            return model;
        }

        public Student GetStudentById(int id)
        {
            var s = db.Student.Where(x => x.Id == id).FirstOrDefault();
            return s;
        }

        public int UpdateStudent(Student stud)
        {
            int res = 0;
            var s = db.Student.Where(x => x.Id == stud.Id).FirstOrDefault();
            if (s != null)
            {
                s.Student_Father_Name = stud.Student_Father_Name;
                s.Student_Mother_Name = stud.Student_Mother_Name;
                s.Student_Name = s.Student_Name;
                s.HomeAddress = stud.HomeAddress;
                s.registrationdate = stud.registrationdate;
                s.Password = stud.Password;
                s.Age = stud.Age;
                s.IsActive = 1;
                res = db.SaveChanges();

            }
            return res;
        }
     }
  }

