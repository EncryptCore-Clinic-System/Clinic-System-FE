using System;

namespace Clinic
{
    partial class LoginPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.SignUp = new System.Windows.Forms.Label();
            this.DontHave = new System.Windows.Forms.Label();
            this.Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.UserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.Login = new Guna.UI2.WinForms.Guna2Button();
            this.Signin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.SignUp);
            this.panel1.Controls.Add(this.DontHave);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.UserName);
            this.panel1.Controls.Add(this.Login);
            this.panel1.Controls.Add(this.Signin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 1011);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SignUp
            // 
            this.SignUp.AutoSize = true;
            this.SignUp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp.ForeColor = System.Drawing.Color.DarkCyan;
            this.SignUp.Location = new System.Drawing.Point(1416, 916);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(85, 28);
            this.SignUp.TabIndex = 8;
            this.SignUp.Text = "Sign Up";
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            this.SignUp.Enter += new System.EventHandler(this.SignUp_MouseEnter);
            this.SignUp.Leave += new System.EventHandler(this.SignUp_MouseLeave);
            // 
            // DontHave
            // 
            this.DontHave.AutoSize = true;
            this.DontHave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DontHave.Location = new System.Drawing.Point(1154, 916);
            this.DontHave.Name = "DontHave";
            this.DontHave.Size = new System.Drawing.Size(273, 96);
            this.DontHave.TabIndex = 7;
            this.DontHave.Text = "Don\'t have an account? \r\n\r\n\r\n";
            this.DontHave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Password
            // 
            this.Password.BorderRadius = 25;
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.DefaultText = "";
            this.Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password.Location = new System.Drawing.Point(1098, 702);
            this.Password.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Password.Name = "Password";
            this.Password.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.Password.PlaceholderText = "   Password";
            this.Password.SelectedText = "";
            this.Password.Size = new System.Drawing.Size(442, 70);
            this.Password.TabIndex = 6;
            this.Password.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // UserName
            // 
            this.UserName.BorderRadius = 25;
            this.UserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserName.DefaultText = "";
            this.UserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserName.Location = new System.Drawing.Point(1098, 583);
            this.UserName.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.UserName.Name = "UserName";
            this.UserName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.UserName.PlaceholderText = "   Enter User Name";
            this.UserName.SelectedText = "";
            this.UserName.Size = new System.Drawing.Size(442, 70);
            this.UserName.TabIndex = 5;
            // 
            // Login
            // 
            this.Login.BorderRadius = 25;
            this.Login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Login.FillColor = System.Drawing.Color.Teal;
            this.Login.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.White;
            this.Login.Location = new System.Drawing.Point(1098, 818);
            this.Login.Name = "Login";
            this.Login.PressedDepth = 50;
            this.Login.Size = new System.Drawing.Size(442, 75);
            this.Login.TabIndex = 4;
            this.Login.Text = "Log in";
            this.Login.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Signin
            // 
            this.Signin.AutoSize = true;
            this.Signin.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signin.ForeColor = System.Drawing.Color.Teal;
            this.Signin.Location = new System.Drawing.Point(1186, 384);
            this.Signin.Name = "Signin";
            this.Signin.Size = new System.Drawing.Size(276, 96);
            this.Signin.TabIndex = 1;
            this.Signin.Text = "Sign In";
            this.Signin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1011);
            this.Controls.Add(this.panel1);
            this.Name = "LoginPage";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Log In";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginPage_FormClosing);
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Signin;
        private Guna.UI2.WinForms.Guna2Button Login;
        private Guna.UI2.WinForms.Guna2TextBox Password;
        private Guna.UI2.WinForms.Guna2TextBox UserName;
        private System.Windows.Forms.Label DontHave;
        private System.Windows.Forms.Label SignUp;
    }
}

