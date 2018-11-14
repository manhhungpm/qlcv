using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCV.Business.Work_PlanItem;

namespace QLCV.Presentation
{
    public partial class AJob : UserControl
    {


        private Dulieu job;

        public Dulieu Job
        {
            get { return job; }
            set { job = value; }
        }

        public string Luu1
        {
            get
            {
                return luu1;
            }

            set
            {
                luu1 = value;
            }
        }

        public string Luu2
        {
            get
            {
                return luu2;
            }

            set
            {
                luu2 = value;
            }
        }

        private event EventHandler edited;
        public event EventHandler Edited
        {
            add { edited += value; }
            remove { edited -= value; }
        }

        private event EventHandler deleted;
        public event EventHandler Deleted
        {
            add { deleted += value; }
            remove { deleted -= value; }
        }
        public AJob(Dulieu job)
        {
            InitializeComponent();

            cbStatus.DataSource = Dulieu.ListStatus;

            this.Job = job;

            ShowInfo();

        }

        void ShowInfo()
        {
            txbJob.Text = Job.WorkName;
            nmFromHours.Value = Job.FromTime.X;
            nmFromMinute.Value = Job.FromTime.Y;
            nmToHours.Value = Job.ToTime.X;
            nmToMinute.Value = Job.ToTime.Y;
            cbStatus.SelectedIndex = Dulieu.ListStatus.IndexOf(Job.WorkStatus);
            ckbDone.Checked = Dulieu.ListStatus.IndexOf(Job.WorkStatus) == (int)EPlanItem.DONE ? true : false;
            cb_pb.Text = Job.DepartmentName;
            cb_staff.Text = Job.StaffName;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (deleted != null)
                deleted(this, new EventArgs());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
           

            //Khai báo d? li?u Work
            Business.Work_PlanItem.Dulieu DT_Work = new Dulieu();
            Business.Work_PlanItem.Xulydulieu XLDL_Work = new Xulydulieu();

            //Khai báo d? li?u CTCV
            Business.CTCV.Dulieu DT_CTCV = new Business.CTCV.Dulieu();
            Business.CTCV.Xulydulieu XLDL_CTCV = new Business.CTCV.Xulydulieu();

            //Khai báo d? li?u CTNV
            Business.CTNV.Dulieu DT_CTNV = new Business.CTNV.Dulieu();
            Business.CTNV.Xulydulieu XLDL_CTNV = new Business.CTNV.Xulydulieu();

            Job.WorkName = txbJob.Text;
            Job.FromTime = new Point((int)nmFromHours.Value, (int)nmFromMinute.Value);
            Job.ToTime = new Point((int)nmToHours.Value, (int)nmToMinute.Value);
            Job.WorkStatus = Dulieu.ListStatus[cbStatus.SelectedIndex];
            Job.StaffName = cb_staff.Text;
            Job.DepartmentName = cb_pb.Text;

            DT_Work.WorkName = Job.WorkName;
            DT_Work.FromTime = Job.FromTime;
            DT_Work.ToTime = Job.ToTime;
            DT_Work.WorkStatus = Job.WorkStatus;
            DT_Work.WorkDate = Job.WorkDate;

            DT_CTCV.DepartmentName = cb_pb.Text;
            DT_CTCV.StaffName = cb_staff.Text;
            DT_CTCV.WorkName = Job.WorkName;
            
            DT_CTNV.WorkName = Job.WorkName;
            DT_CTNV.WorkStatus = Job.WorkStatus;
            DT_CTNV.StaffName = cb_staff.Text; 

            if (edited != null)
                edited(this, new EventArgs());

                XLDL_Work.Work_Insert(DT_Work);

                XLDL_CTCV.chitietCV_Insert(DT_CTCV);

                XLDL_CTNV.chitietNV_Insert(DT_CTNV);


        }

        private void ckbDone_CheckedChanged(object sender, EventArgs e)
        {
            cbStatus.SelectedIndex = ckbDone.Checked ? (int)EPlanItem.DONE : (int)EPlanItem.DOING;
        }

        QLCV.Business.Staff.Dulieu DL_Staff = new Business.Staff.Dulieu();
        QLCV.Business.Staff.Xulydulieu XLDL_Staff = new Business.Staff.Xulydulieu();

        QLCV.Business.Department.Dulieu DL_Department = new Business.Department.Dulieu();
        QLCV.Business.Department.Xulydulieu XLDL_Department = new Business.Department.Xulydulieu();

        private string luu1;
        private string luu2;
        private void cb_pb_SelectedIndexChanged(object sender, EventArgs e)
        {
            DL_Staff.DepartmentID = cb_pb.SelectedValue.ToString();
            cb_staff.DataSource = XLDL_Staff.staff_selectAllId(DL_Staff);
            cb_staff.DisplayMember = "StaffName";
            cb_staff.ValueMember = "StaffID";
            Luu1 = cb_pb.Text;
            Luu2 = cb_staff.Text;
        }

        private void AJob_Load(object sender, EventArgs e)
        {
            cb_pb.DisplayMember = "DepartmentName";
            cb_pb.ValueMember = "DepartmentID";
            cb_pb.DataSource = XLDL_Department.department_selectAll();
            cb_staff.Text = Luu2;
            cb_pb.Text = Luu1;
        }
    }
}
