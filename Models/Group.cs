using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27.Models
{
    internal class Group
    {
        Student[] _students = new Student[0];

        public Student this[string index]
        {
            get
            {
                foreach (Student student in _students)
                {
                    if (student.FinCode == index.ToUpper())
                    {
                        return student;
                    }
                }
                return null;
            }
        }
        public void AddStudent(Student newstudent)
        {
            Array.Resize(ref _students, _students.Length + 1);
            _students[_students.Length - 1] = newstudent;
        }
        Books[] _books = new Books[0];
        public void AddBook(Books newbook)
        {
            Array.Resize(ref _books, _books.Length + 1);
            _books[_books.Length - 1] = newbook;
        }
        public Books this[int id]
        {
            get
            {
                foreach (Books book in _books)
                {
                    if (book.Id ==id)
                    {
                        return book;
                    }
                }
                return null;
            }
        }
    }
}
