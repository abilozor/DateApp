// File: Couple.cs

using System;

namespace DatingBureau
{
    public class Couple
    {
        public Candidate Candidate1 { get; set; }
        public Candidate Candidate2 { get; set; }
        public DateTime DateFormed { get; set; }

        public Couple(Candidate candidate1, Candidate candidate2, DateTime dateFormed)
        {
            Candidate1 = candidate1;
            Candidate2 = candidate2;
            DateFormed = dateFormed;
        }
    }
}
