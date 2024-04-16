namespace ConsoleApp27.Models
{
    internal class Student
    {
        string _finCode;
        string _name;
        string _surname;



        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length > 3 && value.Length < 25)
                {
                    _name = value;
                }
            }
        }
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (value.Length > 3 && value.Length < 25)
                {
                    _surname = value;
                }
            }
        }
        public string FinCode
        {
            get { return _finCode; }
            set
            {

                if (value.Length == 7)
                {
                    _finCode = value.ToUpper();
                }

            }
        }
        public Student( string name, string surname, string fin)
        {
            FinCode = fin;
            Name = name;
            Surname = surname;
        }

    }

    internal class Books
    {
        int _id;
        string _name;
        string _autdor;
        static int count=0;

        public int Id { get; set; }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }
        public string Authot
        {
            get { return _autdor; }
            set
            {
                _autdor= value;
            }
        }
        public Books(string name,string author)
        {
            Name= name;
            Authot= author;
            count++;
            Id = count;
        }

    }
}
