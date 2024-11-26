using System;

namespace DatingBureau
{
    [Serializable]
    public class VIPCandidate : Candidate
    {
        public string VIPStatus { get; set; }

        public VIPCandidate() : base()
        {
        }



        public VIPCandidate(double height, string gender, string firstName, string lastName, DateTime dateOfBirth, string location,
            string selfDescription, string partnerRequirements, bool hasChildren, int numberOfChildren, string religion, string ethnicity, string vipStatus)
            : base(height, gender, firstName, lastName, dateOfBirth, location,
            selfDescription, partnerRequirements, hasChildren, numberOfChildren, religion, ethnicity)
        {
            this.VIPStatus = vipStatus;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $", VIP Статус: {VIPStatus}";
        }

        public override double CalculateCompatibilityScore(Candidate otherCandidate)
        {
            // VIP кандидати отримують додаткові бали
            double vipBonus = 30;

            // Викликаємо базовий метод для обчислення основного бала
            double baseScore = base.CalculateCompatibilityScore(otherCandidate);

            return baseScore + vipBonus;
        }

    }


}