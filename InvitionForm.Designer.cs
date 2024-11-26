// File: InvitationForm.Designer.cs

namespace DatingBureau
{
    partial class InvitationForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblMessage;

        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtMessage;

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTo = new System.Windows.Forms.Label() { Text = "До:", Location = new System.Drawing.Point(12, 15) };
            this.lblFrom = new System.Windows.Forms.Label() { Text = "Від:", Location = new System.Drawing.Point(12, 45) };
            this.lblMessage = new System.Windows.Forms.Label() { Text = "Повідомлення:", Location = new System.Drawing.Point(12, 75) };

            this.txtTo = new System.Windows.Forms.TextBox() { Location = new System.Drawing.Point(150, 12), Width = 120 };
            this.txtFrom = new System.Windows.Forms.TextBox() { Location = new System.Drawing.Point(150, 42), Width = 120 };
            this.txtMessage = new System.Windows.Forms.TextBox() { Location = new System.Drawing.Point(15, 100), Width = 315, Height = 150, Multiline = true };

            this.btnSend = new System.Windows.Forms.Button() { Text = "Надіслати", Location = new System.Drawing.Point(80, 260) };
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);

            this.btnCancel = new System.Windows.Forms.Button() { Text = "Скасувати", Location = new System.Drawing.Point(170, 260) };
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.ClientSize = new System.Drawing.Size(350, 300);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnCancel);
            this.Name = "InvitationForm";
            this.Text = "Надіслати запрошення";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}