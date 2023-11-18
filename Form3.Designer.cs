namespace mainsite
{
    partial class Form3
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
            cmbLessonPresenting = new ComboBox();
            btnBackLessonList = new Button();
            btnDeleteLessonList = new Button();
            btnEditLessonList = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(296, 65);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(108, 21);
            label1.TabIndex = 0;
            label1.Text = "فهرست دروس:";
            // 
            // cmbLessonPresenting
            // 
            cmbLessonPresenting.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLessonPresenting.FormattingEnabled = true;
            cmbLessonPresenting.Location = new Point(71, 67);
            cmbLessonPresenting.Name = "cmbLessonPresenting";
            cmbLessonPresenting.RightToLeft = RightToLeft.Yes;
            cmbLessonPresenting.Size = new Size(204, 23);
            cmbLessonPresenting.TabIndex = 1;
            // 
            // btnBackLessonList
            // 
            btnBackLessonList.Location = new Point(71, 160);
            btnBackLessonList.Name = "btnBackLessonList";
            btnBackLessonList.Size = new Size(75, 29);
            btnBackLessonList.TabIndex = 2;
            btnBackLessonList.Text = "بازگشت";
            btnBackLessonList.UseVisualStyleBackColor = true;
            btnBackLessonList.Click += btnBackLessonList_Click;
            // 
            // btnDeleteLessonList
            // 
            btnDeleteLessonList.Location = new Point(200, 160);
            btnDeleteLessonList.Name = "btnDeleteLessonList";
            btnDeleteLessonList.Size = new Size(75, 29);
            btnDeleteLessonList.TabIndex = 3;
            btnDeleteLessonList.Text = "حذف";
            btnDeleteLessonList.UseVisualStyleBackColor = true;
            btnDeleteLessonList.Click += btnDeleteLessonList_Click;
            // 
            // btnEditLessonList
            // 
            btnEditLessonList.Location = new Point(329, 160);
            btnEditLessonList.Name = "btnEditLessonList";
            btnEditLessonList.Size = new Size(75, 29);
            btnEditLessonList.TabIndex = 4;
            btnEditLessonList.Text = "ویرایش";
            btnEditLessonList.UseVisualStyleBackColor = true;
            btnEditLessonList.Click += btnEditLessonList_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(469, 288);
            Controls.Add(btnEditLessonList);
            Controls.Add(btnDeleteLessonList);
            Controls.Add(btnBackLessonList);
            Controls.Add(cmbLessonPresenting);
            Controls.Add(label1);
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            KeyUp += Form3_KeyUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbLessonPresenting;
        private Button btnBackLessonList;
        private Button btnDeleteLessonList;
        private Button btnEditLessonList;
        private ListView listView1;
    }
}