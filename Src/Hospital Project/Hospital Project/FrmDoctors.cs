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
    public partial class FrmDoctors : UserControl
    {
        BL_Doctor obj = new BL_Doctor();
        public static Boolean Details;
        int DoctorID;
        public FrmDoctors()
        {
            InitializeComponent();
            txtCountry.Texts = "Pakistan";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            BL_Main.GridViewStyle(dataGridView1);
            if (Details==false)
            {
                pnlDetails.Visible = false;
                pnlRegistration.Visible = true;
            }
            else
            {
                pnlDetails.Visible = true;
                pnlRegistration.Visible = false;
                Load();
            }
            
        }
        public void Clear()
        {
            BL_Main.clear2(this);
        }
        public void FillProp(int id)
        {
            obj.DoctorID = id;
            obj.FirstName = txtFirstName.Texts;
            obj.LastName = txtLastName.Texts;
            obj.CNIC = txtCNIC.Texts;
            obj.Qualification = txtQualification.Texts;
            obj.Specialization = txtSpecialization.Texts;
            obj.Contact = txtPhoneNo.Texts;
            obj.Email = txtEmail.Texts;
            obj.Gender = cmbGender.Text;
            obj.Address = txtAddress.Texts;
            obj.City = txtCity.Texts;
            obj.Country = txtCountry.Texts;
            obj.DoctorFees = Convert.ToDouble(txtFees.Texts);
            obj.IsDeleted = 0;
            if (pictureBox1.Image==null)
            {
                obj.Image = BL_Main.ImageToByte(pictureBox1.BackgroundImage);
            }
            else
            {
                obj.Image = BL_Main.ImageToByte(pictureBox1.Image);
            }
        }
        public void Load()
        {
            dataGridView1.DataSource = obj.LoadData(obj);
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[15].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                pnlRegistration.Visible = true;
                pnlDetails.Visible = false;
                DoctorID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["DoctorID"].Value);
                txtFirstName.Texts = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["First_Name"].Value);
                txtLastName.Texts = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Last_Name"].Value);
                txtPhoneNo.Texts = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Contact"].Value);
                txtCNIC.Texts = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["CNIC"].Value);
                txtEmail.Texts = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Email"].Value);
                txtQualification.Texts = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Qualification"].Value);
                txtSpecialization.Texts = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Specialization"].Value);
                cmbGender.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Gender"].Value);
                txtCity.Texts = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["City"].Value);
                txtCountry.Texts = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Country"].Value);
                txtAddress.Texts = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Address"].Value);
                txtFees.Texts = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Doctor_Fees"].Value);
                byte[] img = (byte[])dataGridView1.Rows[e.RowIndex].Cells["Image"].Value;
                pictureBox1.Image = BL_Main.ByteToImage(img);
            }
            else if (e.ColumnIndex==1)
            {
                DialogResult result = MessageBox.Show("Want to Delete this Record ?","Confirmation",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
                if (result==DialogResult.Yes)
                {
                    DoctorID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["DoctorID"].Value);
                    obj.DoctorID = DoctorID;
                    obj.IsDeleted = 1;
                    BL_Doctor.Delete(obj);
                    Load();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ( txtFirstName.Texts==""||txtCNIC.Texts==""||txtPhoneNo.Texts=="" ||txtQualification.Texts==""||txtSpecialization.Texts==""||txtAddress.Texts==""||txtCity.Texts==""||cmbGender.SelectedIndex==-1)
            {
                MessageBox.Show("Please Fill all Empty Fields. ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (DoctorID == 0)
                {
                    FillProp(DoctorID);
                    obj.Save(obj);
                    MessageBox.Show("Doctor Record's Saved Successfully ");
                    Clear();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Update Record ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        FillProp(DoctorID);
                        obj.Save(obj);
                        MessageBox.Show("Record Updated Successfully. ");
                        Clear();
                    }
                }
            }
           
        }

        private void txtCNIC_KeyPress(object sender, KeyPressEventArgs e)
        {
            BL_Main.checkint(e);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog FD = new OpenFileDialog();
                FD.Filter = "JPEG Files (*.jpeg)|*.jpg|PNG Files (*.png)|*.png|GIF Files (*.gif)|*.gif|All Files(*.*)|*.*";
                if (FD.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.ImageLocation = FD.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
            txtCountry.Texts = "Pakistan";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Texts.Length > 0)
            {
                obj.FirstName = txtSearch.Texts;
                dataGridView1.DataSource = obj.SearchData(obj);
            }
            else
            {
                Load();
            }
        }
    }
}
