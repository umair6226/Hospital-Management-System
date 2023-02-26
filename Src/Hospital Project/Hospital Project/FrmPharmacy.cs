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
    public partial class FrmPharmacy : UserControl
    {
        BL_Pharmacy obj = new BL_Pharmacy();
        int ProductID;
        public FrmPharmacy()
        {
            InitializeComponent();
            BL_Main.GridViewStyle(dataGridView1);
            BL_Main.GridViewStyle(dataGridView2);
            Load();
            LoadExpired();
            cmbSelectCatgry.SelectedIndex = 0;
        }
        public void Load()
        {
            dataGridView1.DataSource = obj.LoadData(obj);
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].MinimumWidth = 380;
            dataGridView1.Columns[0].DisplayIndex = 7;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
        }
        public void LoadExpired()
        {
            dataGridView2.DataSource = obj.ExpiredMedic(obj);
            dataGridView2.Columns[0].DisplayIndex = 7;
            dataGridView2.Columns[1].Visible = false;
            dataGridView2.Columns[2].MinimumWidth = 380;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.None;
        }

        public void CheckAvalability()
        {
            obj.Quantity = Convert.ToInt32(txtQuantity.Value);
            obj.CheckAvalaible(obj);
        }

        public void Clear()
        {
            txtPrice.Value = 0;
            txtProName.Text = "";
            txtQuantity.Value = 0;
            cmbAvalaibilty.SelectedIndex = -1;
            cmbCategory.SelectedIndex = -1;
            dtExpiryDate.Value = DateTime.Now;
            ProductID = 0;
        }
        public void FillProp(int ID)
        {
            obj.ProductID = ID;
            obj.ProName = txtProName.Text;
            obj.Category = cmbCategory.Text;
            obj.Quantity = Convert.ToInt32(txtQuantity.Value);
            obj.Price = Convert.ToInt32(txtPrice.Value);
            obj.ExpiryDate = dtExpiryDate.Value;
            obj.Avalaibility = cmbAvalaibilty.Text;
        }

        private void sButton2_Click(object sender, EventArgs e)
        {
            if (txtProName.Text==""||txtPrice.Value==0||cmbCategory.Text==""||cmbAvalaibilty.Text=="")
            {
                MessageBox.Show("PLease Fill all Empty Fields","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                if (ProductID==0)
                {
                    FillProp(ProductID);
                    obj.Save(obj);
                    MessageBox.Show("New Product added in Stock", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Clear();
                }
                else if (ProductID>0)
                {
                    DialogResult result = MessageBox.Show("Make Changes ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        FillProp(ProductID);
                        obj.Save(obj);
                        CheckAvalability();
                        MessageBox.Show("Product Updated. ");
                        btnAdd.Text = "Add";
                    }
                }
                Clear();
                Load();
                LoadExpired();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==0)
            {
                btnAdd.Text = "Update";
                ProductID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ProductID"].Value);
                txtProName.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Name"].Value);
                cmbCategory.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Category"].Value);
                cmbAvalaibilty.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Avalaiblity"].Value);
                dtExpiryDate.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["Expiry_Date"].Value);
                txtQuantity.Value = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value);
                txtPrice.Value = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Price"].Value);
                this.metroTabPage1.Hide();
                this.metroTabPage2.Show();

            }
        }

        private void sTextBox1__TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Texts.Length > 0)
            {
                obj.Type = 5;
                obj.ProName = txtSearch.Texts;
                dataGridView1.DataSource = obj.SearchData(obj);
            }
            else
            {
                Load();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelectCatgry.SelectedIndex==0)
            {
                Load();
            }
            else
            {
                obj.Type = 6;
                obj.Category = cmbSelectCatgry.Text;
                dataGridView1.DataSource = obj.SearchData(obj);
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            
          
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                btnAdd.Text = "Update";
                ProductID = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["ProductID"].Value);
                txtProName.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells["Name"].Value);
                cmbCategory.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells["Category"].Value);
                cmbAvalaibilty.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells["Avalaiblity"].Value);
                dtExpiryDate.Value = Convert.ToDateTime(dataGridView2.Rows[e.RowIndex].Cells["Expiry_Date"].Value);
                txtQuantity.Value = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["Quantity"].Value);
                txtPrice.Value = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["Price"].Value);
                this.metroTabPage3.Hide();
                this.metroTabPage2.Show();
                Load();
                LoadExpired();
            }
        }
    }
}
