﻿
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
            this.grTimkiemsach = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lbltimkiemsach = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grTKS = new System.Windows.Forms.DataGridView();
            this.grTimkiemsach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grTKS)).BeginInit();
            this.SuspendLayout();
            // 
            // grTimkiemsach
            // 
            this.grTimkiemsach.Controls.Add(this.button1);
            this.grTimkiemsach.Controls.Add(this.btnThoat);
            this.grTimkiemsach.Controls.Add(this.txtTimkiem);
            this.grTimkiemsach.Controls.Add(this.radioButton2);
            this.grTimkiemsach.Controls.Add(this.radioButton1);
            this.grTimkiemsach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grTimkiemsach.Location = new System.Drawing.Point(836, 96);
            this.grTimkiemsach.Margin = new System.Windows.Forms.Padding(2);
            this.grTimkiemsach.Name = "grTimkiemsach";
            this.grTimkiemsach.Padding = new System.Windows.Forms.Padding(2);
            this.grTimkiemsach.Size = new System.Drawing.Size(486, 152);
            this.grTimkiemsach.TabIndex = 2;
            this.grTimkiemsach.TabStop = false;
            this.grTimkiemsach.Text = "Tìm kiếm sách";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(374, 104);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(81, 29);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(140, 51);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimkiem.Multiline = true;
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(314, 35);
            this.txtTimkiem.TabIndex = 2;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(32, 74);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(99, 25);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Tên sách";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(32, 38);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(94, 25);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Mã sách";
            this.radioButton1.UseVisualStyleBackColor = true;
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(247, 104);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // grTKS
            // 
            this.grTKS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grTKS.Location = new System.Drawing.Point(23, 104);
            this.grTKS.Name = "grTKS";
            this.grTKS.RowHeadersWidth = 51;
            this.grTKS.RowTemplate.Height = 24;
            this.grTKS.Size = new System.Drawing.Size(745, 542);
            this.grTKS.TabIndex = 13;
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
            this.grTimkiemsach.ResumeLayout(false);
            this.grTimkiemsach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grTKS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grTimkiemsach;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lbltimkiemsach;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grTKS;
    }
}