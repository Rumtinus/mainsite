namespace mainsite
{
    partial class Form8
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnSaveCourseRegistration = new Button();
            btnBackCourseRegistration = new Button();
            cmbStudentChoosing = new ComboBox();
            cmbTermChoosing = new ComboBox();
            cmbLessonChoosing = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(268, 62);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(106, 21);
            label1.TabIndex = 0;
            label1.Text = "انتخاب دانشجو:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(292, 102);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(79, 21);
            label2.TabIndex = 2;
            label2.Text = "انتخاب ترم:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(279, 148);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(92, 21);
            label3.TabIndex = 4;
            label3.Text = "انتخاب درس:";
            // 
            // btnSaveCourseRegistration
            // 
            btnSaveCourseRegistration.Location = new Point(296, 225);
            btnSaveCourseRegistration.Name = "btnSaveCourseRegistration";
            btnSaveCourseRegistration.Size = new Size(75, 35);
            btnSaveCourseRegistration.TabIndex = 6;
            btnSaveCourseRegistration.Text = "ثبت";
            btnSaveCourseRegistration.UseVisualStyleBackColor = true;
            btnSaveCourseRegistration.Click += btnsavesabtnam_Click;
            // 
            // btnBackCourseRegistration
            // 
            btnBackCourseRegistration.Location = new Point(61, 225);
            btnBackCourseRegistration.Name = "btnBackCourseRegistration";
            btnBackCourseRegistration.Size = new Size(75, 35);
            btnBackCourseRegistration.TabIndex = 7;
            btnBackCourseRegistration.Text = "بازگشت";
            btnBackCourseRegistration.UseVisualStyleBackColor = true;
            btnBackCourseRegistration.Click += btnbacksabtnam_Click;
            // 
            // cmbStudentChoosing
            // 
            cmbStudentChoosing.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudentChoosing.FormattingEnabled = true;
            cmbStudentChoosing.Location = new Point(61, 64);
            cmbStudentChoosing.Name = "cmbStudentChoosing";
            cmbStudentChoosing.RightToLeft = RightToLeft.Yes;
            cmbStudentChoosing.Size = new Size(201, 23);
            cmbStudentChoosing.TabIndex = 8;
            cmbStudentChoosing.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cmbTermChoosing
            // 
            cmbTermChoosing.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTermChoosing.FormattingEnabled = true;
            cmbTermChoosing.Location = new Point(61, 104);
            cmbTermChoosing.Name = "cmbTermChoosing";
            cmbTermChoosing.RightToLeft = RightToLeft.Yes;
            cmbTermChoosing.Size = new Size(201, 23);
            cmbTermChoosing.TabIndex = 9;
            cmbTermChoosing.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // cmbLessonChoosing
            // 
            cmbLessonChoosing.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLessonChoosing.FormattingEnabled = true;
            cmbLessonChoosing.Location = new Point(61, 150);
            cmbLessonChoosing.Name = "cmbLessonChoosing";
            cmbLessonChoosing.RightToLeft = RightToLeft.Yes;
            cmbLessonChoosing.Size = new Size(201, 23);
            cmbLessonChoosing.TabIndex = 10;
            cmbLessonChoosing.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(432, 323);
            Controls.Add(cmbLessonChoosing);
            Controls.Add(cmbTermChoosing);
            Controls.Add(cmbStudentChoosing);
            Controls.Add(btnBackCourseRegistration);
            Controls.Add(btnSaveCourseRegistration);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Form8";
            Text = "Form8";
            Load += Form8_Load;
            KeyUp += Form8_KeyUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSaveCourseRegistration;
        private Button btnBackCourseRegistration;
        private ComboBox cmbStudentChoosing;
        private ComboBox cmbTermChoosing;
        private ComboBox cmbLessonChoosing;
    }
}