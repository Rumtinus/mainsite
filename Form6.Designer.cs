namespace mainsite
{
    partial class Form6
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
            btnBackStudent = new Button();
            btnSaveStudent = new Button();
            txtNameStudent = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtLastnameStudent = new TextBox();
            label3 = new Label();
            txtStudentNumber = new TextBox();
            label4 = new Label();
            lblErrorStudentName = new Label();
            lblErrorStudentLastname = new Label();
            lblErrorStudentNumber = new Label();
            SuspendLayout();
            // 
            // btnBackStudent
            // 
            btnBackStudent.Location = new Point(91, 254);
            btnBackStudent.Name = "btnBackStudent";
            btnBackStudent.Size = new Size(75, 27);
            btnBackStudent.TabIndex = 0;
            btnBackStudent.Text = "بازگشت";
            btnBackStudent.UseVisualStyleBackColor = true;
            btnBackStudent.Click += btnBackStudent_Click;
            // 
            // btnSaveStudent
            // 
            btnSaveStudent.Location = new Point(209, 254);
            btnSaveStudent.Name = "btnSaveStudent";
            btnSaveStudent.Size = new Size(75, 27);
            btnSaveStudent.TabIndex = 1;
            btnSaveStudent.Text = "ذخیره";
            btnSaveStudent.UseVisualStyleBackColor = true;
            btnSaveStudent.Click += btnSaveStudent_Click;
            // 
            // txtNameStudent
            // 
            txtNameStudent.Location = new Point(91, 101);
            txtNameStudent.Name = "txtNameStudent";
            txtNameStudent.RightToLeft = RightToLeft.Yes;
            txtNameStudent.Size = new Size(193, 23);
            txtNameStudent.TabIndex = 2;
            txtNameStudent.Click += txtNameStudent_Click;
            txtNameStudent.TextChanged += txtNameStudent_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(290, 104);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(24, 15);
            label1.TabIndex = 3;
            label1.Text = "نام:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(290, 149);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(72, 15);
            label2.TabIndex = 5;
            label2.Text = "نام خانوادگی:";
            // 
            // txtLastnameStudent
            // 
            txtLastnameStudent.Location = new Point(91, 146);
            txtLastnameStudent.Name = "txtLastnameStudent";
            txtLastnameStudent.RightToLeft = RightToLeft.Yes;
            txtLastnameStudent.Size = new Size(193, 23);
            txtLastnameStudent.TabIndex = 4;
            txtLastnameStudent.Click += txtLastnameStudent_Click;
            txtLastnameStudent.TextChanged += txtLastnameStudent_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(290, 197);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(94, 15);
            label3.TabIndex = 7;
            label3.Text = "شماره دانشجویی:";
            // 
            // txtStudentNumber
            // 
            txtStudentNumber.Location = new Point(91, 194);
            txtStudentNumber.Name = "txtStudentNumber";
            txtStudentNumber.RightToLeft = RightToLeft.Yes;
            txtStudentNumber.Size = new Size(193, 23);
            txtStudentNumber.TabIndex = 6;
            txtStudentNumber.Click += txtStudentNumber_Click;
            txtStudentNumber.TextChanged += txtStudentNumber_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(135, 42);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(280, 20);
            label4.TabIndex = 8;
            label4.Text = "لطفا اطلاعات دانشجویی خود را وارد نمایید:";
            // 
            // lblErrorStudentName
            // 
            lblErrorStudentName.AutoSize = true;
            lblErrorStudentName.Location = new Point(91, 83);
            lblErrorStudentName.Name = "lblErrorStudentName";
            lblErrorStudentName.RightToLeft = RightToLeft.Yes;
            lblErrorStudentName.Size = new Size(0, 15);
            lblErrorStudentName.TabIndex = 9;
            // 
            // lblErrorStudentLastname
            // 
            lblErrorStudentLastname.AutoSize = true;
            lblErrorStudentLastname.Location = new Point(91, 128);
            lblErrorStudentLastname.Name = "lblErrorStudentLastname";
            lblErrorStudentLastname.RightToLeft = RightToLeft.Yes;
            lblErrorStudentLastname.Size = new Size(0, 15);
            lblErrorStudentLastname.TabIndex = 10;
            // 
            // lblErrorStudentNumber
            // 
            lblErrorStudentNumber.AutoSize = true;
            lblErrorStudentNumber.Location = new Point(91, 176);
            lblErrorStudentNumber.Name = "lblErrorStudentNumber";
            lblErrorStudentNumber.RightToLeft = RightToLeft.Yes;
            lblErrorStudentNumber.Size = new Size(0, 15);
            lblErrorStudentNumber.TabIndex = 11;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(427, 323);
            Controls.Add(lblErrorStudentNumber);
            Controls.Add(lblErrorStudentLastname);
            Controls.Add(lblErrorStudentName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtStudentNumber);
            Controls.Add(label2);
            Controls.Add(txtLastnameStudent);
            Controls.Add(label1);
            Controls.Add(txtNameStudent);
            Controls.Add(btnSaveStudent);
            Controls.Add(btnBackStudent);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load;
            KeyUp += Form6_KeyUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtstdiddanesh;
        private Label label4;
        private Button btnBackStudent;
        private Button btnSaveStudent;
        private TextBox txtNameStudent;
        private Label label1;
        private Label label2;
        private TextBox txtLastnameStudent;
        private Label label3;
        private TextBox txtStudentNumber;
        private Label lblErrorStudentName;
        private Label lblErrorStudentLastname;
        private Label lblErrorStudentNumber;
    }
}