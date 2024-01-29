using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Secim
{
    public partial class FrmSecim : Form
    {
        public FrmSecim()
        {
            InitializeComponent();
        }

        private void lnklblYazilim_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Aakcayy");
        }

        private void btnSonuclar_Click(object sender, EventArgs e)
        {
            FrmSonuclar frs=new FrmSonuclar();
            frs.Show();
            this.Hide();
        }
        SqlConnection baglan=new SqlConnection(@"Data Source=KARTALPC\SQLEXPRESS03;Initial Catalog=Secim;Integrated Security=True");   
        private void FrmSecim_Load(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand il = new SqlCommand("Select IL From TBLSECIM ",baglan);
            SqlDataReader dr = il.ExecuteReader();
            while (dr.Read())
            {
                cbxIL.Items.Add(dr[0]);

               
            }
            baglan.Close();

           
        }

        private void cbxIL_SelectedIndexChanged(object sender, EventArgs e)
        {
            label8.Text = cbxIL.SelectedItem.ToString();
        }

        private void cbxILCE_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand ilce = new SqlCommand("Select ILCE From TBLSECIM where IL=@p1", baglan);
            ilce.Parameters.AddWithValue("@p1", label8.Text);
            SqlDataReader dt = ilce.ExecuteReader();
            if (dt.Read())
            {
               
                    cbxILCE.Items.Add(dt[0]);

                
            }
            else
            {
                MessageBox.Show("İl seçiniz.");
            }

            baglan.Close();
        }
    }
}
