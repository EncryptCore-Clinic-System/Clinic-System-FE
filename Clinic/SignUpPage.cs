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
using Clinic.Models;

namespace Clinic
{
    public partial class SignUpPage : Form
    {
        MyContext db = new MyContext();
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


            guna2ComboBox1.Items.Add("Select your role");
            guna2ComboBox1.Items.AddRange(new object[] { "Doctor", "Receptionist"});
            guna2ComboBox1.StartIndex = 0; // show placeholder as default

            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;

            this.Resize += SignUpPage_Resize;
            this.Load += SignUpPage_Load;
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

        private bool ValidateField(Guna2ComboBox guna2ComboBox, Guna2HtmlLabel errorLabel, string fieldName) {
            if (guna2ComboBox.SelectedItem == null)
            {
                ShowError(guna2ComboBox, errorLabel, "Please select a role.");
                return false;
            }
            else if (guna2ComboBox.SelectedItem.ToString() == "Select your role")
            {
                ShowError(guna2ComboBox, errorLabel, "Please select a role.");
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


        private bool ValidateAllFields()
        {
            bool valid1 = ValidateField(guna2TextBox1, guna2HtmlLabel4, "Username");
            bool valid2 = ValidateField(guna2TextBox2, guna2HtmlLabel5, "Email");
            bool valid3 = ValidateField(guna2TextBox3, guna2HtmlLabel6, "Password");
            bool valid4 = ValidateField(guna2TextBox4, guna2HtmlLabel7, "Confirm Password");
            bool valid5 = ValidateField(guna2ComboBox1, guna2HtmlLabel8, "role");

            return valid1 && valid2 && valid3 && valid4 && valid5;
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            if (ValidateAllFields())
            {
                MessageBox.Show("Form submitted successfully!");

                string username = guna2TextBox1.Text;
                string email = guna2TextBox2.Text;
                string password = guna2TextBox3.Text;
                string confirmPassword = guna2TextBox4.Text;
                string role = guna2ComboBox1.SelectedItem.ToString();

                // Here, you save the user data to a database or perform other actions.
                var user = new User
                {
                    Username = username,
                    Email = email,
                    Password = password,
                    Role = role
                };

                using (db)
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                }
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

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateField(guna2ComboBox1, guna2HtmlLabel8, "role");
        }

        private void guna2ComboBox1_Leave(object sender, EventArgs e)
        {
            ValidateField(guna2ComboBox1, guna2HtmlLabel8, "role");
        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void SignUpPage_Load(object sender, EventArgs e)
        {
            int spacing = 6;

            // Calculate total height of your stacked controls
            int totalHeight = guna2HtmlLabel1.Height +
                              guna2TextBox1.Height + guna2TextBox2.Height +
                              guna2TextBox3.Height + guna2TextBox4.Height +
                              guna2ComboBox1.Height + guna2Button1.Height +
                              (spacing * 6);

            int startY = (this.ClientSize.Height / 2) - (totalHeight / 2);

            // Center each control horizontally and stack them
            CenterControl(guna2HtmlLabel1, ref startY, spacing); 
            CenterControl(guna2TextBox1, ref startY, spacing);
            CenterControl(guna2HtmlLabel4, ref startY, spacing);
            CenterControl(guna2TextBox2, ref startY, spacing);
            CenterControl(guna2HtmlLabel5, ref startY, spacing);
            CenterControl(guna2TextBox3, ref startY, spacing);
            CenterControl(guna2HtmlLabel6, ref startY, spacing);
            CenterControl(guna2TextBox4, ref startY, spacing);
            CenterControl(guna2HtmlLabel7, ref startY, spacing);
            CenterControl(guna2ComboBox1, ref startY, spacing);
            CenterControl(guna2HtmlLabel8, ref startY, 5);
            CenterControl(guna2Button1, ref startY, 5);
        }

        private void CenterControl(Control ctrl, ref int startY, int spacing)
        {
            ctrl.Left = (this.ClientSize.Width - ctrl.Width) / 2;
            ctrl.Top = startY;
            startY += ctrl.Height + spacing;
        }

        private void SignUpPage_Resize(object sender, EventArgs e)
        {
            SignUpPage_Load(sender, e);
        }

        private void SignUpPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
