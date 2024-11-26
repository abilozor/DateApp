// File: ArchiveForm.cs

using DateApp;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DatingBureau
{
    public partial class ArchiveForm : Form
    {
        private List<Tuple<Candidate, Candidate, DateTime>> archive;

        public ArchiveForm(List<Tuple<Candidate, Candidate, DateTime>> archiveData)
        {
            InitializeComponent();
            this.archive = archiveData;
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            dgvArchive.Rows.Clear();

            foreach (var pair in archive)
            {
                int rowIndex = dgvArchive.Rows.Add();
                DataGridViewRow row = dgvArchive.Rows[rowIndex];
                row.Cells["Candidate1"].Value = $"Олексадр Рудик";
                row.Cells["Candidate2"].Value = $"{pair.Item2.FirstName} {pair.Item2.LastName}";
                row.Cells["DateMatched"].Value = pair.Item3.ToShortDateString();
            }
        }
    }
}