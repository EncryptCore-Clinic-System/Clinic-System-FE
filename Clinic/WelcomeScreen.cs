using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Clinic
{
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
              
                   }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var signUpPage = new SignUpPage();
            signUpPage.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }

        private void WelcomeScreen_Load(object sender, EventArgs e)
        {
            int spacing = 20;

            // احسب الطول الكلي (بما فيهم الزرارين)
            int totalHeight = picture.Height + label.Height
                              + Math.Max(button1.Height, button2.Height)
                              + (spacing * 4);

            int startY = (this.ClientSize.Height / 2) - (totalHeight / 2);

            // Center picture و label
            CenterControl(picture, ref startY, spacing);
            CenterControl(label, ref startY, spacing);

            // زرار Sign Up
            button1.Text = "Log In";
            button1.Image = ResizeImage(picture1.Image, 32, 32); // الصورة resized
            button1.ImageAlign = ContentAlignment.MiddleLeft;    // الصورة شمال
            button1.TextAlign = ContentAlignment.MiddleCenter;   // النص في النص
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;

            // زرار Log In
            button2.Text = "Sign Up";
            button2.Image = ResizeImage(picture2.Image, 32, 32);
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.TextAlign = ContentAlignment.MiddleCenter;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;

            picture1.Visible = false;
            picture2.Visible = false;

            // حطهم جنب بعض
            CenterControlsSideBySide(button1, button2, ref startY, spacing);
        }

        private System.Drawing.Image ResizeImage(System.Drawing.Image imgToResize, int width, int height)
        {
            // نحدد الحجم الجديد
            Size size = new Size(width, height);

            // نعمل صورة جديدة فاضية بالحجم اللي عايزينه
            Bitmap b = new Bitmap(size.Width, size.Height);

            // نرسم الصورة الأصلية على الصورة الجديدة لكن بالمقاس الجديد
            using (Graphics g = Graphics.FromImage((System.Drawing.Image)b))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(imgToResize, 0, 0, size.Width, size.Height);
            }

            return (System.Drawing.Image)b; // نرجع الصورة الجديدة
        }

        // دوال الترتيب زي ما هي
        private void CenterControl(Control ctrl, ref int startY, int spacing)
        {
            ctrl.Left = (this.ClientSize.Width - ctrl.Width) / 2;
            ctrl.Top = startY;
            startY += ctrl.Height + spacing;
        }

        private void CenterControlsSideBySide(Control leftCtrl, Control rightCtrl, ref int startY, int spacing)
        {
            int controlsSpacing = 100;
            int totalWidth = leftCtrl.Width + controlsSpacing + rightCtrl.Width;
            int startX = (this.ClientSize.Width - totalWidth) / 2;

            leftCtrl.Left = startX;
            leftCtrl.Top = startY;

            rightCtrl.Left = startX + leftCtrl.Width + controlsSpacing;
            rightCtrl.Top = startY;

            startY += Math.Max(leftCtrl.Height, rightCtrl.Height) + spacing;
        }
    }
    
}
