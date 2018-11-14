namespace QLCV.Presentation
{
    partial class report_CTCV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(report_CTCV));
            this.chiTietWorkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet2 = new QLCV.Presentation.DataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txt_CTCV = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chiTietWorkTableAdapter = new QLCV.Presentation.DataSet2TableAdapters.chiTietWorkTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietWorkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // chiTietWorkBindingSource
            // 
            this.chiTietWorkBindingSource.DataMember = "chiTietWork";
            this.chiTietWorkBindingSource.DataSource = this.DataSet2;
            // 
            // DataSet2
            // 
            this.DataSet2.DataSetName = "DataSet2";
            this.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.chiTietWorkBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLCV.Presentation.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 61);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(809, 379);
            this.reportViewer1.TabIndex = 0;
            // 
            // txt_CTCV
            // 
            this.txt_CTCV.Location = new System.Drawing.Point(118, 15);
            this.txt_CTCV.Name = "txt_CTCV";
            this.txt_CTCV.Size = new System.Drawing.Size(324, 20);
            this.txt_CTCV.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(513, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chiTietWorkTableAdapter
            // 
            this.chiTietWorkTableAdapter.ClearBeforeFill = true;
            // 
            // report_CTCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 441);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_CTCV);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "report_CTCV";
            this.Text = "Báo cáo chi tiết công việc";
            this.Load += new System.EventHandler(this.report_CTCV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chiTietWorkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TextBox txt_CTCV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource chiTietWorkBindingSource;
        private DataSet2 DataSet2;
        private DataSet2TableAdapters.chiTietWorkTableAdapter chiTietWorkTableAdapter;
    }
}