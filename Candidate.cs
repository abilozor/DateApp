using DateApp;
using System;
using System.Xml.Serialization;

namespace DatingBureau
{
    [Serializable]
    public class Candidate : Person, IComparable<Candidate>, IProfile
    {
        public static int nextRegistrationNumber { get; internal set; } = 1;

        public int RegistrationNumber { get; internal set; }
        public DateTime RegistrationDate { get; internal set; }
        public double Height { get; internal set; }
        public string Gender { get; internal set; }
        public string SelfDescription { get; internal set; }
        public string PartnerRequirements { get; internal set; }
        public bool HasChildren { get; internal set; }
        public int NumberOfChildren { get; internal set; }
        public string Religion { get; internal set; }
        public string Ethnicity { get; internal set; }


        string IProfile.SelfDescription => SelfDescription;
        string IProfile.PartnerRequirements => PartnerRequirements;


        [XmlIgnore]
        public int Age
        {
            get
            {
                int age = DateTime.Now.Year - DateOfBirth.Year;
                if (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear)
                    age--;
                return age;
            }
        }

        public Candidate() : base()
        {
        }

        public Candidate(double height, string gender, string firstName, string lastName, DateTime dateOfBirth, string location,
            string selfDescription, string partnerRequirements, bool hasChildren, int numberOfChildren, string religion, string ethnicity)
            : base(firstName, lastName, dateOfBirth, location)
        {
            this.RegistrationNumber = nextRegistrationNumber++;
            this.RegistrationDate = DateTime.Now;
            this.Height = height;
            this.Gender = gender;
            this.SelfDescription = selfDescription;
            this.PartnerRequirements = partnerRequirements;
            this.HasChildren = hasChildren;
            this.NumberOfChildren = numberOfChildren;
            this.Religion = religion;
            this.Ethnicity = ethnicity;
        }

        public Candidate(int registrationNumber, DateTime registrationDate, double height, string gender, string firstName, string lastName,
            DateTime dateOfBirth, string location, string selfDescription, string partnerRequirements, bool hasChildren, int numberOfChildren,
            string religion, string ethnicity)
            : base(firstName, lastName, dateOfBirth, location)
        {
            this.RegistrationNumber = registrationNumber;
            this.RegistrationDate = registrationDate;
            this.Height = height;
            this.Gender = gender;
            this.SelfDescription = selfDescription;
            this.PartnerRequirements = partnerRequirements;
            this.HasChildren = hasChildren;
            this.NumberOfChildren = numberOfChildren;
            this.Religion = religion;
            this.Ethnicity = ethnicity;

            if (registrationNumber >= nextRegistrationNumber)
            {
                nextRegistrationNumber = registrationNumber + 1;
            }
        }

        public int CompareTo(Candidate other)
        {
            if (other == null) return 1;
            // Сортуємо за прізвищем
            return this.LastName.CompareTo(other.LastName);
        }

        public override string GetInfo()
        {
            return GetBasicInfo() + $", Стать: {Gender}, Зріст: {Height} см";
        }



        public virtual double CalculateCompatibilityScore(Candidate otherCandidate)
        {
            double score = 0;

            // Критерій: Різниця у віці (чим менша, тим краще)
            int ageDifference = Math.Abs(this.Age - otherCandidate.Age);
            score += (100 - ageDifference); // Максимальний бал 100

            // Критерій: Однакова локація
            if (this.Location.Equals(otherCandidate.Location, StringComparison.OrdinalIgnoreCase))
                score += 20;

            // Критерій: Однакова релігія
            if (this.Religion.Equals(otherCandidate.Religion, StringComparison.OrdinalIgnoreCase))
                score += 10;

            // Критерій: Однакова етнічність
            if (this.Ethnicity.Equals(otherCandidate.Ethnicity, StringComparison.OrdinalIgnoreCase))
                score += 5;

            // Можна додати більше критеріїв...

            return score;
        }

    }
}
