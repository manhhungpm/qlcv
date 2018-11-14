using QLCV.Business.PlanData;
using QLCV.Business.Work_PlanItem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLCV.Presentation
{
    //System.Windows.Forms.ComboBox cbx_phanloai = new System.Windows.Forms.ComboBox();
    public partial class DailyPlan : Form
    {
        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        private PlanData job;

        public PlanData Job
        {
            get { return job; }
            set { job = value; }
        }

        

        FlowLayoutPanel fPanel = new FlowLayoutPanel();
        

        public DailyPlan(DateTime date, PlanData job)
        {
            InitializeComponent();
           
            this.Date = date;
            this.Job = job;

            fPanel.Width = pnlJob.Width;
            fPanel.Height = pnlJob.Height;
            pnlJob.Controls.Add(fPanel);

            dtpkDate.Value = Date;
        }
        
        //public DailyPlan() { InitializeComponent(); }

        void ShowJobByDate(DateTime date)
        {
            fPanel.Controls.Clear();
            if (Job != null && Job.Job != null)
            {
                List<Dulieu> todayJob = GetJobByDay(date);
                for (int i = 0; i < todayJob.Count; i++)
                {
                    AddJob(todayJob[i]);
                }
            }
        }

        void AddJob(Dulieu job)
        {
            AJob aJob = new AJob(job);
            aJob.Edited += aJob_Edited;
            aJob.Deleted += aJob_Deleteed;

            fPanel.Controls.Add(aJob);
        }

        void aJob_Deleteed(object sender, EventArgs e)
        {
            AJob uc = sender as AJob;
            Dulieu job = uc.Job;

            fPanel.Controls.Remove(uc);
            Job.Job.Remove(job);
        }

        void aJob_Edited(object sender, EventArgs e)
        {
        }

        List<Dulieu> GetJobByDay(DateTime date)
        {
            return Job.Job.Where(p => p.WorkDate.Year == date.Year && p.WorkDate.Month == date.Month && p.WorkDate.Day == date.Day).ToList();
        }

        private void dtpkDate_ValueChanged(object sender, EventArgs e)
        {
            ShowJobByDate((sender as DateTimePicker).Value);
        }

        private void btnNextDay_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddDays(1);
        }

        private void btnPrevioursDay_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddDays(-1);
        }

        private void mnsiAddJob_Click(object sender, EventArgs e)
        {
            Dulieu item = new Dulieu() { WorkDate = dtpkDate.Value };
            Job.Job.Add(item);
            AddJob(item);
        }

        private void mnsiToDay_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = DateTime.Now;
        }

        private void DailyPlan_Load(object sender, EventArgs e)
        {
            cb_pl.Items.Add("BOSS");
            cb_pl.Items.Add("STAFF");
        }

        private void cb_pl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_pl.Text == "STAFF")
            {
                mnsiAddJob.Enabled = false;
            }
        }

        private void báoCáoCôngViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report report = new report();
            report.ShowDialog();
        }

        private void báoCáoChiTiếtCôngViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report_CTCV report1 = new report_CTCV();
            report1.ShowDialog();
        }

        private void báoCáoNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report_CTNV report2 = new report_CTNV();
            report2.ShowDialog();
        }
    }
}
