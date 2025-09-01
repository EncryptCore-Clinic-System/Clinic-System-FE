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
using Clinic;

namespace Clinic
{
    public partial class SignUpPage : Form
    {
        public SignUpPage()
        {
            InitializeComponent();

            guna2TextBox1.Leave += guna2TextBox1_Leave;
            guna2TextBox2.Leave += guna2TextBox2_Leave;
            guna2TextBox3.Leave += guna2TextBox3_Leave;
            guna2TextBox4.Leave += guna2TextBox4_Leave;

            guna2TextBox1.TextChanged += guna2TextBox1_TextChanged;
            guna2TextBox2.TextChanged += guna2TextBox2_TextChanged;
            guna2TextBox3.TextChanged += guna2TextBox3_TextChanged;
            guna2TextBox4.TextChanged += guna2TextBox4_TextChanged;

            guna2HtmlLabel3.Cursor = Cursors.Hand;
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {
            var LogInPage = new LoginPage();
            LogInPage.Show();
            this.Hide();
        }

        private void guna2HtmlLabel3_MouseEnter(object sender, EventArgs e)
        {
            guna2HtmlLabel3.Cursor = Cursors.Hand;
        }

        private void guna2HtmlLabel3_MouseLeave(object sender, EventArgs e)
        {
            guna2HtmlLabel3.Cursor = Cursors.Default;
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool ValidateField(Guna2TextBox textBox, Guna2HtmlLabel errorLabel, string fieldName)
        {
            string input = textBox.Text;

            switch (fieldName)
            {
                case "Username":
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        ShowError(textBox, errorLabel, "Username cannot be blank.");
                        return false;
                    }
                    else if (input.Length < 3)
                    {
                        ShowError(textBox, errorLabel, "Username must be at least 3 characters.");
                        return false;
                    }
                    else
                    {
                        HideError(textBox, errorLabel);
                        return true;
                    }

                case "Email":
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        ShowError(textBox, errorLabel, "Email cannot be blank.");
                        return false;
                    }
                    else if (!System.Text.RegularExpressions.Regex.IsMatch(
                                input, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                    {
                        ShowError(textBox, errorLabel, "Enter a valid email address.");
                        return false;
                    }
                    else
                    {
                        HideError(textBox, errorLabel);
                        return true;
                    }

                case "Password":
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        ShowError(textBox, errorLabel, "Password cannot be blank.");
                        return false;
                    }
                    else if (input.Length < 6)
                    {
                        ShowError(textBox, errorLabel, "Password must be at least 6 characters.");
                        return false;
                    }
                    else if (!input.Any(char.IsDigit))
                    {
                        ShowError(textBox, errorLabel, "Password must include a number.");
                        return false;
                    }
                    else
                    {
                        HideError(textBox, errorLabel);
                        return true;
                    }

                case "Confirm Password":
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        ShowError(textBox, errorLabel, "Please confirm your password.");
                        return false;
                    }
                    else if (input != guna2TextBox3.Text)
                    {
                        ShowError(textBox, errorLabel, "Passwords do not match.");
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


        private bool ValidateAllFields()
        {
            bool valid1 = ValidateField(guna2TextBox1, guna2HtmlLabel4, "Username");
            bool valid2 = ValidateField(guna2TextBox2, guna2HtmlLabel5, "Email");
            bool valid3 = ValidateField(guna2TextBox3, guna2HtmlLabel6, "Password");
            bool valid4 = ValidateField(guna2TextBox4, guna2HtmlLabel7, "Confirm Password");

            return valid1 && valid2 && valid3 && valid4;
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            if (ValidateAllFields())
            {
                MessageBox.Show("Form submitted successfully!");
            }
        }

        private void guna2TextBox1_Leave(object sender, EventArgs e)
        {
            ValidateField(guna2TextBox1, guna2HtmlLabel4, "Username");
        }

        private void guna2TextBox2_Leave(object sender, EventArgs e)
        {
            ValidateField(guna2TextBox2, guna2HtmlLabel5, "Email");
        }

        private void guna2TextBox3_Leave(object sender, EventArgs e)
        {
            ValidateField(guna2TextBox3, guna2HtmlLabel6, "Password");
        }

        private void guna2TextBox4_Leave(object sender, EventArgs e)
        {
            ValidateField(guna2TextBox4, guna2HtmlLabel7, "Confirm Password");
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            ValidateField(guna2TextBox1, guna2HtmlLabel4, "Username");
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            ValidateField(guna2TextBox2, guna2HtmlLabel5, "Email");
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
            ValidateField(guna2TextBox3, guna2HtmlLabel6, "Password");
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {
            ValidateField(guna2TextBox4, guna2HtmlLabel7, "Confirm Password");
        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

    }
}
