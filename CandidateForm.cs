// File: CandidateForm.cs

using System;
using System.Windows.Forms;

namespace DatingBureau
{
    public partial class CandidateForm : Form
    {
        public Candidate Candidate { get; set; }

        public CandidateForm()
        {
            InitializeComponent();
        }

        // Overloaded constructor for editing
        public CandidateForm(Candidate candidate) : this()
        {
            Candidate = candidate;
            PopulateFields();
        }

        private void PopulateFields()
        {
            txtFirstName.Text = Candidate.FirstName;
            txtLastName.Text = Candidate.LastName;
            dtpDateOfBirth.Value = Candidate.DateOfBirth;
            cmbGender.SelectedItem = Candidate.Gender;
            txtLocation.Text = Candidate.Location;
            txtSelfDescription.Text = Candidate.SelfDescription;
            txtPartnerRequirements.Text = Candidate.PartnerRequirements;
            chkHasChildren.Checked = Candidate.HasChildren;
            numChildren.Value = Candidate.NumberOfChildren;
            txtReligion.Text = Candidate.Religion;
            txtEthnicity.Text = Candidate.Ethnicity;
            numHeight.Value = (decimal)Candidate.Height;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Candidate == null)
                Candidate = new Candidate();

            Candidate.FirstName = txtFirstName.Text;
            Candidate.LastName = txtLastName.Text;
            Candidate.DateOfBirth = dtpDateOfBirth.Value;
            Candidate.Gender = cmbGender.SelectedItem?.ToString();
            Candidate.Location = txtLocation.Text;
            Candidate.SelfDescription = txtSelfDescription.Text;
            Candidate.PartnerRequirements = txtPartnerRequirements.Text;
            Candidate.HasChildren = chkHasChildren.Checked;
            Candidate.NumberOfChildren = (int)numChildren.Value;
            Candidate.Religion = txtReligion.Text;
            Candidate.Ethnicity = txtEthnicity.Text;
            Candidate.Height = (double)numHeight.Value;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}