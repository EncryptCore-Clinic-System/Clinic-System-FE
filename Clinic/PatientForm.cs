using Clinic.Models;
using Guna.UI2.WinForms;
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
    public partial class PatientForm : Form
    {
        MyContext db = new MyContext();
        public PatientForm()
        {
            InitializeComponent();
            ExistingPatient.CheckedChanged += ExistingPatient_CheckedChanged;
            NewPatient.CheckedChanged += NewPatient_CheckedChanged;

            ExistingPatients.Leave += ExistingPatients_Leave;
            ExistingPatients.SelectedIndexChanged += ExistingPatients_SelectedIndexChanged;
            ExistingVisitType.Leave += ExistingVisitType_Leave;
            ExistingVisitType.SelectedIndexChanged += ExistingVisitType_SelectedIndexChanged;
            
            PatientName.Leave += PatientName_Leave;
            PatientName.TextChanged += PatientName_TextChanged;
            PatientAge.Leave += PatientAge_Leave;
            PatientAge.TextChanged += PatientAge_TextChanged;
            PatientGender.Leave += PatientGender_Leave;
            PatientGender.SelectedIndexChanged += PatientGender_SelectedIndexChanged;
            PatientVisitType.Leave += PatientVisitType_Leave;
            PatientVisitType.SelectedIndexChanged += PatientVisitType_SelectedIndexChanged;
            PatientPhone.Leave += PatientPhone_Leave;
            PatientPhone.TextChanged += PatientPhone_TextChanged;
            PatientAddress.Leave += PatientAddress_Leave;
            PatientAddress.TextChanged += PatientAddress_TextChanged;



            PatientVisitType.Items.Add("Select Visit Type");
            PatientVisitType.Items.Add("Consultation");
            PatientVisitType.Items.Add("Follow-up Visit");
            PatientVisitType.StartIndex = 0;

            PatientVisitType.Items.Add("Select Gender");
            PatientGender.Items.Add("Male");
            PatientGender.Items.Add("Female");
            PatientGender.StartIndex = 0;

            ExistingVisitType.Items.Add("Select Visit Type");
            ExistingVisitType.Items.Add("Esteshara");
            ExistingVisitType.Items.Add("Follow-up Visit");
            ExistingVisitType.StartIndex = 0;

            ExistingPatients.Items.Add("Select Patient");
            foreach (var patient in db.Patients.ToList())
            {
                ExistingPatients.Items.Add(patient.Name);
            }
            ExistingPatients.StartIndex = 0;
        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private bool ValidateField(Guna2TextBox textBox, Guna2HtmlLabel errorLabel, string fieldName)
        {
            string input = textBox.Text;

            switch (fieldName)
            {
                case "Name":
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        ShowError(textBox, errorLabel, "Patient name cannot be blank.");
                        return false;
                    }
                    else if (input.Length < 3)
                    {
                        ShowError(textBox, errorLabel, "Patient name must be at least 3 characters.");
                        return false;
                    }
                    else
                    {
                        HideError(textBox, errorLabel);
                        return true;
                    }
                    case "Age":
                        if (string.IsNullOrWhiteSpace(input))
                    {
                        ShowError(textBox, errorLabel, "Age cannot be blank.");
                        return false;
                    }
                    else if (!int.TryParse(input, out int age) || age < 0 || age > 120)
                    {
                        ShowError(textBox, errorLabel, "Please enter a valid age between 0 and 120.");
                        return false;
                    }
                    else
                    {
                        HideError(textBox, errorLabel);
                        return true;
                    }
                    case "Phone":
                            if (string.IsNullOrWhiteSpace(input))
                    {
                        ShowError(textBox, errorLabel, "Phone number cannot be blank.");
                        return false;
                    }
                            else if (!System.Text.RegularExpressions.Regex.IsMatch(input, @"^\+?\d{10,15}$"))
                    {
                        ShowError(textBox, errorLabel, "Please enter a valid phone number (10-15 digits, optional +).");
                        return false;
                    }
                    else
                    {
                        HideError(textBox, errorLabel);
                        return true;
                    }
                    case "Address":
                        if (string.IsNullOrWhiteSpace(input))
                    {
                        ShowError(textBox, errorLabel, "Address cannot be blank.");
                        return false;
                    }
                    else if (input.Length < 5)
                    {
                        ShowError(textBox, errorLabel, "Address must be at least 5 characters.");
                        return false;
                    }
                    else
                    {
                        HideError(textBox, errorLabel);
                        return true;
                    }

                default:
                    return true;
            }
        }

        private bool ValidateField(Guna2ComboBox guna2ComboBox, Guna2HtmlLabel errorLabel, string fieldName)
        {
            if (guna2ComboBox.SelectedItem == null)
            {
                ShowError(guna2ComboBox, errorLabel, $"Please select a {fieldName}.");
                return false;
            }
            else if (guna2ComboBox.SelectedItem.ToString().StartsWith("Select"))
            {
                ShowError(guna2ComboBox, errorLabel, $"Please select a {fieldName}.");
                return false;
            }
            else
            {
                HideError(guna2ComboBox, errorLabel);
                return true;
            }
        }


        private void ShowError(Guna2ComboBox guna2ComboBox, Guna2HtmlLabel errorLabel, string message)
        {
            errorLabel.Text = message;
            errorLabel.ForeColor = Color.Red;
            errorLabel.Visible = true;
            guna2ComboBox.BorderColor = Color.Red;
        }

        private void HideError(Guna2ComboBox guna2ComboBox, Guna2HtmlLabel errorLabel)
        {
            errorLabel.Visible = false;
            guna2ComboBox.BorderColor = Color.FromArgb(213, 218, 223);
        }


        private void ShowError(Guna2TextBox textBox, Guna2HtmlLabel errorLabel, string message)
        {
            errorLabel.Text = message;
            errorLabel.ForeColor = Color.Red;
            errorLabel.Visible = true;
            textBox.BorderColor = Color.Red;
        }

        private void HideError(Guna2TextBox textBox, Guna2HtmlLabel errorLabel)
        {
            errorLabel.Visible = false;
            textBox.BorderColor = Color.FromArgb(213, 218, 223);
        }

        private void NewPatient_CheckedChanged(object sender, EventArgs e)
        {
            ExistingPatients.Visible = false;
            ExistingVisitType.Visible = false;
            AddExistingPatient.Visible = false;

            PatientName.Visible = true;
            PatientAge.Visible = true;
            PatientPhone.Visible = true;
            PatientGender.Visible = true;
            PatientVisitType.Visible = true;
            PatientAddress.Visible = true;
            AddPatientBTN.Visible = true;

            ErrorLabel1.Visible = false;
            ErrorLabel2.Visible = false;
            ErrorLabel3.Visible = false;
            ErrorLabel4.Visible = false;
            ErrorLabel5.Visible = false;
            ErrorLabel6.Visible = false;

        }
        private void ExistingPatient_CheckedChanged(object sender, EventArgs e)
        {
            ExistingPatients.Visible = true;
            ExistingVisitType.Visible = true;
            AddExistingPatient.Visible = true;

            PatientName.Visible = false;
            PatientAge.Visible = false;
            PatientPhone.Visible = false;
            PatientGender.Visible = false;
            PatientVisitType.Visible = false;
            PatientAddress.Visible = false;
            AddPatientBTN.Visible = false;

            ErrorLabel1.Visible = false;
            ErrorLabel2.Visible = false;
            ErrorLabel3.Visible = false;
            ErrorLabel4.Visible = false;
            ErrorLabel5.Visible = false;
            ErrorLabel6.Visible = false;
        }

        private void RefreshExistingPatients()
        {
            ExistingPatients.Items.Clear();
            ExistingPatients.Items.Add("Select Patient");
            foreach (var patient in db.Patients.ToList())
            {
                ExistingPatients.Items.Add(patient.Name);
            }
            ExistingPatients.StartIndex = 0;
        }


        private void AddExistingPatient_Click(object sender, EventArgs e)
        {
            bool valid1 = ValidateField(ExistingPatients, ErrorLabel1, "Patient");
            bool valid2 = ValidateField(ExistingVisitType, ErrorLabel2, "Visit Type");
            if (!valid1 || !valid2) return;
            MessageBox.Show("Successfully Added");
        }

        private void AddPatientBTN_Click(object sender, EventArgs e)
        {
            bool valid1 = ValidateField(PatientName, ErrorLabel1, "Name");
            bool valid2 = ValidateField(PatientAge, ErrorLabel2, "Age");
            bool valid3 = ValidateField(PatientGender, ErrorLabel3, "Gender");
            bool valid4 = ValidateField(PatientVisitType, ErrorLabel4, "Visit Type");
            bool valid5 = ValidateField(PatientPhone, ErrorLabel5, "Phone");
            bool valid6 = ValidateField(PatientAddress, ErrorLabel6, "Address");
            if (!valid1 || !valid2 || !valid3 || !valid4 || !valid5 || !valid6) return;

            try
            {
                db.Patients.Add(new Patient
                {
                    Name = PatientName.Text,
                    Age = int.Parse(PatientAge.Text),
                    Gender = PatientGender.Text,
                    VisitType = PatientVisitType.Text,
                    Phone = PatientPhone.Text,
                    Address = PatientAddress.Text,
                    CreatedAt = DateTime.Now
                });
                db.SaveChanges();
                RefreshExistingPatients();
                MessageBox.Show("Successfully Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding patient: " + ex.Message);
            }
        }

        private void PatientName_TextChanged(object sender, EventArgs e)
        {
            ValidateField(PatientName, ErrorLabel1, "Name");
        }

        private void PatientName_Leave(object sender, EventArgs e)
        {
            ValidateField(PatientName, ErrorLabel1, "Name");
        }

        private void PatientAge_TextChanged(object sender, EventArgs e)
        {
            ValidateField(PatientAge, ErrorLabel2, "Age");
        }
        private void PatientAge_Leave(object sender, EventArgs e)
        {
            ValidateField(PatientAge, ErrorLabel2, "Age");
        }

        private void PatientGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateField(PatientGender, ErrorLabel3, "Gender");
        }

        private void PatientGender_Leave(object sender, EventArgs e)
        {
            ValidateField(PatientAge, ErrorLabel2, "Age");
        }

        private void PatientVisitType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateField(PatientVisitType, ErrorLabel4, "Visit Type");
        }

        private void PatientVisitType_Leave(object sender, EventArgs e)
        {
            ValidateField(PatientVisitType, ErrorLabel4, "Visit Type");
        }

        private void PatientPhone_TextChanged(object sender, EventArgs e)
        {
            ValidateField(PatientPhone, ErrorLabel5, "Phone");
        }
        private void PatientPhone_Leave(object sender, EventArgs e)
        {
            ValidateField(PatientPhone, ErrorLabel5, "Phone");
        }

        private void PatientAddress_TextChanged(object sender, EventArgs e)
        {
            ValidateField(PatientAddress, ErrorLabel6, "Address");
        }

        private void PatientAddress_Leave(object sender, EventArgs e)
        {
            ValidateField(PatientAddress, ErrorLabel6, "Address");
        }

        private void ExistingPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateField(ExistingPatients, ErrorLabel1, "Patient");
        }

        private void ExistingPatients_Leave(object sender, EventArgs e)
        {
            ValidateField(ExistingPatients, ErrorLabel1, "Patient");
        }

        private void ExistingVisitType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateField(ExistingVisitType, ErrorLabel2, "Visit Type");
        }

        private void ExistingVisitType_Leave(object sender, EventArgs e)
        {
            ValidateField(ExistingVisitType, ErrorLabel2, "Visit Type");
        }

    }
}
