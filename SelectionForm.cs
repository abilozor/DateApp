// File: SelectionForm.cs

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DatingBureau
{
    public partial class SelectionForm : Form
    {
        private List<Candidate> candidates;
        private List<Candidate> filteredCandidates;

        public SelectionForm(List<Candidate> candidates)
        {
            InitializeComponent();
            this.candidates = candidates;
            filteredCandidates = new List<Candidate>();

            // Make DataGridView read-only
            dgvCandidates.ReadOnly = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string gender = cmbGender.SelectedItem?.ToString();
            int ageFrom = (int)numAgeFrom.Value;
            int ageTo = (int)numAgeTo.Value;
            bool? hasChildren = chkHasChildren.Checked ? true : (bool?)null;

            filteredCandidates.Clear();

            foreach (var candidate in candidates)
            {
                int age = candidate.Age;
                bool matchesGender = string.IsNullOrEmpty(gender) || candidate.Gender.Equals(gender, StringComparison.OrdinalIgnoreCase);
                bool matchesAge = age >= ageFrom && age <= ageTo;
                bool matchesChildren = !hasChildren.HasValue || candidate.HasChildren == hasChildren.Value;

                if (matchesGender && matchesAge && matchesChildren)
                {
                    filteredCandidates.Add(candidate);
                }
            }

            dgvCandidates.DataSource = null;
            dgvCandidates.DataSource = filteredCandidates;

            if (filteredCandidates.Count == 0)
            {
                MessageBox.Show("Немає кандидатів, що відповідають критеріям пошуку.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnInvite_Click(object sender, EventArgs e)
        {
            if (dgvCandidates.CurrentRow != null)
            {
                Candidate selectedCandidate = (Candidate)dgvCandidates.CurrentRow.DataBoundItem;
                InvitationForm invitationForm = new InvitationForm(selectedCandidate);
                invitationForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Оберіть кандидата для запрошення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}