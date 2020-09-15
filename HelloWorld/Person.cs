using System;
namespace HelloWorld
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        //private DateTime _birthdate;
        public DateTime Birthdate {get; private set;}
        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }
        public int Age
        {
            get
            {
                var timespan = DateTime.Today - Birthdate;
                var years = timespan.Days / 365;
                return years;
            }
        }

        public void Introduce()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }

        //public void SetBirthdate(DateTime birthdate)
        //{
        //    _birthdate = birthdate;
        //}

        //public DateTime GetBirthdate()
        //{
        //    return _birthdate;
        //}
    }
}
