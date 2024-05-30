namespace Exercise3.Exercise301
{
    public class Person
    {
        private int _age;
        private string _fname;
        private string _lname;
        private int _height;
        private int _weight;

        // Se till att hantera undantagen i Program-klassen med en try-catch block.
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Age cannot be under one", nameof(value));
                }
                _age = value;
            }
        }

        public string FName
        {
            get
            {
                return _fname;
            }
            set
            {
                if (value.Length < 2 || value.Length > 10)
                {
                    throw new ArgumentException("fname is either too short or too long." +
                    " It cannot be shorter than two characters or longer than ten.",
                    nameof(value));
                }
                _fname = value;
            }
        }

        public string LName
        {
            get
            {
                return _lname;
            }
            set
            {
                if (value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentException("lname is either too short or too long." +
                        " It cannot be shorter than three characters or longer than 15.",
                        nameof(value));
                }
                _lname = value;
            }
        }

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }

        public int Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                _weight = value;
            }
        }

        public Person(int age, string fName, string lName, int height, int weight)
        {
            Age = age;
            FName = fName;
            LName = lName;
            _height = height;
            _weight = weight;
        }
    }
}
