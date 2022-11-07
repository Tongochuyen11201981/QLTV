
namespace QLTV2022
{
    partial class Frm_Timsach
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
            this.grTimkiemsach = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtTensach = new System.Windows.Forms.TextBox();
            this.chkTensach = new System.Windows.Forms.RadioButton();
            this.chkMasach = new System.Windows.Forms.RadioButton();
            this.lbltimkiemsach = new System.Windows.Forms.Label();
            this.grTKS = new System.Windows.Forms.DataGridView();
            this.sACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTVDataSet = new QLTV2022.QLTVDataSet();
            this.sACHTableAdapter = new QLTV2022.QLTVDataSetTableAdapters.SACHTableAdapter();
            this.qLTVDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MASACH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSACH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAMXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOTRANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATHELOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comMasach = new System.Windows.Forms.ComboBox();
            this.grTimkiemsach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grTKS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grTimkiemsach
            // 
            this.grTimkiemsach.Controls.Add(this.comMasach);
            this.grTimkiemsach.Controls.Add(this.btnTim);
            this.grTimkiemsach.Controls.Add(this.btnThoat);
            this.grTimkiemsach.Controls.Add(this.txtTensach);
            this.grTimkiemsach.Controls.Add(this.chkTensach);
            this.grTimkiemsach.Controls.Add(this.chkMasach);
            this.grTimkiemsach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grTimkiemsach.Location = new System.Drawing.Point(836, 96);
            this.grTimkiemsach.Margin = new System.Windows.Forms.Padding(2);
            this.grTimkiemsach.Name = "grTimkiemsach";
            this.grTimkiemsach.Padding = new System.Windows.Forms.Padding(2);
            this.grTimkiemsach.Size = new System.Drawing.Size(486, 206);
            this.grTimkiemsach.TabIndex = 2;
            this.grTimkiemsach.TabStop = false;
            this.grTimkiemsach.Text = "Tìm kiếm sách";
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(247, 154);
            this.btnTim.Margin = new System.Windows.Forms.Padding(2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(81, 29);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(374, 154);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(81, 29);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // txtTensach
            // 
            this.txtTensach.Location = new System.Drawing.Point(141, 94);
            this.txtTensach.Margin = new System.Windows.Forms.Padding(2);
            this.txtTensach.Multiline = true;
            this.txtTensach.Name = "txtTensach";
            this.txtTensach.Size = new System.Drawing.Size(314, 32);
            this.txtTensach.TabIndex = 2;
            // 
            // chkTensach
            // 
            this.chkTensach.AutoSize = true;
            this.chkTensach.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTensach.Location = new System.Drawing.Point(32, 101);
            this.chkTensach.Margin = new System.Windows.Forms.Padding(2);
            this.chkTensach.Name = "chkTensach";
            this.chkTensach.Size = new System.Drawing.Size(99, 25);
            this.chkTensach.TabIndex = 1;
            this.chkTensach.TabStop = true;
            this.chkTensach.Text = "Tên sách";
            this.chkTensach.UseVisualStyleBackColor = true;
            // 
            // chkMasach
            // 
            this.chkMasach.AutoSize = true;
            this.chkMasach.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMasach.Location = new System.Drawing.Point(32, 38);
            this.chkMasach.Margin = new System.Windows.Forms.Padding(2);
            this.chkMasach.Name = "chkMasach";
            this.chkMasach.Size = new System.Drawing.Size(94, 25);
            this.chkMasach.TabIndex = 0;
            this.chkMasach.TabStop = true;
            this.chkMasach.Text = "Mã sách";
            this.chkMasach.UseVisualStyleBackColor = true;
            this.chkMasach.CheckedChanged += new System.EventHandler(this.chkTimtheomasach_CheckedChanged);
            // 
            // lbltimkiemsach
            // 
            this.lbltimkiemsach.AutoSize = true;
            this.lbltimkiemsach.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimkiemsach.Location = new System.Drawing.Point(562, 34);
            this.lbltimkiemsach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltimkiemsach.Name = "lbltimkiemsach";
            this.lbltimkiemsach.Size = new System.Drawing.Size(230, 31);
            this.lbltimkiemsach.TabIndex = 12;
            this.lbltimkiemsach.Text = "TÌM KIẾM SÁCH";
            // 
            // grTKS
            // 
            this.grTKS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grTKS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grTKS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grTKS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASACH,
            this.TENSACH,
            this.NAMXB,
            this.SOTRANG,
            this.MATHELOAI,
            this.MANXB,
            this.MATG});
            this.grTKS.Location = new System.Drawing.Point(23, 104);
            this.grTKS.Name = "grTKS";
            this.grTKS.RowHeadersWidth = 51;
            this.grTKS.RowTemplate.Height = 24;
            this.grTKS.Size = new System.Drawing.Size(745, 542);
            this.grTKS.TabIndex = 13;
            this.grTKS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grTKS_CellContentClick);
            // 
            // sACHBindingSource
            // 
            this.sACHBindingSource.DataMember = "SACH";
            this.sACHBindingSource.DataSource = this.qLTVDataSet;
            // 
            // qLTVDataSet
            // 
            this.qLTVDataSet.DataSetName = "QLTVDataSet";
            this.qLTVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sACHTableAdapter
            // 
            this.sACHTableAdapter.ClearBeforeFill = true;
            // 
            // qLTVDataSetBindingSource
            // 
            this.qLTVDataSetBindingSource.DataSource = this.qLTVDataSet;
            this.qLTVDataSetBindingSource.Position = 0;
            // 
            // MASACH
            // 
            this.MASACH.DataPropertyName = "MASACH";
            this.MASACH.HeaderText = "Mã sách";
            this.MASACH.MinimumWidth = 6;
            this.MASACH.Name = "MASACH";
            this.MASACH.Width = 90;
            // 
            // TENSACH
            // 
            this.TENSACH.DataPropertyName = "TENSACH";
            this.TENSACH.HeaderText = "Tên sách";
            this.TENSACH.MinimumWidth = 6;
            this.TENSACH.Name = "TENSACH";
            this.TENSACH.Width = 96;
            // 
            // NAMXB
            // 
            this.NAMXB.DataPropertyName = "NAMXB";
            this.NAMXB.HeaderText = "Năm XB";
            this.NAMXB.MinimumWidth = 6;
            this.NAMXB.Name = "NAMXB";
            this.NAMXB.Width = 88;
            // 
            // SOTRANG
            // 
            this.SOTRANG.DataPropertyName = "SOTRANG";
            this.SOTRANG.HeaderText = "Số trang";
            this.SOTRANG.MinimumWidth = 6;
            this.SOTRANG.Name = "SOTRANG";
            this.SOTRANG.Width = 91;
            // 
            // MATHELOAI
            // 
            this.MATHELOAI.DataPropertyName = "MATHELOAI";
            this.MATHELOAI.HeaderText = "Mã thể loại";
            this.MATHELOAI.MinimumWidth = 6;
            this.MATHELOAI.Name = "MATHELOAI";
            this.MATHELOAI.Width = 106;
            // 
            // MANXB
            // 
            this.MANXB.DataPropertyName = "MANXB";
            this.MANXB.HeaderText = "Mã NXB";
            this.MANXB.MinimumWidth = 6;
            this.MANXB.Name = "MANXB";
            this.MANXB.Width = 88;
            // 
            // MATG
            // 
            this.MATG.DataPropertyName = "MATG";
            this.MATG.HeaderText = "Mã tác giả";
            this.MATG.MinimumWidth = 6;
            this.MATG.Name = "MATG";
            this.MATG.Width = 102;
            // 
            // comMasach
            // 
            this.comMasach.FormattingEnabled = true;
            this.comMasach.Location = new System.Drawing.Point(141, 37);
            this.comMasach.Name = "comMasach";
            this.comMasach.Size = new System.Drawing.Size(314, 30);
            this.comMasach.TabIndex = 5;
            // 
            // Frm_Timsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 670);
            this.Controls.Add(this.grTKS);
            this.Controls.Add(this.lbltimkiemsach);
            this.Controls.Add(this.grTimkiemsach);
            this.Name = "Frm_Timsach";
            this.Text = "Frm_Timsach";
            this.Load += new System.EventHandler(this.Frm_Timsach_Load);
            this.grTimkiemsach.ResumeLayout(false);
            this.grTimkiemsach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grTKS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grTimkiemsach;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtTensach;
        private System.Windows.Forms.RadioButton chkTensach;
        private System.Windows.Forms.RadioButton chkMasach;
        private System.Windows.Forms.Label lbltimkiemsach;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridView grTKS;
        private QLTVDataSet qLTVDataSet;
        private System.Windows.Forms.BindingSource sACHBindingSource;
        private QLTVDataSetTableAdapters.SACHTableAdapter sACHTableAdapter;
        private System.Windows.Forms.BindingSource qLTVDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASACH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSACH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAMXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOTRANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATHELOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATG;
        private System.Windows.Forms.ComboBox comMasach;
    }
}