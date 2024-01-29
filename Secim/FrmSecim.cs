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

        
        SqlConnection baglan=new SqlConnection(@"Data Source=KARTALPC\SQLEXPRESS03;Initial Catalog=Secim;Integrated Security=True");   
        private void FrmSecim_Load(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand il = new SqlCommand("SELECT DISTINCT IL FROM TBLSECIM", baglan);
            SqlDataReader dr = il.ExecuteReader();
            while (dr.Read())
            {
                cbxIL.Items.Add(dr["IL"]);
            }
            baglan.Close();


        }

        private void cbxIL_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            cbxILCE.Items.Clear();

            
            string secilenIL = cbxIL.SelectedItem.ToString();

            if (!string.IsNullOrEmpty(secilenIL)) 
            {
                cbxILCE.Items.Clear();

                SqlCommand ilce = new SqlCommand("SELECT ILCE FROM TBLSECIM WHERE IL=@p1", baglan);
                ilce.Parameters.AddWithValue("@p1", secilenIL);

                baglan.Open();
                SqlDataReader dt = ilce.ExecuteReader();

               
                while (dt.Read())
                {
                    cbxILCE.Items.Add(dt["ILCE"].ToString());
                }

                baglan.Close();
            }
           
        }
        private void btnSonuclar_Click(object sender, EventArgs e)
        {
            FrmSonuclar frs = new FrmSonuclar();
            frs.il2 = cbxIL.SelectedItem.ToString(); 

            frs.Show();
            this.Hide();
        }


    }
}
