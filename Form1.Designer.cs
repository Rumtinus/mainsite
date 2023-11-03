namespace mainsite
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            tools = new ToolStripMenuItem();
            toolsabtname = new ToolStripMenuItem();
            toolakharin = new ToolStripMenuItem();
            دروسToolStripMenuItem = new ToolStripMenuItem();
            tooltarifdars = new ToolStripMenuItem();
            toolfehrestdars = new ToolStripMenuItem();
            toolt = new ToolStripMenuItem();
            tooltarifterm = new ToolStripMenuItem();
            toolfehrestterm = new ToolStripMenuItem();
            دانشجویانToolStripMenuItem = new ToolStripMenuItem();
            tooltarifdanesh = new ToolStripMenuItem();
            toolfehrestdanesh = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.SteelBlue;
            menuStrip1.Dock = DockStyle.Right;
            menuStrip1.Items.AddRange(new ToolStripItem[] { tools, دروسToolStripMenuItem, toolt, دانشجویانToolStripMenuItem });
            menuStrip1.Location = new Point(693, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(115, 462);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tools
            // 
            tools.DropDownItems.AddRange(new ToolStripItem[] { toolsabtname, toolakharin });
            tools.Name = "tools";
            tools.Size = new Size(102, 19);
            tools.Text = "ثبت نام دانشجویی";
            tools.TextAlign = ContentAlignment.BottomRight;
            // 
            // toolsabtname
            // 
            toolsabtname.BackColor = Color.SkyBlue;
            toolsabtname.Name = "toolsabtname";
            toolsabtname.Size = new Size(165, 22);
            toolsabtname.Text = "ثبت نام";
            toolsabtname.Click += toolsabtname_Click;
            // 
            // toolakharin
            // 
            toolakharin.BackColor = Color.SkyBlue;
            toolakharin.Name = "toolakharin";
            toolakharin.Size = new Size(165, 22);
            toolakharin.Text = "آخرین ثبت نامی ها";
            toolakharin.Click += toolakharin_Click;
            // 
            // دروسToolStripMenuItem
            // 
            دروسToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tooltarifdars, toolfehrestdars });
            دروسToolStripMenuItem.Name = "دروسToolStripMenuItem";
            دروسToolStripMenuItem.Size = new Size(102, 19);
            دروسToolStripMenuItem.Text = "دروس";
            دروسToolStripMenuItem.TextAlign = ContentAlignment.BottomRight;
            // 
            // tooltarifdars
            // 
            tooltarifdars.BackColor = Color.SkyBlue;
            tooltarifdars.Name = "tooltarifdars";
            tooltarifdars.RightToLeft = RightToLeft.Yes;
            tooltarifdars.Size = new Size(144, 22);
            tooltarifdars.Text = "تعریف درس";
            tooltarifdars.TextAlign = ContentAlignment.MiddleRight;
            tooltarifdars.Click += tooltarifdars_Click;
            // 
            // toolfehrestdars
            // 
            toolfehrestdars.BackColor = Color.SkyBlue;
            toolfehrestdars.Name = "toolfehrestdars";
            toolfehrestdars.RightToLeft = RightToLeft.Yes;
            toolfehrestdars.Size = new Size(144, 22);
            toolfehrestdars.Text = "فهرست دروس";
            toolfehrestdars.TextAlign = ContentAlignment.MiddleRight;
            toolfehrestdars.Click += toolfehrestdars_Click;
            // 
            // toolt
            // 
            toolt.BackColor = Color.SteelBlue;
            toolt.DropDownItems.AddRange(new ToolStripItem[] { tooltarifterm, toolfehrestterm });
            toolt.Name = "toolt";
            toolt.Size = new Size(102, 19);
            toolt.Text = "ترم ";
            toolt.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tooltarifterm
            // 
            tooltarifterm.BackColor = Color.SkyBlue;
            tooltarifterm.Name = "tooltarifterm";
            tooltarifterm.RightToLeft = RightToLeft.Yes;
            tooltarifterm.Size = new Size(143, 22);
            tooltarifterm.Text = "تعریف ترم";
            tooltarifterm.Click += tooltarifterm_Click;
            // 
            // toolfehrestterm
            // 
            toolfehrestterm.BackColor = Color.SkyBlue;
            toolfehrestterm.Name = "toolfehrestterm";
            toolfehrestterm.RightToLeft = RightToLeft.Yes;
            toolfehrestterm.Size = new Size(143, 22);
            toolfehrestterm.Text = "فهرست ترم ها";
            toolfehrestterm.Click += toolfehrestterm_Click;
            // 
            // دانشجویانToolStripMenuItem
            // 
            دانشجویانToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tooltarifdanesh, toolfehrestdanesh });
            دانشجویانToolStripMenuItem.Name = "دانشجویانToolStripMenuItem";
            دانشجویانToolStripMenuItem.Size = new Size(102, 19);
            دانشجویانToolStripMenuItem.Text = "دانشجویان";
            دانشجویانToolStripMenuItem.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tooltarifdanesh
            // 
            tooltarifdanesh.BackColor = Color.LightSkyBlue;
            tooltarifdanesh.Name = "tooltarifdanesh";
            tooltarifdanesh.RightToLeft = RightToLeft.Yes;
            tooltarifdanesh.Size = new Size(166, 22);
            tooltarifdanesh.Text = "تعریف دانشجو";
            tooltarifdanesh.Click += tooltarifdanesh_Click;
            // 
            // toolfehrestdanesh
            // 
            toolfehrestdanesh.BackColor = Color.SkyBlue;
            toolfehrestdanesh.Name = "toolfehrestdanesh";
            toolfehrestdanesh.RightToLeft = RightToLeft.Yes;
            toolfehrestdanesh.Size = new Size(166, 22);
            toolfehrestdanesh.Text = "فهرست دانشچویان";
            toolfehrestdanesh.Click += toolfehrestdanesh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(79, 166);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(545, 40);
            label1.TabIndex = 1;
            label1.Text = "به مجموعه آموزشی ویرا سیستم خوش آمدید!";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(808, 462);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tools;
        private ToolStripMenuItem دروسToolStripMenuItem;
        private ToolStripMenuItem toolt;
        private ToolStripMenuItem دانشجویانToolStripMenuItem;
        private ToolStripMenuItem tooltarifdars;
        private ToolStripMenuItem toolfehrestdars;
        private ToolStripMenuItem tooltarifterm;
        private ToolStripMenuItem toolfehrestterm;
        private ToolStripMenuItem tooltarifdanesh;
        private ToolStripMenuItem toolfehrestdanesh;
        private Label label1;
        private ToolStripMenuItem toolsabtname;
        private ToolStripMenuItem toolakharin;
    }
}