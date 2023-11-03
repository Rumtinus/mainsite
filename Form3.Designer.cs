namespace mainsite
{
    partial class Form3
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
            cmbtarifdars = new ComboBox();
            btnbackdars = new Button();
            btndeldars = new Button();
            btneditdars = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(296, 65);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(108, 21);
            label1.TabIndex = 0;
            label1.Text = "فهرست دروس:";
            // 
            // cmbtarifdars
            // 
            cmbtarifdars.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbtarifdars.FormattingEnabled = true;
            cmbtarifdars.Location = new Point(71, 67);
            cmbtarifdars.Name = "cmbtarifdars";
            cmbtarifdars.RightToLeft = RightToLeft.Yes;
            cmbtarifdars.Size = new Size(204, 23);
            cmbtarifdars.TabIndex = 1;
            cmbtarifdars.SelectedIndexChanged += cmbtarifdars_SelectedIndexChanged;
            cmbtarifdars.Click += cmbtarifdars_Click;
            // 
            // btnbackdars
            // 
            btnbackdars.Location = new Point(71, 160);
            btnbackdars.Name = "btnbackdars";
            btnbackdars.Size = new Size(75, 29);
            btnbackdars.TabIndex = 2;
            btnbackdars.Text = "بازگشت";
            btnbackdars.UseVisualStyleBackColor = true;
            btnbackdars.Click += btnbackdars_Click;
            // 
            // btndeldars
            // 
            btndeldars.Location = new Point(200, 160);
            btndeldars.Name = "btndeldars";
            btndeldars.Size = new Size(75, 29);
            btndeldars.TabIndex = 3;
            btndeldars.Text = "حذف";
            btndeldars.UseVisualStyleBackColor = true;
            btndeldars.Click += btndeldars_Click;
            // 
            // btneditdars
            // 
            btneditdars.Location = new Point(329, 160);
            btneditdars.Name = "btneditdars";
            btneditdars.Size = new Size(75, 29);
            btneditdars.TabIndex = 4;
            btneditdars.Text = "ویرایش";
            btneditdars.UseVisualStyleBackColor = true;
            btneditdars.Click += btneditdars_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(469, 288);
            Controls.Add(btneditdars);
            Controls.Add(btndeldars);
            Controls.Add(btnbackdars);
            Controls.Add(cmbtarifdars);
            Controls.Add(label1);
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            KeyUp += Form3_KeyUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbtarifdars;
        private Button btnbackdars;
        private Button btndeldars;
        private Button btneditdars;
        private ListView listView1;
    }
}