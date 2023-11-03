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
            btnbacktarifterm = new Button();
            btnsavetarifterm = new Button();
            label1 = new Label();
            txttarifterm = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnbacktarifterm
            // 
            btnbacktarifterm.Location = new Point(56, 164);
            btnbacktarifterm.Name = "btnbacktarifterm";
            btnbacktarifterm.Size = new Size(75, 30);
            btnbacktarifterm.TabIndex = 0;
            btnbacktarifterm.Text = "بازگشت";
            btnbacktarifterm.UseVisualStyleBackColor = true;
            btnbacktarifterm.Click += btnbacktarifterm_Click;
            // 
            // btnsavetarifterm
            // 
            btnsavetarifterm.Location = new Point(198, 164);
            btnsavetarifterm.Name = "btnsavetarifterm";
            btnsavetarifterm.Size = new Size(75, 30);
            btnsavetarifterm.TabIndex = 1;
            btnsavetarifterm.Text = "ذخیره";
            btnsavetarifterm.UseVisualStyleBackColor = true;
            btnsavetarifterm.Click += btnsavetarifterm_Click;
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
            // txttarifterm
            // 
            txttarifterm.Location = new Point(56, 77);
            txttarifterm.Name = "txttarifterm";
            txttarifterm.RightToLeft = RightToLeft.Yes;
            txttarifterm.Size = new Size(217, 23);
            txttarifterm.TabIndex = 3;
            txttarifterm.Click += txttarifterm_Click;
            txttarifterm.TextChanged += txttarifterm_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 59);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(0, 15);
            label2.TabIndex = 4;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(553, 267);
            Controls.Add(label2);
            Controls.Add(txttarifterm);
            Controls.Add(label1);
            Controls.Add(btnsavetarifterm);
            Controls.Add(btnbacktarifterm);
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

        private Button btnbacktarifterm;
        private Button btnsavetarifterm;
        private Label label1;
        private TextBox txttarifterm;
        private Label label2;
    }
}