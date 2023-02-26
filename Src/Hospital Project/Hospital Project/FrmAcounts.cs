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
    public partial class FrmAcounts : UserControl
    {
        BL_Users obj = new BL_Users();
        int UserID;
        public static string UserName, Password;
        public FrmAcounts()
        {
            InitializeComponent();
            pnlCreateAccount.Visible = false;
            btnAccountCreation.Visible = false;
            pnlAccountDetails.Visible = true;
            lblHeader.Text = "Account Details";
            LoadData();
        }

        public void FillProp(int ID)
        {
            obj.UserID = ID;
            obj.FirstName = txtFirstName.Texts;
            obj.LastName = txtLastName.Texts;
            obj.Contact = txtContact.Texts;
            obj.Email = txtEmail.Texts;
            obj.UserName = txtUserName.Texts;
            obj.Password = txtPassword.Texts;
            obj.AccountType = txtAcntType.Texts;
            obj.Status = txtStatus.Texts;
            obj.Gender = txtGender.Texts;
            if (txtAcntType.Texts=="Admin")
            {
                obj.IsAdmin = true;
            }
            else
            {
                obj.IsAdmin = false;
            }
        }
        public void Update(int ID)
        {
            obj.UserID = ID;
            obj.FirstName = txtShFName.Texts;
            obj.LastName = txtShLName.Texts;
            obj.Contact = txtShContact.Texts;
            obj.Email = txtShEmail.Texts;
            obj.UserName = txtShUserName.Texts;
            obj.Password = txtShPassword.Texts;
            obj.Gender = txtShGender.Texts;
        }
        public void LoadData()
        {
            
            BL_Users x = BL_Users.CheckLogin(UserName, Password);
            UserID = x.UserID;
            txtShFName.Texts = x.FirstName;
            txtShLName.Texts = x.LastName;
            txtShContact.Texts = x.Contact;
            txtShEmail.Texts = x.Email;
            txtShGender.Texts = x.Gender;
            txtShAcntType.Texts = x.AccountType;
            txtShUserName.Texts = x.UserName;
            txtShPassword.Texts = x.Password;
            if (x.IsAdmin==true)
            {
                btnAccountCreation.Visible = true;
            }
            else if (x.IsAdmin == true)
            {
                btnAccountCreation.Visible = false;
            }
        }
        private void btnShowPassword_Click(object sender, EventArgs e)
        {

            if (btnShowPassword.IconChar == FontAwesome.Sharp.IconChar.Eye)
            {
                btnShowPassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                txtPassword.PasswordChar = false;
                txtCnfrmPassword.PasswordChar = false;
            }
            else
            {
                btnShowPassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
                txtPassword.PasswordChar = true;
                txtCnfrmPassword.PasswordChar = true;
            }
        }

        private void btnAccountCreation_Click(object sender, EventArgs e)
        {
            pnlCreateAccount.Visible = true;
            pnlAccountDetails.Visible = false;
            lblHeader.Text = "Create New Account";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            BL_Main.clear2(this);
            pnlCreateAccount.Visible = false;
            pnlAccountDetails.Visible = true;
            lblHeader.Text = "Account Details";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Edit Account Details","Confirmation",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
            if (result==DialogResult.Yes)
            {
                Update(UserID);
                obj.Save(obj);
                LoadData();
            }
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            BL_Main.checkint(e);
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Texts==""|| txtLastName.Texts == "" || txtGender.Texts == "" || txtContact.Texts == "" || txtPassword.Texts == "" || txtCnfrmPassword.Texts == "" || txtAcntType.Texts == "" || txtStatus.Texts == "" || txtUserName.Texts == "" )
            {
                MessageBox.Show("Please Fill all emtpy fields","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (txtPassword.Texts == txtCnfrmPassword.Texts)
                {
                    DataTable dt = BL_Users.CheckUsername(txtUserName.Texts);
                    if (dt.Rows.Count>0)
                    {
                        MessageBox.Show("This User Name Already Exists \n Try a different User Name.", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        FillProp(0);
                        obj.Save(obj);
                        MessageBox.Show("Account Created Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Password and Confirm Password is not same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
           
        }
    }
}
