using Clinic.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Clinic
{
    public partial class DashboardUC : UserControl
    {
        private User loggedInUser;
        MyContext context = new MyContext();
        private Timer refreshTimer;

        // counters
        int totalAppointments = 0;
        int pendingAppointments = 0;
        int withDoctor = 0;

        public DashboardUC(User user)
        {
            InitializeComponent();
            loggedInUser = user;

            dataGridView1.AllowUserToAddRows = false;

            button1.Visible = loggedInUser.Role == "Receptionist";
            pictureBox5.Visible = loggedInUser.Role == "Receptionist";

            LoadPatients();

            refreshTimer = new Timer();
            refreshTimer.Interval = 3000; // 3 seconds
            refreshTimer.Tick += (s, ev) => RefreshPatients();
            refreshTimer.Start();

            UpdateLabels();
        }

        private void RefreshPatients()
        {
            try
            {
                context = new MyContext(); // ensure fresh context
                context.Patients.Load();

                var updatedPatients = context.Patients.ToList();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = updatedPatients;

                totalAppointments = updatedPatients.Count;
                pendingAppointments = updatedPatients.Count(p => p.Status == "Waiting");
                withDoctor = updatedPatients.Count(p => p.Status == "With Doctor");
                UpdateLabels();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Refresh failed: {ex.Message}");
            }
        }

        private void LoadPatients()
        {
            var patients = context.Patients.ToList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = patients;

            totalAppointments = patients.Count;
            pendingAppointments = patients.Count(p => p.Status == "Waiting");
            withDoctor = patients.Count(p => p.Status == "With Doctor");
        }

        private void AddPatientToGrid(Patient patient)
        {
            //bool exists = context.Patients.Any(p => p.Name == patient.Name && p.Phone == patient.Phone && p.Status != "Completed");
            //if (exists)
            //{
            //    MessageBox.Show("Patient already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            context.Patients.Add(patient);
            context.SaveChanges();

            LoadPatients();
            UpdateLabels();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new PatientForm();
            if (form.ShowDialog() == DialogResult.OK && form.SelectedPatient != null)
            {
                AddPatientToGrid(form.SelectedPatient);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var form = new PatientForm();
            if (form.ShowDialog() == DialogResult.OK && form.SelectedPatient != null)
            {
                AddPatientToGrid(form.SelectedPatient);
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (loggedInUser.Role != "Doctor") return;
            if (e.RowIndex < 0) return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Status")
            {
                var patient = dataGridView1.Rows[e.RowIndex].DataBoundItem as Patient;
                if (patient != null)
                {
                    patient.Status = patient.Status == "Waiting" ? "With Doctor" : "Completed";
                    context.SaveChanges();
                    RefreshPatients();
                }
            }
        }

        private void UpdateLabels()
        {
            lblTotal.Text = totalAppointments.ToString();
            lblPending.Text = pendingAppointments.ToString();
            lblWithDoctor.Text = withDoctor.ToString();
        }

        // --- Empty stubs for Designer events so you don't get errors ---
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged_1(object sender, EventArgs e) { }
        private void textBox1_TextChanged_2(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void richTextBox1_TextChanged(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e) { }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private List<Patient> originalPatients;

        private void LoadOriginalData()
        {
            originalPatients = context.Patients.ToList();
            dataGridView1.DataSource = originalPatients;
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PerformSearch(showMessage: true);
            }
        }
        private void PerformSearch(bool showMessage = false)
        {
            string searchText = Search.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                // إرجاع البيانات الأصلية لما مفيش نص للبحث
                LoadPatients();
                refreshTimer.Tick += (s, ev) => RefreshPatients();
                refreshTimer.Start();
                return;
            }

            if (refreshTimer != null)
                refreshTimer.Stop();
            // تنفيذ البحث
            var results = context.Patients
                .Where(p => p.Name.ToLower().Contains(searchText.ToLower()) ||
                            p.PatientID.ToString().Contains(searchText))
                .ToList();

            ShowResults(results, showMessage);
        }

        private void ShowResults(List<Patient> results, bool showMessage)
        {
            if (results != null && results.Count > 0)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = results;
                dataGridView1.Visible = true;

                if (showMessage)
                {
                    MessageBox.Show($"Found {results.Count} patient(s) ✅", "Search Result",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.Visible = false;

                if (showMessage)
                {
                    MessageBox.Show("Patient not found ❌", "Search Result",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ResetDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = true;
        }

        private void ReceptionistDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (refreshTimer != null)
                refreshTimer.Stop();

            Environment.Exit(0);
        }

        private void pictureBox3_Click(object sender, EventArgs e) { }
        private void groupBox5_Enter(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void lblWithDoctor_Click(object sender, EventArgs e) { }
        private void groupBox6_Enter(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void label4_Click_1(object sender, EventArgs e) { }
        private void label3_Click_1(object sender, EventArgs e) { }
        private void groupBox3_Enter(object sender, EventArgs e) { }
        private void groupBox4_Enter(object sender, EventArgs e) { }
        private void lblTotal_Click(object sender, EventArgs e) { }
        private void guna2HtmlLabel2_MouseClick(object sender, MouseEventArgs e) { }
        private void guna2HtmlLabel2_Click(object sender, EventArgs e) { }
        private void Search_TextChanged_1(object sender, EventArgs e) { }
        private void groupBox1_Enter_1(object sender, EventArgs e) { }
        private void guna2Panel1_Paint(object sender, PaintEventArgs e) { }
        private void Dashboard_Click(object sender, EventArgs e) { }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var signinPage = new LoginPage();
            signinPage.Show();
            this.Hide();
        }
    }
}
