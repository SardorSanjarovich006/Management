using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Management.Domain.Models;
using Management.Infrastucture.Data;

namespace Management.Aplication.Services
{
    public class StudentService
    { 
        private int index = 0;
        public DbContext DbContext { get; set; }
        public StudentService()
        {
            this.DbContext = new DbContext();
        }
        public void AddStudent(string firstName, string lastName)
        {
            if (index >= DbContext.Students.Length)
                return;

            var newStudent = new Student
            {
                Id = new Random().Next(1,15).ToString(),
                FirstName = firstName,
                LastName = lastName
            };
            this.DbContext.Students[index] = newStudent;
            index++;
        }

        public Student[] GetAllStudents()
        {
            return this.DbContext.Students;
        }

        public int StudentsCapasity()
        {
            return this.DbContext.Students.Length;
        }

        public int GetAvailableSeats()
        {
            return this.DbContext.Students.Length-this.index;
        }
    }
}
