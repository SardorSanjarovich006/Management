using Management.Aplication.Services;
using Management.Aplication.Services;
using Management.Domain.Models;
using Management.Domain.Models;

namespace Management.Client
{
    public class Program
    {
        private const string LOGIN = "admin123";
        private const string PASSWORD = "sardor123";
        static StudentService studentService = new StudentService();

        static void Main(string[] args)
        {
            Console.WriteLine("'Kabutar' platformasiga xush kelibsiz,iltimos ismingizni kiriting:");
            string Name = Console.ReadLine();
            Console.Write($"Assalomu aleykum {Name}.Shaxsiy profilingizga kirmoqchimisiz ? / ha / yoq : ");
            string text = Console.ReadLine()?.ToLower();

            if (text == "ha")
            {
                int attempts = 0;
                string pasword;
                string login;
                int maxAttempts = 4;

                do
                {
                    if (attempts > 0)
                        Console.WriteLine($"{Name} parolingiz yoki loginingizni xato kirityabsiz, iltimos qaytadan kiriting : {maxAttempts} ta Urunishingiz qoldi :) ");
                    Console.Write("Login: ");
                    login = Console.ReadLine();
                    Console.Write("Parol: ");
                    pasword = Console.ReadLine();
                    attempts++;
                    maxAttempts--;

                    if (attempts > 3)
                    {
                        Console.WriteLine("Urinishlar limiti tugadi. Kirish bloklandi ");
                        return;
                    }

                } while (pasword != PASSWORD || login != LOGIN);

                Console.WriteLine("Profilingizga muvaffaqiyatli kirdingiz!!!");
                ShowStudents();
            }
            else
            {
                Console.WriteLine("Ha,sog' bo'ling!!!)");
                return;
            }
        }
        public static void ShowStudents()
        {
            bool continueWork = true;

            while (continueWork)
            {
                Console.WriteLine("\n Iltimos menyuni tanlang :\n" +
                    "1. Talaba kiritish\n" +
                    "2. O'quvchilar ro'yxati\n" +
                    "3. Qo'sha oladigan o'quvchilar soni");

                Console.Write("Tanlovingiz: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddStudent();
                        break;

                    case "2":
                        PrintAllStudents();
                        break;

                    case "3":
                        PrintStudentCapacity();
                        break;

                    default:
                        Console.WriteLine("Noto'g'ri tanlov.");
                        break;
                }

                continueWork = AskToContinue();
            }

            Console.WriteLine("\nDastur yakunlandi. Xayr salomat bo'ling :)");
        }


        private static void AddStudent()
        {
            Console.WriteLine("Iltimos talabani ismi va familiyasini kiriting :");
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();

            studentService.AddStudent(firstName, lastName);

            Console.WriteLine("Tabriklaymiz :) . Talaba muvaffaqiyatli qo'shildi :)");
        }

        private static void PrintAllStudents()
        {
            Student[] students = studentService.GetAllStudents();
            foreach (var student in students)
            {
                if (student != null)
                {
                    Console.WriteLine($"ID: {student.Id}, Ismi: {student.FirstName}, Familiyasi: {student.LastName}");
                }
            }
        }

        private static void PrintStudentCapacity()
        {
            int availableSeats = studentService.GetAvailableSeats();
            Console.WriteLine($"Qo'sha oladigan o'quvchilar soni: {availableSeats}");
        }

        private static bool AskToContinue()
        {
            Console.Write("\nYana bir amal bajarishni xohlaysizmi? (ha / yo'q): ");
            string answer = Console.ReadLine()?.ToLower();

            return answer == "ha";
        }


    }
}
