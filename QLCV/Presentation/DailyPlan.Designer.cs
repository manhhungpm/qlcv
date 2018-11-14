namespace QLCV.Presentation
{
    partial class DailyPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyPlan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPrevioursDay = new System.Windows.Forms.Button();
            this.btnNextDay = new System.Windows.Forms.Button();
            this.dtpkDate = new System.Windows.Forms.DateTimePicker();
            this.pnlJob = new System.Windows.Forms.Panel();
            this.mnsMain = new System.Windows.Forms.MenuStrip();
            this.mnsiAddJob = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsiToDay = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoCôngViệcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoChiTiếtCôngViệcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cb_pl = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.mnsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pnlJob);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 484);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnPrevioursDay);
            this.panel3.Controls.Add(this.btnNextDay);
            this.panel3.Controls.Add(this.dtpkDate);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(791, 27);
            this.panel3.TabIndex = 1;
            // 
            // btnPrevioursDay
            // 
            this.btnPrevioursDay.Location = new System.Drawing.Point(3, 1);
            this.btnPrevioursDay.Name = "btnPrevioursDay";
            this.btnPrevioursDay.Size = new System.Drawing.Size(75, 23);
            this.btnPrevioursDay.TabIndex = 3;
            this.btnPrevioursDay.Text = "Hôm qua";
            this.btnPrevioursDay.UseVisualStyleBackColor = true;
            this.btnPrevioursDay.Click += new System.EventHandler(this.btnPrevioursDay_Click);
            // 
            // btnNextDay
            // 
            this.btnNextDay.Location = new System.Drawing.Point(707, 1);
            this.btnNextDay.Name = "btnNextDay";
            this.btnNextDay.Size = new System.Drawing.Size(75, 23);
            this.btnNextDay.TabIndex = 2;
            this.btnNextDay.Text = "Ngày mai";
            this.btnNextDay.UseVisualStyleBackColor = true;
            this.btnNextDay.Click += new System.EventHandler(this.btnNextDay_Click);
            // 
            // dtpkDate
            // 
            this.dtpkDate.Location = new System.Drawing.Point(265, 4);
            this.dtpkDate.Name = "dtpkDate";
            this.dtpkDate.Size = new System.Drawing.Size(200, 20);
            this.dtpkDate.TabIndex = 1;
            this.dtpkDate.ValueChanged += new System.EventHandler(this.dtpkDate_ValueChanged);
            // 
            // pnlJob
            // 
            this.pnlJob.Location = new System.Drawing.Point(3, 32);
            this.pnlJob.Name = "pnlJob";
            this.pnlJob.Size = new System.Drawing.Size(791, 447);
            this.pnlJob.TabIndex = 0;
            // 
            // mnsMain
            // 
            this.mnsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsiAddJob,
            this.mnsiToDay,
            this.báoCáoCôngViệcToolStripMenuItem,
            this.báoCáoChiTiếtCôngViệcToolStripMenuItem,
            this.báoCáoNhânViênToolStripMenuItem});
            this.mnsMain.Location = new System.Drawing.Point(0, 0);
            this.mnsMain.Name = "mnsMain";
            this.mnsMain.Size = new System.Drawing.Size(809, 24);
            this.mnsMain.TabIndex = 1;
            this.mnsMain.Text = "menuStrip1";
            // 
            // mnsiAddJob
            // 
            this.mnsiAddJob.Name = "mnsiAddJob";
            this.mnsiAddJob.Size = new System.Drawing.Size(74, 20);
            this.mnsiAddJob.Text = "Thêm việc";
            this.mnsiAddJob.Click += new System.EventHandler(this.mnsiAddJob_Click);
            // 
            // mnsiToDay
            // 
            this.mnsiToDay.Name = "mnsiToDay";
            this.mnsiToDay.Size = new System.Drawing.Size(68, 20);
            this.mnsiToDay.Text = "Hôm nay";
            this.mnsiToDay.Click += new System.EventHandler(this.mnsiToDay_Click);
            // 
            // báoCáoCôngViệcToolStripMenuItem
            // 
            this.báoCáoCôngViệcToolStripMenuItem.Name = "báoCáoCôngViệcToolStripMenuItem";
            this.báoCáoCôngViệcToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.báoCáoCôngViệcToolStripMenuItem.Text = "Báo cáo công việc";
            this.báoCáoCôngViệcToolStripMenuItem.Click += new System.EventHandler(this.báoCáoCôngViệcToolStripMenuItem_Click);
            // 
            // báoCáoChiTiếtCôngViệcToolStripMenuItem
            // 
            this.báoCáoChiTiếtCôngViệcToolStripMenuItem.Name = "báoCáoChiTiếtCôngViệcToolStripMenuItem";
            this.báoCáoChiTiếtCôngViệcToolStripMenuItem.Size = new System.Drawing.Size(154, 20);
            this.báoCáoChiTiếtCôngViệcToolStripMenuItem.Text = "Báo cáo chi tiết công việc";
            this.báoCáoChiTiếtCôngViệcToolStripMenuItem.Click += new System.EventHandler(this.báoCáoChiTiếtCôngViệcToolStripMenuItem_Click);
            // 
            // báoCáoNhânViênToolStripMenuItem
            // 
            this.báoCáoNhânViênToolStripMenuItem.Name = "báoCáoNhânViênToolStripMenuItem";
            this.báoCáoNhânViênToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.báoCáoNhânViênToolStripMenuItem.Text = "Báo cáo nhân viên";
            this.báoCáoNhânViênToolStripMenuItem.Click += new System.EventHandler(this.báoCáoNhânViênToolStripMenuItem_Click);
            // 
            // cb_pl
            // 
            this.cb_pl.FormattingEnabled = true;
            this.cb_pl.Location = new System.Drawing.Point(642, 0);
            this.cb_pl.Name = "cb_pl";
            this.cb_pl.Size = new System.Drawing.Size(111, 21);
            this.cb_pl.TabIndex = 2;
            this.cb_pl.SelectedIndexChanged += new System.EventHandler(this.cb_pl_SelectedIndexChanged);
            // 
            // DailyPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 511);
            this.Controls.Add(this.cb_pl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mnsMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnsMain;
            this.Name = "DailyPlan";
            this.Text = "Công việc trong ngày";
            this.Load += new System.EventHandler(this.DailyPlan_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.mnsMain.ResumeLayout(false);
            this.mnsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPrevioursDay;
        private System.Windows.Forms.Button btnNextDay;
        private System.Windows.Forms.DateTimePicker dtpkDate;
        private System.Windows.Forms.Panel pnlJob;
        private System.Windows.Forms.MenuStrip mnsMain;
        private System.Windows.Forms.ToolStripMenuItem mnsiAddJob;
        private System.Windows.Forms.ToolStripMenuItem mnsiToDay;
        private System.Windows.Forms.ComboBox cb_pl;
        private System.Windows.Forms.ToolStripMenuItem báoCáoCôngViệcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoChiTiếtCôngViệcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoNhânViênToolStripMenuItem;
    }
}