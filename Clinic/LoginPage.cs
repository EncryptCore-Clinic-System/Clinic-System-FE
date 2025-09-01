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
            int totalHeight = Signin.Height + UserName.Height + Password.Height + Login.Height
                              + Math.Max(SignUp.Height, DontHave.Height) // صف واحد
                              + (spacing * 4);

            int startY = (this.ClientSize.Height / 2) - (totalHeight / 2);

            // الترتيب تحت بعض
            CenterControl(Signin, ref startY, spacing);
            CenterControl(UserName, ref startY, spacing);
            CenterControl(Password, ref startY, spacing);
            CenterControl(Login, ref startY, spacing);

            // SignUp + DontHave جنب بعض
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
            string username = UserName.Text;
            string password = Password.Text;
            var user = db.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user != null)
            {
                // Successful login
                MessageBox.Show("Login successful!");
                //Open the main application form

                //Patient patient = new Patient()
                //patient.Show();
                //this.Hide();
            }
            else
            {
                // Invalid credentials
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
