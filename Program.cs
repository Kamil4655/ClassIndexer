using ConsoleApp27.Models;

namespace ConsoleApp27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Kamil","Qehremanov","6k8l2c3");
            Student student2 = new Student("Anar","Amanli","1sa2da5");

            Group group = new Group();
            //group.AddStudent(student1);
            //group.AddStudent(student2);


            //Student student = group["6k8l2c3"];

            //if (student == null)
            //{
            //    throw new Exception("Student was not found");
            //}
            //else
            //{
            //    Console.WriteLine(student.Name+" "+student.Surname);
            //}

            Books newBookOne = new Books("Pavillon", "Qarib Chan In");
            Books newBookTwo = new Books("Fall In Love", "Bethowen");

            group.AddBook(newBookOne);
            group.AddBook(newBookTwo);

            Books book = group[1];
            Console.WriteLine(book.Name+" "+book.Id);

            
        }
    }
}