using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLTV2022
{
    public partial class Frm_Timsach : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable com2dt = new DataTable();
        String sql, constr;
       
       
        public Frm_Timsach()
        {
            InitializeComponent();
        }

        private void Frm_Timsach_Load(object sender, EventArgs e)
        {
            constr = @"Data Source=LAPTOP-KMAQIM21\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = " Select MASACH, TENSACH, NAMXB, SOTRANG, MATHELOAI, MANXB, MATG From SACH";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grTKS.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* string sql = "select* from SACH";
             SqlCommand cmd = new SqlCommand(sql, conn);
             cmd.Parameters.AddWithValue("TENSACH", txtTensach.Text);*/
            string sql = "Select* from SACH where MASACH = '%"+'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
        }


        private void chkTimtheomasach_CheckedChanged(object sender, EventArgs e)
        {
            if(chkMasach.Checked == true)
            {
                loadcomMasach();
            }
           
        }

        private void loadcomMasach()
        {
            string sql = "Select* from SACH";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comMasach.DataSource = dt;
            comMasach.ValueMember = dt.Columns["MASACH"].ToString();
            
        }

        private void chkTimtheotensach_CheckedChanged(object sender, EventArgs e)
        {
            /*if (chkMasach.Checked == true)
            {
                txtTensach.Text;
            }*/

        }
         



        private void grTKS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }
    }
}
