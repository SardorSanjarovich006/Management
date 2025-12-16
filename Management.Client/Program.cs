using Management.Aplication.Services;
using Management.Domain.Models;

namespace Management.Client
{
    public class Program
    {
        static void Main(string[] args)
        {
           var studentService = new StudentService();
            studentService.AddStudent("Sardor", "Jonimqulov");
            studentService.AddStudent("Eldorbek", "Ro'ziyev");





            Student[] students = studentService.GetAllStudents();
            foreach (var student in students)
            {
                if (student != null)
                {
                    Console.WriteLine($"Student:{student.Id} {student.FirstName} {student.LastName}");
                }
                else
                {
                    break;
                }
            }



        }
    }
}
