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
    public partial class FrmStaff : UserControl
    {
        BL_Staffs obj = new BL_Staffs();
        int ID;
        public FrmStaff()
        {
            InitializeComponent();
            BL_Main.GridViewStyle(dataGridView1);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            Load();
            pnlRegistration.Visible=false;
        }
        public void Load()
        {
            dataGridView1.DataSource = obj.LoadData(obj);
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[13].Visible = false;
        }
        public void Clear()
        {
            BL_Main.clear2(this);
        }
        public void FillProp(int id)
        {
            obj.StaffID = id;
            obj.Name = txtName.Texts;
            obj.CNIC = txtCNIC.Texts;
            obj.Qualification = txtQualification.Texts;
            obj.Contact = txtPhoneNo.Texts;
            obj.Email = txtEmail.Texts;
            obj.Gender = cmbGender.Text;
            obj.Post = cmbPost.Text;
            obj.Status = cmbStatus.Text;
            obj.Address = txtAddress.Texts;
            obj.IsDeleted = 0;
            if (pictureBox1.Image == null)
            {
                obj.Image = BL_Main.ImageToByte(pictureBox1.BackgroundImage);
            }
            else
            {
                obj.Image = BL_Main.ImageToByte(pictureBox1.Image);
            }
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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Texts == "" || txtCNIC.Texts == "" || txtPhoneNo.Texts == "" || txtQualification.Texts == "" ||  txtAddress.Texts == "" ||  cmbGender.SelectedIndex == -1|| cmbPost.SelectedIndex == -1 || cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please Fill all Empty Fields. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (ID == 0)
                {
                    FillProp(ID);
                    obj.Save(obj);
                    MessageBox.Show("Record's Saved Successfully ");
                    Clear();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Update Record ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        FillProp(ID);
                        obj.Save(obj);
                        MessageBox.Show("Record Updated Successfully. ");
                        Clear();
                    }
                }
                Load();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
                txtName.Texts = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Name"].Value);
                cmbPost.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Post"].Value);
                txtPhoneNo.Texts = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Contact"].Value);
                txtCNIC.Texts = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["CNIC"].Value);
                txtEmail.Texts = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Email"].Value);
                txtQualification.Texts = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Qualification"].Value);
                cmbStatus.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Status"].Value);
                cmbGender.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Gender"].Value);
                txtAddress.Texts = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Address"].Value);
                byte[] img = (byte[])dataGridView1.Rows[e.RowIndex].Cells["Image"].Value;
                pictureBox1.Image = BL_Main.ByteToImage(img);
                pnlRegistration.Visible = true;
            }
            else if (e.ColumnIndex == 1)
            {
                DialogResult result = MessageBox.Show("Want to Delete this Record ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["DoctorID"].Value);
                    obj.StaffID = ID;
                    obj.IsDeleted = 1;
                    BL_Staffs.Delete(obj);
                    Load();
                }
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (btnShow.IconChar==FontAwesome.Sharp.IconChar.AngleUp)
            {
                btnShow.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
                pnlRegistration.Hide();
            }
            else
            {
                btnShow.IconChar = FontAwesome.Sharp.IconChar.AngleUp;
                pnlRegistration.Show();
            }
        }
    }
}
