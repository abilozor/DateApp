// File: Person.cs

using System;

namespace DatingBureau
{
    [Serializable]
    public abstract class Person
    {
        // Properties
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public DateTime DateOfBirth { get; internal set; }
        public string Location { get; internal set; }

        // Default constructor for serialization
        public Person()
        {
        }

        // Constructor
        public Person(string firstName, string lastName, DateTime dateOfBirth, string location)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.Location = location;
        }

        protected string GetBasicInfo()
        {
            return $"{FirstName} {LastName}, народився {DateOfBirth.ToShortDateString()}, локація: {Location}";
        }

        public abstract string GetInfo();

    }
}