﻿
namespace QLTV2022
{
    partial class Frm_Docgia
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.txtMaDG = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comGioitinh = new System.Windows.Forms.ComboBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.lblGioitinh = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblNgaysinh = new System.Windows.Forms.Label();
            this.lblHoten = new System.Windows.Forms.Label();
            this.lblMadg = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grDMDG = new System.Windows.Forms.DataGridView();
            this.MADG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTENDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SODIENTHOAIDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qLTVDataSet = new QLTV2022.QLTVDataSet();
            this.dOCGIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dOCGIATableAdapter = new QLTV2022.QLTVDataSetTableAdapters.DOCGIATableAdapter();
            this.dOCGIABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnDau = new System.Windows.Forms.Button();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.btnSau = new System.Windows.Forms.Button();
            this.btnCuoi = new System.Windows.Forms.Button();
            this.gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grDMDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIABindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1596, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐỘC GIẢ";
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.txtMaDG);
            this.gb1.Controls.Add(this.dateTimePicker1);
            this.gb1.Controls.Add(this.comGioitinh);
            this.gb1.Controls.Add(this.txtSDT);
            this.gb1.Controls.Add(this.txtHoten);
            this.gb1.Controls.Add(this.lblGioitinh);
            this.gb1.Controls.Add(this.lblSDT);
            this.gb1.Controls.Add(this.lblNgaysinh);
            this.gb1.Controls.Add(this.lblHoten);
            this.gb1.Controls.Add(this.lblMadg);
            this.gb1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb1.Location = new System.Drawing.Point(1266, 131);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(781, 557);
            this.gb1.TabIndex = 1;
            this.gb1.TabStop = false;
            this.gb1.Text = "Cập nhật thông tin";
            this.gb1.Enter += new System.EventHandler(this.gb1_Enter);
            // 
            // txtMaDG
            // 
            this.txtMaDG.Location = new System.Drawing.Point(256, 88);
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.Size = new System.Drawing.Size(418, 44);
            this.txtMaDG.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(252, 335);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(418, 44);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.Value = new System.DateTime(2022, 11, 6, 21, 34, 57, 0);
            // 
            // comGioitinh
            // 
            this.comGioitinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comGioitinh.FormattingEnabled = true;
            this.comGioitinh.Location = new System.Drawing.Point(256, 251);
            this.comGioitinh.Name = "comGioitinh";
            this.comGioitinh.Size = new System.Drawing.Size(417, 44);
            this.comGioitinh.TabIndex = 13;
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(256, 416);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(418, 44);
            this.txtSDT.TabIndex = 10;
            // 
            // txtHoten
            // 
            this.txtHoten.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoten.Location = new System.Drawing.Point(256, 168);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(418, 44);
            this.txtHoten.TabIndex = 7;
            // 
            // lblGioitinh
            // 
            this.lblGioitinh.AutoSize = true;
            this.lblGioitinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioitinh.Location = new System.Drawing.Point(54, 260);
            this.lblGioitinh.Name = "lblGioitinh";
            this.lblGioitinh.Size = new System.Drawing.Size(129, 36);
            this.lblGioitinh.TabIndex = 5;
            this.lblGioitinh.Text = "Giới tính";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(54, 424);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(182, 36);
            this.lblSDT.TabIndex = 3;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // lblNgaysinh
            // 
            this.lblNgaysinh.AutoSize = true;
            this.lblNgaysinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaysinh.Location = new System.Drawing.Point(54, 342);
            this.lblNgaysinh.Name = "lblNgaysinh";
            this.lblNgaysinh.Size = new System.Drawing.Size(140, 36);
            this.lblNgaysinh.TabIndex = 2;
            this.lblNgaysinh.Text = "Ngày sinh";
            // 
            // lblHoten
            // 
            this.lblHoten.AutoSize = true;
            this.lblHoten.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoten.Location = new System.Drawing.Point(54, 170);
            this.lblHoten.Name = "lblHoten";
            this.lblHoten.Size = new System.Drawing.Size(137, 36);
            this.lblHoten.TabIndex = 1;
            this.lblHoten.Text = "Họ và tên";
            // 
            // lblMadg
            // 
            this.lblMadg.AutoSize = true;
            this.lblMadg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMadg.Location = new System.Drawing.Point(54, 92);
            this.lblMadg.Name = "lblMadg";
            this.lblMadg.Size = new System.Drawing.Size(157, 36);
            this.lblMadg.TabIndex = 0;
            this.lblMadg.Text = "Mã độc giả";
            this.lblMadg.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(1207, 724);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(126, 82);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(1375, 724);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(127, 82);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(1558, 724);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 82);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(1740, 724);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(126, 82);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(1921, 724);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(126, 82);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // grDMDG
            // 
            this.grDMDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grDMDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MADG,
            this.HOTENDG,
            this.GIOITINH,
            this.NGAYSINH,
            this.SODIENTHOAIDG});
            this.grDMDG.Location = new System.Drawing.Point(12, 53);
            this.grDMDG.Name = "grDMDG";
            this.grDMDG.RowHeadersWidth = 82;
            this.grDMDG.RowTemplate.Height = 33;
            this.grDMDG.Size = new System.Drawing.Size(1145, 635);
            this.grDMDG.TabIndex = 8;
            this.grDMDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grDMDG_CellClick);
            this.grDMDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grDMDG_CellContentClick);
            // 
            // MADG
            // 
            this.MADG.DataPropertyName = "MADG";
            this.MADG.HeaderText = "Mã độc giả";
            this.MADG.MinimumWidth = 10;
            this.MADG.Name = "MADG";
            this.MADG.Width = 200;
            // 
            // HOTENDG
            // 
            this.HOTENDG.DataPropertyName = "HOTENDG";
            this.HOTENDG.HeaderText = "Họ và tên";
            this.HOTENDG.MinimumWidth = 10;
            this.HOTENDG.Name = "HOTENDG";
            this.HOTENDG.Width = 200;
            // 
            // GIOITINH
            // 
            this.GIOITINH.DataPropertyName = "GIOITINH";
            this.GIOITINH.HeaderText = "Giới tính";
            this.GIOITINH.MinimumWidth = 10;
            this.GIOITINH.Name = "GIOITINH";
            this.GIOITINH.Width = 200;
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.DataPropertyName = "NGAYSINH";
            this.NGAYSINH.HeaderText = "Ngày Sinh";
            this.NGAYSINH.MinimumWidth = 10;
            this.NGAYSINH.Name = "NGAYSINH";
            this.NGAYSINH.Width = 200;
            // 
            // SODIENTHOAIDG
            // 
            this.SODIENTHOAIDG.DataPropertyName = "SODIENTHOAIDG";
            this.SODIENTHOAIDG.HeaderText = "Số điện thoại";
            this.SODIENTHOAIDG.MinimumWidth = 10;
            this.SODIENTHOAIDG.Name = "SODIENTHOAIDG";
            this.SODIENTHOAIDG.Width = 200;
            // 
            // qLTVDataSet
            // 
            this.qLTVDataSet.DataSetName = "QLTVDataSet";
            this.qLTVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dOCGIABindingSource
            // 
            this.dOCGIABindingSource.DataMember = "DOCGIA";
            this.dOCGIABindingSource.DataSource = this.qLTVDataSet;
            // 
            // dOCGIATableAdapter
            // 
            this.dOCGIATableAdapter.ClearBeforeFill = true;
            // 
            // dOCGIABindingSource1
            // 
            this.dOCGIABindingSource1.DataMember = "DOCGIA";
            this.dOCGIABindingSource1.DataSource = this.qLTVDataSet;
            // 
            // btnDau
            // 
            this.btnDau.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDau.Location = new System.Drawing.Point(13, 734);
            this.btnDau.Name = "btnDau";
            this.btnDau.Size = new System.Drawing.Size(112, 65);
            this.btnDau.TabIndex = 9;
            this.btnDau.Text = "Đầu";
            this.btnDau.UseVisualStyleBackColor = true;
            this.btnDau.Click += new System.EventHandler(this.btnDau_Click);
            // 
            // btnTruoc
            // 
            this.btnTruoc.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTruoc.Location = new System.Drawing.Point(158, 734);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(112, 65);
            this.btnTruoc.TabIndex = 10;
            this.btnTruoc.Text = "Trước";
            this.btnTruoc.UseVisualStyleBackColor = true;
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // btnSau
            // 
            this.btnSau.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSau.Location = new System.Drawing.Point(304, 734);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(112, 65);
            this.btnSau.TabIndex = 11;
            this.btnSau.Text = "Sau";
            this.btnSau.UseVisualStyleBackColor = true;
            this.btnSau.Click += new System.EventHandler(this.btnSau_Click);
            // 
            // btnCuoi
            // 
            this.btnCuoi.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuoi.Location = new System.Drawing.Point(451, 734);
            this.btnCuoi.Name = "btnCuoi";
            this.btnCuoi.Size = new System.Drawing.Size(112, 65);
            this.btnCuoi.TabIndex = 12;
            this.btnCuoi.Text = "Cuối";
            this.btnCuoi.UseVisualStyleBackColor = true;
            this.btnCuoi.Click += new System.EventHandler(this.btnCuoi_Click);
            // 
            // Frm_Docgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2125, 862);
            this.Controls.Add(this.btnCuoi);
            this.Controls.Add(this.btnSau);
            this.Controls.Add(this.btnTruoc);
            this.Controls.Add(this.btnDau);
            this.Controls.Add(this.grDMDG);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Docgia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_DOCGIA";
            this.Load += new System.EventHandler(this.Frm_Docgia_Load);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grDMDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIABindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Label lblMadg;
        private System.Windows.Forms.Label lblGioitinh;
        private System.Windows.Forms.Label lblNgaysinh;
        private System.Windows.Forms.Label lblHoten;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.ComboBox comGioitinh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.DataGridView grDMDG;
        private QLTVDataSet qLTVDataSet;
        private System.Windows.Forms.BindingSource dOCGIABindingSource;
        private QLTVDataSetTableAdapters.DOCGIATableAdapter dOCGIATableAdapter;
        private System.Windows.Forms.BindingSource dOCGIABindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADG;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTENDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SODIENTHOAIDG;
        private System.Windows.Forms.Button btnDau;
        private System.Windows.Forms.Button btnTruoc;
        private System.Windows.Forms.Button btnSau;
        private System.Windows.Forms.Button btnCuoi;
        private System.Windows.Forms.TextBox txtMaDG;
    }
}