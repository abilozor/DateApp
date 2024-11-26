namespace DatingBureau
{
    partial class BasketForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvBasket;

        protected override void Dispose(bool disposing)
        {
            // Dispose code...
        }

        private void InitializeComponent()
        {
            this.dgvBasket = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBasket)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBasket
            // 
            this.dgvBasket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBasket.Location = new System.Drawing.Point(12, 12);
            this.dgvBasket.Name = "dgvBasket";
            this.dgvBasket.Size = new System.Drawing.Size(760, 437);
            this.dgvBasket.TabIndex = 0;
            // 
            // BasketForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.dgvBasket);
            this.Name = "BasketForm";
            this.Text = "Підходящі кандидатури";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBasket)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
