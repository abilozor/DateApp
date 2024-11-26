// File: InvitationForm.cs

using System;
using System.Windows.Forms;

namespace DatingBureau
{
    public partial class InvitationForm : Form
    {
        private Candidate candidate;

        public InvitationForm(Candidate candidate)
        {
            InitializeComponent();
            this.candidate = candidate;
            txtTo.Text = $"{candidate.FirstName} {candidate.LastName}";
            txtFrom.Text = "Олександр Рудик";
            txtMessage.Text = GenerateInvitationMessage();
        }

        private string GenerateInvitationMessage()
        {
            // Automatically generate the invitation text
            return $"Dear {candidate.FirstName},\n\n" +
                   $"We are pleased to invite you to meet potential partners that match your preferences.\n" +
                   $"Please contact us to schedule your meeting.\n\n" +
                   $"Best regards,\n" +
                   $"Dating Bureau";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // Logic to send the invitation (e.g., save to a file, update candidate's invitation list)
            MessageBox.Show("Invitation has been sent.");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}