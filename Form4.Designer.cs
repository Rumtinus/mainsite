namespace mainsite
{
    partial class Form4
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
            btnBackTermPresenting = new Button();
            btnSaveTerm = new Button();
            label1 = new Label();
            txtTermPresenting = new TextBox();
            lblErrorTermPresenting = new Label();
            SuspendLayout();
            // 
            // btnBackTermPresenting
            // 
            btnBackTermPresenting.Location = new Point(56, 164);
            btnBackTermPresenting.Name = "btnBackTermPresenting";
            btnBackTermPresenting.Size = new Size(75, 30);
            btnBackTermPresenting.TabIndex = 0;
            btnBackTermPresenting.Text = "بازگشت";
            btnBackTermPresenting.UseVisualStyleBackColor = true;
            btnBackTermPresenting.Click += btnBackTermPresenting_Click;
            // 
            // btnSaveTerm
            // 
            btnSaveTerm.Location = new Point(198, 164);
            btnSaveTerm.Name = "btnSaveTerm";
            btnSaveTerm.Size = new Size(75, 30);
            btnSaveTerm.TabIndex = 1;
            btnSaveTerm.Text = "ذخیره";
            btnSaveTerm.UseVisualStyleBackColor = true;
            btnSaveTerm.Click += btnSaveTerm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(279, 75);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(252, 21);
            label1.TabIndex = 2;
            label1.Text = "لطفا کد ترم تعریفی خود را وارد نمایید:";
            // 
            // txtTermPresenting
            // 
            txtTermPresenting.Location = new Point(56, 77);
            txtTermPresenting.Name = "txtTermPresenting";
            txtTermPresenting.RightToLeft = RightToLeft.Yes;
            txtTermPresenting.Size = new Size(217, 23);
            txtTermPresenting.TabIndex = 3;
            txtTermPresenting.Click += txtTermPresenting_Click;
            txtTermPresenting.TextChanged += txtTermPresenting_TextChanged;
            // 
            // lblErrorTermPresenting
            // 
            lblErrorTermPresenting.AutoSize = true;
            lblErrorTermPresenting.Location = new Point(56, 59);
            lblErrorTermPresenting.Name = "lblErrorTermPresenting";
            lblErrorTermPresenting.RightToLeft = RightToLeft.Yes;
            lblErrorTermPresenting.Size = new Size(0, 15);
            lblErrorTermPresenting.TabIndex = 4;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(553, 267);
            Controls.Add(lblErrorTermPresenting);
            Controls.Add(txtTermPresenting);
            Controls.Add(label1);
            Controls.Add(btnSaveTerm);
            Controls.Add(btnBackTermPresenting);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            KeyUp += Form4_KeyUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBackTermPresenting;
        private Button btnSaveTerm;
        private Label label1;
        private TextBox txtTermPresenting;
        private Label lblErrorTermPresenting;
    }
}