namespace P03_Person
{
    using System;
    using System.Text;

    public class Person
    {
        private const int MinimumYear = 1930;

        private const string IncorrectYearMessage = "Enter valid year!";
        private const string IncorrectFirstNameMessage = "First name cannot be empty!";
        private const string IncorrectLastNameMessage = "Last name cannot be empty!";

        private string _firstName;
        private string _lastName;
        private DateTime _dateOfBirth;

        private Person()
        {
            this.FirstName = "Unknown";
            this.LastName = "Unknown";
            this.DateOfBirth = DateTime.UtcNow;
        }

        public Person(string firstName)
            : this()
        {
            this.FirstName = firstName;
        }

        public Person(string firstName, string lastName)
            : this(firstName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Person(string firstName, string lastName, DateTime dateOfBirth)
            : this(firstName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
        }

        public string FirstName
        {
            get => _firstName;
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(IncorrectFirstNameMessage);
                }

                _firstName = value;
            }
        }

        public string LastName
        {
            get => _lastName;
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(IncorrectLastNameMessage);
                }

                _lastName = value;
            }
        }

        public int Age
            => DateTime.Compare(this.DateOfBirth, DateTime.UtcNow) < 0
            ? DateTime.UtcNow.Year - this.DateOfBirth.Year - 1
            : DateTime.UtcNow.Year - this.DateOfBirth.Year;

        public DateTime DateOfBirth
        {
            get => _dateOfBirth;
            private set
            {
                if (value.Year < MinimumYear && value.Year > DateTime.UtcNow.Year)
                {
                    throw new ArgumentOutOfRangeException(IncorrectYearMessage);
                }

                _dateOfBirth = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb
                .AppendLine($"F: {this.FirstName}")
                .AppendLine($"L: {this.LastName}")
                .AppendLine($"A: {this.Age}")
                .AppendLine($"B: {this.DateOfBirth.ToLongDateString()}");

            return sb.ToString();
        }
    }
}
