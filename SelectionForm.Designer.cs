// File: SelectionForm.Designer.cs

namespace DatingBureau
{
    partial class SelectionForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblAgeFrom;
        private System.Windows.Forms.Label lblAgeTo;
        private System.Windows.Forms.NumericUpDown numAgeFrom;
        private System.Windows.Forms.NumericUpDown numAgeTo;
        private System.Windows.Forms.CheckBox chkHasChildren;

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnInvite;

        private System.Windows.Forms.DataGridView dgvCandidates;

        protected override void Dispose(bool disposing)
        {
            // Dispose code...
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblGender = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblAgeFrom = new System.Windows.Forms.Label();
            this.numAgeFrom = new System.Windows.Forms.NumericUpDown();
            this.lblAgeTo = new System.Windows.Forms.Label();
            this.numAgeTo = new System.Windows.Forms.NumericUpDown();
            this.chkHasChildren = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnInvite = new System.Windows.Forms.Button();
            this.dgvCandidates = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.numAgeFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAgeTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidates)).BeginInit();

            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(12, 15);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(41, 13);
            this.lblGender.TabIndex = 0;
            this.lblGender.Text = "Стать:";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] { "Чоловік", "Жінка" });
            this.cmbGender.Location = new System.Drawing.Point(80, 12);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(150, 21);
            this.cmbGender.TabIndex = 1;
            // 
            // lblAgeFrom
            // 
            this.lblAgeFrom.AutoSize = true;
            this.lblAgeFrom.Location = new System.Drawing.Point(12, 45);
            this.lblAgeFrom.Name = "lblAgeFrom";
            this.lblAgeFrom.Size = new System.Drawing.Size(38, 13);
            this.lblAgeFrom.TabIndex = 2;
            this.lblAgeFrom.Text = "Вік від:";
            // 
            // numAgeFrom
            // 
            this.numAgeFrom.Location = new System.Drawing.Point(80, 42);
            this.numAgeFrom.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
            this.numAgeFrom.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.numAgeFrom.Value = new decimal(new int[] { 18, 0, 0, 0 });
            this.numAgeFrom.Name = "numAgeFrom";
            this.numAgeFrom.Size = new System.Drawing.Size(60, 20);
            this.numAgeFrom.TabIndex = 2;
            // 
            // lblAgeTo
            // 
            this.lblAgeTo.AutoSize = true;
            this.lblAgeTo.Location = new System.Drawing.Point(160, 45);
            this.lblAgeTo.Name = "lblAgeTo";
            this.lblAgeTo.Size = new System.Drawing.Size(20, 13);
            this.lblAgeTo.TabIndex = 3;
            this.lblAgeTo.Text = "до:";
            // 
            // numAgeTo
            // 
            this.numAgeTo.Location = new System.Drawing.Point(190, 42);
            this.numAgeTo.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
            this.numAgeTo.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.numAgeTo.Value = new decimal(new int[] { 100, 0, 0, 0 });
            this.numAgeTo.Name = "numAgeTo";
            this.numAgeTo.Size = new System.Drawing.Size(60, 20);
            this.numAgeTo.TabIndex = 3;
            // 
            // chkHasChildren
            // 
            this.chkHasChildren.AutoSize = true;
            this.chkHasChildren.Location = new System.Drawing.Point(12, 75);
            this.chkHasChildren.Name = "chkHasChildren";
            this.chkHasChildren.Size = new System.Drawing.Size(115, 17);
            this.chkHasChildren.TabIndex = 4;
            this.chkHasChildren.Text = "Наявність дітей";
            this.chkHasChildren.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 105);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Пошук";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvCandidates
            // 
            this.dgvCandidates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidates.Location = new System.Drawing.Point(12, 135);
            this.dgvCandidates.Name = "dgvCandidates";
            this.dgvCandidates.ReadOnly = true; // Make DataGridView read-only
            this.dgvCandidates.Size = new System.Drawing.Size(760, 300);
            this.dgvCandidates.TabIndex = 6;
            // 
            // btnInvite
            // 
            this.btnInvite.Location = new System.Drawing.Point(12, 445);
            this.btnInvite.Name = "btnInvite";
            this.btnInvite.Size = new System.Drawing.Size(90, 23);
            this.btnInvite.TabIndex = 7;
            this.btnInvite.Text = "Запросити";
            this.btnInvite.UseVisualStyleBackColor = true;
            this.btnInvite.Click += new System.EventHandler(this.btnInvite_Click);
            // 
            // SelectionForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 481);
            this.Controls.Add(this.btnInvite);
            this.Controls.Add(this.dgvCandidates);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.chkHasChildren);
            this.Controls.Add(this.numAgeTo);
            this.Controls.Add(this.lblAgeTo);
            this.Controls.Add(this.numAgeFrom);
            this.Controls.Add(this.lblAgeFrom);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.lblGender);
            this.Name = "SelectionForm";
            this.Text = "Вибір кандидатів";

            ((System.ComponentModel.ISupportInitialize)(this.numAgeFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAgeTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
