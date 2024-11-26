// File: MainForm.cs

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using DateApp;

namespace DatingBureau
{
    public partial class MainForm : Form
    {
        private List<Candidate> candidates;
        private List<Tuple<Candidate, Candidate, DateTime>> archive;

        public MainForm()
        {
            InitializeComponent();
            candidates = new List<Candidate>();
            archive = new List<Tuple<Candidate, Candidate, DateTime>>();

            // Add sample candidates
            AddSampleCandidates();

            // Display entries
            PopulateDataGridView();

            // Disable editing features
            btnAddCandidate.Enabled = true;
            btnEditCandidate.Enabled = true;
            btnDeleteCandidate.Enabled = true;
            btnClearCandidates.Enabled = true;

            // Make DataGridView read-only
            dgvCandidates.ReadOnly = true;
        }

        // Method to add sample candidates
        private void AddSampleCandidates()
        {
            candidates.Add(new Candidate(180, "Чоловік", "Іван", "Ковальчук", DateTime.Parse("1990-01-01"), "Київ",
                "Програміст", "Шукаю людину для спільних подорожей", false, 0, "Християнство", "Українець"));

            candidates.Add(new Candidate(165, "Жінка", "Марія", "Шевченко", DateTime.Parse("1992-05-15"), "Львів",
                "Дизайнер", "Люблю мистецтво та музику", true, 1, "Атеїст", "Українка"));

            // Додайте VIP кандидатів
            candidates.Add(new VIPCandidate(185, "Чоловік", "Олександр", "Мельник", DateTime.Parse("1985-03-18"), "Одеса",
                "Підприємець", "Ціную сімейні цінності", true, 2, "Християнство", "Українець", "Золотий"));

            candidates.Add(new VIPCandidate(170, "Жінка", "Анастасія", "Бондаренко", DateTime.Parse("1988-07-22"), "Харків",
                "Лікар", "Люблю допомагати людям", false, 0, "Християнство", "Українка", "Платиновий"));

            candidates.Add(new VIPCandidate(175, "Жінка", "Олена", "Іванова", DateTime.Parse("1990-02-15"), "Київ",
            "Маркетолог", "Шукаю серйозні стосунки", false, 0, "Християнство", "Українка", "Золотий"));

            candidates.Add(new VIPCandidate(185, "Чоловік", "Дмитро", "Сидоренко", DateTime.Parse("1985-06-10"), "Львів",
                "Архітектор", "Люблю спорт та подорожі", true, 1, "Християнство", "Українець", "Платиновий"));

            candidates.Add(new VIPCandidate(168, "Жінка", "Катерина", "Мельник", DateTime.Parse("1992-11-30"), "Одеса",
                "Підприємець", "Шукаю людину для спільного розвитку", false, 0, "Атеїст", "Українка", "Діамантовий"));

            candidates.Add(new VIPCandidate(178, "Чоловік", "Сергій", "Петренко", DateTime.Parse("1987-09-25"), "Харків",
                "Інженер", "Люблю техніку та інновації", true, 2, "Християнство", "Українець", "Золотий"));

            candidates.Add(new VIPCandidate(165, "Жінка", "Вікторія", "Коваленко", DateTime.Parse("1991-03-05"), "Дніпро",
                "Вчитель", "Шукаю доброго та надійного партнера", false, 0, "Християнство", "Українка", "Платиновий"));

            candidates.Add(new VIPCandidate(182, "Чоловік", "Олексій", "Ткаченко", DateTime.Parse("1984-12-12"), "Запоріжжя",
                "Лікар", "Ціную сімейні цінності", true, 1, "Християнство", "Українець", "Діамантовий"));

            candidates.Add(new VIPCandidate(170, "Жінка", "Марина", "Шевчук", DateTime.Parse("1989-07-18"), "Вінниця",
                "Юрист", "Шукаю партнера для створення сім'ї", false, 0, "Християнство", "Українка", "Золотий"));

            candidates.Add(new VIPCandidate(180, "Чоловік", "Андрій", "Гончаренко", DateTime.Parse("1986-04-22"), "Черкаси",
                "Бізнесмен", "Люблю активний відпочинок", true, 0, "Атеїст", "Українець", "Платиновий"));

            candidates.Add(new VIPCandidate(167, "Жінка", "Світлана", "Демченко", DateTime.Parse("1993-01-29"), "Полтава",
                "Дизайнер", "Творча особистість, шукаю натхнення", false, 0, "Християнство", "Українка", "Золотий"));

            candidates.Add(new VIPCandidate(183, "Чоловік", "Ігор", "Романенко", DateTime.Parse("1988-08-08"), "Чернівці",
                "Пілот", "Шукаю людину, з якою можна підкорювати небо", false, 0, "Християнство", "Українець", "Діамантовий"));

            candidates.Add(new VIPCandidate(172, "Жінка", "Наталія", "Литвин", DateTime.Parse("1990-10-17"), "Суми",
                "Фотограф", "Люблю подорожувати та фотографувати", false, 0, "Атеїст", "Українка", "Платиновий"));


            // Додаткові кандидати...
            // (залиште решту кандидатів без змін або додайте більше VIP кандидатів)
        }

