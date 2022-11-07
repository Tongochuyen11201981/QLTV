
namespace QLTV2022
{
    partial class Frm_Timdocgia
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
            this.lbltimkiemdocgia = new System.Windows.Forms.Label();
            this.grTimkiemsach = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtTimDG = new System.Windows.Forms.TextBox();
            this.rabtnTenDG = new System.Windows.Forms.RadioButton();
            this.rabtnMaDG = new System.Windows.Forms.RadioButton();
            this.grTKDG = new System.Windows.Forms.DataGridView();
            this.grTimkiemsach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grTKDG)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltimkiemdocgia
            // 
            this.lbltimkiemdocgia.AutoSize = true;
            this.lbltimkiemdocgia.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimkiemdocgia.Location = new System.Drawing.Point(500, 35);
            this.lbltimkiemdocgia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltimkiemdocgia.Name = "lbltimkiemdocgia";
            this.lbltimkiemdocgia.Size = new System.Drawing.Size(273, 31);
            this.lbltimkiemdocgia.TabIndex = 14;
            this.lbltimkiemdocgia.Text = "TÌM KIẾM ĐỘC GIẢ";
            this.lbltimkiemdocgia.Click += new System.EventHandler(this.lbltimkiemdocgia_Click);
            // 
            // grTimkiemsach
            // 
            this.grTimkiemsach.Controls.Add(this.button1);
            this.grTimkiemsach.Controls.Add(this.btnThoat);
            this.grTimkiemsach.Controls.Add(this.txtTimDG);
            this.grTimkiemsach.Controls.Add(this.rabtnTenDG);
            this.grTimkiemsach.Controls.Add(this.rabtnMaDG);
            this.grTimkiemsach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grTimkiemsach.Location = new System.Drawing.Point(743, 97);
            this.grTimkiemsach.Margin = new System.Windows.Forms.Padding(2);
            this.grTimkiemsach.Name = "grTimkiemsach";
            this.grTimkiemsach.Padding = new System.Windows.Forms.Padding(2);
            this.grTimkiemsach.Size = new System.Drawing.Size(531, 186);
            this.grTimkiemsach.TabIndex = 13;
            this.grTimkiemsach.TabStop = false;
            this.grTimkiemsach.Text = "Tìm kiếm độc giả";
            this.grTimkiemsach.Enter += new System.EventHandler(this.grTimkiemsach_Enter);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(291, 113);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(415, 113);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(81, 29);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // txtTimDG
            // 
            this.txtTimDG.Location = new System.Drawing.Point(182, 60);
            this.txtTimDG.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimDG.Multiline = true;
            this.txtTimDG.Name = "txtTimDG";
            this.txtTimDG.Size = new System.Drawing.Size(314, 35);
            this.txtTimDG.TabIndex = 2;
            // 
            // rabtnTenDG
            // 
            this.rabtnTenDG.AutoSize = true;
            this.rabtnTenDG.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rabtnTenDG.Location = new System.Drawing.Point(32, 83);
            this.rabtnTenDG.Margin = new System.Windows.Forms.Padding(2);
            this.rabtnTenDG.Name = "rabtnTenDG";
            this.rabtnTenDG.Size = new System.Drawing.Size(120, 25);
            this.rabtnTenDG.TabIndex = 1;
            this.rabtnTenDG.TabStop = true;
            this.rabtnTenDG.Text = "Tên độc giả";
            this.rabtnTenDG.UseVisualStyleBackColor = true;
            // 
            // rabtnMaDG
            // 
            this.rabtnMaDG.AutoSize = true;
            this.rabtnMaDG.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rabtnMaDG.Location = new System.Drawing.Point(32, 47);
            this.rabtnMaDG.Margin = new System.Windows.Forms.Padding(2);
            this.rabtnMaDG.Name = "rabtnMaDG";
            this.rabtnMaDG.Size = new System.Drawing.Size(115, 25);
            this.rabtnMaDG.TabIndex = 0;
            this.rabtnMaDG.TabStop = true;
            this.rabtnMaDG.Text = "Mã độc giả";
            this.rabtnMaDG.UseVisualStyleBackColor = true;
            // 
            // grTKDG
            // 
            this.grTKDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grTKDG.Location = new System.Drawing.Point(23, 97);
            this.grTKDG.Name = "grTKDG";
            this.grTKDG.RowHeadersWidth = 51;
            this.grTKDG.RowTemplate.Height = 24;
            this.grTKDG.Size = new System.Drawing.Size(675, 560);
            this.grTKDG.TabIndex = 15;
            this.grTKDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grTKDG_CellContentClick);
            // 
            // Frm_Timdocgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 701);
            this.Controls.Add(this.grTKDG);
            this.Controls.Add(this.lbltimkiemdocgia);
            this.Controls.Add(this.grTimkiemsach);
            this.Name = "Frm_Timdocgia";
            this.Text = "Frm_Timdocgia";
            this.Load += new System.EventHandler(this.Frm_Timdocgia_Load);
            this.grTimkiemsach.ResumeLayout(false);
            this.grTimkiemsach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grTKDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltimkiemdocgia;
        private System.Windows.Forms.GroupBox grTimkiemsach;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtTimDG;
        private System.Windows.Forms.RadioButton rabtnTenDG;
        private System.Windows.Forms.RadioButton rabtnMaDG;
        private System.Windows.Forms.DataGridView grTKDG;
    }
}