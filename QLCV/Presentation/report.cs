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
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
        }

        private void report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.work' table. You can move, or remove it, as needed.
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.workTableAdapter.Fill(this.DataSet1.work, textBox1.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
