namespace DatingBureau
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        // Оголошення контролів
        private System.Windows.Forms.DataGridView dgvCandidates;
        private System.Windows.Forms.Button btnAddCandidate;
        private System.Windows.Forms.Button btnEditCandidate;
        private System.Windows.Forms.Button btnDeleteCandidate;
        private System.Windows.Forms.Button btnClearCandidates;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSaveAsXML;
        private System.Windows.Forms.Button btnOpenFromXML;
        private System.Windows.Forms.Button btnSaveAsText;
        private System.Windows.Forms.Button btnOpenFromText;
        private System.Windows.Forms.Button btnSelectCandidates;
        private System.Windows.Forms.Button btnViewArchive;
        private System.Windows.Forms.Button btnCalculateCompatibility; // Нова кнопка

        private System.Windows.Forms.ComboBox cmbSearchGender;
        private System.Windows.Forms.NumericUpDown numSearchAgeFrom;
        private System.Windows.Forms.NumericUpDown numSearchAgeTo;
        private System.Windows.Forms.CheckBox chkSearchHasChildren;

        private System.Windows.Forms.DataGridView dgvSearchResults;

        private System.Windows.Forms.Label lblSearchGender;
        private System.Windows.Forms.Label lblSearchAgeRange;
        private System.Windows.Forms.Label lblSearchHasChildren;

        private System.Windows.Forms.Button btnSearchCandidates;
        private System.Windows.Forms.Button btnInviteCandidate;

        /// <summary>
        ///  Очищення ресурсів, які використовуються.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            // Код очищення...
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, створений конструктором форм Windows

        private void InitializeComponent()
        {
            this.dgvCandidates = new System.Windows.Forms.DataGridView();
            this.btnAddCandidate = new System.Windows.Forms.Button();
            this.btnEditCandidate = new System.Windows.Forms.Button();
            this.btnDeleteCandidate = new System.Windows.Forms.Button();
            this.btnClearCandidates = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSaveAsXML = new System.Windows.Forms.Button();
            this.btnOpenFromXML = new System.Windows.Forms.Button();
            this.btnSaveAsText = new System.Windows.Forms.Button();
            this.btnOpenFromText = new System.Windows.Forms.Button();
            this.btnSelectCandidates = new System.Windows.Forms.Button();
            this.btnViewArchive = new System.Windows.Forms.Button();
            this.btnCalculateCompatibility = new System.Windows.Forms.Button();
            this.cmbSearchGender = new System.Windows.Forms.ComboBox();
            this.numSearchAgeFrom = new System.Windows.Forms.NumericUpDown();
            this.numSearchAgeTo = new System.Windows.Forms.NumericUpDown();
            this.chkSearchHasChildren = new System.Windows.Forms.CheckBox();
            this.lblSearchGender = new System.Windows.Forms.Label();
            this.lblSearchAgeRange = new System.Windows.Forms.Label();
            this.lblSearchHasChildren = new System.Windows.Forms.Label();
            this.btnSearchCandidates = new System.Windows.Forms.Button();
            this.btnInviteCandidate = new System.Windows.Forms.Button();
            this.dgvSearchResults = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSearchAgeFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSearchAgeTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCandidates
            // 
            this.dgvCandidates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidates.Location = new System.Drawing.Point(12, 12);
            this.dgvCandidates.Name = "dgvCandidates";
            this.dgvCandidates.ReadOnly = true;
            this.dgvCandidates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCandidates.Size = new System.Drawing.Size(760, 200);
            this.dgvCandidates.TabIndex = 0;
            // 
            // btnAddCandidate
            // 
            this.btnAddCandidate.Location = new System.Drawing.Point(12, 220);
            this.btnAddCandidate.Name = "btnAddCandidate";
            this.btnAddCandidate.Size = new System.Drawing.Size(90, 23);
            this.btnAddCandidate.TabIndex = 1;
            this.btnAddCandidate.Text = "Додати";
            this.btnAddCandidate.UseVisualStyleBackColor = true;
            this.btnAddCandidate.Click += new System.EventHandler(this.btnAddCandidate_Click);
            // 
            // btnEditCandidate
            // 
            this.btnEditCandidate.Location = new System.Drawing.Point(108, 220);
            this.btnEditCandidate.Name = "btnEditCandidate";
            this.btnEditCandidate.Size = new System.Drawing.Size(90, 23);
            this.btnEditCandidate.TabIndex = 2;
            this.btnEditCandidate.Text = "Редагувати";
            this.btnEditCandidate.UseVisualStyleBackColor = true;
            this.btnEditCandidate.Click += new System.EventHandler(this.btnEditCandidate_Click);
            // 
            // btnDeleteCandidate
            // 
            this.btnDeleteCandidate.Location = new System.Drawing.Point(204, 220);
            this.btnDeleteCandidate.Name = "btnDeleteCandidate";
            this.btnDeleteCandidate.Size = new System.Drawing.Size(90, 23);
            this.btnDeleteCandidate.TabIndex = 3;
            this.btnDeleteCandidate.Text = "Видалити";
            this.btnDeleteCandidate.UseVisualStyleBackColor = true;
            this.btnDeleteCandidate.Click += new System.EventHandler(this.btnDeleteCandidate_Click);
            // 
            // btnClearCandidates
            // 
            this.btnClearCandidates.Location = new System.Drawing.Point(300, 220);
            this.btnClearCandidates.Name = "btnClearCandidates";
            this.btnClearCandidates.Size = new System.Drawing.Size(90, 23);
            this.btnClearCandidates.TabIndex = 4;
            this.btnClearCandidates.Text = "Очистити";
            this.btnClearCandidates.UseVisualStyleBackColor = true;
            this.btnClearCandidates.Click += new System.EventHandler(this.btnClearCandidates_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(396, 220);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Вихід";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSaveAsXML
            // 
            this.btnSaveAsXML.Location = new System.Drawing.Point(0, 0);
            this.btnSaveAsXML.Name = "btnSaveAsXML";
            this.btnSaveAsXML.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAsXML.TabIndex = 6;
            // 
            // btnOpenFromXML
            // 
            this.btnOpenFromXML.Location = new System.Drawing.Point(0, 0);
            this.btnOpenFromXML.Name = "btnOpenFromXML";
            this.btnOpenFromXML.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFromXML.TabIndex = 7;
            // 
            // btnSaveAsText
            // 
            this.btnSaveAsText.Location = new System.Drawing.Point(492, 220);
            this.btnSaveAsText.Name = "btnSaveAsText";
            this.btnSaveAsText.Size = new System.Drawing.Size(130, 23);
            this.btnSaveAsText.TabIndex = 8;
            this.btnSaveAsText.Text = "Зберегти як Текст";
            this.btnSaveAsText.UseVisualStyleBackColor = true;
            this.btnSaveAsText.Click += new System.EventHandler(this.btnSaveAsText_Click);
            // 
            // btnOpenFromText
            // 
            this.btnOpenFromText.Location = new System.Drawing.Point(632, 220);
            this.btnOpenFromText.Name = "btnOpenFromText";
            this.btnOpenFromText.Size = new System.Drawing.Size(140, 23);
            this.btnOpenFromText.TabIndex = 9;
            this.btnOpenFromText.Text = "Відкрити з Тексту";
            this.btnOpenFromText.UseVisualStyleBackColor = true;
            this.btnOpenFromText.Click += new System.EventHandler(this.btnOpenFromText_Click);
            // 
            // btnSelectCandidates
            // 
            this.btnSelectCandidates.Location = new System.Drawing.Point(12, 249);
            this.btnSelectCandidates.Name = "btnSelectCandidates";
            this.btnSelectCandidates.Size = new System.Drawing.Size(90, 23);
            this.btnSelectCandidates.TabIndex = 10;
            this.btnSelectCandidates.Text = "Вибір";
            this.btnSelectCandidates.UseVisualStyleBackColor = true;
            this.btnSelectCandidates.Click += new System.EventHandler(this.btnSelectCandidates_Click);
            // 
            // btnViewArchive
            // 
            this.btnViewArchive.Location = new System.Drawing.Point(108, 381);
            this.btnViewArchive.Name = "btnViewArchive";
            this.btnViewArchive.Size = new System.Drawing.Size(90, 23);
            this.btnViewArchive.TabIndex = 11;
            this.btnViewArchive.Text = "Архів";
            this.btnViewArchive.UseVisualStyleBackColor = true;
            this.btnViewArchive.Click += new System.EventHandler(this.btnViewArchive_Click);
            // 
            // btnCalculateCompatibility
            // 
            this.btnCalculateCompatibility.Location = new System.Drawing.Point(114, 249);
            this.btnCalculateCompatibility.Name = "btnCalculateCompatibility";
            this.btnCalculateCompatibility.Size = new System.Drawing.Size(180, 23);
            this.btnCalculateCompatibility.TabIndex = 15;
            this.btnCalculateCompatibility.Text = "Обчислити сумісність";
            this.btnCalculateCompatibility.UseVisualStyleBackColor = true;
            this.btnCalculateCompatibility.Click += new System.EventHandler(this.btnCalculateCompatibility_Click);
            // 
            // cmbSearchGender
            // 
            this.cmbSearchGender.Items.AddRange(new object[] {
            "Чоловік",
            "Жінка"});
            this.cmbSearchGender.Location = new System.Drawing.Point(120, 280);
            this.cmbSearchGender.Name = "cmbSearchGender";
            this.cmbSearchGender.Size = new System.Drawing.Size(150, 21);
            this.cmbSearchGender.TabIndex = 17;
            // 
            // numSearchAgeFrom
            // 
            this.numSearchAgeFrom.Location = new System.Drawing.Point(120, 320);
            this.numSearchAgeFrom.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numSearchAgeFrom.Name = "numSearchAgeFrom";
            this.numSearchAgeFrom.Size = new System.Drawing.Size(60, 20);
            this.numSearchAgeFrom.TabIndex = 19;
            this.numSearchAgeFrom.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // numSearchAgeTo
            // 
            this.numSearchAgeTo.Location = new System.Drawing.Point(210, 320);
            this.numSearchAgeTo.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numSearchAgeTo.Name = "numSearchAgeTo";
            this.numSearchAgeTo.Size = new System.Drawing.Size(60, 20);
            this.numSearchAgeTo.TabIndex = 20;
            this.numSearchAgeTo.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // chkSearchHasChildren
            // 
            this.chkSearchHasChildren.Location = new System.Drawing.Point(120, 350);
            this.chkSearchHasChildren.Name = "chkSearchHasChildren";
            this.chkSearchHasChildren.Size = new System.Drawing.Size(150, 24);
            this.chkSearchHasChildren.TabIndex = 22;
            this.chkSearchHasChildren.Text = "Так";
            this.chkSearchHasChildren.UseVisualStyleBackColor = true;
            // 
            // lblSearchGender
            // 
            this.lblSearchGender.Location = new System.Drawing.Point(14, 283);
            this.lblSearchGender.Name = "lblSearchGender";
            this.lblSearchGender.Size = new System.Drawing.Size(100, 23);
            this.lblSearchGender.TabIndex = 16;
            this.lblSearchGender.Text = "Стать:";
            // 
            // lblSearchAgeRange
            // 
            this.lblSearchAgeRange.Location = new System.Drawing.Point(14, 320);
            this.lblSearchAgeRange.Name = "lblSearchAgeRange";
            this.lblSearchAgeRange.Size = new System.Drawing.Size(100, 23);
            this.lblSearchAgeRange.TabIndex = 18;
            this.lblSearchAgeRange.Text = "Віковий діапазон:";
            // 
            // lblSearchHasChildren
            // 
            this.lblSearchHasChildren.Location = new System.Drawing.Point(12, 350);
            this.lblSearchHasChildren.Name = "lblSearchHasChildren";
            this.lblSearchHasChildren.Size = new System.Drawing.Size(100, 23);
            this.lblSearchHasChildren.TabIndex = 21;
            this.lblSearchHasChildren.Text = "Наявність дітей:";
            // 
            // btnSearchCandidates
            // 
            this.btnSearchCandidates.Location = new System.Drawing.Point(12, 380);
            this.btnSearchCandidates.Name = "btnSearchCandidates";
            this.btnSearchCandidates.Size = new System.Drawing.Size(90, 23);
            this.btnSearchCandidates.TabIndex = 12;
            this.btnSearchCandidates.Text = "Пошук";
            this.btnSearchCandidates.UseVisualStyleBackColor = true;
            this.btnSearchCandidates.Click += new System.EventHandler(this.btnSearchCandidates_Click);
            // 
            // btnInviteCandidate
            // 
            this.btnInviteCandidate.Location = new System.Drawing.Point(12, 570);
            this.btnInviteCandidate.Name = "btnInviteCandidate";
            this.btnInviteCandidate.Size = new System.Drawing.Size(150, 23);
            this.btnInviteCandidate.TabIndex = 14;
            this.btnInviteCandidate.Text = "Запросити кандидата";
            this.btnInviteCandidate.UseVisualStyleBackColor = true;
            this.btnInviteCandidate.Click += new System.EventHandler(this.btnInviteCandidate_Click);
            // 
            // dgvSearchResults
            // 
            this.dgvSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResults.Location = new System.Drawing.Point(12, 410);
            this.dgvSearchResults.Name = "dgvSearchResults";
            this.dgvSearchResults.ReadOnly = true;
            this.dgvSearchResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearchResults.Size = new System.Drawing.Size(760, 150);
            this.dgvSearchResults.TabIndex = 13;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.dgvCandidates);
            this.Controls.Add(this.btnAddCandidate);
            this.Controls.Add(this.btnEditCandidate);
            this.Controls.Add(this.btnDeleteCandidate);
            this.Controls.Add(this.btnClearCandidates);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSaveAsXML);
            this.Controls.Add(this.btnOpenFromXML);
            this.Controls.Add(this.btnSaveAsText);
            this.Controls.Add(this.btnOpenFromText);
            this.Controls.Add(this.btnSelectCandidates);
            this.Controls.Add(this.btnViewArchive);
            this.Controls.Add(this.btnCalculateCompatibility);
            this.Controls.Add(this.lblSearchGender);
            this.Controls.Add(this.cmbSearchGender);
            this.Controls.Add(this.lblSearchAgeRange);
            this.Controls.Add(this.numSearchAgeFrom);
            this.Controls.Add(this.numSearchAgeTo);
            this.Controls.Add(this.lblSearchHasChildren);
            this.Controls.Add(this.chkSearchHasChildren);
            this.Controls.Add(this.btnSearchCandidates);
            this.Controls.Add(this.dgvSearchResults);
            this.Controls.Add(this.btnInviteCandidate);
            this.Name = "MainForm";
            this.Text = "Бюро знайомств";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSearchAgeFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSearchAgeTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
