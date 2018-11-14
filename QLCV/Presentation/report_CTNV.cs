using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCV.Presentation
{
    public partial class report_CTNV : Form
    {
        public report_CTNV()
        {
            InitializeComponent();
        }

        private void report_CTNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet3.chitietStaff' table. You can move, or remove it, as needed.
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.chitietStaffTableAdapter.Fill(this.DataSet3.chitietStaff,txt_CTNV.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
