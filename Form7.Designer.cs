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
            btnbackfehrestdanesh = new Button();
            btndelfehrestdanesh = new Button();
            btneditfehrestdanesh = new Button();
            label1 = new Label();
            cmbfehrastdanesh = new ComboBox();
            SuspendLayout();
            // 
            // btnbackfehrestdanesh
            // 
            btnbackfehrestdanesh.Location = new Point(76, 152);
            btnbackfehrestdanesh.Name = "btnbackfehrestdanesh";
            btnbackfehrestdanesh.Size = new Size(79, 31);
            btnbackfehrestdanesh.TabIndex = 0;
            btnbackfehrestdanesh.Text = "بازگشت";
            btnbackfehrestdanesh.UseVisualStyleBackColor = true;
            btnbackfehrestdanesh.Click += btnbackfehrestdanesh_Click;
            // 
            // btndelfehrestdanesh
            // 
            btndelfehrestdanesh.Location = new Point(242, 152);
            btndelfehrestdanesh.Name = "btndelfehrestdanesh";
            btndelfehrestdanesh.Size = new Size(79, 31);
            btndelfehrestdanesh.TabIndex = 1;
            btndelfehrestdanesh.Text = "حذف";
            btndelfehrestdanesh.UseVisualStyleBackColor = true;
            btndelfehrestdanesh.Click += btndelfehrestdanesh_Click;
            // 
            // btneditfehrestdanesh
            // 
            btneditfehrestdanesh.Location = new Point(392, 152);
            btneditfehrestdanesh.Name = "btneditfehrestdanesh";
            btneditfehrestdanesh.Size = new Size(79, 31);
            btneditfehrestdanesh.TabIndex = 2;
            btneditfehrestdanesh.Text = "ویرایش";
            btneditfehrestdanesh.UseVisualStyleBackColor = true;
            btneditfehrestdanesh.Click += btneditfehrestdanesh_Click;
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
            // cmbfehrastdanesh
            // 
            cmbfehrastdanesh.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbfehrastdanesh.FormattingEnabled = true;
            cmbfehrastdanesh.Location = new Point(76, 63);
            cmbfehrastdanesh.Name = "cmbfehrastdanesh";
            cmbfehrastdanesh.RightToLeft = RightToLeft.Yes;
            cmbfehrastdanesh.Size = new Size(245, 23);
            cmbfehrastdanesh.TabIndex = 4;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(560, 259);
            Controls.Add(cmbfehrastdanesh);
            Controls.Add(label1);
            Controls.Add(btneditfehrestdanesh);
            Controls.Add(btndelfehrestdanesh);
            Controls.Add(btnbackfehrestdanesh);
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

        private Button btnbackfehrestdanesh;
        private Button btndelfehrestdanesh;
        private Button btneditfehrestdanesh;
        private Label label1;
        private ComboBox cmbfehrastdanesh;
    }
}