using Clinic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic
{
    public partial class DashboardUC : UserControl
    {
        private User loggedInUser;
        MyContext context = new MyContext();
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
            // initialize counters
            UpdateLabels();
        }

        private void ReceptionistDashboard_Load(object sender, EventArgs e)
        {
            //// Prevent placeholder new row
            //dataGridView1.AllowUserToAddRows = false;


            //button1.Visible = loggedInUser.Role == "Receptionist";
            //pictureBox5.Visible = loggedInUser.Role == "Receptionist";

            //LoadPatients();
            //// initialize counters
            //UpdateLabels();
        }

        private void LoadPatients()
        {
            var patients = context.Patients.ToList();

            // Optional: Clear existing rows
            dataGridView1.Rows.Clear();

            foreach (var patient in patients)
            {
                dataGridView1.Rows.Add(new object[]
                {
                    patient.PatientID,
                    patient.Name,
                    patient.Age,
                    patient.VisitType,
                    patient.MedicalHistory,
                    patient.Phone,
                    patient.Status
                });
            }
            //MessageBox.Show("Patients loaded successfully.", "Load Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

            totalAppointments = patients.Count;
            pendingAppointments = patients.Count(p => p.Status == "Waiting");
            withDoctor = patients.Count(p => p.Status == "With Doctor");
        }

        private void AddPatientToGrid(Patient patient)
        {
            // Check if patient already exists by Name and Phone
            bool exists = dataGridView1.Rows
                .Cast<DataGridViewRow>()
                .Any(r => r.Cells[1].Value?.ToString() == patient.Name &&
                          r.Cells[5].Value?.ToString() == patient.Phone && r.Cells[6].Value?.ToString() != "Completed");

            if (exists)
            {
                MessageBox.Show("Patient already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Add to grid
            dataGridView1.Rows.Add(new object[]
            {
        patient.PatientID,
        patient.Name,
        patient.Age,
        patient.VisitType,
        patient.MedicalHistory,
        patient.Phone,
        patient.Status
            });

            totalAppointments++;
            pendingAppointments++;
            UpdateLabels();
        }

        // Add button (green button)
        private void button1_Click(object sender, EventArgs e)
        {
            var form = new PatientForm();
            if (form.ShowDialog() == DialogResult.OK && form.SelectedPatient != null)
            {
                AddPatientToGrid(form.SelectedPatient);
            }
        }

        // Add picture (green picture)
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
            if (e.RowIndex < 0 || e.ColumnIndex != 6) return; // only Status column

            DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            string currentStatus = cell.Value?.ToString() ?? "";

            if (currentStatus == "Waiting")
            {
                cell.Value = "With Doctor";
                context.Patients.Find(dataGridView1.Rows[e.RowIndex].Cells[0].Value).Status = "With Doctor";
                context.SaveChanges();
                pendingAppointments = Math.Max(0, pendingAppointments - 1);
                withDoctor++;
            }
            else if (currentStatus == "With Doctor")
            {
                cell.Value = "Completed";
                context.Patients.Find(dataGridView1.Rows[e.RowIndex].Cells[0].Value).Status = "Completed";
                context.SaveChanges();
                withDoctor = Math.Max(0, withDoctor - 1);
            }

            UpdateLabels();
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

        private void Search_TextChanged(object sender, EventArgs e)
        {

            var searchText = Search.Text.Trim();

            var results = context.Patients
                .Where(p => p.Name.Contains(searchText) ||
                            p.PatientID.ToString().Contains(searchText))
                .ToList();

            dataGridView1.DataSource = results; // عرض النتائج

        }

        private void ReceptionistDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // لما المستخدم يدوس Enter
            {
                string searchText = Search.Text.Trim();

                if (!string.IsNullOrEmpty(searchText))
                {
                    var results = context.Patients
                        .Where(p => p.Name.Contains(searchText) ||
                                    p.PatientID.ToString().Contains(searchText))
                        .ToList();

                    if (results.Count > 0)
                    {
                        dataGridView1.DataSource = results;
                        MessageBox.Show("Patient found ✅", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        dataGridView1.DataSource = null;
                        MessageBox.Show("Patient not found ❌", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    dataGridView1.DataSource = null;
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblWithDoctor_Click(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Search_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var signinPage = new LoginPage();
            signinPage.Show();
            this.Hide();
        }
    }
}

    
