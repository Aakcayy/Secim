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
        sqlbaglantisi baglan = new sqlbaglantisi();
        private void lnklblYazilim_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Aakcayy");
        }

        
        
        private void FrmSecim_Load(object sender, EventArgs e)
        {
         
            SqlCommand il = new SqlCommand("SELECT DISTINCT IL FROM TBLSECIM", baglan.baglanti());
            SqlDataReader dr = il.ExecuteReader();
            while (dr.Read())
            {
                cbxIL.Items.Add(dr["IL"]);
            }
         


        }

        private void cbxIL_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            cbxILCE.Items.Clear();

            
            string secilenIL = cbxIL.SelectedItem.ToString();

            if (!string.IsNullOrEmpty(secilenIL)) 
            {
                cbxILCE.Items.Clear();

                SqlCommand ilce = new SqlCommand("SELECT ILCE FROM TBLSECIM WHERE IL=@p1", baglan.baglanti());
                ilce.Parameters.AddWithValue("@p1", secilenIL);

                
                SqlDataReader dt = ilce.ExecuteReader();

               
                while (dt.Read())
                {
                    cbxILCE.Items.Add(dt["ILCE"].ToString());
                }

              
            }
           
        }
        private void btnSonuclar_Click(object sender, EventArgs e)
        {
            FrmSonuclar frs = new FrmSonuclar();
            frs.il2 = cbxIL.SelectedItem.ToString();
            frs.ilce2 = cbxILCE.SelectedItem.ToString();

            frs.Show();
            this.Hide();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand oy = new SqlCommand("Update TBLSECIM SET AParti=@p1,BParti=@p2,CParti=@p3,DParti=@p4,EParti=@p5 where IL=@p6 and ILCE=@p7", baglan.baglanti());
            oy.Parameters.AddWithValue("@p1",tbxAPARTI.Text);
            oy.Parameters.AddWithValue("@p2", tbxBParti.Text);
            oy.Parameters.AddWithValue("@p3", tbxCParti.Text);
            oy.Parameters.AddWithValue("@p4", tbxDParti.Text);
            oy.Parameters.AddWithValue("@p5", tbxEParti.Text);
            oy.Parameters.AddWithValue("@p6", cbxIL.SelectedItem.ToString());
            oy.Parameters.AddWithValue("@p7", cbxILCE.SelectedItem.ToString());
            oy.ExecuteNonQuery();
            MessageBox.Show("Güncelleme yapılmıştır");
        }
    }
}
