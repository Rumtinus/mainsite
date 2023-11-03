namespace mainsite
{
    partial class Form5
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
            btnbackfehrestterm = new Button();
            btndelfehrestterm = new Button();
            btneditfehrestterm = new Button();
            label1 = new Label();
            cmbfehrestterm = new ComboBox();
            SuspendLayout();
            // 
            // btnbackfehrestterm
            // 
            btnbackfehrestterm.Location = new Point(61, 194);
            btnbackfehrestterm.Name = "btnbackfehrestterm";
            btnbackfehrestterm.Size = new Size(75, 33);
            btnbackfehrestterm.TabIndex = 0;
            btnbackfehrestterm.Text = "بازگشت";
            btnbackfehrestterm.UseVisualStyleBackColor = true;
            btnbackfehrestterm.Click += btnbackfehrestterm_Click;
            // 
            // btndelfehrestterm
            // 
            btndelfehrestterm.Location = new Point(238, 194);
            btndelfehrestterm.Name = "btndelfehrestterm";
            btndelfehrestterm.Size = new Size(75, 33);
            btndelfehrestterm.TabIndex = 1;
            btndelfehrestterm.Text = "حذف";
            btndelfehrestterm.UseVisualStyleBackColor = true;
            btndelfehrestterm.Click += btndelfehrestterm_Click;
            // 
            // btneditfehrestterm
            // 
            btneditfehrestterm.Location = new Point(411, 194);
            btneditfehrestterm.Name = "btneditfehrestterm";
            btneditfehrestterm.Size = new Size(75, 33);
            btneditfehrestterm.TabIndex = 2;
            btneditfehrestterm.Text = "ویرایش";
            btneditfehrestterm.UseVisualStyleBackColor = true;
            btneditfehrestterm.Click += btneditfehrestterm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(288, 88);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(198, 21);
            label1.TabIndex = 3;
            label1.Text = "فهرست ترم های تعریف شده:";
            // 
            // cmbfehrestterm
            // 
            cmbfehrestterm.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbfehrestterm.FormattingEnabled = true;
            cmbfehrestterm.Location = new Point(61, 90);
            cmbfehrestterm.Name = "cmbfehrestterm";
            cmbfehrestterm.RightToLeft = RightToLeft.Yes;
            cmbfehrestterm.Size = new Size(178, 23);
            cmbfehrestterm.TabIndex = 4;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(533, 313);
            Controls.Add(cmbfehrestterm);
            Controls.Add(label1);
            Controls.Add(btneditfehrestterm);
            Controls.Add(btndelfehrestterm);
            Controls.Add(btnbackfehrestterm);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            KeyUp += Form5_KeyUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnbackfehrestterm;
        private Button btndelfehrestterm;
        private Button btneditfehrestterm;
        private Label label1;
        private ComboBox cmbfehrestterm;
    }
}