namespace mainsite
{
    partial class Form7
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
            btnBackStudentList = new Button();
            btnDeleteStudent = new Button();
            btnEditStudent = new Button();
            label1 = new Label();
            cmbStudentList = new ComboBox();
            SuspendLayout();
            // 
            // btnBackStudentList
            // 
            btnBackStudentList.Location = new Point(76, 152);
            btnBackStudentList.Name = "btnBackStudentList";
            btnBackStudentList.Size = new Size(79, 31);
            btnBackStudentList.TabIndex = 0;
            btnBackStudentList.Text = "بازگشت";
            btnBackStudentList.UseVisualStyleBackColor = true;
            btnBackStudentList.Click += btnBackStudentList_Click;
            // 
            // btnDeleteStudent
            // 
            btnDeleteStudent.Location = new Point(242, 152);
            btnDeleteStudent.Name = "btnDeleteStudent";
            btnDeleteStudent.Size = new Size(79, 31);
            btnDeleteStudent.TabIndex = 1;
            btnDeleteStudent.Text = "حذف";
            btnDeleteStudent.UseVisualStyleBackColor = true;
            btnDeleteStudent.Click += btnDeleteStudent_Click;
            // 
            // btnEditStudent
            // 
            btnEditStudent.Location = new Point(392, 152);
            btnEditStudent.Name = "btnEditStudent";
            btnEditStudent.Size = new Size(79, 31);
            btnEditStudent.TabIndex = 2;
            btnEditStudent.Text = "ویرایش";
            btnEditStudent.UseVisualStyleBackColor = true;
            btnEditStudent.Click += btnEditStudent_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(341, 61);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(130, 21);
            label1.TabIndex = 3;
            label1.Text = "فهرست داشجویان:";
            // 
            // cmbStudentList
            // 
            cmbStudentList.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudentList.FormattingEnabled = true;
            cmbStudentList.Location = new Point(76, 63);
            cmbStudentList.Name = "cmbStudentList";
            cmbStudentList.RightToLeft = RightToLeft.Yes;
            cmbStudentList.Size = new Size(245, 23);
            cmbStudentList.TabIndex = 4;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(560, 259);
            Controls.Add(cmbStudentList);
            Controls.Add(label1);
            Controls.Add(btnEditStudent);
            Controls.Add(btnDeleteStudent);
            Controls.Add(btnBackStudentList);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Form7";
            Text = "Form7";
            Load += Form7_Load;
            KeyUp += Form7_KeyUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBackStudentList;
        private Button btnDeleteStudent;
        private Button btnEditStudent;
        private Label label1;
        private ComboBox cmbStudentList;
    }
}