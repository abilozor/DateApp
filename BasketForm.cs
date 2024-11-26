using DateApp;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DatingBureau
{
    public partial class BasketForm : Form
    {
        private List<Candidate> basketCandidates;

        public BasketForm(List<Candidate> basketCandidates)
        {
            InitializeComponent();
            this.basketCandidates = basketCandidates;
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            dgvBasket.DataSource = null;
            dgvBasket.DataSource = basketCandidates;

            // Set column headers and visibility as needed
        }
    }
}