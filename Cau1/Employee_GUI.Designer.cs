namespace Cau1
{
    partial class Employee_GUI
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btThoat = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGioiTinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColNoiSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbDonVi = new System.Windows.Forms.ComboBox();
            this.cbGioiTinh = new System.Windows.Forms.CheckBox();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.tbNoiSinhh = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbMa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(668, 405);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(122, 24);
            this.btThoat.TabIndex = 79;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(540, 405);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(122, 24);
            this.btSua.TabIndex = 80;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(284, 405);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(122, 24);
            this.btThem.TabIndex = 82;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Đơn vị";
            // 
            // ColName
            // 
            this.ColName.HeaderText = "Họ Tên";
            this.ColName.Name = "ColName";
            this.ColName.Width = 150;
            // 
            // ColId
            // 
            this.ColId.HeaderText = "Mã";
            this.ColId.Name = "ColId";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColName,
            this.ColNgaySinh,
            this.ColGioiTinh,
            this.ColNoiSinh,
            this.ColDonVi});
            this.dataGridView1.Location = new System.Drawing.Point(14, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(773, 308);
            this.dataGridView1.TabIndex = 78;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // ColNgaySinh
            // 
            this.ColNgaySinh.HeaderText = "Ngày sinh";
            this.ColNgaySinh.Name = "ColNgaySinh";
            this.ColNgaySinh.Width = 150;
            // 
            // ColGioiTinh
            // 
            this.ColGioiTinh.HeaderText = "Giới tính";
            this.ColGioiTinh.Name = "ColGioiTinh";
            // 
            // ColNoiSinh
            // 
            this.ColNoiSinh.HeaderText = "Nơi sinh";
            this.ColNoiSinh.Name = "ColNoiSinh";
            this.ColNoiSinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColNoiSinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColNoiSinh.Width = 150;
            // 
            // ColDonVi
            // 
            this.ColDonVi.HeaderText = "Đơn vị";
            this.ColDonVi.Name = "ColDonVi";
            // 
            // cbDonVi
            // 
            this.cbDonVi.FormattingEnabled = true;
            this.cbDonVi.Location = new System.Drawing.Point(52, 53);
            this.cbDonVi.Name = "cbDonVi";
            this.cbDonVi.Size = new System.Drawing.Size(189, 21);
            this.cbDonVi.TabIndex = 77;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.AutoSize = true;
            this.cbGioiTinh.Location = new System.Drawing.Point(712, 24);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(48, 17);
            this.cbGioiTinh.TabIndex = 76;
            this.cbGioiTinh.Text = "Nam";
            this.cbGioiTinh.UseVisualStyleBackColor = true;
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgaySinh.Location = new System.Drawing.Point(558, 22);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(131, 20);
            this.dtNgaySinh.TabIndex = 75;
            // 
            // tbNoiSinhh
            // 
            this.tbNoiSinhh.Location = new System.Drawing.Point(301, 53);
            this.tbNoiSinhh.Name = "tbNoiSinhh";
            this.tbNoiSinhh.Size = new System.Drawing.Size(486, 20);
            this.tbNoiSinhh.TabIndex = 72;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(301, 22);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(189, 20);
            this.tbName.TabIndex = 73;
            // 
            // tbMa
            // 
            this.tbMa.Location = new System.Drawing.Point(52, 22);
            this.tbMa.Name = "tbMa";
            this.tbMa.Size = new System.Drawing.Size(189, 20);
            this.tbMa.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 67;
            this.label4.Text = "Nơi sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(496, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 68;
            this.label5.Text = "Ngày Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "Họ Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Mã";
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(412, 405);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(122, 24);
            this.btXoa.TabIndex = 81;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // Employee_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbDonVi);
            this.Controls.Add(this.cbGioiTinh);
            this.Controls.Add(this.dtNgaySinh);
            this.Controls.Add(this.tbNoiSinhh);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbMa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btXoa);
            this.Name = "Employee_GUI";
            this.Text = "Employee_GUI";
            this.Load += new System.EventHandler(this.Employee_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNgaySinh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNoiSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDonVi;
        private System.Windows.Forms.ComboBox cbDonVi;
        private System.Windows.Forms.CheckBox cbGioiTinh;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.TextBox tbNoiSinhh;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbMa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btXoa;
    }
}