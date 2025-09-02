using Clinic;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Clinic.Models;


namespace Clinic
{
    public partial class LoginPage : Form
    {
        Models.MyContext db = new Models.MyContext();
        public LoginPage()
        {
            InitializeComponent();


            UserName.Leave += UserName_Leave;
            Password.Leave += Password_Leave;


            UserName.TextChanged += UserName_Leave;
            Password.TextChanged += Password_Leave;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SignIn_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            var signUpPage = new SignUpPage();
            signUpPage.Show();
            this.Hide();
        }

        private void SignUp_MouseEnter(object sender, EventArgs e)
        {
            SignUp.Cursor = Cursors.Hand;
        }

        private void SignUp_MouseLeave(object sender, EventArgs e)
        {
            SignUp.Cursor = Cursors.Default;
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            int spacing = 15;

            // إجمالي الارتفاع اللي هنحتاجه (من غير SignUp و DontHave لأنهم جنب بعض)
            int totalHeight = Signin.Height + UserName.Height + Password.Height + Login.Height + errorname.Height + errorpass.Height
                              + Math.Max(SignUp.Height, DontHave.Height) // صف واحد
                              + (spacing * 4);

            int startY = (this.ClientSize.Height / 2) - (totalHeight / 2);

            CenterControl(Signin, ref startY, spacing);
            CenterControl(UserName, ref startY, spacing);

            // Set error label width to match textbox width before centering
            errorname.Width = UserName.Width;
            CenterControl(errorname, ref startY, 3);

            CenterControl(Password, ref startY, spacing);

            errorpass.Width = Password.Width;
            CenterControl(errorpass, ref startY, 3);

            CenterControl(Login, ref startY, spacing);

            CenterControlsSideBySide(DontHave, SignUp, ref startY, spacing);
        }

        private void CenterControl(Control ctrl, ref int startY, int spacing)
        {
            ctrl.Left = (this.ClientSize.Width - ctrl.Width) / 2;
            ctrl.Top = startY;
            startY += ctrl.Height + spacing;
        }

        private void CenterControlsSideBySide(Control leftCtrl, Control rightCtrl, ref int startY, int spacing)
        {
            // المسافة بينهم
            int controlsSpacing = 5;

            // إجمالي العرض = عرض الاثنين + المسافة
            int totalWidth = leftCtrl.Width + controlsSpacing + rightCtrl.Width;

            // بداية X علشان يبقوا في النص
            int startX = (this.ClientSize.Width - totalWidth) / 2;

            // ضبط أول واحد (الشمال)
            leftCtrl.Left = startX;
            leftCtrl.Top = startY;

            // ضبط الثاني (اليمين)
            rightCtrl.Left = startX + leftCtrl.Width + controlsSpacing;
            rightCtrl.Top = startY;

            // نزود المسافة للّي بعدهم
            startY += Math.Max(leftCtrl.Height, rightCtrl.Height) + spacing;
        }


        private void LoginPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (!ValidateAllFields())
                return;
            string username = UserName.Text;
            string password = Password.Text;
            var user = db.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user != null)
            {
                // Successful login
                MessageBox.Show("Login successful!");
                // Pass the user to the dashboard
                var receptionistDashboard = new ReceptionistDashboard(user);
                receptionistDashboard.Show();
                this.Hide();
            }
            else
            {
                // Invalid credentials
                MessageBox.Show("Invalid username or password.");
            }
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
            bool valid1 = ValidateField(UserName, errorname, "Username");
            bool valid2 = ValidateField(Password, errorpass, "Password");
            return valid1 && valid2;
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            ValidateField(Password, errorpass, "Password");

        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {
            ValidateField(UserName, errorname, "Username");
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            ValidateField(Password, errorpass, "Password");
        }

        private void UserName_Leave(object sender, EventArgs e)
        {
            ValidateField(UserName, errorname, "Username");
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