        // Method to update DataGridView
        private void PopulateDataGridView()
        {
            // Сортуємо кандидатів
            candidates.Sort();

            dgvCandidates.DataSource = null;
            dgvCandidates.DataSource = candidates;

            // Hide all columns first
            foreach (DataGridViewColumn column in dgvCandidates.Columns)
            {
                column.Visible = false;
            }

            // Display columns in the desired order
            dgvCandidates.Columns["RegistrationNumber"].Visible = true;
            dgvCandidates.Columns["RegistrationNumber"].HeaderText = "Реєстраційний номер";
            dgvCandidates.Columns["RegistrationNumber"].DisplayIndex = 0;

            dgvCandidates.Columns["FirstName"].Visible = true;
            dgvCandidates.Columns["FirstName"].HeaderText = "Ім'я";
            dgvCandidates.Columns["FirstName"].DisplayIndex = 1;

            dgvCandidates.Columns["LastName"].Visible = true;
            dgvCandidates.Columns["LastName"].HeaderText = "Прізвище";
            dgvCandidates.Columns["LastName"].DisplayIndex = 2;

            dgvCandidates.Columns["DateOfBirth"].Visible = true;
            dgvCandidates.Columns["DateOfBirth"].HeaderText = "Дата народження";
            dgvCandidates.Columns["DateOfBirth"].DisplayIndex = 3;

            // Add Age column
            if (!dgvCandidates.Columns.Contains("Age"))
            {
                DataGridViewTextBoxColumn ageColumn = new DataGridViewTextBoxColumn();
                ageColumn.Name = "Age";
                ageColumn.HeaderText = "Вік";
                ageColumn.ReadOnly = true;
                dgvCandidates.Columns.Add(ageColumn);
            }
            dgvCandidates.Columns["Age"].DisplayIndex = 4;

            dgvCandidates.Columns["Location"].Visible = true;
            dgvCandidates.Columns["Location"].HeaderText = "Локація";
            dgvCandidates.Columns["Location"].DisplayIndex = 5;

            // Include other columns as needed
            dgvCandidates.Columns["Gender"].Visible = true;
            dgvCandidates.Columns["Gender"].HeaderText = "Стать";
            dgvCandidates.Columns["Gender"].DisplayIndex = 6;

            dgvCandidates.Columns["Height"].Visible = true;
            dgvCandidates.Columns["Height"].HeaderText = "Зріст (см)";
            dgvCandidates.Columns["Height"].DisplayIndex = 7;

            dgvCandidates.Columns["HasChildren"].Visible = true;
            dgvCandidates.Columns["HasChildren"].HeaderText = "Наявність дітей";
            dgvCandidates.Columns["HasChildren"].DisplayIndex = 8;

            dgvCandidates.Columns["NumberOfChildren"].Visible = true;
            dgvCandidates.Columns["NumberOfChildren"].HeaderText = "Кількість дітей";
            dgvCandidates.Columns["NumberOfChildren"].DisplayIndex = 9;

            dgvCandidates.Columns["Religion"].Visible = true;
            dgvCandidates.Columns["Religion"].HeaderText = "Релігія";
            dgvCandidates.Columns["Religion"].DisplayIndex = 10;

            dgvCandidates.Columns["Ethnicity"].Visible = true;
            dgvCandidates.Columns["Ethnicity"].HeaderText = "Етнічність";
            dgvCandidates.Columns["Ethnicity"].DisplayIndex = 11;

            dgvCandidates.Columns["SelfDescription"].Visible = true;
            dgvCandidates.Columns["SelfDescription"].HeaderText = "Про себе";
            dgvCandidates.Columns["SelfDescription"].DisplayIndex = 12;

            dgvCandidates.Columns["PartnerRequirements"].Visible = true;
            dgvCandidates.Columns["PartnerRequirements"].HeaderText = "Вимоги до партнера";
            dgvCandidates.Columns["PartnerRequirements"].DisplayIndex = 13;

            /* Add VIPStatus column if not exists
            if (!dgvCandidates.Columns.Contains("VIPStatus"))
            {
                DataGridViewTextBoxColumn vipStatusColumn = new DataGridViewTextBoxColumn();
                vipStatusColumn.Name = "VIPStatus";
                vipStatusColumn.HeaderText = "VIP Статус";
                vipStatusColumn.ReadOnly = true;
                dgvCandidates.Columns.Add(vipStatusColumn);
            }

            dgvCandidates.Columns["VIPStatus"].DisplayIndex = 14;

            // Update Age and VIPStatus values
            foreach (DataGridViewRow row in dgvCandidates.Rows)
            {
                Candidate candidate = row.DataBoundItem as Candidate;
                if (candidate != null)
                {
                    row.Cells["Age"].Value = candidate.Age;

                    VIPCandidate vipCandidate = candidate as VIPCandidate;
                    if (vipCandidate != null)
                    {
                        row.Cells["VIPStatus"].Value = vipCandidate.VIPStatus;
                    }
                    else
                    {
                        row.Cells["VIPStatus"].Value = "Звичайний";
                    }
                }
            }

            dgvCandidates.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; */
        }


