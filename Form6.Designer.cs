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
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtnamedanesh = new TextBox();
            btnbackdanesh = new Button();
            btnsavedanesh = new Button();
            txtlastnamedenesh = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(286, 113);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(31, 21);
            label1.TabIndex = 0;
            label1.Text = "نام:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(286, 166);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(94, 21);
            label2.TabIndex = 1;
            label2.Text = "نام خانوادگی:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(72, 92);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(0, 15);
            label5.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(72, 145);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(0, 15);
            label6.TabIndex = 4;
            // 
            // txtnamedanesh
            // 
            txtnamedanesh.Location = new Point(72, 110);
            txtnamedanesh.Name = "txtnamedanesh";
            txtnamedanesh.RightToLeft = RightToLeft.Yes;
            txtnamedanesh.Size = new Size(208, 23);
            txtnamedanesh.TabIndex = 5;
            txtnamedanesh.Click += txtnamedanesh_Click;
            txtnamedanesh.TextChanged += txtnamedanesh_TextChanged;
            // 
            // btnbackdanesh
            // 
            btnbackdanesh.Location = new Point(72, 231);
            btnbackdanesh.Name = "btnbackdanesh";
            btnbackdanesh.Size = new Size(69, 34);
            btnbackdanesh.TabIndex = 6;
            btnbackdanesh.Text = "بازگشت";
            btnbackdanesh.UseVisualStyleBackColor = true;
            btnbackdanesh.Click += btnbackdanesh_Click;
            // 
            // btnsavedanesh
            // 
            btnsavedanesh.Location = new Point(242, 231);
            btnsavedanesh.Name = "btnsavedanesh";
            btnsavedanesh.Size = new Size(69, 34);
            btnsavedanesh.TabIndex = 7;
            btnsavedanesh.Text = "ذخیره";
            btnsavedanesh.UseVisualStyleBackColor = true;
            btnsavedanesh.Click += btnsavedanesh_Click;
            // 
            // txtlastnamedenesh
            // 
            txtlastnamedenesh.Location = new Point(72, 163);
            txtlastnamedenesh.Name = "txtlastnamedenesh";
            txtlastnamedenesh.RightToLeft = RightToLeft.Yes;
            txtlastnamedenesh.Size = new Size(208, 23);
            txtlastnamedenesh.TabIndex = 8;
            txtlastnamedenesh.Click += txtlastnamedenesh_Click;
            txtlastnamedenesh.TextChanged += txtlastnamedenesh_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(121, 52);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(275, 21);
            label3.TabIndex = 9;
            label3.Text = "لطفا نام دانشجوی جدید خود را وارد نمایید:";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(408, 305);
            Controls.Add(label3);
            Controls.Add(txtlastnamedenesh);
            Controls.Add(btnsavedanesh);
            Controls.Add(btnbackdanesh);
            Controls.Add(txtnamedanesh);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label6;
        private TextBox txtnamedanesh;
        private Button btnbackdanesh;
        private Button btnsavedanesh;
        private TextBox txtlastnamedenesh;
        private Label label3;
    }
}