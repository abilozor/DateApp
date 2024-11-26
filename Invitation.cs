// File: Invitation.cs

using System;

namespace DatingBureau
{
    public class Invitation
    {
        public Candidate From { get; set; }
        public Candidate To { get; set; }
        public DateTime DateSent { get; set; }
        public string Message { get; set; }

        public Invitation(Candidate from, Candidate to, string message)
        {
            From = from;
            To = to;
            DateSent = DateTime.Now;
            Message = message;
        }
    }
}