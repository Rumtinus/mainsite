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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            btnbackakharin = new Button();
            btndel = new Button();
            btnedit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 107);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RightToLeft = RightToLeft.Yes;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(447, 193);
            dataGridView1.TabIndex = 0;
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
            // btnbackakharin
            // 
            btnbackakharin.Location = new Point(46, 46);
            btnbackakharin.Name = "btnbackakharin";
            btnbackakharin.Size = new Size(65, 28);
            btnbackakharin.TabIndex = 2;
            btnbackakharin.Text = "بازگشت";
            btnbackakharin.UseVisualStyleBackColor = true;
            btnbackakharin.Click += btnbackakharin_Click;
            // 
            // btndel
            // 
            btndel.Location = new Point(128, 46);
            btndel.Name = "btndel";
            btndel.Size = new Size(65, 28);
            btndel.TabIndex = 3;
            btndel.Text = "حذف";
            btndel.UseVisualStyleBackColor = true;
            btndel.Click += btndel_Click;
            // 
            // btnedit
            // 
            btnedit.Location = new Point(208, 44);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(65, 28);
            btnedit.TabIndex = 4;
            btnedit.Text = "ویرایش";
            btnedit.UseVisualStyleBackColor = true;
            btnedit.Click += btnedit_Click;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(498, 322);
            Controls.Add(btnedit);
            Controls.Add(btndel);
            Controls.Add(btnbackakharin);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Form9";
            Text = "Form9";
            Load += Form9_Load;
            KeyUp += Form9_KeyUp;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button btnbackakharin;
        private Button btndel;
        private Button btnedit;
    }
}