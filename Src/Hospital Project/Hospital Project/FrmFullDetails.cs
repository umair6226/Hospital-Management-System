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
    public partial class FrmFullDetails : Form
    {
        BL_Patient obj = new BL_Patient();

        public FrmFullDetails()
        {
            InitializeComponent();
            obj.PatientID = FrmPatients.ID;
            obj.FullData(obj);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            Load();
        }

        public void Load()
        {
            lblName.Text = obj.FirstName + " " + obj.LastName;
            lblCNIC.Text = obj.CNIC;
            lblContact.Text = obj.Contact;
            lblAge.Text = Convert.ToString(obj.Age);
            lblEmail.Text = obj.Email;
            lblGender.Text = obj.Gender;
            lblBloodGroup.Text = obj.BloodGroup;
            lblAddress.Text = obj.Address+", "+obj.City+", "+obj.Country;
            lblChronicDiseses.Text = obj.ChronicDiseases;
            lblMoreDetails.Text = obj.MoreDetails;
            pictureBox1.Image = BL_Main.ByteToImage(obj.Picture);

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
