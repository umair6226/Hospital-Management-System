using Hospital_Project.DL;
using Sipaa.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Project.BL
{
    class BL_Main
    {
        public static Boolean IsAdmin=false;
        public static void GridViewStyle(DataGridView dataGridView1)
        {
            
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            //dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(242, 245, 246);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            //dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(242, 245, 246);
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = 0;
            dataGridView1.ColumnHeadersHeight = 35;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.RowTemplate.MinimumHeight = 40;
          
        }
        public static void checkint(System.Windows.Forms.KeyPressEventArgs e)
        {
            int i = (int)e.KeyChar;
            if (i == 8 || (i >= 48 && i <= 57 || i == 46))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        public static void clear(Form obj)
        {
            foreach (Control GB in obj.Controls)
            {
                if (GB is Panel)
                {
                    foreach (Control ctr in GB.Controls)
                    {
                        ClrItem(ctr);
                    }
                }
                if (GB is GroupBox)
                {
                    foreach (Control ctr in GB.Controls)
                    {
                        ClrItem(ctr);
                    }
                }
                ClrItem(GB);
            }
        }
        public static void clear2(UserControl obj)
        {
            foreach (Control GB in obj.Controls)
            {
                if (GB is Panel)
                {
                    foreach (Control ctr in GB.Controls)
                    {
                        
                        if (ctr is GroupBox)
                        {
                            foreach (Control ctr2 in ctr.Controls)
                            {
                                ClrItem(ctr2);
                            }
                        }
                        else
                        {
                            ClrItem(ctr);
                        }
                    }
                }
                if (GB is GroupBox)
                {
                    foreach (Control ctr in GB.Controls)
                    {
                        ClrItem(ctr);
                    }
                }
                ClrItem(GB);
            }
        }
        public static void ClrItem(Control ctr)
        {

            if (ctr is TextBox || ctr is MaskedTextBox || ctr is RichTextBox)
            {
                ctr.Text = "";
            }
            else  if (ctr is STextBox)
            {
                Sipaa.Framework.STextBox btn = (Sipaa.Framework.STextBox)ctr;
                btn.Texts = "";
            }
            else if (ctr is DateTimePicker)
            {
                DateTimePicker pk = (DateTimePicker)ctr;
                pk.Value = DateTime.Now;

            }
           
            else if (ctr is ComboBox)
            {
                ComboBox cmb = (ComboBox)ctr;
                cmb.SelectedIndex = -1;
            }
            else if (ctr is PictureBox)
            {
                PictureBox pb = (PictureBox)ctr;
                pb.Image = null;
            }
            else if (ctr is CheckBox)
            {
                CheckBox chk = (CheckBox)ctr;
                chk.Checked =false;
            }
            else if (ctr is RadioButton)
            {
                RadioButton rdb = (RadioButton)ctr;
                rdb.Checked = false;
            }
        }

        public static byte[] ImageToByte(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Png);
            byte[] bytes = ms.ToArray();
            return bytes;
        }
        public static Image ByteToImage(byte[] base64string)
        {
            // byte[] imagebytes = Convert.FromBase64String(base64string);
            byte[] imagebytes = base64string;
            // MemoryStream ms = new MemoryStream(imagebytes, 0, imagebytes.Length);
            // ms.Write(imagebytes, 0, imagebytes.Length);
            MemoryStream ms = new MemoryStream(imagebytes);
            return Image.FromStream(ms);
        }

        public DataTable GetData()
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Type", 5);
            return DataAccess.GetDataTable("SP_DashBoard", prm);
        }
        public string Data(int Type)
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Type", Type);
            DataTable dt =DataAccess.GetDataTable("SP_DashBoard", prm);
            if (dt.Rows.Count>0)
            {
                string Record = Convert.ToString(dt.Rows[0]["Total_No"]);
                return Record;
            }
            else
            {
                return "0";
            }
            
            
        }
        public DataTable FillComboBox(int Type, BL_Main obj)
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Type", Type);
            DataTable dt = DataAccess.GetDataTable("SP_ForComboBox", prm);

            return dt;

        }

        public DataTable LoadChart()
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Type", 6);
            DataTable dt = DataAccess.GetDataTable("SP_DashBoard", prm);
            return dt;
        }

    }
}
