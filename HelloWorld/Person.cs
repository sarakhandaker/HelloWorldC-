using System;
namespace HelloWorld
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        private DateTime _birthdate;

        public void Introduce()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }

        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _birthdate;
        }
    }
}
