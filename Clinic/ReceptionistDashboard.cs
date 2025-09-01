using System;
using System.Windows.Forms;

namespace Clinic
{
    public partial class ReceptionistDashboard : Form
    {
        // counters
        int totalAppointments = 0;
        int pendingAppointments = 0;
        int withDoctor = 0;

        public ReceptionistDashboard()
        {
            InitializeComponent();
        }

        private void ReceptionistDashboard_Load(object sender, EventArgs e)
        {
            // Prevent placeholder new row
            dataGridView1.AllowUserToAddRows = false;

            // initialize counters
            UpdateLabels();
        }

        // Add button (green button)
        private void button1_Click(object sender, EventArgs e)
        {
            AddNewAppointment();
        }

        // Add picture (green picture)
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            AddNewAppointment();
        }

        private void AddNewAppointment()
        {
            int newId = dataGridView1.Rows.Count + 1;

            dataGridView1.Rows.Add(new object[]
            {
                newId,   // #
                "",      // Name
                "",      // Age
                "",      // Visit Type
                "",      // Medical History
                "",      // Phone number
                "Waiting"// Status
            });

            totalAppointments++;
            pendingAppointments++;

            UpdateLabels();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != 6) return; // only Status column

            DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            string currentStatus = cell.Value?.ToString() ?? "";

            if (currentStatus == "Waiting")
            {
                cell.Value = "With Doctor";
                pendingAppointments = Math.Max(0, pendingAppointments - 1);
                withDoctor++;
            }
            else if (currentStatus == "With Doctor")
            {
                cell.Value = "Completed";
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
    }
}
