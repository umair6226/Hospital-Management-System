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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            ToolTip tp = new ToolTip();
            tp.SetToolTip(btnClose, "Close");
            tp.SetToolTip(btnShowPassword, "Show Password");
            this.Size = new Size(475, 615);
            ShowLogin();
        }
        public void CheckLogin()
        {
            if (txtUserName.Texts == "" || txtPassword.Texts == "")
            {
                MessageBox.Show("Please Enter User Name and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BL_Users x = BL_Users.CheckLogin(txtUserName.Texts, txtPassword.Texts);
                if (x.UserID > 0)
                {
                    FrmAcounts.UserName = txtUserName.Texts;
                    FrmAcounts.Password = txtPassword.Texts;
                    FrmMain obj = new FrmMain();
                    obj.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Incorrect User Name or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Clear()
        {
            txtUserName.Texts = "";
            txtPassword.Texts = "";
            txtChkUserName.Texts = "";
            txtConfirmPassword.Texts = "";
            txtNewPassword.Texts = "";
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            CheckLogin();
        }

        private void btnLogin_MouseMove(object sender, MouseEventArgs e)
        {
            btnLogin.ForeColor = Color.White;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.CornflowerBlue;
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (btnShowPassword.IconChar==FontAwesome.Sharp.IconChar.Eye)
            {
                btnShowPassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                txtPassword.PasswordChar = false;
            }
            else
            {
                btnShowPassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
                txtPassword.PasswordChar = true;
            }
        }

        private void sButton1_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void ShowLogin()
        {
            Clear();
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox1.Size = new Size(395, 305);
            groupBox1.Location = new Point(38, 274);
        }
        public void ShowResetPassword()
        {
            Clear();
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox2.Size = new Size(395, 305);
            groupBox2.Location = new Point(38, 274);
        }
        private void btnForgetPass_Click(object sender, EventArgs e)
        {
            ShowResetPassword();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ShowLogin();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (iconButton1.IconChar == FontAwesome.Sharp.IconChar.Eye)
            {
                iconButton1.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                txtNewPassword.PasswordChar = false;
                txtConfirmPassword.PasswordChar = false;
            }
            else
            {
                iconButton1.IconChar = FontAwesome.Sharp.IconChar.Eye;
                txtNewPassword.PasswordChar = true;
                txtConfirmPassword.PasswordChar = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (txtChkUserName.Texts==""||txtNewPassword.Texts==""||txtConfirmPassword.Texts=="")
            {
                MessageBox.Show("Please Enter User Name and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtNewPassword.Texts == txtConfirmPassword.Texts)
                {
                    DataTable dt = BL_Users.CheckUsername(txtChkUserName.Texts);
                    if (dt.Rows.Count>0)
                    {
                        int UserId = Convert.ToInt32(dt.Rows[0]["UserID"]);
                        string UserName = Convert.ToString(dt.Rows[0]["UserName"]);
                        BL_Users.ChangePassword(UserId, UserName, txtNewPassword.Texts);
                        MessageBox.Show("Password Changed Successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                         MessageBox.Show("This User Name Does not exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("New password and Confirm Password is not same.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                CheckLogin();
            }
        }
    }
}
