// File: ArchiveForm.Designer.cs

namespace DatingBureau
{
    partial class ArchiveForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvArchive;

        protected override void Dispose(bool disposing)
        {
            // Dispose code...
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgvArchive = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchive)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArchive
            // 
            this.dgvArchive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArchive.Columns.Add("Candidate1", "Кандидат 1");
            this.dgvArchive.Columns.Add("Candidate2", "Кандидат 2");
            this.dgvArchive.Columns.Add("DateMatched", "Дата знайомства");
            this.dgvArchive.Location = new System.Drawing.Point(12, 12);
            this.dgvArchive.Name = "dgvArchive";
            this.dgvArchive.Size = new System.Drawing.Size(760, 437);
            this.dgvArchive.TabIndex = 0;
            // 
            // ArchiveForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.dgvArchive);
            this.Name = "ArchiveForm";
            this.Text = "Архів знайомств";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchive)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}