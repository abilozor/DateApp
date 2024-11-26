// File: CandidateForm.Designer.cs

namespace DatingBureau
{
    partial class CandidateForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblHasChildren;
        private System.Windows.Forms.Label lblNumberOfChildren;
        private System.Windows.Forms.Label lblReligion;
        private System.Windows.Forms.Label lblEthnicity;
        private System.Windows.Forms.Label lblSelfDescription;
        private System.Windows.Forms.Label lblPartnerRequirements;

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.CheckBox chkHasChildren;
        private System.Windows.Forms.NumericUpDown numChildren;
        private System.Windows.Forms.TextBox txtReligion;
        private System.Windows.Forms.TextBox txtEthnicity;
        private System.Windows.Forms.TextBox txtSelfDescription;
        private System.Windows.Forms.TextBox txtPartnerRequirements;

        private System.Windows.Forms.Button btnOK;
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
            // Initialize components and set their properties (similar to the PostalDirectoryApp's AddEntryForm)
            // Set control positions, sizes, and event handlers

            // Labels
            lblFirstName = new System.Windows.Forms.Label() { Text = "Ім'я:", Location = new System.Drawing.Point(12, 15) };
            lblLastName = new System.Windows.Forms.Label() { Text = "Прізвище:", Location = new System.Drawing.Point(12, 45) };
            lblDateOfBirth = new System.Windows.Forms.Label() { Text = "Дата народження:", Location = new System.Drawing.Point(12, 75) };
            lblGender = new System.Windows.Forms.Label() { Text = "Стать:", Location = new System.Drawing.Point(12, 105) };
            lblLocation = new System.Windows.Forms.Label() { Text = "Локація:", Location = new System.Drawing.Point(12, 135) };
            lblHeight = new System.Windows.Forms.Label() { Text = "Зріст (см):", Location = new System.Drawing.Point(12, 165) };
            lblHasChildren = new System.Windows.Forms.Label() { Text = "Наявність дітей:", Location = new System.Drawing.Point(12, 195) };
            lblNumberOfChildren = new System.Windows.Forms.Label() { Text = "Кількість дітей:", Location = new System.Drawing.Point(12, 225) };
            lblReligion = new System.Windows.Forms.Label() { Text = "Релігія:", Location = new System.Drawing.Point(12, 255) };
            lblEthnicity = new System.Windows.Forms.Label() { Text = "Етнічність:", Location = new System.Drawing.Point(12, 285) };
            lblSelfDescription = new System.Windows.Forms.Label() { Text = "Про себе:", Location = new System.Drawing.Point(12, 315) };
            lblPartnerRequirements = new System.Windows.Forms.Label() { Text = "Вимоги до партнера:", Location = new System.Drawing.Point(12, 375) };

            // TextBoxes and other inputs
            txtFirstName = new System.Windows.Forms.TextBox() { Location = new System.Drawing.Point(150, 12) };
            txtLastName = new System.Windows.Forms.TextBox() { Location = new System.Drawing.Point(150, 42) };
            dtpDateOfBirth = new System.Windows.Forms.DateTimePicker() { Location = new System.Drawing.Point(150, 72), Format = System.Windows.Forms.DateTimePickerFormat.Short };
            cmbGender = new System.Windows.Forms.ComboBox() { Location = new System.Drawing.Point(150, 102) };
            cmbGender.Items.AddRange(new object[] { "Чоловік", "Жінка" });
            txtLocation = new System.Windows.Forms.TextBox() { Location = new System.Drawing.Point(150, 132) };
            numHeight = new System.Windows.Forms.NumericUpDown() { Location = new System.Drawing.Point(150, 162), Minimum = 100, Maximum = 250 };
            chkHasChildren = new System.Windows.Forms.CheckBox() { Location = new System.Drawing.Point(150, 195) };
            numChildren = new System.Windows.Forms.NumericUpDown() { Location = new System.Drawing.Point(150, 222), Minimum = 0, Maximum = 10 };
            txtReligion = new System.Windows.Forms.TextBox() { Location = new System.Drawing.Point(150, 252) };
            txtEthnicity = new System.Windows.Forms.TextBox() { Location = new System.Drawing.Point(150, 282) };
            txtSelfDescription = new System.Windows.Forms.TextBox() { Location = new System.Drawing.Point(150, 312), Multiline = true, Size = new System.Drawing.Size(200, 50) };
            txtPartnerRequirements = new System.Windows.Forms.TextBox() { Location = new System.Drawing.Point(150, 372), Multiline = true, Size = new System.Drawing.Size(200, 50) };

            // Buttons
            btnOK = new System.Windows.Forms.Button() { Text = "OK", Location = new System.Drawing.Point(150, 430) };
            btnOK.Click += new System.EventHandler(this.btnOK_Click);
            btnCancel = new System.Windows.Forms.Button() { Text = "Скасувати", Location = new System.Drawing.Point(230, 430) };
            btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // Form settings
            this.ClientSize = new System.Drawing.Size(370, 470);
            this.Controls.Add(lblFirstName);
            this.Controls.Add(txtFirstName);
            this.Controls.Add(lblLastName);
            this.Controls.Add(txtLastName);
            this.Controls.Add(lblDateOfBirth);
            this.Controls.Add(dtpDateOfBirth);
            this.Controls.Add(lblGender);
            this.Controls.Add(cmbGender);
            this.Controls.Add(lblLocation);
            this.Controls.Add(txtLocation);
            this.Controls.Add(lblHeight);
            this.Controls.Add(numHeight);
            this.Controls.Add(lblHasChildren);
            this.Controls.Add(chkHasChildren);
            this.Controls.Add(lblNumberOfChildren);
            this.Controls.Add(numChildren);
            this.Controls.Add(lblReligion);
            this.Controls.Add(txtReligion);
            this.Controls.Add(lblEthnicity);
            this.Controls.Add(txtEthnicity);
            this.Controls.Add(lblSelfDescription);
            this.Controls.Add(txtSelfDescription);
            this.Controls.Add(lblPartnerRequirements);
            this.Controls.Add(txtPartnerRequirements);
            this.Controls.Add(btnOK);
            this.Controls.Add(btnCancel);

            this.Name = "CandidateForm";
            this.Text = "Додати/Редагувати кандидата";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
