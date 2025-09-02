namespace Clinic
{
    partial class PatientForm
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
            this.ExistingPatient = new Guna.UI2.WinForms.Guna2RadioButton();
            this.NewPatient = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PatientName = new Guna.UI2.WinForms.Guna2TextBox();
            this.PatientAge = new Guna.UI2.WinForms.Guna2TextBox();
            this.PatientVisitType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.PatientPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.PatientAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.ExistingPatients = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ExistingVisitType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.AddPatientBTN = new Guna.UI2.WinForms.Guna2Button();
            this.AddExistingPatient = new Guna.UI2.WinForms.Guna2Button();
            this.ErrorLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ErrorLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ErrorLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ErrorLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ErrorLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ErrorLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PatientGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // ExistingPatient
            // 
            this.ExistingPatient.AutoSize = true;
            this.ExistingPatient.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ExistingPatient.CheckedState.BorderThickness = 0;
            this.ExistingPatient.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ExistingPatient.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ExistingPatient.CheckedState.InnerOffset = -4;
            this.ExistingPatient.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExistingPatient.Location = new System.Drawing.Point(162, 77);
            this.ExistingPatient.Name = "ExistingPatient";
            this.ExistingPatient.Size = new System.Drawing.Size(113, 21);
            this.ExistingPatient.TabIndex = 0;
            this.ExistingPatient.Text = "Existing Patient";
            this.ExistingPatient.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ExistingPatient.UncheckedState.BorderThickness = 2;
            this.ExistingPatient.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.ExistingPatient.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.ExistingPatient.CheckedChanged += new System.EventHandler(this.guna2RadioButton1_CheckedChanged);
            // 
            // NewPatient
            // 
            this.NewPatient.AutoSize = true;
            this.NewPatient.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NewPatient.CheckedState.BorderThickness = 0;
            this.NewPatient.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NewPatient.CheckedState.InnerColor = System.Drawing.Color.White;
            this.NewPatient.CheckedState.InnerOffset = -4;
            this.NewPatient.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPatient.Location = new System.Drawing.Point(162, 104);
            this.NewPatient.Name = "NewPatient";
            this.NewPatient.Size = new System.Drawing.Size(95, 21);
            this.NewPatient.TabIndex = 1;
            this.NewPatient.Text = "New Patient";
            this.NewPatient.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.NewPatient.UncheckedState.BorderThickness = 2;
            this.NewPatient.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.NewPatient.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.NewPatient.CheckedChanged += new System.EventHandler(this.NewPatient_CheckedChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Teal;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(275, 22);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(186, 32);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "New Appointment";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // PatientName
            // 
            this.PatientName.BorderRadius = 17;
            this.PatientName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PatientName.DefaultText = "";
            this.PatientName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PatientName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PatientName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PatientName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PatientName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatientName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PatientName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatientName.Location = new System.Drawing.Point(162, 143);
            this.PatientName.Name = "PatientName";
            this.PatientName.PlaceholderText = "Patient Name";
            this.PatientName.SelectedText = "";
            this.PatientName.Size = new System.Drawing.Size(233, 36);
            this.PatientName.TabIndex = 3;
            this.PatientName.Visible = false;
            // 
            // PatientAge
            // 
            this.PatientAge.BorderRadius = 17;
            this.PatientAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PatientAge.DefaultText = "";
            this.PatientAge.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PatientAge.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PatientAge.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PatientAge.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PatientAge.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatientAge.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PatientAge.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatientAge.Location = new System.Drawing.Point(162, 185);
            this.PatientAge.Name = "PatientAge";
            this.PatientAge.PlaceholderText = "Age";
            this.PatientAge.SelectedText = "";
            this.PatientAge.Size = new System.Drawing.Size(233, 36);
            this.PatientAge.TabIndex = 4;
            this.PatientAge.Visible = false;
            // 
            // PatientVisitType
            // 
            this.PatientVisitType.BackColor = System.Drawing.Color.Transparent;
            this.PatientVisitType.BorderRadius = 17;
            this.PatientVisitType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.PatientVisitType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PatientVisitType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatientVisitType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatientVisitType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PatientVisitType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.PatientVisitType.ItemHeight = 30;
            this.PatientVisitType.Location = new System.Drawing.Point(162, 269);
            this.PatientVisitType.Name = "PatientVisitType";
            this.PatientVisitType.Size = new System.Drawing.Size(233, 36);
            this.PatientVisitType.TabIndex = 6;
            this.PatientVisitType.Visible = false;
            // 
            // PatientPhone
            // 
            this.PatientPhone.BorderRadius = 17;
            this.PatientPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PatientPhone.DefaultText = "";
            this.PatientPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PatientPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PatientPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PatientPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PatientPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatientPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PatientPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatientPhone.Location = new System.Drawing.Point(162, 311);
            this.PatientPhone.Name = "PatientPhone";
            this.PatientPhone.PlaceholderText = "Phone no.";
            this.PatientPhone.SelectedText = "";
            this.PatientPhone.Size = new System.Drawing.Size(233, 36);
            this.PatientPhone.TabIndex = 7;
            this.PatientPhone.Visible = false;
            // 
            // PatientAddress
            // 
            this.PatientAddress.BorderRadius = 17;
            this.PatientAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PatientAddress.DefaultText = "";
            this.PatientAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PatientAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PatientAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PatientAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PatientAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatientAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PatientAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatientAddress.Location = new System.Drawing.Point(162, 353);
            this.PatientAddress.Name = "PatientAddress";
            this.PatientAddress.PlaceholderText = "Address";
            this.PatientAddress.SelectedText = "";
            this.PatientAddress.Size = new System.Drawing.Size(233, 36);
            this.PatientAddress.TabIndex = 8;
            this.PatientAddress.Visible = false;
            // 
            // ExistingPatients
            // 
            this.ExistingPatients.BackColor = System.Drawing.Color.Transparent;
            this.ExistingPatients.BorderRadius = 17;
            this.ExistingPatients.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ExistingPatients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExistingPatients.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ExistingPatients.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ExistingPatients.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ExistingPatients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ExistingPatients.ItemHeight = 30;
            this.ExistingPatients.Location = new System.Drawing.Point(162, 143);
            this.ExistingPatients.Name = "ExistingPatients";
            this.ExistingPatients.Size = new System.Drawing.Size(233, 36);
            this.ExistingPatients.TabIndex = 9;
            this.ExistingPatients.Visible = false;
            // 
            // ExistingVisitType
            // 
            this.ExistingVisitType.BackColor = System.Drawing.Color.Transparent;
            this.ExistingVisitType.BorderRadius = 17;
            this.ExistingVisitType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ExistingVisitType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExistingVisitType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ExistingVisitType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ExistingVisitType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ExistingVisitType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ExistingVisitType.ItemHeight = 30;
            this.ExistingVisitType.Location = new System.Drawing.Point(162, 185);
            this.ExistingVisitType.Name = "ExistingVisitType";
            this.ExistingVisitType.Size = new System.Drawing.Size(233, 36);
            this.ExistingVisitType.TabIndex = 10;
            this.ExistingVisitType.Visible = false;
            // 
            // AddPatientBTN
            // 
            this.AddPatientBTN.BorderRadius = 17;
            this.AddPatientBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddPatientBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddPatientBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddPatientBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddPatientBTN.FillColor = System.Drawing.Color.Teal;
            this.AddPatientBTN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPatientBTN.ForeColor = System.Drawing.Color.White;
            this.AddPatientBTN.Location = new System.Drawing.Point(162, 396);
            this.AddPatientBTN.Name = "AddPatientBTN";
            this.AddPatientBTN.Size = new System.Drawing.Size(233, 45);
            this.AddPatientBTN.TabIndex = 11;
            this.AddPatientBTN.Text = "Add Patient";
            this.AddPatientBTN.Visible = false;
            this.AddPatientBTN.Click += new System.EventHandler(this.AddPatientBTN_Click);
            // 
            // AddExistingPatient
            // 
            this.AddExistingPatient.BorderRadius = 17;
            this.AddExistingPatient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddExistingPatient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddExistingPatient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddExistingPatient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddExistingPatient.FillColor = System.Drawing.Color.Teal;
            this.AddExistingPatient.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddExistingPatient.ForeColor = System.Drawing.Color.White;
            this.AddExistingPatient.Location = new System.Drawing.Point(162, 218);
            this.AddExistingPatient.Name = "AddExistingPatient";
            this.AddExistingPatient.Size = new System.Drawing.Size(233, 45);
            this.AddExistingPatient.TabIndex = 12;
            this.AddExistingPatient.Text = "Add Patient";
            this.AddExistingPatient.Visible = false;
            this.AddExistingPatient.Click += new System.EventHandler(this.AddExistingPatient_Click);
            // 
            // ErrorLabel1
            // 
            this.ErrorLabel1.BackColor = System.Drawing.Color.Transparent;
            this.ErrorLabel1.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel1.Location = new System.Drawing.Point(402, 152);
            this.ErrorLabel1.Name = "ErrorLabel1";
            this.ErrorLabel1.Size = new System.Drawing.Size(58, 15);
            this.ErrorLabel1.TabIndex = 13;
            this.ErrorLabel1.Text = "ErrorLabel1";
            this.ErrorLabel1.Visible = false;
            // 
            // ErrorLabel2
            // 
            this.ErrorLabel2.BackColor = System.Drawing.Color.Transparent;
            this.ErrorLabel2.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel2.Location = new System.Drawing.Point(402, 196);
            this.ErrorLabel2.Name = "ErrorLabel2";
            this.ErrorLabel2.Size = new System.Drawing.Size(58, 15);
            this.ErrorLabel2.TabIndex = 14;
            this.ErrorLabel2.Text = "ErrorLabel1";
            this.ErrorLabel2.Visible = false;
            // 
            // ErrorLabel3
            // 
            this.ErrorLabel3.BackColor = System.Drawing.Color.Transparent;
            this.ErrorLabel3.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel3.Location = new System.Drawing.Point(401, 239);
            this.ErrorLabel3.Name = "ErrorLabel3";
            this.ErrorLabel3.Size = new System.Drawing.Size(58, 15);
            this.ErrorLabel3.TabIndex = 15;
            this.ErrorLabel3.Text = "ErrorLabel1";
            this.ErrorLabel3.Visible = false;
            // 
            // ErrorLabel4
            // 
            this.ErrorLabel4.BackColor = System.Drawing.Color.Transparent;
            this.ErrorLabel4.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel4.Location = new System.Drawing.Point(401, 280);
            this.ErrorLabel4.Name = "ErrorLabel4";
            this.ErrorLabel4.Size = new System.Drawing.Size(58, 15);
            this.ErrorLabel4.TabIndex = 16;
            this.ErrorLabel4.Text = "ErrorLabel1";
            this.ErrorLabel4.Visible = false;
            // 
            // ErrorLabel5
            // 
            this.ErrorLabel5.BackColor = System.Drawing.Color.Transparent;
            this.ErrorLabel5.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel5.Location = new System.Drawing.Point(401, 322);
            this.ErrorLabel5.Name = "ErrorLabel5";
            this.ErrorLabel5.Size = new System.Drawing.Size(58, 15);
            this.ErrorLabel5.TabIndex = 17;
            this.ErrorLabel5.Text = "ErrorLabel1";
            this.ErrorLabel5.Visible = false;
            // 
            // ErrorLabel6
            // 
            this.ErrorLabel6.BackColor = System.Drawing.Color.Transparent;
            this.ErrorLabel6.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel6.Location = new System.Drawing.Point(402, 363);
            this.ErrorLabel6.Name = "ErrorLabel6";
            this.ErrorLabel6.Size = new System.Drawing.Size(58, 15);
            this.ErrorLabel6.TabIndex = 18;
            this.ErrorLabel6.Text = "ErrorLabel1";
            this.ErrorLabel6.Visible = false;
            // 
            // PatientGender
            // 
            this.PatientGender.BackColor = System.Drawing.Color.Transparent;
            this.PatientGender.BorderRadius = 17;
            this.PatientGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.PatientGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PatientGender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatientGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatientGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PatientGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.PatientGender.ItemHeight = 30;
            this.PatientGender.Location = new System.Drawing.Point(162, 227);
            this.PatientGender.Name = "PatientGender";
            this.PatientGender.Size = new System.Drawing.Size(233, 36);
            this.PatientGender.TabIndex = 19;
            this.PatientGender.Visible = false;
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.PatientGender);
            this.Controls.Add(this.ErrorLabel6);
            this.Controls.Add(this.ErrorLabel5);
            this.Controls.Add(this.ErrorLabel4);
            this.Controls.Add(this.ErrorLabel3);
            this.Controls.Add(this.ErrorLabel2);
            this.Controls.Add(this.ErrorLabel1);
            this.Controls.Add(this.AddExistingPatient);
            this.Controls.Add(this.AddPatientBTN);
            this.Controls.Add(this.ExistingVisitType);
            this.Controls.Add(this.ExistingPatients);
            this.Controls.Add(this.PatientAddress);
            this.Controls.Add(this.PatientPhone);
            this.Controls.Add(this.PatientVisitType);
            this.Controls.Add(this.PatientAge);
            this.Controls.Add(this.PatientName);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.NewPatient);
            this.Controls.Add(this.ExistingPatient);
            this.Name = "PatientForm";
            this.Text = "PatientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2RadioButton ExistingPatient;
        private Guna.UI2.WinForms.Guna2RadioButton NewPatient;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox PatientName;
        private Guna.UI2.WinForms.Guna2TextBox PatientAge;
        private Guna.UI2.WinForms.Guna2ComboBox PatientVisitType;
        private Guna.UI2.WinForms.Guna2TextBox PatientPhone;
        private Guna.UI2.WinForms.Guna2TextBox PatientAddress;
        private Guna.UI2.WinForms.Guna2ComboBox ExistingPatients;
        private Guna.UI2.WinForms.Guna2ComboBox ExistingVisitType;
        private Guna.UI2.WinForms.Guna2Button AddPatientBTN;
        private Guna.UI2.WinForms.Guna2Button AddExistingPatient;
        private Guna.UI2.WinForms.Guna2HtmlLabel ErrorLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel ErrorLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel ErrorLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel ErrorLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel ErrorLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel ErrorLabel6;
        private Guna.UI2.WinForms.Guna2ComboBox PatientGender;
    }
}