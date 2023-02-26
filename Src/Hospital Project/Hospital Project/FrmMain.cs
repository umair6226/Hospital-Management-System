using FontAwesome.Sharp;
using Hospital_Project.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Project
{
    public partial class FrmMain : Form
    {
        BL_Main obj = new BL_Main();
        public FrmMain()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
            ToolTip tp = new ToolTip();
            tp.SetToolTip(btnClose,"Close");
            tp.SetToolTip(btnMinimize,"Minimze");
            tp.SetToolTip(btnAccounts,"My Accounts");
            tp.SetToolTip(btnLogout,"Log Out");
            PicArrow.Location = new Point(0, 0);
            LoadChart();
            LoadData();
            GridViewStyle(dataGridView1);
            
            //if (BL_Main.IsAdmin==true)
            //{
            //    btnDoctorRegistration.Visible = true;
            //}
            //else
            //{
            //    btnDoctorRegistration.Visible = false;
            //}
        }
        public void LoadData()
        {
            dataGridView1.DataSource = obj.GetData();
            lblPatients.Text = obj.Data(1);
            lblDoctors.Text = obj.Data(2);
            lblStaffs.Text = obj.Data(3);
            lblAdmitedPatients.Text = obj.Data(4);
        }
        public void LoadForm(object Form)
        {
            pnlMain.Controls.Clear();
            UserControl f = Form as UserControl;
            f.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(f);
            f.Show();
        }
        public void LoadChart()
        {
            DateTime Date;
            int Records,Day;
            DataTable dt = obj.LoadChart();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows.Count<=0)
                {
                    chart1.Series["No of Patients"].Points.AddXY(i, 0);
                }
                else
                {
                   
                    Date = Convert.ToDateTime(dt.Rows[i]["Date"]);
                    Records = Convert.ToInt32(dt.Rows[i]["Total_No"]);
                    chart1.Series["No of Patients"].Points.AddXY(Date.Day, Records);
                }
               
            }

            //chart1.Series["Patients"].Points.AddXY(1, 20);

            //chart1.Series["Patients"].Points.AddXY(2, 10);

            //chart1.Series["Patients"].Points.AddXY(3, 90);

            //chart1.Series["Patients"].Points.AddXY(4, 50);

            //chart1.Series["Patients"].Points.AddXY(5, 30);

            //chart1.Series["Patients"].Points.AddXY(6, 80);

            //chart1.Series["Patients"].Points.AddXY(7, 35);

            //chart1.Series["Patients"].Points.AddXY(8, 65);

            //chart1.Series["Patients"].Points.AddXY(9, 100);

            //chart1.Series["Patients"].Points.AddXY(10, 70);


            //chart1.Series["Patients"].Points.AddXY(11, 20);

            //chart1.Series["Patients"].Points.AddXY(12, 10);

            //chart1.Series["Patients"].Points.AddXY(13, 90);

            //chart1.Series["Patients"].Points.AddXY(14, 50);

            //chart1.Series["Patients"].Points.AddXY(15, 30);

            //chart1.Series["Patients"].Points.AddXY(16, 80);

            //chart1.Series["Patients"].Points.AddXY(17, 35);

            //chart1.Series["Patients"].Points.AddXY(18, 65);

            //chart1.Series["Patients"].Points.AddXY(19, 100);

            //chart1.Series["Patients"].Points.AddXY(20, 70);

            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
        }
        public void ChangeColor(object sender,EventArgs e)
        {
            foreach (Control C in pnlSideBar.Controls)
            {
                 if (C is FontAwesome.Sharp.IconButton)
                {
                    FontAwesome.Sharp.IconButton btn = (FontAwesome.Sharp.IconButton)C;
                    btn.ForeColor = Color.Silver;
                    btn.IconColor = Color.Silver;
                }
            }
            FontAwesome.Sharp.IconButton Click = (FontAwesome.Sharp.IconButton)sender;
            if (Click.ForeColor==Color.Silver)
            {
                Click.ForeColor = Color.CornflowerBlue;
                Click.IconColor = Color.CornflowerBlue;
            }
           
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(pnlDashBoard);
            ChangeColor(btnDashBoard, null);
            PicArrow.Location = new Point(0,0);
            LoadData();
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            ChangeColor(btnAppointments, null);
            LoadForm(new FrmAppointments());
            PicArrow.Location = new Point(0, 50);
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            FrmDoctors.Details = true;
            ChangeColor(btnDoctors, null);
            LoadForm(new FrmDoctors());
            PicArrow.Location = new Point(0, 100);
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            FrmPatients.Details = true;
            ChangeColor(btnPatients, null);
            LoadForm(new FrmPatients());
            PicArrow.Location = new Point(0, 150);
        }

       

        private void btnPatientRegistration_Click(object sender, EventArgs e)
        {
            FrmPatients.Details = false;
            ChangeColor(btnPatientRegistration, null);
            LoadForm(new FrmPatients());
            PicArrow.Location = new Point(0, -50);
        }

        private void btnDoctorRegistration_Click(object sender, EventArgs e)
        {
            FrmDoctors.Details = false;
            ChangeColor(btnDoctorRegistration, null);
            LoadForm(new FrmDoctors());
            PicArrow.Location = new Point(0, -50);
        }

        public static void GridViewStyle(DataGridView dataGridView1)
        {

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ReadOnly = true;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.RowTemplate.MinimumHeight = 50;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.ColumnHeadersHeightSizeMode = 0;
            dataGridView1.ColumnHeadersHeight = 35;
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            ChangeColor(btnPatientRegistration, null);
            LoadForm(new FrmStaff());
            PicArrow.Location = new Point(0, -50);
        }

        private void btnPharmacy_Click(object sender, EventArgs e)
        {
            ChangeColor(btnPharmacy, null);
            LoadForm(new FrmPharmacy());
            PicArrow.Location = new Point(0, 250);
        }

        private void btnPatientsVisit_Click(object sender, EventArgs e)
        {
            LoadForm(new FrmPatientVisit());
            ChangeColor(btnTreatment, null);
            PicArrow.Location = new Point(0, 200);
        }

        private void btnIPBilling_Click(object sender, EventArgs e)
        {
            ChangeColor(btnIPBilling, null);
            LoadForm(new FrmIPBilling());
            PicArrow.Location = new Point(0, 300);
        }

        private void btnOPBilling_Click(object sender, EventArgs e)
        {
            ChangeColor(btnOPBilling, null);
            LoadForm(new FrmOPBilling());
            PicArrow.Location = new Point(0, 350);
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            ChangeColor(btnDoctorRegistration, null);
            LoadForm(new FrmAcounts());
            PicArrow.Location = new Point(0, -50);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Want to Logout ?","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (result==DialogResult.Yes)
            {
                this.Close();
                FrmLogin frm = new FrmLogin();
                frm.ShowDialog();
            }
        }
    }
}
