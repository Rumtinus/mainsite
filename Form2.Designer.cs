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
            btnbacktarifdars = new Button();
            btnsavedars = new Button();
            txttarifdars = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnbacktarifdars
            // 
            btnbacktarifdars.Location = new Point(74, 178);
            btnbacktarifdars.Name = "btnbacktarifdars";
            btnbacktarifdars.RightToLeft = RightToLeft.No;
            btnbacktarifdars.Size = new Size(75, 33);
            btnbacktarifdars.TabIndex = 0;
            btnbacktarifdars.Text = "بازگشت";
            btnbacktarifdars.UseVisualStyleBackColor = true;
            btnbacktarifdars.Click += btnbacktarifdars_Click;
            // 
            // btnsavedars
            // 
            btnsavedars.Location = new Point(232, 178);
            btnsavedars.Name = "btnsavedars";
            btnsavedars.RightToLeft = RightToLeft.No;
            btnsavedars.Size = new Size(75, 33);
            btnsavedars.TabIndex = 1;
            btnsavedars.Text = "ذخیره";
            btnsavedars.UseVisualStyleBackColor = true;
            btnsavedars.Click += btnsavedars_Click;
            btnsavedars.KeyDown += btnsavedars_KeyDown;
            // 
            // txttarifdars
            // 
            txttarifdars.Location = new Point(74, 103);
            txttarifdars.Name = "txttarifdars";
            txttarifdars.RightToLeft = RightToLeft.Yes;
            txttarifdars.Size = new Size(233, 23);
            txttarifdars.TabIndex = 2;
            txttarifdars.Click += txttarifdars_Click;
            txttarifdars.TextChanged += textBox1_TextChanged;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 85);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(0, 15);
            label2.TabIndex = 4;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(579, 315);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txttarifdars);
            Controls.Add(btnsavedars);
            Controls.Add(btnbacktarifdars);
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

        private Button btnbacktarifdars;
        private Button btnsavedars;
        private TextBox txttarifdars;
        private Label label1;
        private Label label2;
    }
}