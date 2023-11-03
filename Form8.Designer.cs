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
            btnsavesabtnam = new Button();
            btnbacksabtnam = new Button();
            cmbdanesh = new ComboBox();
            cmbterm = new ComboBox();
            cmbdars = new ComboBox();
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
            // btnsavesabtnam
            // 
            btnsavesabtnam.Location = new Point(296, 225);
            btnsavesabtnam.Name = "btnsavesabtnam";
            btnsavesabtnam.Size = new Size(75, 35);
            btnsavesabtnam.TabIndex = 6;
            btnsavesabtnam.Text = "ثبت";
            btnsavesabtnam.UseVisualStyleBackColor = true;
            btnsavesabtnam.Click += btnsavesabtnam_Click;
            // 
            // btnbacksabtnam
            // 
            btnbacksabtnam.Location = new Point(61, 225);
            btnbacksabtnam.Name = "btnbacksabtnam";
            btnbacksabtnam.Size = new Size(75, 35);
            btnbacksabtnam.TabIndex = 7;
            btnbacksabtnam.Text = "بازگشت";
            btnbacksabtnam.UseVisualStyleBackColor = true;
            btnbacksabtnam.Click += btnbacksabtnam_Click;
            // 
            // cmbdanesh
            // 
            cmbdanesh.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbdanesh.FormattingEnabled = true;
            cmbdanesh.Location = new Point(61, 64);
            cmbdanesh.Name = "cmbdanesh";
            cmbdanesh.RightToLeft = RightToLeft.Yes;
            cmbdanesh.Size = new Size(201, 23);
            cmbdanesh.TabIndex = 8;
            cmbdanesh.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cmbterm
            // 
            cmbterm.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbterm.FormattingEnabled = true;
            cmbterm.Location = new Point(61, 104);
            cmbterm.Name = "cmbterm";
            cmbterm.RightToLeft = RightToLeft.Yes;
            cmbterm.Size = new Size(201, 23);
            cmbterm.TabIndex = 9;
            cmbterm.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // cmbdars
            // 
            cmbdars.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbdars.FormattingEnabled = true;
            cmbdars.Location = new Point(61, 150);
            cmbdars.Name = "cmbdars";
            cmbdars.RightToLeft = RightToLeft.Yes;
            cmbdars.Size = new Size(201, 23);
            cmbdars.TabIndex = 10;
            cmbdars.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(432, 323);
            Controls.Add(cmbdars);
            Controls.Add(cmbterm);
            Controls.Add(cmbdanesh);
            Controls.Add(btnbacksabtnam);
            Controls.Add(btnsavesabtnam);
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
        private Button btnsavesabtnam;
        private Button btnbacksabtnam;
        private ComboBox cmbdanesh;
        private ComboBox cmbterm;
        private ComboBox cmbdars;
    }
}