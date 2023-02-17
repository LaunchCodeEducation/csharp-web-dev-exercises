using System;
namespace Classes_Part_2
{
	public class Teacher
	{
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }
        public int YearsTeaching { get; set; }

        public Teacher(string firstName, string lastName, string subject, int yearsTeaching)
        {
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
            YearsTeaching = yearsTeaching;
        }
    }
}

