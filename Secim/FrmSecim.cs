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
            tbxAPARTI.Enabled = false;
            tbxBParti.Enabled = false;
            tbxCParti.Enabled = false;
            tbxDParti.Enabled = false;
            tbxEParti.Enabled = false;


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

                tbxAPARTI.Enabled = true;
                tbxBParti.Enabled = true;
                tbxCParti.Enabled = true;
                tbxDParti.Enabled = true;
                tbxEParti.Enabled = true;
            }
           

        }
        private void btnSonuclar_Click(object sender, EventArgs e)
        {
            if (cbxILCE.SelectedItem == null || cbxIL.SelectedItem == null)
            {
                MessageBox.Show("İL veya ilçe seçimi yapılmamıştır.");
            }
            else
            {
                FrmSonuclar frs = new FrmSonuclar();
                frs.il2 = cbxIL.SelectedItem.ToString();
                frs.ilce2 = cbxILCE.SelectedItem.ToString();

                frs.Show();
                this.Hide();
            }
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cbxILCE.SelectedItem == null || cbxIL.SelectedItem == null || tbxAPARTI.Text == "" || tbxBParti.Text == "" || tbxCParti.Text == "" || tbxDParti.Text == "" || tbxEParti.Text == "")
            {
                MessageBox.Show("Eksik veri girişi yapılmıştır.");
            }
            else 
            {
                SqlCommand guncelleme = new SqlCommand("SELECT AParti,BParti,CParti,DParti,EParti FROM TBLSECIM WHERE IL=@p1 and ILCE=@p2", baglan.baglanti());
                guncelleme.Parameters.AddWithValue("@p1", cbxIL.SelectedItem.ToString());
                guncelleme.Parameters.AddWithValue("@p2", cbxILCE.SelectedItem.ToString());
                SqlDataReader dt = guncelleme.ExecuteReader();
                while (dt.Read())
                {
                    
                    int eskiA = Convert.ToInt32(dt["AParti"]);
                    int eskiB = Convert.ToInt32(dt["BParti"]);
                    int eskiC = Convert.ToInt32(dt["CParti"]);
                    int eskiD = Convert.ToInt32(dt["DParti"]);
                    int eskiE = Convert.ToInt32(dt["EParti"]);
                    int yeniA = eskiA + Convert.ToInt32(tbxAPARTI.Text);
                    int yeniB = eskiB + Convert.ToInt32(tbxBParti.Text);
                    int yeniC = eskiC + Convert.ToInt32(tbxCParti.Text);
                    int yeniD = eskiD + Convert.ToInt32(tbxDParti.Text);
                    int yeniE = eskiE + Convert.ToInt32(tbxEParti.Text);

                    SqlCommand oy = new SqlCommand("Update TBLSECIM SET AParti=@p1,BParti=@p2,CParti=@p3,DParti=@p4,EParti=@p5 where IL=@p6 and ILCE=@p7", baglan.baglanti());

                    oy.Parameters.AddWithValue("@p1", yeniA);
                    oy.Parameters.AddWithValue("@p2", yeniB);
                    oy.Parameters.AddWithValue("@p3", yeniC);
                    oy.Parameters.AddWithValue("@p4", yeniD);
                    oy.Parameters.AddWithValue("@p5", yeniE);
                    oy.Parameters.AddWithValue("@p6", cbxIL.SelectedItem.ToString());
                    oy.Parameters.AddWithValue("@p7", cbxILCE.SelectedItem.ToString());
                    oy.ExecuteNonQuery();
                    MessageBox.Show("Güncelleme yapılmıştır");

                }
                tbxAPARTI.Text = "";
                tbxBParti.Text = "";
                tbxCParti.Text = "";
                tbxDParti.Text = "";
                tbxEParti.Text = "";
             }

        }
    }
}