        // "Exit" button click event
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вийти з програми?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // "Add Candidate" button click event
        private void btnAddCandidate_Click(object sender, EventArgs e)
        {
            CandidateForm candidateForm = new CandidateForm();
            if (candidateForm.ShowDialog() == DialogResult.OK)
            {
                candidates.Add(candidateForm.Candidate);
                PopulateDataGridView();
            }
        }

        // "Edit Candidate" button click event
        private void btnEditCandidate_Click(object sender, EventArgs e)
        {
            if (dgvCandidates.CurrentRow != null)
            {
                Candidate selectedCandidate = (Candidate)dgvCandidates.CurrentRow.DataBoundItem;
                CandidateForm candidateForm = new CandidateForm(selectedCandidate);
                if (candidateForm.ShowDialog() == DialogResult.OK)
                {
                    // Update the candidate in the list
                    int index = candidates.IndexOf(selectedCandidate);
                    candidates[index] = candidateForm.Candidate;
                    PopulateDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Оберіть кандидата для редагування.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // "Delete Candidate" button click event
        private void btnDeleteCandidate_Click(object sender, EventArgs e)
        {
            if (dgvCandidates.CurrentRow != null)
            {
                Candidate selectedCandidate = (Candidate)dgvCandidates.CurrentRow.DataBoundItem;
                if (MessageBox.Show("Ви впевнені, що хочете видалити цього кандидата?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    candidates.Remove(selectedCandidate);
                    PopulateDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Оберіть кандидата для видалення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // "Clear Candidates" button click event
        private void btnClearCandidates_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви впевнені, що хочете очистити список кандидатів?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                candidates.Clear();
                PopulateDataGridView();
            }
        }

        private void btnViewArchive_Click(object sender, EventArgs e)
        {
            ArchiveForm archiveForm = new ArchiveForm(archive);
            archiveForm.ShowDialog();
        }

        // "Save as Text" button click event
        private void btnSaveAsText_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстові файли (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.Title = "Зберегти дані у текстовому форматі";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false, System.Text.Encoding.UTF8))
                {
                    foreach (var candidate in candidates)
                    {
                        sw.WriteLine($"{candidate.RegistrationNumber}\t{candidate.FirstName}\t{candidate.LastName}\t{candidate.DateOfBirth.ToShortDateString()}\t{candidate.Age}\t{candidate.Location}\t{candidate.Gender}\t{candidate.Height}\t{candidate.HasChildren}\t{candidate.NumberOfChildren}\t{candidate.Religion}\t{candidate.Ethnicity}\t{candidate.SelfDescription}\t{candidate.PartnerRequirements}\t{candidate.RegistrationDate.ToShortDateString()}");
                    }
                }
                MessageBox.Show("Дані успішно збережено у текстовий файл.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // "Open from Text" button click event
        private void btnOpenFromText_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстові файли (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.Title = "Відкрити дані з текстового файлу";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                candidates.Clear();

                using (StreamReader sr = new StreamReader(openFileDialog.FileName, System.Text.Encoding.UTF8))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split('\t');
                        if (parts.Length >= 15)
                        {
                            int registrationNumber = int.Parse(parts[0]);
                            string firstName = parts[1];
                            string lastName = parts[2];
                            DateTime dateOfBirth = DateTime.Parse(parts[3]);
                            // Age is calculated automatically
                            string location = parts[5];
                            string gender = parts[6];
                            double height = double.Parse(parts[7]);
                            bool hasChildren = bool.Parse(parts[8]);
                            int numberOfChildren = int.Parse(parts[9]);
                            string religion = parts[10];
                            string ethnicity = parts[11];
                            string selfDescription = parts[12];
                            string partnerRequirements = parts[13];
                            DateTime registrationDate = DateTime.Parse(parts[14]);

                            Candidate candidate = new Candidate(registrationNumber, registrationDate, height, gender, firstName, lastName,
                                dateOfBirth, location, selfDescription, partnerRequirements, hasChildren, numberOfChildren, religion, ethnicity);

                            candidates.Add(candidate);
                        }
                    }
                }

                // Update nextRegistrationNumber to avoid duplicate registration numbers
                if (candidates.Count > 0)
                {
                    Candidate.nextRegistrationNumber = candidates[candidates.Count - 1].RegistrationNumber + 1;
                }
                else
                {
                    Candidate.nextRegistrationNumber = 1;
                }

                PopulateDataGridView();
                MessageBox.Show("Дані успішно завантажено з текстового файлу.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // "Search Candidates" button click event
        private void btnSearchCandidates_Click(object sender, EventArgs e)
        {
            // Implement search functionality based on user input
            string gender = cmbSearchGender.SelectedItem?.ToString();
            int ageFrom = (int)numSearchAgeFrom.Value;
            int ageTo = (int)numSearchAgeTo.Value;
            bool? hasChildren = null;
            if (chkSearchHasChildren.Checked)
                hasChildren = true;

            List<Candidate> results = new List<Candidate>();

            foreach (var candidate in candidates)
            {
                int age = candidate.Age;
                bool matchesGender = string.IsNullOrEmpty(gender) || candidate.Gender.Equals(gender, StringComparison.OrdinalIgnoreCase);
                bool matchesAge = age >= ageFrom && age <= ageTo;
                bool matchesChildren = !hasChildren.HasValue || candidate.HasChildren == hasChildren.Value;

                if (matchesGender && matchesAge && matchesChildren)
                {
                    results.Add(candidate);
                }
            }

            dgvSearchResults.DataSource = null;
            dgvSearchResults.DataSource = results;

            if (results.Count == 0)
            {
                MessageBox.Show("Немає кандидатів, що відповідають критеріям пошуку.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // "Invite Candidate" button click event
        private void btnInviteCandidate_Click(object sender, EventArgs e)
        {
            if (dgvSearchResults.CurrentRow != null)
            {
                Candidate selectedCandidate = (Candidate)dgvSearchResults.CurrentRow.DataBoundItem;

                // For demonstration, we'll assume the current user is the first candidate in the list
                Candidate currentUser = candidates[0]; // Replace with the actual current user

                // Add the matched pair to the archive
                archive.Add(new Tuple<Candidate, Candidate, DateTime>(currentUser, selectedCandidate, DateTime.Now));

                MessageBox.Show($"Ви запросили кандидата {selectedCandidate.FirstName} {selectedCandidate.LastName}.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Оберіть кандидата для запрошення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // "Select Candidates" button click event
        private void btnSelectCandidates_Click(object sender, EventArgs e)
        {
            SelectionForm selectionForm = new SelectionForm(candidates);
            selectionForm.ShowDialog();
        }

        private void btnCalculateCompatibility_Click(object sender, EventArgs e)
        {
            if (dgvCandidates.CurrentRow != null)
            {
                Candidate selectedCandidate = (Candidate)dgvCandidates.CurrentRow.DataBoundItem;

                // Створення нового користувача Олександра Рудика
                Candidate currentUser = new VIPCandidate(
                    185,
                    "Чоловік",
                    "Олександр",
                    "Рудик",
                    DateTime.Parse("2005-03-18"),
                    "Одеса",
                    "Підприємець",
                    "Ціную сімейні цінності",
                    true,
                    2,
                    "Християнство",
                    "Українець",
                    "Золотий"
                );

                // Обчислення балу сумісності
                double score = currentUser.CalculateCompatibilityScore(selectedCandidate);

                MessageBox.Show($"Бал сумісності між {currentUser.FirstName} {currentUser.LastName} та {selectedCandidate.FirstName} {selectedCandidate.LastName}: {score}",
                                "Бал сумісності",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Оберіть кандидата для обчислення сумісності.",
                                "Помилка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }



    }
}
