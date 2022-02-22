
namespace Project2WFA
{
    partial class Form1
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
            this.f_nameLabel = new System.Windows.Forms.Label();
            this.f_nameValue = new System.Windows.Forms.TextBox();
            this.l_nameValue = new System.Windows.Forms.TextBox();
            this.l_nameLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.dobValue = new System.Windows.Forms.DateTimePicker();
            this.idnumValue = new System.Windows.Forms.TextBox();
            this.idnumLabel = new System.Windows.Forms.Label();
            this.phoneValue = new System.Windows.Forms.TextBox();
            this.phonLabel = new System.Windows.Forms.Label();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressValue = new System.Windows.Forms.RichTextBox();
            this.profileLabel = new System.Windows.Forms.Label();
            this.profile_pictureBox = new System.Windows.Forms.PictureBox();
            this.choosefilebutton = new System.Windows.Forms.Button();
            this.profile_pictureLabel = new System.Windows.Forms.Label();
            this.submitbutton = new System.Windows.Forms.Button();
            this.resetbutton = new System.Windows.Forms.Button();
            this.genderLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.genderPanel = new System.Windows.Forms.Panel();
            this.gender_fButton = new System.Windows.Forms.RadioButton();
            this.gender_mButton = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.status_graduatedButton = new System.Windows.Forms.RadioButton();
            this.status_studyingButton = new System.Windows.Forms.RadioButton();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.profile_pictureBox)).BeginInit();
            this.genderPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // f_nameLabel
            // 
            this.f_nameLabel.Location = new System.Drawing.Point(50, 51);
            this.f_nameLabel.Name = "f_nameLabel";
            this.f_nameLabel.Size = new System.Drawing.Size(112, 26);
            this.f_nameLabel.TabIndex = 0;
            this.f_nameLabel.Text = "First Name";
            this.f_nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.f_nameLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // f_nameValue
            // 
            this.f_nameValue.Location = new System.Drawing.Point(168, 51);
            this.f_nameValue.Name = "f_nameValue";
            this.f_nameValue.Size = new System.Drawing.Size(416, 26);
            this.f_nameValue.TabIndex = 1;
            this.f_nameValue.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // l_nameValue
            // 
            this.l_nameValue.Location = new System.Drawing.Point(168, 115);
            this.l_nameValue.Name = "l_nameValue";
            this.l_nameValue.Size = new System.Drawing.Size(416, 26);
            this.l_nameValue.TabIndex = 3;
            this.l_nameValue.TextChanged += new System.EventHandler(this.l_nameValue_TextChanged);
            // 
            // l_nameLabel
            // 
            this.l_nameLabel.Location = new System.Drawing.Point(50, 115);
            this.l_nameLabel.Name = "l_nameLabel";
            this.l_nameLabel.Size = new System.Drawing.Size(112, 26);
            this.l_nameLabel.TabIndex = 2;
            this.l_nameLabel.Text = "Last Name";
            this.l_nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dobLabel
            // 
            this.dobLabel.Location = new System.Drawing.Point(50, 178);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(112, 26);
            this.dobLabel.TabIndex = 4;
            this.dobLabel.Text = "Date of Birth";
            this.dobLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dobValue
            // 
            this.dobValue.CustomFormat = "dd/MM/yyyy";
            this.dobValue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dobValue.Location = new System.Drawing.Point(168, 178);
            this.dobValue.Name = "dobValue";
            this.dobValue.Size = new System.Drawing.Size(416, 26);
            this.dobValue.TabIndex = 6;
            this.dobValue.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // idnumValue
            // 
            this.idnumValue.Location = new System.Drawing.Point(168, 243);
            this.idnumValue.Name = "idnumValue";
            this.idnumValue.Size = new System.Drawing.Size(416, 26);
            this.idnumValue.TabIndex = 8;
            this.idnumValue.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // idnumLabel
            // 
            this.idnumLabel.Location = new System.Drawing.Point(50, 243);
            this.idnumLabel.Name = "idnumLabel";
            this.idnumLabel.Size = new System.Drawing.Size(112, 26);
            this.idnumLabel.TabIndex = 7;
            this.idnumLabel.Text = "ID Number";
            this.idnumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // phoneValue
            // 
            this.phoneValue.Location = new System.Drawing.Point(168, 308);
            this.phoneValue.Name = "phoneValue";
            this.phoneValue.Size = new System.Drawing.Size(416, 26);
            this.phoneValue.TabIndex = 10;
            // 
            // phonLabel
            // 
            this.phonLabel.Location = new System.Drawing.Point(50, 308);
            this.phonLabel.Name = "phonLabel";
            this.phonLabel.Size = new System.Drawing.Size(112, 26);
            this.phonLabel.TabIndex = 9;
            this.phonLabel.Text = "Phone";
            this.phonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // emailValue
            // 
            this.emailValue.Location = new System.Drawing.Point(168, 371);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(416, 26);
            this.emailValue.TabIndex = 12;
            // 
            // emailLabel
            // 
            this.emailLabel.Location = new System.Drawing.Point(50, 371);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(112, 26);
            this.emailLabel.TabIndex = 11;
            this.emailLabel.Text = "Email";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addressLabel
            // 
            this.addressLabel.Location = new System.Drawing.Point(50, 558);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(112, 26);
            this.addressLabel.TabIndex = 17;
            this.addressLabel.Text = "Address";
            this.addressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addressLabel.Click += new System.EventHandler(this.label8_Click);
            // 
            // addressValue
            // 
            this.addressValue.Location = new System.Drawing.Point(168, 558);
            this.addressValue.Name = "addressValue";
            this.addressValue.Size = new System.Drawing.Size(416, 93);
            this.addressValue.TabIndex = 19;
            this.addressValue.Text = "";
            this.addressValue.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // profileLabel
            // 
            this.profileLabel.Location = new System.Drawing.Point(50, 691);
            this.profileLabel.Name = "profileLabel";
            this.profileLabel.Size = new System.Drawing.Size(112, 26);
            this.profileLabel.TabIndex = 20;
            this.profileLabel.Text = "Profile";
            this.profileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // profile_pictureBox
            // 
            this.profile_pictureBox.Image = global::Project2WFA.Properties.Resources.man;
            this.profile_pictureBox.Location = new System.Drawing.Point(168, 691);
            this.profile_pictureBox.Name = "profile_pictureBox";
            this.profile_pictureBox.Size = new System.Drawing.Size(150, 200);
            this.profile_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profile_pictureBox.TabIndex = 22;
            this.profile_pictureBox.TabStop = false;
            this.profile_pictureBox.Click += new System.EventHandler(this.profile_pictureBox_Click);
            // 
            // choosefilebutton
            // 
            this.choosefilebutton.Location = new System.Drawing.Point(168, 929);
            this.choosefilebutton.Name = "choosefilebutton";
            this.choosefilebutton.Size = new System.Drawing.Size(150, 45);
            this.choosefilebutton.TabIndex = 23;
            this.choosefilebutton.Text = "Choose file";
            this.choosefilebutton.UseVisualStyleBackColor = true;
            this.choosefilebutton.Click += new System.EventHandler(this.choosefilebutton_Click);
            // 
            // profile_pictureLabel
            // 
            this.profile_pictureLabel.Location = new System.Drawing.Point(324, 935);
            this.profile_pictureLabel.Name = "profile_pictureLabel";
            this.profile_pictureLabel.Size = new System.Drawing.Size(166, 32);
            this.profile_pictureLabel.TabIndex = 24;
            this.profile_pictureLabel.Text = "No file chosen.";
            this.profile_pictureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profile_pictureLabel.Click += new System.EventHandler(this.profile_pictureLabel_Click);
            // 
            // submitbutton
            // 
            this.submitbutton.Location = new System.Drawing.Point(358, 1005);
            this.submitbutton.Name = "submitbutton";
            this.submitbutton.Size = new System.Drawing.Size(162, 31);
            this.submitbutton.TabIndex = 25;
            this.submitbutton.Text = "Submit";
            this.submitbutton.UseVisualStyleBackColor = true;
            this.submitbutton.Click += new System.EventHandler(this.submitbutton_Click);
            // 
            // resetbutton
            // 
            this.resetbutton.Location = new System.Drawing.Point(526, 1005);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(162, 31);
            this.resetbutton.TabIndex = 26;
            this.resetbutton.Text = "Reset";
            this.resetbutton.UseVisualStyleBackColor = true;
            this.resetbutton.Click += new System.EventHandler(this.button3_Click);
            // 
            // genderLabel
            // 
            this.genderLabel.Location = new System.Drawing.Point(50, 434);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(112, 26);
            this.genderLabel.TabIndex = 13;
            this.genderLabel.Text = "Gender";
            this.genderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusLabel
            // 
            this.statusLabel.Location = new System.Drawing.Point(50, 495);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(112, 26);
            this.statusLabel.TabIndex = 27;
            this.statusLabel.Text = "Status";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // genderPanel
            // 
            this.genderPanel.Controls.Add(this.gender_fButton);
            this.genderPanel.Controls.Add(this.gender_mButton);
            this.genderPanel.Location = new System.Drawing.Point(168, 434);
            this.genderPanel.Name = "genderPanel";
            this.genderPanel.Size = new System.Drawing.Size(416, 26);
            this.genderPanel.TabIndex = 28;
            this.genderPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.genderPanel_Paint);
            // 
            // gender_fButton
            // 
            this.gender_fButton.AutoSize = true;
            this.gender_fButton.Location = new System.Drawing.Point(160, 3);
            this.gender_fButton.Name = "gender_fButton";
            this.gender_fButton.Size = new System.Drawing.Size(87, 24);
            this.gender_fButton.TabIndex = 1;
            this.gender_fButton.TabStop = true;
            this.gender_fButton.Text = "Female";
            this.gender_fButton.UseVisualStyleBackColor = true;
            this.gender_fButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // gender_mButton
            // 
            this.gender_mButton.AutoSize = true;
            this.gender_mButton.Location = new System.Drawing.Point(0, 3);
            this.gender_mButton.Name = "gender_mButton";
            this.gender_mButton.Size = new System.Drawing.Size(68, 24);
            this.gender_mButton.TabIndex = 0;
            this.gender_mButton.TabStop = true;
            this.gender_mButton.Text = "Male";
            this.gender_mButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.status_graduatedButton);
            this.panel2.Controls.Add(this.status_studyingButton);
            this.panel2.Location = new System.Drawing.Point(168, 495);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 26);
            this.panel2.TabIndex = 29;
            // 
            // status_graduatedButton
            // 
            this.status_graduatedButton.AutoSize = true;
            this.status_graduatedButton.Location = new System.Drawing.Point(160, 3);
            this.status_graduatedButton.Name = "status_graduatedButton";
            this.status_graduatedButton.Size = new System.Drawing.Size(111, 24);
            this.status_graduatedButton.TabIndex = 1;
            this.status_graduatedButton.TabStop = true;
            this.status_graduatedButton.Text = "Graduated";
            this.status_graduatedButton.UseVisualStyleBackColor = true;
            // 
            // status_studyingButton
            // 
            this.status_studyingButton.AutoSize = true;
            this.status_studyingButton.Location = new System.Drawing.Point(0, 3);
            this.status_studyingButton.Name = "status_studyingButton";
            this.status_studyingButton.Size = new System.Drawing.Size(96, 24);
            this.status_studyingButton.TabIndex = 0;
            this.status_studyingButton.TabStop = true;
            this.status_studyingButton.Text = "Studying";
            this.status_studyingButton.UseVisualStyleBackColor = true;
            // 
            // openFD
            // 
            this.openFD.FileName = "openFileDialog1";
            this.openFD.FileOk += new System.ComponentModel.CancelEventHandler(this.openFD_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 1060);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.genderPanel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.resetbutton);
            this.Controls.Add(this.submitbutton);
            this.Controls.Add(this.profile_pictureLabel);
            this.Controls.Add(this.choosefilebutton);
            this.Controls.Add(this.profile_pictureBox);
            this.Controls.Add(this.profileLabel);
            this.Controls.Add(this.addressValue);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.emailValue);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.phoneValue);
            this.Controls.Add(this.phonLabel);
            this.Controls.Add(this.idnumValue);
            this.Controls.Add(this.idnumLabel);
            this.Controls.Add(this.dobValue);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.l_nameValue);
            this.Controls.Add(this.l_nameLabel);
            this.Controls.Add(this.f_nameValue);
            this.Controls.Add(this.f_nameLabel);
            this.Name = "Form1";
            this.Text = "Personal Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profile_pictureBox)).EndInit();
            this.genderPanel.ResumeLayout(false);
            this.genderPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label f_nameLabel;
        private System.Windows.Forms.TextBox f_nameValue;
        private System.Windows.Forms.TextBox l_nameValue;
        private System.Windows.Forms.Label l_nameLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.DateTimePicker dobValue;
        private System.Windows.Forms.TextBox idnumValue;
        private System.Windows.Forms.Label idnumLabel;
        private System.Windows.Forms.TextBox phoneValue;
        private System.Windows.Forms.Label phonLabel;
        private System.Windows.Forms.TextBox emailValue;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.RichTextBox addressValue;
        private System.Windows.Forms.Label profileLabel;
        private System.Windows.Forms.PictureBox profile_pictureBox;
        private System.Windows.Forms.Button choosefilebutton;
        private System.Windows.Forms.Label profile_pictureLabel;
        private System.Windows.Forms.Button submitbutton;
        private System.Windows.Forms.Button resetbutton;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Panel genderPanel;
        private System.Windows.Forms.RadioButton gender_fButton;
        private System.Windows.Forms.RadioButton gender_mButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton status_graduatedButton;
        private System.Windows.Forms.RadioButton status_studyingButton;
        private System.Windows.Forms.OpenFileDialog openFD;
    }
}

