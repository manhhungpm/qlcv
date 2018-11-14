namespace QLCV.Presentation
{
    partial class report_CTNV
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txt_CTNV = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chitietStaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet3 = new QLCV.Presentation.DataSet3();
            this.chitietStaffTableAdapter = new QLCV.Presentation.DataSet3TableAdapters.chitietStaffTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chitietStaffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.chitietStaffBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLCV.Presentation.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 49);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(728, 398);
            this.reportViewer1.TabIndex = 0;
            // 
            // txt_CTNV
            // 
            this.txt_CTNV.Location = new System.Drawing.Point(132, 12);
            this.txt_CTNV.Name = "txt_CTNV";
            this.txt_CTNV.Size = new System.Drawing.Size(325, 20);
            this.txt_CTNV.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(498, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chitietStaffBindingSource
            // 
            this.chitietStaffBindingSource.DataMember = "chitietStaff";
            this.chitietStaffBindingSource.DataSource = this.DataSet3;
            // 
            // DataSet3
            // 
            this.DataSet3.DataSetName = "DataSet3";
            this.DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chitietStaffTableAdapter
            // 
            this.chitietStaffTableAdapter.ClearBeforeFill = true;
            // 
            // report_CTNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 447);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_CTNV);
            this.Controls.Add(this.reportViewer1);
            this.Name = "report_CTNV";
            this.Text = "Báo cáo công việc của nhân viên";
            this.Load += new System.EventHandler(this.report_CTNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chitietStaffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TextBox txt_CTNV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource chitietStaffBindingSource;
        private DataSet3 DataSet3;
        private DataSet3TableAdapters.chitietStaffTableAdapter chitietStaffTableAdapter;
    }
}