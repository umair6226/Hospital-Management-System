
namespace Hospital_Project
{
    partial class FrmIPBilling
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.sPanel1 = new Sipaa.Framework.SPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sPanel2 = new Sipaa.Framework.SPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtRoomCharges = new Sipaa.Framework.STextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new Sipaa.Framework.STextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtOtherFees = new Sipaa.Framework.STextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtMedFees = new Sipaa.Framework.STextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtTreatmentFees = new Sipaa.Framework.STextBox();
            this.lbl12 = new System.Windows.Forms.Label();
            this.txtLabFees = new Sipaa.Framework.STextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDoctorFees = new Sipaa.Framework.STextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnTotal = new Sipaa.Framework.SButton();
            this.btnGenerateBill = new Sipaa.Framework.SButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDate = new Sipaa.Framework.STextBox();
            this.txtContact = new Sipaa.Framework.STextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGender = new Sipaa.Framework.STextBox();
            this.txtAdmissionDate = new Sipaa.Framework.STextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPName = new Sipaa.Framework.STextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRegistrationID = new Sipaa.Framework.STextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new Sipaa.Framework.SButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sPanel1.SuspendLayout();
            this.sPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1125, 10);
            this.panel3.TabIndex = 6;
            // 
            // sPanel1
            // 
            this.sPanel1.BackColor = System.Drawing.Color.White;
            this.sPanel1.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.sPanel1.BorderRadius = 6;
            this.sPanel1.BorderSize = 0;
            this.sPanel1.Controls.Add(this.label1);
            this.sPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sPanel1.ForeColor = System.Drawing.Color.White;
            this.sPanel1.Location = new System.Drawing.Point(0, 13);
            this.sPanel1.Name = "sPanel1";
            this.sPanel1.Size = new System.Drawing.Size(1125, 46);
            this.sPanel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "In Patient\'s Billing";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1125, 13);
            this.panel1.TabIndex = 4;
            // 
            // sPanel2
            // 
            this.sPanel2.BackColor = System.Drawing.Color.White;
            this.sPanel2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sPanel2.BorderRadius = 6;
            this.sPanel2.BorderSize = 0;
            this.sPanel2.Controls.Add(this.groupBox1);
            this.sPanel2.Controls.Add(this.panel4);
            this.sPanel2.Controls.Add(this.panel2);
            this.sPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sPanel2.ForeColor = System.Drawing.Color.White;
            this.sPanel2.Location = new System.Drawing.Point(0, 69);
            this.sPanel2.Name = "sPanel2";
            this.sPanel2.Size = new System.Drawing.Size(1125, 612);
            this.sPanel2.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.btnTotal);
            this.groupBox1.Controls.Add(this.btnGenerateBill);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.groupBox1.Size = new System.Drawing.Size(1045, 612);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Details";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.txtRoomCharges, 2, 6);
            this.tableLayoutPanel2.Controls.Add(this.label18, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.label15, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.txtTotalAmount, 2, 7);
            this.tableLayoutPanel2.Controls.Add(this.label21, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.txtOtherFees, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.label20, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.txtMedFees, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.label19, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtTreatmentFees, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbl12, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtLabFees, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.label17, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtDoctorFees, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label16, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label9, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label14, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label8, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label13, 0, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 181);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1035, 335);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // txtRoomCharges
            // 
            this.txtRoomCharges.BackColor = System.Drawing.SystemColors.Window;
            this.txtRoomCharges.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtRoomCharges.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txtRoomCharges.BorderRadius = 3;
            this.txtRoomCharges.BorderSize = 1;
            this.txtRoomCharges.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRoomCharges.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomCharges.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRoomCharges.Location = new System.Drawing.Point(728, 246);
            this.txtRoomCharges.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoomCharges.Multiline = false;
            this.txtRoomCharges.Name = "txtRoomCharges";
            this.txtRoomCharges.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtRoomCharges.PasswordChar = false;
            this.txtRoomCharges.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtRoomCharges.PlaceholderText = "";
            this.txtRoomCharges.Size = new System.Drawing.Size(302, 32);
            this.txtRoomCharges.TabIndex = 19;
            this.txtRoomCharges.Texts = "";
            this.txtRoomCharges.UnderlinedStyle = false;
            this.txtRoomCharges.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDoctorFees_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.DimGray;
            this.label18.Location = new System.Drawing.Point(159, 242);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(561, 40);
            this.label18.TabIndex = 18;
            this.label18.Text = "Room \\ Bed Charges";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DimGray;
            this.label15.Location = new System.Drawing.Point(4, 242);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(148, 40);
            this.label15.TabIndex = 17;
            this.label15.Text = "6";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotalAmount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTotalAmount.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txtTotalAmount.BorderRadius = 3;
            this.txtTotalAmount.BorderSize = 1;
            this.txtTotalAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotalAmount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotalAmount.Location = new System.Drawing.Point(728, 287);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalAmount.Multiline = false;
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTotalAmount.PasswordChar = false;
            this.txtTotalAmount.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTotalAmount.PlaceholderText = "";
            this.txtTotalAmount.Size = new System.Drawing.Size(302, 40);
            this.txtTotalAmount.TabIndex = 16;
            this.txtTotalAmount.Texts = "";
            this.txtTotalAmount.UnderlinedStyle = false;
            this.txtTotalAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDoctorFees_KeyPress);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.DimGray;
            this.label21.Location = new System.Drawing.Point(159, 283);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(561, 51);
            this.label21.TabIndex = 15;
            this.label21.Text = "Total Amount";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOtherFees
            // 
            this.txtOtherFees.BackColor = System.Drawing.SystemColors.Window;
            this.txtOtherFees.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtOtherFees.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txtOtherFees.BorderRadius = 3;
            this.txtOtherFees.BorderSize = 1;
            this.txtOtherFees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOtherFees.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtherFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOtherFees.Location = new System.Drawing.Point(728, 205);
            this.txtOtherFees.Margin = new System.Windows.Forms.Padding(4);
            this.txtOtherFees.Multiline = false;
            this.txtOtherFees.Name = "txtOtherFees";
            this.txtOtherFees.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtOtherFees.PasswordChar = false;
            this.txtOtherFees.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtOtherFees.PlaceholderText = "";
            this.txtOtherFees.Size = new System.Drawing.Size(302, 32);
            this.txtOtherFees.TabIndex = 14;
            this.txtOtherFees.Texts = "";
            this.txtOtherFees.UnderlinedStyle = false;
            this.txtOtherFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDoctorFees_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.DimGray;
            this.label20.Location = new System.Drawing.Point(159, 201);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(561, 40);
            this.label20.TabIndex = 13;
            this.label20.Text = "Other Charges";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMedFees
            // 
            this.txtMedFees.BackColor = System.Drawing.SystemColors.Window;
            this.txtMedFees.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMedFees.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txtMedFees.BorderRadius = 3;
            this.txtMedFees.BorderSize = 1;
            this.txtMedFees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMedFees.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMedFees.Location = new System.Drawing.Point(728, 164);
            this.txtMedFees.Margin = new System.Windows.Forms.Padding(4);
            this.txtMedFees.Multiline = false;
            this.txtMedFees.Name = "txtMedFees";
            this.txtMedFees.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMedFees.PasswordChar = false;
            this.txtMedFees.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMedFees.PlaceholderText = "";
            this.txtMedFees.Size = new System.Drawing.Size(302, 32);
            this.txtMedFees.TabIndex = 12;
            this.txtMedFees.Texts = "";
            this.txtMedFees.UnderlinedStyle = false;
            this.txtMedFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDoctorFees_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DimGray;
            this.label19.Location = new System.Drawing.Point(159, 160);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(561, 40);
            this.label19.TabIndex = 11;
            this.label19.Text = "Medicine Charges";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTreatmentFees
            // 
            this.txtTreatmentFees.BackColor = System.Drawing.SystemColors.Window;
            this.txtTreatmentFees.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTreatmentFees.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txtTreatmentFees.BorderRadius = 3;
            this.txtTreatmentFees.BorderSize = 1;
            this.txtTreatmentFees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTreatmentFees.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTreatmentFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTreatmentFees.Location = new System.Drawing.Point(728, 123);
            this.txtTreatmentFees.Margin = new System.Windows.Forms.Padding(4);
            this.txtTreatmentFees.Multiline = false;
            this.txtTreatmentFees.Name = "txtTreatmentFees";
            this.txtTreatmentFees.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTreatmentFees.PasswordChar = false;
            this.txtTreatmentFees.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTreatmentFees.PlaceholderText = "";
            this.txtTreatmentFees.Size = new System.Drawing.Size(302, 32);
            this.txtTreatmentFees.TabIndex = 10;
            this.txtTreatmentFees.Texts = "";
            this.txtTreatmentFees.UnderlinedStyle = false;
            this.txtTreatmentFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDoctorFees_KeyPress);
            // 
            // lbl12
            // 
            this.lbl12.AutoSize = true;
            this.lbl12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl12.ForeColor = System.Drawing.Color.DimGray;
            this.lbl12.Location = new System.Drawing.Point(159, 119);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(561, 40);
            this.lbl12.TabIndex = 9;
            this.lbl12.Text = "Treatment Charges";
            this.lbl12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLabFees
            // 
            this.txtLabFees.BackColor = System.Drawing.SystemColors.Window;
            this.txtLabFees.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtLabFees.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txtLabFees.BorderRadius = 3;
            this.txtLabFees.BorderSize = 1;
            this.txtLabFees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLabFees.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLabFees.Location = new System.Drawing.Point(728, 82);
            this.txtLabFees.Margin = new System.Windows.Forms.Padding(4);
            this.txtLabFees.Multiline = false;
            this.txtLabFees.Name = "txtLabFees";
            this.txtLabFees.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtLabFees.PasswordChar = false;
            this.txtLabFees.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtLabFees.PlaceholderText = "";
            this.txtLabFees.Size = new System.Drawing.Size(302, 32);
            this.txtLabFees.TabIndex = 8;
            this.txtLabFees.Texts = "";
            this.txtLabFees.UnderlinedStyle = false;
            this.txtLabFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDoctorFees_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DimGray;
            this.label17.Location = new System.Drawing.Point(159, 78);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(561, 40);
            this.label17.TabIndex = 7;
            this.label17.Text = "Lab Test Charges";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDoctorFees
            // 
            this.txtDoctorFees.BackColor = System.Drawing.SystemColors.Window;
            this.txtDoctorFees.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDoctorFees.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txtDoctorFees.BorderRadius = 3;
            this.txtDoctorFees.BorderSize = 1;
            this.txtDoctorFees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDoctorFees.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctorFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDoctorFees.Location = new System.Drawing.Point(728, 41);
            this.txtDoctorFees.Margin = new System.Windows.Forms.Padding(4);
            this.txtDoctorFees.Multiline = false;
            this.txtDoctorFees.Name = "txtDoctorFees";
            this.txtDoctorFees.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDoctorFees.PasswordChar = false;
            this.txtDoctorFees.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDoctorFees.PlaceholderText = "";
            this.txtDoctorFees.Size = new System.Drawing.Size(302, 32);
            this.txtDoctorFees.TabIndex = 6;
            this.txtDoctorFees.Texts = "";
            this.txtDoctorFees.UnderlinedStyle = false;
            this.txtDoctorFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDoctorFees_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DimGray;
            this.label16.Location = new System.Drawing.Point(159, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(561, 40);
            this.label16.TabIndex = 5;
            this.label16.Text = "Doctor Fees";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(727, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(304, 35);
            this.label9.TabIndex = 2;
            this.label9.Text = "Amount";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DimGray;
            this.label14.Location = new System.Drawing.Point(4, 201);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(148, 40);
            this.label14.TabIndex = 3;
            this.label14.Text = "5";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(4, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 40);
            this.label12.TabIndex = 3;
            this.label12.Text = "3";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(159, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(561, 35);
            this.label8.TabIndex = 1;
            this.label8.Text = "Particulars";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(4, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 35);
            this.label7.TabIndex = 0;
            this.label7.Text = "Sr.No";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(4, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 40);
            this.label10.TabIndex = 3;
            this.label10.Text = "1";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(4, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 40);
            this.label11.TabIndex = 4;
            this.label11.Text = "2";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(4, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(148, 40);
            this.label13.TabIndex = 4;
            this.label13.Text = "4";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(5, 168);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1035, 13);
            this.panel5.TabIndex = 5;
            // 
            // btnTotal
            // 
            this.btnTotal.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnTotal.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnTotal.BorderRadius = 6;
            this.btnTotal.BorderSize = 1;
            this.btnTotal.FlatAppearance.BorderSize = 0;
            this.btnTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotal.ForeColor = System.Drawing.Color.White;
            this.btnTotal.Location = new System.Drawing.Point(299, 528);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(131, 40);
            this.btnTotal.TabIndex = 4;
            this.btnTotal.Text = "Count Total ";
            this.btnTotal.UseVisualStyleBackColor = false;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnGenerateBill
            // 
            this.btnGenerateBill.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGenerateBill.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnGenerateBill.BorderRadius = 6;
            this.btnGenerateBill.BorderSize = 1;
            this.btnGenerateBill.FlatAppearance.BorderSize = 0;
            this.btnGenerateBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateBill.ForeColor = System.Drawing.Color.White;
            this.btnGenerateBill.Location = new System.Drawing.Point(162, 528);
            this.btnGenerateBill.Name = "btnGenerateBill";
            this.btnGenerateBill.Size = new System.Drawing.Size(131, 40);
            this.btnGenerateBill.TabIndex = 3;
            this.btnGenerateBill.Text = "Generate Bill";
            this.btnGenerateBill.UseVisualStyleBackColor = false;
            this.btnGenerateBill.Click += new System.EventHandler(this.btnGenerateBill_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel1.Controls.Add(this.txtDate, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtContact, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtGender, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtAdmissionDate, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtRegistrationID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1035, 140);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.SystemColors.Window;
            this.txtDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDate.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txtDate.BorderRadius = 3;
            this.txtDate.BorderSize = 1;
            this.txtDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDate.Location = new System.Drawing.Point(707, 5);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtDate.Multiline = false;
            this.txtDate.Name = "txtDate";
            this.txtDate.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDate.PasswordChar = false;
            this.txtDate.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDate.PlaceholderText = "";
            this.txtDate.Size = new System.Drawing.Size(323, 36);
            this.txtDate.TabIndex = 11;
            this.txtDate.Texts = "";
            this.txtDate.UnderlinedStyle = false;
            // 
            // txtContact
            // 
            this.txtContact.BackColor = System.Drawing.SystemColors.Window;
            this.txtContact.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtContact.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txtContact.BorderRadius = 3;
            this.txtContact.BorderSize = 1;
            this.txtContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContact.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtContact.Location = new System.Drawing.Point(707, 97);
            this.txtContact.Margin = new System.Windows.Forms.Padding(4);
            this.txtContact.Multiline = false;
            this.txtContact.Name = "txtContact";
            this.txtContact.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtContact.PasswordChar = false;
            this.txtContact.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtContact.PlaceholderText = "";
            this.txtContact.Size = new System.Drawing.Size(323, 36);
            this.txtContact.TabIndex = 10;
            this.txtContact.Texts = "";
            this.txtContact.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(561, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 46);
            this.label6.TabIndex = 9;
            this.label6.Text = "Patient Contact";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGender
            // 
            this.txtGender.BackColor = System.Drawing.SystemColors.Window;
            this.txtGender.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtGender.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txtGender.BorderRadius = 3;
            this.txtGender.BorderSize = 1;
            this.txtGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGender.Location = new System.Drawing.Point(232, 97);
            this.txtGender.Margin = new System.Windows.Forms.Padding(4);
            this.txtGender.Multiline = false;
            this.txtGender.Name = "txtGender";
            this.txtGender.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtGender.PasswordChar = false;
            this.txtGender.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtGender.PlaceholderText = "";
            this.txtGender.Size = new System.Drawing.Size(321, 36);
            this.txtGender.TabIndex = 8;
            this.txtGender.Texts = "";
            this.txtGender.UnderlinedStyle = false;
            // 
            // txtAdmissionDate
            // 
            this.txtAdmissionDate.BackColor = System.Drawing.SystemColors.Window;
            this.txtAdmissionDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAdmissionDate.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txtAdmissionDate.BorderRadius = 3;
            this.txtAdmissionDate.BorderSize = 1;
            this.txtAdmissionDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAdmissionDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdmissionDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAdmissionDate.Location = new System.Drawing.Point(707, 51);
            this.txtAdmissionDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdmissionDate.Multiline = false;
            this.txtAdmissionDate.Name = "txtAdmissionDate";
            this.txtAdmissionDate.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtAdmissionDate.PasswordChar = false;
            this.txtAdmissionDate.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAdmissionDate.PlaceholderText = "";
            this.txtAdmissionDate.Size = new System.Drawing.Size(323, 36);
            this.txtAdmissionDate.TabIndex = 6;
            this.txtAdmissionDate.Texts = "";
            this.txtAdmissionDate.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(561, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 45);
            this.label4.TabIndex = 5;
            this.label4.Text = "Admission Date";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPName
            // 
            this.txtPName.BackColor = System.Drawing.SystemColors.Window;
            this.txtPName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPName.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txtPName.BorderRadius = 3;
            this.txtPName.BorderSize = 1;
            this.txtPName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPName.Location = new System.Drawing.Point(232, 51);
            this.txtPName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPName.Multiline = false;
            this.txtPName.Name = "txtPName";
            this.txtPName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPName.PasswordChar = false;
            this.txtPName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPName.PlaceholderText = "";
            this.txtPName.Size = new System.Drawing.Size(321, 36);
            this.txtPName.TabIndex = 4;
            this.txtPName.Texts = "";
            this.txtPName.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(4, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 45);
            this.label3.TabIndex = 3;
            this.label3.Text = "Patient Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRegistrationID
            // 
            this.txtRegistrationID.BackColor = System.Drawing.SystemColors.Window;
            this.txtRegistrationID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtRegistrationID.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txtRegistrationID.BorderRadius = 3;
            this.txtRegistrationID.BorderSize = 1;
            this.txtRegistrationID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRegistrationID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistrationID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRegistrationID.Location = new System.Drawing.Point(232, 5);
            this.txtRegistrationID.Margin = new System.Windows.Forms.Padding(4);
            this.txtRegistrationID.Multiline = false;
            this.txtRegistrationID.Name = "txtRegistrationID";
            this.txtRegistrationID.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtRegistrationID.PasswordChar = false;
            this.txtRegistrationID.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtRegistrationID.PlaceholderText = "";
            this.txtRegistrationID.Size = new System.Drawing.Size(321, 36);
            this.txtRegistrationID.TabIndex = 1;
            this.txtRegistrationID.Texts = "";
            this.txtRegistrationID.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(4, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 45);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter Patient Registration ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(4, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 46);
            this.label5.TabIndex = 7;
            this.label5.Text = "Gender";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSearch.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnSearch.BorderRadius = 6;
            this.btnSearch.BorderSize = 1;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(568, 4);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnSearch.MaximumSize = new System.Drawing.Size(130, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(124, 39);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1085, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(40, 612);
            this.panel4.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(40, 612);
            this.panel2.TabIndex = 10;
            // 
            // FrmIPBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.sPanel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.sPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmIPBilling";
            this.Size = new System.Drawing.Size(1125, 681);
            this.sPanel1.ResumeLayout(false);
            this.sPanel1.PerformLayout();
            this.sPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private Sipaa.Framework.SPanel sPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Sipaa.Framework.SPanel sPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Sipaa.Framework.STextBox txtTotalAmount;
        private System.Windows.Forms.Label label21;
        private Sipaa.Framework.STextBox txtOtherFees;
        private System.Windows.Forms.Label label20;
        private Sipaa.Framework.STextBox txtMedFees;
        private System.Windows.Forms.Label label19;
        private Sipaa.Framework.STextBox txtTreatmentFees;
        private System.Windows.Forms.Label lbl12;
        private Sipaa.Framework.STextBox txtLabFees;
        private System.Windows.Forms.Label label17;
        private Sipaa.Framework.STextBox txtDoctorFees;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel5;
        private Sipaa.Framework.SButton btnTotal;
        private Sipaa.Framework.SButton btnGenerateBill;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Sipaa.Framework.STextBox txtDate;
        private Sipaa.Framework.STextBox txtContact;
        private System.Windows.Forms.Label label6;
        private Sipaa.Framework.STextBox txtGender;
        private Sipaa.Framework.STextBox txtAdmissionDate;
        private System.Windows.Forms.Label label4;
        private Sipaa.Framework.STextBox txtPName;
        private System.Windows.Forms.Label label3;
        private Sipaa.Framework.STextBox txtRegistrationID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private Sipaa.Framework.SButton btnSearch;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private Sipaa.Framework.STextBox txtRoomCharges;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
    }
}
