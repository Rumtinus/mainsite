namespace mainsite
{
    partial class Form9
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
            dataGridViewRegistration = new DataGridView();
            label1 = new Label();
            btnBackRegistrationList = new Button();
            btnDeleteRegistrationList = new Button();
            btnEditRegistrationList = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRegistration).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewRegistration
            // 
            dataGridViewRegistration.AllowUserToAddRows = false;
            dataGridViewRegistration.AllowUserToDeleteRows = false;
            dataGridViewRegistration.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRegistration.Location = new Point(35, 107);
            dataGridViewRegistration.Name = "dataGridViewRegistration";
            dataGridViewRegistration.ReadOnly = true;
            dataGridViewRegistration.RightToLeft = RightToLeft.Yes;
            dataGridViewRegistration.RowTemplate.Height = 25;
            dataGridViewRegistration.Size = new Size(447, 193);
            dataGridViewRegistration.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(292, 46);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(190, 21);
            label1.TabIndex = 1;
            label1.Text = "آخرین وضعیت ثبت نامی ها:";
            // 
            // btnBackRegistrationList
            // 
            btnBackRegistrationList.Location = new Point(46, 46);
            btnBackRegistrationList.Name = "btnBackRegistrationList";
            btnBackRegistrationList.Size = new Size(65, 28);
            btnBackRegistrationList.TabIndex = 2;
            btnBackRegistrationList.Text = "بازگشت";
            btnBackRegistrationList.UseVisualStyleBackColor = true;
            btnBackRegistrationList.Click += btnbackakharin_Click;
            // 
            // btnDeleteRegistrationList
            // 
            btnDeleteRegistrationList.Location = new Point(128, 46);
            btnDeleteRegistrationList.Name = "btnDeleteRegistrationList";
            btnDeleteRegistrationList.Size = new Size(65, 28);
            btnDeleteRegistrationList.TabIndex = 3;
            btnDeleteRegistrationList.Text = "حذف";
            btnDeleteRegistrationList.UseVisualStyleBackColor = true;
            btnDeleteRegistrationList.Click += btndel_Click;
            // 
            // btnEditRegistrationList
            // 
            btnEditRegistrationList.Location = new Point(208, 46);
            btnEditRegistrationList.Name = "btnEditRegistrationList";
            btnEditRegistrationList.Size = new Size(65, 28);
            btnEditRegistrationList.TabIndex = 4;
            btnEditRegistrationList.Text = "ویرایش";
            btnEditRegistrationList.UseVisualStyleBackColor = true;
            btnEditRegistrationList.Click += btnedit_Click;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(498, 322);
            Controls.Add(btnEditRegistrationList);
            Controls.Add(btnDeleteRegistrationList);
            Controls.Add(btnBackRegistrationList);
            Controls.Add(label1);
            Controls.Add(dataGridViewRegistration);
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Form9";
            Text = "Form9";
            Load += Form9_Load;
            KeyUp += Form9_KeyUp;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRegistration).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewRegistration;
        private Label label1;
        private Button btnBackRegistrationList;
        private Button btnDeleteRegistrationList;
        private Button btnEditRegistrationList;
    }
}