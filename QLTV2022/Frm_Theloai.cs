using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV2022
{
    public partial class Frm_Theloai : Form
    {
        public Frm_Theloai()
        {
            InitializeComponent();
        }
       
        private void Frm_Theloai_Load(object sender, EventArgs e)
        {
            
        }
        private void NapCT()
        {
           
        }

        private void grTL_SelectionChanged(object sender, EventArgs e)
        {
            
        }
        private void grTL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FrmMain();
            f.Show();
        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            grTL.ClearSelection();
            grTL.CurrentCell = grTL[0, 0];
            NapCT();
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            int i = grTL.CurrentRow.Index;
            if (i > 0)
            {
                grTL.CurrentCell = grTL[0, i - 1];
                NapCT();
            }
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            int i = grTL.CurrentRow.Index;
            if (i < grTL.RowCount - 1)
            {
                grTL.CurrentCell = grTL[0, i + 1];
                NapCT();
            }
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            grTL.ClearSelection();
            grTL.CurrentCell = grTL[0, grTL.RowCount - 1];
            NapCT();
        }
    }
}
    

