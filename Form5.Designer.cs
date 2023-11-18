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
            btnBackTermList = new Button();
            btnDeleteTermList = new Button();
            btnEditTermList = new Button();
            label1 = new Label();
            cmbTermList = new ComboBox();
            SuspendLayout();
            // 
            // btnBackTermList
            // 
            btnBackTermList.Location = new Point(61, 194);
            btnBackTermList.Name = "btnBackTermList";
            btnBackTermList.Size = new Size(75, 33);
            btnBackTermList.TabIndex = 0;
            btnBackTermList.Text = "بازگشت";
            btnBackTermList.UseVisualStyleBackColor = true;
            btnBackTermList.Click += btnBackTermList_Click;
            // 
            // btnDeleteTermList
            // 
            btnDeleteTermList.Location = new Point(238, 194);
            btnDeleteTermList.Name = "btnDeleteTermList";
            btnDeleteTermList.Size = new Size(75, 33);
            btnDeleteTermList.TabIndex = 1;
            btnDeleteTermList.Text = "حذف";
            btnDeleteTermList.UseVisualStyleBackColor = true;
            btnDeleteTermList.Click += btnDeleteTermList_Click;
            // 
            // btnEditTermList
            // 
            btnEditTermList.Location = new Point(411, 194);
            btnEditTermList.Name = "btnEditTermList";
            btnEditTermList.Size = new Size(75, 33);
            btnEditTermList.TabIndex = 2;
            btnEditTermList.Text = "ویرایش";
            btnEditTermList.UseVisualStyleBackColor = true;
            btnEditTermList.Click += btnEditTermList_Click;
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
            // cmbTermList
            // 
            cmbTermList.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTermList.FormattingEnabled = true;
            cmbTermList.Location = new Point(61, 90);
            cmbTermList.Name = "cmbTermList";
            cmbTermList.RightToLeft = RightToLeft.Yes;
            cmbTermList.Size = new Size(178, 23);
            cmbTermList.TabIndex = 4;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(533, 313);
            Controls.Add(cmbTermList);
            Controls.Add(label1);
            Controls.Add(btnEditTermList);
            Controls.Add(btnDeleteTermList);
            Controls.Add(btnBackTermList);
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

        private Button btnBackTermList;
        private Button btnDeleteTermList;
        private Button btnEditTermList;
        private Label label1;
        private ComboBox cmbTermList;
    }
}