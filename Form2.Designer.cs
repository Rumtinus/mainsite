namespace mainsite
{
    partial class Form2
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
            btnBackLessonPresenting = new Button();
            btnSaveLesson = new Button();
            txtLessonPresenting = new TextBox();
            label1 = new Label();
            lblLessonPresenting = new Label();
            SuspendLayout();
            // 
            // btnBackLessonPresenting
            // 
            btnBackLessonPresenting.Location = new Point(74, 178);
            btnBackLessonPresenting.Name = "btnBackLessonPresenting";
            btnBackLessonPresenting.RightToLeft = RightToLeft.No;
            btnBackLessonPresenting.Size = new Size(75, 33);
            btnBackLessonPresenting.TabIndex = 0;
            btnBackLessonPresenting.Text = "بازگشت";
            btnBackLessonPresenting.UseVisualStyleBackColor = true;
            btnBackLessonPresenting.Click += btnBackLessonPresenting_Click;
            // 
            // btnSaveLesson
            // 
            btnSaveLesson.Location = new Point(232, 178);
            btnSaveLesson.Name = "btnSaveLesson";
            btnSaveLesson.RightToLeft = RightToLeft.No;
            btnSaveLesson.Size = new Size(75, 33);
            btnSaveLesson.TabIndex = 1;
            btnSaveLesson.Text = "ذخیره";
            btnSaveLesson.UseVisualStyleBackColor = true;
            btnSaveLesson.Click += btnsavedars_Click;
            // 
            // txtLessonPresenting
            // 
            txtLessonPresenting.Location = new Point(74, 103);
            txtLessonPresenting.Name = "txtLessonPresenting";
            txtLessonPresenting.RightToLeft = RightToLeft.Yes;
            txtLessonPresenting.Size = new Size(233, 23);
            txtLessonPresenting.TabIndex = 2;
            txtLessonPresenting.Click += txtLessonPresenting_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(314, 103);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(238, 21);
            label1.TabIndex = 3;
            label1.Text = "لطفا نام درس تعریفی را وارد نمایید:";
            // 
            // lblLessonPresenting
            // 
            lblLessonPresenting.AutoSize = true;
            lblLessonPresenting.Location = new Point(74, 85);
            lblLessonPresenting.Name = "lblLessonPresenting";
            lblLessonPresenting.RightToLeft = RightToLeft.Yes;
            lblLessonPresenting.Size = new Size(0, 15);
            lblLessonPresenting.TabIndex = 4;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(579, 315);
            Controls.Add(lblLessonPresenting);
            Controls.Add(label1);
            Controls.Add(txtLessonPresenting);
            Controls.Add(btnSaveLesson);
            Controls.Add(btnBackLessonPresenting);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            KeyUp += Form2_KeyUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBackLessonPresenting;
        private Button btnSaveLesson;
        private TextBox txtLessonPresenting;
        private Label label1;
        private Label lblLessonPresenting;
    }
}